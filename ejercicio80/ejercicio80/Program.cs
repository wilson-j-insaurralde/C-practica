using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se debe crear un vector donde almacenar 5 sueldos. Ordenar el vector sueldos de menor a mayor.
namespace ejercicio80
{
     class Sueldos
    {
        private int[] sueldos;
        public void Carga()
        {   
            sueldos = new int[5];
            string linea;
            for (int i = 0; i < 5;i++)
            {
                Console.WriteLine("ingrese el sueldo: ");
                linea = Console.ReadLine(); 
                sueldos[i] = int.Parse(linea);
            }
        }
        public void Ordenar()
        {
            int aux = 0;
            for (int i = 0;i < 4; i++)
            {
                for (int j = 0;j < 4;j++)
                {
                    if (sueldos[j] > sueldos[j+1])
                    {
                        aux = sueldos[j];
                        sueldos[j] = sueldos[j+1];
                        sueldos[j+1] = aux;
                    }
                }
            }
        }
        public void Imprimir()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{sueldos[i]} - ");
            }
        }

        static void Main(string[] args)
        {
            Sueldos su= new Sueldos();
            su.Carga();
            su.Ordenar();
            su.Imprimir();
            Console.ReadKey();
        }
    }
}
