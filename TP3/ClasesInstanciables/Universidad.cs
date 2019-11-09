using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD };
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        #region Constructor

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }

        #endregion

        #region Properties
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }

        #endregion

        #region Methods

        public static bool Guardar(Universidad uni)
        {
            bool retorno = false;

            if(!object.Equals(uni,null))
            {
                Xml<Universidad> xml = new Xml<Universidad>();
                retorno = xml.Guardar("Universidad.xml", uni);
            }
            return retorno;
        }

        public static Universidad Leer()
        {
            Universidad uni = null;

            if(File.Exists("Universidad.xml"))
            {
                Xml<Universidad> xml = new Xml<Universidad>();
                xml.Leer("Universidad.xml", out uni);
            }

            return uni;
        }

        private static string MostrarDatos(Universidad uni)
        {
            string retorno = "";
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("JORNADA: ");
                foreach(Jornada j in uni.Jornadas)
                {
                    sb.AppendLine(j.ToString());
                    sb.AppendLine("<------------------------------------------------>\n");
                }
                retorno = sb.ToString();
                return retorno;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        #endregion

        #region Operators Overload

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            if (!object.Equals(u, null) && !object.Equals(clase, null))
            {
                foreach (Profesor p in u.Instructores)
                {
                    if (p != clase)
                    {
                        return p;
                    }
                }
                throw new SinProfesorException();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            if(!object.Equals(g,null) && !object.Equals(a,null))
            {
                foreach(Alumno s in g.alumnos)
                {
                    if(s == a)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
            return retorno;
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            if (!object.Equals(g, null) && !object.Equals(i, null))
            {
                foreach (Profesor p in g.Instructores)
                {
                    if (p == i)
                    {
                        retorno = true;
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
            return retorno;
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor retorno = null;

            if (!object.Equals(u, null) && !object.Equals(clase, null))
            {
                foreach (Profesor p in u.Instructores)
                {
                    if (p == clase)
                    {
                        retorno = p;
                    }
                    else
                    {
                        throw (new SinProfesorException());
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
            return retorno;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if(u != a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw (new AlumnoRepetidoException());
            }
            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if(u != i)
            {
                u.profesores.Add(i);
            }
            return u;
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j = new Jornada(clase, g == clase);
            Alumno a;
            for(int i = 0; i < g.Alumnos.Count; i++)
            {
                a = g.Alumnos[i];
                if(a == clase)
                {
                    j.Alumnos.Add(a);
                }
            }
            g.Jornadas.Add(j);

            return g;
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
