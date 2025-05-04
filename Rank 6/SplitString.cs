using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars_GitHub.Rank_6
{
    internal class SplitString
    {
        public static string[] Solution(string str)
        {
            string[] arr = new string[str.Length % 2 == 0 ? str.Length / 2 : str.Length / 2 + 1];
            for(int i = 0; i < str.Length; i+=2)
            {
                if(i <= str.Length - 2)
                {
                    AppendToArr<string>($"{str[i]}{str[i + 1]}", arr);
                }
                else
                {
                    AppendToArr<string>($"{str[i]}_", arr);
                }
            }
            return arr;
        }
        public static void AppendToArr<T>(T element, T[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = element;
                    break;
                }
            }
        }
    }
}
