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
        public int Priemnik;
        public MyyClass(int n, int m)
        {
            Numbers = new int[n];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = i;
            }
            Priemnik = m;
        }
        public int this[int k]
        {
            get
            {
                int num = Numbers[k-Priemnik];
                return num;
            }
            set
            {
                Numbers[k-Priemnik] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyyClass A = new MyyClass(5, 10);
            Console.WriteLine(A[1]);
            A[1] = 10;
            Console.WriteLine(A[1]);
            
            Console.ReadKey();
        }
    }
}
