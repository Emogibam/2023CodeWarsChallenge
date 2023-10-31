using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023CodeWarsChallenge.Kata6
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            if (n >= 0 && n < 10)
            {
                return (int)n;
            }
            else
            {
                string num = n.ToString();
                long totalnum = 0;
                for (int x = 0; x < num.Length; x++)
                {
                    totalnum += int.Parse(num[x].ToString());
                }
                if (totalnum > 9)
                {
                    return DigitalRoot(totalnum);
                }

                return (int)totalnum;
            }
        }
    }
}
