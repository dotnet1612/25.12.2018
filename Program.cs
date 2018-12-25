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
            /*
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

    */

            Console.WriteLine("Enter a number (zugi/ezugi):");
            int numberZugi = Convert.ToInt32(Console.ReadLine());

            if(numberZugi % 2 == 0)
            {
                // here will be done when true zugi
                Console.WriteLine("Zugi");
            }
            else
            {
                // here will be done when false ezugi
                Console.WriteLine("E Zugi");
            }

            if (numberZugi % 2 == 0 && numberZugi % 5 == 10)
            {
                Console.WriteLine("Divide by 10 without reminder!");
            }
            else
            {
                Console.WriteLine("Does NOT divide by 10 without reminder!");
            }
            
            // number 1 or 2 print small else print big
            if (numberZugi == 1 || numberZugi == 2)
            {
                Console.WriteLine("Small number");
            }
            else
            {
                Console.WriteLine("Large numnber");
            }


            Console.ReadLine();

        }
    }
}
