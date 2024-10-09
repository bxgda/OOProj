using Extensions;
using Racunanje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        private ALU alu;
        private bool jeUnetaTacka;
        private bool datumPrikazan;
        private string izraz;
        private string skrivenIzraz;
        private bool jeOtvorenaZagrada;
        private bool jeZnak;

        #endregion

        #region Konstruktor

        public GlavnaForma()
        {
            InitializeComponent();

            alu = new ALU();
            jeUnetaTacka = false;
            datumPrikazan = false;
            izraz = "";
            skrivenIzraz = "";
            jeOtvorenaZagrada = false;
            jeZnak = false;
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
            }
            else
            {
                izraz = ekran.Text;
                ekran.Text = DateTime.Now.VratiTrenutnoVreme();
                datumPrikazan = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ekran.Text = "";
            skrivenIzraz = "";
            jeUnetaTacka = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            UnosCifre(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            UnosCifre(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            UnosCifre(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            UnosCifre(btn3.Text);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            UnosCifre(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            UnosCifre(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            UnosCifre(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            UnosCifre(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            UnosCifre(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            UnosCifre(btn9.Text);
        }

        private void btnTacka_Click(object sender, EventArgs e)
        {
            if (!jeUnetaTacka)
            {
                if (ekran.Text == "")
                   ekran.Text = "0.";
                else if (JeZnak(ekran.Text[ekran.Text.Length - 1]))
                    ekran.Text += "0.";
                else
                    ekran.Text += ".";

                jeUnetaTacka = true;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            UnosOperacije('+');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            UnosOperacije('-');
        }

        private void btnMnozenje_Click(object sender, EventArgs e)
        {
            UnosOperacije('*');
        }

        private void btnDeljenje_Click(object sender, EventArgs e)
        {
            UnosOperacije('/');
        }

        private void btnOtvorena_Click(object sender, EventArgs e)
        {
            UnosZagrade('(');
        }

        private void btnZatvorena_Click(object sender, EventArgs e)
        {
            UnosZagrade(')');
        }

        private void btnZnak_Click(object sender, EventArgs e)
        {
            string s = ekran.Text;
            if (ekran.Text != "" && !JeZnak(s[s.Length - 1]) && s[s.Length - 1] != '(')
            {
                // Ubaci zagrade oko broja za negativan broj
                if (s[s.Length - 1] != ')')
                {
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
                    jeZnak = true;
                }
                // Izbaci zagrade
                else if(jeZnak)
                {
                    string str = ekran.Text;
                    int indeks = str.Length - 1;
                    while (indeks > 0 && str[indeks] != '(')
                        indeks--;

                    ekran.Text = (str.Substring(0, indeks) + str.Substring(indeks + 2, str.Length - indeks - 3));
                    jeZnak = false;
                }
            }
        }

        private void btnJednako_Click(object sender, EventArgs e)
        {

            if (ekran.Text != "" && !JeZnak(ekran.Text[ekran.Text.Length - 1]))
            {
                string izraz = ekran.Text;
                double rez = alu.Izracunaj(skrivenIzraz);
                if (rez < 0)
                    ekran.Text = "(" + rez.ToString() + ")";
                else
                    ekran.Text = rez.ToString();

                MessageBox.Show($"Rezultat izraza {izraz} je {ekran.Text}", "Obaveštenje",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Loš format!", "Greška",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metode

        private void UnosCifre(string cifra)
        {
            if (!datumPrikazan && (ekran.Text == "" || ekran.Text[ekran.Text.Length - 1] != ')'))
            {
                ekran.Text += cifra;
                skrivenIzraz += cifra;
            }
        }

        private bool JeZnak(char v)
        {
            return (v == '+' || v == '-' || v == '*' || v == '/');
        }

        private void UnosOperacije(char op)
        {
            if (!datumPrikazan && ekran.Text != "")
            {
                char poslednji = ekran.Text[ekran.Text.Length - 1]; 
                if (poslednji == '.')
                {
                    ekran.Text += '0';
                    skrivenIzraz += '0';
                }
                else if (JeZnak(poslednji))
                {
                    ekran.Text = ekran.Text.Substring(0, ekran.Text.Length - 1);
                    skrivenIzraz = skrivenIzraz.Substring(0, skrivenIzraz.Length - 1);
                }
                if (poslednji != '(')
                {
                    ekran.Text += op;
                    skrivenIzraz += op;
                    jeUnetaTacka = false;
                }
                jeZnak = false;
            }
        }

        private void UnosZagrade(char z)
        {
            if(ekran.Text == "" || JeZnak(ekran.Text[ekran.Text.Length - 1]))
            {
                if(!jeOtvorenaZagrada && z == '(')
                {
                    ekran.Text += z;
                    jeOtvorenaZagrada = true;
                }
            }
            if(jeOtvorenaZagrada && z == ')')
            {
                ekran.Text += z;
                jeOtvorenaZagrada = false;
            }
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li sigurno želite da zatvorite formu?", "Obaveštenje",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion

    }
}

