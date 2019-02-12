using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_shapeArea
{
    class Program
    {
        int shapeArea(int n)
        {
            int area = 1;
            int x = 4;
            if (n == 1) return area;
            for (int i = 1; i <= n; i++)
            {
                area = x * (i - 1) + area;
            }
            return area;
        }
        static void Main(string[] args)
        {
            Program A = new Program();
            Console.WriteLine(A.shapeArea(7));
            Console.ReadKey();
        }
    }
}
