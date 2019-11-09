using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using EntidadesAbstractas;
using System.Linq;

namespace Profesor_Test.cs
{
    [TestClass]
    public class Universidad_Test
    {
        [TestMethod]
        public void UniversidadProfesorNull()
        {
            Universidad uni = new Universidad();
            try
            {
                Profesor profNull = null;
                uni += profNull;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NullReferenceException));
            }
        }

        [TestMethod]
        public void ProfesorRepetido()
        {
            Universidad uni = new Universidad();

            Profesor profA = new Profesor(1, "N", "A", "1", Persona.ENacionalidad.Argentino);
            Profesor profB = new Profesor(1, "N", "A", "1", Persona.ENacionalidad.Argentino);

            uni += profA;
            uni += profB;

            if(1 == uni.Instructores.Count())
            {
                Assert.Fail("Sin excepcion para profesor repetido");
            }
        }
    }
}
