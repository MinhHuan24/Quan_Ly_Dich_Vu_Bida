using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


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
            return Regex.IsMatch(em,@"^[a-zA-Z0-9_]{3,20}@gmail.com(.vn|)$");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Modify modify = new Modify();
        private void btndangky_Click(object sender, EventArgs e)
        {
            string tentk = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            string xnmatkhau = txtxacnhanmatkhau.Text;
            string email = txtemail.Text;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui l�ng nhap t�n t�i khoan d�i 6-24 k� tu, voi c�c k� tu chu v� su, chu hoa v� chu thuong! "); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui l�ng nh?p t�n m?t kh?u d�i 6-24 k� t?, v?i c�c k� t? ch? v� s?, ch?u hoa v� ch? th??ng! "); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui l�ng x�c nh?n m?t kh?u ch�nh x�c!"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui l�ng nh?p ?�ng ??nh d?ng email!"); return; }
            if ((modify.TaiKhoans("select * from TaiKhoan where email = '" + email + "'").Count != 0))
                { MessageBox.Show("Email n�y ?� ???c ??ng k�, vui l�ng ??ng k� email kh�c"); return; }
            try
                {
                string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                    modify.Command(query);
                    if (MessageBox.Show("??ng k� th�nh c�ng! B?n �c mu?n ??ng nh?p lu�n kh�ng?", "Th�ng b�o", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("T�n t�i kho?n n�y ?� ???c ??ng k�!, vui l�ng ??ng k� t�n t�i kho?n kh�c!");
                }
        }
       
    }
}
