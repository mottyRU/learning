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
        int count;
        double a, b, MemoryDoub;
        bool Equally = false;
        bool Plus, Minus, Multiply, Division, ButtonIndicate, Percent, TextBOX;
        bool WaitInfo = true;
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
            WaitInfo = true;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            //кнопка C
            //textBox1.Clear();
            TextValueZero();
            a = 0;
            b = 0;
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
        public string NumberButton()
        {
            string Txt = "";
            switch (count)
            {
                case 0:
                    Txt += "0";
                    break;
                case 1:
                    Txt += "1";
                    break;
                case 2:
                    Txt += "2";
                    break;
                case 3:
                    Txt += "3";
                    break;
                case 4:
                    Txt += "4";
                    break;
                case 5:
                    Txt += "5";
                    break;
                case 6:
                    Txt += "6";
                    break;
                case 7:
                    Txt += "7";
                    break;
                case 8:
                    Txt += "8";
                    break;
                case 9:
                    Txt += "9";
                    break;
            }
            return Txt;
        }
        public void ButtonClick()
        {
            if (ButtonIndicate == true | Equally == true)
            {
                ButtonIndicate = false;
                Equally = false;
                textBox1.Clear();
                textBox1.Text += NumberButton();
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = NumberButton();
            }
            else
            {
                textBox1.Text += NumberButton();
            }
            WaitInfo = false;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //кнопка 0
            count = 0;
            ButtonClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка 1
            count = 1;
            ButtonClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //кнопка 2
            count = 2;
            ButtonClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //кнопка 3
            count = 3;
            ButtonClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //кнопка 4
            count = 4;
            ButtonClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //кнопка 5
            count = 5;
            ButtonClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //кнопка 6
            count = 6;
            ButtonClick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //кнопка 7
            count = 7;
            ButtonClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //кнопка 8
            count = 8;
            ButtonClick();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            //кнопка 9
            count = 9;
            ButtonClick();
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
                Calculator();
            }            
            else if (a != 0 & b != 0)
            {
                Calculator();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //кнопка ПЛЮС:
            if (WaitInfo == true) return;
            Plus = true;
            ButtonIndicate = true;
            Plus_Minus_Multiply_Division();
            //Plus = false;
            Minus = false;
            Multiply = false;
            Division = false;
            WaitInfo = true;
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            //кнопка МИНУС:
            if (WaitInfo == true & Plus == true | Multiply == true | Division == true)
            {
                WaitInfo = false;
                a = 0;
            }                
            else if (WaitInfo == true) return;
            Minus = true;
            ButtonIndicate = true;
            Plus = false;
            //Minus = false;
            Multiply = false;
            Division = false;            
            Plus_Minus_Multiply_Division();
            WaitInfo = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //кнопка УМНОЖИТЬ:
            if (WaitInfo == true) return;
            Multiply = true;
            ButtonIndicate = true;
            Plus_Minus_Multiply_Division();
            Plus = false;
            Minus = false;
            //Multiply = false;
            Division = false;
            WaitInfo = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //кнопка РАЗДЕЛИТЬ:
            if (WaitInfo == true) return;
            Division = true;
            ButtonIndicate = true;
            Plus_Minus_Multiply_Division();
            Plus = false;
            Minus = false;
            Multiply = false;
            //Division = false;
            WaitInfo = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //кнопка равно:
            //Equally = true;
            Calculator();
            Equally = true;
        }

        public void Calculator()
        {

            b = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            if (Plus == true) a += b;
            else if (Minus == true) a -= b;
            else if (Multiply == true) a *= b;
            else if (Division == true) a /= b;
            else if (Percent == true)
            {
                a = a * 100 / b;
                Percent = false;
            }
            textBox1.Text = a.ToString();
            //Hranitel = a;
            a = Convert.ToDouble(textBox1.Text);
            b = 0;
            textBox1.Text = a.ToString();
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
