using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023CodeWarsChallenge.Kata6
{
    public class RoboterFactory
    {
        //https://www.codewars.com/kata/5898a7208b431434e500013b/train/csharp
        public long CalculateScrap(int[] scraps, int numberOfRobots)
        {
            decimal totalIronNeeded = numberOfRobots * 50m;

            for (int i = scraps.Length - 1; i >= 0; i--)
            {
                decimal efficiency = (100m - scraps[i]) / 100m;
                totalIronNeeded = totalIronNeeded / efficiency;
            }

            return (long)Math.Ceiling(totalIronNeeded);
        }
    }
}
