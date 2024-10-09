namespace lab4MUP
{
    partial class FormaVozac
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.dtpRodj = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.cbPol = new System.Windows.Forms.ComboBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisiKat = new System.Windows.Forms.Button();
            this.btnDodajKat = new System.Windows.Forms.Button();
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnObrisiZabr = new System.Windows.Forms.Button();
            this.btnDodajZabr = new System.Windows.Forms.Button();
            this.dgvZabrane = new System.Windows.Forms.DataGridView();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.Odustani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrane)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(260, 23);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(267, 22);
            this.tbIme.TabIndex = 0;
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetic_KeyPress);
            this.tbIme.Leave += new System.EventHandler(this.alphabetic_Leave);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(260, 57);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(267, 22);
            this.tbPrezime.TabIndex = 1;
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetic_KeyPress);
            this.tbPrezime.Leave += new System.EventHandler(this.alphabetic_Leave);
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(260, 186);
            this.tbBroj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBroj.MaxLength = 9;
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(267, 22);
            this.tbBroj.TabIndex = 2;
            this.tbBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBroj_KeyPress);
            // 
            // dtpRodj
            // 
            this.dtpRodj.Location = new System.Drawing.Point(260, 90);
            this.dtpRodj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRodj.Name = "dtpRodj";
            this.dtpRodj.Size = new System.Drawing.Size(267, 22);
            this.dtpRodj.TabIndex = 3;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(260, 122);
            this.dtpOd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(267, 22);
            this.dtpOd.TabIndex = 4;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(260, 154);
            this.dtpDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(267, 22);
            this.dtpDo.TabIndex = 5;
            // 
            // tbMesto
            // 
            this.tbMesto.Location = new System.Drawing.Point(260, 218);
            this.tbMesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.Size = new System.Drawing.Size(267, 22);
            this.tbMesto.TabIndex = 6;
            this.tbMesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetic_KeyPress);
            this.tbMesto.Leave += new System.EventHandler(this.alphabetic_Leave);
            // 
            // cbPol
            // 
            this.cbPol.FormattingEnabled = true;
            this.cbPol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cbPol.Location = new System.Drawing.Point(260, 251);
            this.cbPol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(267, 24);
            this.cbPol.TabIndex = 7;
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(561, 251);
            this.btnSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(247, 28);
            this.btnSlika.TabIndex = 9;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.btnSlika);
            this.groupBox1.Controls.Add(this.tbPrezime);
            this.groupBox1.Controls.Add(this.pbSlika);
            this.groupBox1.Controls.Add(this.tbBroj);
            this.groupBox1.Controls.Add(this.cbPol);
            this.groupBox1.Controls.Add(this.dtpRodj);
            this.groupBox1.Controls.Add(this.tbMesto);
            this.groupBox1.Controls.Add(this.dtpOd);
            this.groupBox1.Controls.Add(this.dtpDo);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(820, 297);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mesto izdavanja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Broj dozvole:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Važi do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Važi od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Datum rođenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ime:";
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(561, 23);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(247, 187);
            this.pbSlika.TabIndex = 8;
            this.pbSlika.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiKat);
            this.groupBox2.Controls.Add(this.btnDodajKat);
            this.groupBox2.Controls.Add(this.dgvKategorije);
            this.groupBox2.Location = new System.Drawing.Point(16, 319);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(820, 207);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategorije";
            // 
            // btnObrisiKat
            // 
            this.btnObrisiKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKat.Image = global::lab4MUP.Properties.Resources.kanta2;
            this.btnObrisiKat.Location = new System.Drawing.Point(636, 125);
            this.btnObrisiKat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiKat.Name = "btnObrisiKat";
            this.btnObrisiKat.Size = new System.Drawing.Size(172, 74);
            this.btnObrisiKat.TabIndex = 7;
            this.btnObrisiKat.Text = "Obriši kategoriju";
            this.btnObrisiKat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiKat.UseVisualStyleBackColor = true;
            this.btnObrisiKat.Click += new System.EventHandler(this.btnObrisiKat_Click);
            // 
            // btnDodajKat
            // 
            this.btnDodajKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKat.Image = global::lab4MUP.Properties.Resources.plus2;
            this.btnDodajKat.Location = new System.Drawing.Point(9, 125);
            this.btnDodajKat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajKat.Name = "btnDodajKat";
            this.btnDodajKat.Size = new System.Drawing.Size(172, 74);
            this.btnDodajKat.TabIndex = 5;
            this.btnDodajKat.Text = "Dodaj kategoriju";
            this.btnDodajKat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajKat.UseVisualStyleBackColor = true;
            this.btnDodajKat.Click += new System.EventHandler(this.btnDodajKat_Click);
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Location = new System.Drawing.Point(9, 25);
            this.dgvKategorije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.RowHeadersWidth = 51;
            this.dgvKategorije.Size = new System.Drawing.Size(803, 92);
            this.dgvKategorije.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnObrisiZabr);
            this.groupBox3.Controls.Add(this.btnDodajZabr);
            this.groupBox3.Controls.Add(this.dgvZabrane);
            this.groupBox3.Location = new System.Drawing.Point(16, 534);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(820, 319);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zabrane";
            // 
            // btnObrisiZabr
            // 
            this.btnObrisiZabr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZabr.Image = global::lab4MUP.Properties.Resources.kanta2;
            this.btnObrisiZabr.Location = new System.Drawing.Point(640, 236);
            this.btnObrisiZabr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiZabr.Name = "btnObrisiZabr";
            this.btnObrisiZabr.Size = new System.Drawing.Size(172, 74);
            this.btnObrisiZabr.TabIndex = 8;
            this.btnObrisiZabr.Text = "Obriši zabranu";
            this.btnObrisiZabr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiZabr.UseVisualStyleBackColor = true;
            this.btnObrisiZabr.Click += new System.EventHandler(this.btnObrisiZabr_Click);
            // 
            // btnDodajZabr
            // 
            this.btnDodajZabr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZabr.Image = global::lab4MUP.Properties.Resources.plus2;
            this.btnDodajZabr.Location = new System.Drawing.Point(8, 236);
            this.btnDodajZabr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajZabr.Name = "btnDodajZabr";
            this.btnDodajZabr.Size = new System.Drawing.Size(172, 74);
            this.btnDodajZabr.TabIndex = 6;
            this.btnDodajZabr.Text = "Dodaj zabranu";
            this.btnDodajZabr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajZabr.UseVisualStyleBackColor = true;
            this.btnDodajZabr.Click += new System.EventHandler(this.btnDodajZabr_Click);
            // 
            // dgvZabrane
            // 
            this.dgvZabrane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabrane.Location = new System.Drawing.Point(8, 23);
            this.dgvZabrane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvZabrane.Name = "dgvZabrane";
            this.dgvZabrane.RowHeadersWidth = 51;
            this.dgvZabrane.Size = new System.Drawing.Size(803, 206);
            this.dgvZabrane.TabIndex = 1;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(218, 861);
            this.btnProsledi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(155, 31);
            this.btnProsledi.TabIndex = 13;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // Odustani
            // 
            this.Odustani.Location = new System.Drawing.Point(430, 861);
            this.Odustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Odustani.Name = "Odustani";
            this.Odustani.Size = new System.Drawing.Size(155, 31);
            this.Odustani.TabIndex = 14;
            this.Odustani.Text = "Odustani";
            this.Odustani.UseVisualStyleBackColor = true;
            this.Odustani.Click += new System.EventHandler(this.Odustani_Click);
            // 
            // FormaVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 918);
            this.Controls.Add(this.Odustani);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormaVozac";
            this.Text = "FormaVozac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaVozac_FormClosing);
            this.Load += new System.EventHandler(this.FormaVozac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.DateTimePicker dtpRodj;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.ComboBox cbPol;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.Button btnDodajKat;
        private System.Windows.Forms.Button btnObrisiKat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnObrisiZabr;
        private System.Windows.Forms.Button btnDodajZabr;
        private System.Windows.Forms.DataGridView dgvZabrane;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button Odustani;
    }
}