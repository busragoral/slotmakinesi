using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace slotmakinesi
{
	public partial class Form1 : Form
	{
		int jetonsayi = 0;
		//int sayac = 0;
		

		Random rand = new Random();
		int index1, index2, index3;
		int puan = 0;
		int toplampuan1 = 0;
		public Form1()
		{

			
			InitializeComponent();
			jetonsayisi.Text = "Jeton Sayısı: ".ToString() + jetonsayi;

		}



		private void button1_Click(object sender, EventArgs e)
		{
		
			if (jetonsayi > 0)
			{

				timer1.Start();
				durdur.Enabled = true;
				durdur.Visible = true;

				jetonsayisi.Text = "Jeton Sayısı: ".ToString() + jetonsayi;
			}
			else
			{

				button1.Visible = false;

				MessageBox.Show("Jeton sayınız yetersizdir. Lütfen yükleme yapınız...");

			}

		
		}

		private void button2_Click(object sender, EventArgs e)
		{

			
			jetonsayi++;
			jetonsayisi.Text = "Jeton Sayısı: ".ToString() + jetonsayi;
			button1.Visible = true;
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//pictureBox1.Image = Image.FromFile("mango.jpg");
			index1 = rand.Next(ımageList1.Images.Count);

			 index2 = new int();
			index2 = rand.Next(ımageList1.Images.Count);

			 index3 = new int();
			index3 = rand.Next(ımageList1.Images.Count);


			pictureBox1.Image = ımageList1.Images[index1];
			pictureBox2.Image = ımageList1.Images[index2];
			pictureBox3.Image = ımageList1.Images[index3];



		}

		private void durdur_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			if (index1 == index2 && index1 == index3)
			{

				puan = puan + 100;
				puanText.Text = "Kazanılan Puan: " + puan.ToString();

				toplampuan.Text = "Toplam Puan: " + toplampuan1.ToString();
			}
			else if (index1 == index2 || index2 == index3 || index1 == index3)
			{
				puan = puan + 50;
				puanText.Text = "Kazanılan Puan: " + puan.ToString();
				toplampuan1 += puan;
				toplampuan.Text = "Toplam Puan: " + toplampuan1.ToString();
			}
			
				if (toplampuan1 > 1000)
			{
				Application.Exit();
			}
		}
	}
}
