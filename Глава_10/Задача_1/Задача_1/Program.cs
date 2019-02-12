using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int year;
            year = Convert.ToInt32(Console.ReadLine());
            int Century = 0;
            string Txt = Convert.ToString(year);
            if (year == 0) Century = 0;
            else if (year >= 1 & year <= 100) Century = 1;
            else if (year >= 100 & year <= 999)
            {
                if (Txt.LastIndexOf("0", Txt.Length - 1, 1) != 1 & Txt.LastIndexOf("0", Txt.Length - 2, 1) != 1)
                {
                    Txt = Txt.Substring(0, 1);
                    Century = Convert.ToInt32(Txt);
                }
                else
                {
                    Txt = Txt.Substring(0, 1);
                    Century = Convert.ToInt32(Txt) + 1;
                }
            }
            else if (year >= 1000 & year <= 9999)
            {
                if (Txt.LastIndexOf("0", Txt.Length - 1, 1) != 1 & Txt.LastIndexOf("0", Txt.Length - 2, 1) != 1)
                {
                    Txt = Txt.Substring(0, 2);
                    Century = Convert.ToInt32(Txt);
                }
                else
                {
                    Txt = Txt.Substring(0, 2);
                    Century = Convert.ToInt32(Txt) + 1;
                }
            }
            Console.WriteLine(Century);
            Console.ReadKey();
        }
    }
}
