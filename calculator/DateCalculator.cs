using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DateCalculator
    {
        public void PerformDateCalculation()
        {
            DateTime enterDate = Prompts.GetDate("Please Enter a Date");
            int numDays = Prompts.GetDaysToAdd("Please enter the number of days to add ");
            DateTime answer = enterDate.AddDays(numDays);

            Console.WriteLine($"Result is: {answer}");
            Console.ReadLine();
        }
    }
}
