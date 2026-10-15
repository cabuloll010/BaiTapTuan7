namespace QuanLySinhVien.UI
{
    partial class Form1
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
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            btnLocDat = new Button();
            label1 = new Label();
            label2 = new Label();
            dgvSinhVien = new DataGridView();
            laaaaaa = new Label();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(161, 99);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(234, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(504, 103);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(125, 27);
            txtDiem.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(81, 188);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(220, 188);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(369, 188);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(504, 188);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(95, 29);
            btnTaiLai.TabIndex = 2;
            btnTaiLai.Text = "Tải lại danh";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(637, 188);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(135, 29);
            btnLocDat.TabIndex = 2;
            btnLocDat.Text = "Lọc SV đạt (LINQ)";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 106);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 110);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Điểm:";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(100, 247);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(606, 207);
            dgvSinhVien.TabIndex = 4;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // laaaaaa
            // 
            laaaaaa.AutoSize = true;
            laaaaaa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laaaaaa.Location = new Point(161, 33);
            laaaaaa.Name = "laaaaaa";
            laaaaaa.Size = new Size(520, 31);
            laaaaaa.TabIndex = 5;
            laaaaaa.Text = "QUẢN LÝ SINH VIÊN - EF CORE (CRUD ĐẦY ĐỦ)";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = SystemColors.ActiveCaptionText;
            lblTrangThai.Location = new Point(47, 473);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(71, 20);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Sẵn sàng.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(lblTrangThai);
            Controls.Add(laaaaaa);
            Controls.Add(dgvSinhVien);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLocDat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private Button btnLocDat;
        private Label label1;
        private Label label2;
        private DataGridView dgvSinhVien;
        private Label laaaaaa;
        private Label lblTrangThai;
    }
}
