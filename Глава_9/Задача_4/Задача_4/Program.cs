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
        public BearClass(uint n)
        {
            Number = n;
            Text = Convert.ToString(Number, 8);
        }
        public uint PrisvoitZnachenie
        {
            set
            {
                if (value < 0) Number = 99;
                else Number = value;
                //uint A = Number % 8;
                //uint B = (Number / 8) % 8;
                string A = Convert.ToString(Number, 8);
                Text = "Number =  " +  A;
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
            BearClass A = new BearClass(25);
            A.PrisvoitZnachenie = 19;
            Console.WriteLine(A);
            Console.ReadKey();
        }
    }
}
