using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using EntidadesAbstractas;
using Excepciones;
using System.Linq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProfesorCorrecto()
        {
            try
            {
                Profesor prof = new Profesor(1, "Santiago", "Aguado", "0", Persona.ENacionalidad.Argentino);
                Assert.Fail("No debe ingresar valores menores a 1");
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        [TestMethod]
        public void NacionalidadYDni()
        {
            try
            {
                Profesor prof = new Profesor(1, "Santiago", "Aguado", "91000000", Persona.ENacionalidad.Argentino);
                Assert.Fail("El DNI Argentino no debe superar el numero 90000000");
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        [TestMethod]
        public void DNILetras()
        {
            try
            {
                Profesor prof = new Profesor(1, "Santiago", "Aguado", "4505A3D1", Persona.ENacionalidad.Extranjero);
                Assert.Fail("El DNI no debe contener letras");
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        [TestMethod]
        public void UniversidadNull()
        {
            try
            {
                Universidad uni = new Universidad();
                Profesor prof = null;
                uni += prof;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NullReferenceException));
            }
        }

        [TestMethod]
        public void ProfRepetido()
        {
            Universidad uni = new Universidad();
            Profesor prof1 = new Profesor(1, "Santiago", "Aguado", "45326784", Persona.ENacionalidad.Argentino);
            Profesor prof2 = new Profesor(1, "Santiago", "Aguado", "45326784", Persona.ENacionalidad.Argentino);
            uni += prof1;
            uni += prof2;

            if(1 == uni.Instructores.Count())
            {
                Assert.Fail("ERROR: Profesor Repetido, Sin exception");
            }
        }
    }
}
