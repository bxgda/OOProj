using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4.Podaci;  // da bi mogo da koristim klase iz Lab4.Podaci

namespace Lab4.Aplikacija
{
    public partial class FormGlavna : Form
    {
        #region Constructors

        public FormGlavna()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            // Postavi vreme i pokreni tajmer
            lblTacnoVreme.Text = string.Empty;
            tmrTacnoVreme.Start();

            // Postavi default vrednosti za ComboBox
            cmbNacinSortiranja.SelectedIndex = 0;

            // Ucitaj podatke u DataGridView
            UcitajPodatke();
        }

        private void FormGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ZatvoriFormu() == DialogResult.No)
                e.Cancel = true;
        }

        private void tmrTacnoVreme_Tick(object sender, EventArgs e)
        {
            String str = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
            lblTacnoVreme.Text = str;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // Kreiraj formu za dodavanje
            var frm = new FormVozac();
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brojDozvole = (string)dgvListaVozaca.Rows[selectedRow].Cells[2].Value;

            Vozac o = ListaVozaca.Instance.GetVozac(brojDozvole);

            // Kreiraj formu za izmenu
            var frm = new FormVozac(o);
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Ako je korisnik klinuo dugme obrisi ali nije nista selektovao samo prekini akciju
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            // Pitaj korisnika da potvrdi akciju brisanja
            DialogResult dlg = MessageBox.Show("Da li ste sigurni da želite da obrišete izabranu stavku?",
                                               "Obaveštenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brojDozvole = (string)dgvListaVozaca.Rows[selectedRow].Cells[2].Value;

            Vozac v = ListaVozaca.Instance.GetVozac(brojDozvole);

            if (ListaVozaca.Instance.ObrisiVozaca(v))
            {
                MessageBox.Show("Izabrana akcija je uspešno obavljena.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Osvezi podatke u DataGridView
                UcitajPodatke();
            }
            else
            {
                MessageBox.Show("Izabrana akcija nije uspešno obavljena. Pokušajte ponovo.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Na svaku promenu u combo box-u zakaci drugu metodu za sortiranje delegatu u ListiVozaca
        private void cmbNacinSortiranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNacinSortiranja.SelectedIndex == 0)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(SortBrVozackeDozvole);
            else if (cmbNacinSortiranja.SelectedIndex == 1)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(SortIme);
            else if (cmbNacinSortiranja.SelectedIndex == 2)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(SortPrezime);
            else if (cmbNacinSortiranja.SelectedIndex == 3)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(SortMestoIzdavanja);

            UcitajPodatke();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            ListaVozaca.Instance.SortirajListuVozaca();
            UcitajPodatke();
        }

        #endregion

        #region Methods

        private void UcitajPodatke()
        {
            dgvListaVozaca.DataSource = ListaVozaca.Instance.ListaVozacaValues.ToList();

            if (dgvListaVozaca.RowCount > 0)
            {
                btnObrisi.Enabled = true;
                btnIzmeni.Enabled = true;
            }
            else
            {
                btnObrisi.Enabled = false;
                btnIzmeni.Enabled = false;
            }
        }

        private void SortBrVozackeDozvole(List<Vozac> v)
        {
            ListaVozaca.Instance.ListaVozacaValues.Sort((v1, v2) => v1.BrojDozvole.CompareTo(v2.BrojDozvole));
        }

        private void SortIme(List<Vozac> v)
        {
            ListaVozaca.Instance.ListaVozacaValues.Sort((v1, v2) => v1.Ime.CompareTo(v2.Ime));
        }

        private void SortPrezime(List<Vozac> v)
        {
            ListaVozaca.Instance.ListaVozacaValues.Sort((v1, v2) => v1.Prezime.CompareTo(v2.Prezime));
        }

        private void SortMestoIzdavanja(List<Vozac> v)
        {
            ListaVozaca.Instance.ListaVozacaValues.Sort((v1, v2) => v1.MestoIzdavanjaDozvole.CompareTo(v2.MestoIzdavanjaDozvole));
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li sigurno želite da zatvorite aplikaciju?", "Obaveštenje",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        #endregion
    }
}
