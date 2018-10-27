using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, n;
            A = B = 1;
            
            string step;
            Console.WriteLine("Enter step number:");
            for (n = Int32.Parse(Console.ReadLine()); n == 0; --n)
            {
                
                C = A + B;
                A = B;
                B = C;
                                                
            }
            Console.WriteLine("Result is: " + A, B, C + "");
            Console.ReadKey();
        }
    }
}
