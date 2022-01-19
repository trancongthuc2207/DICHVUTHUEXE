namespace DichVuThueXe.GUI
{
    partial class MENU_ChucNang_Quantrivien_NVTaiKhoan
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
            this.tbNVTaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefeshNVTK = new System.Windows.Forms.Button();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemNVTK = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtMKNhapLai = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.btnHienAn = new System.Windows.Forms.Button();
            this.txtMKHT = new System.Windows.Forms.TextBox();
            this.btnChoPhepSD = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCamSD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbNVTaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNVTaiKhoan
            // 
            this.tbNVTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbNVTaiKhoan.Location = new System.Drawing.Point(335, 22);
            this.tbNVTaiKhoan.Name = "tbNVTaiKhoan";
            this.tbNVTaiKhoan.RowHeadersWidth = 51;
            this.tbNVTaiKhoan.RowTemplate.Height = 24;
            this.tbNVTaiKhoan.Size = new System.Drawing.Size(566, 507);
            this.tbNVTaiKhoan.TabIndex = 0;
            this.tbNVTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbNVTaiKhoan_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefeshNVTK);
            this.groupBox1.Controls.Add(this.txtViTri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTimKiemNVTK);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // btnRefeshNVTK
            // 
            this.btnRefeshNVTK.Location = new System.Drawing.Point(6, 182);
            this.btnRefeshNVTK.Name = "btnRefeshNVTK";
            this.btnRefeshNVTK.Size = new System.Drawing.Size(301, 31);
            this.btnRefeshNVTK.TabIndex = 10;
            this.btnRefeshNVTK.Text = "Làm mới";
            this.btnRefeshNVTK.UseVisualStyleBackColor = true;
            this.btnRefeshNVTK.Click += new System.EventHandler(this.btnRefeshNVTK_Click);
            // 
            // txtViTri
            // 
            this.txtViTri.AccessibleName = "";
            this.txtViTri.Enabled = false;
            this.txtViTri.Location = new System.Drawing.Point(101, 142);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(205, 22);
            this.txtViTri.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vị trí:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AccessibleName = "";
            this.txtTaiKhoan.Enabled = false;
            this.txtTaiKhoan.Location = new System.Drawing.Point(101, 114);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(205, 22);
            this.txtTaiKhoan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tài khoản:";
            // 
            // label13
            // 
            this.label13.AccessibleName = "";
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "(i): Keyboard layout ở định dạng ENG để có hiệu xuất cao nhất";
            // 
            // txtMaNV
            // 
            this.txtMaNV.AccessibleName = "";
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(101, 86);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(205, 22);
            this.txtMaNV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtTimKiemNVTK
            // 
            this.txtTimKiemNVTK.Location = new System.Drawing.Point(6, 31);
            this.txtTimKiemNVTK.Name = "txtTimKiemNVTK";
            this.txtTimKiemNVTK.Size = new System.Drawing.Size(300, 22);
            this.txtTimKiemNVTK.TabIndex = 2;
            this.txtTimKiemNVTK.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);
            this.txtTimKiemNVTK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemNVTK_KeyUp);
            this.txtTimKiemNVTK.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoiMK);
            this.groupBox2.Controls.Add(this.txtMKNhapLai);
            this.groupBox2.Controls.Add(this.txtMKMoi);
            this.groupBox2.Controls.Add(this.btnHienAn);
            this.groupBox2.Controls.Add(this.txtMKHT);
            this.groupBox2.Location = new System.Drawing.Point(16, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đổi mật khẩu";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(101, 129);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(206, 37);
            this.btnDoiMK.TabIndex = 5;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtMKNhapLai
            // 
            this.txtMKNhapLai.AccessibleName = "";
            this.txtMKNhapLai.Location = new System.Drawing.Point(9, 89);
            this.txtMKNhapLai.MaxLength = 25;
            this.txtMKNhapLai.Name = "txtMKNhapLai";
            this.txtMKNhapLai.Size = new System.Drawing.Size(297, 22);
            this.txtMKNhapLai.TabIndex = 4;
            this.txtMKNhapLai.Enter += new System.EventHandler(this.txtMKNhapLai_Enter);
            this.txtMKNhapLai.Leave += new System.EventHandler(this.txtMKNhapLai_Leave);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.AccessibleName = "";
            this.txtMKMoi.Location = new System.Drawing.Point(9, 61);
            this.txtMKMoi.MaxLength = 25;
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(297, 22);
            this.txtMKMoi.TabIndex = 3;
            this.txtMKMoi.Enter += new System.EventHandler(this.txtMKMoi_Enter);
            this.txtMKMoi.Leave += new System.EventHandler(this.txtMKMoi_Leave);
            // 
            // btnHienAn
            // 
            this.btnHienAn.Location = new System.Drawing.Point(9, 129);
            this.btnHienAn.Name = "btnHienAn";
            this.btnHienAn.Size = new System.Drawing.Size(86, 37);
            this.btnHienAn.TabIndex = 0;
            this.btnHienAn.Text = "Hiện";
            this.btnHienAn.UseVisualStyleBackColor = true;
            this.btnHienAn.Click += new System.EventHandler(this.btnHienAn_Click);
            // 
            // txtMKHT
            // 
            this.txtMKHT.AccessibleName = "";
            this.txtMKHT.Location = new System.Drawing.Point(9, 33);
            this.txtMKHT.MaxLength = 25;
            this.txtMKHT.Name = "txtMKHT";
            this.txtMKHT.Size = new System.Drawing.Size(297, 22);
            this.txtMKHT.TabIndex = 2;
            this.txtMKHT.Enter += new System.EventHandler(this.txtMKHT_Enter);
            this.txtMKHT.Leave += new System.EventHandler(this.txtMKHT_Leave);
            // 
            // btnChoPhepSD
            // 
            this.btnChoPhepSD.Location = new System.Drawing.Point(6, 30);
            this.btnChoPhepSD.Name = "btnChoPhepSD";
            this.btnChoPhepSD.Size = new System.Drawing.Size(144, 32);
            this.btnChoPhepSD.TabIndex = 8;
            this.btnChoPhepSD.Text = "Cho phép sử dụng";
            this.btnChoPhepSD.UseVisualStyleBackColor = true;
            this.btnChoPhepSD.Click += new System.EventHandler(this.btnChoPhepSD_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCamSD);
            this.groupBox3.Controls.Add(this.btnChoPhepSD);
            this.groupBox3.Location = new System.Drawing.Point(16, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng khác";
            // 
            // btnCamSD
            // 
            this.btnCamSD.Location = new System.Drawing.Point(163, 30);
            this.btnCamSD.Name = "btnCamSD";
            this.btnCamSD.Size = new System.Drawing.Size(144, 32);
            this.btnCamSD.TabIndex = 9;
            this.btnCamSD.Text = "Cấm sử dụng";
            this.btnCamSD.UseVisualStyleBackColor = true;
            this.btnCamSD.Click += new System.EventHandler(this.btnCamSD_Click);
            // 
            // MENU_ChucNang_Quantrivien_NVTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 543);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbNVTaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Name = "MENU_ChucNang_Quantrivien_NVTaiKhoan";
            this.Text = "Chức Năng Quản Trị Viên";
            this.Load += new System.EventHandler(this.MENU_ChucNang_Quantrivien_NVTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbNVTaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tbNVTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTimKiemNVTK;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHienAn;
        private System.Windows.Forms.TextBox txtMKHT;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChoPhepSD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMKNhapLai;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnCamSD;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefeshNVTK;
    }
}