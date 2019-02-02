using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_простой
{
    public partial class Form1 : Form
    {
        double a, b, Hranitel, MemoryDoub;
        bool Equally = false;
        bool Plus, Minus, Multiply, Division, ButtonIndicate, Percent, TextBOX;
        public Form1()
        {
            InitializeComponent();
            textBox1.TextAlign = HorizontalAlignment.Right;
            TextValueZero();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public void TextValueZero()
        {
            textBox1.Text = "0";
            TextBOX = true;
        }
        public void AllBoolFalse()
        {
            Equally = false;
            Plus = false;
            Minus = false;
            Multiply = false;
            Division = false;
            ButtonIndicate = false;
            Percent = false;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            //кнопка C
            //textBox1.Clear();
            TextValueZero();
            a = 0;
            b = 0;
            Hranitel = 0;
            AllBoolFalse();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //кнопка CE
            textBox1.Text = "0";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            //кнопка стереть один знак
            int Number = textBox1.Text.Length;
            string Txt = "0";
            try
            {
                Txt = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                textBox1.Text = Txt;
                if (textBox1.Text == "") textBox1.Text = "0";
            }
            catch
            {
                Txt = "0";
            }
        }
        //------------------------------кнопки с цифрами:
        private void button10_Click(object sender, EventArgs e)
        {
            //кнопка 0
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "0";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text += "";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка 1
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "1";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //кнопка 2
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "2";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //кнопка 3
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "3";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //кнопка 4
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "4";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //кнопка 5
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "5";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //кнопка 6
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "6";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //кнопка 7
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "7";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //кнопка 8
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "8";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            //кнопка 9
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += "9";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        //-------------------------------------операции с числами:
        public void Plus_Minus_Multiply_Division()
        {
            if (Equally == true)
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = b.ToString();
            }
            else if (a == 0 & Equally == false)
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            else if (a != 0 & Equally == false)
            {
                if (Plus == true) a += Convert.ToDouble(textBox1.Text);
                else if (Minus == true) a -= Convert.ToDouble(textBox1.Text);
                else if (Multiply == true) a *= Convert.ToDouble(textBox1.Text);
                else if (Division == true) a /= Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox1.Text);
                //Hranitel = a;
                textBox1.Text = a.ToString();
                a = Convert.ToDouble(textBox1.Text);
            }            
            else if (a != 0 & b != 0)
            {
                textBox1.Text = Calculator();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //кнопка ПЛЮС:
            Plus = true;
            ButtonIndicate = true;
            Plus_Minus_Multiply_Division();
            //Plus = false;
            Minus = false;
            Multiply = false;
            Division = false;
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            //кнопка МИНУС:
            Minus = true;
            ButtonIndicate = true;
            Plus_Minus_Multiply_Division();
            Plus = false;
            //Minus = false;
            Multiply = false;
            Division = false;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //кнопка УМНОЖИТЬ:
            Multiply = true;
            ButtonIndicate = true;
            Plus_Minus_Multiply_Division();
            Plus = false;
            Minus = false;
            //Multiply = false;
            Division = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //кнопка РАЗДЕЛИТЬ:
            Division = true;
            ButtonIndicate = true;
            Plus_Minus_Multiply_Division();
            Plus = false;
            Minus = false;
            Multiply = false;
            //Division = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //кнопка равно:
            //Equally = true;
            textBox1.Text = Calculator();
        }

        public string Calculator()
        {
            if (Plus == true)
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                a += b;
                textBox1.Text = a.ToString();
                //Hranitel = a;
                a = Convert.ToDouble(textBox1.Text);
            }
            if (Minus == true)
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                a -= b;
                textBox1.Text = a.ToString();
                //Hranitel = a;
                a = Convert.ToDouble(textBox1.Text);
            }
            if (Multiply == true)
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                a *= b;
                textBox1.Text = a.ToString();
                //Hranitel = a;
                a = Convert.ToDouble(textBox1.Text);
            }
            if (Division == true)
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                a /= b;
                textBox1.Text = a.ToString();
                //Hranitel = a;
                a = Convert.ToDouble(textBox1.Text);
            }
            if (Percent == true)
            {
                b = Convert.ToDouble(textBox1.Text);
                a = a * 100 / b;
                textBox1.Text = a.ToString();
                Percent = false;
            }
            b = 0;
            Hranitel = 0;
            Equally = true;
            return a.ToString();
        }

        //-----------------------------------второстепенные операции:
        private void button19_Click(object sender, EventArgs e)
        {
            //операция смены знака (+/-)
            string Z = textBox1.Text;
            if (textBox1.Text.Contains("-") == false)
            {
                Z = textBox1.Text.Insert(0, "-");
                textBox1.Text = Z;
            }
            else
            {
                Z = textBox1.Text.Remove(0, 1);
                textBox1.Text = Z;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //кнопка разделитель (",")
            string Z = textBox1.Text;
            if (textBox1.Text.Contains(",") == false)
            {
                Z += ",";
                textBox1.Text = Z;
            }
            else
            {
                Z += "";
                textBox1.Text = Z;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //вычисление процентов:
            a = Convert.ToDouble(textBox1.Text);
            Percent = true;
            textBox1.Text = "0";
            AllBoolFalse();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //вычисление квадратного корня:
            a = Convert.ToDouble(textBox1.Text);
            a = Math.Sqrt(a);
            b = a;
            textBox1.Text = a.ToString();
            a = 0;
            AllBoolFalse();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //кнопка возведение в степень
            a = Convert.ToDouble(textBox1.Text);
            a = Math.Pow(a, 2);
            b = a;
            textBox1.Text = a.ToString();
            a = 0;
            AllBoolFalse();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            //вычисление 1/X
            a = Convert.ToDouble(textBox1.Text);
            a = 1 / a;
            textBox1.Text = a.ToString();
            a = 0;
            AllBoolFalse();
        }
        //------------------------------кнопки памяти данных:

        private void button30_Click(object sender, EventArgs e)
        {
            //кнопка M
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //кнопка MemorySave
            //сохранить число, отображенное в данный момент на дисплее 
            //калькулятора в память.
            MemoryDoub = Convert.ToDouble(textBox1.Text);
            Equally = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //кнопка M-
            //вычесть из числа в памяти число, отображенное на дисплее
            //калькулятора и результат записать в память.
            MemoryDoub -= Convert.ToDouble(textBox1.Text);
            Equally = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //кнопка M+
            //прибавить к числу из памяти число, отображенное
            //на дисплее и результат записать в память вместо предыдущего.
            MemoryDoub += Convert.ToDouble(textBox1.Text);
            Equally = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //кнопка MemoryRead
            //считать число из ячейки памяти и вывести его на дисплей.
            textBox1.Text = Convert.ToString(MemoryDoub);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //кнопка MemoryClear
            //кнопка означает стереть данные из ячейки памяти.
            MemoryDoub = 0;

        }

    }
}
