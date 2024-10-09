using System;
using System.ComponentModel;

namespace Lab4.Podaci
{
    public class Kategorija
    {
        #region Attributes

        private string _oznakaKategorije;
        private DateTime _datumOd;
        private DateTime _datumDo;

        #endregion

        #region Properties

        [DisplayName("KategorijaValue")]
        public string OznakaKategorije
        {
            get { return _oznakaKategorije; }
            set { _oznakaKategorije = value; }
        }

        [DisplayName("DatumOdValue")]
        public DateTime DatumOd
        {
            get { return _datumOd; }
            set { _datumOd = value; }
        }

        [DisplayName("DatumDoValue")]
        public DateTime DatumDo
        {
            get { return _datumDo; }
            set { _datumDo = value; }
        }

        #endregion

        #region Constructors

        public Kategorija()
        {
            _oznakaKategorije = string.Empty;
            _datumOd = DateTime.Now;
            _datumDo = DateTime.Now;
        }

        public Kategorija(string oznakaKategorije, DateTime datumOd, DateTime datumDo)
        {
            _oznakaKategorije = oznakaKategorije;
            _datumOd = datumOd;
            _datumDo = datumDo;
        }

        #endregion
    }
}