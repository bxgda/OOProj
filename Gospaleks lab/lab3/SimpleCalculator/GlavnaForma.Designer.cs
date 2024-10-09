namespace SimpleCalculator
{
    partial class GlavnaForma
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
            this.ekran = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDeljenje = new System.Windows.Forms.Button();
            this.btnDatum = new System.Windows.Forms.Button();
            this.btnMnozenje = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnJednako = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnZnak = new System.Windows.Forms.Button();
            this.btnTacka = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnOtvorena = new System.Windows.Forms.Button();
            this.btnZatvorena = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekran
            // 
            this.ekran.BackColor = System.Drawing.SystemColors.Info;
            this.ekran.Enabled = false;
            this.ekran.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekran.Location = new System.Drawing.Point(12, 12);
            this.ekran.Name = "ekran";
            this.ekran.Size = new System.Drawing.Size(476, 42);
            this.ekran.TabIndex = 0;
            this.ekran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ekran.TextChanged += new System.EventHandler(this.ekran_TextChanged);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Blue;
            this.btn7.Location = new System.Drawing.Point(12, 64);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btnDeljenje
            // 
            this.btnDeljenje.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeljenje.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeljenje.Location = new System.Drawing.Point(240, 64);
            this.btnDeljenje.Name = "btnDeljenje";
            this.btnDeljenje.Size = new System.Drawing.Size(70, 70);
            this.btnDeljenje.TabIndex = 12;
            this.btnDeljenje.Text = "/";
            this.btnDeljenje.UseVisualStyleBackColor = true;
            this.btnDeljenje.Click += new System.EventHandler(this.operacija_Click);
            // 
            // btnDatum
            // 
            this.btnDatum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDatum.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatum.ForeColor = System.Drawing.Color.Blue;
            this.btnDatum.Location = new System.Drawing.Point(404, 140);
            this.btnDatum.Name = "btnDatum";
            this.btnDatum.Size = new System.Drawing.Size(84, 70);
            this.btnDatum.TabIndex = 18;
            this.btnDatum.Text = "Date";
            this.btnDatum.UseVisualStyleBackColor = false;
            this.btnDatum.Click += new System.EventHandler(this.btnDatum_Click);
            // 
            // btnMnozenje
            // 
            this.btnMnozenje.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMnozenje.ForeColor = System.Drawing.Color.Crimson;
            this.btnMnozenje.Location = new System.Drawing.Point(240, 140);
            this.btnMnozenje.Name = "btnMnozenje";
            this.btnMnozenje.Size = new System.Drawing.Size(70, 70);
            this.btnMnozenje.TabIndex = 13;
            this.btnMnozenje.Text = "*";
            this.btnMnozenje.UseVisualStyleBackColor = true;
            this.btnMnozenje.Click += new System.EventHandler(this.operacija_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Crimson;
            this.btnMinus.Location = new System.Drawing.Point(240, 216);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 70);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.operacija_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Crimson;
            this.btnPlus.Location = new System.Drawing.Point(240, 292);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(70, 70);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.operacija_Click);
            // 
            // btnJednako
            // 
            this.btnJednako.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJednako.ForeColor = System.Drawing.Color.Crimson;
            this.btnJednako.Location = new System.Drawing.Point(316, 292);
            this.btnJednako.Name = "btnJednako";
            this.btnJednako.Size = new System.Drawing.Size(172, 70);
            this.btnJednako.TabIndex = 17;
            this.btnJednako.Text = "=";
            this.btnJednako.UseVisualStyleBackColor = true;
            this.btnJednako.Click += new System.EventHandler(this.btnJednako_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZatvori.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.ForeColor = System.Drawing.Color.Crimson;
            this.btnZatvori.Location = new System.Drawing.Point(404, 216);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(84, 70);
            this.btnZatvori.TabIndex = 19;
            this.btnZatvori.Text = "Exit";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Crimson;
            this.btnClear.Location = new System.Drawing.Point(316, 64);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 70);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Blue;
            this.btn9.Location = new System.Drawing.Point(164, 64);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Blue;
            this.btn8.Location = new System.Drawing.Point(88, 64);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btnZnak
            // 
            this.btnZnak.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZnak.ForeColor = System.Drawing.Color.Blue;
            this.btnZnak.Location = new System.Drawing.Point(164, 292);
            this.btnZnak.Name = "btnZnak";
            this.btnZnak.Size = new System.Drawing.Size(70, 70);
            this.btnZnak.TabIndex = 11;
            this.btnZnak.Text = "+/-";
            this.btnZnak.UseVisualStyleBackColor = true;
            this.btnZnak.Click += new System.EventHandler(this.btnZnak_Click);
            // 
            // btnTacka
            // 
            this.btnTacka.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacka.ForeColor = System.Drawing.Color.Blue;
            this.btnTacka.Location = new System.Drawing.Point(88, 292);
            this.btnTacka.Name = "btnTacka";
            this.btnTacka.Size = new System.Drawing.Size(70, 70);
            this.btnTacka.TabIndex = 10;
            this.btnTacka.Text = ".";
            this.btnTacka.UseVisualStyleBackColor = true;
            this.btnTacka.Click += new System.EventHandler(this.btnTacka_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Blue;
            this.btn0.Location = new System.Drawing.Point(12, 292);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 70);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Blue;
            this.btn1.Location = new System.Drawing.Point(12, 216);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Blue;
            this.btn2.Location = new System.Drawing.Point(88, 216);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Blue;
            this.btn3.Location = new System.Drawing.Point(164, 216);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Blue;
            this.btn6.Location = new System.Drawing.Point(164, 140);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Blue;
            this.btn5.Location = new System.Drawing.Point(88, 140);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Blue;
            this.btn4.Location = new System.Drawing.Point(12, 140);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.cifra_Click);
            // 
            // btnOtvorena
            // 
            this.btnOtvorena.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtvorena.ForeColor = System.Drawing.Color.Crimson;
            this.btnOtvorena.Location = new System.Drawing.Point(316, 140);
            this.btnOtvorena.Name = "btnOtvorena";
            this.btnOtvorena.Size = new System.Drawing.Size(82, 70);
            this.btnOtvorena.TabIndex = 21;
            this.btnOtvorena.Text = "(";
            this.btnOtvorena.UseVisualStyleBackColor = true;
            this.btnOtvorena.Click += new System.EventHandler(this.btnOtvorena_Click);
            // 
            // btnZatvorena
            // 
            this.btnZatvorena.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvorena.ForeColor = System.Drawing.Color.Crimson;
            this.btnZatvorena.Location = new System.Drawing.Point(316, 216);
            this.btnZatvorena.Name = "btnZatvorena";
            this.btnZatvorena.Size = new System.Drawing.Size(82, 70);
            this.btnZatvorena.TabIndex = 22;
            this.btnZatvorena.Text = ")";
            this.btnZatvorena.UseVisualStyleBackColor = true;
            this.btnZatvorena.Click += new System.EventHandler(this.btnZatvorena_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Crimson;
            this.btnSave.Location = new System.Drawing.Point(404, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 70);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save Input";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 371);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnZatvorena);
            this.Controls.Add(this.btnOtvorena);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnJednako);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMnozenje);
            this.Controls.Add(this.btnDatum);
            this.Controls.Add(this.btnDeljenje);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnZnak);
            this.Controls.Add(this.btnTacka);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.ekran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavnaForma_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ekran;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDeljenje;
        private System.Windows.Forms.Button btnDatum;
        private System.Windows.Forms.Button btnMnozenje;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnJednako;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnZnak;
        private System.Windows.Forms.Button btnTacka;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnOtvorena;
        private System.Windows.Forms.Button btnZatvorena;
        private System.Windows.Forms.Button btnSave;
    }
}

