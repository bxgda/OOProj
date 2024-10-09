using Extensions;
using Racunanje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleCalculator
{
    public partial class GlavnaForma : Form
    {
        #region Atributi

        private ALU alu;                // objekat za izracunavanje
        private FileUpisivac upisivac;  // objekat za upisivanje u fajl

        private bool jeUnetaTacka;      // flag da li je uneta tacka
        private bool datumPrikazan;     // flag da li je trenutno prikazan datum
        private bool negativan;
        private string izraz;
        private int brOtvorenih;        // broj otvorenih zagrada (kad je na 0 izraz je ok)

        private bool cuvaSe = false;    // flag da li se cuva unos u fajl
        private int saveIndex;          // index u ekranText odakle pocinje da se cuva unos u fajl

        #endregion

        #region Konstruktor

        public GlavnaForma()
        {
            InitializeComponent();

            alu = new ALU();
            upisivac = new FileUpisivac("input.txt");

            Init();
        }

        #endregion

        #region EventHendleri

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ZatvoriFormu() == DialogResult.No)
                e.Cancel = true;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatum_Click(object sender, EventArgs e)
        {
            if (datumPrikazan)
            {
                datumPrikazan = false;
                ekran.Text = izraz;
                btnDatum.BackColor = SystemColors.Control;
            }
            else
            {
                izraz = ekran.Text;
                ekran.Text = DateTime.Now.VratiTrenutnoVreme();
                datumPrikazan = true;
                btnDatum.BackColor = Color.LightBlue;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!datumPrikazan)
            {
                Init();

                MessageBox.Show("Sadržaj ekrana je obrisan.", "Obaveštenje",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cifra_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            UnosCifre(btn.Text);
        }

        private void operacija_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            UnosOperacije(btn.Text[0]);
        }

        private void btnTacka_Click(object sender, EventArgs e)
        {
            // Tacka moze da se unese samo ako nije uneta prethodno i ako zadnji karakter u izrazu nije )
            // Jer posle ) mora da ide znak operacije
            if (!jeUnetaTacka)
            {
                if (ekran.Text == "")
                   ekran.Text = "0.";
                else if (JeZnak(ekran.Text[ekran.Text.Length - 1]))
                    ekran.Text += "0.";
                else if (ekran.Text[ekran.Text.Length - 1] != ')')
                    ekran.Text += ".";

                jeUnetaTacka = true;
            }
        }

        private void btnZnak_Click(object sender, EventArgs e)
        {
            // Spec slucaj kad se klikne dugme za znak a ekran je prazan
            if (ekran.Text == "")
            {
                ekran.Text = "(-";
                negativan = true;
                return;
            }

            if (!datumPrikazan && ekran.Text != "")
            {
                // Ako je prvo kliknuto dugme za znak samo dodaj (- 
                if (!negativan && JeZnak(ekran.Text[ekran.Text.Length - 1]))
                {
                    ekran.Text += "(-";
                    negativan = true;
                }
                else if (negativan)
                {
                    IzbaciZagradeOkoNegativnog();
                    negativan = false;
                }
                // Ako je unet broj pa kliknuto dugme za znak
                else
                {
                    if (ekran.Text[ekran.Text.Length - 1] != ')')
                        UbaciZagradeOkoNegativnog();
                    else
                        IzbaciZagradeOkoNegativnog();
                }
            }
        }

        private void btnJednako_Click(object sender, EventArgs e)
        {
            if (!datumPrikazan && ekran.Text != "" && !JeZnak(ekran.Text[ekran.Text.Length - 1]) && brOtvorenih == 0)
            {
                saveIndex = 0;
                string izraz = ekran.Text;
                double rez = 0.0;
                
                try
                {
                    rez = alu.Izracunaj(izraz); // poziv metode za izracunavanje izraza
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ekran.Text = "";
                    return;
                }

                // Ako je rezultat razlomljen broj onemoguci unos tacke
                if (rez % 1 != 0)
                    jeUnetaTacka = true;

                // Ako je rezultat negativan prikazi ga na ekran sa zagradama
                if (rez < 0)
                    ekran.Text = "(" + rez.ToString() + ")";
                else
                    ekran.Text = rez.ToString();

                MessageBox.Show($"Rezultat izraza {izraz} je {ekran.Text}", "Obaveštenje",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                brOtvorenih = 0;
            }
            else
            {
                MessageBox.Show("Loš format!", "Greška",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Dodato za za otvaranje i zatvaranje zagrada
        private void btnOtvorena_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "")
            {
                ekran.Text = "(";
                brOtvorenih++;
            }
            else if (ekran.Text[ekran.Text.Length - 1] == '(' || JeZnak(ekran.Text[ekran.Text.Length - 1]))
            {
                ekran.Text += "(";
                brOtvorenih++;
            }
        }

        private void btnZatvorena_Click(object sender, EventArgs e)
        {
            if (ekran.Text.Length > 0 && ekran.Text[ekran.Text.Length - 1] == '(')
                return;

            if (brOtvorenih == 0 || ekran.Text == "" || JeZnak(ekran.Text[ekran.Text.Length - 1]))
                return;

            ekran.Text += ")";
            --brOtvorenih;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!cuvaSe)
            {
                cuvaSe = true;
                btnSave.BackColor = Color.LightBlue;

                // otvori stream za upis
                upisivac.OtvoriStream();

                if (ekran.Text == "")
                    return;

                saveIndex = ekran.Text.Length - 1;
            }
            else
            {
                // zatvori stream
                cuvaSe = false;
                btnSave.BackColor = SystemColors.Control;

                upisivac.ZatvoriStream();
            }
        }

        private void ekran_TextChanged(object sender, EventArgs e)
        {
            if (cuvaSe)
                upisivac.Upisi(ekran.Text.Substring(saveIndex));
        }

        #endregion

        #region Metode

        private void Init()
        {
            jeUnetaTacka = false;
            datumPrikazan = false;
            negativan = false;
            brOtvorenih = 0;
            saveIndex = 0;
            izraz = "";
            ekran.Text = "";
        }

        private void UnosCifre(string cifra)
        {
            if (!datumPrikazan && (ekran.Text == "" || ekran.Text[ekran.Text.Length - 1] != ')'))
            {
                ekran.Text += cifra;
            }
        }

        private bool JeZnak(char v)
        {
            return (v == '+' || v == '-' || v == '*' || v == '/');
        }

        private void UnosOperacije(char op)
        {
            if (!datumPrikazan && ekran.Text != "" && ekran.Text[ekran.Text.Length - 1] != '.')
            {
                // ako je bio znak pa opet kliknuto samo ga promeni
                if (JeZnak(ekran.Text[ekran.Text.Length - 1]))
                {
                    ekran.Text = ekran.Text.Remove(ekran.Text.Length - 1);
                    ekran.Text += op;
                    return;
                }

                if (negativan)
                    ekran.Text += ")";
                negativan = false;

                ekran.Text += op;
                jeUnetaTacka = false;
            }
        }

        private void UbaciZagradeOkoNegativnog()
        {
            string s = ekran.Text;
            int indeks = s.Length - 1;

            while (indeks > 0 && !JeZnak(s[indeks]))
                indeks--;

            if (JeZnak(s[indeks]))
                indeks++;

            ekran.Text = ekran.Text.Insert(indeks, "(-");
            if (s[s.Length - 1] == '.')
            {
                ekran.Text = ekran.Text.Remove(ekran.Text.Length - 1);
                jeUnetaTacka = false;
            }

            ekran.Text += ")";
        }

        private void IzbaciZagradeOkoNegativnog()
        {
            string str = ekran.Text;
            int indeks = str.Length - 1;
            while (indeks > 0 && str[indeks] != '(') // trazi prvu otvorenu zagradu s leva
                indeks--;

            if (negativan)
                ekran.Text = (str.Substring(0, indeks) + str.Substring(indeks + 2, str.Length - indeks - 2));
            else
                ekran.Text = (str.Substring(0, indeks) + str.Substring(indeks + 2, str.Length - indeks - 3));
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li sigurno želite da zatvorite formu?", "Obaveštenje",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion

    }
}

