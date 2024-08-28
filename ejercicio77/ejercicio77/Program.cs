    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas.
//Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad (mayores o iguales a 18 años)
namespace ejercicio77
{
    class VectorEdadyNombre
    {
        private string[] nombres;
        private int[] edades;
        public void Carga()
        {
            string linea;
            nombres = new string[5];
            edades = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese el nombre de la persona: ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("ingrese la edad: ");
                linea = Console.ReadLine();
                edades[i]=int.Parse(linea);
                
            }
        }
        public void Mostrar()
        {
            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine($"{nombres[i]} - {edades[i]}");
            }
        }
        public void MostrarMayores18()
        {
            Console.WriteLine("los mayores de edad son: ");
            for (int i = 0; i < 5; i++)
            {   if (edades[i] > 18) { 
                Console.WriteLine($"{nombres[i]} - {edades[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            VectorEdadyNombre vec=new VectorEdadyNombre();
            vec.Carga();
            vec.Mostrar();
            vec.MostrarMayores18();
            Console.ReadKey();
        }
    }
}
