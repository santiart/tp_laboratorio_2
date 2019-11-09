using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino,Extranjero}
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #region Properties
        public string Apellido
        {
            get { return this.apellido; }

            set
            {
                if(value is string)
                this.apellido = ValidarNombreApellido(value);
            }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }

            set
            {
                if(value is string)
                this.nombre = ValidarNombreApellido(value);
            }
        }

        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        #endregion

        #region Constructors

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad) : this(nombre, apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("NOMBRE COMPLETO: {0}, {1} \nNACIONALIDAD: {2}\n\n",this.Apellido, this.Nombre, this.Nacionalidad.ToString());
        }

        private static int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            int retorno = -1;

            if(nacionalidad == ENacionalidad.Argentino)
            {
                if(dato > 0 && dato < 90000000)
                {
                    retorno = dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            else if(nacionalidad == ENacionalidad.Extranjero)
            {
                if(dato >= 90000000 && dato <= 99999999)
                {
                    retorno = dato;
                }
                else
                {
                    throw (new NacionalidadInvalidaException());
                }
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }

            return retorno;
        }

        private static int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = -1;

            if(!object.Equals(nacionalidad,null) && !object.Equals(dato,null))
            {
                foreach(char c in dato)
                {
                    if(!char.IsDigit(c))
                    {
                        throw new DniInvalidoException();
                    }
                    retorno = ValidarDni(nacionalidad, int.Parse(dato));
                }
            }
            else
            {
                throw new DniInvalidoException();
            }
            return retorno;
        }

        private string ValidarNombreApellido(string dato)
        {
            string retorno = "";
            foreach (char car in dato)
            {
                if (!char.IsLetter(car))
                    throw new Exception("Caracteres no validos");
                retorno = dato;
            }
            return retorno;
        }

        #endregion
    }
}
