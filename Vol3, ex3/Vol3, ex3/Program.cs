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
                A = 1;
                number = 0;
                while (A != 0)
                {
                    A = Int32.Parse(Interaction.InputBox("Enter number:"));
                    number += A;
                    MessageBox.Show("Result is:" + number + "");
                }
                MessageBox.Show("Wrong number!");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
