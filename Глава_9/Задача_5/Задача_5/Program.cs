using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class NewClass
    {
        public static int Last = 2;
        public static int Prev = 1;
        public static int NechentZnachen
        {
            get
            {
                int Res = Prev;
                Prev = Last + Prev;
                return Res;
            }
            set
            {
                Prev = 1;
                Last = 2;
                for (int i = 2; i <=value; i++)
                {
                    Prev = Last + Prev;
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
