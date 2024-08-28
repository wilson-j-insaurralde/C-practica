using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mostrar los múltiplos de 8 hasta el valor 500. Debe aparecer en pantalla 8 - 16 - 24, etc

namespace ejercicio36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int  y ;
            
            y = 8 ;
            while (y <= 500)
            {
                Console.Write(y);
                Console.Write('-'); 
                y = y + 8;

            }
            Console.ReadKey();
        }
    }
}
