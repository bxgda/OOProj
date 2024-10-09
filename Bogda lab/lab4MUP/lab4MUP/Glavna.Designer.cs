namespace lab4MUP
{
    partial class Glavna
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
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.cbOpcije = new System.Windows.Forms.ComboBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblTacnoVreme = new System.Windows.Forms.Label();
            this.tmrVreme = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortiraj.Location = new System.Drawing.Point(743, 15);
            this.btnSortiraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(100, 28);
            this.btnSortiraj.TabIndex = 0;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // cbOpcije
            // 
            this.cbOpcije.FormattingEnabled = true;
            this.cbOpcije.Items.AddRange(new object[] {
            "Broj vozačke dozvole",
            "Ime",
            "Prezime",
            "Mesto izdavanja"});
            this.cbOpcije.Location = new System.Drawing.Point(851, 15);
            this.cbOpcije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOpcije.Name = "cbOpcije";
            this.cbOpcije.Size = new System.Drawing.Size(199, 24);
            this.cbOpcije.TabIndex = 1;
            this.cbOpcije.SelectedIndexChanged += new System.EventHandler(this.cbOpcije_SelectedIndexChanged);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(8, 23);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(1019, 362);
            this.dgvLista.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.dgvLista);
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 489);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Vozača";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Image = global::lab4MUP.Properties.Resources.kanta2;
            this.btnObrisi.Location = new System.Drawing.Point(855, 393);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(172, 89);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši vozača";
            this.btnObrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Image = global::lab4MUP.Properties.Resources.olovka2;
            this.btnIzmeni.Location = new System.Drawing.Point(189, 394);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(172, 89);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni vozača";
            this.btnIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Image = global::lab4MUP.Properties.Resources.plus2;
            this.btnDodaj.Location = new System.Drawing.Point(8, 393);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(172, 89);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj vozača";
            this.btnDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblTacnoVreme
            // 
            this.lblTacnoVreme.AutoSize = true;
            this.lblTacnoVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacnoVreme.Location = new System.Drawing.Point(17, 7);
            this.lblTacnoVreme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacnoVreme.Name = "lblTacnoVreme";
            this.lblTacnoVreme.Size = new System.Drawing.Size(95, 36);
            this.lblTacnoVreme.TabIndex = 4;
            this.lblTacnoVreme.Text = "label1";
            // 
            // tmrVreme
            // 
            this.tmrVreme.Tick += new System.EventHandler(this.tmrVreme_Tick);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTacnoVreme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbOpcije);
            this.Controls.Add(this.btnSortiraj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Glavna_FormClosing);
            this.Load += new System.EventHandler(this.Glavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ComboBox cbOpcije;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label lblTacnoVreme;
        private System.Windows.Forms.Timer tmrVreme;
    }
}