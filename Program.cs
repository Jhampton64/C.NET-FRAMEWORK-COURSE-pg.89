using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_pg._89
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to Multiply:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int num2 = 50;

            int product = num1 * num2;

            Console.WriteLine(product);

            Console.WriteLine("Enter a number to Add:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int num4 = 25;

            int total = num3 + num4;

            Console.WriteLine(total);


            Console.WriteLine("Enter a number to Divide:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double num6 = 12.5;

            double quotient = num5 / num6;

            Console.WriteLine(quotient);

            Console.WriteLine("Enter a number greater than 50:");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int num8 = 50;

            bool isgreater = num7 > num8;
            Console.WriteLine(isgreater);
            


            Console.WriteLine("Enter a number to find the remainder:");
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int num10 = 7;

            int remainder = num9 % num10;

            Console.WriteLine(remainder);



            Console.ReadLine();


        }

    }
}
