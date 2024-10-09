using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab5.Aplikacija
{
    public partial class FormSettings : Form
    {
        #region Atributi

        private bool ok = false;

        #endregion

        #region Konstruktori

        public FormSettings()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Sacuvaj u xml
            Settings.Settings.Instance.BrojRedova = (int)nudBrojRedova.Value;
            Settings.Settings.Instance.BrojKolona = (int)nudBrojKolona.Value;
            Settings.Settings.Instance.BrojParova = (int)nudBrojParova.Value;
            Settings.Settings.Instance.BrojSlika = (int)nudBrojSlika.Value;

            if (Validaraj())
            {
                Settings.Settings.Instance.Save("../../../Podaci/Settings.xml");
                this.Close();
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            nudBrojRedova.Value = 6;
            nudBrojKolona.Value = 5;
            nudBrojParova.Value = nudBrojParova.Minimum;
            nudBrojSlika.Value = nudBrojSlika.Minimum;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            var settings = Lab5.Settings.Settings.Instance;

            // Popuni formu sa ucitanim podesavanjima
            nudBrojRedova.Value = settings.BrojRedova;
            nudBrojKolona.Value = settings.BrojKolona;
            nudBrojParova.Value = settings.BrojParova;
            nudBrojSlika.Value = settings.BrojSlika;
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ok && ZatvoriFormu() == DialogResult.No)
                e.Cancel = true;
        }

        private bool Validaraj()
        {
            if (2 * nudBrojParova.Value > nudBrojRedova.Value * nudBrojKolona.Value)
            {
                MessageBox.Show("Imate više parova nego polja.", "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                nudBrojParova.Focus();
                return false;
            }

            string[] files = Directory.GetFiles("../../../Podaci/Slike/");

            int brojFajlova = files.Length - 1;

            // Provera broja fajlova u folderu
            if (brojFajlova < nudBrojSlika.Value)
            {
                MessageBox.Show("U folderu \"Slike\" nema dovoljan broj slika.", "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                nudBrojSlika.Focus();
                return false;
            }

            return true;
        }

        private DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Niste sačuvali podešavanja, da li sigurno želite da zatvorite formu?",
                                   "Upozorenje!",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning);
        }

        #endregion
    }
}
