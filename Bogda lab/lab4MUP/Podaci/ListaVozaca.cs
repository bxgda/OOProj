using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaVozaca
    {
        #region Atributi

        private static ListaVozaca instanca = null;
        private List<Vozac> lista;
        public delegate void SortDelegate(List<Vozac> l);

        #endregion

        #region Properties

        public static ListaVozaca Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new ListaVozaca();
                return instanca;
            }
        }

        public List<Vozac> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public SortDelegate Sortiranje { get; set; }

        #endregion

        #region Konstruktori

        private ListaVozaca()
        {
            lista = new List<Vozac>();
        }

        #endregion

        #region Metode

        public bool Dodaj(Vozac v)
        {
            if (lista.Contains(v))
                return false;
            lista.Add(v);
            return true;
        }

        public bool Obrisi(Vozac v)
        {
            if (!lista.Contains(v))
                return false;
            lista.Remove(v);
            return true;
        }

        public Vozac VratiVozaca(string brojDozvolen)
        {
            foreach (Vozac v in lista)
                if (v.BrojDozvole == brojDozvolen)
                    return v;
            return null;
        }

        public bool Izmeni(Vozac v)
        {
            Vozac uListi = VratiVozaca(v.BrojDozvole);
            if (uListi == null) return false;
            uListi.Ime = v.Ime;
            uListi.Prezime = v.Prezime;
            uListi.DatumRodj = v.DatumRodj;
            uListi.VaziOd = v.VaziOd;
            uListi.VaziDo = v.VaziDo;
            uListi.BrojDozvole = v.BrojDozvole;
            uListi.MestoIzdavanja = v.MestoIzdavanja;
            uListi.Pol = v.Pol;
            uListi.Slika = v.Slika;
            uListi.Kategorije = v.Kategorije;
            uListi.Zabrane = v.Zabrane;
            return true;
        }

        public void Sortiraj()
        {
            if(Sortiranje != null)
                Sortiranje(lista);
        }

        #endregion
    }
}
