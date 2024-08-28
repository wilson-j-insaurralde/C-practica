using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Confeccionar una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor.
//    Finalizar el programa al ingresar el -1.
namespace ejercicio66
{
    class Entero
    {
        private int num;
        public void Inicializar() 
        {
            do {
                string linea;
                Console.Write("ingrese el numero: ");
                linea = Console.ReadLine();
                num=int.Parse(linea);
                if (num != -1)
                {
                    CalcularTabla(num);
                }

                
                } while (num != -1);
        }
        public void CalcularTabla(int v)
        { for (int i = v; i<=v*10; i = i + v)
            {
                Console.WriteLine(i);
            }

        }

        static void Main(string[] args)
        {
            Entero Entero1 = new Entero();
            Entero1.Inicializar();

        }
    }
}
