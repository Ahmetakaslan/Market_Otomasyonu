namespace Otomasyon1
{
    partial class FormÜrünSat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÜrünSat));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.Labelİsim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxgücelleÜrünİsmi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxgüncelleÜrünAdedi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxgücelleÜrünFiyatı = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxÜrünİsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxürünadedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxfiyat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(961, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 31);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Labelİsim
            // 
            this.Labelİsim.AutoSize = true;
            this.Labelİsim.Location = new System.Drawing.Point(506, 20);
            this.Labelİsim.Name = "Labelİsim";
            this.Labelİsim.Size = new System.Drawing.Size(42, 23);
            this.Labelİsim.TabIndex = 11;
            this.Labelİsim.Text = "isim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // tbxgücelleÜrünİsmi
            // 
            this.tbxgücelleÜrünİsmi.Location = new System.Drawing.Point(842, 383);
            this.tbxgücelleÜrünİsmi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxgücelleÜrünİsmi.Name = "tbxgücelleÜrünİsmi";
            this.tbxgücelleÜrünİsmi.Size = new System.Drawing.Size(183, 30);
            this.tbxgücelleÜrünİsmi.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stok Adedi:";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(842, 604);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(183, 33);
            this.btnGüncelle.TabIndex = 12;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 17;
            // 
            // tbxgüncelleÜrünAdedi
            // 
            this.tbxgüncelleÜrünAdedi.Location = new System.Drawing.Point(842, 532);
            this.tbxgüncelleÜrünAdedi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxgüncelleÜrünAdedi.Name = "tbxgüncelleÜrünAdedi";
            this.tbxgüncelleÜrünAdedi.Size = new System.Drawing.Size(183, 30);
            this.tbxgüncelleÜrünAdedi.TabIndex = 14;
            this.tbxgüncelleÜrünAdedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxgüncelleÜrünAdedi_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ürün ismi:";
            // 
            // tbxgücelleÜrünFiyatı
            // 
            this.tbxgücelleÜrünFiyatı.Location = new System.Drawing.Point(842, 457);
            this.tbxgücelleÜrünFiyatı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxgücelleÜrünFiyatı.Name = "tbxgücelleÜrünFiyatı";
            this.tbxgücelleÜrünFiyatı.Size = new System.Drawing.Size(183, 30);
            this.tbxgücelleÜrünFiyatı.TabIndex = 15;
            this.tbxgücelleÜrünFiyatı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxgücelleÜrünFiyatı_KeyPress_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(405, 440);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 96);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "Açıklama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ürün Fiyatı:";
            // 
            // tbxÜrünİsmi
            // 
            this.tbxÜrünİsmi.Location = new System.Drawing.Point(153, 383);
            this.tbxÜrünİsmi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxÜrünİsmi.Name = "tbxÜrünİsmi";
            this.tbxÜrünİsmi.Size = new System.Drawing.Size(183, 30);
            this.tbxÜrünİsmi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Stok Adedi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(153, 604);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(183, 33);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 25;
            // 
            // tbxürünadedi
            // 
            this.tbxürünadedi.Location = new System.Drawing.Point(153, 532);
            this.tbxürünadedi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxürünadedi.Name = "tbxürünadedi";
            this.tbxürünadedi.Size = new System.Drawing.Size(183, 30);
            this.tbxürünadedi.TabIndex = 22;
            this.tbxürünadedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxürünadedi_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ürün ismi:";
            // 
            // tbxfiyat
            // 
            this.tbxfiyat.Location = new System.Drawing.Point(153, 457);
            this.tbxfiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxfiyat.Name = "tbxfiyat";
            this.tbxfiyat.Size = new System.Drawing.Size(183, 30);
            this.tbxfiyat.TabIndex = 23;
            this.tbxfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxfiyat_KeyPress_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(704, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 25);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(15, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 25);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Sat";
            // 
            // FormÜrünSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxÜrünİsmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxürünadedi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxfiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxgücelleÜrünİsmi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxgüncelleÜrünAdedi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxgücelleÜrünFiyatı);
            this.Controls.Add(this.Labelİsim);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormÜrünSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Sat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label Labelİsim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxgücelleÜrünİsmi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxgüncelleÜrünAdedi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxgücelleÜrünFiyatı;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxÜrünİsmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxürünadedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxfiyat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

