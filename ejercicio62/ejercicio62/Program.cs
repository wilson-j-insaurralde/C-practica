using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: cargar los valores de x e y,
//    imprimir en que cuadrante se encuentra dicho punto (concepto matemático,
//    primer cuadrante si x e y son positivas, si x<0 e y>0 segundo cuadrante, etc.)
namespace ejercicio62
{
    internal class Punto
    {   
        private int x, y;
        private void Inicializar() {
            string linea;
            Console.WriteLine("ingrese el valor de x: ");
            linea = Console.ReadLine();
            x= int.Parse(linea);
            Console.WriteLine("ingrese el valor de y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);
            
        }
        private void Cuadrante()
        {
            if ( x >0 && y >0 ) { Console.WriteLine("se encuentra en el primer cuadrante.");}
            else { if (x < 0 && y > 0) { Console.WriteLine("se encuentra en el segundo cuadrante");}
                   else { if (x < 0 && y < 0) { Console.WriteLine("se encuentra en el tercer cuadrante"); }   
                          else { Console.WriteLine("se encuentra en el cuarto cuadrante.");}
                         }
                  }
        }


        static void Main(string[] args)
        { Punto Punto1 = new Punto();
            Punto1.Inicializar();
            Punto1.Cuadrante();
            Console.ReadKey();
        }
    }
}
