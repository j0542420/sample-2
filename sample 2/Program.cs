using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            int month;

            Console.WriteLine("Enter a number for a month (1-12):");

            // Input validation
            if (int.TryParse(Console.ReadLine(), out month))
            {
                string monthName = "";
                string daysInMonth = "";

                switch (month)
                {
                    case 1:
                        monthName = "January";
                        daysInMonth = "31 days";
                        break;
                    case 2:
                        monthName = "February";
                        daysInMonth = "28 or 29 days (leap year)";
                        break;
                    case 3:
                        monthName = "March";
                        daysInMonth = "31 days";
                        break;
                    case 4:
                        monthName = "April";
                        daysInMonth = "30 days";
                        break;
                    case 5:
                        monthName = "May";
                        daysInMonth = "31 days";
                        break;
                    case 6:
                        monthName = "June";
                        daysInMonth = "30 days";
                        break;
                    case 7:
                        monthName = "July";
                        daysInMonth = "31 days";
                        break;
                    case 8:
                        monthName = "August";
                        daysInMonth = "31 days";
                        break;
                    case 9:
                        monthName = "September";
                        daysInMonth = "30 days";
                        break;
                    case 10:
                        monthName = "October";
                        daysInMonth = "31 days";
                        break;
                    case 11:
                        monthName = "November";
                        daysInMonth = "30 days";
                        break;
                    case 12:
                        monthName = "December";
                        daysInMonth = "31 days";
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
                        return;
                }

                // Output the result
                Console.WriteLine($"The month is {monthName}, and it has {daysInMonth}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}