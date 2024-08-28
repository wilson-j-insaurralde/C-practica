using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
//Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas
namespace ejercicio69
{
    class VectorFloat
    {
        private float[] alturas;
        private float promedio;

        public void Carga()

        {   alturas = new float[5];
            for (int i = 0; i < 5; i++)
            {
                string linea;
                Console.WriteLine("cargar altura: ");
                linea = Console.ReadLine();
                alturas[i]=float.Parse(linea);

            }    
        }
        public void Promedio()
        {
            float suma;
            suma=0;
            for (int i = 0;i < 5; i++)
            {
                suma = suma + alturas[i];
            }
            promedio = suma/5;
            Console.WriteLine("el promedio es: " + promedio);


        }
        public void MasAltasPromedio()
        {
            int cont;
            cont = 0;
            for (int i = 0 ; i<5 ; i++)
            {
                if (alturas[i] > promedio)
                {
                    cont = cont + 1;
                }
            }
            Console.WriteLine("la cantidad de personas mas alta que el promedio son: "+cont);
        }
        public void MasBajaPromedio() 
        {   int cont;
            cont = 0;
            for(int i = 0 ;i<5 ;i++)
            {
                if (alturas[i] < promedio) { cont = cont + 1; }
            }
            Console.WriteLine("la cantidad de personas mas bajas que el promedio son: "+cont);
        }
            

        static void Main(string[] args)
        {
            VectorFloat vec1= new VectorFloat();
            vec1.Carga();
            vec1.Promedio();
            vec1.MasAltasPromedio();
            vec1.MasBajaPromedio();
            Console.ReadKey();

        }
    }
}
