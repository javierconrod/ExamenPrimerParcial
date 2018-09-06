using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> menus = new List<Menu>();
            
            menus.Add(new Menu());
            menus[0].Nombre = "Mañana";
            menus[0].Identificador = "WIUWIU";
            menus[0].HoraInicio = 7;
            menus[0].HoraFin = 12;

            menus[0].platillos.Add(new Platillos("LALSD", "Tacos", "Son tacos pues que más.", 16.53));
            menus[0].platillos[0].ingredientes.Add(new Ingredientes("Tortillas", "666"));
            menus[0].platillos[0].ingredientes.Add(new Ingredientes("Carne", "696"));

            menus[0].platillos.Add(new Platillos("LALER", "Pan con mantequilla", "Listos en media hora.", 60.75));
            menus[0].platillos[1].ingredientes.Add(new Ingredientes("Pan", "123"));
            menus[0].platillos[1].ingredientes.Add(new Ingredientes("Mantequilla", "987"));
            menus[0].platillos[1].ingredientes.Add(new Ingredientes("Gluten", "9888"));
            menus[0].platillos[1].ingredientes.Add(new Ingredientes("Azucar", "645"));

            foreach (Menu menu in menus)
            {
                Console.WriteLine("Nombre de menu: " + menu.Nombre);
                Console.WriteLine("Identificador: " + menu.Identificador);
                Console.WriteLine("Horario: " + menu.HoraInicio + " - " + menu.HoraFin);
                Console.WriteLine("Platillos: ");
                foreach(Platillos platillos in menu.platillos)
                {
                    Console.WriteLine("******************");
                    Console.WriteLine("Nombre: " + platillos.Nombre);
                    Console.WriteLine("Identificador: " + platillos.Identificador);
                    Console.WriteLine("Descripcion: " + platillos.Descripcion);
                    Console.WriteLine("Precio: " + platillos.Precio);
                    Console.WriteLine("Ingredientes: ");
                    foreach(Ingredientes ingredientes in platillos.ingredientes)
                    {
                        Console.WriteLine("----Nombre: " + ingredientes.Nombre);
                        Console.WriteLine("----Identificador: " + ingredientes.Identificador);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
