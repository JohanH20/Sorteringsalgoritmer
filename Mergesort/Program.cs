using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace Mergesort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> osorterad = new List<int>();
            List<int> sorterad;
            int längd = 1000000;
            Random nummer = new Random();
            Stopwatch timer = new Stopwatch();

            for (int i = 0; i < längd; i++)
            {
                osorterad.Add(nummer.Next(längd * 2));
            }
            timer.Start();
            sorterad = MergeSort(osorterad);
            timer.Stop();

            foreach (int x in sorterad)
            {
                Console.WriteLine(x);
            }

            TimeSpan tid = timer.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            tid.Minutes, tid.Seconds,
            tid.Milliseconds / 10);
            Console.WriteLine("Tid för sortering: " + elapsedTime);
        }
        private static List<int> MergeSort(List<int> osorterad)
        {
            if (osorterad.Count <= 1)
                return osorterad;

            List<int> vänstra = new List<int>();
            List<int> högra = new List<int>();

            int mitten = osorterad.Count / 2;
            for (int i = 0; i < mitten; i++)
            {
                vänstra.Add(osorterad[i]);
            }
            for (int i = mitten; i < osorterad.Count; i++)
            {
                högra.Add(osorterad[i]);
            }

            vänstra = MergeSort(vänstra);
            högra = MergeSort(högra);
            return Merge(vänstra, högra);
        }

        private static List<int> Merge(List<int> vänstra, List<int> högra)
        {
            List<int> resultat = new List<int>();

            while (vänstra.Count > 0 || högra.Count > 0)
            {
                if (vänstra.Count > 0 && högra.Count > 0)
                {
                    if (vänstra.First() <= högra.First())
                    {
                        resultat.Add(vänstra.First());
                        vänstra.Remove(vänstra.First());
                    }
                    else
                    {
                        resultat.Add(högra.First());
                        högra.Remove(högra.First());
                    }
                }
                else if (vänstra.Count > 0)
                {
                    resultat.Add(vänstra.First());
                    vänstra.Remove(vänstra.First());
                }
                else if (högra.Count > 0)
                {
                    resultat.Add(högra.First());

                    högra.Remove(högra.First());
                }
            }
            return resultat;
        }
    }
}