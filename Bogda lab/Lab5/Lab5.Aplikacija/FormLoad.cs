using Lab5.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Aplikacija
{
    public partial class FormLoad : Form
    {
        private bool fleg = false;
        public FormLoad()
        {
            InitializeComponent();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("../../../Podaci/Sacuvane_Igre/");

            lbxLista.Items.Clear();
            lbxLista.Items.AddRange(files.Select(Path.GetFileName).ToArray());
        }

        private void lbxLista_DoubleClick(object sender, EventArgs e)
        {
            if (lbxLista.SelectedIndex == -1)
                return;

            string file = "../../../Podaci/Sacuvane_Igre/" + lbxLista.SelectedItem.ToString();

            StanjeIgre.Load(file);
            fleg = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormLoad_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
