using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {

        static void Main(string[] args)
        {
        Start:
            decimal num1;
            decimal num2;
            decimal num3;

            Console.Write("Please input a number: ");
            num1 = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Please input another number: ");
            num2 = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Please input your final number: ");
            num3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Console.Write("The Average is: ");
            decimal averageAmount = (num1 + num2 + num3) / 3;
            Console.WriteLine(Math.Round(averageAmount, 2));

            Console.WriteLine();

            if (num1 >= num2 & num1 > num3)
            {
                Console.Write("First number inputed is the largest: ");
                Console.WriteLine(num1);
            }
            else if (num2 >= num1 & num2 > num3)
            {
                Console.Write("Second number inputed is the largest: ");
                Console.WriteLine(num2);
            }
            else
            {
                Console.Write("Third number inputed is the largest: ");
                Console.WriteLine(num3);
            }

            Console.WriteLine();

            if (num1 <= num2 & num1 < num3)
            {
                Console.Write("First number inputed is the smallest: ");
                Console.WriteLine(num1);
            }
            else if (num2 <= num1 & num2 < num3)
            {
                Console.Write("Second number inputed is the smallest: ");
                Console.WriteLine(num2);
            }
            else
            {
                Console.Write("Third number inputed is the smallest: ");
                Console.WriteLine(num3);
            }

            Console.WriteLine();

            var allTotal = Convert.ToString(num1 + num2 + num3);


            Console.Write("The total in USD is: $");
            Console.WriteLine(string.Format("{0:#.00}", Convert.ToDecimal(allTotal)));
            

            Console.Write("The total in SWK is: KR");
            Console.WriteLine(string.Format("{0:#.00}", Convert.ToDecimal(allTotal)));

            Console.Write("The total in YEN is: ");
            Console.WriteLine(string.Format("{0:#.00}", Convert.ToDecimal(allTotal)));

            Console.Write("The total in TWD is: ฿");
            Console.WriteLine(string.Format("{0:#.00}", Convert.ToDecimal(allTotal)));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to restart!");
            Console.ReadKey();
            goto Start;
        }
    }
}
