using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base 
{
   public class Carro : Espacio
    {
        /// <summary>
        /// Esta clase guarda la informacion del vehiculo, hora y costos
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Carro(string placa, DateTime hora)
        {
            HoraEntrada = hora;
            Placa = placa;
        }
        public string Placa { set; get; }
        public DateTime HoraEntrada { set; get; }
        public DateTime HoraSalida { set; get; }
        public TimeSpan TotalTiempo { set; get; }
        public decimal TotalPagar { set; get; }

        public void Salir()
        {
            HoraSalida = DateTime.Now;
            TotalTiempo = HoraSalida - HoraEntrada;
            TotalPagar = (decimal) TotalTiempo.TotalMinutes * 10;
        }
    }

    
}
