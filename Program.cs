using System;



using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;

            string text = Console.ReadLine();

            int[] array = new int[] { 1, 2, 3, 4, 5 };

            if (int.TryParse(text, out val))
            {
                UberMathLibrary lib = new UberMathLibrary();

                val = val / lib.GetNormalization(val);

                for (int i=0;i<array.Length;i++)
                {
                    array[i] += val;

                    if (array[i] > 8)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
