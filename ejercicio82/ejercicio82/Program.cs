using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector.
namespace ejercicio82
{
     class VectorN
    {
        private int[] Vectorn;
         public void Carga()
        {
            string linea;
            int n = 0;
            Console.WriteLine("ingrese el numero de elementos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            Vectorn = new int[n];
            for (int i = 0; i < Vectorn.Length; i++)
            {
                Console.WriteLine("ingrese elemento: ");
                linea = Console.ReadLine();
                Vectorn[i]=int.Parse(linea);
            }
        }

        public void Ordenar()

        {
            int aux = 0;
            for (int i = 0;i < Vectorn.Length-1;i++)
            {
                for(int j = 0;j< Vectorn.Length-1;j++)
                {
                    if (Vectorn[j].CompareTo(Vectorn[j+1]) > 0)
                    {
                        aux = Vectorn[j];
                        Vectorn[j] = Vectorn[j + 1];
                        Vectorn[j + 1] = aux;
                    }
                }
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < Vectorn.Length; i++)
            {
                Console.Write($"{Vectorn[i]} -- ");
            }

        }
        static void Main(string[] args)
        {
            VectorN vec= new VectorN();
            vec.Carga();
            vec.Ordenar();
            vec.imprimir();
            Console.ReadKey();
        }
    }
}
