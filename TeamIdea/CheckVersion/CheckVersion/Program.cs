using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckVersion
{
    class Program
    {
        public void CheckVersion(string n, string m)
        {
            string Val1 = "";
            string Val2 = "";
            Regex A = new Regex(@"\d*.\d*.\d*.\d*");
            Match match1 = Regex.Match(n, @":(.*?)!");
            Match match2 = Regex.Match(m, @":(.*?)!");
            if (match1.Success)
            {
                Val1 = match1.Groups[1].Value;
                Console.WriteLine(match1.Groups[1].Value);
            }
            if (match2.Success)
            {
                Val2 = match2.Groups[1].Value;
                Console.WriteLine(match2.Groups[1].Value);
            }
            string[] MassiveVal1 = Val1.Split('.');
            string[] MassiveVal2 = Val2.Split('.');
            for (int i = 0; i < MassiveVal1.Length; i++)
            {
                if (Convert.ToInt32(MassiveVal1[i]) > Convert.ToInt32(MassiveVal2[i]))
                {
                    Console.WriteLine(Val1 + " is New version");
                    break;
                }
                else if (Convert.ToInt32(MassiveVal1[i]) == Convert.ToInt32(MassiveVal2[i])) continue;
                else if (Convert.ToInt32(MassiveVal1[i]) < Convert.ToInt32(MassiveVal2[i]))
                {
                    Console.WriteLine(Val2 + " is New version");
                    break;
                }
            }

        }
        static void Main(string[] args)
        {
            string VersionOne = "This is old version of program: 8.1.009.125!";
            string VersionTwo = "This is old version of program: 8.1.13.41!";
            Program obj = new Program();
            obj.CheckVersion(VersionOne, VersionTwo);
            Console.ReadKey();
        }
    }
}
