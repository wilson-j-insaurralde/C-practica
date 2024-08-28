using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B, cada curso cuenta con 5 alumnos.
//Realizar un programa que muestre el curso que obtuvo el mayor promedio general.
namespace ejercicio73
{
    class Promedio
    {
        private int[] cursoa;
        private int[] cursob;
      
       
        public void Cargar()
        {
           
            cursoa = new int[5];
            cursob = new int[5];

            Console.WriteLine("cargar de las notas curso A: ");
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("ingrese la nota: ");
                string linea;
                linea = Console.ReadLine();
                cursoa[i] = int.Parse(linea);
            }
            
            Console.WriteLine("carga notas del curso B: ");
            for(int i = 0;i<5; i++)
            {
                Console.WriteLine("ingrese la nota: ");
                string linea;
                linea = Console.ReadLine();
                cursob[i] = int.Parse(linea);
            }
            

        }
        public void Promed()
        {
            int promeA, promeB, sumaA, sumaB; 
            promeA = 0;
            promeB = 0;
            sumaA = 0;
            sumaB = 0;
            for(int i = 0; i < 5; i++)
            {
                sumaA= sumaA + cursoa[i];
                sumaB= sumaB + cursob[i];
            }
            promeA = sumaA / 5;
            promeB = sumaB / 5;
            if (promeA == promeB)
            {
                Console.WriteLine("ambos cursos poseen el mismo promedio de notas generales: ");
                
            }
            else { if (promeA > promeB) {Console.WriteLine("el curso A tiene mayor promedio de notas generales: "); }
                   
                    else { Console.WriteLine("el curso B tiene mayor promedio de notas generales: "); }
             }
            
            
            
        }
        static void Main(string[] args)
        {
            Promedio nota = new Promedio();
            nota.Cargar();
            nota.Promed();
            Console.ReadKey();
        }
    }
}
