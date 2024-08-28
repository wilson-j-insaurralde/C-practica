using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Confeccionar un programa que permita cargar los nombres de 5 alumnos y sus notas respectivas.
//    Luego ordenar las notas de mayor a menor. Imprimir las notas y los nombres de los alumnos.

namespace ejercicio83
{
    class Program
    {
        private int[] notas;
        private string[] alumnos;

        public void Carga()
        {
            string linea;
            notas = new int[5];
            alumnos = new string[5];
            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine("ingrese el nombre de alumno: ");
                alumnos[i] = Console.ReadLine();
                Console.WriteLine("ingrese la nota del alumno:");
                linea = Console.ReadLine();
                notas[i]=int.Parse(linea);

            }
        }
        public void Ordenar()
        {
            for (int i = 0;i < 4 ; i++)
            {
                for(int j = 0;j < 4 ; j++)
                {
                    if (notas[j] < notas[j + 1])
                    {
                        int auxnt; string auxnm;
                        auxnt = notas[j+1];
                        notas[j+1]= notas[j];
                        notas[j]= auxnt;
                        auxnm = alumnos[j + 1];
                        alumnos[j+1]= alumnos[j];
                        alumnos[j]= auxnm;  
                    }
                }
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombres de alumnos y notas de mayor a menor:");
            for (int i = 0;i<5 ; i++)
            {
                Console.WriteLine($"{alumnos[i]} -- {notas[i]}  ");
            }
        }
        static void Main(string[] args)
        {
            Program ver = new Program();
            ver.Carga();
            ver.Ordenar();
            ver.Imprimir();
            Console.ReadKey();
        }
    }
}
