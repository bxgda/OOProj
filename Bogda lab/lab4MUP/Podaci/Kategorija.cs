using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Kategorija
    {
        #region Atributi

        private string oznaka;
        private DateTime vaziOd;
        private DateTime vaziDo;

        #endregion

        #region Properties

        public string Oznaka { get => oznaka; set => oznaka = value; }
        public DateTime VaziOd { get => vaziOd; set => vaziOd = value; }
        public DateTime VaziDo { get => vaziDo; set => vaziDo = value; }

        #endregion

        #region Konstruktori

        public Kategorija(string oznaka, DateTime vaziOd, DateTime vaziDo)
        {
            Oznaka = oznaka;
            VaziOd = vaziOd;
            VaziDo = vaziDo;
        }

        public Kategorija()
        {
            Oznaka = string.Empty;
            VaziOd = DateTime.Now;
            VaziDo = DateTime.Now;
        }

        #endregion
    }
}
