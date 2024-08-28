using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos:
//    inicializar los atributos, imprimir el valor del lado mayor y otro método que muestre si es equilátero o no.
namespace ejercicio61
{
     class Triangulo
    {
         private int lado1, lado2, lado3;

        public void Inicializar()
        {
            string linea;
            Console.WriteLine("ingrese el primer lado: ");
            linea = Console.ReadLine();
            lado1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo lado: ");
            linea = Console.ReadLine();
            lado2 = int.Parse(linea);
            Console.WriteLine("ingrese el tercer lado: ");
            linea = Console.ReadLine();
            lado3 = int.Parse(linea);
        }
        public void LadoMayor()
        {
            Console.Write("el lado mayor es: ");
            if (lado1 > lado2 && lado1 > lado3) { Console.WriteLine(lado1); }
            else  { if (lado2 > lado3) { Console.WriteLine(lado2); }
                    else{ Console.WriteLine(lado3); } 
                   } 

        }
        public void Equilatero()
        {
            if (lado1 == lado2 && lado1== lado3) { Console.WriteLine("es equilatero."); }
            else {  Console.WriteLine("no es equilatero."); }
        }

        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            triangulo1.Inicializar();
            triangulo1.LadoMayor();
            triangulo1.Equilatero();
            Console.ReadKey();

        }
    }
}
