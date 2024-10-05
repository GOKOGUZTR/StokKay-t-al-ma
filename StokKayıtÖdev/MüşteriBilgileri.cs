using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokKayıtÖdev
{
    public partial class MüşteriBilgileri : Form
    {
        public MüşteriBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FBG2IBT;Initial Catalog=VERİALMA1234;Integrated Security=True");
        private void btnMüşteriEkleme_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("insert into müşteri1234(tc,[ad soyad],telefon, adres, email) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komutlar.Parameters.AddWithValue("@p1", txtTc.Text); 
            komutlar.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komutlar.Parameters.AddWithValue("@p3", txtTelefon.Text);
            komutlar.Parameters.AddWithValue("@p4", textBox1.Text);
            komutlar.Parameters.AddWithValue("@p5", textBox2.Text);
            komutlar.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt gerçekleşti");

        }

        private void MüşteriBilgileri_Load(object sender, EventArgs e)
        {
            //  Bu kod satırı 'vERİALMA1234DataSet3.müşteri1234' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilir.
            this.müşteri1234TableAdapter1.Fill(this.vERİALMA1234DataSet3.müşteri1234);
            



        }

        private void Listele_Click(object sender, EventArgs e)
        {
            //  Bu kod satırı 'vERİALMA1234DataSet3.müşteri1234' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilir.
            this.müşteri1234TableAdapter1.Fill(this.vERİALMA1234DataSet3.müşteri1234);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}