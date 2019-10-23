using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EERrrr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            string input = Console.ReadLine();
            int numOne = Convert.ToInt32(input);
            Console.WriteLine("Enter a number");
            input = Console.ReadLine();
            int numTwo = Convert.ToInt32(input);
            int sum = subNumbers(numOne, numTwo);
            Console.WriteLine(sum);
            Console.WriteLine("Enter a number");
            int numThree = Convert.ToInt32(Console.ReadLine());
            sum = subNumbers(numThree, sum);
            Console.WriteLine("THe final sub total is " + -sum);
         
            Console.ReadLine();
        }
        static int subNumbers(int one, int two)
        {
            int sum = one - two;
            return sum;
          
        }
    }
}
