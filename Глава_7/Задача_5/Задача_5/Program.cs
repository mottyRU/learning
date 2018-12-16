using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        public static string IndexSearch(string n, char m)
        {
            int index;
            string A;
            index = n.IndexOf(m);
            A = "" + index;
            return A;
        }
        static void Main()
        {
            string Text = "Hello Wild World";
            char ForSearch = 'W';            
            Console.WriteLine("Search result is: {0}", IndexSearch(Text, ForSearch));
            Console.ReadKey();
        }
    }
}
