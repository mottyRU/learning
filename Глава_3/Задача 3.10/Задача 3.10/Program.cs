using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, A, B, C;
            A = 1;
            B = 0;
            Console.WriteLine("Enter n:");
            for (n = Int32.Parse(Console.ReadLine()); n != 0; n--)
            {           
                
                if ((A % 5==2)&(A % 3==1))
                {
                    B +=A;
                    Console.WriteLine("" + A + "");
                }
                A++;
            }
            Console.WriteLine("Sum:" + B + "");
            Console.ReadKey();
        }
    }
}
/* int A, B, C, n;
            A = B = 1;
            C = A + B;
            string step;
            Console.WriteLine("Enter step number:");
            for (n = Int32.Parse(Console.ReadLine()); n == 0; n--)
            {
                A = B = 1;
                C = A + B;
                B = (A + B);
                A = B;
                Console.WriteLine("Result is: "+A, B, C+"");
            }
            Console.ReadKey();*/
