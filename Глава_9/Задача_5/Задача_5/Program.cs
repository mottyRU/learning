using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class NewClass
    {
        public static int Step = 2;
        public static int Prev = 1;
        public static int NechentZnachen
        {
            get
            {
                int Res = Prev;
                Prev = Step + Prev;
                return Res;
            }
            set
            {
                Prev = 1;
                Step = 2;
                for (int i = 2; i <= value; i++)
                {
                    Prev = Step + Prev;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //NewClass.NechentZnachen = 6;
            Console.WriteLine(NewClass.NechentZnachen);
            Console.WriteLine(NewClass.NechentZnachen);
            NewClass.NechentZnachen = 5;
            Console.WriteLine(NewClass.NechentZnachen);
            //Console.WriteLine(NewClass.NechentZnachen);
            //Console.WriteLine(NewClass.NechentZnachen);
            Console.ReadKey();
        }
    }
}
