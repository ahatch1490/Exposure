using System;

namespace ExposureAPI.Models
{
    public static class StringExtenions 
    {
        public static string Titlize(this String str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return str;
            }

            var letter = str[0];
            letter = letter.ToString().ToUpperInvariant()[0];
            str = str.Insert(0, letter.ToString());
            str = str.Remove(1, 1);
            return str;
        }
        
    }
}