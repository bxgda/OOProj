using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Racunanje
{
    public class ALU
    {
        private List<double> operandi;
        private List<char> operacije;

        public ALU()
        {
            operandi = new List<double>();
            operacije = new List<char>();
        }

        public double Izracunaj(string izraz)
        {
            operandi.Clear();
            operacije.Clear();

            double rezultat = 0;

            Izdvoji(izraz);

            while (operacije.Count != 0)
            {
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

                if (broj[broj.Length - 1] == ')')
                    operandi.Add(-double.Parse(broj.Substring(0, broj.Length - 1)));
                else
                    operandi.Add(double.Parse(broj));
            }
        }

        private bool JeZnak(char v)
        {
            return (v == '+' || v == '-' || v == '*' || v == '/');
        }
    }
}
