using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_OOP_Bar
{
    class Humanoide
    {
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
    }
}
