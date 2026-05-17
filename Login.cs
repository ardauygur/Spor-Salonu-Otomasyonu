using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sporSalonu
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDUYG\\SQLEXPRESS02;Initial Catalog=SporSalonuDB;Integrated Security=True;Encrypt=False");
        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            kullaniciAdiLbl.Parent = arkaPlanPb;
            sifreLbl.Parent = arkaPlanPb;
            girisYapBtn.Parent = arkaPlanPb;
            kullaniciAdTxt.Parent = arkaPlanPb;
            sifreTxt.Parent = arkaPlanPb;
            logoPb.Parent = arkaPlanPb;
            this.AcceptButton = girisYapBtn;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdTxt.Text;
            string sifre = sifreTxt.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Personel WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre", baglanti);
            komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);
            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                baglanti.Close();
                AnaForm anaForm = new AnaForm();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                reader.Close();
                baglanti.Close();
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                kullaniciAdTxt.Text = "";
                sifreTxt.Text = "";
                kullaniciAdTxt.Focus();
            }
        }
    }
}
