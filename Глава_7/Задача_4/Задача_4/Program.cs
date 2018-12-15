using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        public static bool Compare(string n, string m)
        {
            char[] Text1 = n.ToCharArray();
            char[] Text2 = m.ToCharArray();
            string Hranitel_1 = "", Hranitel_2 = "";
            foreach (char s in n)
            {
                if (n.Contains(Hranitel_1) == false) Hranitel_1 +=s; 
            }
            String.Sort(Hranitel_1);
            for (int i = 0; i < m.Length; i++)
            {
                if (m.Contains(Text1[i]) == true) Hranitel_2[i] = Text1[i];
            }
            Array.Sort(Hranitel_2);
            if (Hranitel_1 == Hranitel_2) return true;
            return false;

        }
        static void Main()
        {
            string Text1 = "ABCD", Text2 = "DCBA";
            Console.WriteLine("Ищем текст {0}", Text2);
            Console.WriteLine("Text_1 == Text_2: {0}", Compare(Text1, Text2));
            Console.ReadKey();
        }
    }
}
