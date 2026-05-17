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
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDUYG\\SQLEXPRESS02;Initial Catalog=SporSalonuDB;Integrated Security=True;Encrypt=False");
        private void YeniKayit_Load(object sender, EventArgs e)
        {
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

        private void temizleBtn_Click(object sender, EventArgs e)
        {
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

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Uyeler (TC, Ad, Soyad, Telefon, Yas, Cinsiyet, Adres, KanGrubu, Ucret, KayitTarihi, UyelikTuru) " +
                "VALUES (@tc, @ad, @soyad, @telefon, @yas, @cinsiyet, @adres, @kanGrubu, @ucret, @kayitTarihi, @uyelikTuru)", baglanti);
            komut.Parameters.AddWithValue("@tc", tcMtb.Text);
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
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye başarıyla eklendi!");
            temizleBtn_Click(sender, e);
        }

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Close();
        }
    }
}
