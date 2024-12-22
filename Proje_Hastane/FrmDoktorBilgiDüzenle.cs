using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        public string tc;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tc;
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p4 Where DoktorTC=@p5", bgl.baglanti());
            
            kmt.Parameters.AddWithValue("@p1", txtAd.Text);
            kmt.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kmt.Parameters.AddWithValue("@p3", cmbBrans.Text);
            kmt.Parameters.AddWithValue("@p4", txtSifre.Text);
            kmt.Parameters.AddWithValue("@p5", mskTC.Text);

            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
