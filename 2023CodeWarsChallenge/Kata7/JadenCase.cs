using System.Globalization;
using System.Text.RegularExpressions;

namespace _2023CodeWarsChallenge.Kata7
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                return phrase;
            }

            // Apply TitleCase to the entire sentence
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }

        //public static string ToJadenCase(this string phrase)
        //{
        //    return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
        //}

        //public static string ToJadenCase(this string phrase)
        //{
        //    TextInfo text = new CultureInfo("en-US", false).TextInfo;
        //    return text.ToTitleCase(phrase);
        //}


        //public static string ToJadenCase(this string phrase)
        //{
        //    return Regex.Replace(phrase, @"(^|\s)[a-z]", m => m.Value.ToUpper());
        //}
    }
}
