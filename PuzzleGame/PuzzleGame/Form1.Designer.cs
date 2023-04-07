namespace PuzzleGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel4 = new Panel();
            lblenYuksekPuan = new Label();
            label12 = new Label();
            label11 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            label5 = new Label();
            lstBoxSure = new ListBox();
            lstBoxSkorlarTablosu = new ListBox();
            panel3 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            btnCozum = new Button();
            btnKaristir = new Button();
            btnExit = new Button();
            panel5 = new Panel();
            orijinalResim = new PictureBox();
            btnResimYukle = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            tbxName = new TextBox();
            label10 = new Label();
            label8 = new Label();
            lblTiklamaSayisi = new Label();
            lblGuncelPuan = new Label();
            label6 = new Label();
            lblZaman = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orijinalResim).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.RosyBrown;
            panel4.Controls.Add(lblenYuksekPuan);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 626);
            panel4.TabIndex = 7;
            // 
            // lblenYuksekPuan
            // 
            lblenYuksekPuan.AutoSize = true;
            lblenYuksekPuan.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblenYuksekPuan.ForeColor = Color.MistyRose;
            lblenYuksekPuan.Location = new Point(138, 108);
            lblenYuksekPuan.Name = "lblenYuksekPuan";
            lblenYuksekPuan.Size = new Size(33, 34);
            lblenYuksekPuan.TabIndex = 7;
            lblenYuksekPuan.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.RosyBrown;
            label12.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.MistyRose;
            label12.Location = new Point(37, 62);
            label12.Name = "label12";
            label12.Size = new Size(232, 34);
            label12.TabIndex = 10;
            label12.Text = "En Yüksek Skor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.RosyBrown;
            label11.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.MistyRose;
            label11.Location = new Point(8, 242);
            label11.Name = "label11";
            label11.Size = new Size(204, 34);
            label11.TabIndex = 9;
            label11.Text = "Skor Tablosu ";
            // 
            // panel6
            // 
            panel6.BackColor = Color.MistyRose;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(lstBoxSure);
            panel6.Controls.Add(lstBoxSkorlarTablosu);
            panel6.Location = new Point(8, 288);
            panel6.Name = "panel6";
            panel6.Size = new Size(327, 317);
            panel6.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(163, 3);
            label7.Name = "label7";
            label7.Size = new Size(66, 28);
            label7.TabIndex = 9;
            label7.Text = "Süre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 8;
            label5.Text = "Skor";
            // 
            // lstBoxSure
            // 
            lstBoxSure.BackColor = Color.MistyRose;
            lstBoxSure.BorderStyle = BorderStyle.None;
            lstBoxSure.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lstBoxSure.ForeColor = Color.Maroon;
            lstBoxSure.FormattingEnabled = true;
            lstBoxSure.ItemHeight = 28;
            lstBoxSure.Location = new Point(163, 34);
            lstBoxSure.Name = "lstBoxSure";
            lstBoxSure.Size = new Size(156, 280);
            lstBoxSure.TabIndex = 7;
            // 
            // lstBoxSkorlarTablosu
            // 
            lstBoxSkorlarTablosu.BackColor = Color.MistyRose;
            lstBoxSkorlarTablosu.BorderStyle = BorderStyle.None;
            lstBoxSkorlarTablosu.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lstBoxSkorlarTablosu.ForeColor = Color.Maroon;
            lstBoxSkorlarTablosu.FormattingEnabled = true;
            lstBoxSkorlarTablosu.ItemHeight = 28;
            lstBoxSkorlarTablosu.Location = new Point(6, 34);
            lstBoxSkorlarTablosu.Name = "lstBoxSkorlarTablosu";
            lstBoxSkorlarTablosu.Size = new Size(157, 280);
            lstBoxSkorlarTablosu.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(344, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(733, 67);
            panel3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RosyBrown;
            label4.Cursor = Cursors.IBeam;
            label4.Font = new Font("Tahoma", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MistyRose;
            label4.Location = new Point(201, 15);
            label4.Name = "label4";
            label4.Size = new Size(359, 52);
            label4.TabIndex = 0;
            label4.Text = "PUZZLE OYUNU";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnCozum);
            panel1.Controls.Add(btnKaristir);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnResimYukle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1077, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 626);
            panel1.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.RosyBrown;
            label13.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.MistyRose;
            label13.Location = new Point(29, 68);
            label13.Name = "label13";
            label13.Size = new Size(156, 28);
            label13.TabIndex = 12;
            label13.Text = "Resim Yükle";
            // 
            // btnCozum
            // 
            btnCozum.BackColor = Color.MistyRose;
            btnCozum.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCozum.ForeColor = Color.Maroon;
            btnCozum.Location = new Point(29, 507);
            btnCozum.Name = "btnCozum";
            btnCozum.Size = new Size(294, 100);
            btnCozum.TabIndex = 7;
            btnCozum.Text = "ÇÖZÜM";
            btnCozum.UseVisualStyleBackColor = false;
            btnCozum.Click += btnCozum_Click;
            // 
            // btnKaristir
            // 
            btnKaristir.BackColor = Color.MistyRose;
            btnKaristir.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaristir.ForeColor = Color.Maroon;
            btnKaristir.Location = new Point(29, 381);
            btnKaristir.Name = "btnKaristir";
            btnKaristir.Size = new Size(294, 100);
            btnKaristir.TabIndex = 3;
            btnKaristir.Text = "KARIŞTIR";
            btnKaristir.UseVisualStyleBackColor = false;
            btnKaristir.Click += btnKaristir_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.MistyRose;
            btnExit.FlatAppearance.BorderColor = Color.RosyBrown;
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(279, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(63, 41);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MistyRose;
            panel5.Controls.Add(orijinalResim);
            panel5.Location = new Point(29, 119);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 231);
            panel5.TabIndex = 1;
            // 
            // orijinalResim
            // 
            orijinalResim.Location = new Point(0, 0);
            orijinalResim.Name = "orijinalResim";
            orijinalResim.Size = new Size(294, 231);
            orijinalResim.SizeMode = PictureBoxSizeMode.StretchImage;
            orijinalResim.TabIndex = 0;
            orijinalResim.TabStop = false;
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.MistyRose;
            btnResimYukle.FlatAppearance.BorderColor = Color.Maroon;
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnResimYukle.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnResimYukle.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimYukle.ForeColor = Color.Maroon;
            btnResimYukle.Location = new Point(205, 68);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(118, 36);
            btnResimYukle.TabIndex = 0;
            btnResimYukle.Text = "Yükle";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 448);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 520);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(lblZaman);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 644);
            panel2.Name = "panel2";
            panel2.Size = new Size(1407, 197);
            panel2.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(tbxName);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(lblTiklamaSayisi);
            panel7.Controls.Add(lblGuncelPuan);
            panel7.Controls.Add(label6);
            panel7.ForeColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(441, 24);
            panel7.Name = "panel7";
            panel7.Size = new Size(497, 155);
            panel7.TabIndex = 8;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.MistyRose;
            tbxName.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbxName.ForeColor = SystemColors.ActiveCaptionText;
            tbxName.Location = new Point(259, 15);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(214, 34);
            tbxName.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.MistyRose;
            label10.Location = new Point(23, 102);
            label10.Name = "label10";
            label10.Size = new Size(215, 34);
            label10.TabIndex = 16;
            label10.Text = "Tıklama Sayısı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MistyRose;
            label8.Location = new Point(23, 59);
            label8.Name = "label8";
            label8.Size = new Size(191, 34);
            label8.TabIndex = 15;
            label8.Text = "Güncel Puan";
            // 
            // lblTiklamaSayisi
            // 
            lblTiklamaSayisi.AutoSize = true;
            lblTiklamaSayisi.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTiklamaSayisi.ForeColor = Color.MistyRose;
            lblTiklamaSayisi.Location = new Point(259, 102);
            lblTiklamaSayisi.Name = "lblTiklamaSayisi";
            lblTiklamaSayisi.Size = new Size(33, 34);
            lblTiklamaSayisi.TabIndex = 14;
            lblTiklamaSayisi.Text = "0";
            // 
            // lblGuncelPuan
            // 
            lblGuncelPuan.AutoSize = true;
            lblGuncelPuan.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGuncelPuan.ForeColor = Color.MistyRose;
            lblGuncelPuan.Location = new Point(259, 59);
            lblGuncelPuan.Name = "lblGuncelPuan";
            lblGuncelPuan.Size = new Size(33, 34);
            lblGuncelPuan.TabIndex = 13;
            lblGuncelPuan.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MistyRose;
            label6.Location = new Point(23, 15);
            label6.Name = "label6";
            label6.Size = new Size(52, 34);
            label6.TabIndex = 0;
            label6.Text = "Ad";
            // 
            // lblZaman
            // 
            lblZaman.AutoSize = true;
            lblZaman.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblZaman.ForeColor = Color.MistyRose;
            lblZaman.Location = new Point(85, 91);
            lblZaman.Name = "lblZaman";
            lblZaman.Size = new Size(143, 34);
            lblZaman.TabIndex = 7;
            lblZaman.Text = "00:00:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MistyRose;
            label3.Location = new Point(96, 46);
            label3.Name = "label3";
            label3.Size = new Size(111, 34);
            label3.TabIndex = 2;
            label3.Text = "Zaman";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1433, 856);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orijinalResim).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label lblenYuksekPuan;
        private Label label12;
        private Label label11;
        private Panel panel6;
        private ListBox lstBoxSure;
        private ListBox lstBoxSkorlarTablosu;
        private Panel panel3;
        private Label label4;
        private Panel panel1;
        private Label label13;
        private Button btnCozum;
        private Button btnKaristir;
        private Button btnExit;
        private Panel panel5;
        private PictureBox orijinalResim;
        private Button btnResimYukle;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel7;
        private TextBox tbxName;
        private Label label10;
        private Label label8;
        private Label lblTiklamaSayisi;
        private Label lblGuncelPuan;
        private Label label6;
        private Label lblZaman;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label label5;
    }
}