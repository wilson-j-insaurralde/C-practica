using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desarrollar una clase que represente un Cuadrado y tenga los siguientes métodos: cargar el valor de su lado,
//    imprimir su perímetro y su superficie.
namespace ejercicio63
{
    internal class Cuadrado
    {
        private int lado;

        private void Inicializar()
        {
            string linea;
            Console.WriteLine("ingrese el lado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }
        private void Area ()
        {
            int area;
            area = lado * lado;
            Console.WriteLine("el area del cuadrado es: " + area);
        }
        private void Superficie()
        {
            int sup;
            sup = lado * 4;
            Console.WriteLine("la superficie del cuadrado es: "+ sup);
        }
        static void Main(string[] args)
        {
            Cuadrado Cuadrado1 = new Cuadrado();
            Cuadrado1.Inicializar();
            Cuadrado1.Superficie();
            Cuadrado1 .Area();
            Console.ReadKey();
        }
    }
}
