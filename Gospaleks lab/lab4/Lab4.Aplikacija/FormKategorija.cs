using Lab4.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Aplikacija
{
    public partial class FormKategorija : Form
    {
        #region Attributes

        private bool sveOk = false;
        private List<Kategorija> _listaKategorija;

        #endregion

        #region Constructors

        public FormKategorija()
        {
            InitializeComponent();
        }

        public FormKategorija(ref List<Kategorija> listaKategorija)
            : this()
        {
            _listaKategorija = listaKategorija;
        }

        #endregion

        #region EventHandlers

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validiraj())
                return;

            string nazivKategorije = cbKategorija.SelectedItem.ToString();
            Kategorija tmp = new Kategorija(nazivKategorije, dtpDatumOd.Value, dtpDatumDo.Value);

            if(!Proveri(tmp))
            {
                MessageBox.Show("Kategorija sa unetom oznakom već postoji.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            _listaKategorija.Add(tmp);
            sveOk = true;
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            if (ZatvoriFormu() == DialogResult.Yes)
            {
                sveOk = true;
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void FormKategorija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!sveOk)
                if (ZatvoriFormu() == DialogResult.No)
                    e.Cancel = true;
        }

        #endregion

        #region Methods

        private bool Proveri(Kategorija tmp)
        {
            // Proveri da li kategorija vec postoji
            foreach (var k in _listaKategorija)
            {
                if (k.OznakaKategorije == tmp.OznakaKategorije)
                    return false;
            }

            return true;
        }

        private bool Validiraj()
        {
            if (cbKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati vrednost za polje Kategorija.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                cbKategorija.Focus();
                return false;
            }

            if (dtpDatumOd.Value > dtpDatumDo.Value)
            {
                MessageBox.Show("Datum od mora biti manji od datuma do.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                dtpDatumOd.Focus();
                return false;
            }

            return true;
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li sigurno želite da zatvorite formu?", "Obaveštenje",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion
    }
}
