using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClasesInstanciables.Universidad;
using Archivos;
using System.IO;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;

        #region Constructors

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(EClases clase, Profesor instructor): this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
            //this.alumnos = new List<Alumno>();
        }
        #endregion

        #region Properties

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }

        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }

        #endregion

        #region Methods

        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();

            string archivo = "Jornada.txt";

            try
            {
                return texto.Guardar(archivo, jornada.ToString());
            }
            catch(Exception e)
            {
                throw new Excepciones.ArchivosException(e);
            }
        }

        public static string Leer()
        {
            string retorno = "";

            if(File.Exists("Jornada.txt"))
            {
                Texto texto = new Texto();

                texto.Leer("Jornada.txt", out retorno);
            }

            return retorno;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j != a)
            {
                j.alumnos.Add(a);
            }
            return j;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            if(!object.Equals(j,null) && !object.Equals(a,null))
            {
                if(a == j.Clase)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASE DE " + this.Clase.ToString() + " POR " + this.Instructor.ToString() + "\n");
            sb.AppendLine("ALUMNOS: ");
            foreach(Alumno a in this.Alumnos)
            {
                sb.AppendLine(a.ToString()); 
            }
            return sb.ToString();
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
