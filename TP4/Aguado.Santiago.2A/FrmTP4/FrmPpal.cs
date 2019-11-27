using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmTP4
{
    public partial class FrmPpal : Form
    {
        private Correo correo;

        private void ActualizarEstado()
        {
            this.lstEstadoIngresado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();

            foreach(Paquete p in this.correo.Paquetes)
            {
                if(p.Estado == Paquete.EEstado.EnViaje)
                {
                    this.lstEstadoEnViaje.Items.Add(p);
                }
                else if(p.Estado == Paquete.EEstado.Ingresado)
                {
                    this.lstEstadoIngresado.Items.Add(p);
                }
                else
                {
                    this.lstEstadoEntregado.Items.Add(p);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete(this.txtDireccion.Text, this.mtxtTrackingId.Text);
            paquete.InformaEstado += this.paq_InformaEstado;

            try
            {
                this.correo += paquete;
            }
            catch(TrackingIdRepetidoException)
            {
                MessageBox.Show("Ya existe el tracking ID " + this.mtxtTrackingId.Text);
            }

            this.ActualizarEstado();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        public FrmPpal()
        {
            correo = new Correo();

            FormClosing += FrmPpal_FormClosing;

            InitializeComponent();
        }

        private void FrmPpal_FormClosing(object sender, EventArgs e)
        {
            this.correo.FinEntregas();
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(elemento != null)
            {
                string dato = elemento.MostrarDatos(elemento);

                try
                {
                    this.rtbMostrar.Text = dato;

                    dato.Guardar("salida.txt");
                }
                catch(Exception)
                {
                    MessageBox.Show("Fallo al guardar");
                }
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if(this.InvokeRequired)
            {
                DelegadoEstado de = new DelegadoEstado(paq_InformaEstado);
                this.Invoke(de, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstado();
            }
        }
    }
}
