using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MostrarRecibos : Form
    {
        Utils util = new Utils();
        public MostrarRecibos()
        {
            InitializeComponent();
           
            util.NumeroFactura(comboBox1,Muestra);
        }

        int valorselecto = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valorselecto = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Muestra_Click(object sender, EventArgs e)
        {
            util.facturaInt(valorselecto);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Hide();
            panel.ShowDialog();
        }
    }
}
