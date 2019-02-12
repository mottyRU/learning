using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_Polindrom
{
    class Program
    {
        public bool CheckPolindrom(string n)
        {
            return n == new string(n.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            Program A = new Program();
            Console.Write(A.CheckPolindrom("aabaa"));
            Console.ReadKey();
        }
    }
}
