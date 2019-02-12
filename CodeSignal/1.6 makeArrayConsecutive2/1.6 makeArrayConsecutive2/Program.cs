using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_makeArrayConsecutive2
{
    class Program
    {
        int makeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);
            int count = 0;
            for (int i = 0; i < statues.Length; i++)
            {
                if (i == statues.Length-1) break;
                else if (statues[i] + 1 == statues[i + 1])
                {
                    continue;
                }
                else
                {
                    do
                    {
                        count++;
                        if (i == statues.Length-1) break;
                        statues[i] += 1;
                    }
                    while (statues[i] + 1 != statues[i + 1]);
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] NumberMassive = new int[] { 6, 2, 3, 8 };
            Program A = new Program();
            Console.Write(A.makeArrayConsecutive2(NumberMassive));
            Console.ReadKey();
        }
    }
}
