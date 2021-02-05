namespace slotmakinesi
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.durdur = new System.Windows.Forms.Button();
			this.jetonsayisi = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.puanText = new System.Windows.Forms.Label();
			this.toplampuan = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(71, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(159, 140);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(309, 74);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(159, 140);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(549, 74);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(159, 140);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.CausesValidation = false;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(309, 298);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 37);
			this.button1.TabIndex = 3;
			this.button1.Text = "BAŞLA";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// durdur
			// 
			this.durdur.BackColor = System.Drawing.Color.Red;
			this.durdur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.durdur.CausesValidation = false;
			this.durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.durdur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.durdur.Location = new System.Drawing.Point(309, 354);
			this.durdur.Name = "durdur";
			this.durdur.Size = new System.Drawing.Size(159, 37);
			this.durdur.TabIndex = 4;
			this.durdur.Text = "DURDUR";
			this.durdur.UseVisualStyleBackColor = false;
			this.durdur.Visible = false;
			this.durdur.Click += new System.EventHandler(this.durdur_Click);
			// 
			// jetonsayisi
			// 
			this.jetonsayisi.AutoSize = true;
			this.jetonsayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.jetonsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.jetonsayisi.ForeColor = System.Drawing.SystemColors.MenuText;
			this.jetonsayisi.Location = new System.Drawing.Point(23, 298);
			this.jetonsayisi.Name = "jetonsayisi";
			this.jetonsayisi.Size = new System.Drawing.Size(119, 19);
			this.jetonsayisi.TabIndex = 5;
			this.jetonsayisi.Text = "JETON SAYISI:";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.CausesValidation = false;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new System.Drawing.Point(23, 337);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 31);
			this.button2.TabIndex = 6;
			this.button2.Text = "Jeton Yükle";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "cilek.jpg");
			this.ımageList1.Images.SetKeyName(1, "kiraz.jpg");
			this.ımageList1.Images.SetKeyName(2, "mango.jpg");
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// puanText
			// 
			this.puanText.AutoSize = true;
			this.puanText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.puanText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.puanText.ForeColor = System.Drawing.SystemColors.MenuText;
			this.puanText.Location = new System.Drawing.Point(559, 298);
			this.puanText.Name = "puanText";
			this.puanText.Size = new System.Drawing.Size(127, 19);
			this.puanText.TabIndex = 7;
			this.puanText.Text = "Kazanılan puan:";
			// 
			// toplampuan
			// 
			this.toplampuan.AutoSize = true;
			this.toplampuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toplampuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toplampuan.ForeColor = System.Drawing.SystemColors.MenuText;
			this.toplampuan.Location = new System.Drawing.Point(559, 337);
			this.toplampuan.Name = "toplampuan";
			this.toplampuan.Size = new System.Drawing.Size(125, 19);
			this.toplampuan.TabIndex = 8;
			this.toplampuan.Text = "TOPLAM PUAN:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toplampuan);
			this.Controls.Add(this.puanText);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.jetonsayisi);
			this.Controls.Add(this.durdur);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button durdur;
		private System.Windows.Forms.Label jetonsayisi;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label puanText;
		private System.Windows.Forms.Label toplampuan;
	}
}

