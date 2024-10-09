using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Podaci
{
    public class ListaVozaca
    {
        #region Attributes

        private static ListaVozaca _instance = null;
        private List<Vozac> _listaVozaca;
        public delegate void SortDelegate(List<Vozac> v);

        #endregion

        #region Properties

        public static ListaVozaca Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListaVozaca();

                return _instance;
            }
        }

        public List<Vozac> ListaVozacaValues
        {
            get { return _listaVozaca; }
        }

        public SortDelegate SortListDelegate { get; set; }

        #endregion

        #region Constructors

        private ListaVozaca()
        {
            _listaVozaca = new List<Vozac>();
        }

        #endregion

        #region Methods

        public bool DodajVozaca(Vozac vozac)
        {
            if (_listaVozaca.Contains(vozac))
                return false;

            _listaVozaca.Add(vozac);
            return true;
        }

        public Vozac GetVozac(string brojDozvole)
        {
            foreach (var v in _listaVozaca)
            {
                if (v.BrojDozvole == brojDozvole)
                    return v;
            }

            return null;
        }

        public bool IzmeniVozaca(Vozac v)
        {
            Vozac tmp = GetVozac(v.BrojDozvole);

            if (tmp == null)
                return false;

            tmp.Ime = v.Ime;
            tmp.Prezime = v.Prezime;
            tmp.DatumRodjenja = v.DatumRodjenja;
            tmp.VazenjeDozvoleOd = v.VazenjeDozvoleOd;
            tmp.VazenjeDozvoleDo = v.VazenjeDozvoleDo;
            tmp.BrojDozvole = v.BrojDozvole;
            tmp.MestoIzdavanjaDozvole = v.MestoIzdavanjaDozvole;
            tmp.Pol = v.Pol;
            tmp.PutanjaDoSlike = v.PutanjaDoSlike;
            tmp.ListaKategorija = v.ListaKategorija;
            tmp.ListaZabrana = v.ListaZabrana;

            return true;
        }

        public bool ObrisiVozaca(Vozac v)
        {
            // Ako prosledjena osoba nije u listi, vrati false
            if (!_listaVozaca.Contains(v))
                return false;

            _listaVozaca.Remove(v);
            return true;
        }

        public void SortirajListuVozaca()
        {
            if (SortListDelegate != null)
                SortListDelegate.Invoke(_listaVozaca);
        }

        #endregion
    }
}
