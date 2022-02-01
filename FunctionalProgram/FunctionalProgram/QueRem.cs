using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class QueRem
    {
        static public void FindQueRem()
        {
            int num1, num2, que, rem;
            Console.WriteLine("Enter number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            que = num1 / num2;
            rem = num1 % num2;
            Console.WriteLine("Quoetient is:" + que + " Reminder is:" + rem);
        }
    }
}
