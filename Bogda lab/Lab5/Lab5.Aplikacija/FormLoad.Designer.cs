﻿namespace Lab5.Aplikacija
{
    partial class FormLoad
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
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(12, 84);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(446, 355);
            this.lbxLista.TabIndex = 0;
            this.lbxLista.DoubleClick += new System.EventHandler(this.lbxLista_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite igru koju želite da učitate:";
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxLista);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(486, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 489);
            this.Name = "FormLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sačuvane igre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoad_FormClosing);
            this.Load += new System.EventHandler(this.FormLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Label label1;
    }
}