using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class CatClass
    {
        private uint Number = 0;
        public void ViewResult()
        {
            Console.WriteLine(Number);
        }
        public uint this[uint i]
        {
            set
            {
                uint Hranitel;
                Hranitel = value % 10;
                Number += Hranitel * Convert.ToUInt32(Math.Pow(10, i));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CatClass A = new CatClass();
            A[0] = 5;
            A.ViewResult();
            A[1] = 56;
            A.ViewResult();
            A[2] = 57;
            A.ViewResult();
            //A[3] = 58;
            //A[4] = 79;
            Console.ReadKey();
        }
    }
}
