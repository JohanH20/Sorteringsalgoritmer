using System;
using System.Diagnostics;
using System.Threading;

namespace Insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int längd = 10;
            int[] lista = new int[längd];
            Random nummer = new Random();
            Stopwatch timer = new Stopwatch();

            for (int j = 0; j < längd; j++)
            {
                lista[j] = nummer.Next(längd * 2);
            }
            timer.Start();
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
            timer.Stop();

            TimeSpan tid = timer.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            tid.Minutes, tid.Seconds,
            tid.Milliseconds / 10);
            Console.WriteLine("Tid för sortering: " + elapsedTime);
        }
    }
}
