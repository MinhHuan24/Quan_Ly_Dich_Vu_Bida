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

namespace QL_DV_Bida
{
    public partial class frmOderDV : Form
    {
        public frmOderDV()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        public void connect()
        {
            string strcon = "Data Source=DESKTOP-5TIU7BH;Initial Catalog=Oder_DV;Integrated Security=True;";
            try
            {
                conn = new SqlConnection(strcon);
                conn.Open();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không kết nối được CSDL", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string[] LoaiBan = new string[] { "Pool", "Libre", "Carom 3c" };
        string[] TenBan = new string[] { "B1", "B2", "B3", "B4", "B5" };
        DataTable tbOder;
        public DataTable getDSNuoc()
        {
            string strSQL = "Select * from Table_Nuoc";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset);
                return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        public DataTable getDSMonAn()
        {
            string strSQL = "Select * from Table_MonAn";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset);
                return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        public DataTable getDSDichVuKhac()
        {
            string strSQL = "Select * from Table_DichVuKhac";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(strSQL, conn);
            DataSet dataset = new DataSet();
            try
            {
                adapter.Fill(dataset);
                return dataset.Tables[0];
            }
            catch
            {
                return null;
            }
        }
        private void frmOderDV_Load(object sender, EventArgs e)
        {
            connect();
            cbbLoaiBan.Items.AddRange(LoaiBan);
            cbbTenBan.Items.AddRange(TenBan);
            tbOder = new DataTable();
            // table có 2 cột
            tbOder.Columns.Add("Dich Vu");
            tbOder.Columns.Add("So Luong");
            // add dữ liệu vào cbb Nước
            DataTable table_Nuoc = getDSNuoc();
            if (table_Nuoc != null)
            {
                cbbNuoc.Items.Add("Hãy chọn");
                foreach (DataRow row in table_Nuoc.Rows)
                {
                    cbbNuoc.Items.Add(row["Nuoc"]);
                }
            }
            //mac dinh
            cbbNuoc.SelectedIndex = 0;

            // add dữ liệu vào cbb Món ăn
            DataTable table_MonAn = getDSMonAn();
            if (table_MonAn != null)
            {
                cbbMonAn.Items.Add("Hãy chọn");
                foreach (DataRow row in table_MonAn.Rows)
                {
                    cbbMonAn.Items.Add(row["MonAn"]);
                }
            }
            //mac dinh
            cbbMonAn.SelectedIndex = 0;

            // add dữ liệu vào cbb dịch vụ khác
            DataTable table_DichVuKhac = getDSDichVuKhac();
            if (table_DichVuKhac != null)
            {
                // them hay chon vao muc dau tien cua ComboBox
                cbbSP_Khac.Items.Add("Hãy chọn");
                foreach (DataRow row in table_DichVuKhac.Rows)
                {
                    cbbSP_Khac.Items.Add(row["DichVuKhac"]);
                }
            }
            //mac dinh
            cbbSP_Khac.SelectedIndex = 0;

            // add table vào dataGridView
            dgvOder.DataSource = tbOder;

            // định dạng 2 cột
            dgvOder.Columns[0].Width = (int)(dgvOder.Width * 0.5);
            dgvOder.Columns[1].Width = (int)(dgvOder.Width * 0.4);
        }
        //
        private void cbbLoaiBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbLoaiBan.SelectedItem.ToString());
        }
        //
        private void cbbTenBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbTenBan.SelectedItem.ToString());
        }
        private void cbbNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Kiểm tra xem có mục nào được chọn
            if (comboBox.SelectedIndex != 0)
            {
                // ktra xem mục được chọn có phải là một chuỗi
                if (comboBox.SelectedItem is string selectedItem)
                {
                    bool itemExists = false;
                    // kiểm tra xem mục đã tồn tại hay chưa
                    foreach (DataRow row in tbOder.Rows)
                    {
                        if (row["Dich Vu"].ToString() == selectedItem)
                        {
                            // nếu mục đã tồn tại tăng số lượng lên 1
                            int currentQuantity = Convert.ToInt32(row["So Luong"]);
                            row["So Luong"] = currentQuantity + 1;
                            itemExists = true;
                            break;
                        }
                    }
                    if (!itemExists)
                    {
                        // nếu mục chưa tồn tại thêm một dòng mới vào DataTable với số lượng là 1
                        DataRow newRow = tbOder.NewRow();
                        newRow["Dich Vu"] = selectedItem;
                        newRow["So Luong"] = 1;
                        tbOder.Rows.Add(newRow);
                    }
                }
            }
        }
        private void cbbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Kiểm tra xem có mục nào được chọn
            if (comboBox.SelectedIndex != 0)
            {
                // ktra xem mục được chọn có phải là một chuỗi
                if (comboBox.SelectedItem is string selectedItem)
                {
                    bool itemExists = false;
                    // kiểm tra xem mục đã tồn tại hay chưa
                    foreach (DataRow row in tbOder.Rows)
                    {
                        if (row["Dich Vu"].ToString() == selectedItem)
                        {
                            // nếu mục đã tồn tại tăng số lượng lên 1
                            int currentQuantity = Convert.ToInt32(row["So Luong"]);
                            row["So Luong"] = currentQuantity + 1;
                            itemExists = true;
                            break;
                        }
                    }
                    if (!itemExists)
                    {
                        // nếu mục chưa tồn tại thêm một dòng mới vào DataTable với số lượng là 1
                        DataRow newRow = tbOder.NewRow();
                        newRow["Dich Vu"] = selectedItem;
                        newRow["So Luong"] = 1;
                        tbOder.Rows.Add(newRow);
                    }
                }
            }
        }
        private void cbbSP_Khac_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Kiểm tra xem có mục nào được chọn
            if (comboBox.SelectedIndex != 0)
            {
                // ktra xem mục được chọn có phải là một chuỗi
                if (comboBox.SelectedItem is string selectedItem)
                {
                    bool itemExists = false;
                    // kiểm tra xem mục đã tồn tại hay chưa
                    foreach (DataRow row in tbOder.Rows)
                    {
                        if (row["Dich Vu"].ToString() == selectedItem)
                        {
                            // nếu mục đã tồn tại tăng số lượng lên 1
                            int currentQuantity = Convert.ToInt32(row["So Luong"]);
                            row["So Luong"] = currentQuantity + 1;
                            itemExists = true;
                            break;
                        }
                    }
                    if (!itemExists)
                    {
                        // nếu mục chưa tồn tại thêm một dòng mới vào DataTable với số lượng là 1
                        DataRow newRow = tbOder.NewRow();
                        newRow["Dich Vu"] = selectedItem;
                        newRow["So Luong"] = 1;
                        tbOder.Rows.Add(newRow);
                    }
                }
            }
        }
        private void InsertDataToDatabase()
        {
            try
            {
                conn.Open();
                foreach (DataRow row in tbOder.Rows)
                {
                    string dichVu = row["Dich Vu"].ToString();
                    int soLuong = Convert.ToInt32(row["So Luong"]);
                    //INSERT để thêm dữ liệu vào cơ sở dữ liệu
                    string sql = "INSERT INTO PhieuDV (DichVu, SoLuong) VALUES (@DichVu, @SoLuong)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DichVu", dichVu);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu vào cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private int GetNewMaPhieuDV()
        {
            int maPhieuDV = 0;
            try
            {
                conn.Open();
                // lấy ra mã phiếu dịch vụ mới
                string sql = "SELECT MAX(MaPhieuDV) FROM PhieuDV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    maPhieuDV = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã phiếu dịch vụ mới: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return maPhieuDV + 1;
        }
        private void btnOder_Click(object sender, EventArgs e)
        {          
            InsertDataToDatabase();          
            int maPhieuDV = GetNewMaPhieuDV();           
            MessageBox.Show("Mã phiếu dịch vụ mới: " + maPhieuDV.ToString());
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {        
            for (int i = tbOder.Rows.Count - 1; i >= 0; i--)
            {                
                if (dgvOder.Rows[i].Selected)
                {                  
                    tbOder.Rows.RemoveAt(i);
                }
            }
            dgvOder.Refresh();
        }
    }
}
