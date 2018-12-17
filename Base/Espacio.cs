using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public class Espacio
    {
        /// <summary>
        /// Esta clase sera la que gestionara cada uno de los campos
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Espacio(int id)
        {
            IdEspacio = id;
            Disponible = true;
        }
        public Espacio() { }

        public Boolean Disponible { set; get; }
        public int IdEspacio { set; get; }
        public int Contador = 0;
        public List<Carro> Carrito = new List<Carro>();

        public void Ingresa(string placa, DateTime hora)
        {
            Carrito.Add(new Carro(placa, hora));
        }

        public void actualiza(bool valor, string placa)
        {
            Disponible = valor;
            if (valor)
            {
                Contador++;
                foreach (Carro x in Carrito)
                {
                    if (placa.Equals(x.Placa)) x.Salir();
                    BasedeDato.Facturero.Add(new Factura(x));
                    BasedeDato.Cliente.Add(x);
                }
            }
        }

        public int total(string placa)
        {
            int Total = 0; 
            foreach (Carro x in Carrito)
                if (placa.Equals(x.Placa)) Total = (int) x.TotalPagar;
            return Total;
        }

    }
}
