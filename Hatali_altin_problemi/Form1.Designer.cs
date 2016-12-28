namespace Hatali_altin_problemi
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
            this.btn_bul = new System.Windows.Forms.Button();
            this.txt_altin_sayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_altin = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tarti = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_süre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bul
            // 
            this.btn_bul.Location = new System.Drawing.Point(15, 43);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(197, 23);
            this.btn_bul.TabIndex = 0;
            this.btn_bul.Text = "HATALI ALTINI BUL";
            this.btn_bul.UseVisualStyleBackColor = true;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // txt_altin_sayisi
            // 
            this.txt_altin_sayisi.Location = new System.Drawing.Point(112, 17);
            this.txt_altin_sayisi.Name = "txt_altin_sayisi";
            this.txt_altin_sayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_altin_sayisi.TabIndex = 1;
            this.txt_altin_sayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_altin_sayisi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Altın Sayısı Giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "00";
            // 
            // lst_altin
            // 
            this.lst_altin.BackColor = System.Drawing.Color.White;
            this.lst_altin.FormattingEnabled = true;
            this.lst_altin.Location = new System.Drawing.Point(227, 20);
            this.lst_altin.Name = "lst_altin";
            this.lst_altin.Size = new System.Drawing.Size(154, 277);
            this.lst_altin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hatalı Altın Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tartış Sayısı  :";
            // 
            // lbl_tarti
            // 
            this.lbl_tarti.AutoSize = true;
            this.lbl_tarti.Location = new System.Drawing.Point(152, 241);
            this.lbl_tarti.Name = "lbl_tarti";
            this.lbl_tarti.Size = new System.Drawing.Size(19, 13);
            this.lbl_tarti.TabIndex = 3;
            this.lbl_tarti.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hatalı Altın Bulma Süresi :";
            // 
            // lbl_süre
            // 
            this.lbl_süre.AutoSize = true;
            this.lbl_süre.Location = new System.Drawing.Point(153, 269);
            this.lbl_süre.Name = "lbl_süre";
            this.lbl_süre.Size = new System.Drawing.Size(19, 13);
            this.lbl_süre.TabIndex = 3;
            this.lbl_süre.Text = "00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hatali_altin_problemi.Properties.Resources.gold;
            this.pictureBox1.Location = new System.Drawing.Point(15, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 312);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lst_altin);
            this.Controls.Add(this.lbl_süre);
            this.Controls.Add(this.lbl_tarti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_altin_sayisi);
            this.Controls.Add(this.btn_bul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.TextBox txt_altin_sayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_altin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_tarti;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_süre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

