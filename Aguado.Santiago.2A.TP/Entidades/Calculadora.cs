namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// realiza la operacion que se elija
        /// </summary>
        /// <param name="num1">primer valor ingresado</param>
        /// <param name="num2">segundo valor ingresado</param>
        /// <param name="operador">operacion a realizar</param>
        /// <returns>devuelve el resultado de la operacion que se pidio</returns>
        public double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno;

            switch (ValidarOperador(operador))
            {
                case "/":
                    retorno = num1 / num2;
                    break;

                case "-":
                    retorno = num1 - num2;
                    break;

                case "*":
                    retorno = num1 * num2;
                    break;

                case "+":
                    retorno = num1 + num2;
                    break;

                default:
                    retorno = num1 + num2;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// valida el operador ingresado como parametro
        /// </summary>
        /// <param name="operador">operador ingresado</param>
        /// <returns>devuelve el operador validado</returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";

            if (operador == "-")
                retorno = "-";
            else if (operador == "/")
                retorno = "/";
            else if (operador == "*")
                retorno = "*";

            return retorno;
        }
    }
}