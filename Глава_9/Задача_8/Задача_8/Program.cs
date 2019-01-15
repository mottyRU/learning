using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class CatClass
    {
        private uint Number;
        private uint Hranitel;
        private uint NewValue;
        public uint this[int i]
        {
            set
            {
                Number = value % 10;
                if (i == 0)
                {
                    Number += 0;
                    Hranitel = Number;
                    Console.WriteLine(Number);
                }                    
                else if (i == 1)
                {
                    NewValue = Number*10 + Hranitel;
                    Number = NewValue;
                    Console.WriteLine(NewValue);
                }
                else if (i == 2)
                {
                    NewValue = Number * 100 + NewValue;
                    Number = NewValue;
                    Console.WriteLine(NewValue);
                }
                else if (i == 3)
                {
                    NewValue = Number * 1000 + NewValue;
                    Number = NewValue;
                    Console.WriteLine(NewValue);
                }
                else if (i == 4)
                {
                    NewValue = Number * 10000 + NewValue;
                    Number = NewValue;
                    Console.WriteLine(NewValue);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CatClass A = new CatClass();
            A[0] = 5;
            A[1] = 56;
            A[2] = 57;
            A[3] = 58;
            A[4] = 79;
            Console.ReadKey();
        }
    }
}
