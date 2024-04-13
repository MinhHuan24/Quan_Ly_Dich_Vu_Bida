namespace QL_DV_Bida
{
    partial class frmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            picture_TaiKhoan = new PictureBox();
            picture_MatKhau = new PictureBox();
            link_QuenMatKhau = new LinkLabel();
            link_DangKy = new LinkLabel();
            btn_DangNhap = new Button();
            check_DieuKhoan = new CheckBox();
            image_DangNhap = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture_TaiKhoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_MatKhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image_DangNhap).BeginInit();
            SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(173, 321);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(214, 27);
            txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(173, 381);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(214, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // picture_TaiKhoan
            // 
            picture_TaiKhoan.Image = (Image)resources.GetObject("picture_TaiKhoan.Image");
            picture_TaiKhoan.Location = new Point(126, 318);
            picture_TaiKhoan.Name = "picture_TaiKhoan";
            picture_TaiKhoan.Size = new Size(30, 30);
            picture_TaiKhoan.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_TaiKhoan.TabIndex = 2;
            picture_TaiKhoan.TabStop = false;
            // 
            // picture_MatKhau
            // 
            picture_MatKhau.Image = (Image)resources.GetObject("picture_MatKhau.Image");
            picture_MatKhau.Location = new Point(126, 378);
            picture_MatKhau.Name = "picture_MatKhau";
            picture_MatKhau.Size = new Size(30, 30);
            picture_MatKhau.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_MatKhau.TabIndex = 2;
            picture_MatKhau.TabStop = false;
            // 
            // link_QuenMatKhau
            // 
            link_QuenMatKhau.AutoSize = true;
            link_QuenMatKhau.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_QuenMatKhau.LinkColor = Color.Navy;
            link_QuenMatKhau.Location = new Point(94, 438);
            link_QuenMatKhau.Name = "link_QuenMatKhau";
            link_QuenMatKhau.Size = new Size(130, 20);
            link_QuenMatKhau.TabIndex = 3;
            link_QuenMatKhau.TabStop = true;
            link_QuenMatKhau.Text = "Quên mật khẩu";
            link_QuenMatKhau.LinkClicked += link_QuenMatKhau_LinkClicked;
            // 
            // link_DangKy
            // 
            link_DangKy.AutoSize = true;
            link_DangKy.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_DangKy.LinkColor = Color.Navy;
            link_DangKy.Location = new Point(304, 438);
            link_DangKy.Name = "link_DangKy";
            link_DangKy.Size = new Size(74, 20);
            link_DangKy.TabIndex = 3;
            link_DangKy.TabStop = true;
            link_DangKy.Text = "Đăng ký";
            link_DangKy.LinkClicked += link_DangKy_LinkClicked;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(191, 496);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(124, 45);
            btn_DangNhap.TabIndex = 4;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click_1;
            // 
            // check_DieuKhoan
            // 
            check_DieuKhoan.AutoSize = true;
            check_DieuKhoan.Location = new Point(126, 578);
            check_DieuKhoan.Name = "check_DieuKhoan";
            check_DieuKhoan.Size = new Size(270, 24);
            check_DieuKhoan.TabIndex = 5;
            check_DieuKhoan.Text = "Bạn đồng ý với toàn bộ điều khoản?";
            check_DieuKhoan.UseVisualStyleBackColor = true;
            // 
            // image_DangNhap
            // 
            image_DangNhap.Image = (Image)resources.GetObject("image_DangNhap.Image");
            image_DangNhap.Location = new Point(94, -1);
            image_DangNhap.Name = "image_DangNhap";
            image_DangNhap.Size = new Size(336, 299);
            image_DangNhap.SizeMode = PictureBoxSizeMode.StretchImage;
            image_DangNhap.TabIndex = 0;
            image_DangNhap.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(532, 693);
            Controls.Add(check_DieuKhoan);
            Controls.Add(btn_DangNhap);
            Controls.Add(link_DangKy);
            Controls.Add(link_QuenMatKhau);
            Controls.Add(picture_MatKhau);
            Controls.Add(picture_TaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(image_DangNhap);
            Name = "frmDangNhap";
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)picture_TaiKhoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_MatKhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)image_DangNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private PictureBox picture_TaiKhoan;
        private PictureBox picture_MatKhau;
        private LinkLabel link_QuenMatKhau;
        private LinkLabel link_DangKy;
        private Button btn_DangNhap;
        private CheckBox check_DieuKhoan;
        private PictureBox image_DangNhap;
    }
}
