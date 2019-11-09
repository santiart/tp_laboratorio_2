using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using EntidadesAbstractas;
using Excepciones;

namespace Clases_Instanciables_Test
{
    [TestClass]
    public class Profesor_Test
    {
        [TestMethod]
        public void ProfesorCorrecto()
        {
            try
            {
                Profesor prof = new Profesor(1, "Santiago", "Apellido", "0",Persona.ENacionalidad.Argentino);
                Assert.Fail("No se Deben Ingresar Valores Menores a 1 \n");
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        [TestMethod]
        public void NacionalidadYDNI()
        {
            try
            {
                Profesor prof2 = new Profesor(1, "Santiago","Aguado","90000000",Persona.ENacionalidad.Argentino);
                Assert.Fail("El DNI no puede ser mayor a 89999999 si es Argentino");
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        [TestMethod]
        public void ToStringTest()
        {
            try
            {
                Profesor prof3 = new Profesor(1,"Santiago","Aguado","856AB542", Persona.ENacionalidad.Argentino);
                Assert.Fail("No debe permitir el ingreso de letras");
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }
    }
}
