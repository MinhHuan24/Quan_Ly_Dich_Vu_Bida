using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_DV_Bida.Class;


namespace QL_DV_Bida
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }

        public bool checkAccount(string ac) // check mk and tk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_]{3,20}@gmail.com(.vn|)$");
        }


        Modify modify = new Modify();
        private void btndangky_Click(object sender, EventArgs e)
        {
            string tentk = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            string xnmatkhau = txtxacnhanmatkhau.Text;
            string email = txtemail.Text;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhap tên tài khoan dài 6-24 ký tu, voi các ký tu chu và so, chu hoa và chu thuong! "); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6-24 ký t?, voi các ký tu chu và so, chu hoa và chu thuong! "); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if ((modify.TaiKhoans("select * from TaiKhoan where email = '" + email + "'").Count != 0))
            { MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!, vui lòng đăng ký tên tài khoản khác!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co that su muon thoat chuong trinh?", "Thong bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
