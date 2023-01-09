using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszeruCseres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Egyszerű cserés rendezés");

            int[] tomb = new int[] { 5,3,10,6,1,2,4,8};

            for (int i = 0; i < tomb.Length-1; i++)
            {
                for (int j = i+1 ; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        int temp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = temp;
                    }
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
