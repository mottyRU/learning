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
        }
        public uint this[int k]
        {
            get
            {
                string Z = Convert.ToString(Number, 2);
                Console.WriteLine(Z);
                Priemnik = new uint[Z.Length];
                for (int i = 0; i < Z.Length; i++)
                {
                    Priemnik[k] = Convert.ToUInt32(Z[i]);
                    Console.Write("|" + Priemnik[k]);
                }
                Console.WriteLine("|");
                return Priemnik[k];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BuClass A = new BuClass(150);
            Console.WriteLine(A[0]);
            Console.ReadKey();
        }
    }
}
