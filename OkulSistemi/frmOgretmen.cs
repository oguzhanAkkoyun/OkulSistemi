using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulSistemi
{
    public partial class frmOgretmen : Form
    {
        public frmOgretmen()
        {
            InitializeComponent();
        }

        private void btnKulup_Click(object sender, EventArgs e)
        {
            frmKulup fr = new frmKulup();
            fr.Show();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            frmDersler fr = new frmDersler();
            fr.Show();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenci frm = new frmOgrenci();
            frm.Show();
        }

        private void btnSinav_Click(object sender, EventArgs e)
        {
            frmSinavIslemleri frm = new frmSinavIslemleri();
            frm.Show(); 
        }
    }
}
