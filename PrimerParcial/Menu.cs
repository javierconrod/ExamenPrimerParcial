using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Menu
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public List<Platillos> platillos = new List<Platillos>();

        public Menu()
        {
            Nombre = "Nuevo menú";
        }

    }
}
