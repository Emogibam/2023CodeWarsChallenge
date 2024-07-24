using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023CodeWarsChallenge.Kata7
{
    public class CheckThreeAndTwoKata
    {

         public static bool CheckThreeAndTwo(string[] array)
        {
            return array.Length == 5 &&
                   array.GroupBy(x => x)
                        .Select(g => g.Count())
                        .OrderByDescending(c => c)
                        .SequenceEqual(new[] { 3, 2 });
        }
        // public static bool CheckThreeAndTwo(string[] array)
        // {
        //     if(array.Length > 5 || array.Length < 5)
        //         return false;

        //     Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

        //     foreach(string key in array)
        //     {
        //        if(!keyValuePairs.ContainsKey(key))
        //         {
        //             keyValuePairs.Add(key, 1);
        //         }
        //         else
        //         {
        //             keyValuePairs[key]++;
        //         }
        //     }

        //    int[] intArray = keyValuePairs.Values.ToArray();

        //     var counts = keyValuePairs.Values.OrderByDescending(x => x).ToArray();

        //     return counts.Length == 2 && counts[0] == 3 && counts[1] == 2;
        // }
    }
}
