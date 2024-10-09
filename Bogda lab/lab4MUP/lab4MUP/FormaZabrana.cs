using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4MUP
{
    public partial class FormaZabrana : Form
    {
        #region Atributi

        private bool uRedu = false;
        private List<Kategorija> listaKat;
        private List<Kategorija> listaZab;

        #endregion

        #region Konstruktori

        public FormaZabrana()
        {
            InitializeComponent();
        }

        public FormaZabrana(ref List<Kategorija> listaZabrana, List<Kategorija> listaMogucihKategorija)
            : this()
        {
            listaZab = listaZabrana;
            cbKat.Items.Clear();
            foreach (Kategorija kategorija in listaMogucihKategorija)
                cbKat.Items.Add(kategorija.Oznaka);
        }

        #endregion

        #region Event Handlers

        private void FormaZabrana_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!uRedu)
                if (Zatvori() == DialogResult.No)
                    e.Cancel = true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (Zatvori() == DialogResult.Yes)
            {
                uRedu = true;
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validiraj())
                return;

            string nazivKategorije = cbKat.SelectedItem.ToString();
            Kategorija tmp = new Kategorija(nazivKategorije, dtpOd.Value, dtpDo.Value);

            if (!Proveri(tmp))
            {
                MessageBox.Show("Zabrana za izabranu kategoriju već postoji.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listaZab.Add(tmp);
            uRedu = true;
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        #endregion

        #region Metode

        private DialogResult Zatvori()
        {
            return MessageBox.Show("Da li sigurno želite da zatvorite formu?", "Obaveštenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private bool Proveri(Kategorija tmp)
        {
            foreach (var z in listaZab)
                if (z.Oznaka == tmp.Oznaka)
                    return false;
            return true;
        }

        private bool Validiraj()
        {
            if (cbKat.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati vrednost za polje Kategorija.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbKat.Focus();
                return false;
            }

            if (dtpOd.Value > dtpDo.Value)
            {
                MessageBox.Show("Datum od mora biti manji od datuma do.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpOd.Focus();
                return false;
            }

            return true;
        }

        #endregion
    }
}
