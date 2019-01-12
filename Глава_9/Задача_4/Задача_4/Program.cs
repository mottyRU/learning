using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class BearClass
    {
        private uint Number;
        private string Text;
        public BearClass(uint n, string m)
        {
            Number = n;
            Text = m;
        }
        public uint PrisvoitZnachenie
        {
            set
            {
                if (value < 0) value = 99;
                Number = value;
                uint A = Number % 8;
                uint B = (Number / 8) % 8;
                Text = "Number =  " +  B + A;
            }
        }
        public override string ToString()
        { 
            return Text;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BearClass A = new BearClass(25, "31");
            A.PrisvoitZnachenie = 19;
            /*int z = 19;
            int y = 8;
            int x = z % y;
            int w = (z / y)%8;
            string txt ="";
            Console.WriteLine(x);
            Console.WriteLine(w);
            Console.WriteLine(txt + w + x);*/
            Console.WriteLine(A);
            Console.ReadKey();
        }
    }
}
