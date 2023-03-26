using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {

        bool deger;  //butona ardışık şekilde farklı şeyler yazdırmak için bool değişkeni kullandık
        int deger_sayi = 0; //kaç kere butona basıldığını hesaplayacak
        public Form1()
        {
            InitializeComponent();
        }
        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deger = (!deger); //böylece ilk başlayan oyuncu değişti
            button1.Text = ""; //butonların içini boşalttı
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true; //true yaparak tekrar tıklanmaya açık hale geldi
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            deger_sayi = 0; //sıfırlayarak önceki oyunda tıklanmış butonlar yoksayıldı
            
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //oyundan çıkış yapmak için kullanıldı
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ŞEYMA BAŞGÖZE tarafından"); //hakkında seçeneği için messagebox oluşturuldu
        }

          private void button_Click(object sender, EventArgs e)
        {
            
            Button yaz = (Button)sender;
            if (deger)
            {
                yaz.Text = "O"; //değer,her tıklandığında 1 veya 0 olacak şekilde değişecek
            }
            else
                yaz.Text = "X"; //böylece her tıkta farklı karakterler yazdırılacak
                deger = !deger; //bu şartı kullanarak değer değişecek, sürekli "x" veya "o"yazılmayacak
                yaz.Enabled = false; //sayesinde kutudaki ifade değişmiyor ve kazanan belli oluyor
                deger_sayi++; //9 olması durumunda oyunun bittiğini belirtmek için artırıldı(3*3 matris)
            label2.Text = yaz.Text; //en son oynayan oyuncunun adını yazar
            if (button9.Text == button5.Text && button5.Text == button1.Text && (!button1.Enabled))
            {//tüm kazanma olasılıklarını yazdırıldı
                MessageBox.Show(button1.Text + " kazandı"); //enabled sayesinde butonlar değişime kapandı
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && (!button1.Enabled))
            {
                MessageBox.Show(button7.Text + " kazandı");
            }
            else if (button1.Text == button2.Text && button2.Text == button3.Text && (!button1.Enabled))
            {
                MessageBox.Show(button3.Text + " kazandı");
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && (!button2.Enabled))
            {
                MessageBox.Show(button2.Text + " kazandı");
               
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && (!button3.Enabled))
            {
                MessageBox.Show(button9.Text + " kazandı");
              
            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text && !(button4.Enabled))
            {
                MessageBox.Show(button6.Text + " kazandı");
               
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && (!button7.Enabled))
            {
                MessageBox.Show(button9.Text + " kazandı");
               
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && (!button7.Enabled))
            {
                MessageBox.Show(button7.Text + " kazandı");
              
            }
            else if (deger_sayi >= 9)//sayaç toplam kare sayısına ulaşırsa oyun berabere biter
            {
               
                MessageBox.Show("oyun berabere,yeni oyun açılıyor");
                label2.Text = (deger).ToString(); //değerin çevirdiği şeyi label'a yazdırdı
                button1.Text = ""; //butonların içini boşalttı
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                button1.Enabled = true; //true yaparak tekrar tıklanmaya açık hale geldi
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                deger_sayi = 0;       //sıfırlayarak önceki oyunda tıklanmış butonlar yoksayıldı   
            }
        }
      }
   }

