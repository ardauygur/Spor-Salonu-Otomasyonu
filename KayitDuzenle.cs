using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace sporSalonu
{
    public partial class KayitDuzenle : Form
    {
        public KayitDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDUYG\\SQLEXPRESS02;Initial Catalog=SporSalonuDB;Integrated Security=True;Encrypt=False");

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Close();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Uyeler WHERE TC=@tc", baglanti);
            cmd.Parameters.AddWithValue("@tc", tcMtb.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye bilgileri başarıyla silindi!");
            this.uyelerTableAdapter.Fill(this.sporSalonuDBDataSet1.Uyeler);

            adTxt.Text = "";
            soyadTxt.Text = "";
            tcMtb.Text = "";
            telefonMtb.Text = "";
            yasTxt.Text = "";
            ucretTxt.Text = "";
            adresTxt.Text = "";
            cinsiyetCmb.SelectedIndex = 0;
            kanGrubuCmb.SelectedIndex = 0;
            uyelikTuruCmb.SelectedIndex = 0;
            kayitTarihiDtp.Value = DateTime.Today;
            adTxt.Focus();
        }

        private void KayitDuzenle_Load(object sender, EventArgs e)
        {
            sporSalonuDBDataSet1.EnforceConstraints = false;
            this.uyelerTableAdapter.Fill(this.sporSalonuDBDataSet1.Uyeler);
            logoPb.Parent = arkaPlanPb;
            baslikLbl.Parent = arkaPlanPb;
            label0.Parent = kayitGroupBox;
            label1.Parent = kayitGroupBox;
            label2.Parent = kayitGroupBox;
            label3.Parent = kayitGroupBox;
            label4.Parent = kayitGroupBox;
            label5.Parent = kayitGroupBox;
            label6.Parent = kayitGroupBox;
            label7.Parent = kayitGroupBox;
            label8.Parent = kayitGroupBox;
            label9.Parent = kayitGroupBox;
            label10.Parent = kayitGroupBox;
            kayitGroupBox.Parent = arkaPlanPb;

            cinsiyetCmb.SelectedIndex = 0;
            kanGrubuCmb.SelectedIndex = 0;
            uyelikTuruCmb.SelectedIndex = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tcMtb.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); // TC
            adTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); // Ad
            soyadTxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString(); // Soyad
            telefonMtb.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); // Telefon
            yasTxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); // Yas
            cinsiyetCmb.SelectedItem = dataGridView1.Rows[secilen].Cells[5].Value.ToString(); // Cinsiyet
            adresTxt.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); // Adres
            kanGrubuCmb.SelectedItem = dataGridView1.Rows[secilen].Cells[7].Value.ToString(); // KanGrubu
            ucretTxt.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString(); // Ucret
            kayitTarihiDtp.Value = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[9].Value); // KayitTarihi
            uyelikTuruCmb.SelectedItem = dataGridView1.Rows[secilen].Cells[10].Value.ToString(); // UyelikTuru
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Uyeler SET Ad=@ad, Soyad=@soyad, Telefon=@telefon, Yas=@yas, Cinsiyet=@cinsiyet, " +
                "Adres=@adres, KanGrubu=@kanGrubu, Ucret=@ucret, KayitTarihi=@kayitTarihi, UyelikTuru=@uyelikTuru WHERE TC=@tc", baglanti);

            komut.Parameters.AddWithValue("@ad", adTxt.Text);
            komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            komut.Parameters.AddWithValue("@telefon", telefonMtb.Text);
            komut.Parameters.AddWithValue("@yas", Convert.ToInt32(yasTxt.Text));
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyetCmb.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@adres", adresTxt.Text);
            komut.Parameters.AddWithValue("@kanGrubu", kanGrubuCmb.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@ucret", Convert.ToDecimal(ucretTxt.Text));
            komut.Parameters.AddWithValue("@kayitTarihi", kayitTarihiDtp.Value);
            komut.Parameters.AddWithValue("@uyelikTuru", uyelikTuruCmb.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@tc", tcMtb.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Üye bilgileri başarıyla güncellendi!");
            this.uyelerTableAdapter.Fill(this.sporSalonuDBDataSet1.Uyeler);


        }
    }
    
}
