﻿using System;
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
                    day = "Error!";
                    break;               

            }
            
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
