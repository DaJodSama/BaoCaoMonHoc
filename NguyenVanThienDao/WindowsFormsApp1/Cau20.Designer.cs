namespace WindowsFormsApp1
{
    partial class Cau20
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridSinhVien = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnh = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.collMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(154, 19);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(156, 26);
            this.txtMasv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sinh viên:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(154, 69);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(215, 26);
            this.txtTenSV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm:";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(770, 22);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(156, 26);
            this.txtDiem.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp:";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(770, 71);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(156, 26);
            this.txtLop.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(844, 281);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(713, 281);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 33);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(287, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 33);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(165, 281);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 33);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 281);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 33);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridSinhVien
            // 
            this.dataGridSinhVien.AllowUserToAddRows = false;
            this.dataGridSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collMaSV,
            this.collTen,
            this.collDiem,
            this.collLop});
            this.dataGridSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridSinhVien.Location = new System.Drawing.Point(0, 346);
            this.dataGridSinhVien.Name = "dataGridSinhVien";
            this.dataGridSinhVien.RowHeadersWidth = 62;
            this.dataGridSinhVien.RowTemplate.Height = 28;
            this.dataGridSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSinhVien.Size = new System.Drawing.Size(980, 270);
            this.dataGridSinhVien.TabIndex = 10;
            this.dataGridSinhVien.SelectionChanged += new System.EventHandler(this.dataGridSinhVien_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(154, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAnh
            // 
            this.btnAnh.Location = new System.Drawing.Point(40, 170);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(96, 38);
            this.btnAnh.TabIndex = 9;
            this.btnAnh.Text = "Chọn ảnh:";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // collMaSV
            // 
            this.collMaSV.DataPropertyName = "MaSV";
            this.collMaSV.HeaderText = "Mã SV";
            this.collMaSV.MinimumWidth = 8;
            this.collMaSV.Name = "collMaSV";
            // 
            // collTen
            // 
            this.collTen.DataPropertyName = "TenSV";
            this.collTen.HeaderText = "Tên SV";
            this.collTen.MinimumWidth = 8;
            this.collTen.Name = "collTen";
            // 
            // collDiem
            // 
            this.collDiem.DataPropertyName = "Diem";
            this.collDiem.HeaderText = "Điểm SV";
            this.collDiem.MinimumWidth = 8;
            this.collDiem.Name = "collDiem";
            // 
            // collLop
            // 
            this.collLop.DataPropertyName = "Lop";
            this.collLop.HeaderText = "Lớp SV";
            this.collLop.MinimumWidth = 8;
            this.collLop.Name = "collLop";
            // 
            // Cau20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridSinhVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnAnh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label1);
            this.Name = "Cau20";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cau20";
            this.Load += new System.EventHandler(this.Cau20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridSinhVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn collMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn collTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn collDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn collLop;
    }
}