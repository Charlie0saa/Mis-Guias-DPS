using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA03
{
    public partial class Facto3 : Form
    {
        public Facto3()
        {
            InitializeComponent();
        }
        public static bool IsNumeric(string dato)
        {
            int numero;
            return int.TryParse(dato, out numero);
        }

        private void BTNCALCUL_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(TXTB1.Text))
            {
                MessageBox.Show("Ingrese un número válido");
                TXTB1.Focus();
                return;
            }
            int numero = Convert.ToInt32(TXTB1.Text);
            int reves = 0;
            int digito;
            do
            {
                digito = numero % 10;
                reves = (reves * 10) + digito;
                numero = numero / 10;
            }
            while (numero > 0);
            TXTB2.Text = reves.ToString();
        }

        private void TXTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
              !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void BTNLIMP_Click(object sender, EventArgs e)
        {
            TXTB2.Clear();
            TXTB1.Clear();      
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();

            this.Hide();
        }
    }
}
