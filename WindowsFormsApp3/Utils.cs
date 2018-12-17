using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Base;



namespace WindowsFormsApp3
{
    class Utils
    {
        /// <summary>
        /// Esta clase es la que hace la conexion entre "la base de datos" y las vistas que vera el usuario
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        BasedeDato basede = new BasedeDato();
        
        public Utils() { }
        
        public void BorderChange(Button btn, Label label,Label pla, int id)
        {
            string placa = null;

            if (basede.verifica(id))
            {
                bool a = false;
                while (!a)
                {
                    placa = Interaction.InputBox("Ingrese Numero de Placa", "Estacionamiento", "");//texto, titulo, PLACEHOLDER
                    a = Check(placa);
                }
                if (a)
                {
                    btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
                    label.Text = "Ocupado";
                    pla.Text = placa;
                    DateTime hora = DateTime.Now;
                    label.Text = hora.ToString("h:mm:ss");

                    basede.Ingresar(id,placa, hora);
                    pla.Visible = true;
                    MessageBox.Show(basede.Actualiza(id, false));
                    a = false;
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Vehiculo sale?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
                if (resultado == DialogResult.Yes)
                {
                    placa = pla.Text;
                    MessageBox.Show(basede.Sale(id, placa));
                    btn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    label.Text = "Disponible";
                    pla.Text = null;
                    pla.Visible = false;
                    int a = BasedeDato.Facturero.Count -1;
                    factura(placa);                 
                }
            }
        }

        public bool Check(String data)
        {
            if (String.IsNullOrEmpty(data))
            {
                MessageBox.Show("Ingrese La placa");
                return false;
            }
            else {
                if (data.Length < 6 || data.Length > 6)
                {
                    MessageBox.Show("La Placa debe tener 6 caracteres");
                    return false;
                }
                else {
                    string pattern = "[a-zA-Z0-9]";
                    if (System.Text.RegularExpressions.Regex.IsMatch(data, pattern))
                    {
                        return true;
                    }
                    else {
                        MessageBox.Show("Ingrese solo numeros y letras");
                        return false; 
                    }
                }
            }
        }

        public bool login(string nombre, string contra)
        {
            if (basede.Valida(nombre, contra)) return true;
            else return false;
        }

        public void factura(string id ) // Este metodo cargara el Form con la informacion de la factura solicitada
        {
            Factura facturita  = basede.factura(id);
            Recibo recibito = new Recibo(facturita.Fecha, facturita.IdFactura.ToString(), facturita.Carrito.Placa.ToString(), facturita.Carrito.HoraEntrada.ToString(), facturita.Carrito.HoraSalida.ToString(), facturita.Carrito.TotalPagar.ToString());
            recibito.Show();
        }

        public void NumeroFactura(ComboBox combo, Button boton)
        {
            foreach (Factura x in BasedeDato.Facturero)
            {
                combo.Items.Add(x.IdFactura);
            }

            if (combo.Items.Count < 1) {
                MessageBox.Show("No hay Facturas por el momento");
                combo.Hide();
                boton.Hide();

            }
        }
        public void facturaInt(int id) // Este metodo cargara el Form con la informacion de la factura solicitada por medio de INT
        {
            Factura facturita = basede.facturaInt(id);
            Recibo recibito = new Recibo(facturita.Fecha, facturita.IdFactura.ToString(), facturita.Carrito.Placa.ToString(), facturita.Carrito.HoraEntrada.ToString(), facturita.Carrito.HoraSalida.ToString(), facturita.Carrito.TotalPagar.ToString());
            recibito.Show();
        }

    }
}
