
namespace DichVuThueXe.GUI.MENU_MAIN.NHANVIEN
{
    partial class MENU_SuaHopDong
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.cbB_LoaiDV = new System.Windows.Forms.ComboBox();
            this.lOAIDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTTX_DataSet = new DichVuThueXe.HTTX_DataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTrangThaiXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtP_KetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtP_BatDau = new System.Windows.Forms.DateTimePicker();
            this.lOAIDVTableAdapter = new DichVuThueXe.HTTX_DataSetTableAdapters.LOAIDVTableAdapter();
            this.lblMaHDG = new System.Windows.Forms.Label();
            this.gridV_Xe = new System.Windows.Forms.DataGridView();
            this.btnSuaHDG = new System.Windows.Forms.Button();
            this.btnKP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_Xe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hợp Đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại dịch vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã xe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Khách Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Nhân Viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Bắt Đầu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Kết Thúc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaDV);
            this.groupBox1.Controls.Add(this.cbB_LoaiDV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(53, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN LOẠI DỊCH VỤ";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(100, 54);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(200, 20);
            this.txtGiaDV.TabIndex = 2;
            // 
            // cbB_LoaiDV
            // 
            this.cbB_LoaiDV.DataSource = this.lOAIDVBindingSource;
            this.cbB_LoaiDV.DisplayMember = "Tenloai";
            this.cbB_LoaiDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbB_LoaiDV.FormattingEnabled = true;
            this.cbB_LoaiDV.Location = new System.Drawing.Point(100, 17);
            this.cbB_LoaiDV.Name = "cbB_LoaiDV";
            this.cbB_LoaiDV.Size = new System.Drawing.Size(200, 21);
            this.cbB_LoaiDV.TabIndex = 1;
            this.cbB_LoaiDV.ValueMember = "MaL";
            this.cbB_LoaiDV.SelectedIndexChanged += new System.EventHandler(this.cbB_LoaiDV_SelectedIndexChanged);
            // 
            // lOAIDVBindingSource
            // 
            this.lOAIDVBindingSource.DataMember = "LOAIDV";
            this.lOAIDVBindingSource.DataSource = this.hTTX_DataSet;
            // 
            // hTTX_DataSet
            // 
            this.hTTX_DataSet.DataSetName = "HTTX_DataSet";
            this.hTTX_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTrangThaiXe);
            this.groupBox2.Controls.Add(this.txtTenXe);
            this.groupBox2.Controls.Add(this.txtMaXe);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(53, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN XE THUÊ";
            // 
            // txtTrangThaiXe
            // 
            this.txtTrangThaiXe.Location = new System.Drawing.Point(100, 78);
            this.txtTrangThaiXe.Name = "txtTrangThaiXe";
            this.txtTrangThaiXe.Size = new System.Drawing.Size(200, 20);
            this.txtTrangThaiXe.TabIndex = 2;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(100, 48);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(200, 20);
            this.txtTenXe.TabIndex = 2;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(100, 17);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(200, 20);
            this.txtMaXe.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Trạng thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên xe:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTenKH);
            this.groupBox3.Controls.Add(this.txtMaKH);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(431, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 88);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(100, 49);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(200, 20);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(100, 22);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(200, 20);
            this.txtMaKH.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên khách hàng:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTenNV);
            this.groupBox4.Controls.Add(this.txtMaNV);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(431, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 113);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(100, 48);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(200, 20);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(100, 18);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(200, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên nhân viên:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtP_KetThuc);
            this.groupBox5.Controls.Add(this.dtP_BatDau);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(53, 401);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "THỜI GIAN THUÊ";
            // 
            // dtP_KetThuc
            // 
            this.dtP_KetThuc.Location = new System.Drawing.Point(100, 54);
            this.dtP_KetThuc.Name = "dtP_KetThuc";
            this.dtP_KetThuc.Size = new System.Drawing.Size(200, 20);
            this.dtP_KetThuc.TabIndex = 1;
            // 
            // dtP_BatDau
            // 
            this.dtP_BatDau.Location = new System.Drawing.Point(100, 20);
            this.dtP_BatDau.Name = "dtP_BatDau";
            this.dtP_BatDau.Size = new System.Drawing.Size(200, 20);
            this.dtP_BatDau.TabIndex = 1;
            // 
            // lOAIDVTableAdapter
            // 
            this.lOAIDVTableAdapter.ClearBeforeFill = true;
            // 
            // lblMaHDG
            // 
            this.lblMaHDG.AutoSize = true;
            this.lblMaHDG.Location = new System.Drawing.Point(133, 29);
            this.lblMaHDG.Name = "lblMaHDG";
            this.lblMaHDG.Size = new System.Drawing.Size(16, 13);
            this.lblMaHDG.TabIndex = 6;
            this.lblMaHDG.Text = "...";
            // 
            // gridV_Xe
            // 
            this.gridV_Xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV_Xe.Location = new System.Drawing.Point(53, 270);
            this.gridV_Xe.Name = "gridV_Xe";
            this.gridV_Xe.Size = new System.Drawing.Size(495, 125);
            this.gridV_Xe.TabIndex = 7;
            this.gridV_Xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridV_Xe_CellClick);
            // 
            // btnSuaHDG
            // 
            this.btnSuaHDG.Location = new System.Drawing.Point(479, 429);
            this.btnSuaHDG.Name = "btnSuaHDG";
            this.btnSuaHDG.Size = new System.Drawing.Size(122, 35);
            this.btnSuaHDG.TabIndex = 8;
            this.btnSuaHDG.Text = "SỬA HỢP ĐỒNG";
            this.btnSuaHDG.UseVisualStyleBackColor = true;
            this.btnSuaHDG.Click += new System.EventHandler(this.btnSuaHDG_Click);
            // 
            // btnKP
            // 
            this.btnKP.Location = new System.Drawing.Point(620, 429);
            this.btnKP.Name = "btnKP";
            this.btnKP.Size = new System.Drawing.Size(122, 35);
            this.btnKP.TabIndex = 8;
            this.btnKP.Text = "Khôi phục";
            this.btnKP.UseVisualStyleBackColor = true;
            // 
            // MENU_SuaHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 510);
            this.Controls.Add(this.btnKP);
            this.Controls.Add(this.btnSuaHDG);
            this.Controls.Add(this.gridV_Xe);
            this.Controls.Add(this.lblMaHDG);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MENU_SuaHopDong";
            this.Text = "MENU_SuaHopDong";
            this.Load += new System.EventHandler(this.MENU_SuaHopDong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_Xe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.ComboBox cbB_LoaiDV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTrangThaiXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtP_KetThuc;
        private System.Windows.Forms.DateTimePicker dtP_BatDau;
        private HTTX_DataSet hTTX_DataSet;
        private System.Windows.Forms.BindingSource lOAIDVBindingSource;
        private HTTX_DataSetTableAdapters.LOAIDVTableAdapter lOAIDVTableAdapter;
        private System.Windows.Forms.Label lblMaHDG;
        private System.Windows.Forms.DataGridView gridV_Xe;
        private System.Windows.Forms.Button btnSuaHDG;
        private System.Windows.Forms.Button btnKP;
    }
}