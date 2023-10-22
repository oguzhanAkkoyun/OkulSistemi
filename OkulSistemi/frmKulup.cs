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

namespace OkulSistemi
{
    public partial class frmKulup : Form
    {
        public frmKulup()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=OGUZHAN\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
         void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Kulupler", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmKulup_Load(object sender, EventArgs e)
        {

            liste();
        }

        private void btnKulupListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btnKulupEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Kulupler (KulupAd) VALUES (@p1)", conn);
            cmd.Parameters.AddWithValue("@p1", txtKulupAd.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kulüp listeye eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            liste();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnKulupSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Kulupler WHERE KulupID=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", txtKulupId.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kulup silindi..");
            liste();

        }

        private void btnKulupGuncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Kulupler SET KulupAd=@p1 WHERE KulupID=@p2", conn);
            cmd.Parameters.AddWithValue("@p1", txtKulupAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtKulupId.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kulup güncellendi..");
            liste();
        }
    }
}
