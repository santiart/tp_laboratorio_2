using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructors

        public Universitario() : base() { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj.GetType() == this.GetType())
                retorno = true;
            return retorno;
        }

        protected virtual string MostrarDatos()
        {
            return base.ToString() + "LEGAJO NÚMERO: " + this.legajo.ToString() + "\n";
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;

            if(!object.Equals(pg1,null) && !object.Equals(pg2,null))
            {
                if(pg1.GetType() == pg2.GetType() &&
                    pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        protected abstract string ParticiparEnClase();

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}
