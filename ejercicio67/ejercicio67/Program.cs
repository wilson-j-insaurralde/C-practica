using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Confeccionar una clase que permita ingresar tres valores por teclado. Luego mostrar el mayor y el menor.
namespace ejercicio67
{
     class MostrarMayorMenor
    {
        int v1, v2, v3;
        public void MayorMenor() 
        {
            string linea;
            Console.WriteLine("ingrese el primer numero:  ");
            linea = Console.ReadLine();
            v1=int.Parse(linea);
            Console.WriteLine("ingrese el sugundo numero: ");
            linea=Console.ReadLine();
            v2=int.Parse(linea);
            Console.WriteLine("ingrese el tercer numero: ");
            linea=Console.ReadLine();
            v3=int.Parse(linea);
            int Mayor, Menor;
            Mayor = CalcularMayor (v1, v2, v3); 
            Menor = CalcularMenor (v1, v2, v3);
            Console.WriteLine("el mayor es: " + Mayor);
            Console.WriteLine("el menor es: "+ Menor);

        }
        public int CalcularMayor (int x,int y,int z) 
        {
            if (x>y && x>z) { return x; }
            else {  if (y>z) { return y; }
                    else {  return z; } 
                  }

        }
        public int CalcularMenor(int x, int y, int z)
        {
            if (x < y && x < z) { return x; }
            else
            {
                if (y < z) { return y; }
                else { return z; }
            }

        }
        static void Main(string[] args)
        {
            MostrarMayorMenor mostrar = new MostrarMayorMenor();
            mostrar.MayorMenor();
            Console.ReadKey();

        }
    }
}
