using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo : IMostrar<Correo>
    {
        private List<Thread> mockPacketes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }

        public Correo()
        {
            this.mockPacketes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        public void FinEntregas()
        {
            foreach(Thread hilo in this.mockPacketes)
            {
                if (hilo.IsAlive)
                    hilo.Abort();
            }
        }

        public string MostrarDatos(IMostrar<Correo> elemento)
        {
            List<Paquete> lista2 = new List<Paquete>();
            StringBuilder sb = new StringBuilder();

            foreach(Paquete p in lista2)
            {
                sb.AppendFormat("{0} para {1} {2} \n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            }
            return sb.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            if(!object.Equals(c,null) && !object.Equals(p,null))
            {
                foreach(Paquete x in c.paquetes)
                {
                    if(x.Equals(p))
                    {
                        throw new TrackingIdRepetidoException("ID Repetido...\n");
                    }
                }
                Thread hilo = new Thread(p.MockCicloDeVida);
                c.Paquetes.Add(p);
                c.mockPacketes.Add(hilo);
                hilo.Start();
            }
            return c;
        }
    }
}
