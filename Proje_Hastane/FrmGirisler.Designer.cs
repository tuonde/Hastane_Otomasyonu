namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnDr = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnSekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDr
            // 
            this.btnDr.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDr.FlatAppearance.BorderSize = 0;
            this.btnDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDr.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDr.ForeColor = System.Drawing.Color.White;
            this.btnDr.Image = ((System.Drawing.Image)(resources.GetObject("btnDr.Image")));
            this.btnDr.Location = new System.Drawing.Point(74, 161);
            this.btnDr.Name = "btnDr";
            this.btnDr.Size = new System.Drawing.Size(236, 309);
            this.btnDr.TabIndex = 0;
            this.btnDr.Text = "DOKTOR";
            this.btnDr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDr.UseVisualStyleBackColor = false;
            this.btnDr.Click += new System.EventHandler(this.btnDr_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHasta.FlatAppearance.BorderSize = 0;
            this.btnHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHasta.ForeColor = System.Drawing.Color.White;
            this.btnHasta.Image = ((System.Drawing.Image)(resources.GetObject("btnHasta.Image")));
            this.btnHasta.Location = new System.Drawing.Point(380, 150);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(217, 320);
            this.btnHasta.TabIndex = 1;
            this.btnHasta.Text = "HASTA";
            this.btnHasta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHasta.UseVisualStyleBackColor = false;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnSekreter
            // 
            this.btnSekreter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSekreter.FlatAppearance.BorderSize = 0;
            this.btnSekreter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekreter.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreter.ForeColor = System.Drawing.Color.White;
            this.btnSekreter.Image = ((System.Drawing.Image)(resources.GetObject("btnSekreter.Image")));
            this.btnSekreter.Location = new System.Drawing.Point(654, 161);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(215, 309);
            this.btnSekreter.TabIndex = 2;
            this.btnSekreter.Text = "SEKRETER";
            this.btnSekreter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSekreter.UseVisualStyleBackColor = false;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEMİRAL HOSPİTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(768, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(955, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreter);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.btnDr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "DEMİRAL HOSPİTAL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDr;
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnSekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

