using System;

namespace Reverse3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter 1st integer: ");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd integer: ");
            int middleInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 3rd integer: ");
            int lastInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The original numbers are {firstInt}, {middleInt}, {lastInt}.");
            Console.WriteLine();
            Reference(ref firstInt, ref middleInt, ref lastInt);
            Console.WriteLine();
            Console.WriteLine($"The original numbers are {firstInt}, {middleInt}, {lastInt}.");
        }
        private static void Reference(ref int firstInt, ref int middleInt, ref int lastInt) {
            int placeholder = 0 ;

            placeholder = firstInt;
            firstInt = lastInt;
            lastInt = placeholder;

       
        }
    }
}
