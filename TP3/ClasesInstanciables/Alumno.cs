using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using static EntidadesAbstractas.Persona;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta { AlDia, Deudor, Becado}
        private EClases claseQueToma;
        private EEstadoCuenta estadoDeCuenta;

        #region Constructors

        public Alumno() : base() { }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma) : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoDeCuenta) : this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoDeCuenta = estadoDeCuenta;
        }

        #endregion

        #region Methods
        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + "\n ESTADO DE CUENTA: " + this.estadoDeCuenta.ToString() + "\n" + ParticiparEnClase();
        }

        public static bool operator !=(Alumno a, EClases clase)
        {
            bool retorno = false;
            if (a.claseQueToma != clase)
                retorno = true;
            return retorno;
        }

        public static bool operator ==(Alumno a, EClases clase)
        {
            bool retorno = false;

            if(!object.Equals(a,null))
            {
                if(a.claseQueToma == clase && a.estadoDeCuenta != EEstadoCuenta.Deudor)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        protected override string ParticiparEnClase()
        {
            return ("TOMA  CLASE DE " + this.claseQueToma.ToString() + " \n");
        }

        public override string ToString()
        {
            return this.MostrarDatos();
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
