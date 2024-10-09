using Ekstenzije;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace lab4MUP
{
    public partial class FormaVozac : Form
    {
        #region Atributi

        private bool uRedu = false;
        private List<Kategorija> tmpKat = new List<Kategorija>();
        private List<Kategorija> tmpZab = new List<Kategorija>();

        #endregion

        #region Properties

        public Vozac Vozac { get; set; }

        #endregion

        #region Konstruktori

        public FormaVozac()
        {
            InitializeComponent();
        }

        public FormaVozac(Vozac v)
            : this()
        {
            Vozac = v;
            tmpKat = v.Kategorije.ToList();
            tmpZab = v.Zabrane.ToList();
            btnProsledi.Text = "Izmeni";
            btnSlika.Text = "Izmeni sliku";
            tbBroj.Enabled = false;
        }

        #endregion

        #region EventHandlers

        private void Odustani_Click(object sender, EventArgs e)
        {
            if (Zatvori() == DialogResult.Yes)
            {
                uRedu = true;
                this.Close();
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void FormaVozac_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!uRedu)
                if (Zatvori() == DialogResult.No)
                    e.Cancel = true;
        }

        private void FormaVozac_Load(object sender, EventArgs e)
        {
            UcitajListe();
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
                pbSlika.ImageLocation = ofd.FileName;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            if (Vozac == null) 
            {
                if (!Dodaj())
                {
                    MessageBox.Show("Neuspešno dodavanje. Pokušajte ponovo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else           
            {
                if (!Izmeni())
                {
                    MessageBox.Show("Neuspešna izmena. Pokušajte ponovo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Uspešno obavljena operacija.", "Obaveštenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            uRedu = true;
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void alphabetic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void alphabetic_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;
            tb.Text = tb.Text.PrvoVeliko();
        }

        private void tbBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnDodajKat_Click(object sender, EventArgs e)
        {
            var frm = new FormaKategorija(ref tmpKat);
            DialogResult dlg = frm.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajDataGridView();
        }

        private void btnDodajZabr_Click(object sender, EventArgs e)
        {
            var frm = new FormaZabrana(ref tmpZab, tmpKat);
            DialogResult dlg = frm.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajDataGridView();
        }

        private void btnObrisiKat_Click(object sender, EventArgs e)
        {
            if (dgvKategorije.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu stavku?",
                                               "Obaveštenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvKategorije.SelectedRows[0].Index;
            string oznakaKategorije = (string)dgvKategorije.Rows[selectedRow].Cells[0].Value;

            if (ObrisiKategoriju(oznakaKategorije))
            {
                ObrisiZabranu(oznakaKategorije);
                MessageBox.Show("Izabrana akcija je uspešno obavljena.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajDataGridView();
            }
            else
                MessageBox.Show("Izabrana akcija nije uspešno obavljena. Pokušajte ponovo.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnObrisiZabr_Click(object sender, EventArgs e)
        {
            if (dgvZabrane.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu stavku?",
                                               "Obaveštenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvZabrane.SelectedRows[0].Index;
            string oznakaKategorije = (string)dgvZabrane.Rows[selectedRow].Cells[0].Value;

            if (ObrisiZabranu(oznakaKategorije))
            {
                MessageBox.Show("Izabrana akcija je uspešno obavljena.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajDataGridView();
            }
            else
                MessageBox.Show("Izabrana akcija nije uspešno obavljena. Pokušajte ponovo.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Metode

        private bool ObrisiZabranu(string oznakaKategorije)
        {
            Kategorija z = tmpZab.Find(x => x.Oznaka == oznakaKategorije);
            if (z == null)
                return false;
            tmpZab.Remove(z);
            return true;
        }

        private bool ObrisiKategoriju(string oznakaKategorije)
        {
            Kategorija k = tmpKat.Find(x => x.Oznaka == oznakaKategorije);
            if (k == null)
                return false;
            tmpKat.Remove(k);
            return true;
        }

        private bool Izmeni()
        {
            bool pol;

            if (cbPol.SelectedItem.ToString() == "M") pol = false;
            else pol = true;

            Vozac v = new Vozac(tbIme.Text, tbPrezime.Text, dtpRodj.Value, dtpOd.Value, dtpDo.Value, tbBroj.Text, tbMesto.Text, pol, pbSlika.ImageLocation, tmpKat, tmpZab);

            return ListaVozaca.Instanca.Izmeni(v);
        }

        private bool Dodaj()
        {
            bool pol;

            if (cbPol.SelectedItem.ToString() == "M") pol = false;
            else pol = true;

            Vozac v = new Vozac(tbIme.Text, tbPrezime.Text, dtpRodj.Value, dtpOd.Value, dtpDo.Value, tbBroj.Text, tbMesto.Text, pol, pbSlika.ImageLocation, tmpKat, tmpZab);

            return ListaVozaca.Instanca.Dodaj(v);
        }

        private bool Validacija()
        {
            if(String.IsNullOrEmpty(tbIme.Text))
            {
                MessageBox.Show("Polje Ime ne sme biti prazno.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbIme.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbPrezime.Text))
            {
                MessageBox.Show("Polje Prezime ne sme biti prazno.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPrezime.Focus();
                return false;
            }

            if (dtpOd.Value > dtpDo.Value)
            {
                MessageBox.Show("Datum važenja dozvole od ne može biti veći od datuma važenja dozvole do.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpOd.Focus();
                return false;
            }

            if (DateTime.Now.Year - dtpRodj.Value.Year < 18)
            {
                MessageBox.Show("Vozač mora biti punoletan.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpRodj.Focus();
                return false;
            }

            if (tbBroj.Text.Length < tbBroj.MaxLength)
            {
                MessageBox.Show("Polje Br. vozačke dozvole mora sadržati 9 cifara.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBroj.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbMesto.Text))
            {
                MessageBox.Show("Polje Mesto izdavanja ne sme biti prazno.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMesto.Focus();
                return false;
            }

            if (cbPol.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati vrednost za polje Pol.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbPol.Focus();
                return false;
            }

            //if (String.IsNullOrEmpty(pbSlika.ImageLocation))
            //{
            //    MessageBox.Show("Morate izabrati sliku.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    btnSlika.Focus();
            //    return false;
            //}

            return true;
        }

        private void UcitajListe()
        {
            if (Vozac != null)
                UcitajUKontrole();
            UcitajDataGridView();
        }

        private void UcitajDataGridView()
        {
            dgvKategorije.DataSource = tmpKat.ToList();
            dgvZabrane.DataSource = tmpZab.ToList();

            if (dgvKategorije.RowCount > 0)
                btnObrisiKat.Enabled = true;
            else
                btnObrisiKat.Enabled = false;

            if (dgvZabrane.RowCount > 0)
                btnObrisiZabr.Enabled = true;
            else
                btnObrisiZabr.Enabled = false;
        }

        private void UcitajUKontrole()
        {
            tbIme.Text = Vozac.Ime;
            tbPrezime.Text = Vozac.Prezime;
            dtpRodj.Value = Vozac.DatumRodj;
            dtpOd.Value = Vozac.VaziOd;
            dtpDo.Value = Vozac.VaziDo;
            tbBroj.Text = Vozac.BrojDozvole;
            tbMesto.Text = Vozac.MestoIzdavanja;
            cbPol.SelectedItem = Vozac.Pol ? "Ž" : "M";
            pbSlika.ImageLocation = Vozac.Slika;
        }

        private DialogResult Zatvori()
        {
            return MessageBox.Show("Da li sigurno želite da odustanete?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion
    }
}
