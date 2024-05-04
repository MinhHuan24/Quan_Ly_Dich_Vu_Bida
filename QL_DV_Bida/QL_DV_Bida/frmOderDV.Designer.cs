namespace QL_DV_Bida
{
    partial class frmOderDV
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
            grDichVu = new GroupBox();
            cbbSP_Khac = new ComboBox();
            label4 = new Label();
            cbbMonAn = new ComboBox();
            label3 = new Label();
            cbbNuoc = new ComboBox();
            label2 = new Label();
            btnXoa = new Button();
            btnOder = new Button();
            cbbLoaiBan = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cbbTenBan = new ComboBox();
            dgvOder = new DataGridView();
            grDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 20);
            label1.Name = "label1";
            label1.Size = new Size(92, 38);
            label1.TabIndex = 0;
            label1.Text = "Oder";
            // 
            // grDichVu
            // 
            grDichVu.Controls.Add(cbbSP_Khac);
            grDichVu.Controls.Add(label4);
            grDichVu.Controls.Add(cbbMonAn);
            grDichVu.Controls.Add(label3);
            grDichVu.Controls.Add(cbbNuoc);
            grDichVu.Controls.Add(label2);
            grDichVu.Location = new Point(12, 61);
            grDichVu.Name = "grDichVu";
            grDichVu.Size = new Size(508, 275);
            grDichVu.TabIndex = 1;
            grDichVu.TabStop = false;
            grDichVu.Text = "Dịch vụ";
            // 
            // cbbSP_Khac
            // 
            cbbSP_Khac.FormattingEnabled = true;
            cbbSP_Khac.Location = new Point(19, 224);
            cbbSP_Khac.Name = "cbbSP_Khac";
            cbbSP_Khac.Size = new Size(483, 28);
            cbbSP_Khac.TabIndex = 1;
            cbbSP_Khac.SelectedIndexChanged += cbbSP_Khac_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 192);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 0;
            label4.Text = "Sản phẩm khác";
            // 
            // cbbMonAn
            // 
            cbbMonAn.FormattingEnabled = true;
            cbbMonAn.Location = new Point(19, 141);
            cbbMonAn.Name = "cbbMonAn";
            cbbMonAn.Size = new Size(483, 28);
            cbbMonAn.TabIndex = 1;
            cbbMonAn.SelectedIndexChanged += cbbMonAn_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 109);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 0;
            label3.Text = "Món ăn";
            // 
            // cbbNuoc
            // 
            cbbNuoc.FormattingEnabled = true;
            cbbNuoc.Location = new Point(19, 66);
            cbbNuoc.Name = "cbbNuoc";
            cbbNuoc.Size = new Size(483, 28);
            cbbNuoc.TabIndex = 1;
            cbbNuoc.SelectedIndexChanged += cbbNuoc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 0;
            label2.Text = "Nước";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(399, 413);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 45);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnOder
            // 
            btnOder.Location = new Point(399, 345);
            btnOder.Name = "btnOder";
            btnOder.Size = new Size(115, 42);
            btnOder.TabIndex = 2;
            btnOder.Text = "Oder";
            btnOder.UseVisualStyleBackColor = true;
            btnOder.Click += btnOder_Click;
            // 
            // cbbLoaiBan
            // 
            cbbLoaiBan.FormattingEnabled = true;
            cbbLoaiBan.Location = new Point(104, 353);
            cbbLoaiBan.Name = "cbbLoaiBan";
            cbbLoaiBan.Size = new Size(256, 28);
            cbbLoaiBan.TabIndex = 1;
            cbbLoaiBan.SelectedIndexChanged += cbbLoaiBan_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 356);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 0;
            label5.Text = "Loại bàn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 425);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 0;
            label6.Text = "Tên bàn";
            // 
            // cbbTenBan
            // 
            cbbTenBan.FormattingEnabled = true;
            cbbTenBan.Location = new Point(104, 422);
            cbbTenBan.Name = "cbbTenBan";
            cbbTenBan.Size = new Size(256, 28);
            cbbTenBan.TabIndex = 1;
            cbbTenBan.SelectedIndexChanged += cbbTenBan_SelectedIndexChanged;
            // 
            // dgvOder
            // 
            dgvOder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOder.Location = new Point(-4, 467);
            dgvOder.Name = "dgvOder";
            dgvOder.RowHeadersWidth = 51;
            dgvOder.Size = new Size(545, 234);
            dgvOder.TabIndex = 3;
            // 
            // frmOderDV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 693);
            Controls.Add(dgvOder);
            Controls.Add(btnOder);
            Controls.Add(cbbTenBan);
            Controls.Add(cbbLoaiBan);
            Controls.Add(btnXoa);
            Controls.Add(grDichVu);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "frmOderDV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOderDV";
            Load += frmOderDV_Load;
            grDichVu.ResumeLayout(false);
            grDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grDichVu;
        private ComboBox cbbSP_Khac;
        private Label label4;
        private ComboBox cbbMonAn;
        private Label label3;
        private ComboBox cbbNuoc;
        private Label label2;
        private Button btnXoa;
        private Button btnOder;
        private ComboBox cbbLoaiBan;
        private Label label5;
        private Label label6;
        private ComboBox cbbTenBan;
        private DataGridView dgvOder;
    }
}