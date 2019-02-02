﻿using System;
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
        int count;
        double a, b, CalcData;
        bool Equally = false; //для кнопки РАВНО
        bool Plus, Minus, Multiply, Division, ButtonIndicate; //для кнопок матем.операций
        public Form1()
        {
            InitializeComponent();
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Text = "0";
        }
        public void Stiratel()
        {
            textBox1.Text = "0";
            //Equally = false;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //кнопка С
            //textBox1.Clear();
            Stiratel();
            a = 0;
            b = 0;
            CalcData = 0;
            Plus = false;
            Minus = false;
            Multiply = false;
            Division = false;
            ButtonIndicate = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка 1
            if (textBox1.Text == "0")
            {
                if (ButtonIndicate == true)
                {
                    ButtonIndicate = false;
                    textBox1.Clear();
                    textBox1.Text += "1";
                }
                else
                {
                    textBox1.Clear();
                    textBox1.Text += "1";
                }
            }
            else textBox1.Text += "1";

            /*if (textBox1.Text == "0") textBox1.Clear();
            else if (Equally | Plus | Minus | Multiply | Division == true)
            {
                Stiratel();
                textBox1.Clear();
            }
            textBox1.Text += "1";*/
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //кнопка 2
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //кнопка 3
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //кнопка 4
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //кнопка 5
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //кнопка 6
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //кнопка 7
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //кнопка 8
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //кнопка 9
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            //кнопка 0
            if (ButtonIndicate == true)
            {
                ButtonIndicate = false;
                textBox1.Clear();
                textBox1.Text += "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            //кнопа ПЛЮС
            ButtonIndicate = true;
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
                a += Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox1.Text);
                CalcData = a;
                textBox1.Text = CalcData.ToString();
            }
            else if (a != 0 & b != 0)
            {
                textBox1.Text = calculate();
            }
            Plus = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //кнопа МИНУС
            a = Convert.ToDouble(textBox1.Text);
            //count = 2;
            Minus = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //кнопа УМНОЖИТЬ
            a = Convert.ToDouble(textBox1.Text);
            //count = 3;
            Multiply = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //кнопа РАЗДЕЛИТЬ
            a = Convert.ToDouble(textBox1.Text);
            //count = 4;
            Division = true;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            //вычислить проценты
            a = Convert.ToDouble(textBox1.Text);
            count = 5;
            Stiratel();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //кнопа равно
            Equally = true;            
            textBox1.Text = a.ToString();            
            
        }
        private string calculate()
        {
            if (Plus == true)
            {
                b = Convert.ToDouble(textBox1.Text);
                a += b;
                textBox1.Text = a.ToString();
                CalcData = a;
            }
            Equally = true;
            return a.ToString();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //кнопка "<--"
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

        private void button20_Click(object sender, EventArgs e)
        {
            //кнопка CE
            Stiratel();
            b = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //корень квадратный
            a = Convert.ToDouble(textBox1.Text);
            a = Math.Sqrt(a);
            textBox1.Text = a.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //возведение в квадрат
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Pow(a, 2);
            Equally = true;
            textBox1.Text = b.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //вычисление 1/X
            if (a != 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                a = 1 / a;
                textBox1.Text = a.ToString();
            }
            else textBox1.Text = "Деление на 0 невозможно";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //кнопка ","
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



        private void button15_Click(object sender, EventArgs e)
        {
            //кнопка +/-
            if (textBox1.Text[0] == '-') textBox1.Text = textBox1.Text.Remove(0, 1);
            else textBox1.Text = '-' + textBox1.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //кнопка MemorySave
            //сохранить число, отображенное в данный момент на дисплее 
            //калькулятора в память.
            CalcData = Convert.ToDouble(textBox1.Text);
            Equally = true;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            //кнопка MemoryClear
            //кнопка означает стереть данные из ячейки памяти.
            CalcData = 0;
        }
        private void button26_Click(object sender, EventArgs e)
        {
            //кнопка MemoryRead
            //считать число из ячейки памяти и вывести его на дисплей.
            if (CalcData != 0) textBox1.Text = Convert.ToString(CalcData);
            else textBox1.Text = "0";
        }
        private void button27_Click(object sender, EventArgs e)
        {
            //кнопка M+
            //прибавить к числу из памяти число, отображенное
            //на дисплее и результат записать в память вместо предыдущего.
            CalcData += Convert.ToDouble(textBox1.Text);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            //кнопка M-
            //вычесть из числа в памяти число, отображенное на дисплее
            //калькулятора и результат записать в память.
            CalcData -= Convert.ToDouble(textBox1.Text);
        }
    }
}
