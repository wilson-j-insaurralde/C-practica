using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se carga una fecha (día, mes y año) por teclado. Mostrar un mensaje si corresponde al primer trimestre del año
//(enero, febrero o marzo) Cargar por teclado el valor numérico del día, mes y año.
//    Ejemplo: dia: 10 mes: 1 año: 2019.

namespace ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string linea;
            int dia, mes, año;
            Console.WriteLine("ingrese el nro del dia: ");
            linea = Console.ReadLine();
            dia= int.Parse(linea);
            Console.WriteLine("ingrese el nro del mes: ");
            linea= Console.ReadLine();
            mes= int.Parse(linea);
            Console.WriteLine("ingrese el nro del año: ");
            linea= Console.ReadLine();
            año = int.Parse(linea);
            if (mes == 1 || mes== 2 || mes== 3)
            {
                Console.WriteLine("Corresponde al primer trimestre");
            }
            Console.ReadLine();  


        }
    }
}
