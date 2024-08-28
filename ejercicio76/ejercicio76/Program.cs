using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desarrollar un programa que permita ingresar un vector de n elementos, ingresar n por teclado. Luego imprimir la suma de todos sus elementos
namespace ejercicio76
{
     class VectorNElementos
    {

        private int[] vectorn;  
        public void Carga()
        {
            string linea;
            int n;
            Console.WriteLine("ingrese el numero de elementos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            vectorn = new int[n];
            for (int i = 0; i < vectorn.Length; i++)
            {
                Console.WriteLine("ingrese elemento: ");
                
                linea = Console.ReadLine();
                vectorn[i] = int.Parse(linea);
            }
        }
        public void Suma()
        {
            int suma;
            suma = 0;
            for (int i = 0;i < vectorn.Length;i++)
            {
                suma = suma + vectorn[i];
            }
            Console.WriteLine("la suma de todos sus elementos es: "+ suma); 
        }
        static void Main(string[] args)
        {
            VectorNElementos vec=new VectorNElementos();
            vec.Carga();
            vec.Suma(); 
            Console.ReadKey();
        }
    }
}
