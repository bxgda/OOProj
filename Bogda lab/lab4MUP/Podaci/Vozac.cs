using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Vozac
    {
        #region Atributi

        private string ime;
        private string prezime;
        private DateTime datumRodj;
        private DateTime vaziOd;
        private DateTime vaziDo;
        private string brojDozvole;
        private string mestoIzdavanja;
        private bool pol;   // 0 - muski, 1 - zenski

        private string slika;
        private List<Kategorija> kategorije;
        private List<Kategorija> zabrane;

        #endregion

        #region Properties

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        [Browsable(false)]
        public DateTime DatumRodj
        {
            get { return datumRodj; }
            set { datumRodj = value; }
        }

        [Browsable(false)]
        public DateTime VaziOd
        {
            get { return vaziOd; }
            set { vaziOd = value; }
        }

        [Browsable(false)]
        public DateTime VaziDo
        {
            get { return vaziDo; }
            set { vaziDo = value; }
        }

        [DisplayName("Broj dozvole")]
        public string BrojDozvole
        {
            get { return brojDozvole; }
            set { brojDozvole = value; }
        }

        [DisplayName("Mesto izdavanja")]
        public string MestoIzdavanja
        {
            get { return mestoIzdavanja; }
            set { mestoIzdavanja = value; }
        }

        [Browsable(false)]
        public bool Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        [Browsable(false)]
        public string Slika
        {
            get { return slika; }
            set { slika = value; }
        }

        public List<Kategorija> Kategorije
        {
            get { return kategorije; }
            set { kategorije = value; }
        }

        public List<Kategorija> Zabrane
        {
            get { return zabrane; }
            set { zabrane = value; }
        }

        #endregion

        #region Konstruktori

        public Vozac()
        {
            Ime = string.Empty;
            Prezime = string.Empty;
            DatumRodj = DateTime.Now;
            VaziOd = DateTime.Now;
            VaziDo = DateTime.Now;
            BrojDozvole = string.Empty;
            MestoIzdavanja = string.Empty;
            Pol = false;
            Slika = string.Empty;
            kategorije = new List<Kategorija>();
            zabrane = new List<Kategorija>();
        }

        public Vozac(string ime, string prezime, DateTime datumRodj, DateTime vaziOd, DateTime vaziDo, string brojDozvole, string mestoIzdavanja, bool pol, string slika)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodj = datumRodj;
            VaziOd = vaziOd;
            VaziDo = vaziDo;
            BrojDozvole = brojDozvole;
            MestoIzdavanja = mestoIzdavanja;
            Pol = pol;
            Slika = slika;
            kategorije = new List<Kategorija>();
            zabrane = new List<Kategorija>();
        }

        public Vozac(string ime, string prezime, DateTime datumRodj, DateTime vaziOd, DateTime vaziDo, string brojDozvole, string mestoIzdavanja, bool pol, string slika, List<Kategorija> kategorije, List<Kategorija> zabrane)
            : this(ime, prezime, datumRodj, vaziOd, vaziDo, brojDozvole, mestoIzdavanja, pol, slika)
        {
            Kategorije = kategorije;
            Zabrane = zabrane;
        }


        #endregion

        #region Metode

        public override bool Equals(object obj)
        {
            return obj is Vozac vozac &&
                   BrojDozvole == vozac.BrojDozvole;
        }

        #endregion
    }
}
