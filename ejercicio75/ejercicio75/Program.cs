using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Se desea almacenar los sueldos de operarios. Cuando se ejecuta el programa se debe pedir la cantidad de sueldos a ingresar. Luego crear un vector con dicho tamaño.
namespace ejercicio75
{
    class SueldosOperarios
    {
        private int[] sueldos;
        public void Cargar()
        {
            string linea;
            int rango;
            Console.WriteLine("ingrese la cantidad de sueldos: ");
            linea = Console.ReadLine();
            rango = int.Parse(linea);
            sueldos = new int[rango];
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine("ingrese sueldo:");
                linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea);

            }
            

        }
        public void Mostrar()
        {
            for (int i = 0;i < sueldos.Length;i++)
            {
                Console.Write(sueldos[i]);
                Console.Write("-");
            }
        }

        static void Main(string[] args)
        {
            SueldosOperarios su=new SueldosOperarios();
            su.Cargar();
            su.Mostrar();
            Console.ReadKey();
        }
    }
}
