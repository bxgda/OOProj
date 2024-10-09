using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Racunanje
{
    public class ALU
    {
        #region Atributi

        private List<double> operandi;
        private List<char> operacije;

        #endregion

        #region Konstruktor

        public ALU()
        {
            operandi = new List<double>();
            operacije = new List<char>();
        }

        #endregion

        #region Metode

        public double Izracunaj(string izraz)
        {
            operandi.Clear();
            operacije.Clear();

            double rezultat = 0;

            // Izdvajanje operanada i operacija iz izraza
            Izdvoji(izraz);

            // Sve operacije su binarne pa se uvek operacija vrsi nad prva dva operanda
            // a rezultat se smesta kao novi prvi operand (ponasa se kao Akumulator)
            while (operacije.Count != 0)
            {
                if (operandi[1] == 0 && operacije[0] == '/')
                    throw new DivideByZeroException("Deljenje nulom nije dozvoljeno.");
                rezultat = UradiOperaciju(operandi[0], operandi[1], operacije[0]);
                operacije.RemoveAt(0);
                operandi[0] = rezultat;
                operandi.RemoveAt(1);
            }

            return operandi[0];
        }

        private double UradiOperaciju(double op1, double op2, char o)
        {
            double rez = 0;

            switch (o)
            {
                case '+':
                    rez = op1 + op2;
                    break;
                case '-':
                    rez = op1 - op2;
                    break;
                case '*':
                    rez = op1 * op2;
                    break;
                case '/':
                    rez = op1 / op2;
                    break;
                default:
                    throw new ArgumentException("Nepodržana operacija: " + o);
            }

            return rez;
        }

        private void Izdvoji(string izraz)
        {
            // ovo je zbog ove jebene zagrade
            // znaci samo vratim izraz kako bi izgledao bez zagrade jer nicemu ne sluze osim za priaz
            bool neg = false;
            for (int i = 0; i < izraz.Length; ++i)
            {
                if (izraz[i] == ')' && neg)
                {
                    neg = false;
                    continue;
                }
                else if (izraz[i] == '(' && izraz[i + 1] == '-')
                {
                    neg = true;
                    continue;
                }
                else if (izraz[i] == '(' || izraz[i] == ')')
                {
                    izraz = izraz.Substring(0, i) + izraz.Substring(i + 1, izraz.Length - i - 1);
                    --i;
                }
            }

            // na dalje isto
            List<string> brIzmedjuZnakova = new List<string>();

            int pocetak = 0;
            for (int i = 0; i < izraz.Length; ++i)
            {
                if (JeZnak(izraz[i]))
                {
                    if (izraz[i - 1] != '(')
                        operacije.Add(izraz[i]);

                    brIzmedjuZnakova.Add(izraz.Substring(pocetak, i - pocetak));
                    pocetak = i + 1;
                }
            }

            brIzmedjuZnakova.Add(izraz.Substring(pocetak, izraz.Length - pocetak));

            foreach (var broj in brIzmedjuZnakova)
            {
                if (broj == "(")
                    continue;

                // ako je broj u zagradi znaci da je negativan
                if (broj[broj.Length - 1] == ')')
                    operandi.Add(-double.Parse(broj.Substring(0, broj.Length - 1)));
                // inace je pozitivan
                else
                    operandi.Add(double.Parse(broj));
            }
        }

        private bool JeZnak(char v)
        {
            return (v == '+' || v == '-' || v == '*' || v == '/');
        }

        #endregion
    }
}
