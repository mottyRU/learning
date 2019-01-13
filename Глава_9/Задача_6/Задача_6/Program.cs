using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class MyyClass
    {
        public int[] Numbers;
        public MyyClass(int n)
        {
            Numbers = new int[n];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = i;
            }
        }
        public int this[int k]
        {
            get
            {
                int num = Numbers[k];
                return num;
            }
            set
            {
                Numbers[k] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyyClass A = new MyyClass(5);
            Console.WriteLine(A[4]);
            A[4] = 10;
            Console.WriteLine(A[4]);
            Console.ReadKey();
        }
    }
}
