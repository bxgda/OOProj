using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class DateTimeExtensions
    {
        public static string VratiTrenutnoVreme(this DateTime datum)
        {
            return datum.ToString("dd.MM.yyyy. HH:mm:ss");
        }
    }
}
