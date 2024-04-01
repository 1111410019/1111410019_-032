using System;
using System.Collections.Generic;
using static System.Console;
namespace _1111410019_張子桓_032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;				//設定要輸入的數字與紀錄羅馬數字的字串
            string roman = "";
            num = int.Parse(ReadLine());

            string[] romanNum = { "M", "CM", "D", "CD", "C", "XC", 			//設定全部的羅馬數字符號與對應的數字陣列
				  "L", "XL", "X", "IX", "V", "IV", "I" };

            int[] math = { 1000, 900, 500, 400, 100, 90, 
			   50, 40, 10, 9, 5, 4, 1 };

            for (int i = 0; i < 13; i++)	//從最大值開始計算13次
            {
                while (num >= math[i])		//只要輸入的數字比當前的數字陣列大
                {
                    roman += romanNum[i];	//就寫入當前的羅馬數字符號
                    num -= math[i];		//然後減去對應的數字直到歸零
                }
            }
            WriteLine(roman);			//輸出轉換後的羅馬數字符號
        }
    }
}
