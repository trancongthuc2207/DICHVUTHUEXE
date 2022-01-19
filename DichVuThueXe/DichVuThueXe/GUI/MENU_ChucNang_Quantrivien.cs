using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.BUS;

namespace DichVuThueXe.GUI
{
    public partial class MENU_ChucNang_Quantrivien : Form
    {
        private static int maXeHT = 0;
        private static int maNVHT = 0;
        private bool unCheckedAll = true;
        private bool unCheckedAllNV = true;
        private CheckBox checkboxHeader;
        private CheckBox checkboxHeaderNV;
        BUS_XE busXe;
        BUS_NHANVIEN busNV;
        BUS_NHANVIEN_TAIKHOAN busNVTaiKhoan;

        public MENU_ChucNang_Quantrivien()
        {
            InitializeComponent();
            busXe = new BUS_XE();
            busNV = new BUS_NHANVIEN();
            busNVTaiKhoan = new BUS_NHANVIEN_TAIKHOAN();

            /////////////////////////////////////////// XE
            this.txtTimKiem.ForeColor = Color.Gray;
            this.txtTimKiem.Text = " Tìm kiếm trên bảng";
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);

            /////////////////////////////////////////// NV
            this.txtTimKiemNV.ForeColor = Color.Gray;
            this.txtTimKiemNV.Text = " Tìm kiếm trên bảng";
            this.txtTimKiemNV.Leave += new System.EventHandler(this.txtTimKiemNV_Leave);
            this.txtTimKiemNV.Enter += new System.EventHandler(this.txtTimKiemNV_Enter);
        }
        private void MENU_ChucNang_Quantrivien_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////// XE
            this.loadDataTableXe();
            this.initInputXe();

            /////////////////////////////////////////// NV
            this.loadDataTableNV();
            this.initInputNV();
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            //dinh dang 2 column xe nv

            /////////////////////////////////////////// COLUMN TAB XE
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbXe.Columns.Insert(0, checkBoxColumn);

            Rectangle rect = this.tbXe.GetCellDisplayRectangle(0, -1, false);

