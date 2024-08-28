using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implementar la clase operaciones. Se deben cargar dos valores enteros, calcular su suma, resta, multiplicación y división,
//    cada una en un método, imprimir dichos resultados.
namespace ejercicio65
{
    class Operaciones
    {   private int valor1, valor2;
        private void Inicializar()
        {
            string linea;
            Console.WriteLine("ingrese el primer valor: ");
            linea = Console.ReadLine();
            valor1= int.Parse(linea);
            Console.WriteLine("ingrese el segundo valor:");
            linea= Console.ReadLine();
            valor2= int.Parse(linea);
        }
        private void Suma() {
            int suma;
            suma = valor1 + valor2;
            Console.WriteLine("su suma es: " +suma);
        } 
        private void Resta ()
        {
            int resta;
            resta = valor1 - valor2;
            Console.WriteLine("su resta es: " + resta);
        }
        private void Multiplicacion()
        {
            int multiplicacion;
            multiplicacion = valor1 * valor2;
            Console.WriteLine("su multiplicacion es: "+multiplicacion);
        }
        private void division ()
        {
            int division;
            division = valor1/valor2;
            Console.WriteLine("su division es: "+ division);
        }

        static void Main(string[] args)
        { Operaciones Operaciones1 = new Operaciones();
            Operaciones1.Inicializar();
            Operaciones1.Suma();
            Operaciones1.Resta();
            Operaciones1.division();
            Operaciones1.Multiplicacion();
            Console.ReadKey();
        }
    }
}
