﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Pereopredelitel
    {
        public int[] Numbers;
        public Pereopredelitel(int n = 10)
        {
            Numbers = new int[n];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = i;
            }
        }
        public static implicit operator string(Pereopredelitel a)
        {
            string NewText = "";
            for (int i = 0; i < a.Numbers.Length; i++)
            {
                NewText += a.Numbers[i];
            }
            return NewText;
        }
        public static implicit operator int(Pereopredelitel a)
        {
            int NewNumber = a.Numbers.Sum();
            return NewNumber;
        }
        public static implicit operator Pereopredelitel(int n)
        {
            Pereopredelitel B = new Pereopredelitel(n);
            for (int i = 0; i < B.Numbers.Length; i++)
            {
                B.Numbers[i] = 0;
            }
            return B;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pereopredelitel A = new Pereopredelitel();
            string x = A;
            Console.WriteLine("Object to String: " + x);
            int y = A;
            Console.WriteLine("Object to Int: " + y);
            Pereopredelitel z = 7;
            Console.WriteLine("Int to Object: " + z);
            Console.ReadKey();
        }
    }
}
