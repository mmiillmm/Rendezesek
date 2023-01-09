using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beszuro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beszúró rendezés");

            int[] tomb = new int[] { 5, 3, 10, 6, 1, 2, 4, 8,1 };

            for (int i = 1; i < tomb.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && tomb[j] > tomb[j+1])
                {
                    int temp = tomb[j];
                    tomb[j] = tomb[j + 1];
                    tomb[j + 1] = temp;
                    j--;
                }
            }

            foreach (var t in tomb)
            {
                Console.Write($"{t} ");
            }

            Console.ReadKey();
        }
    }
}
