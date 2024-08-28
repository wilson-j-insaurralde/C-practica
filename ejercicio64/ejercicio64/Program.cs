using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.
//    Confeccionar los métodos para la carga, otro para imprimir sus datos y por último uno que imprima un mensaje si debe pagar impuestos
//    (si el sueldo supera a 3000)
namespace ejercicio64
{
    class Empleado
    {
        private string nombre;
        private int sueldo;

        private void Inicializar()
        {
            string linea;
            Console.WriteLine("ingrese el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese el sueldo: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }
        private void Imprimir ()
        {
            Console.WriteLine("nombre: "+nombre);
            Console.WriteLine("sueldo: "+sueldo);
        }
        private void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("debe pagar impuestos.");
            }
            else { Console.WriteLine("no debe pagar impuestos."); }
        }
        static void Main(string[] args)
        {
            Empleado Empleado1 = new Empleado();
            Empleado1.Inicializar();
            Empleado1.Imprimir();
            Empleado1.Impuestos();
            Console.ReadKey();
        }
    }
}
