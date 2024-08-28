using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cargar en un vector los nombres de 5 paises y en otro vector paralelo la cantidad de habitantes del mismo. Ordenar alfabéticamente e imprimir los resultados.
//    Por último ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir nuevamente.
namespace ejercicio84
{
    class Program
    {
        private string[] paises;
        private int[] habitantes;
        public void Carga()
        {
            paises = new string[5];
            habitantes = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string linea;
                Console.WriteLine("ingrese el pais:");
                paises[i]=Console.ReadLine();
                Console.WriteLine("ingrese su cantidad de habitantes: ");
                linea = Console.ReadLine();
                habitantes[i]=int.Parse(linea);
            }

        }
        public void OrdenarAlfabeticamente()
        {
            Console.WriteLine("ordenados alfabeticamente: ");
            for (int i = 0;i < 6;i++)
            {
                for (int j = 0;j < 4; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1])>0){
                        int auxh = 0;
                        string auxp;
                        auxp = paises[j];
                        paises[j]=paises[j+1];
                        paises[j+1]=auxp;
                        auxh = habitantes[j];
                        habitantes[j] = habitantes[j+1];
                        habitantes[j+1]=auxh;

                    }
                }
            }
        }
        public void OrdenarCantHabit()
        {
            Console.WriteLine("ordenador por cantidad de habitantes: ");
              for (int i = 0;i < 4;i++)
            {
                for (int j = 0;j < 4; j++)
                {
                    if (habitantes[j].CompareTo(habitantes[j + 1])>0){
                        int auxh = 0;
                        string auxp;
                        auxp = paises[j];
                        paises[j]=paises[j+1];
                        paises[j+1]=auxp;
                        auxh = habitantes[j];
                        habitantes[j] = habitantes[j+1];
                        habitantes[j+1]=auxh;

                    }
                }
            }


        }
        public void Imprimir()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{paises[i]} --- {habitantes[i]} ");
            }
        }
        static void Main(string[] args)
        {

            Program ver = new Program();
            ver.Carga();
            ver.OrdenarAlfabeticamente();
            ver.Imprimir();
            ver.OrdenarCantHabit();
            ver.Imprimir();
            Console.ReadKey();
        }
    }
}
