using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Глава_3_задача_5_
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
            switch(day)
            {
                case "Monday":
                    number = 1;
                    break;
                case "Tuesday":
                    number = 2;
                    break;
                case "Wednesday":
                    number = 3;
                    break;
                case "Thursday:":
                    number = 4;
                    break;
                case "Friday":
                    number = 5;
                    break;
                case "Saturday":
                    number = 6;
                    break;
                case "Sunday":
                    number = 7;
                    break;
                default:
                    Console.WriteLine(number == 0?"Error!": "Day number is: "+number+"");
                    break;                
            }
            Console.WriteLine("Day number is: "+number+"");
            Console.ReadKey();
        }
    }
}
