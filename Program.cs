using System;

namespace OrdenamientoBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arreglo de ejemplo con 10 valores
            int[] Valores = new int[10] { 10, 5, 35, 11, 3, 9, 15, 2, 12, 1 };
            int Auxiliar = 0;

            // Se hace un recorrido desde el segundo elemento hasta el ultimo
            for (int i = 1; i < Valores.Length; i++)
            {
                for (int j = 0; j < Valores.Length - i; j++)
                {


                    if (Valores[j] > Valores[j + 1])
                    {
                        Auxiliar = Valores[j];
                        Valores[j] = Valores[j + 1];
                        Valores[j + 1] = Auxiliar;
                    }
                }
            }

            for (int i = 0; i < Valores.Length; i++)
            {
                Console.WriteLine(Valores[i]);
            }
            Console.ReadLine();

        }
    }
    
}
