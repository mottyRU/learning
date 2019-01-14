using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class CatClass
    {
        public uint Number;
        public uint Hranitel;
        public uint this[int i]
        {

            set
            {
                Hranitel = value % 10;
                if (i == 0) Hranitel += 0;
                else if (i == 1) Hranitel += 10;
                else if (i == 2) Hranitel += 100;
                else if (i == 3) Hranitel += 1000;
                else if (i == 4) Hranitel += 10000;
            }
        }
        public void ShowResult()
        {
            Console.WriteLine(Hranitel);
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CatClass A = new CatClass();
            A[2] = 5;
            A.ShowResult();
        }
    }
}
