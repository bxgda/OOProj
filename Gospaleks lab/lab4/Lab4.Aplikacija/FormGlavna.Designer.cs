namespace Lab4.Aplikacija
{
    partial class FormGlavna
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
            this.components = new System.ComponentModel.Container();
            this.gbListaVozaca = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvListaVozaca = new System.Windows.Forms.DataGridView();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.cmbNacinSortiranja = new System.Windows.Forms.ComboBox();
            this.lblTacnoVreme = new System.Windows.Forms.Label();
            this.tmrTacnoVreme = new System.Windows.Forms.Timer(this.components);
            this.gbListaVozaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListaVozaca
            // 
            this.gbListaVozaca.Controls.Add(this.btnObrisi);
            this.gbListaVozaca.Controls.Add(this.btnIzmeni);
            this.gbListaVozaca.Controls.Add(this.btnDodaj);
            this.gbListaVozaca.Controls.Add(this.dgvListaVozaca);
            this.gbListaVozaca.Location = new System.Drawing.Point(16, 46);
            this.gbListaVozaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbListaVozaca.Name = "gbListaVozaca";
            this.gbListaVozaca.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbListaVozaca.Size = new System.Drawing.Size(803, 437);
            this.gbListaVozaca.TabIndex = 0;
            this.gbListaVozaca.TabStop = false;
            this.gbListaVozaca.Text = "Lista vozača";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnObrisi.Image = global::Lab4.Aplikacija.Properties.Resources.Metla;
            this.btnObrisi.Location = new System.Drawing.Point(665, 362);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(129, 68);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši vozača";
            this.btnObrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnIzmeni.Image = global::Lab4.Aplikacija.Properties.Resources.edit;
            this.btnIzmeni.Location = new System.Drawing.Point(145, 362);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(129, 68);
            this.btnIzmeni.TabIndex = 1;
            this.btnIzmeni.Text = "Izmeni vozača";
            this.btnIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnDodaj.Image = global::Lab4.Aplikacija.Properties.Resources.add;
            this.btnDodaj.Location = new System.Drawing.Point(8, 362);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(129, 68);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj vozača";
            this.btnDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvListaVozaca
            // 
            this.dgvListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVozaca.Location = new System.Drawing.Point(8, 23);
            this.dgvListaVozaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaVozaca.Name = "dgvListaVozaca";
            this.dgvListaVozaca.RowHeadersWidth = 51;
            this.dgvListaVozaca.Size = new System.Drawing.Size(787, 331);
            this.dgvListaVozaca.TabIndex = 3;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(515, 15);
            this.btnSortiraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(100, 28);
            this.btnSortiraj.TabIndex = 1;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // cmbNacinSortiranja
            // 
            this.cmbNacinSortiranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacinSortiranja.FormattingEnabled = true;
            this.cmbNacinSortiranja.Items.AddRange(new object[] {
            "Broj vozačke dozvole",
            "Ime",
            "Prezime",
            "Mesto izdavanja dozvole"});
            this.cmbNacinSortiranja.Location = new System.Drawing.Point(623, 16);
            this.cmbNacinSortiranja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNacinSortiranja.Name = "cmbNacinSortiranja";
            this.cmbNacinSortiranja.Size = new System.Drawing.Size(195, 24);
            this.cmbNacinSortiranja.TabIndex = 2;
            this.cmbNacinSortiranja.SelectedIndexChanged += new System.EventHandler(this.cmbNacinSortiranja_SelectedIndexChanged);
            // 
            // lblTacnoVreme
            // 
            this.lblTacnoVreme.AutoSize = true;
            this.lblTacnoVreme.Font = new System.Drawing.Font("Consolas", 14F);
            this.lblTacnoVreme.Location = new System.Drawing.Point(11, 14);
            this.lblTacnoVreme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacnoVreme.Name = "lblTacnoVreme";
            this.lblTacnoVreme.Size = new System.Drawing.Size(272, 28);
            this.lblTacnoVreme.TabIndex = 3;
            this.lblTacnoVreme.Text = "HH:mm:ss dd.MM.yyyy.";
            // 
            // tmrTacnoVreme
            // 
            this.tmrTacnoVreme.Tick += new System.EventHandler(this.tmrTacnoVreme_Tick);
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(832, 487);
            this.Controls.Add(this.lblTacnoVreme);
            this.Controls.Add(this.cmbNacinSortiranja);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.gbListaVozaca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 534);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 534);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista vozača";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGlavna_FormClosing);
            this.Load += new System.EventHandler(this.FormGlavna_Load);
            this.gbListaVozaca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaVozaca;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ComboBox cmbNacinSortiranja;
        private System.Windows.Forms.Label lblTacnoVreme;
        private System.Windows.Forms.DataGridView dgvListaVozaca;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Timer tmrTacnoVreme;
    }
}

