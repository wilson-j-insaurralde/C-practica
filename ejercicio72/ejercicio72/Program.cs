using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos.
//Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer vector del mismo tamaño. Sumar componente a componente.
namespace ejercicio72
{
    class DosVectores
    {
        private float[] vector1;
        private float[] vector2;
        private float[] vectorsuma;
        public void Cargar ()
        {
            string linea;
            vector1 = new float[4];
            Console.WriteLine("carga del primer vector:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese el numero:");
                linea = Console.ReadLine();
                vector1[i]= float.Parse(linea);
            }
            vector2 = new float[4];
            Console.WriteLine("carga del segundo vector: ");
            for (int i = 0;i < 4;i++)
            {
              Console.WriteLine("ingrese el numero: ");
              linea = Console.ReadLine();
              vector2[i]= float.Parse(linea);

            }

        }
        public void SumaDosVec()
        {
            
            vectorsuma = new float[4];
            for (int i = 0; i<4;i++)
            {
                vectorsuma[i] = vector1[i] + vector2[i];
            }
        }
        public void MostrarSuma()
        {
            Console.WriteLine("suma vectores componente a componente: ");
            for (int i = 0;i<4;i++)
            {   
                Console.Write(vectorsuma[i]);
                Console.Write("-");
            }

        }
        static void Main(string[] args)
        {
            DosVectores vec = new DosVectores();
            vec.Cargar();
            vec.SumaDosVec();
            vec.MostrarSuma();
            Console.ReadKey();
        }
    }
}
