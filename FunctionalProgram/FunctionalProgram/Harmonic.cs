using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Harmonic
    {
        static public void SumofHarmonic()
        {
            Console.WriteLine("Enter number for Harmonic Series");
            int num = Convert.ToInt32(Console.ReadLine());
            double i, s = 0.0;
            for (i = 1; i <= num; i++)
            {
                s = s + 1 / i;

                Console.WriteLine("Sum is:" + s);
            }
        }
    }
}
