using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir la matriz completa y la última fila
namespace ejercicio89
{
    class Matriz
    {
        private int[,] matriz;
        public void Carga()
        {
            string linea;
            int f;
            int c;
            Console.WriteLine("ingrese la cantidad de filas: ");
            linea = Console.ReadLine();
            f = int.Parse(linea);
            Console.WriteLine("ingrese la cantidad de columnas: ");
            linea = Console.ReadLine();
            c = int.Parse(linea);
            matriz = new int[f, c];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("ingrese componente de la matriz");
                    linea = Console.ReadLine();
                    matriz[i,j] = int.Parse(linea);
                }
            }

        }
        public void Imprimir()
        {
            for(int i = 0;i < matriz.GetLength(0); i++)
            {
                for (int k = 0; k < matriz.GetLength(1); k++)
                {
                    Console.Write(matriz[i,k]+ "  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {   Matriz matriz = new Matriz();
            matriz.Carga();
            matriz.Imprimir();
            Console.ReadKey();
        }
    }
}
