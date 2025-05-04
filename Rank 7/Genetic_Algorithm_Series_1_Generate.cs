using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_GitHub.Rank_7
{
    internal class Genetic_Algorithm_Series_1_Generate
    {
        public static string Generate(int lenght)
        {
            Random rand = new Random();
            char[] arr = ['0', '1'];
            char[] result = new char[lenght];
            for(int i = 0; i < lenght; i++)
            {
                result[i] = arr[rand.Next(arr.Length)];
            }
            return new string(result);
        }
    }
}
