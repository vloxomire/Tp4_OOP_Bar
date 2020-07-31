using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_OOP_Bar
{
    class Bar
    {
        private Humanoide[] barra;
        private Humanoide humanoide;
        public Bar() 
        {
            barra = new Humanoide[10];
            humanoide = new Humanoide();
        }
        public void MostrarBarra()
        {
            foreach (Humanoide humanoide in barra) 
            {
                Console.Write(humanoide.Nombre.ElementAt(0)+"-");
            }
        }
        public void AsignarCliente(bool lugar,Humanoide humanoide) 
        {
            //Recorro la barra y cuanto las posiciones vacias
            if (!lugar)
            {
                return;
            }
            barra[AsientoLibre()]=humanoide;
           
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
