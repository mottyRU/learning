using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_almostIncreasingSequence
{
    class Program
    {
        public bool almostIncreasingSequence(int[] n)
        {
            bool A = true;
            for (int i = 0; i < n.Length; )
            {
                if (i == n.Length) break;
                else if (n[i] < n[i+1])
                {
                    A = true;
                    i++;
                }
                else if (n[i] == n[i+1])
                {
                    if (n[i] == n[i + 2])
                    {
                        A = false;
                        i++;
                    }
                    else if (n[i] > n[i + 1])
                    {
                        A = false;
                        i++;
                    }
                    else if (n[i] < n[i + 1])
                    {
                        A = true;
                        i++;
                    }
                } 
                else if (n[i] > n[i+1])
                {
                    if (i == n.Length - 1 - 1)
                    {
                        if(n[n.Length-1] < n[i])
                        {
                            A = false;
                            i++;
                        }
                    }
                    else if (n[i] > n[i + 2])
                    {
                        A = false;
                        i++;
                    }
                    else if (n[i] == n[i + 2])
                    {
                        A = false;
                        i++;
                    }
                    else if (n[i] < n[i + 2])
                    {
                        A = true;
                        i++;
                    }
                }
            }
            return A;
        }
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 1, 3, 2, 1 };
            Program A = new Program();
            Console.WriteLine(A.almostIncreasingSequence(Numbers));
            Console.ReadKey();
        }
    }
}
