
namespace DichVuThueXe.GUI
{
    partial class MENU_ChucNangMain
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
            this.lblTenNVTruc = new System.Windows.Forms.Label();
            this.lblChucvuNVTruc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabP_ThanhToan = new System.Windows.Forms.TabPage();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.gridV_HOADON = new System.Windows.Forms.DataGridView();
            this.tabP_XemHD = new System.Windows.Forms.TabPage();
            this.btnRefreshHD = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDatXe = new System.Windows.Forms.Button();
            this.btnQuantri = new System.Windows.Forms.Button();
            this.btnXuLyHDG = new System.Windows.Forms.Button();
            this.btnQuanLyKH = new System.Windows.Forms.Button();
            this.hTTX_DataSet = new DichVuThueXe.HTTX_DataSet();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new DichVuThueXe.HTTX_DataSetTableAdapters.HOADONTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl_Main.SuspendLayout();
            this.tabP_ThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_HOADON)).BeginInit();
            this.tabP_XemHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU CHỨC NĂNG THUÊ XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ:";
            // 
            // lblTenNVTruc
            // 
            this.lblTenNVTruc.AutoSize = true;
            this.lblTenNVTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNVTruc.Location = new System.Drawing.Point(170, 31);
            this.lblTenNVTruc.Name = "lblTenNVTruc";
            this.lblTenNVTruc.Size = new System.Drawing.Size(66, 24);
            this.lblTenNVTruc.TabIndex = 3;
            this.lblTenNVTruc.Text = "label4";
            // 
            // lblChucvuNVTruc
            // 
            this.lblChucvuNVTruc.AutoSize = true;
            this.lblChucvuNVTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvuNVTruc.Location = new System.Drawing.Point(114, 55);
            this.lblChucvuNVTruc.Name = "lblChucvuNVTruc";
            this.lblChucvuNVTruc.Size = new System.Drawing.Size(66, 24);
            this.lblChucvuNVTruc.TabIndex = 4;
            this.lblChucvuNVTruc.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thông tin nhân viên trực:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chức năng quản trị";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabP_ThanhToan);
            this.tabControl_Main.Controls.Add(this.tabP_XemHD);
            this.tabControl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.tabControl_Main.Location = new System.Drawing.Point(543, 69);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(650, 377);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabP_ThanhToan
            // 
            this.tabP_ThanhToan.Controls.Add(this.btnThanhToan);
            this.tabP_ThanhToan.Controls.Add(this.gridV_HOADON);
            this.tabP_ThanhToan.Location = new System.Drawing.Point(4, 22);
            this.tabP_ThanhToan.Name = "tabP_ThanhToan";
            this.tabP_ThanhToan.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_ThanhToan.Size = new System.Drawing.Size(642, 351);
            this.tabP_ThanhToan.TabIndex = 0;
            this.tabP_ThanhToan.Text = "Thanh Toán Hợp Đồng";
            this.tabP_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(463, 301);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(155, 32);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // gridV_HOADON
            // 
            this.gridV_HOADON.AutoGenerateColumns = false;
            this.gridV_HOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV_HOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ngayinDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.gridV_HOADON.DataSource = this.hOADONBindingSource;
            this.gridV_HOADON.Location = new System.Drawing.Point(0, 0);
            this.gridV_HOADON.Name = "gridV_HOADON";
            this.gridV_HOADON.Size = new System.Drawing.Size(642, 295);
            this.gridV_HOADON.TabIndex = 0;
            // 
            // tabP_XemHD
            // 
            this.tabP_XemHD.Controls.Add(this.btnRefreshHD);
            this.tabP_XemHD.Controls.Add(this.dataGridView2);
            this.tabP_XemHD.Location = new System.Drawing.Point(4, 22);
            this.tabP_XemHD.Name = "tabP_XemHD";
            this.tabP_XemHD.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_XemHD.Size = new System.Drawing.Size(642, 351);
            this.tabP_XemHD.TabIndex = 1;
            this.tabP_XemHD.Text = "Theo Dõi Hợp Đồng";
            this.tabP_XemHD.UseVisualStyleBackColor = true;
            // 
            // btnRefreshHD
            // 
            this.btnRefreshHD.Location = new System.Drawing.Point(455, 299);
            this.btnRefreshHD.Name = "btnRefreshHD";
            this.btnRefreshHD.Size = new System.Drawing.Size(149, 34);
            this.btnRefreshHD.TabIndex = 1;
            this.btnRefreshHD.Text = "Refresh";
            this.btnRefreshHD.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(642, 290);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnDatXe
            // 
            this.btnDatXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatXe.Location = new System.Drawing.Point(19, 120);
            this.btnDatXe.Name = "btnDatXe";
            this.btnDatXe.Size = new System.Drawing.Size(161, 44);
            this.btnDatXe.TabIndex = 7;
            this.btnDatXe.Text = "Chức năng Đặt xe";
            this.btnDatXe.UseVisualStyleBackColor = true;
            this.btnDatXe.Click += new System.EventHandler(this.btnDatXe_Click);
            // 
            // btnQuantri
            // 
            this.btnQuantri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantri.Location = new System.Drawing.Point(19, 179);
            this.btnQuantri.Name = "btnQuantri";
            this.btnQuantri.Size = new System.Drawing.Size(161, 44);
            this.btnQuantri.TabIndex = 8;
            this.btnQuantri.Text = "Chức năng Quản trị";
            this.btnQuantri.UseVisualStyleBackColor = true;
            this.btnQuantri.Click += new System.EventHandler(this.btnQuantri_Click);
            // 
            // btnXuLyHDG
            // 
            this.btnXuLyHDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyHDG.Location = new System.Drawing.Point(19, 239);
            this.btnXuLyHDG.Name = "btnXuLyHDG";
            this.btnXuLyHDG.Size = new System.Drawing.Size(161, 44);
            this.btnXuLyHDG.TabIndex = 9;
            this.btnXuLyHDG.Text = "Xử lý hợp đồng";
            this.btnXuLyHDG.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyKH
            // 
            this.btnQuanLyKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKH.Location = new System.Drawing.Point(19, 307);
            this.btnQuanLyKH.Name = "btnQuanLyKH";
            this.btnQuanLyKH.Size = new System.Drawing.Size(161, 44);
            this.btnQuanLyKH.TabIndex = 10;
            this.btnQuanLyKH.Text = "Quản lý khách hàng";
            this.btnQuanLyKH.UseVisualStyleBackColor = true;
            // 
            // hTTX_DataSet
            // 
            this.hTTX_DataSet.DataSetName = "HTTX_DataSet";
            this.hTTX_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.hTTX_DataSet;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHDG";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaHDG";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SogioSD";
            this.dataGridViewTextBoxColumn3.HeaderText = "SogioSD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Thanhtien";
            this.dataGridViewTextBoxColumn4.HeaderText = "Thanhtien";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ngayinDataGridViewTextBoxColumn
            // 
            this.ngayinDataGridViewTextBoxColumn.DataPropertyName = "Ngayin";
            this.ngayinDataGridViewTextBoxColumn.HeaderText = "Ngayin";
            this.ngayinDataGridViewTextBoxColumn.Name = "ngayinDataGridViewTextBoxColumn";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Trangthai";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Trangthai";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // MENU_ChucNangMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 576);
            this.Controls.Add(this.btnQuanLyKH);
            this.Controls.Add(this.btnXuLyHDG);
            this.Controls.Add(this.btnQuantri);
            this.Controls.Add(this.btnDatXe);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblChucvuNVTruc);
            this.Controls.Add(this.lblTenNVTruc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MENU_ChucNangMain";
            this.Text = "HỆ THỐNG MENU CHỨC NĂNG";
            this.Load += new System.EventHandler(this.MENU_ChucNangMain_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabP_ThanhToan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridV_HOADON)).EndInit();
            this.tabP_XemHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenNVTruc;
        private System.Windows.Forms.Label lblChucvuNVTruc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
      
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabP_ThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView gridV_HOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogioSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage tabP_XemHD;
        private System.Windows.Forms.DataGridView dataGridView2;
   
        private System.Windows.Forms.Button btnRefreshHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDGDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthaiDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnDatXe;
        private System.Windows.Forms.Button btnQuantri;
        private System.Windows.Forms.Button btnXuLyHDG;
        private System.Windows.Forms.Button btnQuanLyKH;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private HTTX_DataSet hTTX_DataSet;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private HTTX_DataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}