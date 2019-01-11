using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class MyMegaClass
    {
        private int[] Numbers = new int[5];
        public int[] ZapolnMassive()
        {
            Random rnd = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = rnd.Next(0, 100);
            }
            return Numbers;
        }
        public void PokazMassive()
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write("|" + Numbers[i]);
            }
            Console.WriteLine("|");
        }
        public int CBOiCTBO
        {
            get
            {
                int Summa = Numbers.Sum();
                return Summa;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMegaClass A = new MyMegaClass();
            A.ZapolnMassive();
            A.PokazMassive();
            Console.WriteLine("Сумма элементов: " + A.CBOiCTBO);
            Console.ReadKey();
        }
    }
}
