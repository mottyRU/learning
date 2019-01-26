using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10._9
{
    class Alpha
    {
        protected string Text = "Alpha Class!";
        public virtual string TextReturn
        {
            get
            {
                return Text;
            }
            set
            {
                Text = value;
            }
        }
        public override string ToString()
        {
            string Txt = "";
            Txt += "Alpha class: " + Text;
            return Txt;
        }
    }
    class Bravo : Alpha
    {
        protected string BrText = "Bravo class!";
        public override string TextReturn
        {
            get
            {
                string Txt = "";
                Txt = String.Concat(BrText, "_", Text);
                return Txt;
            }
            set
            {
                int A = value.IndexOf(" ");
                if (A != -1)
                {
                    Text = value.Substring(0, A);
                    BrText = value.Substring(A+1);
                }
                else
                {
                    Text = value;
                    BrText = "";
                }

            }
        }
        public override string ToString()
        {
            string Txt = "";
            Txt += "Bravo class: " + Text;
            Txt += "\nBravo class: " + BrText;
            return Txt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Alpha A = new Alpha();
            //Console.WriteLine(A.TextReturn);
            //A.TextReturn = "Goodbye";
            //Console.WriteLine(A);
            Bravo B = new Bravo();
            Console.WriteLine(B.TextReturn);
            B.TextReturn = "Hranitel Vreditel";
            Console.WriteLine(B);
            Console.ReadKey();
        }
    }
}
