using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los cuatro valores que se encuentran en los vértices de la misma (mat[0][0] etc.)

namespace ejercicio92
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
            f = int.Parse(linea);
            Console.WriteLine("ingrese la cantidad de columnas: ");
            linea = Console.ReadLine();
            c = int.Parse(linea);
            matriz = new int[f, c];
            for (int i = 0; i < matriz.GetLength(0); i++)
            { for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("ingrese componente: ");
                    linea= Console.ReadLine();
                    matriz[i,j] = int.Parse(linea);
                }

            }
            ImprimirVertice(f,c);

        }
        public void ImprimirVertice(int f,int c)
        {
            for (int i = 0;i < matriz.GetLength(0);i++)
            {
                for(int j = 0;j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] == matriz[0, 0])
                    {
                        Console.Write(matriz[i,j]);
                    }
                    else
                    {
                        if (matriz[i, j] == matriz[0, c-1])
                        {
                            Console.Write(matriz[i,j]);
                        }
                        else
                        {
                            if (matriz[i,j]==matriz[f-1, 0])
                            {
                                Console.Write(matriz[i,j]);
                            }
                            else
                            {
                                if (matriz[i,j]== matriz[f - 1, c-1])
                                {
                                    Console.Write(matriz[i, j]);
                                }
                                else { Console.Write(" -- "); }
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ProgramMatriz matriz = new ProgramMatriz();
            matriz.Carga();
            Console.ReadKey();

        }
    }
}
