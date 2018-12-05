using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class MyClass
    {
        public char Symbol;
        public int Number;
        public MyClass(char N, int M)
        {
            Symbol = N;
            Number = M;
        }
        public MyClass(double K)
        {
            string[] Text;
            string ProverkaZnakov;
            Text = Convert.ToString(K).Split((new Char[] {'.', ','}));
            Console.WriteLine(Text[0]);
            Console.WriteLine(Text[1]);
            if (Text[1].Length == 0)
            {
                ProverkaZnakov = "0";
            }
            else if (Text[1].Length == 1)
            {
                ProverkaZnakov = Text[1][0] + "";
            }
            else {ProverkaZnakov = Text[1][0] + Text[1][1] + " "};
            Console.ReadKey();
            Symbol =(char) Convert.ToInt32(Text[0]);
            Number = Convert.ToInt32(ProverkaZnakov);

        }
        public void Show()
        {
            Console.WriteLine("" + Symbol + ", " + Number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MyClass A = new MyClass('A', 55);
            A.Show();
            MyClass B = new MyClass(100*2*rnd.NextDouble());
            B.Show();
            Console.ReadKey();            
        }
    }
}
