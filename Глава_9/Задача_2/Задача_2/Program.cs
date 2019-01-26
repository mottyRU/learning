using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class MyNewClass
    {
        private int[] Numbers = new int[5] {1,2,3,4,5};
        private int Index = 0;
        public int CBOiCTBO
        {
            get
            {
                if (Index > 4) Index = 0;
                Index += 1;
                return Numbers[Index-1];
            }
            set
            {
                Numbers[Index-1] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyNewClass A = new MyNewClass();
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            A.CBOiCTBO = 10;
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.WriteLine("Значение элемента массива: " + A.CBOiCTBO);
            Console.ReadKey();
        }
    }
}
