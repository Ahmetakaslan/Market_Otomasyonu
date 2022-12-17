using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Otomasyon1
{
    public partial class FormÜrünAl : Form
    {
        public string isimUrunAl;
        public FormÜrünAl()
        {
            InitializeComponent();
        }
        // BURADA ALINAN ÜRÜNLERİ VERİ TABANINA EKLEMEK İÇİN
        // KULLANICININ KİM OLDUĞUNU BULMAK İÇİN KULLANICI ADI VE ŞİFRESİNİ 
        // GİRİŞ SAYFASINDAN DEĞİŞKENE ATTADIM
        string girisKullanıcıAdı = FormGirisYap.tempKullanıcıAdı;
        string girisKullanıcıSifre = FormGirisYap.tempSifre;
        ProductDal productDal = new ProductDal();
        PersonDal person = new PersonDal();
        private void Form2_Load(object sender , EventArgs e)
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.tcmb.gov.tr/kurlar/today.xml");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());

                string data = reader.ReadToEnd();

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(data);
              //  string tarih = " /Tarih_Date";
             //   XmlNode node0 = xml.SelectSingleNode(tarih);
             //   DateTime dateTime = Convert.ToDateTime(xml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string dolarAlis = "/Tarih_Date/Currency[@Kod='USD']/ForexSelling";
                XmlNode node = xml.SelectSingleNode(dolarAlis);
                string euroAlis = "/Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
                XmlNode node2 = xml.SelectSingleNode(euroAlis);
              //  groupBoxDoviz.Text = dateTime.ToShortDateString();
                labelDolarAlis.Text = " Dolar Alış :" + node.InnerText;
                labelEuroAlis.Text = " Euro Aklış " + node2.InnerText;
            }catch (Exception s)
            {
                labelDolarAlis.Text = "Internetiniz kapalı";
                labelEuroAlis.Text = "Internetiniz kapalı";
            }

            // TODO: This line of code loads data into the 'mainDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mainDataSet1.Products);
            dataGridView2.ReadOnly = true;
                Labelİsim.Text = isimUrunAl;
                dataGridView2.DataSource = productDal.GetAll();
            
          
        }

        private void textBox1_TextChanged(object sender , EventArgs e)
        {
            dataGridView2.DataSource = productDal.Search(tbxAra.Text);
        }





        private void btnSatınAl_Click(object sender , EventArgs e)
        {
            {


                if (tbxAlınacakÜrünAdedi.Text.Equals("") || tbxAlÜrünİsmi.Text.Equals(""))
                {
                    MessageBox.Show("Lütfen Alanları Doldurunuz");
                }
                else
                {
                    FormGirisYap giriş = new FormGirisYap();
                    // isrue Aşağıda  kulllanılmak için yazıldı
                    bool istrue = false;
                    // burada var olan ürün alındığında stok azaltmak için kullanılıyor
                    int temp = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                    if (temp >= Convert.ToInt32(tbxAlınacakÜrünAdedi.Text))
                    {
                        ProductContext product = new ProductContext();
                        istrue = true;
                        int temp2 = Convert.ToInt32(tbxAlınacakÜrünAdedi.Text);
                        int id = product.Person.FirstOrDefault(p => p.Email.Equals(girisKullanıcıAdı) && p.Password.Equals(girisKullanıcıSifre)).Id;

                        person.Update(new Person
                        {
                            Id = product.Person.SingleOrDefault(p => p.Email.Equals(girisKullanıcıAdı) && p.Password.Equals(girisKullanıcıSifre)).Id ,
                            Name = product.Person.SingleOrDefault(p => p.Email.Equals(girisKullanıcıAdı) && p.Password.Equals(girisKullanıcıSifre)).Name ,
                            Email = girisKullanıcıAdı ,
                            Password = girisKullanıcıSifre ,
                            // burada Alinan ürünleri Artırmalyız
                            Piece = temp + product.Person.FirstOrDefault(p => p.Id.Equals(id)).Piece
                        });
                        temp -= temp2;
                    }
                    else
                    {// ürünün stokts bulunmaması durumunda
                        istrue = false;
                        MessageBox.Show("Üzgünüz belirtilen miktarda ürünümüz \n bulunmamaktadır");
                    }
                    if (istrue)
                    {
                        productDal.Update(new Products
                        {
                            Id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) ,
                            Name = dataGridView2.CurrentRow.Cells[1].Value.ToString() ,
                            UnitPrice = Convert.ToDecimal(dataGridView2.CurrentRow.Cells[2].Value) ,
                            StockAmount = temp
                        });
                        dataGridView2.DataSource = productDal.GetAll();
                        MessageBox.Show("Ürünü aldınız");

                    }
                }
            }


        }
        private void dataGridView2_CellClick(object sender , DataGridViewCellEventArgs e)
        {
            tbxAlÜrünİsmi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView2.CurrentCell.ColumnIndex == 4) { 
                if( dataGridView2.CurrentCell.Value != null )
                {
                    if (!dataGridView2.CurrentCell.Value.Equals(""))
                    {
                        tbxAçıklama.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    }
                    else
                    {
                        tbxAçıklama.Text = "";
                    }
                }
                    
                
            }
          
         

          
           
        }

        private void dataGridView2_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {
           
        }

        private void tbxAlınacakÜrünAdedi_TextChanged(object sender , EventArgs e)
        {

        }

        private void tbxAlınacakÜrünAdedi_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
         )
            {
                e.Handled = true;
            }

        }

        private void groupBox2_Enter(object sender , EventArgs e)
        {

        }

        private void labelEuroAlis_Click(object sender , EventArgs e)
        {

        }

        private void tbxAlÜrünİsmi_TextChanged(object sender , EventArgs e)
        {

        }
    }
}

