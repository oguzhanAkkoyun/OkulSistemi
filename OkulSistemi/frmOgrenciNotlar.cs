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
    public partial class frmOgrenciNotlar : Form
    {
        public frmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=OGUZHAN\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
        public string number;
        private void frmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT DersAd, Sınav1, Sınav2, Sınav3, Proje, Ortalama, Durum FROM Tbl_Notlar INNER JOIN Tbl_Dersler ON Tbl_Notlar.DersID = Tbl_Dersler.DersID WHERE OgrID=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", number);
            //this.Text = number.ToString();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
