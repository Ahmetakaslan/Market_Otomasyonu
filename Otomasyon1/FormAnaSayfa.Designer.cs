namespace Otomasyon1
{
    partial class FormAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.Al = new System.Windows.Forms.Button();
            this.Sat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDolarAlis = new System.Windows.Forms.Label();
            this.labelEuroAlis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Al
            // 
            this.Al.BackColor = System.Drawing.Color.Fuchsia;
            this.Al.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Al.Location = new System.Drawing.Point(464, 157);
            this.Al.Name = "Al";
            this.Al.Size = new System.Drawing.Size(166, 86);
            this.Al.TabIndex = 0;
            this.Al.Text = "Al";
            this.Al.UseVisualStyleBackColor = false;
            this.Al.Click += new System.EventHandler(this.Al_Click);
            this.Al.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Al_KeyDown);
            // 
            // Sat
            // 
            this.Sat.BackColor = System.Drawing.Color.Fuchsia;
            this.Sat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sat.Location = new System.Drawing.Point(464, 372);
            this.Sat.Name = "Sat";
            this.Sat.Size = new System.Drawing.Size(166, 86);
            this.Sat.TabIndex = 1;
            this.Sat.Text = "Sat";
            this.Sat.UseVisualStyleBackColor = false;
            this.Sat.Click += new System.EventHandler(this.Sat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(45, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dolar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Euro : ";
            // 
            // labelDolarAlis
            // 
            this.labelDolarAlis.AutoSize = true;
            this.labelDolarAlis.Location = new System.Drawing.Point(114, 84);
            this.labelDolarAlis.Name = "labelDolarAlis";
            this.labelDolarAlis.Size = new System.Drawing.Size(25, 22);
            this.labelDolarAlis.TabIndex = 4;
            this.labelDolarAlis.Text = "...";
            this.labelDolarAlis.Click += new System.EventHandler(this.labelDolarAlis_Click);
            // 
            // labelEuroAlis
            // 
            this.labelEuroAlis.AutoSize = true;
            this.labelEuroAlis.Location = new System.Drawing.Point(114, 127);
            this.labelEuroAlis.Name = "labelEuroAlis";
            this.labelEuroAlis.Size = new System.Drawing.Size(25, 22);
            this.labelEuroAlis.TabIndex = 5;
            this.labelEuroAlis.Text = "...";
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 668);
            this.Controls.Add(this.labelEuroAlis);
            this.Controls.Add(this.labelDolarAlis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sat);
            this.Controls.Add(this.Al);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnaSayfa";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Al;
        private System.Windows.Forms.Button Sat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDolarAlis;
        private System.Windows.Forms.Label labelEuroAlis;
    }
}