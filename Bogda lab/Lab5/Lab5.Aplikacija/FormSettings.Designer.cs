namespace Lab5.Aplikacija
{
    partial class FormSettings
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
            this.lblBrojRedova = new System.Windows.Forms.Label();
            this.nudBrojRedova = new System.Windows.Forms.NumericUpDown();
            this.nudBrojKolona = new System.Windows.Forms.NumericUpDown();
            this.lblBrojKolona = new System.Windows.Forms.Label();
            this.nudBrojSlika = new System.Windows.Forms.NumericUpDown();
            this.lblBrojSlika = new System.Windows.Forms.Label();
            this.nudBrojParova = new System.Windows.Forms.NumericUpDown();
            this.lblBrojParova = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojRedova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojKolona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojParova)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrojRedova
            // 
            this.lblBrojRedova.AutoSize = true;
            this.lblBrojRedova.Location = new System.Drawing.Point(47, 25);
            this.lblBrojRedova.Name = "lblBrojRedova";
            this.lblBrojRedova.Size = new System.Drawing.Size(69, 13);
            this.lblBrojRedova.TabIndex = 6;
            this.lblBrojRedova.Text = "Broj Redova:";
            // 
            // nudBrojRedova
            // 
            this.nudBrojRedova.Location = new System.Drawing.Point(133, 25);
            this.nudBrojRedova.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBrojRedova.Name = "nudBrojRedova";
            this.nudBrojRedova.Size = new System.Drawing.Size(83, 20);
            this.nudBrojRedova.TabIndex = 0;
            this.nudBrojRedova.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nudBrojKolona
            // 
            this.nudBrojKolona.Location = new System.Drawing.Point(133, 63);
            this.nudBrojKolona.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBrojKolona.Name = "nudBrojKolona";
            this.nudBrojKolona.Size = new System.Drawing.Size(83, 20);
            this.nudBrojKolona.TabIndex = 1;
            this.nudBrojKolona.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblBrojKolona
            // 
            this.lblBrojKolona.AutoSize = true;
            this.lblBrojKolona.Location = new System.Drawing.Point(52, 65);
            this.lblBrojKolona.Name = "lblBrojKolona";
            this.lblBrojKolona.Size = new System.Drawing.Size(64, 13);
            this.lblBrojKolona.TabIndex = 7;
            this.lblBrojKolona.Text = "Broj Kolona:";
            // 
            // nudBrojSlika
            // 
            this.nudBrojSlika.Location = new System.Drawing.Point(133, 154);
            this.nudBrojSlika.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBrojSlika.Name = "nudBrojSlika";
            this.nudBrojSlika.Size = new System.Drawing.Size(83, 20);
            this.nudBrojSlika.TabIndex = 3;
            this.nudBrojSlika.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblBrojSlika
            // 
            this.lblBrojSlika.AutoSize = true;
            this.lblBrojSlika.Location = new System.Drawing.Point(62, 156);
            this.lblBrojSlika.Name = "lblBrojSlika";
            this.lblBrojSlika.Size = new System.Drawing.Size(54, 13);
            this.lblBrojSlika.TabIndex = 9;
            this.lblBrojSlika.Text = "Broj Slika:";
            // 
            // nudBrojParova
            // 
            this.nudBrojParova.Location = new System.Drawing.Point(133, 107);
            this.nudBrojParova.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudBrojParova.Name = "nudBrojParova";
            this.nudBrojParova.Size = new System.Drawing.Size(83, 20);
            this.nudBrojParova.TabIndex = 2;
            this.nudBrojParova.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lblBrojParova
            // 
            this.lblBrojParova.AutoSize = true;
            this.lblBrojParova.Location = new System.Drawing.Point(55, 109);
            this.lblBrojParova.Name = "lblBrojParova";
            this.lblBrojParova.Size = new System.Drawing.Size(65, 13);
            this.lblBrojParova.TabIndex = 8;
            this.lblBrojParova.Text = "Broj Parova:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(50, 229);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(166, 35);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(50, 200);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(102, 23);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Podrazumevano";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 281);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudBrojSlika);
            this.Controls.Add(this.lblBrojSlika);
            this.Controls.Add(this.nudBrojParova);
            this.Controls.Add(this.lblBrojParova);
            this.Controls.Add(this.nudBrojKolona);
            this.Controls.Add(this.lblBrojKolona);
            this.Controls.Add(this.nudBrojRedova);
            this.Controls.Add(this.lblBrojRedova);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 320);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podešavanja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojRedova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojKolona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojParova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojRedova;
        private System.Windows.Forms.NumericUpDown nudBrojRedova;
        private System.Windows.Forms.NumericUpDown nudBrojKolona;
        private System.Windows.Forms.Label lblBrojKolona;
        private System.Windows.Forms.NumericUpDown nudBrojSlika;
        private System.Windows.Forms.Label lblBrojSlika;
        private System.Windows.Forms.NumericUpDown nudBrojParova;
        private System.Windows.Forms.Label lblBrojParova;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDefault;
    }
}