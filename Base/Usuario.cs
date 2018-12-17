using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Usuario
    {
        /// <summary>
        /// Esta clase sera la que guardara cada usuario
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Usuario(string nombre, string contra) {
            Nombre = nombre;
            Contra = contra;
        }
        public string Nombre { get; set; }
        public string Contra { get; set; }
        public bool Dentro { get; set; }
    }
}
