using QL_DV_Bida.Class;

namespace QL_DV_Bida
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void link_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau frmQuenMatKhau = new frmQuenMatKhau();
            this.Hide();
            frmQuenMatKhau.ShowDialog();
            this.Show();
        }
        Modify modify = new Modify();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui long nhap lai tai khoan!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui long nhap lai mat khau!"); }
            else
            {
                string query = "Select * from Taikhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Dang nhap thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTrangChu trangChu = new frmTrangChu();
                    this.Hide();
                    trangChu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Ten tai khoan hoac mat khau khong chinh xac!");
                }
            }
        }
        private void link_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKi dangKi = new frmDangKi();
            this.Hide();
            dangKi.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co that su muon thoat chuong trinh?", "Thong bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
