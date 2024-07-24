using System.Text;
using System.Text.RegularExpressions;

namespace _2023CodeWarsChallenge.Kata6
{
    public class ConvertToCamel
    {
        public static string ToCamelCase(string str)
        {
            return str
              .Split('_', '-')
              .Aggregate((result, word) => {
                  result += char.ToUpper(word[0]) + word.Substring(1);
                  return result;
              });
        }

        //public static string ToCamelCase(string str)
        //{
        //    string[] strarr = str.Split('-', '_');

        //    for (int i = 1; i < strarr.Length; ++i)
        //    {
        //        strarr[i] = char.ToUpper(strarr[i][0]) + strarr[i].Substring(1);
        //    }

        //    return string.Concat(strarr);
        //}

        //public static string ToCamelCase(string str)
        //   => string.Concat(str.Split(new[] { '-', '_' }).
        //        Select((st, i) => i > 0 ? Regex.Replace(st, @"^\w", t => t.Value.ToUpper()) : st));

        //public static string ToCamelCase(string str)
        //{
        //    string result = "";

        //    for (int x = 0; x < str.Length; x++)
        //    {
        //        if (str[x] == '-' || str[x] == '_')
        //        {
        //            result += char.ToUpper(str[x + 1]);
        //            x++;
        //        }
        //        else result += str[x];
        //    }
        //    return result;
        //}
    }
}
