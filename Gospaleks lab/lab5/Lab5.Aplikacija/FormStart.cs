using Lab5.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Aplikacija
{
    public partial class FormStart : Form
    {
        #region Konstruktori

        public FormStart()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Ugasi trenutnu formu a pokreni FormGame
            this.Hide();
            var frm = new FormGame();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
                this.Show();
            else
                this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frm = new FormSettings();
            frm.ShowDialog();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            var frm = new FormLoad();
            frm.ShowDialog();

            // Ako je izadjeno iz forme dvoklikom na neki save game
            if (frm.DialogResult == DialogResult.OK)
            {
                this.Hide();

                var stanje = StanjeIgre.Instance;
                FormGame frm1;
                if (stanje.RedPrvoKliknuto == -1)
                    frm1 = new FormGame(new Polje(-1, -1), stanje.Kliknuto, stanje.BrojSekundi);
                else
                    frm1 = new FormGame(stanje[stanje.RedPrvoKliknuto, stanje.KolonaPrvoKliknuto], stanje.Kliknuto, stanje.BrojSekundi);

                frm1.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                    this.Show();
                else
                    this.Close();
            }

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            // Ucitaj globalna podesavanja iz xml-a koji je ostao prethodno sacuvan
            Lab5.Settings.Settings.Load("../../../Podaci/Settings.xml");
            var settings = Lab5.Settings.Settings.Instance;
        }

        #endregion
    }
}
