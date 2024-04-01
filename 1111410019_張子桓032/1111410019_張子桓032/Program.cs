using System;
using System.Collections.Generic;
using static System.Console;
namespace _1111410019_張子桓_032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string roman = "";
            num = int.Parse(ReadLine());

            string[] romanNum = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] math = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            for (int i = 0; i < 13; i++)
            {
                while (num >= math[i])
                {
                    roman += romanNum[i];
                    num -= math[i];
                }
            }
            WriteLine(roman);
        }
    }
}
