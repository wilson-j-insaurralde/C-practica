using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir el mayor elemento y la fila y columna donde se almacena.
namespace ejercicio90
{
    class Programmatriz
    {
        private int[,] matriz;
        public void Carga()
        {
            string linea;
            int f, c;
            Console.WriteLine("ingrese la cantidad de filas: ");
            linea = Console.ReadLine(); 
            f = int.Parse(linea);
            Console.WriteLine("ingrese la cantidad de columnas: ");
           linea= Console.ReadLine();
            c = int.Parse(linea);
            matriz = new int[f,c];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("ingrese componentes: ");
                    linea = Console.ReadLine();
                    matriz[i,j] = int.Parse(linea);

                }
                
            }
        }
        public void ImprimirMayor()
        {
            int mayor = matriz[0,0];
            int fila = 0;
            int columna = 0;
            for (int i = 0;i < matriz.GetLength(0);i++)
            {
                for (int j = 0;j < matriz.GetLength(1);j++)
                {
                    if (matriz[i,j] > mayor)
                    {
                        mayor = matriz[i,j];
                        fila = i;
                        columna = j;
                    }
                }
            }
            Console.WriteLine($"el mayor es: {mayor} ");
            Console.WriteLine(" su ubicacion es: ");
            Console.WriteLine("fila: " + fila);
            Console.WriteLine("columna: "+columna);
        }
        
        static void Main(string[] args)
        {
           Programmatriz mat= new Programmatriz();
            mat.Carga();
            mat.ImprimirMayor();
            Console.ReadKey();  
        }
    }
}
