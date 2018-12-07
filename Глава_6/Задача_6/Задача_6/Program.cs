using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class MyClass
    {
        private int Max, Min;
        public void Prisvoit(int n)
        {
            int Hranitel;
            Random rnd = new Random();
            Max = rnd.Next(100);
            Min = rnd.Next(100);
            if (Min > Max)
            {
                Hranitel = Max;
                Max = Min;
                Min = Hranitel;
            }
            Console.WriteLine(""+n+", "+Max+", "+Min+"");
            if (Min > Max)
            {
                Hranitel = Max;
                Max = Min;
                Min = Hranitel;
            }
            else if (n > Max)
            {
                Max = n;
            }
        }
        public void Prisvoit(int n, int m)
        {

        }
        public void Show()
        {
            Console.WriteLine(""+Max+", "+Min+"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MyClass A = new MyClass();
            A.Prisvoit(rnd.Next(100));
            A.Show();
            Console.ReadKey();
        }
    }
}
