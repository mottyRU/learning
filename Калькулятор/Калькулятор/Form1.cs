using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        int count;
        public Form1()
        {
            InitializeComponent(); 
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Text = "0";
        }
        public void Stiratel()
        {
            textBox1.Text = "0";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            Stiratel();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "1";
            }
            else if (textBox1.Text != "0") textBox1.Text += "1";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "2";
            }
            else if (textBox1.Text != "0") textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "3";
            }
            else if (textBox1.Text != "0") textBox1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "4";
            }
            else if (textBox1.Text != "0") textBox1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "5";
            }
            else if (textBox1.Text != "0") textBox1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "6";
            }
            else if (textBox1.Text != "0") textBox1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "7";
            }
            else if (textBox1.Text != "0") textBox1.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "8";
            }
            else if (textBox1.Text != "0") textBox1.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //textBox1.Text += "9";
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "9";
            }
            else if (textBox1.Text != "0") textBox1.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            /*bool Proverka;
            string A = ",";
            for (int i = 0; i <= 9; i++)
            {
                A += i;
            }
            Proverka = textBox1.Text.EndsWith(A);
            if (Proverka == true) textBox1.Text += "";
            else if (Proverka != true) textBox1.Text += "0";*/
            if (textBox1.Text == "0") textBox1.Text += "";
            else if (textBox1.Text != "0") textBox1.Text += "0";

        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Stiratel();
            else if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            Stiratel();
            count = 1;
        } 

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Stiratel();
            else if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            Stiratel();
            count = 2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Stiratel();
            else if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            Stiratel();
            count = 3;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") Stiratel();
            else if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            Stiratel();
            count = 4;
        }
        private void calculate()
        {
            if (textBox1.Text == "") Stiratel();
            switch (count)
            {

                case 1:
                    b = a + double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break; 
                case 4:
                    b = a / double.Parse(textBox1.Text);
                    if (double.Parse(textBox1.Text) == 0) textBox1.Text = "Деление на 0 невозможно";
                    else if (double.Parse(textBox1.Text) != 0) textBox1.Text = b.ToString();
                    break;

            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Clear(); 
            calculate();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                int NumberLength = textBox1.Text.Length;
                string a = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                textBox1.Text = a;
                if (a == "") Stiratel(); 
            } 
            catch
            {
                textBox1.Text = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string  A = textBox1.Text;
            if (A == "") textBox1.Clear(); 
            else if (A != "")
            {
                string Z = ",";
                bool Proverka;
                Proverka = textBox1.Text.Contains(Z);
                if (Proverka == true) textBox1.Text += "";
                else if (Proverka != true) textBox1.Text += ",";
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToDouble(textBox1.Text);
                A *= -1;
                textBox1.Text = A.ToString();
            }
            catch
            {
                textBox1.Text = "";
            }
        }
    }
}
