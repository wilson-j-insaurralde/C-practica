using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde)
//Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
//Imprimir los gastos en sueldos de cada turno.
namespace ejercicio70
{
     class SueldoEmpleados
    {
        private float[] TurnoMañ;
        private float[] TurnoTar;
        public void TurnoTarde()
        {
            float suma1;
            suma1 = 0;
            TurnoTar = new float[4];
            for (int i = 0;i<4;i++)
            {
                string linea;
              
                Console.WriteLine("ingrese el sueldo turno tarde: ");
                linea = Console.ReadLine();
                TurnoTar[i]=float.Parse(linea);
                suma1 = suma1 + TurnoTar[i];
            }
            Console.WriteLine("gastototal sueldo turno tarde: ");
            Imprimir(suma1);
            
        }
        public void TurnoMañana ()
        {
            float suma2;
            suma2 = 0;
            TurnoMañ = new float[4];
            for (int i = 0; i<4;i++)
            {
                string linea;
                Console.WriteLine("ingrese el sueldo turno mañana: ");
                linea = Console.ReadLine();
                TurnoMañ[i]=float.Parse(linea);
                suma2 = suma2 + TurnoMañ[i];
            }
            Console.WriteLine("gastototal sueldo turno mañana: ");
            Imprimir(suma2);

        }
        // probando como se hace esto.
        public void Imprimir(float suma1)
        {
            Console.WriteLine("sueldo: " + suma1);
        }
       
        static void Main(string[] args)
        {
            SueldoEmpleados ver= new SueldoEmpleados();
            ver.TurnoTarde();
            ver.TurnoMañana();
            Console.ReadKey();
           // ver.Imprimir();
        }
    }
}
