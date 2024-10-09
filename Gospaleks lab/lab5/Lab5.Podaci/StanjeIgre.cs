using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Lab5.Podaci
{
    [Serializable]
    public class StanjeIgre
    {
        #region Atributi

        // Samo jedna instanca stanja igre
        private static StanjeIgre _instance;

        private Polje[,] _mat;

        private List<Image> _slike;

        private int _brojRedova;
        private int _brojKolona;
        private int _brojParova;
        private int _brojSlika;
        private int _brojOtvorenihParova;
        private int _brojSekundi;
        private bool _kliknuto;
        private int _redPrvoKliknuto;
        private int _kolonaPrvoKliknuto;

        Random rnd = new Random();

        #endregion

        #region Atributi-Liste

        private List<int> _redovi;
        private List<int> _kolone;
        private List<int> _slikePolja;
        private List<bool> _otkrivena;

        #endregion

        #region Konstruktori

        private StanjeIgre()
        {
            _slike = new List<Image>();
        }

        #endregion

        #region Properties

        [XmlIgnore]
        public Polje this[int i, int j]
        {
            get { return _mat[i, j]; }
            set { _mat[i, j] = value; }
        }

        [XmlIgnore]
        public static StanjeIgre Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StanjeIgre();
                return _instance;
            }
            set { _instance = value; }
        }

        [XmlIgnore]
        public List<Image> Slike
        {
            get { return _slike; }
            set { _slike = value; }
        }

        public int BrojRedova
        {
            get { return _brojRedova; }
            set { _brojRedova = value; }
        }

        public int BrojKolona
        {
            get { return _brojKolona; }
            set { _brojKolona = value; }
        }

        public int BrojParova
        {
            get { return _brojParova; }
            set { _brojParova = value; }
        }

        public int BrojSlika
        {
            get { return _brojSlika; }
            set { _brojSlika = value; }
        }

        public int BrojOtvorenihParova
        {
            get { return _brojOtvorenihParova; }
            set { _brojOtvorenihParova = value; }
        }

        public List<int> Redovi { get => _redovi; set => _redovi = value; }
        public List<int> Kolone { get => _kolone; set => _kolone = value; }
        public List<int> SlikePolja { get => _slikePolja; set => _slikePolja = value; }
        public List<bool> Otkrivena { get => _otkrivena; set => _otkrivena = value; }
        public int BrojSekundi { get => _brojSekundi; set => _brojSekundi = value; }
        public bool Kliknuto { get => _kliknuto; set => _kliknuto = value; }
        public int RedPrvoKliknuto { get => _redPrvoKliknuto; set => _redPrvoKliknuto = value; }
        public int KolonaPrvoKliknuto { get => _kolonaPrvoKliknuto; set => _kolonaPrvoKliknuto = value; }

        #endregion

        #region Metode

        public void Save(int brojSekundi, bool kliknuto, int prvoKlikRed, int prvoKlikKolona)
        {
            string putanjaFajla = $"../../../Podaci/Sacuvane_Igre/{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")}.xml";

            _redovi = new List<int>();
            _kolone = new List<int>();
            _slikePolja = new List<int>();
            _otkrivena = new List<bool>();
            _brojSekundi = brojSekundi;
            _kliknuto = kliknuto;
            _redPrvoKliknuto = prvoKlikRed;
            _kolonaPrvoKliknuto = prvoKlikKolona;

            for (int i = 0; i < _brojRedova; i++)
                for (int j = 0; j < _brojKolona; j++)
                {
                    _redovi.Add(_mat[i, j].Red);
                    _kolone.Add(_mat[i, j].Kolona);
                    _slikePolja.Add(_mat[i, j].Slika);
                    _otkrivena.Add(_mat[i, j].Otkriveno);
                }
                   
            XmlTextWriter wr = null;

            try
            {
                wr = new XmlTextWriter(putanjaFajla, Encoding.Unicode);

                XmlSerializer sr = new XmlSerializer(typeof(StanjeIgre));

                sr.Serialize(wr, this);
            }
            catch
            {
            }
            finally
            {
                wr.Close();
            }

            // Poruka korisniku
            MessageBox.Show($"Igra je sačuvana!\n{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Load(string fileName)
        {
            StreamReader rd = null;

            try
            {
                rd = new StreamReader(fileName, Encoding.Unicode);

                XmlSerializer sr = new XmlSerializer(typeof(StanjeIgre));

                Instance = (StanjeIgre)sr.Deserialize(rd);
            }
            catch
            {
            }
            finally
            {
                rd.Close();
            }

            UcitajAtribute();
        }

        private static void UcitajAtribute()
        {

            Instance._mat = null;
            Instance._mat = new Polje[Instance.BrojRedova, Instance.BrojKolona];
            for (int i = 0; i < Instance.BrojRedova; i++)
                for (int j = 0; j < Instance.BrojKolona; j++)
                    Instance._mat[i, j] = new Polje(i, j);

            for (int i = 0; i < Instance.BrojRedova; i++)
                for (int j = 0; j < Instance.BrojKolona; j++)
                {
                    Instance[i, j].Red = Instance.Redovi[i * Instance.BrojKolona + j];
                    Instance[i, j].Kolona = Instance.Kolone[i * Instance.BrojKolona + j];
                    Instance[i, j].Slika = Instance.SlikePolja[i * Instance.BrojKolona + j];
                    Instance[i, j].Otkriveno = Instance.Otkrivena[i * Instance.BrojKolona + j];
                }
        }

        public void UcitajSlike()
        {
            _slike = new List<Image>();
            for (int i = 0; i <= _brojSlika; i++)
                _slike.Add(Image.FromFile($"../../../Podaci/Slike/{i}.png"));
        }

        public void InicijalizujMatricu()
        {
            _brojOtvorenihParova = 0;

            _mat = null;
            _mat = new Polje[_brojRedova, _brojKolona];
            for (int i = 0; i < _brojRedova; i++)
                for (int j = 0; j < _brojKolona; j++)
                    _mat[i, j] = new Polje(i, j);
        }
        public void GenerisiParoveSlika()
        {
            int trSlika = 1;
            for (int i = 0; i < _brojParova; i++)
            {
                // Generisi dva polja
                int r1, k1, r2, k2;
                GenerisiRandomPolja(out r1, out k1, out r2, out k2);

                // Postavi slike
                _mat[r1, k1].Slika = trSlika;
                _mat[r2, k2].Slika = trSlika;

                // idi sa slikama u krug s tim da nultu preskace jer je to X
                trSlika = ((trSlika + 1) % (_brojSlika + 1));
                if (trSlika == 0)
                    trSlika = 1;
            }
        }

        private void GenerisiRandomPolja(out int r1, out int k1, out int r2, out int k2)
        {
            do
            {
                r1 = rnd.Next(_brojRedova);
                k1 = rnd.Next(_brojKolona);
                r2 = rnd.Next(_brojRedova);
                k2 = rnd.Next(_brojKolona);
            } while (_mat[r1, k1].Slika != 0 || _mat[r2, k2].Slika != 0 || (r1 == r2 && k1 == k2));
        }

        public bool ProveriZaKrajIgre()
        {
            return _brojOtvorenihParova == _brojParova;
        }

        #endregion
    }
}
