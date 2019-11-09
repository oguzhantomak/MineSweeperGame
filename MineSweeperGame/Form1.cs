using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            flpMineArea.Controls.Clear();
            //PictureBox[] pbMines = new PictureBox[100];
            for (int i = 0; i < 100; i++)
            {
                PictureBox minePb = new PictureBox();
                minePb.Height = minePb.Width = 40;

                minePb.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                int mine = rnd.Next(0, 2);
                minePb.Text = mine.ToString();

                //Kontroler üzerinde değer saklarken "TAG" değişkenini kullanırız. Tipi object olduğundan istediğimiz tipte değer saklamamızı sağlar.
                minePb.Tag = mine;

                //Kontrol Adı.Event Adı += TAB TAB
                minePb.Click += MinePb_Click;


                flpMineArea.Controls.Add(minePb);
            }
        }

        private void MinePb_Click(object sender, EventArgs e)
        {
            //Tıklanan butonu yakalıyoruz.(Sender ediyoruz)
            PictureBox minePb1 = (PictureBox)sender;
            //MessageBox.Show(minePb1.Tag.ToString());

            //Tıklanan butonun Tag bilgisini yani mayın olup olmadığını yani 0 veya 1 olduğunu mineInfo değişkenine atıyoruz.
            int mineInfo = Convert.ToInt32(minePb1.Tag);

            //Eğer mineInfo değişkeni yani tıklanan butonun tag'i 0 ise yani mayın değilse
            if (mineInfo == 0)
            {
                //Tıklanan butonun arka plan rengini yeşil yap
                minePb1.BackColor = Color.Green;
            }
            //Eğer tıklanan buton bir mayınsa
            else
            {
                //flpMineArea isimli Flow Layout Panel'in içerisindeki controls(kontroller)'de dön, Control türünde item olarak tut.
                foreach (Control item in flpMineArea.Controls)
                {
                    //PictureBox türünde minePb değişkeni oluştur ve control olarak dönen itemları PictureBox türünde tut.
                    PictureBox minePb = item as PictureBox;

                    //Eğer tuttuğumuz minePb değişkenindeki PictureBoxların taglari'i 1 ise
                    if (Convert.ToInt32(minePb.Tag) == 1)
                    {
                        //Tag'i 1 olan bütün PictureBoxların arka planını siyah yap ve mayın simgesi getir.
                        minePb.BackColor = Color.Black;
                        minePb.Image = Image.FromFile("C:/Users/Ruben Castro/Desktop/Mine-Transparent-Backgroundx25.png");
                    }
                    else
                    {
                        //Tag'i 0 olan bütün PictureBoxlaron arka planını beyaz yap.
                        minePb.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
