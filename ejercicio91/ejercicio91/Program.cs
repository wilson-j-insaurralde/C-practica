using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la primer fila con la segunda. Imprimir luego la matriz.
namespace ejercicio91
{
     class ProgramMatriz
    {
        private int[,] matriz;
        public void Carga()
        {
            int f, c;
            string linea;
            
            Console.WriteLine("ingrese la cantidad de filas: ");
            linea = Console.ReadLine();
            f= int.Parse(linea);
            Console.WriteLine("ingrese la cantidad de columnas: ");
            linea = Console.ReadLine();
            c = int.Parse(linea);
            matriz = new int[f,c];
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("ingrese componente: ");
                    linea= Console.ReadLine();
                    matriz[i,j] = int.Parse(linea);
                }
            }

        }
        public void Intercambiar()
        {
            int aux;
            for (int i = 0;i <= 0; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    aux = matriz[i+1,j];
                    matriz [i+1,j] = matriz[i,j];
                    matriz[i,j]= aux;


                }
            }
        }
        public void Imprimir()
        {
            for ( int i = 0;i<matriz.GetLength(0);i++)
            {
                for (int k = 0;k < matriz.GetLength(1); k++)
                {
                    Console.Write(matriz[i,k]+ "  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ProgramMatriz mat= new ProgramMatriz();
            mat.Carga();
            mat.Intercambiar();
            mat.Imprimir();
            Console.ReadKey();
        }
    }
}
