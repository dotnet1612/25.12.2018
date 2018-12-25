using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2512
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            // int short byte double float long double string boolean?

            int a, b;

            Console.WriteLine("Please write your name:");

            string name = Console.ReadLine();

            Console.Write("Hello ");
            Console.WriteLine(name);

            Console.Write("Please enter 1st number:" );
            // 1
            //string stringNumber = Console.ReadLine();
            //a = Convert.ToInt32(stringNumber);

            // 2
            a = Convert.ToInt32( Console.ReadLine() );

            Console.Write("Please enter 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.Write("Sum is : ");
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
