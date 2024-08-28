using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Definir un vector donde almacenar los nombres de 5 paises. Confeccionar el algoritmo de ordenamiento alfabético.
namespace ejercicio81
{
     class Vector5
    {   
        private string[] paises;

        public void VectorPaises()
        {
            paises = new string[5];
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("ingrese el nomre del pais: ");
                paises[i] = Console.ReadLine();

            }
        }
        public void Ordenar()
        {
            string aux;
            for (int i = 0;i < 4;i++)
            {
                for(int j = 0;j < 4;j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        aux = paises[j];
                        paises[j]=paises[j+1];
                        paises[j + 1] = aux;
                    } 
                }
            }
        }
        public void Imprimir()
        {
            for (int i = 0;i<5 ; i++)
            {
                Console.Write($"{paises[i]} - ");
            }
            Console.WriteLine();    
        }
        static void Main(string[] args)
        {
            Vector5 vector = new Vector5();
            vector.VectorPaises();
            vector.Imprimir();
            vector.Ordenar();
            vector.Imprimir();
            Console.ReadKey();
        }
    }
}
