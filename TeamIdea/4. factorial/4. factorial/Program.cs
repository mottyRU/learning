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
            Int64 A = 1;
            for (int i = 1; i <= n; i++)
            {
                A *= i;
            }
            return Convert.ToString(A);
        }
        static int ZeroCount(string n)
        {
            int count = 0;
            for (int i = n.Length-1; i > 0; i--)
            {
                if (Char.GetNumericValue(n[i]) == 0) count++;
                else break;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write(ZeroCount(factorial(10)));
            Console.ReadKey();
        }
    }
}
