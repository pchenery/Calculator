using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string myFirstNumber = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            string mySecondNumber = Console.ReadLine();

            int myMultiple = int.Parse(myFirstNumber) * int.Parse(mySecondNumber);
            Console.WriteLine($"Multiple is: {myMultiple}");
            Console.ReadLine();
        }
    }
}
