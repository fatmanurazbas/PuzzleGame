using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        List<Button> butonListesi = new List<Button>();
        LinkedList<Bitmap> resimler = new LinkedList<Bitmap>();
        List<string> konumlar = new List<string>();
        List<string> mevcut_konumlar = new List<string>();
        string kazanma_konumu;
        string mevcut_konum;
        Bitmap AnaBitmap;
        int saniye = 0, dakika = 0, saat = 0;
        int puan = 0;
        int hareketSayisi = 0;
        OpenFileDialog open = new OpenFileDialog();

        ArrayList skorDizisi = new ArrayList();
        int oyunSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
        private void btnResimYukle_Click(object sender, EventArgs e)
        {

            if (butonListesi != null)
            {
                foreach (Button pics in butonListesi.ToList())
                {
                    this.Controls.Remove(pics);
                }
                butonListesi.Clear();
                resimler.Clear();
                konumlar.Clear();
                mevcut_konumlar.Clear();
                kazanma_konumu = string.Empty;
                mevcut_konum = string.Empty;
                label2.Text = string.Empty;
            }
            open.Filter = "Image Files Only | *.jpg; *.jpeg; *.gif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                AnaBitmap = new Bitmap(open.FileName);
                ButonOlustur();
                ResimEkle();
            }

            String resimKonumu = "";
            try
            {
                resimKonumu = open.FileName;
                orijinalResim.ImageLocation = resimKonumu;
                resimKonumu.Normalize();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluþtu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButonOlustur()
        {
            for (int i = 0; i < 16; i++)
            {
                Button gecici_resim = new Button();
                gecici_resim.Size = new Size(140, 130);
                gecici_resim.Tag = i.ToString();
                gecici_resim.Click += ResmeTiklama;
                butonListesi.Add(gecici_resim);
                konumlar.Add(gecici_resim.Tag.ToString());
            }
        }
        private void ResmeTiklama(object? sender, EventArgs e)
        {
            List<int> labelList = new List<int>();
            Random rand = new Random();
            //BAÐLI LÝSTE
            LinkedList<Button> butonlar = new LinkedList<Button>();
            LinkedListNode<Button> node, right_worker, bottom_worker, bottom_worker_ornek;

            Button button = (Button)sender;

            for (int i = 0; i < 16; i++)
            {
                butonlar.AddLast(button);

            }
            hareketSayisi++;
            puan += 5;


            Button button1 = butonListesi.Find(x => x.Tag == "0");
            Point pic1 = new Point(button.Location.X, button.Location.Y);
            Point pic2 = new Point(button1.Location.X, button1.Location.Y);
            var index1 = this.Controls.IndexOf(button);
            var index2 = this.Controls.IndexOf(button1);
            foreach (Button buton in butonListesi)
            {
                if (buton.Right == button1.Left && buton.Location.Y == button1.Location.Y
               || buton.Left == button1.Right && buton.Location.Y == button1.Location.Y
               || buton.Top == button1.Bottom && buton.Location.X == button1.Location.X
              || buton.Bottom == button1.Top && buton.Location.X == button1.Location.X
              )
                {
                    button.Location = pic2;
                    button1.Location = pic1;

                    this.Controls.SetChildIndex(button, index2);
                    this.Controls.SetChildIndex(button1, index1);
                    lblGuncelPuan.Text = puan.ToString();
                    lblTiklamaSayisi.Text = hareketSayisi.ToString();
                    //lblenYuksekPuan.Text = lblGuncelPuan.Text;

                }
            }
            mevcut_konumlar.Clear();
            Kontrol(sender, e);
        }
        private void ResmiKirp(Bitmap main_bitmap, int height, int width)
        {
            int x, y;
            x = 0;
            y = 0;
            for (int bloklar = 0; bloklar < 16; bloklar++)
            {
                Bitmap kirpilan_resim = new Bitmap(height, width);
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        kirpilan_resim.SetPixel(i, j, main_bitmap.GetPixel((i + x), (j + y)));
                    }
                }
                resimler.AddLast(kirpilan_resim);
                x += 140;
                if (x == 560)
                {
                    x = 0;
                    y += 130;
                }
            }
        }
        private void ResimEkle()
        {
            Bitmap tempBitmap = new Bitmap(AnaBitmap, new Size(560, 520));
            ResmiKirp(tempBitmap, 140, 130);
            for (int i = 0; i < butonListesi.Count; i++)
            {
                //resimler.AddFirst(tempBitmap);
                butonListesi[i].BackgroundImage = resimler.ElementAt(i);
            }
            ButtonlariKonumlandir();
        }
        private void ButtonlariKonumlandir()
        {
            var resimleriKaristir = butonListesi.OrderBy(a => Guid.NewGuid()).ToList();
            butonListesi = resimleriKaristir;
            int x = 440;
            int y = 100;
            for (int i = 0; i < butonListesi.Count; i++)
            {
                butonListesi[i].BackColor = Color.White;
                if (i == 4 || i == 8 || i == 12)
                {
                    y += 130;
                    x = 440;
                }
                butonListesi[i].Location = new Point(x, y);
                this.Controls.Add(butonListesi[i]);
                x += 140;
                kazanma_konumu += konumlar[i];
            }
        }
        private void CozumButonlar()
        {
            int x = 440;
            int y = 100;
            for (int i = 0; i < butonListesi.Count; i++)
            {
                butonListesi[i].BackColor = Color.White;
                if (i == 4 || i == 8 || i == 12)
                {
                    y += 130;
                    x = 440;
                }
                butonListesi[i].Location = new Point(x, y);
                this.Controls.Add(butonListesi[i]);
                x += 140;
                kazanma_konumu += konumlar[i];
            }
        }
        private void skorSiralama()
        {

        }
        private void Kontrol(object sender, EventArgs e)
        {
            oyunSayisi++;
            foreach (Control x in this.Controls)
            {

                if (x is Button)
                {
                    mevcut_konumlar.Add(x.Tag.ToString());
                }
            }
            mevcut_konum = string.Join("", mevcut_konumlar);
            label1.Text = kazanma_konumu;
            label2.Text = mevcut_konum;
            if (kazanma_konumu == mevcut_konum)
            {
                MessageBox.Show("Tebrikler, Oyun Bitti!", "Puzzle Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiklamaSayisi.Text = hareketSayisi.ToString();
                lblGuncelPuan.Text = puan.ToString();
                //lstBoxSkorlarTablosu.Items.Add(lblenYuksekPuan.Text);
                lstBoxSkorlarTablosu.Items.Insert(0, lblGuncelPuan.Text);
                lstBoxSure.Items.Add(lblZaman.Text);
                DialogResult cikis;
                cikis = MessageBox.Show("Oyundan Çýkmak Ýstiyor Musunuz?", "Puzzle Oyunu",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cikis == DialogResult.Yes)
                {
                    Application.Exit();
                    Yazdir();
                }
                else
                {
                    cikis = MessageBox.Show("Yeniden oynamak ister misiniz?", "Puzzle Oyunu", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (cikis == DialogResult.Yes)
                    {
                        Yazdir();
                        Reset(sender, e);
                        hareketSayisi = 0;
                        puan = 0;
                        enYuksekSkor();
                        lblGuncelPuan.Text = "0";
                        lblTiklamaSayisi.Text = "0";
                        tbxName.Text = "";
                        foreach (Button pics in butonListesi.ToList())
                        {
                            this.Controls.Remove(pics);
                        }
                        butonListesi.Clear();
                        resimler.Clear();
                        konumlar.Clear();
                        orijinalResim.Image = null;
                        mevcut_konumlar.Clear();
                    }
                }
                label2.Text = "Matched !!!!";
                skorSiralama();
            }
        }

        public void Reset(object sender, EventArgs e)
        {
            lblZaman.Text = "00:00:00";
            saniye = 0;
            dakika = 0;
            saat = 0;
            timer1_Tick(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Oyundan Çýkmak Ýstiyor Musunuz?", "Puzzle Oyunu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
                Yazdir();
            }
            else
            {
                cikis = MessageBox.Show("Yeniden oynamak ister misiniz?", "Puzzle Oyunu", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (cikis == DialogResult.Yes)
                {
                    Yazdir();
                    Reset(sender, e);
                    hareketSayisi = 0;
                    puan = 0;
                    foreach (Button pics in butonListesi.ToList())
                    {
                        this.Controls.Remove(pics);
                    }
                    butonListesi.Clear();
                    resimler.Clear();
                    konumlar.Clear();
                    mevcut_konumlar.Clear();
                    orijinalResim.Image = null;
                    ButtonlariKonumlandir();
                    enYuksekSkor();
                    lblGuncelPuan.Text = 0.ToString();
                    lblTiklamaSayisi.Text = 0.ToString();
                    tbxName.Text = "";
                }
            }
        }
        private void enYuksekSkor()
        {
            int enYuksekSkor = 0;
            //for (int i = 0; i < lstBoxSkorlarTablosu.Items.Count; i++)
            //{
            //    if (i > enYuksekSkor)
            //    {
            //        enYuksekSkor = i;
            //        lblenYuksekPuan.Text = lstBoxSkorlarTablosu.Items[enYuksekSkor].ToString();

            //    }
            //}
            foreach (var item in lstBoxSkorlarTablosu.Items)
            {
                int value = int.Parse(item.ToString());

                if (value > enYuksekSkor)
                    enYuksekSkor = value;
            }
            lblenYuksekPuan.Text =  $"{enYuksekSkor}";
        }
            private void btnCozum_Click(object sender, EventArgs e)
        {
            oyunSayisi++;
            CozumButonlar();
            int x = 90;
            int y = 45;

            for (int i = 0; i < butonListesi.Count; i++)
            {
                butonListesi[i].BackgroundImage = (Image)resimler.ElementAt(i);
            }

            MessageBox.Show("Tebrikler, Oyun Bitti!", "Puzzle Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTiklamaSayisi.Text = hareketSayisi.ToString();
            lblGuncelPuan.Text = puan.ToString();
            lstBoxSkorlarTablosu.Items.Insert(0, lblGuncelPuan.Text);
            lstBoxSure.Items.Insert(0, lblZaman.Text);
            enYuksekSkor();
            DialogResult cikis;
            cikis = MessageBox.Show("Oyundan Çýkmak Ýstiyor Musunuz?", "Puzzle Oyunu",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                cikis = MessageBox.Show("Yeniden oynamak ister misiniz?", "Puzzle Oyunu", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (cikis == DialogResult.Yes)
                {
                    Reset(sender, e);
                    hareketSayisi = 0;
                    puan = 0;
                    foreach (Button pics in butonListesi.ToList())
                    {
                        this.Controls.Remove(pics);
                    }
                    butonListesi.Clear();
                    resimler.Clear();
                    konumlar.Clear();
                    mevcut_konumlar.Clear();
                    orijinalResim.Image = null;
                    enYuksekSkor();
                    lblGuncelPuan.Text = "0";
                    lblTiklamaSayisi.Text = "0";
                    tbxName.Text = "";
                }
            }
        }
        private void Yazdir()
        {
            TextWriter txt = new StreamWriter("E:\\PuzzleGame Github\\PuzzleGame\\PuzzleGame\\enyuksekskor.txt");
            txt.Write("Kullanýcý adý : " + tbxName.Text + "\n");
            txt.Write("Hamle sayýsý : " + lblTiklamaSayisi.Text + "\n");
            txt.Write("Puan : " + lblGuncelPuan.Text + "\n");
            txt.Write("Süre: " + lblZaman.Text + "\n");
            txt.Write("*********************************** \n");
            txt.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Zaman";
            timer1.Start();
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                saniye = 0;
                dakika = 0;
                saat++;
            }
            lblZaman.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye++;
        }
        private void btnKaristir_Click(object sender, EventArgs e)
        {
            ButtonlariKonumlandir();
        }
    }
}