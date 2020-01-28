using System;
using System.Diagnostics;
using System.Threading;

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
            Stopwatch timer = new Stopwatch();

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = nummer.Next(Listlängd * 2);
            }
            timer.Start();
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
            timer.Stop();

            TimeSpan tid = timer.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            tid.Minutes, tid.Seconds,
            tid.Milliseconds / 10);
            Console.WriteLine("Tid för sortering: " + elapsedTime);
        }
    }
}