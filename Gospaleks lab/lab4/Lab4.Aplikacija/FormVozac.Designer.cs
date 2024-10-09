namespace Lab4.Aplikacija
{
    partial class FormVozac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOsnovniPodaci = new System.Windows.Forms.GroupBox();
            this.cbPol = new System.Windows.Forms.ComboBox();
            this.lblPol = new System.Windows.Forms.Label();
            this.txtMestoIzdavanja = new System.Windows.Forms.TextBox();
            this.lblMestoIzdavanja = new System.Windows.Forms.Label();
            this.txtBrojVozackeDozvole = new System.Windows.Forms.TextBox();
            this.lblBrojVozackeDozvole = new System.Windows.Forms.Label();
            this.dtpDozvolaDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDozvolaOd = new System.Windows.Forms.DateTimePicker();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.lblDozvolaDo = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.lblDozvolaOd = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbKategorije = new System.Windows.Forms.GroupBox();
            this.dgvListaKategorija = new System.Windows.Forms.DataGridView();
            this.gbZabrane = new System.Windows.Forms.GroupBox();
            this.dgvListaZabrana = new System.Windows.Forms.DataGridView();
            this.btnObrisiZabranu = new System.Windows.Forms.Button();
            this.btnDodajZabranu = new System.Windows.Forms.Button();
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.gbOsnovniPodaci.SuspendLayout();
            this.gbKategorije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKategorija)).BeginInit();
            this.gbZabrane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaZabrana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOsnovniPodaci
            // 
            this.gbOsnovniPodaci.Controls.Add(this.cbPol);
            this.gbOsnovniPodaci.Controls.Add(this.lblPol);
            this.gbOsnovniPodaci.Controls.Add(this.txtMestoIzdavanja);
            this.gbOsnovniPodaci.Controls.Add(this.lblMestoIzdavanja);
            this.gbOsnovniPodaci.Controls.Add(this.txtBrojVozackeDozvole);
            this.gbOsnovniPodaci.Controls.Add(this.lblBrojVozackeDozvole);
            this.gbOsnovniPodaci.Controls.Add(this.dtpDozvolaDo);
            this.gbOsnovniPodaci.Controls.Add(this.dtpDozvolaOd);
            this.gbOsnovniPodaci.Controls.Add(this.btnDodajSliku);
            this.gbOsnovniPodaci.Controls.Add(this.pbSlika);
            this.gbOsnovniPodaci.Controls.Add(this.lblDozvolaDo);
            this.gbOsnovniPodaci.Controls.Add(this.dtpDatumRodjenja);
            this.gbOsnovniPodaci.Controls.Add(this.lblDozvolaOd);
            this.gbOsnovniPodaci.Controls.Add(this.lblDatumRodjenja);
            this.gbOsnovniPodaci.Controls.Add(this.txtPrezime);
            this.gbOsnovniPodaci.Controls.Add(this.lblPrezime);
            this.gbOsnovniPodaci.Controls.Add(this.txtIme);
            this.gbOsnovniPodaci.Controls.Add(this.lblIme);
            this.gbOsnovniPodaci.Location = new System.Drawing.Point(12, 12);
            this.gbOsnovniPodaci.Name = "gbOsnovniPodaci";
            this.gbOsnovniPodaci.Size = new System.Drawing.Size(444, 256);
            this.gbOsnovniPodaci.TabIndex = 0;
            this.gbOsnovniPodaci.TabStop = false;
            this.gbOsnovniPodaci.Text = "Osnovni podaci";
            // 
            // cbPol
            // 
            this.cbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPol.FormattingEnabled = true;
            this.cbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cbPol.Location = new System.Drawing.Point(142, 213);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(135, 21);
            this.cbPol.TabIndex = 7;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(100, 216);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(25, 13);
            this.lblPol.TabIndex = 17;
            this.lblPol.Text = "Pol:";
            // 
            // txtMestoIzdavanja
            // 
            this.txtMestoIzdavanja.Location = new System.Drawing.Point(142, 186);
            this.txtMestoIzdavanja.Name = "txtMestoIzdavanja";
            this.txtMestoIzdavanja.Size = new System.Drawing.Size(135, 20);
            this.txtMestoIzdavanja.TabIndex = 6;
            this.txtMestoIzdavanja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetic_KeyPress);
            this.txtMestoIzdavanja.Leave += new System.EventHandler(this.alphabetic_Leave);
            // 
            // lblMestoIzdavanja
            // 
            this.lblMestoIzdavanja.AutoSize = true;
            this.lblMestoIzdavanja.Location = new System.Drawing.Point(40, 189);
            this.lblMestoIzdavanja.Name = "lblMestoIzdavanja";
            this.lblMestoIzdavanja.Size = new System.Drawing.Size(87, 13);
            this.lblMestoIzdavanja.TabIndex = 15;
            this.lblMestoIzdavanja.Text = "Mesto izdavanja:";
            // 
            // txtBrojVozackeDozvole
            // 
            this.txtBrojVozackeDozvole.Location = new System.Drawing.Point(142, 160);
            this.txtBrojVozackeDozvole.MaxLength = 9;
            this.txtBrojVozackeDozvole.Name = "txtBrojVozackeDozvole";
            this.txtBrojVozackeDozvole.Size = new System.Drawing.Size(135, 20);
            this.txtBrojVozackeDozvole.TabIndex = 5;
            this.txtBrojVozackeDozvole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojVozackeDozvole_KeyPress);
            // 
            // lblBrojVozackeDozvole
            // 
            this.lblBrojVozackeDozvole.AutoSize = true;
            this.lblBrojVozackeDozvole.Location = new System.Drawing.Point(20, 163);
            this.lblBrojVozackeDozvole.Name = "lblBrojVozackeDozvole";
            this.lblBrojVozackeDozvole.Size = new System.Drawing.Size(107, 13);
            this.lblBrojVozackeDozvole.TabIndex = 13;
            this.lblBrojVozackeDozvole.Text = "Br. vozačke dozvole:";
            // 
            // dtpDozvolaDo
            // 
            this.dtpDozvolaDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDozvolaDo.Location = new System.Drawing.Point(142, 134);
            this.dtpDozvolaDo.Name = "dtpDozvolaDo";
            this.dtpDozvolaDo.Size = new System.Drawing.Size(135, 20);
            this.dtpDozvolaDo.TabIndex = 4;
            // 
            // dtpDozvolaOd
            // 
            this.dtpDozvolaOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDozvolaOd.Location = new System.Drawing.Point(142, 108);
            this.dtpDozvolaOd.Name = "dtpDozvolaOd";
            this.dtpDozvolaOd.Size = new System.Drawing.Size(135, 20);
            this.dtpDozvolaOd.TabIndex = 3;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(325, 148);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 8;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // lblDozvolaDo
            // 
            this.lblDozvolaDo.AutoSize = true;
            this.lblDozvolaDo.Location = new System.Drawing.Point(105, 137);
            this.lblDozvolaDo.Name = "lblDozvolaDo";
            this.lblDozvolaDo.Size = new System.Drawing.Size(22, 13);
            this.lblDozvolaDo.TabIndex = 8;
            this.lblDozvolaDo.Text = "do:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(142, 74);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(135, 20);
            this.dtpDatumRodjenja.TabIndex = 2;
            // 
            // lblDozvolaOd
            // 
            this.lblDozvolaOd.AutoSize = true;
            this.lblDozvolaOd.Location = new System.Drawing.Point(24, 112);
            this.lblDozvolaOd.Name = "lblDozvolaOd";
            this.lblDozvolaOd.Size = new System.Drawing.Size(103, 13);
            this.lblDozvolaOd.TabIndex = 6;
            this.lblDozvolaOd.Text = "Važenje dozvole od:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(46, 80);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(81, 13);
            this.lblDatumRodjenja.TabIndex = 4;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(142, 48);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(135, 20);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetic_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.alphabetic_Leave);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(80, 51);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(142, 22);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(135, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetic_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.alphabetic_Leave);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(100, 25);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(144, 684);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 3;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(251, 684);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // gbKategorije
            // 
            this.gbKategorije.Controls.Add(this.btnObrisiKategoriju);
            this.gbKategorije.Controls.Add(this.btnDodajKategoriju);
            this.gbKategorije.Controls.Add(this.dgvListaKategorija);
            this.gbKategorije.Location = new System.Drawing.Point(12, 274);
            this.gbKategorije.Name = "gbKategorije";
            this.gbKategorije.Size = new System.Drawing.Size(444, 193);
            this.gbKategorije.TabIndex = 1;
            this.gbKategorije.TabStop = false;
            this.gbKategorije.Text = "Kategorije";
            // 
            // dgvListaKategorija
            // 
            this.dgvListaKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKategorija.Location = new System.Drawing.Point(6, 19);
            this.dgvListaKategorija.Name = "dgvListaKategorija";
            this.dgvListaKategorija.Size = new System.Drawing.Size(432, 121);
            this.dgvListaKategorija.TabIndex = 2;
            // 
            // gbZabrane
            // 
            this.gbZabrane.Controls.Add(this.btnObrisiZabranu);
            this.gbZabrane.Controls.Add(this.btnDodajZabranu);
            this.gbZabrane.Controls.Add(this.dgvListaZabrana);
            this.gbZabrane.Location = new System.Drawing.Point(14, 471);
            this.gbZabrane.Name = "gbZabrane";
            this.gbZabrane.Size = new System.Drawing.Size(444, 193);
            this.gbZabrane.TabIndex = 2;
            this.gbZabrane.TabStop = false;
            this.gbZabrane.Text = "Zabrane upravljanja";
            // 
            // dgvListaZabrana
            // 
            this.dgvListaZabrana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaZabrana.Location = new System.Drawing.Point(6, 19);
            this.dgvListaZabrana.Name = "dgvListaZabrana";
            this.dgvListaZabrana.Size = new System.Drawing.Size(432, 121);
            this.dgvListaZabrana.TabIndex = 2;
            // 
            // btnObrisiZabranu
            // 
            this.btnObrisiZabranu.Image = global::Lab4.Aplikacija.Properties.Resources.Metla;
            this.btnObrisiZabranu.Location = new System.Drawing.Point(335, 146);
            this.btnObrisiZabranu.Name = "btnObrisiZabranu";
            this.btnObrisiZabranu.Size = new System.Drawing.Size(103, 41);
            this.btnObrisiZabranu.TabIndex = 1;
            this.btnObrisiZabranu.Text = "Obriši zabranu";
            this.btnObrisiZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiZabranu.UseVisualStyleBackColor = true;
            this.btnObrisiZabranu.Click += new System.EventHandler(this.btnObrisiZabranu_Click);
            // 
            // btnDodajZabranu
            // 
            this.btnDodajZabranu.Image = global::Lab4.Aplikacija.Properties.Resources.add;
            this.btnDodajZabranu.Location = new System.Drawing.Point(6, 146);
            this.btnDodajZabranu.Name = "btnDodajZabranu";
            this.btnDodajZabranu.Size = new System.Drawing.Size(146, 41);
            this.btnDodajZabranu.TabIndex = 0;
            this.btnDodajZabranu.Text = "Dodaj novu zabranu";
            this.btnDodajZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajZabranu.UseVisualStyleBackColor = true;
            this.btnDodajZabranu.Click += new System.EventHandler(this.btnDodajZabranu_Click);
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.Image = global::Lab4.Aplikacija.Properties.Resources.Metla;
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(335, 146);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(103, 41);
            this.btnObrisiKategoriju.TabIndex = 1;
            this.btnObrisiKategoriju.Text = "Obriši kategoriju";
            this.btnObrisiKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisiKategoriju.Click += new System.EventHandler(this.btnObrisiKategoriju_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Image = global::Lab4.Aplikacija.Properties.Resources.add;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(6, 146);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(121, 41);
            this.btnDodajKategoriju.TabIndex = 0;
            this.btnDodajKategoriju.Text = "Dodaj novu kategoriju";
            this.btnDodajKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.InitialImage = global::Lab4.Aplikacija.Properties.Resources.profilna;
            this.pbSlika.Location = new System.Drawing.Point(303, 22);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(120, 120);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 9;
            this.pbSlika.TabStop = false;
            // 
            // FormVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 721);
            this.Controls.Add(this.gbZabrane);
            this.Controls.Add(this.gbKategorije);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.gbOsnovniPodaci);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 760);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(485, 760);
            this.Name = "FormVozac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozač";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVozac_FormClosing);
            this.Load += new System.EventHandler(this.FormVozac_Load);
            this.gbOsnovniPodaci.ResumeLayout(false);
            this.gbOsnovniPodaci.PerformLayout();
            this.gbKategorije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKategorija)).EndInit();
            this.gbZabrane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaZabrana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOsnovniPodaci;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label lblDozvolaOd;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblDozvolaDo;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.GroupBox gbKategorije;
        private System.Windows.Forms.DataGridView dgvListaKategorija;
        private System.Windows.Forms.Label lblBrojVozackeDozvole;
        private System.Windows.Forms.DateTimePicker dtpDozvolaDo;
        private System.Windows.Forms.DateTimePicker dtpDozvolaOd;
        private System.Windows.Forms.ComboBox cbPol;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.TextBox txtMestoIzdavanja;
        private System.Windows.Forms.Label lblMestoIzdavanja;
        private System.Windows.Forms.TextBox txtBrojVozackeDozvole;
        private System.Windows.Forms.Button btnObrisiKategoriju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.GroupBox gbZabrane;
        private System.Windows.Forms.Button btnObrisiZabranu;
        private System.Windows.Forms.Button btnDodajZabranu;
        private System.Windows.Forms.DataGridView dgvListaZabrana;
    }
}