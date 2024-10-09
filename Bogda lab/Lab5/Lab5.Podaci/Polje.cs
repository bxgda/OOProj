using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Podaci
{
    [Serializable]
    public class Polje : Button
    {
        #region Atributi

        private int _red;
        private int _kolona;
        private bool _otkriveno;
        private int _slika; // 0 je prazno, ostalo je redni broj slike

        #endregion

        #region Properties

        public int Red
        {
            get { return _red; }
            set { _red = value; }
        }

        public int Kolona
        {
            get { return _kolona; }
            set { _kolona = value; }
        }

        public bool Otkriveno
        {
            get { return _otkriveno; }
            set { _otkriveno = value; }
        }

        public int Slika
        {
            get { return _slika; }
            set { _slika = value; }
        }

        #endregion

        #region Konstruktori

        public Polje()
        {
            _red = 0;
            _kolona = 0;
            _slika = 0;
            _otkriveno = false;
        }

        public Polje(int red, int kolona, int slika = 0)
        {
            _red = red;
            _kolona = kolona;
            _slika = slika;
            _otkriveno = false;
            this.BackgroundImage = null;
        }

        #endregion
    }
}
