using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector
namespace ejercicio79
{
    class VectorNElementos
    {
        private int[] vectorn;
        private int menor;

        public void Carga()
        {
            int n = 0;
            string linea;
            Console.WriteLine("ingrese el numero de elementos: ");
            linea = Console.ReadLine();
            n= int.Parse(linea);
            vectorn = new int[n];
            for(int i = 0; i < vectorn.Length; i++)
            {
                Console.WriteLine("ingrese elemento: ");
                linea = Console.ReadLine() ;
                vectorn[i]=int.Parse(linea);
            }
        }
        public void ImprimirMenor()
        {
             menor= 0;
            for(int i = 0; i<vectorn.Length-1; i++)
            {
                for (int j = 0; i< vectorn.Length; i++)
                {
                    if (vectorn[i] > vectorn[j])
                    {
                        menor = vectorn[j];
                    }
                    else
                    {
                        menor = vectorn[i];
                    }

                }
            }
            Console.WriteLine($"el menor valor es {menor}");
        }
        public void Repite()
        {   int cont= 0;
            for(int i = 0; i < vectorn.Length; i++)
            {
                if (menor == vectorn[i])
                {
                    cont = cont + 1;
                }
            }
            Console.WriteLine($"el numero se repite {cont} veces");
        }

        static void Main(string[] args)
        {
            VectorNElementos vec= new VectorNElementos();
            vec.Carga();
            vec.ImprimirMenor();
            vec.Repite();
            Console.ReadKey();
        }
    }
}
