﻿namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(84, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 29);
            this.label7.TabIndex = 46;
            this.label7.Text = "Bilgi Güncelleme Ekranı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuncelle.Location = new System.Drawing.Point(186, 310);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 40);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(154, 273);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(172, 31);
            this.txtSifre.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(154, 136);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(172, 31);
            this.txtSoyad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(98, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "TC Kimlik No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(154, 88);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(172, 31);
            this.txtAd.TabIndex = 1;
            // 
            // mskTC
            // 
            this.mskTC.Enabled = false;
            this.mskTC.Location = new System.Drawing.Point(154, 181);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(172, 31);
            this.mskTC.TabIndex = 35;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(85, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(111, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ad:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(154, 227);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(172, 31);
            this.cmbBrans.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(89, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Branş:";
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(399, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label1;
    }
}