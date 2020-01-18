using System;

namespace Insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int längd = 10;
            int[] lista = new int[längd];
            Random nummer = new Random();

            for (int j = 0; j < längd; j++)
            {
                lista[j] = nummer.Next(längd * 2);
            }
            for (int i = 1; i < längd; i++)
            {
                int temp = lista[i];
                int n = i - 1;

                while (n >= 0 && lista[n] > temp)
                {
                    lista[n + 1] = lista[n];
                    n--;
                }
                lista[n + 1] = temp;
            }
            Console.WriteLine("Sorterade tal: ");
            foreach (int c in lista)
                Console.WriteLine(c + " ");
        }
    }
}
