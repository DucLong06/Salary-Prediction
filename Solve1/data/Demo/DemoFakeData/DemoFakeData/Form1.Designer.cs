namespace DemoFakeData
{
    partial class Form1
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
            this.cbBangCap = new System.Windows.Forms.ComboBox();
            this.cbSoNamKinhNghiem = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbNoiDaoTao = new System.Windows.Forms.ComboBox();
            this.cbNangLuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLuong = new System.Windows.Forms.TextBox();
            this.btLuong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBangCap
            // 
            this.cbBangCap.FormattingEnabled = true;
            this.cbBangCap.Items.AddRange(new object[] {
            "Tiến sĩ"});
            this.cbBangCap.Location = new System.Drawing.Point(111, 54);
            this.cbBangCap.Name = "cbBangCap";
            this.cbBangCap.Size = new System.Drawing.Size(121, 21);
            this.cbBangCap.TabIndex = 0;
            this.cbBangCap.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbSoNamKinhNghiem
            // 
            this.cbSoNamKinhNghiem.FormattingEnabled = true;
            this.cbSoNamKinhNghiem.Items.AddRange(new object[] {
            "7"});
            this.cbSoNamKinhNghiem.Location = new System.Drawing.Point(111, 133);
            this.cbSoNamKinhNghiem.Name = "cbSoNamKinhNghiem";
            this.cbSoNamKinhNghiem.Size = new System.Drawing.Size(121, 21);
            this.cbSoNamKinhNghiem.TabIndex = 1;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Trưởng phòng",
            "Nhân viên"});
            this.cbChucVu.Location = new System.Drawing.Point(412, 133);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbChucVu.TabIndex = 3;
            // 
            // cbNoiDaoTao
            // 
            this.cbNoiDaoTao.FormattingEnabled = true;
            this.cbNoiDaoTao.Items.AddRange(new object[] {
            "Trong nước",
            "Ngoài nước"});
            this.cbNoiDaoTao.Location = new System.Drawing.Point(412, 54);
            this.cbNoiDaoTao.Name = "cbNoiDaoTao";
            this.cbNoiDaoTao.Size = new System.Drawing.Size(121, 21);
            this.cbNoiDaoTao.TabIndex = 2;
            // 
            // cbNangLuc
            // 
            this.cbNangLuc.FormattingEnabled = true;
            this.cbNangLuc.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbNangLuc.Location = new System.Drawing.Point(611, 92);
            this.cbNangLuc.Name = "cbNangLuc";
            this.cbNangLuc.Size = new System.Drawing.Size(121, 21);
            this.cbNangLuc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bằng cấp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số năm kinh nghiệm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nơi đào tạo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năng lực";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mức lương";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbLuong
            // 
            this.tbLuong.Location = new System.Drawing.Point(294, 219);
            this.tbLuong.Name = "tbLuong";
            this.tbLuong.Size = new System.Drawing.Size(34, 20);
            this.tbLuong.TabIndex = 11;
            this.tbLuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btLuong
            // 
            this.btLuong.Location = new System.Drawing.Point(521, 217);
            this.btLuong.Name = "btLuong";
            this.btLuong.Size = new System.Drawing.Size(75, 23);
            this.btLuong.TabIndex = 12;
            this.btLuong.Text = "Tính lương";
            this.btLuong.UseVisualStyleBackColor = true;
            this.btLuong.Click += new System.EventHandler(this.btLuong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Triệu đồng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btLuong);
            this.Controls.Add(this.tbLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNangLuc);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.cbNoiDaoTao);
            this.Controls.Add(this.cbSoNamKinhNghiem);
            this.Controls.Add(this.cbBangCap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBangCap;
        private System.Windows.Forms.ComboBox cbSoNamKinhNghiem;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbNoiDaoTao;
        private System.Windows.Forms.ComboBox cbNangLuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLuong;
        private System.Windows.Forms.Button btLuong;
        private System.Windows.Forms.Label label7;
    }
}

