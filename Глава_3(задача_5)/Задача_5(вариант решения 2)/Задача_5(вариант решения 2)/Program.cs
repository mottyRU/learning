using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5_вариант_решения_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string day;
            number = 0;
            Console.WriteLine("Enter weekday:");
            day = Console.ReadLine();
            if (day == "Monday")
            {
                number = 1;
            }
            else if (day == "Tuesday")
            {
                number = 2;
            }
            else if (day == "Wednesday")
            {
                number = 3;
            }
            else if (day == "Thursday")
            {
                number = 4;
            }
            else if (day == "Friday")
            {
                number = 5;
            }
            else if (day == "Saturday")
            {
                number = 6;
            }
            else if (day == "Sunday")
            {
                number = 7;
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.WriteLine("Day number is: " + number + "");
            Console.ReadKey();
            }
            
        }
    }

