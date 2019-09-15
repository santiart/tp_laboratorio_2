using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        #region ATRIBUTO

        private double numero;

        #region PROPIEDAD
        /// <summary>
        /// setea el atributo "numero" del objeto Numero.
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        #endregion

        #endregion
        /// <summary>
        /// hace la conversion de binario a decimal
        /// </summary>
        /// <param name="binario">numero binario positivo</param>
        /// <returns>numero decimal como retorno</returns>
        public string BinarioDecimal(string binario)
        {
            double result = 0;
            string resultStr = "El Numero Ingresado es Invalido";
            int aux;

            if (int.TryParse(binario, out aux))
            {
                if (int.Parse(binario) > 0)
                {
                    for (int i = 1; i <= binario.Length; i++)
                    {
                        result += int.Parse(binario[i - 1].ToString()) * (int)(Math.Pow(2, (binario.Length - i)));
                    }
                    resultStr = result.ToString();
                }
                else if (int.Parse(binario) == 0)
                {
                    resultStr = "0";
                }
            }

            return resultStr;
        }

        /// <summary>
        /// hace la conversion de decimal a binario
        /// </summary>
        /// <param name="numero">numero tipo double</param>
        /// <returns>devuelve el numero ingresado en tipo binario como string</returns>
        public string DecimalBinario(double numero)
        {
            long entero;
            string resultadoStr = "El Valor Ingresado es Invalido";

            if (numero > 0 && numero < double.MaxValue)
            {
                entero = (long)numero;
                resultadoStr = "";
                while (entero != 0)
                {
                    resultadoStr = (entero % 2).ToString() + resultadoStr;
                    entero /= 2;
                }
            }
            else if (numero == 0)
            {
                resultadoStr = "0";
            }

            return resultadoStr;
        }

        /// <summary>
        /// hace la conversion de decimal a binario
        /// </summary>
        /// <param name="numeroStr">numero ingresado tipo string</param>
        /// <returns>devuelve el numero ingresado en binario de tipo string</returns>
        public string DecimalBinario(string numeroStr)
        {
            double aux;
            string retorno = "El Numero Ingresado es Invalido";

            if (double.TryParse(numeroStr, out aux))
            {
                retorno = this.DecimalBinario(double.Parse(numeroStr));
            }
            return retorno;
        }

        #region CONSTRUCTORES

        /// <summary>
        /// constructor de tipo Numero, inicializa los atributos en 0.
        /// </summary>
        public Numero() : this(0)
        {

        }

        /// <summary>
        /// constructor de tipo Numero, inicializa segun parametros.
        /// </summary>
        /// <param name="numero">recibe un numero de tipo double</param>
        public Numero(double numero):this(numero.ToString())
        {
        }

        /// <summary>
        /// constructor de tipo Numero, inicializa segun parametros.
        /// </summary>
        /// <param name="numero">recibe un numero de tipo string</param>
        public Numero(string numeroStr)
        {
            this.SetNumero = numeroStr;
        }

        #endregion

        #region SOBRECARGA DE OPERADORES

        /// <summary>
        /// realiza una resta entre objetos del tipo Numero
        /// </summary>
        /// <param name="num1">primer valor ingresado</param>
        /// <param name="num2">segundo valor ingresado</param>
        /// <returns></returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// realiza una multiplicacion entre objetos del tipo Numero
        /// </summary>
        /// <param name="num1">primer valor ingresado</param>
        /// <param name="num2">segundo dato ingresado</param>
        /// <returns></returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// realiza  una division entre objetos del tipo Numero
        /// </summary>
        /// <param name="num1">primer valor ingresado</param>
        /// <param name="num2">segundo valor ingresado</param>
        /// <returns></returns>
        public static double operator /(Numero num1, Numero num2)
        {
            double resultado;
            if (num2.numero != 0)
            {
                resultado = num1.numero / num2.numero;
            }
            else
            {
                resultado = double.MinValue;
            }

            return resultado;
        }

        /// <summary>
        /// realiza una suma entre objetos del tipo Numero
        /// </summary>
        /// <param name="num1">primer valor ingresado</param>
        /// <param name="num2">segundo valor ingresado</param>
        /// <returns></returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        #endregion

        #region METODO
        /// <summary>
        /// valida el numero ingresado como parametro
        /// </summary>
        /// <param name="strNumero">numero a validar</param>
        /// <returns>devuelve el numero que se ingreso o 0 en caso de error</returns>
        private double ValidarNumero(string strNumero)
        {
            double.TryParse(strNumero, out double returnValue);

            return returnValue;
        }

        #endregion
    }
}
