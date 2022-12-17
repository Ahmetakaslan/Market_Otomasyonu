namespace Otomasyon1
{
    partial class FormGirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisYap));
            this.tbxKullanıcıadı = new System.Windows.Forms.TextBox();
            this.tbxŞifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labeltick = new System.Windows.Forms.Label();
            this.lblSifreTick = new System.Windows.Forms.Label();
            this.lblPostaTick = new System.Windows.Forms.Label();
            this.labelGoz = new System.Windows.Forms.Label();
            this.btnGozAc = new System.Windows.Forms.PictureBox();
            this.btnGözKapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnGozAc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGözKapa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxKullanıcıadı
            // 
            this.tbxKullanıcıadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKullanıcıadı.Location = new System.Drawing.Point(453, 196);
            this.tbxKullanıcıadı.Name = "tbxKullanıcıadı";
            this.tbxKullanıcıadı.Size = new System.Drawing.Size(214, 34);
            this.tbxKullanıcıadı.TabIndex = 0;
            this.tbxKullanıcıadı.TextChanged += new System.EventHandler(this.tbxKullanıcıadı_TextChanged_1);
            // 
            // tbxŞifre
            // 
            this.tbxŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxŞifre.HideSelection = false;
            this.tbxŞifre.Location = new System.Drawing.Point(453, 268);
            this.tbxŞifre.Name = "tbxŞifre";
            this.tbxŞifre.PasswordChar = '*';
            this.tbxŞifre.Size = new System.Drawing.Size(214, 34);
            this.tbxŞifre.TabIndex = 1;
            this.tbxŞifre.TextChanged += new System.EventHandler(this.tbxŞifre_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(249, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "E  Posta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(249, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.Location = new System.Drawing.Point(263, 379);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(135, 56);
            this.btnKayıtOl.TabIndex = 4;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click_1);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(655, 379);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(135, 56);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGirisYap_KeyDown);
            // 
            // admin
            // 
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin.Location = new System.Drawing.Point(469, 497);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(135, 56);
            this.admin.TabIndex = 6;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 342);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 22);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labeltick
            // 
            this.labeltick.AutoSize = true;
            this.labeltick.BackColor = System.Drawing.Color.White;
            this.labeltick.Location = new System.Drawing.Point(673, 201);
            this.labeltick.Name = "labeltick";
            this.labeltick.Size = new System.Drawing.Size(0, 22);
            this.labeltick.TabIndex = 8;
            // 
            // lblSifreTick
            // 
            this.lblSifreTick.AutoSize = true;
            this.lblSifreTick.BackColor = System.Drawing.Color.White;
            this.lblSifreTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreTick.Location = new System.Drawing.Point(673, 273);
            this.lblSifreTick.Name = "lblSifreTick";
            this.lblSifreTick.Size = new System.Drawing.Size(0, 29);
            this.lblSifreTick.TabIndex = 9;
            // 
            // lblPostaTick
            // 
            this.lblPostaTick.AutoSize = true;
            this.lblPostaTick.BackColor = System.Drawing.Color.White;
            this.lblPostaTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPostaTick.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPostaTick.Location = new System.Drawing.Point(672, 201);
            this.lblPostaTick.Name = "lblPostaTick";
            this.lblPostaTick.Size = new System.Drawing.Size(0, 29);
            this.lblPostaTick.TabIndex = 10;
            // 
            // labelGoz
            // 
            this.labelGoz.AutoSize = true;
            this.labelGoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGoz.Location = new System.Drawing.Point(735, 268);
            this.labelGoz.Name = "labelGoz";
            this.labelGoz.Size = new System.Drawing.Size(0, 32);
            this.labelGoz.TabIndex = 11;
            // 
            // btnGozAc
            // 
            this.btnGozAc.BackColor = System.Drawing.Color.White;
            this.btnGozAc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGozAc.BackgroundImage")));
            this.btnGozAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGozAc.Location = new System.Drawing.Point(708, 268);
            this.btnGozAc.Name = "btnGozAc";
            this.btnGozAc.Size = new System.Drawing.Size(40, 34);
            this.btnGozAc.TabIndex = 14;
            this.btnGozAc.TabStop = false;
            this.btnGozAc.Click += new System.EventHandler(this.btnGozAc_Click_1);
            // 
            // btnGözKapa
            // 
            this.btnGözKapa.BackColor = System.Drawing.Color.White;
            this.btnGözKapa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGözKapa.BackgroundImage")));
            this.btnGözKapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGözKapa.Location = new System.Drawing.Point(708, 268);
            this.btnGözKapa.Name = "btnGözKapa";
            this.btnGözKapa.Size = new System.Drawing.Size(40, 34);
            this.btnGözKapa.TabIndex = 15;
            this.btnGözKapa.TabStop = false;
            this.btnGözKapa.Click += new System.EventHandler(this.btnGözKapa_Click_1);
            // 
            // FormGirisYap
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 668);
            this.Controls.Add(this.btnGözKapa);
            this.Controls.Add(this.btnGozAc);
            this.Controls.Add(this.labelGoz);
            this.Controls.Add(this.lblPostaTick);
            this.Controls.Add(this.lblSifreTick);
            this.Controls.Add(this.labeltick);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxŞifre);
            this.Controls.Add(this.tbxKullanıcıadı);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGirisYap";
            this.Load += new System.EventHandler(this.FormGirisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGozAc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGözKapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKullanıcıadı;
        private System.Windows.Forms.TextBox tbxŞifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labeltick;
        private System.Windows.Forms.Label lblSifreTick;
        private System.Windows.Forms.Label lblPostaTick;
        private System.Windows.Forms.Label labelGoz;
        private System.Windows.Forms.PictureBox btnGozAc;
        private System.Windows.Forms.PictureBox btnGözKapa;
    }
}