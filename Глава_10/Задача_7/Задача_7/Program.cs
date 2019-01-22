using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Baza
    {
        public string Baza_Text;
        public virtual Alpha Sozdatel()
        {
            Alpha A = new Alpha();
            return A;
        }
    }
    class Alpha : Baza
    {
        public char Alpha_Symbol;
        public override Alpha Sozdatel()
        {
            Alpha A = new Alpha();
            
            return 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baza B = new Baza();
            B.Sozdatel();
        }
    }
}
