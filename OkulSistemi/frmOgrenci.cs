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

namespace OkulSistemi
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=OGUZHAN\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");

        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Kulupler", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            cmbKulubu.DisplayMember = "KulupAd";
            cmbKulubu.ValueMember = "KulupID";
            cmbKulubu.DataSource = dt;
            conn.Close();
        }

        string c = "";

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
    

            ds.OgrenciEkle(txtAd.Text, txtSoyad.Text, byte.Parse(cmbKulubu.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci ekleme yapıldı.");
        }

        private void btnDersListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void cmbKulubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = cmbKulubu.SelectedValue.ToString();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtID.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbKulubu.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[3].Value.Equals("Kadın"))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton1.Checked= false;
            }
            if (dataGridView1.CurrentRow.Cells[3].Value.Equals("Erkek"))
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton2.Checked = false;
            }
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(txtAd.Text,txtSoyad.Text, byte.Parse(cmbKulubu.SelectedValue.ToString()), c, int.Parse(txtID.Text));
            MessageBox.Show("Öğrenci güncelleme işlemi yapıldı.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                c = "Kadın";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ds.OgrenciGetir(txtAra.Text);
        }
    }
}
