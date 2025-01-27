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
            // declaration
            //input
            int month = 0;

            Console.WriteLine("Enter a number for a month (1-12)");
            month = Convert.ToInt32(Console.ReadLine());
            switch (month) {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:

                case 1;
                    Console.WriteLine("31");
                    break;
                case 2;
                    Console.WriteLine("29");
                    break;
                case 3;
                    Console.WriteLine("31");
                    break;
                case 4;
                    Console.WriteLine("31");
                    break;
                case 5;
                    Console.WriteLine("29");
                    break;
                case 6;
                    Console.WriteLine("31");
                    break;
                case 7;
                    Console.WriteLine("31");
                    break;
                case 8;
                    Console.WriteLine("29");
                    break;
                case 9;
                    Console.WriteLine("31");
                    break;
                case 10;
                    Console.WriteLine("31");
                    break;
                case 11;
                    Console.WriteLine("29");
                    break;
                case 12;
                    Console.WriteLine("31");
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }









        }
    }
}
