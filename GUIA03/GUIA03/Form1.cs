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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNFACTO_Click(object sender, EventArgs e)
        {
            Facto ventana = new Facto();
            ventana.Show();

            this.Hide();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNFACTO2_Click(object sender, EventArgs e)
        {
            Facto2 ventana = new Facto2();
            ventana.Show();

            this.Hide();
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            Facto3 ventana = new Facto3();
            ventana.Show();

            this.Hide();
        }
    }
}
