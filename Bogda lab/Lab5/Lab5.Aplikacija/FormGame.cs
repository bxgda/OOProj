using Lab5.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Aplikacija
{
    public partial class FormGame : Form
    {
        #region Atributi

        Random rnd = new Random();

        // Matrica polja
        private StanjeIgre igra;

        // Pomocne promenljive
        private bool kliknuto = false;
        private Polje prvoKliknuto = null;
        private int brojSekundi;
        private bool auto = false;
        private bool otvorenoAuto = false;
        private Polje randomPolje;
        private int indeksAuto;

        #endregion

        #region Konstruktori

        public FormGame()
        {
            InitializeComponent();

            igra = StanjeIgre.Instance;

            Restart();
        }

        public FormGame(Polje prvoKliknuto, bool kliknuto, int brojSekundi)
        {
            InitializeComponent();

            igra = StanjeIgre.Instance;

            if (prvoKliknuto.Red == -1)
                this.prvoKliknuto = new Polje(-1, -1);
            else
                this.prvoKliknuto = prvoKliknuto;

            this.kliknuto = kliknuto;
            this.brojSekundi = brojSekundi;

            // Osvezi prikaz
            pnlMatrica.Controls.Clear();
            igra.UcitajSlike();
            GenerisiMatricu();
            tmrGame.Start();
        }

        #endregion

        #region Metode

        private void Restart()
        {
            // Ucitaj podesavanja i slika
            UcitajPodesavanja();
            igra.UcitajSlike();

            // Inicijalizacija promenljivih
            kliknuto = false;
            prvoKliknuto = new Polje(-1, -1);

            // Inicijalizacija matrice
            igra.InicijalizujMatricu();
            igra.GenerisiParoveSlika();
            GenerisiMatricu();

            // Resetuj timer
            ResetujTimer();
            tmrGame.Start();
        }

        private void ResetujTimer()
        {
            brojSekundi = 0;
            lblVreme.Text = "00:00";
        }

        private void GenerisiMatricu()
        {
            for (int i = 0; i < igra.BrojRedova; i++)
            {
                for (int j = 0; j < igra.BrojKolona; j++)
                {
                    igra[i, j].Parent = pnlMatrica;
                    igra[i, j].Location = new Point(j * 80, i * 80);
                    igra[i, j].Width = 70;
                    igra[i, j].Height = 70;
                    igra[i, j].BackgroundImage = null;
                    igra[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    igra[i, j].FlatAppearance.BorderSize = 0;
                    igra[i, j].TabStop = false;

                    if (igra[i, j].Otkriveno)
                        igra[i, j].BackgroundImage = igra.Slike[igra[i, j].Slika];
                    else
                        igra[i, j].BackgroundImage = null;

                    // Dodaj event handler
                    igra[i, j].Click += ButtonClick;

                    // Zakaci na panel
                    pnlMatrica.Controls.Add(igra[i, j]);
                }
            }
        }

        private void UcitajPodesavanja()
        {
            var settings = Lab5.Settings.Settings.Instance;
            igra.BrojRedova = settings.BrojRedova;
            igra.BrojKolona = settings.BrojKolona;
            igra.BrojParova = settings.BrojParova;
            igra.BrojSlika = settings.BrojSlika;
        }

        private void OtkrijSvaPolja()
        {
            for (int i = 0; i < igra.BrojRedova; i++)
                for (int j = 0; j < igra.BrojKolona; j++)
                {
                    igra[i, j].Enabled = false;
                    igra[i, j].Otkriveno = true;
                    igra[i, j].BackgroundImage = igra.Slike[igra[i, j].Slika];
                }
            tmrGame.Stop();
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li sigurno želite da napustite trenutnu igru?", "Obaveštenje",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Information);
        }

        #endregion

        #region EventHandlers

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ZatvoriFormu() == DialogResult.No)
                e.Cancel = true;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Polje btn = sender as Polje;

            if (btn.Otkriveno)
                return;

            // Ako je kliknuo na prazno polje samo ga ostavi otvoreno
            if (btn.Slika == 0)
            {
                btn.BackgroundImage = igra.Slike[0];
                btn.Otkriveno = true;
                return;
            }

            // Ako nije kliknuto nista zapamti prvi klik i otvori kliknuto polje
            if (!kliknuto)
            {
                kliknuto = true;
                prvoKliknuto = btn;

                btn.Otkriveno = true;
                btn.BackgroundImage = igra.Slike[btn.Slika];

                return;
            }
            else
            {
                // Pogodjen par -> ostavi oba otvorena i povecaj broj otvorenih parova
                if (prvoKliknuto.Slika == btn.Slika)
                {
                    btn.Enabled = false;
                    btn.Otkriveno = true;
                    btn.BackgroundImage = igra.Slike[btn.Slika];

                    prvoKliknuto.Enabled = false;
                    kliknuto = false;
                    prvoKliknuto = new Polje(-1, -1);

                    igra.BrojOtvorenihParova++;
                }
                else
                {
                    // otvori polje, cekaj 1s i zatvori oba
                    btn.Otkriveno = true;
                    btn.BackgroundImage = igra.Slike[btn.Slika];

                    // koristi async/await da bi mogao da koristis Task.Delay
                    Task.Delay(500).ContinueWith(t =>
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            btn.BackgroundImage = null;
                            btn.Otkriveno = false;
                            prvoKliknuto.BackgroundImage = null;
                            prvoKliknuto.Otkriveno = false;

                            kliknuto = false;
                            prvoKliknuto = new Polje(-1, -1);
                        });
                    });

                }
            }

            // Provera za kraj igre
            if(igra.ProveriZaKrajIgre())
            {
                OtkrijSvaPolja();
                MessageBox.Show($"Čestitamo, pobedili ste! Vaše vreme je: {lblVreme.Text}", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            //TimeSpan vreme = DateTime.Now - _pocetnoVreme;
            brojSekundi++;
            TimeSpan vreme = TimeSpan.FromSeconds(brojSekundi); ;
            lblVreme.Text = $"{vreme.Minutes:00}:{vreme.Seconds:00}";
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMatrica.Controls.Clear();
            Restart();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormSettings();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void showFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sva polja se otkrivaju i blokiraju
            // Korisnik moze da restartuje igru ili da se vrati na pocetnu formu ili da ucita vec postojecu igru
            OtkrijSvaPolja();
        }

        private void backToStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            igra.Save(brojSekundi, kliknuto, prvoKliknuto.Red, prvoKliknuto.Kolona);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormLoad();
            frm.ShowDialog();
            
            if (frm.DialogResult == DialogResult.OK)
            {
                igra = StanjeIgre.Instance;

                if (igra.RedPrvoKliknuto == -1)
                    this.prvoKliknuto = new Polje(-1, -1);
                else
                    this.prvoKliknuto = igra[igra.RedPrvoKliknuto, igra.KolonaPrvoKliknuto];

                this.kliknuto = igra.Kliknuto;
                this.brojSekundi = igra.BrojSekundi;

                // Osvezi prikaz
                pnlMatrica.Controls.Clear();
                igra.UcitajSlike();
                GenerisiMatricu();
                tmrGame.Start();
            }
        }

        private void tmrAuto_Tick(object sender, EventArgs e)
        { 
            // ovo u sustini kurcu ne valja ali oke

            if (!otvorenoAuto)
            {
                List<Polje> neotvorenaPolja = igra.GetNeotvorenaPolja();
                if (neotvorenaPolja.Count > 0)
                {
                    randomPolje = neotvorenaPolja[indeksAuto++];
                    randomPolje.BackgroundImage = igra.Slike[randomPolje.Slika];
                    randomPolje.Otkriveno = true;
                    otvorenoAuto = true;
                }
            }
            else
            {
                randomPolje.BackgroundImage = null;
                randomPolje.Otkriveno = false;
                otvorenoAuto = false;
            }
        }

        private void randomAauto_Click(object sender, EventArgs e)
        {
            if (auto)
            {
                auto = false;
                tmrAuto.Stop();
            }
            else
            {
                indeksAuto = 0;
                auto = true;
                tmrAuto.Start();
            }
        }

        #endregion
    }
}
