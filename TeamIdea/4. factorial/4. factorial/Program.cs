using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.factorial
{
    class Program
    {
        static string factorial(int n)
        {
            int A = 1;
            for (int i = 1; i <= n; i++)
            {
                A *= i;
            }
            return Convert.ToString(A);
        }
        static int ZeroCount(string n)
        {
            int count = 0;
            for (int i = 0; i < n.Length; )
            {
                if (Convert.ToInt32(n[i]) == 0)
                {
                    count++;
                    i++;
                }
                else i++;

            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write(ZeroCount(factorial(5)));
            Console.ReadKey();
        }
    }
}
