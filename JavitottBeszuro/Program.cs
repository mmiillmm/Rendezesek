using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavitottBeszuro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Javított beszúró rendezés");

            int[] tomb = new int[] { 5, 3, 10, 6, 1, 2, 4, 8, 1 };

            for (int i = 1; i < tomb.Length; i++)
            {
                int j = i - 1;
                int tmp = tomb[i];
                while (j >= 0 && tomb[j] > tmp)
                {
                    tomb[j + 1] = tomb[j];
                    j--;
                }
                tomb[j + 1] = tmp;
            }

            foreach (var t in tomb)
            {
                Console.Write($"{t} ");
            }

            Console.ReadLine();

        }
    }
}
