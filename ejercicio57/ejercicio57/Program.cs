using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta corriente se conoce: número de cuenta y saldo actual.
//    El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
//Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
//a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
//Estado de la cuenta	'Acreedor' si el saldo es >0.
//			'Deudor' si el saldo es <0.
//			'Nulo' si el saldo es =0.
//b) La suma total de los saldos acreedores.
namespace ejercicio57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int cuenta, saldo, suma;
            suma = 0;
            cuenta = 0;
            saldo = 0;
            do {
                Console.WriteLine("ingrese numero de cuenta: ");
                linea = Console.ReadLine();
                cuenta = int.Parse(linea);
                
                if (cuenta < 0) { }
                else
                {
                    Console.WriteLine("ingrese el saldo actual de la cuenta: ");
                    linea = Console.ReadLine();
                    saldo = int.Parse(linea);
                    if ( saldo > 0)
                    {
                        Console.WriteLine("Acreedor");
                        suma= saldo+suma;

                    }
                    else { if (saldo < 0)
                        {
                            Console.WriteLine("deudor");
                        }
                    else { Console.WriteLine("nulo"); }
                    }
                }
                

                }
            while (cuenta >= 0);
            if(suma > 0) { Console.WriteLine("la suma total de los acredores es: " + suma); }
            
            Console.ReadKey();
        }
    }
}
