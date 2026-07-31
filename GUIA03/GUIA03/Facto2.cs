using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text;

namespace GUIA03
{
    public partial class Facto2 : Form
    {
        
        public Facto2()
        {
            InitializeComponent();
            
        }

        private void LBL1_Click(object sender, EventArgs e)
        {

        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();

            this.Hide();
        }

        private void BTN1_Click(object sender, EventArgs e)

        {
            int llave;
            string texto = TXTB2.Text;
            string resultado = "";
            llave = Convert.ToInt32(TXTB1.Text);
            if (RD1.Checked)
            {
                llave = -llave;
            }
            foreach (char letra in texto)
            {
                resultado += Convert.ToChar(letra + llave);
            }
            TXTB3.Text = resultado;
        }

        private void TXTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
            !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void RD1_CheckedChanged(object sender, EventArgs e)
        {
            BTN1.Text = "Encriptar";
        }

        private void RD2_CheckedChanged(object sender, EventArgs e)
        {
            BTN1.Text = "Desencriptar";

        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            TXTB2.Clear();
            TXTB1.Clear();
            TXTB3.Clear();
            RD1.Checked = true;
            TXTB2.Focus();
        }
    }
}
