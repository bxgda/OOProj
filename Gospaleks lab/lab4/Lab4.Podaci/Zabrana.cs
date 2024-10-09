using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Podaci
{
    public class Zabrana
    {
        #region Attributes

        private string _kategorija;
        private DateTime _datumOd;
        private DateTime _datumDo;

        #endregion

        #region Properties

        [DisplayName("KategorijaValue")]
        public string Kategorija
        {
            get { return _kategorija; }
            set { _kategorija = value; }
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

        public Zabrana()
        {
            _kategorija = string.Empty;
            _datumOd = DateTime.Now;
            _datumDo = DateTime.Now;
        }

        public Zabrana(string kategorija, DateTime datumOd, DateTime datumDo)
        {
            _kategorija = kategorija;
            _datumOd = datumOd;
            _datumDo = datumDo;
        }

        #endregion
    }
}
