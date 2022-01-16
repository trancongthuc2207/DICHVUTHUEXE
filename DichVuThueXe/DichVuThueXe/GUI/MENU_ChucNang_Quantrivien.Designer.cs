
namespace DichVuThueXe.GUI
{
    partial class MENU_ChucNang_Quantrivien
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
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnChuaDiChuyen = new System.Windows.Forms.RadioButton();
            this.rbtnDiChuyen = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbXe = new System.Windows.Forms.DataGridView();
            this.xEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTTX_DataSet = new DichVuThueXe.HTTX_DataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xETableAdapter = new DichVuThueXe.HTTX_DataSetTableAdapters.XETableAdapter();
            this.btnXoaNhieu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(280, 59);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBienSo);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnChuaDiChuyen);
            this.groupBox2.Controls.Add(this.rbtnDiChuyen);
            this.groupBox2.Location = new System.Drawing.Point(6, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // rbtnChuaDiChuyen
            // 
            this.rbtnChuaDiChuyen.AutoSize = true;
            this.rbtnChuaDiChuyen.Location = new System.Drawing.Point(115, 28);
            this.rbtnChuaDiChuyen.Name = "rbtnChuaDiChuyen";
            this.rbtnChuaDiChuyen.Size = new System.Drawing.Size(119, 20);
            this.rbtnChuaDiChuyen.TabIndex = 1;
            this.rbtnChuaDiChuyen.TabStop = true;
            this.rbtnChuaDiChuyen.Text = "Chưa di chuyển";
            this.rbtnChuaDiChuyen.UseVisualStyleBackColor = true;
            // 
            // rbtnDiChuyen
            // 
            this.rbtnDiChuyen.AutoSize = true;
            this.rbtnDiChuyen.Location = new System.Drawing.Point(6, 28);
            this.rbtnDiChuyen.Name = "rbtnDiChuyen";
            this.rbtnDiChuyen.Size = new System.Drawing.Size(87, 20);
            this.rbtnDiChuyen.TabIndex = 0;
            this.rbtnDiChuyen.TabStop = true;
            this.rbtnDiChuyen.Text = "Di chuyển";
            this.rbtnDiChuyen.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 31);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(349, 22);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(63, 143);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(178, 22);
            this.txtMaLoai.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã loại:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(63, 115);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(178, 22);
            this.txtBienSo.TabIndex = 2;
            // 
            // txtMaXe
            // 
            this.txtMaXe.AccessibleName = "";
            this.txtMaXe.Enabled = false;
            this.txtMaXe.Location = new System.Drawing.Point(63, 59);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(178, 22);
            this.txtMaXe.TabIndex = 2;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(63, 87);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(178, 22);
            this.txtTenXe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Biển số:";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên xe:";
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Xe:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(280, 177);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 48);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(280, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(280, 88);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbXe
            // 
            this.tbXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbXe.Location = new System.Drawing.Point(382, 13);
            this.tbXe.Name = "tbXe";
            this.tbXe.RowHeadersWidth = 51;
            this.tbXe.RowTemplate.Height = 24;
            this.tbXe.Size = new System.Drawing.Size(741, 263);
            this.tbXe.TabIndex = 2;
            this.tbXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbXe_CellClick);
            // 
            // xEBindingSource
            // 
            this.xEBindingSource.DataMember = "XE";
            this.xEBindingSource.DataSource = this.hTTX_DataSet;
            // 
            // hTTX_DataSet
            // 
            this.hTTX_DataSet.DataSetName = "HTTX_DataSet";
            this.hTTX_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1137, 311);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbXe);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1129, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1129, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // xETableAdapter
            // 
            this.xETableAdapter.ClearBeforeFill = true;
            // 
            // btnXoaNhieu
            // 
            this.btnXoaNhieu.Location = new System.Drawing.Point(398, 325);
            this.btnXoaNhieu.Name = "btnXoaNhieu";
            this.btnXoaNhieu.Size = new System.Drawing.Size(125, 30);
            this.btnXoaNhieu.TabIndex = 0;
            this.btnXoaNhieu.Text = "Xóa Hàng Loạt";
            this.btnXoaNhieu.UseVisualStyleBackColor = true;
            this.btnXoaNhieu.Click += new System.EventHandler(this.btnXoaNhieu_Click);
            // 
            // MENU_ChucNang_Quantrivien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 367);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnXoaNhieu);
            this.Name = "MENU_ChucNang_Quantrivien";
            this.Text = "MENU_ChucNang_Quantrivien";
            this.Load += new System.EventHandler(this.MENU_ChucNang_Quantrivien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnChuaDiChuyen;
        private System.Windows.Forms.RadioButton rbtnDiChuyen;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView tbXe;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private HTTX_DataSet hTTX_DataSet;
        private System.Windows.Forms.BindingSource xEBindingSource;
        private HTTX_DataSetTableAdapters.XETableAdapter xETableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxHeader;
        private System.Windows.Forms.Button btnXoaNhieu;
    }
}