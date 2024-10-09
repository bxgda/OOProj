using Extensions;
using Lab4.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4.Aplikacija
{
    public partial class FormVozac : Form
    {
        #region Attributes

        private bool sveOk = false;
        private List<Kategorija> _tmpListaKategorija = new List<Kategorija>();
        private List<Zabrana> _tmpListaZabrana = new List<Zabrana>();

        #endregion

        #region Properties

        public Vozac Vozac { get; set; }

        #endregion

        #region Constructors

        // Konstruktor koji se koristi za dodavanje novog vozaca
        public FormVozac()
        {
            InitializeComponent();
        }

        // Konstruktor koji se koristi za izmenu postojeceg vozaca
        public FormVozac(Vozac v)
            : this()
        {

            // Znaci ideja je da se ceo proces radi sa tmpListama, a tek na kraju kada se klikne na dugme za prosledi/izmeni
            // da se update-uje ili kreira novi korisnik sto mi omogucava da korisnik moze da odustane od promena klikom na dugme zatvori
            Vozac = v;
            _tmpListaKategorija = v.ListaKategorija.ToList();
            _tmpListaZabrana = v.ListaZabrana.ToList();
            btnProsledi.Text = "Izmeni";
            btnDodajSliku.Text = "Izmeni sliku";
            txtBrojVozackeDozvole.Enabled = false;
        }

        #endregion

        #region EventHandlers

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            if (ZatvoriFormu() == DialogResult.Yes)
            {
                sveOk = true;
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void FormVozac_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!sveOk) // ovaj flag sveOk omogucava da se forma zatvori bez provere ako je izvrseno dodavanje ili izmena
                if (ZatvoriFormu() == DialogResult.No)
                    e.Cancel = true;
        }

        private void FormVozac_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
                pbSlika.ImageLocation = ofd.FileName;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            // Ispitivanje da li su sva polja uneta
            if (!Validacija())
                return;

            if (Vozac == null)   // Dodavanje novog vozaca
            {
                if (!Dodaj())
                {
                    MessageBox.Show("Neuspešno dodavanje. Pokušajte ponovo.",
                                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else                 // Izmena postojeceg vozaca
            {
                if (!Izmeni())
                {
                    MessageBox.Show("Neuspešna izmena. Pokušajte ponovo.",
                                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Uspešno obavljena operacija.", "Obaveštenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            sveOk = true;
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
            tb.Text = tb.Text.PostaviPrvoVelikoSlovo();
        }

        private void txtBrojVozackeDozvole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            // Formi koja dodaje nove kategorije prosledjuje se privremena lista kategorija
            // koja se posle dodeli vozacu ako je u pitanju izmena postojeceg vozaca
            // ili se dodeli novom vozacu prilikom kreiranja objekta ako je u pitanju dodavanje novog vozaca
            var frm = new FormKategorija(ref _tmpListaKategorija);
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajDataGridView();
        }

        private void btnDodajZabranu_Click(object sender, EventArgs e)
        {
            var frm = new FormZabrana(ref _tmpListaZabrana, _tmpListaKategorija);
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajDataGridView();
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (dgvListaKategorija.SelectedRows.Count == 0)
                return;

            // Pitaj korisnika da potvrdi akciju brisanja
            DialogResult dlg = MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu stavku?",
                                               "Obaveštenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvListaKategorija.SelectedRows[0].Index;
            string oznakaKategorije = (string)dgvListaKategorija.Rows[selectedRow].Cells[0].Value;

            if (ObrisiKategoriju(oznakaKategorije))
            {
                // Izbrisi i zabrane vezane za tu kategoriju (ako postoje)
                ObrisiZabranu(oznakaKategorije);

                MessageBox.Show("Izabrana akcija je uspešno obavljena.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Osvezi podatke u DataGridView
                UcitajDataGridView();
            }
            else
            {
                MessageBox.Show("Izabrana akcija nije uspešno obavljena. Pokušajte ponovo.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnObrisiZabranu_Click(object sender, EventArgs e)
        {
            if (dgvListaZabrana.SelectedRows.Count == 0)
                return;

            // Pitaj korisnika da potvrdi akciju brisanja
            DialogResult dlg = MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu stavku?",
                                               "Obaveštenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvListaZabrana.SelectedRows[0].Index;
            string oznakaKategorije = (string)dgvListaKategorija.Rows[selectedRow].Cells[0].Value;

            if (ObrisiZabranu(oznakaKategorije))
            {
                MessageBox.Show("Izabrana akcija je uspešno obavljena.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Osvezi podatke u DataGridView
                UcitajDataGridView();
            }
            else
            {
                MessageBox.Show("Izabrana akcija nije uspešno obavljena. Pokušajte ponovo.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Methods

        private bool ObrisiZabranu(string oznakaKategorije)
        {
            Zabrana z = _tmpListaZabrana.Find(x => x.Kategorija == oznakaKategorije);

            if (z == null)
                return false;

            _tmpListaZabrana.Remove(z);
            return true;
        }

        private bool ObrisiKategoriju(string oznakaKategorije)
        {
            Kategorija k = _tmpListaKategorija.Find(x => x.OznakaKategorije == oznakaKategorije);

            if (k == null)
                return false;

            _tmpListaKategorija.Remove(k);
            return true;
        }

        private bool Izmeni()
        {
            Vozac v = new Vozac(txtIme.Text, txtPrezime.Text, dtpDatumRodjenja.Value, dtpDozvolaOd.Value,
                                dtpDozvolaDo.Value, txtBrojVozackeDozvole.Text, txtMestoIzdavanja.Text,
                                cbPol.SelectedItem.ToString(), pbSlika.ImageLocation,
                                _tmpListaKategorija, _tmpListaZabrana);

            return ListaVozaca.Instance.IzmeniVozaca(v);
        }

        private bool Dodaj()
        {
            Vozac v = new Vozac(txtIme.Text, txtPrezime.Text, dtpDatumRodjenja.Value, dtpDozvolaOd.Value,
                                    dtpDozvolaOd.Value, txtBrojVozackeDozvole.Text, txtMestoIzdavanja.Text,
                                    cbPol.SelectedItem.ToString(), pbSlika.ImageLocation,
                                    _tmpListaKategorija, _tmpListaZabrana);

            return ListaVozaca.Instance.DodajVozaca(v);
        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Polje Ime ne sme biti prazno.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtIme.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Polje Prezime ne sme biti prazno.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtPrezime.Focus();
                return false;
            }

            //if (dtpDozvolaOd.Value > dtpDozvolaDo.Value)
            //{
            //    MessageBox.Show("Datum važenja dozvole od ne može biti veći od datuma važenja dozvole do.",
            //                    "Obaveštenje",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Information);
            //    dtpDozvolaOd.Focus();
            //    return false;
            //}

            //if (DateTime.Now.Year - dtpDatumRodjenja.Value.Year < 18)
            //{
            //    MessageBox.Show("Vozač mora biti punoletan.",
            //                    "Obaveštenje",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Information);
            //    dtpDatumRodjenja.Focus();
            //    return false;
            //}

            if (txtBrojVozackeDozvole.Text.Length < txtBrojVozackeDozvole.MaxLength)
            {
                MessageBox.Show("Polje Br. vozačke dozvole mora sadržati 9 cifara.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtBrojVozackeDozvole.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtMestoIzdavanja.Text))
            {
                MessageBox.Show("Polje Mesto izdavanja ne sme biti prazno.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtMestoIzdavanja.Focus();
                return false;
            }

            if (cbPol.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati vrednost za polje Pol.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                cbPol.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(pbSlika.ImageLocation))
            {
                MessageBox.Show("Morate izabrati sliku.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                btnDodajSliku.Focus();
                return false;
            }

            return true;
        }

        private void UcitajPodatke()
        {
            if (Vozac != null)
                UcitajPodatkeUKontrole();

            UcitajDataGridView();
        }

        private void UcitajPodatkeUKontrole()
        {
            txtIme.Text = Vozac.Ime;
            txtPrezime.Text = Vozac.Prezime;
            dtpDatumRodjenja.Value = DateTime.Parse(Vozac.DatumRodjenja);
            dtpDozvolaOd.Value = DateTime.Parse(Vozac.VazenjeDozvoleOd);
            dtpDozvolaDo.Value = DateTime.Parse(Vozac.VazenjeDozvoleDo);
            txtBrojVozackeDozvole.Text = Vozac.BrojDozvole;
            txtMestoIzdavanja.Text = Vozac.MestoIzdavanjaDozvole;
            cbPol.SelectedItem = Vozac.Pol;
            pbSlika.ImageLocation = Vozac.PutanjaDoSlike;
            //pbSlika.Image = Image.FromFile(Vozac.PutanjaDoSlike);
        }

        private void UcitajDataGridView()
        {
            dgvListaKategorija.DataSource = _tmpListaKategorija.ToList();
            dgvListaZabrana.DataSource = _tmpListaZabrana.ToList();

            if (dgvListaKategorija.RowCount > 0)
                btnObrisiKategoriju.Enabled = true;
            else
                btnObrisiKategoriju.Enabled = false;

            if (dgvListaZabrana.RowCount > 0)
                btnObrisiZabranu.Enabled = true;
            else
                btnObrisiZabranu.Enabled = false;
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li sigurno želite da odustanete od dodavanja/izmene vozača?", "Obaveštenje",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion
    }
}
