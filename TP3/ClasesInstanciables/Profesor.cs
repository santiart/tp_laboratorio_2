using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    public class Profesor : Universitario
    {
        private Queue<EClases> clasesDelDia;
        private static Random random;

        #region Methods

        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((EClases)Profesor.random.Next(1,4));
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + this.ParticiparEnClase();
        }

        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }

        public static bool operator ==(Profesor i, EClases clase)
        {
            EClases aux;

            if(!object.Equals(i,null) && !Object.Equals(clase,null))
            {
                for(int x = 0; x < i.clasesDelDia.Count; x++)
                {
                    aux = i.clasesDelDia.Dequeue();
                    i.clasesDelDia.Enqueue(aux);
                    if(aux == clase)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return object.Equals(i, clase);
            }
            throw new SinProfesorException();
        }

        protected override string ParticiparEnClase()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                EClases aux;
                sb.AppendFormat("CLASES DEL DÍA: ");
                for(int i = 0; i < this.clasesDelDia.Count; i++)
                {
                    aux = this.clasesDelDia.Dequeue();
                    sb.AppendFormat("\n{0}", aux.ToString());
                    this.clasesDelDia.Enqueue(aux);
                }
                return sb.ToString();
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public override string ToString()
        {
            return MostrarDatos();
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

        #region Constructors
        public Profesor() : base()
        {
        }

        static Profesor()
        {
            random = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<EClases>();
            for (int i = 0; i < 2; i++)
                this._randomClases();
        }
        #endregion
    }
}
