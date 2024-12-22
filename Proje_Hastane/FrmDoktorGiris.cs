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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", mskTC.Text);
            kmt.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.tc = mskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TCKN veya Şifre", "Giriş Yapılamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
