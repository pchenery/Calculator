using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DateCalculator : ICalculator
    {
        public void PerformCalculation()
        {
            DateTime enterDate = Prompts.GetDate("Please Enter a Date");
            int numDays = Prompts.GetDaysToAdd("Please enter the number of days to add ");
            DateTime answer = enterDate.AddDays(numDays);

            Console.WriteLine($"Result is: {answer}");
            Console.ReadLine();
        }
    }
}
