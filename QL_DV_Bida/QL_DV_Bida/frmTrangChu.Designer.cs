namespace QL_DV_Bida
{
    partial class frmTrangChu
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.Location = new Point(323, 551);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(216, 86);
            button1.TabIndex = 0;
            button1.Text = "Bấm giờ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LemonChiffon;
            button3.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button3.Location = new Point(-7, 748);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(216, 128);
            button3.TabIndex = 0;
            button3.Text = "Đăng xuất";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LemonChiffon;
            button4.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button4.Location = new Point(323, 428);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(219, 86);
            button4.TabIndex = 0;
            button4.Text = "Đặt bàn";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LemonChiffon;
            button5.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button5.Location = new Point(323, 674);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(216, 86);
            button5.TabIndex = 0;
            button5.Text = "Dịch vụ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(60, 66);
            label1.Name = "label1";
            label1.Size = new Size(279, 38);
            label1.TabIndex = 1;
            label1.Text = "BILLIARD WORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(194, 131);
            label2.Name = "label2";
            label2.Size = new Size(294, 26);
            label2.TabIndex = 1;
            label2.Text = "\"Tận hưởng từng phút giây !\"";
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.trangchu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(532, 866);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTrangChu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Trang chủ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}