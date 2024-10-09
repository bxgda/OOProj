using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class StringExtensions
    {
        public static String PostaviPrvoVelikoSlovo(this String s)
        {
            if (String.IsNullOrEmpty(s))
                return s;

            String str = s.ToLower();
            str = str[0].ToString().ToUpper() + str.Substring(1);

            return str;
        }
    }
}
