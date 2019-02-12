using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_adjacentElementsProduct
{
    class Program
    {
        public int adjacentElementsProduct(int[] inputArray)
        {
            int MaxValue = -1000;
            if (inputArray.Length < 2 & inputArray.Length > 10) return MaxValue = 0;
            else
            {
                int Dergatel = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i == 0) Dergatel = inputArray[i] * inputArray[i + 1];
                    if (Dergatel > MaxValue) MaxValue = Dergatel;
                    else if (i == inputArray.Length - 1) Dergatel = inputArray[i] * inputArray[i - 1];
                    if (Dergatel > MaxValue) MaxValue = Dergatel;
                    else if (i != 0 & i != inputArray.Length - 1) Dergatel = inputArray[i] * inputArray[i - 1];
                    if (Dergatel > MaxValue) MaxValue = Dergatel;
                    else if (i != 0 & i != inputArray.Length - 1) Dergatel = inputArray[i] * inputArray[i + 1];
                    if (Dergatel > MaxValue) MaxValue = Dergatel;
                }
            }
            return MaxValue;
        }
        static void Main(string[] args)
        {
            Program A = new Program();
            int[] Numbers = new int[] { -23, 4, -3, 8, -12 };            
            Console.WriteLine(A.adjacentElementsProduct(Numbers));
            Console.ReadKey();
        }
    }
}
