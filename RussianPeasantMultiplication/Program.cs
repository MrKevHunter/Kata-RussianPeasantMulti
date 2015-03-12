using System;

namespace RussianPeasantMultiplication
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         Console.WriteLine("Enter First Number");
         int lhs = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter Second Number");
         int rhs = int.Parse(Console.ReadLine());
         int output = new Multiplication().Multiply(lhs, rhs);
         Console.WriteLine("Answer is {0}", output);
         Console.ReadLine();
      }
   }
}