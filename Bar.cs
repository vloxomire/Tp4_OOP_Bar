using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_OOP_Bar
{
    class Bar
    {
        private Humanoide[] barra;
        private Humanoide humanoide;
        private int indice;
        public Bar() 
        {
            indice = 10;
            barra = new Humanoide[indice];
            humanoide = new Humanoide();
        }
        public void InicializarBar() 
        {
            int menu = 0;
            do
            {
                Console.WriteLine("1)Desea asignarle un humanoide?");
                //podria surgir dde aca un nuevo humanoide con el random de nombre
                Console.WriteLine("2)Mostrar barra");
                Console.WriteLine("3)Salir");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        AsignarCliente(HayAsientoVacio(),humanoide);
                        break;
                    case 2:
                        MostrarBarra();
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (menu!=3);
        }
        public void MostrarBarra()
        {
            for (int i = 0; i < barra.Length; i++)
            {
                if (barra[i] != humanoide)
                {
                    Console.Write("x-");
                }
                else 
                {
                    Console.Write(humanoide.Nombre.ElementAt(0) + "-");
                }
            }
        }
        public void AsignarCliente(bool lugar,Humanoide humanoide) 
        {
            //Recorro la barra y cuanto las posiciones vacias
            if (!lugar)
            {
                return;
            }
            int posicion = AsientoLibre();
            barra[posicion]=humanoide;
            barra[posicion].Nombre(humanoide.AsignarNombre(posicion)
           
        }
        public bool HayAsientoVacio() 
        {
            int contador = 0;
            Console.Write("Contador="+contador);
            for (int i = 0; i < barra.Length; i++)
            {
                if (barra[i] == null)
                {
                    contador++;
                    Console.Write("ContadorBucle=" + contador);
                    return true;
                }
            }
            return false;
        }
        private int AsientoLibre() 
        {
            int valor = 0;
            for (int i = 0; i < barra.Length; i++)
            {
                if (barra[i] == null)
                {
                    valor = i;
                    break;
                }
            }
            return valor;
        }
    }
}
