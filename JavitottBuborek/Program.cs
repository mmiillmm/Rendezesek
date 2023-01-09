using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavitottBuborek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Javított buborék rendezés");
            int[] tomb = new int[] { 5, 3, 10, 6, 1, 2, 4, 8 };

            int i = tomb.Length - 1;

            while (i >= 1)
            {
                int csereHelye = -1;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (tomb[j] > tomb[j+1])
                    {
                        csereHelye = j;
                        int temp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = temp;
                    }
                }

                i = csereHelye;
            }

            foreach (var t in tomb)
            {
                Console.Write($"{t} ");
            }

            Console.ReadLine();
        }
    }
}
