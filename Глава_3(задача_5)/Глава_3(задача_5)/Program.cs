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
            
            Console.WriteLine("Enter day:");
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
                case "Thursday":
                    number = 4;
                    break;
                default:
                    number = 0;                    
                    break;               

            }

            Console.WriteLine(number == 0 ? "Error":""+number+"");
            Console.ReadKey();
        }
    }
}
