using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se desea guardar los sueldos de 5 operarios.
//Según lo conocido deberíamos definir 5 variables si queremos tener en un cierto momento los 5 sueldos almacenados en memoria.
//Empleando un vector solo se requiere definir un único nombre y accedemos a cada elemento por medio del subíndice.
namespace ejercicio68
{
    class PruebaVector
    {

        private int[] sueldos;
        public void Cargar() 
        {
            sueldos = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string linea;
                Console.WriteLine("ingrese el sueldo: ");
                linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea) ;
            }
        
        }
        public void imprimir ()
        {
            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine(sueldos[i]);

            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector pruebaVector1 = new PruebaVector();
            pruebaVector1.Cargar();
            pruebaVector1 .imprimir();  
        }
    }
}
