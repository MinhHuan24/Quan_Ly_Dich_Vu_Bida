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
            frmQuenMatKhau quenMatKhau = new frmQuenMatKhau();
            quenMatKhau.ShowDialog();
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
                    frmHome frmHome = new frmHome();
                    frmHome.ShowDialog();
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
            dangKi.ShowDialog();
        }
    }
}
