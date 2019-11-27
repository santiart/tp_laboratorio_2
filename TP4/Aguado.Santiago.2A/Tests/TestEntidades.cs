using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Tests
{
    [TestClass]
    public class TestEntidades
    {
        [TestMethod]
        public void listaInstanciada()
        {
            Correo c = new Correo();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void TrackingIDRepetido()
        {
            Paquete p1 = new Paquete("dir1", "123456789");
            Paquete p2 = new Paquete("dir2", "123456789");
            Correo c = new Correo();

            c += p1;
            try
            {
                c += p2;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(TrackingIdRepetidoException));
            }
            Assert.Fail("ERROR, trackingID repetido: " + p2.TrackingID + "\n");
        }
    }
}
