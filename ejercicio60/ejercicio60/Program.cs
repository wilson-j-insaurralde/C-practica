using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Confeccionar una clase que permita carga el nombre y la edad de una persona. Mostrar los datos cargados.
//    Imprimir un mensaje si es mayor de edad (edad>=18)
namespace ejercicio60
{
     class Persona
    {
        private string nombre;
        private int edad;
        public void Inicializar()
        {
            Console.WriteLine("ingrese el nombre: ");
            nombre = Console.ReadLine();
            string linea;
            Console.WriteLine("ingrese la edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);

        }
        public void Imprimir()
        {
            Console.WriteLine("nombre: "+ nombre);
            Console.WriteLine("edad: "+edad);
        }
        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("es mayor de edad");
            }
            else
            {
                Console.WriteLine("es menor de edad.");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Inicializar();
            persona1.Imprimir();
            persona1.EsMayorEdad();

        }
    }
}
