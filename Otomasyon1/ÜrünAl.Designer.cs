namespace Otomasyon1
{
    partial class FormÜrünAl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÜrünAl));
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet1 = new Otomasyon1.MainDataSet1();
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.Labelİsim = new System.Windows.Forms.Label();
            this.tbxAçıklama = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productsTableAdapter = new Otomasyon1.MainDataSet1TableAdapters.ProductsTableAdapter();
            this.btnSatınAl = new System.Windows.Forms.Button();
            this.tbxAlÜrünİsmi = new System.Windows.Forms.TextBox();
            this.tbxAlınacakÜrünAdedi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDoviz = new System.Windows.Forms.GroupBox();
            this.labelEuroAlis = new System.Windows.Forms.Label();
            this.labelDolarAlis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxDoviz.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1204, 12);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(162, 45);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 92);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1093, 256);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.mainDataSet1;
            // 
            // mainDataSet1
            // 
            this.mainDataSet1.DataSetName = "MainDataSet1";
            this.mainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxAra
            // 
            this.tbxAra.Location = new System.Drawing.Point(923, 12);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(158, 30);
            this.tbxAra.TabIndex = 16;
            this.tbxAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 17;
            this.label4.Tag = "";
            this.label4.Text = "Ara ";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // Labelİsim
            // 
            this.Labelİsim.AutoSize = true;
            this.Labelİsim.Location = new System.Drawing.Point(502, 50);
            this.Labelİsim.Name = "Labelİsim";
            this.Labelİsim.Size = new System.Drawing.Size(42, 23);
            this.Labelİsim.TabIndex = 18;
            this.Labelİsim.Text = "İsim";
            // 
            // tbxAçıklama
            // 
            this.tbxAçıklama.Enabled = false;
            this.tbxAçıklama.Location = new System.Drawing.Point(867, 434);
            this.tbxAçıklama.Multiline = true;
            this.tbxAçıklama.Name = "tbxAçıklama";
            this.tbxAçıklama.Size = new System.Drawing.Size(191, 116);
            this.tbxAçıklama.TabIndex = 19;
            this.tbxAçıklama.Text = "Açıklama:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSatınAl
            // 
            this.btnSatınAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSatınAl.Location = new System.Drawing.Point(156, 198);
            this.btnSatınAl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSatınAl.Name = "btnSatınAl";
            this.btnSatınAl.Size = new System.Drawing.Size(183, 33);
            this.btnSatınAl.TabIndex = 1;
            this.btnSatınAl.Text = "Satın Al";
            this.btnSatınAl.UseVisualStyleBackColor = false;
            this.btnSatınAl.Click += new System.EventHandler(this.btnSatınAl_Click);
            // 
            // tbxAlÜrünİsmi
            // 
            this.tbxAlÜrünİsmi.Location = new System.Drawing.Point(156, 43);
            this.tbxAlÜrünİsmi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAlÜrünİsmi.Name = "tbxAlÜrünİsmi";
            this.tbxAlÜrünİsmi.Size = new System.Drawing.Size(183, 30);
            this.tbxAlÜrünİsmi.TabIndex = 2;
            this.tbxAlÜrünİsmi.TextChanged += new System.EventHandler(this.tbxAlÜrünİsmi_TextChanged);
            // 
            // tbxAlınacakÜrünAdedi
            // 
            this.tbxAlınacakÜrünAdedi.Location = new System.Drawing.Point(156, 124);
            this.tbxAlınacakÜrünAdedi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAlınacakÜrünAdedi.Name = "tbxAlınacakÜrünAdedi";
            this.tbxAlınacakÜrünAdedi.Size = new System.Drawing.Size(183, 30);
            this.tbxAlınacakÜrünAdedi.TabIndex = 7;
            this.tbxAlınacakÜrünAdedi.TextChanged += new System.EventHandler(this.tbxAlınacakÜrünAdedi_TextChanged);
            this.tbxAlınacakÜrünAdedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAlınacakÜrünAdedi_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tbxAlÜrünİsmi);
            this.groupBox1.Controls.Add(this.btnSatınAl);
            this.groupBox1.Controls.Add(this.tbxAlınacakÜrünAdedi);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(300, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 261);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Al";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 26);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün ismi  :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 25);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün adedi:";
            // 
            // groupBoxDoviz
            // 
            this.groupBoxDoviz.Controls.Add(this.labelEuroAlis);
            this.groupBoxDoviz.Controls.Add(this.labelDolarAlis);
            this.groupBoxDoviz.Controls.Add(this.label5);
            this.groupBoxDoviz.Controls.Add(this.label3);
            this.groupBoxDoviz.Location = new System.Drawing.Point(1, 421);
            this.groupBoxDoviz.Name = "groupBoxDoviz";
            this.groupBoxDoviz.Size = new System.Drawing.Size(272, 100);
            this.groupBoxDoviz.TabIndex = 21;
            this.groupBoxDoviz.TabStop = false;
            this.groupBoxDoviz.Text = "Döviz";
            // 
            // labelEuroAlis
            // 
            this.labelEuroAlis.AutoSize = true;
            this.labelEuroAlis.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuroAlis.Location = new System.Drawing.Point(97, 65);
            this.labelEuroAlis.Name = "labelEuroAlis";
            this.labelEuroAlis.Size = new System.Drawing.Size(28, 30);
            this.labelEuroAlis.TabIndex = 3;
            this.labelEuroAlis.Text = "...";
            this.labelEuroAlis.Click += new System.EventHandler(this.labelEuroAlis_Click);
            // 
            // labelDolarAlis
            // 
            this.labelDolarAlis.AutoSize = true;
            this.labelDolarAlis.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolarAlis.Location = new System.Drawing.Point(97, 30);
            this.labelDolarAlis.Name = "labelDolarAlis";
            this.labelDolarAlis.Size = new System.Drawing.Size(28, 30);
            this.labelDolarAlis.TabIndex = 2;
            this.labelDolarAlis.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Euro Alış :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dolar Alış :";
            // 
            // FormÜrünAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 668);
            this.Controls.Add(this.groupBoxDoviz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxAçıklama);
            this.Controls.Add(this.Labelİsim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormÜrünAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Al";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxDoviz.ResumeLayout(false);
            this.groupBoxDoviz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.Label label4;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label Labelİsim;
        private System.Windows.Forms.TextBox tbxAçıklama;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MainDataSet1 mainDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MainDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btnSatınAl;
        private System.Windows.Forms.TextBox tbxAlÜrünİsmi;
        private System.Windows.Forms.TextBox tbxAlınacakÜrünAdedi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDoviz;
        private System.Windows.Forms.Label labelEuroAlis;
        private System.Windows.Forms.Label labelDolarAlis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}