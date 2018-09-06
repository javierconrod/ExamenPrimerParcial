using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Ingredientes
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }

        public Ingredientes(string nombre, string id)
        {
            Nombre = nombre;
            Identificador = id;
        }
    }
}
