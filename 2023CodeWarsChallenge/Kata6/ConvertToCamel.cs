using System.Text;

namespace _2023CodeWarsChallenge.Kata6
{
    public class ConvertToCamel
    {
        public static string ToCamelCase(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool IsDash = false;
            for (int x = 0; x < str.Length; x++)
            {
                if (str[x] == '_')
                {
                    stringBuilder.Append(str[x]);
                    IsDash = true;
                }
                else if (IsDash)
                {
                    stringBuilder.Append(str.ToUpper());
                    IsDash = false;
                }
                else
                {
                    stringBuilder.Append(str);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
