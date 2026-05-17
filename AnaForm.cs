using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sporSalonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            logoPb.Parent = arkaPlanPb;
            baslikLbl.Parent = arkaPlanPb;
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            YeniKayit yeniKayit = new YeniKayit();
            yeniKayit.Show();
            this.Hide();
        }

        private void kayitGuncelleBtn_Click(object sender, EventArgs e)
        {
            KayitDuzenle kayitDuzenle = new KayitDuzenle();
            kayitDuzenle.Show();
            this.Hide();
        }
    }
}
