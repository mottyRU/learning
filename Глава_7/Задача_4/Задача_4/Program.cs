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
            char[] Text1, Text2;
            string Hranitel_1 = "", Hranitel_2 = "";
            foreach (char s in n)
            {
                if (!Hranitel_1.Contains(s)) Hranitel_1 +=s; 
            }
            Text1 = Hranitel_1.ToCharArray();
            Array.Sort(Text1);
            Hranitel_1 = new string (Text1);

            foreach (char s in m)
            {
                if (!Hranitel_2.Contains(s)) Hranitel_2 += s;
            }
            Text2 = Hranitel_2.ToCharArray();
            Array.Sort(Text2);
            Hranitel_2 = new string(Text2);
            if (Hranitel_1 == Hranitel_2) return true;
            return false;

        }
        static void Main()
        {
            string Text1 = "ABDF", Text2 = "DFBAD";
            Console.WriteLine("{0} == {1}: {2}", Text1, Text2, Compare(Text1, Text2));
            Console.ReadKey();
        }
    }
}
