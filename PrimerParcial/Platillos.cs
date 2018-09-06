using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Platillos
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Ingredientes> ingredientes = new List<Ingredientes>();
        double _precio;
        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if(value < 50)
                {
                    Console.WriteLine("No puede costar menos de 50 pesos. Se asignará precio mínimo");
                    _precio = 50;
                }
                else
                {
                    _precio = value;
                }
            }
        }
        public Platillos(string id, string nombre, string desc, double pre)
        {
            Identificador = id;
            Nombre = nombre;
            Descripcion = desc;
            Precio = pre;
        }

    }
}
