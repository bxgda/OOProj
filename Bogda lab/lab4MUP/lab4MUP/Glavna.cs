using Podaci;
using System;
using System.Collections;
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
    public partial class Glavna : Form
    {
        #region Konstruktori

        public Glavna()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void Glavna_Load(object sender, EventArgs e)
        {
            lblTacnoVreme.Text = string.Empty;
            tmrVreme.Start();
            cbOpcije.SelectedIndex = 0;
            UcitajListu();
        }

        private void tmrVreme_Tick(object sender, EventArgs e)
        {
            lblTacnoVreme.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
        }


        private void Glavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Zatvori() == DialogResult.No)
                e.Cancel = true;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var forma = new FormaVozac();
            DialogResult dlg = forma.ShowDialog();
            if(dlg == DialogResult.OK)
                UcitajListu();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 0)
                return;
            int selectedIndex = dgvLista.SelectedRows[0].Index;
            Vozac v = ListaVozaca.Instanca.VratiVozaca((string)dgvLista.Rows[selectedIndex].Cells[2].Value);
            var forma = new FormaVozac(v);
            DialogResult dlg = forma.ShowDialog();
            if(dlg == DialogResult.OK)
                UcitajListu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(dgvLista.SelectedRows.Count == 0)
                return;
            DialogResult dlg = MessageBox.Show("Da li ste sigurni da želite da obrišete vozača?", "Obaveštenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
                return;
            int selectedIndex = dgvLista.SelectedRows[0].Index;
            Vozac v = ListaVozaca.Instanca.VratiVozaca((string)dgvLista.Rows[selectedIndex].Cells[2].Value);
            if (ListaVozaca.Instanca.Obrisi(v))
            {
                MessageBox.Show("Uspešno ste obrisali vozača", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajListu();
            }
            else
                MessageBox.Show(Text = "Došlo je do greške prilikom brisanja vozača", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbOpcije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcije.SelectedIndex == 0)
                ListaVozaca.Instanca.Sortiranje = new ListaVozaca.SortDelegate(SortirajBrojDozovle);
            else if (cbOpcije.SelectedIndex == 1)
                ListaVozaca.Instanca.Sortiranje = new ListaVozaca.SortDelegate(SortirajIme);
            else if (cbOpcije.SelectedIndex == 2)
                ListaVozaca.Instanca.Sortiranje = new ListaVozaca.SortDelegate(SortirajPrezime);
            else if (cbOpcije.SelectedIndex == 3)
                ListaVozaca.Instanca.Sortiranje = new ListaVozaca.SortDelegate(SortirajMesto);
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            ListaVozaca.Instanca.Sortiraj();
            UcitajListu();
        }

        #endregion

        #region Metode

        private void SortirajBrojDozovle(List<Vozac> l)
        {
            ListaVozaca.Instanca.Lista.Sort((x, y) => x.BrojDozvole.CompareTo(y.BrojDozvole));
        }

        private void SortirajIme(List<Vozac> l)
        {
            ListaVozaca.Instanca.Lista.Sort((x, y) => x.Ime.CompareTo(y.Ime));
        }

        private void SortirajPrezime(List<Vozac> l)
        {
            ListaVozaca.Instanca.Lista.Sort((x, y) => x.Prezime.CompareTo(y.Prezime));
        }

        private void SortirajMesto(List<Vozac> l)
        {
            ListaVozaca.Instanca.Lista.Sort((x, y) => x.MestoIzdavanja.CompareTo(y.MestoIzdavanja));
        }

        private DialogResult Zatvori()
        {
            return MessageBox.Show("Da li sigurno želite da zatvorite aplikaciju?", "Obaveštenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void UcitajListu()
        {
            dgvLista.DataSource = ListaVozaca.Instanca.Lista.ToList();
            if(dgvLista.Rows.Count > 0)
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

        #endregion
    }
}
