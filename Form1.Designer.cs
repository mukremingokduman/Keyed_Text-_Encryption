﻿namespace anahtarli_metin_sifreleme
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label1.Location = new System.Drawing.Point(612, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "İstenilen Adresi Giriniz.";
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSifreCoz.BackgroundImage")));
            this.btnSifreCoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifreCoz.Location = new System.Drawing.Point(39, 247);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(129, 116);
            this.btnSifreCoz.TabIndex = 14;
            this.btnSifreCoz.Text = "Şifre Çöz";
            this.btnSifreCoz.UseVisualStyleBackColor = true;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(604, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(464, 215);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 86);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 86);
            this.textBox1.TabIndex = 11;
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSifrele.BackgroundImage")));
            this.btnSifrele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifrele.Location = new System.Drawing.Point(39, 40);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(129, 116);
            this.btnSifrele.TabIndex = 10;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 406);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnSifreCoz);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSifrele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnSifreCoz;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSifrele;
    }
}

