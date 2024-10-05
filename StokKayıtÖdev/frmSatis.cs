using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokKayıtÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Data Source=DESKTOP-FBG2IBT;Initial Catalog=Stok;Integrated Security=True;";

        private void button1_Click(object sender, EventArgs e)
        {
            //Ekle
            string t1 = textBox1.Text; //malzemeKodu
            string t2 = textBox2.Text; //MalzemeAdi
            string t3 = textBox3.Text; //YillikSatiş
            string t4 = textBox4.Text; //BirimFiyat
            string t5 = textBox5.Text; //MiniStok
            string t6 = textBox6.Text; //TeminSuresi

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Malzemeler (MalzemeKodu, MalzemeAdi, YillikSatiş, BirimFiyat, MiniStok, TeminSuresi) VALUES (@MalzemeKodu, @MalzemeAdi, @YillikSatiş, @BirimFiyat, @MiniStok, @TeminSuresi)";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@MalzemeKodu", t1);
                komut.Parameters.AddWithValue("@MalzemeAdi", t2);
                komut.Parameters.AddWithValue("@YillikSatiş", t3);
                komut.Parameters.AddWithValue("@BirimFiyat", t4);
                komut.Parameters.AddWithValue("@MiniStok", t5);
                komut.Parameters.AddWithValue("@TeminSuresi", t6);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele(); //veri tabanındaki kayıtları güncel bir şekilde göstermek için
        }

        private void listele() //veri tabanındaki kayıtları güncel bir şekilde göstermek için
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Malzemeler", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo; //veri kaynağının tablo olduğunu göstermek
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text; //seçilen satırın malzeme kodu

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Malzemeler WHERE MalzemeKodu = @MalzemeKodu";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@MalzemeKodu", t1);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }

            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text; //malzeme kodu
            string t2 = textBox2.Text; //MalzemeAdi
            string t3 = textBox3.Text; //YillikSatiş
            string t4 = textBox4.Text; //BirimFiyat
            string t5 = textBox5.Text; //MinStok
            string t6 = textBox6.Text; //TeminSuresi

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                string query = "UPDATE Malzemeler SET MalzemeAdi = @MalzemeAdi, YillikSatiş = @YillikSatiş, BirimFiyat = @BirimFiyat, MiniStok = @MiniStok, TeminSuresi = @TeminSuresi WHERE MalzemeKodu = @MalzemeKodu";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@MalzemeKodu", t1);
                komut.Parameters.AddWithValue("@MalzemeAdi", t2);
                komut.Parameters.AddWithValue("@YillikSatiş", t3);
                komut.Parameters.AddWithValue("@BirimFiyat", t4);
                komut.Parameters.AddWithValue("@MiniStok", t5);
                komut.Parameters.AddWithValue("@TeminSuresi", t6);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }

            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MüşteriBilgileri form = new MüşteriBilgileri();
            form.Show();
            this.Hide();
        }
    }
}
