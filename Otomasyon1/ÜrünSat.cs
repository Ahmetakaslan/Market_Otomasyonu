using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otomasyon1
{
    
    public partial class FormÜrünSat : Form
    {
        public string isimUrunSat;
        public FormÜrünSat()
        {
            InitializeComponent();
        }
        ProductDal productdal = new ProductDal();
        public void Dondur()
        {
            dataGridView1.DataSource = productdal.GetAll();
        }
        private void Form1_Load(object sender , EventArgs e)
        {
            richTextBox1.Enabled = true;
            Labelİsim.Text = isimUrunSat;
            Dondur();
        }

        private void button1_Click(object sender , EventArgs e)
        {
            productdal.Add(new Products
            {
                Name = tbxÜrünİsmi.Text ,
                UnitPrice = Convert.ToDecimal(tbxfiyat.Text) ,
                StockAmount = Convert.ToInt32(tbxürünadedi.Text),
                Explain= richTextBox1.Text.ToString()
               
            }); ;
            dataGridView1.DataSource=productdal.GetAll();
            MessageBox.Show("Ürününüz eklendi");
        }

        private void btnGüncelle_Click(object sender , EventArgs e)
        {
            productdal.Update(new Products
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = tbxgücelleÜrünİsmi.Text ,
                UnitPrice = Convert.ToDecimal(tbxgücelleÜrünFiyatı.Text) ,
                StockAmount = Convert.ToInt32(tbxgüncelleÜrünAdedi.Text),
                Explain=richTextBox1.Text
            });
            Dondur();
            MessageBox.Show("Ürün güncellendi");
        }
        public void Equal()
        {
            tbxgücelleÜrünİsmi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxgücelleÜrünFiyatı.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxgüncelleÜrünAdedi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
          
        }

    

        private void dataGridView1_CellClick(object sender , DataGridViewCellEventArgs e)
        {
            Equal();
        }

        private void btnSil_Click(object sender , EventArgs e)
        {
            productdal.Delete(new Products
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
  
            });
            Dondur();
            MessageBox.Show("Ürün Silindi");
        }

        private void richTextBox1_TextChanged(object sender , EventArgs e)
        {
            
        }

        private void tbxürünadedi_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
              )
            {
                e.Handled = true;
            }

    
        
        }

        private void tbxgüncelleÜrünAdedi_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
          )
            {
                e.Handled = true;
            }

        }

     

        private void tbxgücelleÜrünFiyatı_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void tbxfiyat_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void labelControl1_Click(object sender , EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender , EventArgs e)
        {

        }

        private void tbxürünadedi_KeyPress_1(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxfiyat_KeyPress_1(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxgüncelleÜrünAdedi_KeyPress_1(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxgücelleÜrünFiyatı_KeyPress_1(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnEkle_Click(object sender , EventArgs e)
        {
            productdal.Add(new Products
            {
                Name = tbxÜrünİsmi.Text ,
                UnitPrice = Convert.ToDecimal(tbxfiyat.Text) ,
                StockAmount = Convert.ToInt32(tbxürünadedi.Text) ,
                Explain = richTextBox1.Text.ToString()

            }); ;
            dataGridView1.DataSource = productdal.GetAll();
            MessageBox.Show("Ürününüz eklendi");

        }

        private void btnGüncelle_Click_1(object sender , EventArgs e)
        {
            productdal.Update(new Products
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) ,
                Name = tbxgücelleÜrünİsmi.Text ,
                UnitPrice = Convert.ToDecimal(tbxgücelleÜrünFiyatı.Text) ,
                StockAmount = Convert.ToInt32(tbxgüncelleÜrünAdedi.Text) ,
                Explain = richTextBox1.Text
            });
            Dondur();
            MessageBox.Show("Ürün güncellendi");
        }
    }
}
