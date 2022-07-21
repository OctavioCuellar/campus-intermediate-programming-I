using System;
using System.Text.RegularExpressions;

namespace campus_intermediate_programming_I
{
    static class ExtensiveMethod
    {
        public static T GetFirst<T>(this Map<T> map) where T : Pair
        {
            return map.GetAt(0);
        }

        public static bool RegexMatch(this string str)
        {
            return Regex.IsMatch(str, @"^[A-Z][a-z]{3}\d{4}");
        }

    }
}
