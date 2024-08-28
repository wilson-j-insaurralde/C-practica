using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor
namespace ejercicio74
{
     class Vectordies
    {
        private int[] Vector;
        public void Cargar()
        {
            Vector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                string linea;
                Console.WriteLine("ingrese elemento: ");
                linea = Console.ReadLine();
                Vector[i] = int.Parse(linea);
            }

        }
        public void VerificarOrden()
        {
            int x;
            x= 0;
            for (int i = 0;i < 9;i++)
            {
                if (Vector[i + 1] > Vector[i])
                {
                    x = 1;
                }
                else
                {
                    x=0;
                }
            }
            if (x==1)
            {
                Console.WriteLine("el vector esta ordenado de menor a mayor.");
            }
            else
            {
                Console.WriteLine("el vector no esta ordenado.");
            }


        }
        static void Main(string[] args)
        {
            Vectordies v = new Vectordies();
            v.Cargar();
            v.VerificarOrden();
            Console.ReadKey();
        }
    }
}
