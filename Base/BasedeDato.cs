using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public class BasedeDato
    {
        static List<Espacio> basesita = new List<Espacio>();
        static public List<Factura> Facturero = new List<Factura>();
        static public List<Carro> Cliente = new List<Carro>();
        public List<Usuario> Usuario = new List<Usuario>();

        public BasedeDato() {
            
            llenar();
        }

        public void llenar()
        {
            basesita.Add(new Espacio(1));
            basesita.Add(new Espacio(2));
            basesita.Add(new Espacio(3));
            basesita.Add(new Espacio(4));
            basesita.Add(new Espacio(5));
            basesita.Add(new Espacio(6));
            basesita.Add(new Espacio(7));
            basesita.Add(new Espacio(8));
            basesita.Add(new Espacio(9));
            basesita.Add(new Espacio(10));
            basesita.Add(new Espacio(11));
            basesita.Add(new Espacio(12));
            Usuario.Add(new Usuario("Juan", "Perez"));
            Usuario.Add(new Usuario("Homero", "Simpson"));

        }

        public bool verifica(int id)
        {
            bool a = false;

            foreach (Espacio x in basesita)
            {
                if (id == x.IdEspacio) a = x.Disponible;
            }
            return a;
        }

        public string Ingresar(int id, string placa,DateTime hora)
        {
            foreach (Espacio x in basesita)
            {
                if (id == x.IdEspacio) x.Ingresa(placa, hora);

            }
            return "Estado Ingresado";
        }

        public string Actualiza(int id,bool valor)
        {
            foreach (Espacio x in basesita)
            {
                
                if (id == x.IdEspacio) x.Disponible = valor;
            }
             return "Estado Actualizado";
        }


        public string Sale(int id, string placa)
        {
            foreach (Espacio x in basesita)
            {
                if (x.IdEspacio == id)  x.actualiza(true,placa); 
            }
            return "Estado Actualizado";
        }

        public string Total(int id, string placa)
        {
            string a = "";
            foreach (Espacio x in basesita)
            {
                if (x.IdEspacio == id) a = x.total(placa).ToString();
            }
            return a;

        }

        public bool Valida(string nombre, string contra)
        {
            bool respuesta = false;
            int cont = 0;

            foreach (Usuario x in Usuario)
                if (x.Nombre.Equals(nombre))
                {
                    cont++;
                    if (x.Contra.Equals(contra))
                    {
                        if (x.Dentro) { MessageBox.Show("Usuario ya conectado");  }
                        else { MessageBox.Show("Bienvenido "+ x.Nombre); respuesta = true; x.Dentro = true; }
                    }
                    else MessageBox.Show("Contrasena invalida"); 
                }
            if(cont <1) MessageBox.Show("Usuario No encontrado");
            return respuesta;
        }

        public Factura factura( string id)
        {
            Factura resp = new Factura(new Carro("aaa111", DateTime.Now));
            foreach (Factura x in Facturero)
                if (id.Equals( x.Carrito.Placa)) resp = x;

            return resp;
        }

        public Factura facturaInt(int id)
        {
            Factura resp = new Factura(new Carro("aaa111", DateTime.Now));
            foreach (Factura x in Facturero)
                if (id == x.IdFactura) resp = x;

            return resp;
        }
    }
}
