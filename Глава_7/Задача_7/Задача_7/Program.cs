using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        public static string MethodSubstring(string s, int n, int m)
        {
            string NewText = "";
            for (int i = n; i < s.Length; i++)
            {
                NewText += s[i];
                if (NewText.Length == m) break;
            }            
            return NewText;
        }
        static void Main()
        {
            string Text = "Hello_Wild_World";
            int a = 2, b = 5;
            Console.WriteLine("Result is: {0}", MethodSubstring(Text, a, b));
            Console.ReadKey();
        }
    }
}
