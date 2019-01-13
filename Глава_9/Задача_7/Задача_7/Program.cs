using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class BuClass
    {
        private uint Number;
        private uint[] Priemnik;
        public BuClass(uint n)
        {
            Number = n;
            string Z = Convert.ToString(Number, 2);
            Console.WriteLine(Z);
            Priemnik = new uint[Z.Length];
            for (int i = 0; i < Z.Length; i++)
            {
                Priemnik[i] = Convert.ToUInt32(Z[i]);
                Console.Write("|" + Priemnik[i]);
            }
            Console.WriteLine("|");
        }
        public uint this[int k]
        {
            get
            {
                return Priemnik[k];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BuClass A = new BuClass(150);
            Console.WriteLine(A[7]);
            Console.ReadKey();
        }
    }
}
