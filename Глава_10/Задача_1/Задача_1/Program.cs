using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Base
    {
        protected string BaseText;
        public Base(string n)
        {
            BaseText = n;
        }
        public override string ToString()
        {
            string Text = "";
            Text += "Base class: " + BaseText;
            return Text;
        }
    }
    class Alpha : Base
    {
        protected string AlphaText;
        public Alpha(string n) : base(n)
        {
            AlphaText = n;
        }
        public Alpha (string n, string m) : base(m)
        {
            AlphaText = n;
        }
        public override string ToString()
        {
            string Text = "";
            if (BaseText == "") Text += "Alpha class: " + AlphaText;
            else if (BaseText != "") Text += "Alpha class: " + AlphaText + "\n" + "Base class: " + BaseText;
            return Text;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base A = new Base("Hello_Wild_World");
            //Alpha B = new Alpha("Good_bye_Wild_World", "Rrrrr");
            Alpha B1 = new Alpha("Good_bye_Wild_World");
            Console.WriteLine(A);
           // Console.WriteLine(B);
            Console.WriteLine(B1);
            Console.ReadKey();
        }
    }
}
