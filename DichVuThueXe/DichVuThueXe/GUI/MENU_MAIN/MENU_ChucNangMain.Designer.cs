
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTTX_DataSet = new DichVuThueXe.HTTX_DataSet();
            this.reportHDByNgayBDandNgayKTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUTHUEXEDataSet = new DichVuThueXe.DICHVUTHUEXEDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenNVTruc = new System.Windows.Forms.Label();
            this.lblChucvuNVTruc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabP_ThanhToan = new System.Windows.Forms.TabPage();
            this.txtVD = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.gridV_HOADON = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabP_XemHD = new System.Windows.Forms.TabPage();
            this.btnSuaHDG = new System.Windows.Forms.Button();
            this.btnRefreshHD = new System.Windows.Forms.Button();
            this.gridV_HOPDONG = new System.Windows.Forms.DataGridView();
            this.tabP_QLKH = new System.Windows.Forms.TabPage();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.tabP_Report = new System.Windows.Forms.TabPage();
            this.btn_xemBC = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtP_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtP_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnDatXe = new System.Windows.Forms.Button();
            this.btnQuantri = new System.Windows.Forms.Button();
            this.btnXuLyHDG = new System.Windows.Forms.Button();
            this.btnQuanLyKH = new System.Windows.Forms.Button();
            this.hOADONTableAdapter = new DichVuThueXe.HTTX_DataSetTableAdapters.HOADONTableAdapter();
            this.reportHDByNgayBDandNgayKTTableAdapter = new DichVuThueXe.DICHVUTHUEXEDataSetTableAdapters.reportHDByNgayBDandNgayKTTableAdapter();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.grBox_MenuMain = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportHDByNgayBDandNgayKTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUTHUEXEDataSet)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.tabP_ThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_HOADON)).BeginInit();
            this.tabP_XemHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_HOPDONG)).BeginInit();
            this.tabP_QLKH.SuspendLayout();
            this.tabP_Report.SuspendLayout();
            this.grBox_MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.hTTX_DataSet;
            // 
            // hTTX_DataSet
            // 
            this.hTTX_DataSet.DataSetName = "HTTX_DataSet";
            this.hTTX_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportHDByNgayBDandNgayKTBindingSource
            // 
            this.reportHDByNgayBDandNgayKTBindingSource.DataMember = "reportHDByNgayBDandNgayKT";
            this.reportHDByNgayBDandNgayKTBindingSource.DataSource = this.dICHVUTHUEXEDataSet;
            // 
            // dICHVUTHUEXEDataSet
            // 
            this.dICHVUTHUEXEDataSet.DataSetName = "DICHVUTHUEXEDataSet";
            this.dICHVUTHUEXEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lblTenNVTruc.Size = new System.Drawing.Size(28, 24);
            this.lblTenNVTruc.TabIndex = 3;
            this.lblTenNVTruc.Text = "...";
            // 
            // lblChucvuNVTruc
            // 
            this.lblChucvuNVTruc.AutoSize = true;
            this.lblChucvuNVTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvuNVTruc.Location = new System.Drawing.Point(114, 55);
            this.lblChucvuNVTruc.Name = "lblChucvuNVTruc";
            this.lblChucvuNVTruc.Size = new System.Drawing.Size(28, 24);
            this.lblChucvuNVTruc.TabIndex = 4;
            this.lblChucvuNVTruc.Text = "...";
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
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabP_ThanhToan);
            this.tabControl_Main.Controls.Add(this.tabP_XemHD);
            this.tabControl_Main.Controls.Add(this.tabP_QLKH);
            this.tabControl_Main.Controls.Add(this.tabP_Report);
            this.tabControl_Main.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(247, 86);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(979, 474);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabP_ThanhToan
            // 
            this.tabP_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabP_ThanhToan.Controls.Add(this.txtVD);
            this.tabP_ThanhToan.Controls.Add(this.btnThanhToan);
            this.tabP_ThanhToan.Controls.Add(this.gridV_HOADON);
            this.tabP_ThanhToan.Location = new System.Drawing.Point(4, 28);
            this.tabP_ThanhToan.Name = "tabP_ThanhToan";
            this.tabP_ThanhToan.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_ThanhToan.Size = new System.Drawing.Size(971, 442);
            this.tabP_ThanhToan.TabIndex = 0;
            this.tabP_ThanhToan.Text = "Thanh Toán Hợp Đồng";
            // 
            // txtVD
            // 
            this.txtVD.Location = new System.Drawing.Point(102, 386);
            this.txtVD.Name = "txtVD";
            this.txtVD.Size = new System.Drawing.Size(245, 27);
            this.txtVD.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(463, 384);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(158, 46);
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
            this.gridV_HOADON.Size = new System.Drawing.Size(971, 368);
            this.gridV_HOADON.TabIndex = 0;
            this.gridV_HOADON.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridV_HOADON_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHD";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Hoá Đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHDG";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Hợp Đồng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SogioSD";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Giờ Sử Dụng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Thanhtien";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "Thành Tiền";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // ngayinDataGridViewTextBoxColumn
            // 
            this.ngayinDataGridViewTextBoxColumn.DataPropertyName = "Ngayin";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ngayinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.ngayinDataGridViewTextBoxColumn.HeaderText = "Ngày In";
            this.ngayinDataGridViewTextBoxColumn.Name = "ngayinDataGridViewTextBoxColumn";
            this.ngayinDataGridViewTextBoxColumn.Width = 170;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Trangthai";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Trạng Thái";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // tabP_XemHD
            // 
            this.tabP_XemHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabP_XemHD.Controls.Add(this.btnSuaHDG);
            this.tabP_XemHD.Controls.Add(this.btnRefreshHD);
            this.tabP_XemHD.Controls.Add(this.gridV_HOPDONG);
            this.tabP_XemHD.Location = new System.Drawing.Point(4, 28);
            this.tabP_XemHD.Name = "tabP_XemHD";
            this.tabP_XemHD.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_XemHD.Size = new System.Drawing.Size(971, 442);
            this.tabP_XemHD.TabIndex = 1;
            this.tabP_XemHD.Text = "Theo Dõi Hợp Đồng";
            // 
            // btnSuaHDG
            // 
            this.btnSuaHDG.Location = new System.Drawing.Point(276, 389);
            this.btnSuaHDG.Name = "btnSuaHDG";
            this.btnSuaHDG.Size = new System.Drawing.Size(142, 41);
            this.btnSuaHDG.TabIndex = 2;
            this.btnSuaHDG.Text = "Sửa Hợp Đồng";
            this.btnSuaHDG.UseVisualStyleBackColor = true;
            this.btnSuaHDG.Click += new System.EventHandler(this.btnSuaHDG_Click);
            // 
            // btnRefreshHD
            // 
            this.btnRefreshHD.Location = new System.Drawing.Point(455, 389);
            this.btnRefreshHD.Name = "btnRefreshHD";
            this.btnRefreshHD.Size = new System.Drawing.Size(154, 41);
            this.btnRefreshHD.TabIndex = 1;
            this.btnRefreshHD.Text = "Refresh";
            this.btnRefreshHD.UseVisualStyleBackColor = true;
            this.btnRefreshHD.Click += new System.EventHandler(this.btnRefreshHD_Click);
            // 
            // gridV_HOPDONG
            // 
            this.gridV_HOPDONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV_HOPDONG.Location = new System.Drawing.Point(0, 3);
            this.gridV_HOPDONG.Name = "gridV_HOPDONG";
            this.gridV_HOPDONG.Size = new System.Drawing.Size(971, 352);
            this.gridV_HOPDONG.TabIndex = 0;
            this.gridV_HOPDONG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridV_HOPDONG_CellClick);
            // 
            // tabP_QLKH
            // 
            this.tabP_QLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabP_QLKH.Controls.Add(this.btnXoaKH);
            this.tabP_QLKH.Controls.Add(this.btnSuaKH);
            this.tabP_QLKH.Location = new System.Drawing.Point(4, 28);
            this.tabP_QLKH.Name = "tabP_QLKH";
            this.tabP_QLKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_QLKH.Size = new System.Drawing.Size(971, 442);
            this.tabP_QLKH.TabIndex = 3;
            this.tabP_QLKH.Text = "Quản Lý Khách Hàng";
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(226, 391);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(97, 42);
            this.btnXoaKH.TabIndex = 11;
            this.btnXoaKH.Text = "Xoá";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(94, 391);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(97, 42);
            this.btnSuaKH.TabIndex = 0;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            // 
            // tabP_Report
            // 
            this.tabP_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabP_Report.Controls.Add(this.btn_xemBC);
            this.tabP_Report.Controls.Add(this.label7);
            this.tabP_Report.Controls.Add(this.label5);
            this.tabP_Report.Controls.Add(this.dtP_NgayKT);
            this.tabP_Report.Controls.Add(this.dtP_NgayBD);
            this.tabP_Report.Controls.Add(this.reportViewer1);
            this.tabP_Report.Location = new System.Drawing.Point(4, 28);
            this.tabP_Report.Name = "tabP_Report";
            this.tabP_Report.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Report.Size = new System.Drawing.Size(971, 442);
            this.tabP_Report.TabIndex = 2;
            this.tabP_Report.Text = "Report";
            // 
            // btn_xemBC
            // 
            this.btn_xemBC.Location = new System.Drawing.Point(382, 29);
            this.btn_xemBC.Name = "btn_xemBC";
            this.btn_xemBC.Size = new System.Drawing.Size(78, 40);
            this.btn_xemBC.TabIndex = 5;
            this.btn_xemBC.Text = "Xem";
            this.btn_xemBC.UseVisualStyleBackColor = true;
            this.btn_xemBC.Click += new System.EventHandler(this.btn_xemBC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày KT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày BĐ:";
            // 
            // dtP_NgayKT
            // 
            this.dtP_NgayKT.Location = new System.Drawing.Point(109, 53);
            this.dtP_NgayKT.Name = "dtP_NgayKT";
            this.dtP_NgayKT.Size = new System.Drawing.Size(252, 27);
            this.dtP_NgayKT.TabIndex = 2;
            // 
            // dtP_NgayBD
            // 
            this.dtP_NgayBD.Location = new System.Drawing.Point(109, 18);
            this.dtP_NgayBD.Name = "dtP_NgayBD";
            this.dtP_NgayBD.Size = new System.Drawing.Size(252, 27);
            this.dtP_NgayBD.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSetHD";
            reportDataSource3.Value = this.hOADONBindingSource;
            reportDataSource4.Name = "DataSetHD_Giua2Ngay";
            reportDataSource4.Value = this.reportHDByNgayBDandNgayKTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DichVuThueXe.Report.ReportHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(971, 337);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnDatXe
            // 
            this.btnDatXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatXe.Location = new System.Drawing.Point(20, 33);
            this.btnDatXe.Name = "btnDatXe";
            this.btnDatXe.Size = new System.Drawing.Size(196, 44);
            this.btnDatXe.TabIndex = 7;
            this.btnDatXe.Text = "Chức năng Đặt xe";
            this.btnDatXe.UseVisualStyleBackColor = true;
            this.btnDatXe.Click += new System.EventHandler(this.btnDatXe_Click);
            // 
            // btnQuantri
            // 
            this.btnQuantri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuantri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantri.Location = new System.Drawing.Point(20, 102);
            this.btnQuantri.Name = "btnQuantri";
            this.btnQuantri.Size = new System.Drawing.Size(196, 44);
            this.btnQuantri.TabIndex = 8;
            this.btnQuantri.Text = "Chức năng Quản trị";
            this.btnQuantri.UseVisualStyleBackColor = true;
            this.btnQuantri.Click += new System.EventHandler(this.btnQuantri_Click);
            // 
            // btnXuLyHDG
            // 
            this.btnXuLyHDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuLyHDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyHDG.Location = new System.Drawing.Point(20, 176);
            this.btnXuLyHDG.Name = "btnXuLyHDG";
            this.btnXuLyHDG.Size = new System.Drawing.Size(196, 44);
            this.btnXuLyHDG.TabIndex = 9;
            this.btnXuLyHDG.Text = "Xử lý hợp đồng";
            this.btnXuLyHDG.UseVisualStyleBackColor = true;
            this.btnXuLyHDG.Click += new System.EventHandler(this.btnXuLyHDG_Click);
            // 
            // btnQuanLyKH
            // 
            this.btnQuanLyKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKH.Location = new System.Drawing.Point(20, 245);
            this.btnQuanLyKH.Name = "btnQuanLyKH";
            this.btnQuanLyKH.Size = new System.Drawing.Size(196, 44);
            this.btnQuanLyKH.TabIndex = 10;
            this.btnQuanLyKH.Text = "Quản lý khách hàng";
            this.btnQuanLyKH.UseVisualStyleBackColor = true;
            this.btnQuanLyKH.Click += new System.EventHandler(this.btnQuanLyKH_Click);
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // reportHDByNgayBDandNgayKTTableAdapter
            // 
            this.reportHDByNgayBDandNgayKTTableAdapter.ClearBeforeFill = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(20, 391);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(196, 44);
            this.btnBaoCao.TabIndex = 11;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnTT
            // 
            this.btnTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.Location = new System.Drawing.Point(20, 320);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(196, 44);
            this.btnTT.TabIndex = 11;
            this.btnTT.Text = "Thanh toán";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // grBox_MenuMain
            // 
            this.grBox_MenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grBox_MenuMain.Controls.Add(this.btnDatXe);
            this.grBox_MenuMain.Controls.Add(this.btnBaoCao);
            this.grBox_MenuMain.Controls.Add(this.btnTT);
            this.grBox_MenuMain.Controls.Add(this.btnQuantri);
            this.grBox_MenuMain.Controls.Add(this.btnXuLyHDG);
            this.grBox_MenuMain.Controls.Add(this.btnQuanLyKH);
            this.grBox_MenuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBox_MenuMain.ForeColor = System.Drawing.Color.BlueViolet;
            this.grBox_MenuMain.Location = new System.Drawing.Point(5, 86);
            this.grBox_MenuMain.Name = "grBox_MenuMain";
            this.grBox_MenuMain.Size = new System.Drawing.Size(236, 474);
            this.grBox_MenuMain.TabIndex = 12;
            this.grBox_MenuMain.TabStop = false;
            this.grBox_MenuMain.Text = "DANH MỤC CHỨC NĂNG";
            // 
            // MENU_ChucNangMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1230, 576);
            this.Controls.Add(this.grBox_MenuMain);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblChucvuNVTruc);
            this.Controls.Add(this.lblTenNVTruc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MENU_ChucNangMain";
            this.Text = "HỆ THỐNG MENU CHỨC NĂNG";
            this.Load += new System.EventHandler(this.MENU_ChucNangMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportHDByNgayBDandNgayKTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUTHUEXEDataSet)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.tabP_ThanhToan.ResumeLayout(false);
            this.tabP_ThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_HOADON)).EndInit();
            this.tabP_XemHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridV_HOPDONG)).EndInit();
            this.tabP_QLKH.ResumeLayout(false);
            this.tabP_Report.ResumeLayout(false);
            this.tabP_Report.PerformLayout();
            this.grBox_MenuMain.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView gridV_HOPDONG;
   
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
        private System.Windows.Forms.TabPage tabP_Report;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_xemBC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtP_NgayKT;
        private System.Windows.Forms.DateTimePicker dtP_NgayBD;
        private System.Windows.Forms.BindingSource reportHDByNgayBDandNgayKTBindingSource;
        private DICHVUTHUEXEDataSet dICHVUTHUEXEDataSet;
        private DICHVUTHUEXEDataSetTableAdapters.reportHDByNgayBDandNgayKTTableAdapter reportHDByNgayBDandNgayKTTableAdapter;
        private System.Windows.Forms.TabPage tabP_QLKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.GroupBox grBox_MenuMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txtVD;
        private System.Windows.Forms.Button btnSuaHDG;
    }
}