using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    /// <summary>
    /// Esta clase  sera la factura que se mostrara al cliente
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public class Factura
    {
        public Factura(Carro carro) {
            IdFactura = Numero + 1;
            Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Numero++;
            Carrito = carro;
        }
        public int IdFactura { get; set; }
        public string Fecha { get; set; }
        public Carro Carrito{ get; set; }
        public int Total { get; set; }

        public static int Numero = 0;

    }
}
