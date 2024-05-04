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
    public partial class frmDatBan : Form
    {
        public frmDatBan()
        {
            InitializeComponent();


            // Thêm các mục thể loại
            cmbTheLoai.SelectedIndexChanged += cmbTheLoai_SelectedIndexChanged_1;
            cmbTheLoai.Items.Add("Pool 50k/h");
            cmbTheLoai.Items.Add("Carom 60k/h");
            cmbTheLoai.Items.Add("Libre 70k/h");
            // Thêm các Chi Nhánh
            cmbChiNhanh.SelectedIndexChanged += cmbChiNhanh_SelectedIndexChanged_1;
            cmbChiNhanh.Items.Add("Chi nhánh A");
            cmbChiNhanh.Items.Add("Chi nhánh B");
            cmbChiNhanh.Items.Add("Chi nhánh C");
            // Thêm các giờ Bắt đầu 
            cmbTimeBatDau.Items.Add("00h");
            cmbTimeBatDau.Items.Add("01h");
            cmbTimeBatDau.Items.Add("02h");
            cmbTimeBatDau.Items.Add("03h");
            cmbTimeBatDau.Items.Add("04h");
            cmbTimeBatDau.Items.Add("05h");
            cmbTimeBatDau.Items.Add("06h");
            cmbTimeBatDau.Items.Add("07h");
            cmbTimeBatDau.Items.Add("08h");
            cmbTimeBatDau.Items.Add("09h");
            cmbTimeBatDau.Items.Add("10h");
            cmbTimeBatDau.Items.Add("11h");
            cmbTimeBatDau.Items.Add("12h");
            cmbTimeBatDau.Items.Add("13h");
            cmbTimeBatDau.Items.Add("14h");
            cmbTimeBatDau.Items.Add("15h");
            cmbTimeBatDau.Items.Add("16h");
            cmbTimeBatDau.Items.Add("17h");
            cmbTimeBatDau.Items.Add("18h");
            cmbTimeBatDau.Items.Add("19h");
            cmbTimeBatDau.Items.Add("20h");
            cmbTimeBatDau.Items.Add("21h");
            cmbTimeBatDau.Items.Add("22h");
            cmbTimeBatDau.Items.Add("23h");
            //Thêm các giờ kết thúc
            cmbTimeKetThuc.Items.Add("00h");
            cmbTimeKetThuc.Items.Add("01h");
            cmbTimeKetThuc.Items.Add("02h");
            cmbTimeKetThuc.Items.Add("03h");
            cmbTimeKetThuc.Items.Add("04h");
            cmbTimeKetThuc.Items.Add("05h");
            cmbTimeKetThuc.Items.Add("06h");
            cmbTimeKetThuc.Items.Add("07h");
            cmbTimeKetThuc.Items.Add("08h");
            cmbTimeKetThuc.Items.Add("09h");
            cmbTimeKetThuc.Items.Add("10h");
            cmbTimeKetThuc.Items.Add("11h");
            cmbTimeKetThuc.Items.Add("12h");
            cmbTimeKetThuc.Items.Add("13h");
            cmbTimeKetThuc.Items.Add("14h");
            cmbTimeKetThuc.Items.Add("15h");
            cmbTimeKetThuc.Items.Add("16h");
            cmbTimeKetThuc.Items.Add("17h");
            cmbTimeKetThuc.Items.Add("18h");
            cmbTimeKetThuc.Items.Add("19h");
            cmbTimeKetThuc.Items.Add("20h");
            cmbTimeKetThuc.Items.Add("21h");
            cmbTimeKetThuc.Items.Add("22h");
            cmbTimeKetThuc.Items.Add("23h");


        }


        private void frmDatBan_Load(object sender, EventArgs e)
        {

        }

        private void cmbTimeBatDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý khi một mục được chọn
            string selectedGenre = cmbTimeBatDau.SelectedItem.ToString();
            MessageBox.Show("Giờ bắt đầu đã chọn là: " + selectedGenre);


        }

        private void cmbTheLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            // Xử lý khi một mục được chọn
            string selectedGenre = cmbTheLoai.SelectedItem.ToString();
            MessageBox.Show("Thể loại bạn đã chọn là: " + selectedGenre);

        }
        private void cmbChiNhanh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Xử lý khi một mục được chọn
            string selectedBranch = cmbChiNhanh.SelectedItem.ToString();
            MessageBox.Show("Bạn đã chọn chi nhánh: " + selectedBranch);
            // Thêm các Chi Nhánh

        }
        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            // Xử lý khi ngày tháng năm được chọn từ DateTimePicker
            DateTime selectedDate = dtpNgay.Value;
            MessageBox.Show("Ngày tháng năm bạn đã chọn là: " + selectedDate.ToString("dd/MM/yyyy"));
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt bàn thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmTrangChu frmTrangChu = new frmTrangChu();
            this.Hide();
            frmTrangChu.ShowDialog();
            this.Show();

        }
        private void listLichSu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị lịch sử đặt bàn
            string history = "Lịch sử đặt bàn thành công:\n";
            List<string> bookingHistory = new List<string>();
            foreach (string entry in bookingHistory)
            {
                history += entry + "\n";
            }
            MessageBox.Show(history);
        }

        private void cmbTimeKetThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý khi một mục được chọn
            string selectedGenre = cmbTimeKetThuc.SelectedItem.ToString();
            MessageBox.Show("Giờ kết thúc đã chọn là: " + selectedGenre);
        }
    }
}
