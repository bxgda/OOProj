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
    public partial class FormZabrana : Form
    {
        #region Attributes

        private bool sveOk = false;
        private List<Zabrana> _listaZabrana;
        private List<Zabrana> _listaMogucihKategorija;

        #endregion

        #region Constructors

        public FormZabrana()
        {
            InitializeComponent();
        }

        public FormZabrana(ref List<Zabrana> listaZabrana, List<Kategorija> listaMogucihKategorija)
            : this()
        {
            _listaZabrana = listaZabrana;

            // Inicijalizacija ComboBox-a sa mogucim kategorijama koje mogu da se zabrane
            cbKategorija.Items.Clear();
            foreach (Kategorija kategorija in listaMogucihKategorija)
                cbKategorija.Items.Add(kategorija.OznakaKategorije);
        }

        #endregion

        #region EventHandlers

        private void FormZabrana_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!sveOk)
                if (ZatvoriFormu() == DialogResult.No)
                    e.Cancel = true;
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

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validiraj())
                return;

            string nazivKategorije = cbKategorija.SelectedItem.ToString();
            Zabrana tmp = new Zabrana(nazivKategorije, dtpDatumOd.Value, dtpDatumDo.Value);

            // Provera dal dodajemo zabranu za kategoriju koja vec postoji u listi zabrana
            if (!Proveri(tmp))
            {
                MessageBox.Show("Zabrana za izabranu kategoriju već postoji.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            _listaZabrana.Add(tmp);
            sveOk = true;
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        #endregion

        #region Methods

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

        private bool Proveri(Zabrana tmp)
        {
            foreach (var z in _listaZabrana)
            {
                if (z.Kategorija == tmp.Kategorija)
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
