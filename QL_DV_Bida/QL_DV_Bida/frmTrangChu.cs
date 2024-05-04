using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DV_Bida
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmOderDV oderDV = new frmOderDV();
            this.Hide();
            oderDV.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDatBan DatBan = new frmDatBan();
            this.Hide();
            DatBan.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            this.Hide();
            frmDangNhap.ShowDialog();
            this.Show();
        }
    }
}
