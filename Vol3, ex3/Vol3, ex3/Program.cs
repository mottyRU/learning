using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vol3__ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int A, number;
                number = 0;
                
                for (A=Int32.Parse(Interaction.InputBox("Enter number:")); A != 0; A = Int32.Parse(Interaction.InputBox("Enter number:")))
                {
                    number += A;
                    MessageBox.Show("Result is: "+number+"");
                }
                MessageBox.Show("Wrong number");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
