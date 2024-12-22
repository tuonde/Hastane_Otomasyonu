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

namespace Proje_Hastane
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları ComboBox'a Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Insert Into Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            
            kmt.Parameters.AddWithValue("@p1", txtAd.Text);
            kmt.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kmt.Parameters.AddWithValue("@p3", cmbBrans.Text);
            kmt.Parameters.AddWithValue("@p4", mskTC.Text);
            kmt.Parameters.AddWithValue("@p5", txtSifre.Text);

            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Delete From Tbl_Doktorlar Where DoktorTc = @p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", mskTC.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p5 Where DoktorTc=@p4", bgl.baglanti());

            kmt.Parameters.AddWithValue("@p1", txtAd.Text);
            kmt.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kmt.Parameters.AddWithValue("@p3", cmbBrans.Text);
            kmt.Parameters.AddWithValue("@p4", mskTC.Text);
            kmt.Parameters.AddWithValue("@p5", txtSifre.Text);

            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
