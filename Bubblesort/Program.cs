using System;

namespace Bubblesort
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int Listlängd = 100000;
            int[] lista = new int[Listlängd];
            Random nummer = new Random();

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = nummer.Next(Listlängd * 2);
            }
            for (int i = 0; i < lista.Length; i++)
            {
                for (int j = 0; j < lista.Length - 1 - i; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        Swap(ref lista[j], ref lista[j + 1]);
                    }
                }
            }
            Console.WriteLine("Sorterade tal: ");
            foreach (int c in lista)
                Console.WriteLine(c + " ");
        }
    }
}