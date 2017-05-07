using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine("Please enter the first number: "+ a );
            Console.WriteLine("Please enter the first number: " + b);
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));
            if (a > b)
            {
                Console.WriteLine(a +" is greater than " + b);
            }
            else if (a < b)
            {
                Console.WriteLine(a + " is less than " + b);
            }
            else if (a == b)
            {
                Console.WriteLine(a + " is equal " + b);
            }
            Console.Read();
        }
    }
}
