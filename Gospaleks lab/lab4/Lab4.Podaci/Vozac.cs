using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Podaci
{
    public class Vozac
    {
        #region Attributes

        private string _ime;
        private string _prezime;
        private DateTime _datumRodjenja;
        private DateTime _vazenjeDozvoleOd;
        private DateTime _vazenjeDozvoleDo;
        private string _brojDozvole; // 9 cifara
        private string _mestoIzdavanjaDozvole;
        private string _pol;

        private string _putanjaDoSlike;
        private List<Kategorija> _listaKategorija;
        private List<Zabrana> _listaZabrana;

        #endregion

        #region Properties

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        [DisplayName("Br. vozačke dozvole")]
        public string BrojDozvole
        {
            get { return _brojDozvole; }
            set { _brojDozvole = value; }
        }

        [Browsable(false)]
        public string DatumRodjenja
        {
            get { return _datumRodjenja.ToString("dd.MM.yyyy."); }
            set { _datumRodjenja = DateTime.Parse(value); }
        }

        [Browsable(false)]
        public string VazenjeDozvoleOd
        {
            get { return _vazenjeDozvoleOd.ToString("dd.MM.yyyy."); }
            set { _vazenjeDozvoleOd = DateTime.Parse(value); }
        }

        [Browsable(false)]
        public string VazenjeDozvoleDo
        {
            get { return _vazenjeDozvoleDo.ToString("dd.MM.yyyy."); }
            set { _vazenjeDozvoleDo = DateTime.Parse(value); }
        }

        [DisplayName("Mesto izdavanja dozvole")]
        public string MestoIzdavanjaDozvole
        {
            get { return _mestoIzdavanjaDozvole; }
            set { _mestoIzdavanjaDozvole = value; }
        }

        [Browsable(false)]
        public string PutanjaDoSlike
        {
            get { return _putanjaDoSlike; }
            set { _putanjaDoSlike = value; }
        }

        [Browsable(false)]
        public string Pol
        {
            get { return _pol; }
            set { _pol = value; }
        }

        public List<Kategorija> ListaKategorija
        {
            get { return _listaKategorija; }
            set { _listaKategorija = value; }
        }

        public List<Zabrana> ListaZabrana
        {
            get { return _listaZabrana; }
            set { _listaZabrana = value; }
        }

        #endregion

        #region Constructors

        public Vozac()
        {
            _ime = string.Empty;
            _prezime = string.Empty;
            _datumRodjenja = DateTime.Now;
            _vazenjeDozvoleOd = DateTime.Now;
            _vazenjeDozvoleDo = DateTime.Now;
            _brojDozvole = string.Empty;
            _mestoIzdavanjaDozvole = string.Empty;
            _pol = string.Empty;
            _putanjaDoSlike = string.Empty;
            _listaKategorija = new List<Kategorija>();
            _listaZabrana = new List<Zabrana>();
        }

        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime vazenjeDozvoleOd, DateTime vazenjeDozvoleDo, string brojDozvole, string mestoIzdavanjaDozvole, string pol, string putanjaDoSlike)
        {
            _ime = ime;
            _prezime = prezime;
            _datumRodjenja = datumRodjenja;
            _vazenjeDozvoleOd = vazenjeDozvoleOd;
            _vazenjeDozvoleDo = vazenjeDozvoleDo;
            _brojDozvole = brojDozvole;
            _mestoIzdavanjaDozvole = mestoIzdavanjaDozvole;
            _pol = pol;
            _putanjaDoSlike = putanjaDoSlike;
            _listaKategorija = new List<Kategorija>();
            _listaZabrana = new List<Zabrana>();
        }

        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime vazenjeDozvoleOd, DateTime vazenjeDozvoleDo,
                    string brojDozvole, string mestoIzdavanjaDozvole, string pol, string putanjaDoSlike,
                    List<Kategorija> listaKategorija, List<Zabrana> listaZabrana)
            : this(ime, prezime, datumRodjenja, vazenjeDozvoleOd, vazenjeDozvoleDo, brojDozvole, mestoIzdavanjaDozvole, pol, putanjaDoSlike)
        {
            _listaKategorija = listaKategorija;
            _listaZabrana = listaZabrana;
        }

        #endregion

        #region Methods

        public override bool Equals(object obj)     // override metode Equals da bi koristio Contains metodu
        {
            Vozac other = obj as Vozac;

            if (other == null)
                return false;

            return _brojDozvole == other._brojDozvole;
        }

        #endregion

    }
}
