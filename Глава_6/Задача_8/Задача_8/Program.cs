using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class MyClass
    {
        private static int Number = 0;
        public static void Show()
        {
            Console.WriteLine(Number++);
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass.Show();
            MyClass.Show();
            Console.ReadKey();
        }
    }
}
