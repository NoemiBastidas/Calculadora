using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BurbujaOrdenamiento
{
        class Burbuja
        {
            private int[] vector;

            public void Ejecutar()
            {
                Console.WriteLine("Burbuja");
                Console.Write("longitud del vector ");
                string linea;
                linea = Console.ReadLine();
                int cant;
                cant = int.Parse(linea);
                vector = new int[cant];
                for (int f = 0; f < vector.Length; f++)
                {
                    Console.Write("Ingrese elemento " + (f + 1) + ": ");
                    linea = Console.ReadLine();
                    vector[f] = int.Parse(linea);
                }
            }

            public void MetodoBurbuja()
            {
                int j;
                for (int a = 1; a < vector.Length; a++)
                    for (int b = vector.Length - 1; b >= a; b--)
                    {
                        if (vector[b - 1] > vector[b])
                        {
                            j = vector[b - 1];
                            vector[b - 1] = vector[b];
                            vector[b] = j;
                        }
                    }
            }

            public void Imprimir()
            {
                Console.WriteLine("Vector ordenados en forma ascendente");
                for (int f = 0; f < vector.Length; f++)
                {
                    Console.Write(vector[f] + "  ");
                }
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                Burbuja ordenable = new Burbuja();
                ordenable.Ejecutar();
                ordenable.MetodoBurbuja();
                ordenable.Imprimir();
            }
        }    
}
