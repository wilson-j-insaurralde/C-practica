using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Confeccionar un programa que permita cargar los nombres de 5 operarios y sus sueldos respectivos. Mostrar el sueldo mayor y el nombre del operario.
namespace ejercicio78
{
     class OperariosNombres
    {
        private string[] operarios;
        private int[] sueldos;
        public void Carga()
        {
            operarios = new string[5];
            sueldos = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string linea;
                Console.WriteLine("ingrese el nombre del operario: ");
                operarios[i]=Console.ReadLine();
                Console.WriteLine("ingrese su sueldo: ");
                linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea);
            }
        }
        public void SueldoMayor()
        {
            int sueldoM;
            string operarioM;
            operarioM = operarios[0];
            sueldoM = sueldos[0];
            for (int i = 0;i < 4;i++)
            {
                for (int j = 0; j < 5;j++)
                {
                    if (sueldos[j] > sueldos[i+1])
                    {
                        sueldoM = sueldos[j];
                        operarioM = operarios[j];
                    }
                    else { sueldoM = sueldos[i + 1];
                           operarioM = operarios[i+1];  }
                }
            }
            Console.WriteLine($"el operario con mayor sueldo es:{operarioM} + {sueldoM}  ");
        }
        static void Main(string[] args)
        {
            OperariosNombres operarios = new OperariosNombres();
            operarios.Carga();
            operarios.SueldoMayor();
            Console.ReadKey();
            
        }
    }
}
