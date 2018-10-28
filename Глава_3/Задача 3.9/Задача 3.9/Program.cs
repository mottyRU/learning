using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Enter A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B:");
            B = Convert.ToInt32(Console.ReadLine());
            if (A >= B)
            {
                if (A == B)
                {
                    Console.WriteLine("Error! A = B");
                }
                else
                {
                    while (A == B)
                    {
                        B = B++;
                        Console.WriteLine("" + B + "");
                    }
                    Console.WriteLine("End of program.");
                }                
            }
            else
            {
                do
                {
                    A++;
                }
                while (A == B);
            }
            Console.ReadKey();
        }
    }
}
