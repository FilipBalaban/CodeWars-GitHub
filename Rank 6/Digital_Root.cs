using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_GitHub.Rank_6
{
    internal class Digital_Root
    {
        public static int DigitalRoot(long n)
        {
            string digitStr = n.ToString();
            int sum = 0;
            for(int i = 0; i < digitStr.Length; i++)
            {
                sum += int.Parse(digitStr[i].ToString());
            }

            return sum;
        }
    }
}
