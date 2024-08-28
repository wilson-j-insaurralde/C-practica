using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
//El valor acumulado de todos los elementos del vector.
//El valor acumulado de los elementos del vector que sean mayores a 36.
//Cantidad de valores mayores a 50.

namespace ejercicio71
{
     class VectorOchoElemt
    {
        private float[] Vector8;
        public void Cargar ()
        { 
            Vector8 = new float[8]; 
            for (int i = 0; i < 8; i++)
            {
                string linea;
                Console.WriteLine("ingrese elemnto: ");
                linea = Console.ReadLine();
                Vector8[i] = float.Parse(linea);

            }

         
        }
        public void ValorAcumuado()
        {
            float acumulado;
            acumulado = 0.0f;
            for (int i = 0;i < 8;i++)
            {
                acumulado = acumulado + Vector8[i];
            }
            Console.WriteLine("el valor acumulado es: "+acumulado);
        }
        public void AcumuladoMayor36()
        {
            float acumulado;
            acumulado = 0.0f;
            for (int i = 0; i < 8; i++)
            {
                if (Vector8[i] > 36)
                {
                    acumulado = acumulado + Vector8[i];
                }
            }
            Console.WriteLine("el valor acumulado de los elementos del vector mayores a 36 es: " + acumulado);

        }
        public void AcumuladoMayor50()
        {
            float acumulado;
            acumulado= 0.0f;
            for (int i = 0; i < 8; i++)
            {
                if (Vector8[i] >50) {
                    acumulado= acumulado + Vector8[i];

                }
            }
            Console.WriteLine("el valor acumulado de los elementos del vector mayores a 50 es: " + acumulado);
        }
        static void Main(string[] args)
        {
            VectorOchoElemt vec= new VectorOchoElemt();
            vec.Cargar();
            vec.ValorAcumuado();
            vec.AcumuladoMayor36();
            vec.AcumuladoMayor50();
            Console.ReadKey();
        }
    }
}
