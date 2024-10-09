using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ekstenzije
{
    public static class StringEkstenzija
    {
        public static String PrvoVeliko(this String s)
        {
            if (s.Length == 0)
                return s;
            String str = s.ToLower();
            return str[0].ToString().ToUpper() + str.Substring(1);
        }
    }
}
