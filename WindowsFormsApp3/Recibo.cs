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
    public partial class Recibo : Form
    {
        public Recibo(string fecha, string idFac, string placa0, string horaE, string horaS, string precio)
        {
            InitializeComponent();

            fecha1.Text = fecha;
            IdFactura.Text = idFac;
            placa.Text = placa0;
            entrada.Text = horaE;
            salida.Text = horaS;
            monto.Text = precio;
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
