using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_OOP_Bar
{
    class Humanoide
    {
        public Random random;
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public Humanoide()
        {
            Nombre = "Nombre";
            Raza = "Humanoide";
        }
        public void Hablar()
        {
            Console.WriteLine("Mi nombre es {0}, soy un {1}", Nombre, Raza);

        }
        public void AsignarNombre(Humanoide[] barra,int posicion) 
        {
            random = new Random();
            int valor = random.Next(0, 3);
            string[] nombres={ "Jose", "Marcos", "David","Carlos" };
            barra[posicion].Nombre = nombres[valor];

        }
    }
}
