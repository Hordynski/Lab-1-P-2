using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1P2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime Date1, Date2;
            TimeSpan timeSpan1, timeSpan2, timeSpan3;
            double minuteDifference, hourDifference, dayDifference;
            bool repeat1 = true, repeat2 = true;
            char runAgain;

            while (repeat1 == true)
            {
                try
                {
                    Console.WriteLine("Hello user! Please enter your first date. (MM/DD/YYYY)");
                    Date1 = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Thank you for your entry. Please enter a second date. (MM/DD/YYYY)");
                    Date2 = DateTime.Parse(Console.ReadLine());

                    timeSpan1 = (Date2 - Date1);
                    minuteDifference = timeSpan1.TotalMinutes;
                    Console.WriteLine("The difference in minutes is {0}.", minuteDifference);

                    timeSpan2 = (Date2 - Date1);
                    hourDifference = timeSpan1.TotalHours;
                    Console.WriteLine("The difference in hours is {0}.", hourDifference);

                    timeSpan3 = (Date2 - Date1);
                    dayDifference = timeSpan3.TotalDays;
                    Console.WriteLine("The difference in days is {0}.", dayDifference);
                }
                catch (Exception)
                {
                    Console.WriteLine("I'm sorry. I do not recognize that input.");
                }

                    Console.WriteLine("Would you like to run this program again? (Y or N)");
                    runAgain = Convert.ToChar(Console.ReadLine());

                    if (runAgain == 'y' || runAgain == 'Y')
                    {
                        repeat1 = true;
                    }

                    else
                    {
                        repeat1 = false;
                    }
            }

        }
    }
}
