using System;
using System.Windows.Forms;

namespace BilgiYarışmasıUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        public void islem()
        {
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnB.Text;
            btnSonraki.Enabled = true;
            islem();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnC.Text;
            btnSonraki.Enabled = true;
            islem();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnD.Text;
            islem();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnA.Text;
            islem();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruNo++;
            lblSoruNo.Text = soruNo.ToString();
            if(soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edildi ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi Şehir Güneydoğu Anadolu bölgesinde bulunmaz ?";
                btnA.Text = "Mardin";
                btnB.Text = "Batman";
                btnC.Text = "Diyarbakır";
                btnD.Text = "Van";
                label4.Text = "Van";
                btnSonraki.Text = "Sonuçlar";
            }
            if(soruNo == 3)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru : " + dogru +"\n" + "Yanlış : " + yanlis);

            }
        }
        
   
    }
}
