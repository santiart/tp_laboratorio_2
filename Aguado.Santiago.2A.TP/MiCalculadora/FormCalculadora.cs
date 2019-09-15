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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        Calculadora calculadora = new Calculadora();
        public FormCalculadora()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConverirABinario_Click(object sender, EventArgs e)
        {
            Numero number = new Numero(this.txtResultado.Text);
            this.txtResultado.Text = number.DecimalBinario(this.txtResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero number = new Numero(this.txtResultado.Text);
            this.txtResultado.Text = number.BinarioDecimal(this.txtResultado.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtResultado.ResetText();
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(this.txtNumero1.Text != " " && this.txtNumero2.Text != " " && this.cmbOperador.SelectedItem != null)
            {
                Numero num1 = new Numero(this.txtNumero1.Text);
                Numero num2 = new Numero(this.txtNumero2.Text);

                this.txtResultado.Text = this.calculadora.Operar(num1, num2, this.cmbOperador.SelectedItem.ToString()).ToString();
            }
        }


    }
}
