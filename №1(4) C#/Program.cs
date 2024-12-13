using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perimeter of a square");

            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Error");
                return;
            }

            double result = (a + b) * 2;

            Console.WriteLine(result);
        }
    }
}
//==============================================================

//namespace Exercise4_2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("If the number is a pair, then divide by 2");
//            Console.WriteLine("If the number is unpaired, then multiply by 2");
//            Console.WriteLine("If the number is 100, then take its root");

//            Console.Write("Enter your number: ");
//            double a = Convert.ToDouble(Console.ReadLine());

//            double result = 0;

//            if (a % 2 == 0 && a != 100)
//            {
//                result = a / 2;

//            }
//            else if (a % 2 != 0)
//            {
//                result = a * 2;
//            }
//            else
//            {
//                result = Math.Sqrt(a);
//            }

//            Console.Write($"Result: {result}\n");

//        }
//    }
//}

//==============================================================

//namespace Exercise4_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Write the number whose factorial you want to know.");

//            Console.Write("Enter your number: ");
//            int a = Convert.ToInt32(Console.ReadLine());

//            int result = 1;

//            for (int i = a; i != 0; i--)
//            {
//                result *= i;
//            }

//            Console.Write($"Result: {result}\n");

//        }
//    }
//}