using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public class DniInvalidoException : Exception
    {
        private string mensajeBase;

        public DniInvalidoException() : this("Formato de DNI Invalido") { }

        public DniInvalidoException(Exception e) : this("Formato de DNI Invalido", e) { }

        public DniInvalidoException(string message) : base (message)
        {
            this.mensajeBase = message;
        }

        public DniInvalidoException(string message, Exception e) : base(message, e) { }
    }
}
