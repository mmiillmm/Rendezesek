using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumKivalasztas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 5, 3, 10, 6, 1, 2, 4, 8 };

            for (int i = 6; i > tomb.Length - 1; i--)
            {
                int max = 0;

                for (int j = 1; j < i; j++)
                {
                    if (tomb[max] < tomb[j])
                    {
                        max = j;
                    }
                }

                int temp = tomb[i];
                tomb[i] = tomb[max];
                tomb[max] = temp;
            }

            foreach (var t in tomb)
            {
                Console.Write($"{t} ");
            }

            Console.ReadKey();
        }
    }
}
