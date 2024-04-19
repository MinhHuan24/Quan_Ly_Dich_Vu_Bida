namespace QL_DV_Bida
{
    partial class frmQuenMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtEmailDangKy = new TextBox();
            label2 = new Label();
            btnLayLaiMatKhau = new Button();
            image1 = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(58, 464);
            label1.Name = "label1";
            label1.Size = new Size(152, 26);
            label1.TabIndex = 0;
            label1.Text = "Email đăng ký:";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // txtEmailDangKy
            // 
            txtEmailDangKy.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmailDangKy.Location = new Point(207, 455);
            txtEmailDangKy.Margin = new Padding(3, 4, 3, 4);
            txtEmailDangKy.Name = "txtEmailDangKy";
            txtEmailDangKy.Size = new Size(296, 38);
            txtEmailDangKy.TabIndex = 1;
            txtEmailDangKy.UseWaitCursor = true;
            txtEmailDangKy.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(58, 540);
            label2.Name = "label2";
            label2.Size = new Size(90, 26);
            label2.TabIndex = 2;
            label2.Text = "Kết quả:";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // btnLayLaiMatKhau
            // 
            btnLayLaiMatKhau.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLayLaiMatKhau.Location = new Point(151, 688);
            btnLayLaiMatKhau.Margin = new Padding(3, 4, 3, 4);
            btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            btnLayLaiMatKhau.Size = new Size(231, 56);
            btnLayLaiMatKhau.TabIndex = 3;
            btnLayLaiMatKhau.Text = "Lấy lại mật khẩu";
            btnLayLaiMatKhau.UseVisualStyleBackColor = true;
            btnLayLaiMatKhau.UseWaitCursor = true;
            btnLayLaiMatKhau.Click += btnLayLaiMatKhau_Click;
            // 
            // image1
            // 
            image1.BackgroundImageLayout = ImageLayout.None;
            image1.BorderStyle = BorderStyle.FixedSingle;
            image1.Cursor = Cursors.WaitCursor;
            image1.Location = new Point(112, 52);
            image1.Margin = new Padding(3, 4, 3, 4);
            image1.Name = "image1";
            image1.Size = new Size(320, 340);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 4;
            image1.TabStop = false;
            image1.UseWaitCursor = true;
            image1.Click += pictureBox1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(338, 617);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(532, 693);
            Controls.Add(btnExit);
            Controls.Add(image1);
            Controls.Add(btnLayLaiMatKhau);
            Controls.Add(label2);
            Controls.Add(txtEmailDangKy);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQuenMatKhau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quên mật khẩu";
            UseWaitCursor = true;
            FormClosing += frmQuenMatKhau_FormClosing;
            Load += frmQuenMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLayLaiMatKhau;
        private System.Windows.Forms.PictureBox image1;
        private Button btnExit;
    }
}