            rect.X = rect.Location.X + (rect.Width / 16);
            rect.Y = rect.Location.Y + (rect.Height / 16);
            checkboxHeader = new CheckBox();
            checkboxHeader.BackColor = Color.FromArgb(0, 80, 200);
            checkboxHeader.Name = "checkBoxHeader";
            checkboxHeader.Size = new Size(18, 18);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxColumn.ReadOnly = false;

            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);

            this.tbXe.Controls.Add(checkboxHeader);
            ///////////////////////////////////////////

            /////////////////////////////////////////// COLUMN TAB NV
            DataGridViewCheckBoxColumn checkBoxColumnNV = new DataGridViewCheckBoxColumn();
            checkBoxColumnNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkBoxColumnNV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbNV.Columns.Insert(0, checkBoxColumnNV);

            //Rectangle rectNV = this.tbNV.GetCellDisplayRectangle(0, -1, false);

            rect.X = rect.Location.X + (rect.Width / 24);
            rect.Y = rect.Location.Y + (rect.Height / 24);
            checkboxHeaderNV = new CheckBox();
            checkboxHeaderNV.BackColor = Color.FromArgb(0, 80, 200);
            checkboxHeaderNV.Name = "checkBoxHeader";
            checkboxHeaderNV.Size = new Size(18, 18);
            checkboxHeaderNV.Location = rect.Location;
            checkboxHeaderNV.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxColumnNV.ReadOnly = false;

            checkboxHeaderNV.CheckedChanged += new EventHandler(checkboxHeaderNV_CheckedChanged);

            this.tbNV.Controls.Add(checkboxHeaderNV);
            ///////////////////////////////////////////
        }
        //////////////////////////////// CHỨC NĂNG QUẢN TRỊ XE ////////////////////////////////
        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHeader.Checked)
            {
                for (int i = 0; i < this.tbXe.RowCount; i++)
                {
                    this.tbXe[0, i].Value = true;
                }
            }
            else
            {
                if (unCheckedAll)
                {
                    for (int i = 0; i < this.tbXe.RowCount; i++)
                    {
                        this.tbXe[0, i].Value = false;
                    }
                }
            }
            unCheckedAll = true;
        }

        public void initInputXe()
        {
            maXeHT = busXe.getMaXeHT();
            var xe = busXe.getXe1(maXeHT);
            this.txtMaXe.Text = xe.Maxe.ToString();
            this.txtTenXe.Text = xe.Tenxe;
            this.txtBienSo.Text = xe.Bienso;
            this.txtMaLoai.Text = xe.MaL.ToString();
            if (xe.Trangthai)
                this.rbtnDiChuyen.Checked = true;
            else
                this.rbtnChuaDiChuyen.Checked = true;
        }

        public void loadDataTableXe()
        {
            this.busXe = new BUS_XE();
            this.tbXe.DataSource = busXe.getXe();
        }

        public void loadDataTableXe(int maXe)
        {
            this.busXe = new BUS_XE();
            this.tbXe.DataSource = busXe.getXe(maXe);
        }

        public void loadDataTableXe(string tenXe)
        {
            this.busXe = new BUS_XE();
            this.tbXe.DataSource = busXe.getXe(tenXe);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.loadDataTableXe();
            this.initInputXe();
        }

        private void tbXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tbXe.SelectedCells.Count == 0)
            {
                if (e.RowIndex >= 0)
                {
                    if ((bool)this.tbXe[0, e.RowIndex].Value)
                    {
                        this.tbXe[0, e.RowIndex].Value = false;
                        foreach (DataGridViewRow r in this.tbXe.Rows)
                        {
                            if ((bool)r.Cells[0].Value)
                            {
                                unCheckedAll = false;
                                break;
                            }
                        }
                        checkboxHeader.Checked = false;
                    }
                    else
                    {
                        this.tbXe[0, e.RowIndex].Value = true;
                        bool check = true;
                        foreach (DataGridViewRow r in this.tbXe.Rows)
                        {
                            if (!((bool)r.Cells[0].Value))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
                        {
                            checkboxHeader.Checked = true;
                        }
                    }
                }
            }

            try
            {
                DataGridViewRow row = this.tbXe.Rows[e.RowIndex];
                if (Convert.ToBoolean(row.Cells[0].Value) || row.Cells[0].Selected)
                {
                    this.tbXe.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    this.tbXe.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex) { }

            try
            {
                if (this.tbXe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.tbXe.CurrentRow.Selected = true;
                    this.txtMaXe.Text = this.tbXe.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.txtTenXe.Text = this.tbXe.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.txtBienSo.Text = this.tbXe.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.rbtnDiChuyen.Checked = true;
                    if (this.tbXe.Rows[e.RowIndex].Cells[4].Value.Equals(false))
                        this.rbtnChuaDiChuyen.Checked = true;
                    this.txtMaLoai.Text = this.tbXe.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ chọn dòng tương ứng", "Cảnh báo!");
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (this.txtTimKiem.Text == "")
            {
                this.txtTimKiem.Text = " Tìm kiếm trên bảng";
                this.txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (this.txtTimKiem.Text == " Tìm kiếm trên bảng")
            {
                this.txtTimKiem.Text = "";
                this.txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtTimKiem.Text) || string.IsNullOrEmpty(this.txtTimKiem.Text) && Convert.ToInt32(e.KeyCode) == 8)
                this.loadDataTableXe();
            if (!(string.IsNullOrWhiteSpace(this.txtTimKiem.Text) && string.IsNullOrEmpty(this.txtTimKiem.Text)))
            {
                if (this.IsNumber(this.txtTimKiem.Text))
                    this.loadDataTableXe(int.Parse(this.txtTimKiem.Text));
                if (!this.IsNumber(this.txtTimKiem.Text))
                    this.loadDataTableXe(this.txtTimKiem.Text.Trim());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (this.isXeInputNotNull())
            //{
            //    if (this.isXeInputExactly())
            //    {
            //        if (!busXe.checkXeTonTai(int.Parse(this.txtMaXe.Text)))
            //        {
            int maXe = int.Parse(this.txtMaXe.Text);
            string tenXe = this.txtTenXe.Text;
            string bienSo = this.txtBienSo.Text;
            bool trangThai = false;
            if (rbtnDiChuyen.Checked)
                trangThai = true;
            int maLoai = int.Parse(this.txtMaLoai.Text);
            try
            {
                busXe.themXe(maXe, tenXe, bienSo, trangThai, maLoai);
                MessageBox.Show("Thêm thành công!!!", "Thông báo");
                this.loadDataTableXe();
                maXeHT = busXe.getMaXeHT() + 1;
                this.txtMaXe.Text = maXeHT.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại!!!", "Lỗi!");
            }
            //        }
            //        else
            //            MessageBox.Show("Mã xe trùng khớp", "Thông báo");
            //    }
            //    else
            //        MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
            //}
            //else
            //    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (this.isXeInputNotNull())
            //{
            //    if (this.isXeInputExactly())
            //    {
            //        if (busXe.checkXeTonTai(int.Parse(this.txtMaXe.Text)))
            //        {
            int maXe = int.Parse(this.txtMaXe.Text);
            string tenXe = this.txtTenXe.Text;
            string bienSo = this.txtBienSo.Text;
            int maLoai = int.Parse(this.txtMaLoai.Text);
            bool trangThai = false;
            if (rbtnDiChuyen.Checked)
                trangThai = true;
            try
            {
                busXe.suaXe(maXe, tenXe, bienSo, trangThai, maLoai);
                MessageBox.Show("Sửa thành công!!!", "Thông báo");
                this.loadDataTableXe();
                this.resetTextBox(maXe);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại!!!", "Lỗi!");
            }
            //        }
            //        else
            //            MessageBox.Show("Mã xe không tồn tại", "Thông báo");
            //    }
            //    else
            //        MessageBox.Show("Thông tin không hợp lệ", "Thông báo");
            //}
            //else
            //    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    busXe.xoaXe(int.Parse(this.txtMaXe.Text));
                    MessageBox.Show("Xóa thành công!!!", "Thông báo");
                    this.btnRefresh_Click(sender, e);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Xóa thất bại!!!", "Lỗi!");
                }
            }
        }

        private void btnXoaNhieu_Click(object sender, EventArgs e)
        {
            bool checkBoxCells = false;
            for (int i = this.tbXe.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = this.tbXe.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    checkBoxCells = true;
                    break;
                }
            }
            if (checkBoxCells)
            {
                bool checkXoa = true;
                if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = this.tbXe.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = this.tbXe.Rows[i];
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            try
                            {
                                int maXe = Convert.ToInt32(row.Cells[1].Value);
                                busXe.xoaXe(maXe);
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Xóa thất bại!!!", "Lỗi!");
                                checkXoa = false;
                                this.btnRefresh_Click(sender, e);
                            }
                        }
                    }
                }
                if (checkXoa)
                {
                    MessageBox.Show("Xóa hàng loạt thành công!!!", "Thông báo");
                    this.btnRefresh_Click(sender, e);
                }
            }
            if (!checkBoxCells)
                MessageBox.Show("Bạn chưa lựa chọn dòng nào để xóa!", "Thông báo");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtTimKiem.ForeColor = Color.Gray;
            this.txtTimKiem.Text = " Tìm kiếm trên bảng";

            maXeHT = busXe.getMaXeHT() + 1;
            this.txtMaXe.Text = maXeHT.ToString();

            this.txtTenXe.Text = null;
            this.txtBienSo.Text = null;
            this.rbtnDiChuyen.Checked = false;
            this.rbtnChuaDiChuyen.Checked = false;
            this.txtMaLoai.Text = null;

            this.loadDataTableXe();
        }

        public void resetTextBox(int maXe)
        {
            var xe = busXe.getXe(maXe).First();
            this.txtMaXe.Text = xe.Maxe.ToString();
            this.txtTenXe.Text = xe.Tenxe;
            this.txtBienSo.Text = xe.Bienso;
            this.txtMaLoai.Text = xe.MaL.ToString();
            if (xe.Trangthai)
                this.rbtnDiChuyen.Checked = true;
            else
                this.rbtnChuaDiChuyen.Checked = true;
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public bool isXeInputNotNull()
        {
            if (this.txtTenXe.Text == null || this.txtBienSo.Text == null || this.txtMaLoai.Text == null)
                if (this.rbtnDiChuyen.Checked == false && this.rbtnChuaDiChuyen.Checked == false)
                    return false;
            return true;
        }

        public bool isXeInputExactly()
        {
            if (!this.IsNumber(this.txtMaLoai.Text))
                return false;
            return true;
        }

        //////////////////////////////// CHỨC NĂNG QUẢN TRỊ NHÂN VIÊN ////////////////////////////////
        private void checkboxHeaderNV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHeaderNV.Checked)
            {
                for (int i = 0; i < this.tbNV.RowCount; i++)
                {
                    this.tbNV[0, i].Value = true;
                }
            }
            else
            {
                if (unCheckedAllNV)
                {
                    for (int i = 0; i < this.tbNV.RowCount; i++)
                    {
                        this.tbNV[0, i].Value = false;
                    }
                }
            }
            unCheckedAllNV = true;
        }

        public void initInputNV()
        {
            maNVHT = busNV.getMaNVHT();
            var nv = busNV.getNV1(maNVHT);
            this.txtMaNV.Text = nv.MaNV.ToString();
            this.txtTenNV.Text = nv.TenNV;
            this.txtCMND.Text = nv.CMND;
            this.txtGioiTinh.Text = nv.Gioitinh;
            this.dtpNgaySinh.Value = (DateTime)nv.Ngaysinh;
            this.txtDiaChi.Text = nv.Diachi;
            this.txtSDT.Text = nv.SDT;
        }

        public void loadDataTableNV()
        {
            this.busNV = new BUS_NHANVIEN();
            this.tbNV.DataSource = busNV.getNV();
        }

        public void loadDataTableNV(int maNV)
        {
            this.busNV = new BUS_NHANVIEN();
            this.tbNV.DataSource = busNV.getNV(maNV);
        }

        public void loadDataTableNV(string tenNV)
        {
            this.busNV = new BUS_NHANVIEN();
            this.tbNV.DataSource = busNV.getNV(tenNV);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            this.loadDataTableNV();
            this.initInputNV();
        }

        private void tbNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tbNV.SelectedCells.Count == 0)
            {
                if (e.RowIndex >= 0)
                {
                    if ((bool)this.tbNV[0, e.RowIndex].Value)
                    {
                        this.tbNV[0, e.RowIndex].Value = false;
                        foreach (DataGridViewRow r in this.tbNV.Rows)
                        {
                            if ((bool)r.Cells[0].Value)
                            {
                                unCheckedAllNV = false;
                                break;
                            }
                        }
                        checkboxHeaderNV.Checked = false;
                    }
                    else
                    {
                        this.tbNV[0, e.RowIndex].Value = true;
                        bool check = true;
                        foreach (DataGridViewRow r in this.tbNV.Rows)
                        {
                            if (!((bool)r.Cells[0].Value))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
                        {
                            checkboxHeaderNV.Checked = true;
                        }
                    }
                }
            }

            try
            {
                DataGridViewRow row = this.tbNV.Rows[e.RowIndex];
                if (Convert.ToBoolean(row.Cells[0].Value) || row.Cells[0].Selected)
                {
                    this.tbNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    this.tbNV.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex) { }

            try
            {
                if (this.tbNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.tbNV.CurrentRow.Selected = true;
                    this.txtMaNV.Text = this.tbNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.txtTenNV.Text = this.tbNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.txtCMND.Text = this.tbNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.txtGioiTinh.Text = this.tbNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.dtpNgaySinh.Value = (DateTime)this.tbNV.Rows[e.RowIndex].Cells[5].Value;
                    this.txtDiaChi.Text = this.tbNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                    this.txtSDT.Text = this.tbNV.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ chọn dòng tương ứng", "Cảnh báo!");
            }
        }

        private void txtTimKiemNV_Leave(object sender, EventArgs e)
        {
            if (this.txtTimKiemNV.Text == "")
            {
                this.txtTimKiemNV.Text = " Tìm kiếm trên bảng";
                this.txtTimKiemNV.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiemNV_Enter(object sender, EventArgs e)
        {
            if (this.txtTimKiemNV.Text == " Tìm kiếm trên bảng")
            {
                this.txtTimKiemNV.Text = "";
                this.txtTimKiemNV.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemNV_MouseClick(object sender, MouseEventArgs e)
        {
            this.toolTipTimKiemNV.SetToolTip(this.txtTimKiemNV, "Nhấn Enter để tìm kiếm nếu chứa ký tự có dấu.");
        }

        private void txtTimKiemNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtTimKiemNV.Text) || string.IsNullOrEmpty(this.txtTimKiemNV.Text) && Convert.ToInt32(e.KeyCode) == 8)
                this.loadDataTableNV();
            if (!(string.IsNullOrWhiteSpace(this.txtTimKiemNV.Text) && string.IsNullOrEmpty(this.txtTimKiemNV.Text)))
            {
                if (this.IsNumber(this.txtTimKiemNV.Text))
                    this.loadDataTableNV(int.Parse(this.txtTimKiemNV.Text));
                if (!this.IsNumber(this.txtTimKiemNV.Text))
                    this.loadDataTableNV(this.txtTimKiemNV.Text.Trim());
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(this.txtMaNV.Text);
            string tenNV = this.txtTenNV.Text;
            string cmnd = this.txtCMND.Text;
            string gioiTinh = this.txtGioiTinh.Text;
            DateTime ngaySinh = this.dtpNgaySinh.Value;
            string diaChi = this.txtDiaChi.Text;
            string sdt = this.txtSDT.Text;
            try
            {
                busNV.suaNV(maNV, tenNV, cmnd, gioiTinh, ngaySinh, diaChi, sdt);
                MessageBox.Show("Sửa thành công!!!", "Thông báo");
                this.resetTextBoxNV(maNV);
                this.loadDataTableNV();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại!!!", "Lỗi!");
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    busNVTaiKhoan.xoaNVTaiKhoan(int.Parse(this.txtMaNV.Text));
                    busNV.xoaNV(int.Parse(this.txtMaNV.Text));
                    MessageBox.Show("Xóa thành công!!!", "Thông báo");
                    this.btnRefreshNV_Click(sender, e);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Xóa thất bại!!!", "Lỗi!");
                }
            }
        }

        private void btnXoaNhieuNV_Click(object sender, EventArgs e)
        {
            bool checkBoxCells = false;
            for (int i = this.tbNV.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = this.tbNV.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    checkBoxCells = true;
                    break;
                }
            }
            if (checkBoxCells)
            {
                bool checkXoa = true;
                if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = this.tbNV.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = this.tbNV.Rows[i];
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            try
                            {
                                int maNV = Convert.ToInt32(row.Cells[1].Value);
                                busNVTaiKhoan.xoaNVTaiKhoan(maNV);
                                busNV.xoaNV(maNV);
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Xóa thất bại!!!", "Lỗi!");
                                checkXoa = false;
                                this.btnRefreshNV_Click(sender, e);
                            }
                        }
                    }
                }
                if (checkXoa)
                {
                    MessageBox.Show("Xóa hàng loạt thành công!!!", "Thông báo");
                    this.btnRefreshNV_Click(sender, e);
                }
            }
            if (!checkBoxCells)
                MessageBox.Show("Bạn chưa lựa chọn dòng nào để xóa!", "Thông báo");
        }

        private void btnRefreshNV_Click(object sender, EventArgs e)
        {
            this.txtTimKiem.ForeColor = Color.Gray;
            this.txtTimKiem.Text = " Tìm kiếm trên bảng";

            maNVHT = busNV.getMaNVHT();

            this.txtMaNV.Text = null;
            this.txtTenNV.Text = null;
            this.txtCMND.Text = null;
            this.txtGioiTinh.Text = null;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = null;
            this.txtSDT.Text = null;

            this.loadDataTableNV();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            MENU_ChucNang_Quantrivien_NVTaiKhoan FMenu_Quantri_NVTaiKhoan = new MENU_ChucNang_Quantrivien_NVTaiKhoan();
            FMenu_Quantri_NVTaiKhoan.ShowDialog();
        }

        public void resetTextBoxNV(int maNV)
        {
            var nv = busNV.getNV(maNV).First();
            this.txtMaNV.Text = nv.MaNV.ToString();
            this.txtTenNV.Text = nv.TenNV;
            this.txtCMND.Text = nv.CMND;
            this.txtGioiTinh.Text = nv.Gioitinh;
            this.dtpNgaySinh.Value = (DateTime)nv.Ngaysinh;
            this.txtDiaChi.Text = nv.Diachi;
            this.txtSDT.Text = nv.SDT;
        }

        //hint vuot qua so luong ky tu
    }
}
