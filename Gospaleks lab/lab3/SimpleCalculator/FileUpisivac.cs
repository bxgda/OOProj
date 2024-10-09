using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class FileUpisivac
    {
        private StreamWriter sw;    // stream za upis u fajl
        private string imeFajla;

        public FileUpisivac(string imeFajla)
        {
            this.imeFajla = imeFajla;
        }

        public void OtvoriStream()
        {
            sw = new StreamWriter(new FileStream(imeFajla, FileMode.Create));
        }

        public void ZatvoriStream()
        {
            sw.Close();
        }

        public void Upisi(string tekst)
        {
            sw.Flush();
            sw.BaseStream.SetLength(0);
            sw.Write(tekst);
            sw.Flush();
        }
    }
}
