using DichVuThueXe.BUS;
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

namespace DichVuThueXe.GUI
{
    public partial class MENU_ChucNang_Quantrivien_NVTaiKhoan : Form
    {
        private bool unCheckedAllNVTK = true;
        private CheckBox checkboxHeaderNVTK;
        BUS_NHANVIEN_TAIKHOAN busNVTaiKhoan;

        public MENU_ChucNang_Quantrivien_NVTaiKhoan()
        {
            InitializeComponent();
            busNVTaiKhoan = new BUS_NHANVIEN_TAIKHOAN();

            /////////////////////////////////////////// TIM KIEM
            this.txtTimKiemNVTK.ForeColor = Color.Gray;
            this.txtTimKiemNVTK.Text = " Tìm kiếm trên bảng";
            this.txtTimKiemNVTK.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            this.txtTimKiemNVTK.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);

            /////////////////////////////////////////// MK HIEN TAI
            this.txtMKHT.ForeColor = Color.Gray;
            this.txtMKHT.Text = " Mật khẩu hiện tại";
            this.txtMKHT.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            this.txtMKHT.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);

            /////////////////////////////////////////// MK MOI
            this.txtMKMoi.ForeColor = Color.Gray;
            this.txtMKMoi.Text = " Mật khẩu mới";
            this.txtMKMoi.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            this.txtMKMoi.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);

            /////////////////////////////////////////// NHAP LAI MK
            this.txtMKNhapLai.ForeColor = Color.Gray;
            this.txtMKNhapLai.Text = " Nhập lại mật khẩu mới";
            this.txtMKNhapLai.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            this.txtMKNhapLai.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);
        }

        private void MENU_ChucNang_Quantrivien_NVTaiKhoan_Load(object sender, EventArgs e)
        {
            this.initInputNVTK();
            this.loadDataTableNVTK();

            DataGridViewCheckBoxColumn checkBoxColumnNVTK = new DataGridViewCheckBoxColumn();
            checkBoxColumnNVTK.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkBoxColumnNVTK.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbNVTaiKhoan.Columns.Insert(0, checkBoxColumnNVTK);

            Rectangle rect = this.tbNVTaiKhoan.GetCellDisplayRectangle(0, -1, false);

            rect.X = rect.Location.X + (rect.Width / 16);
            rect.Y = rect.Location.Y + (rect.Height / 16);
            checkboxHeaderNVTK = new CheckBox();
            checkboxHeaderNVTK.BackColor = Color.FromArgb(0, 80, 200);
            checkboxHeaderNVTK.Name = "checkBoxHeader";
            checkboxHeaderNVTK.Size = new Size(18, 18);
            checkboxHeaderNVTK.Location = rect.Location;
            checkboxHeaderNVTK.CheckAlign = ContentAlignment.MiddleCenter;
            checkBoxColumnNVTK.ReadOnly = false;

            checkboxHeaderNVTK.CheckedChanged += new EventHandler(checkboxHeaderNVTK_CheckedChanged);

            this.tbNVTaiKhoan.Controls.Add(checkboxHeaderNVTK);
        }

        private void checkboxHeaderNVTK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHeaderNVTK.Checked)
            {
                for (int i = 0; i < this.tbNVTaiKhoan.RowCount; i++)
                {
                    this.tbNVTaiKhoan[0, i].Value = true;
                }
            }
            else
            {
                if (unCheckedAllNVTK)
                {
                    for (int i = 0; i < this.tbNVTaiKhoan.RowCount; i++)
                    {
                        this.tbNVTaiKhoan[0, i].Value = false;
                    }
                }
            }
            unCheckedAllNVTK = true;
        }

        public void initInputNVTK()
        {
            this.txtMaNV.Text = null;
            this.txtTaiKhoan.Text = null;
            this.txtViTri.Text = null;
        }

        public void loadDataTableNVTK()
        {
            this.busNVTaiKhoan = new BUS_NHANVIEN_TAIKHOAN();
            this.tbNVTaiKhoan.DataSource = busNVTaiKhoan.getListNV_TK();
        }

        public void loadDataTableNVTK(int maNV)
        {
            this.busNVTaiKhoan = new BUS_NHANVIEN_TAIKHOAN();
            this.tbNVTaiKhoan.DataSource = busNVTaiKhoan.getListNV_TK(maNV);
        }

        public void loadDataTableNVTK(string taiKhoan)
        {
            this.busNVTaiKhoan = new BUS_NHANVIEN_TAIKHOAN();
            this.tbNVTaiKhoan.DataSource = busNVTaiKhoan.getListNV_TK(taiKhoan);
        }

        private void tbNVTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tbNVTaiKhoan.SelectedCells.Count == 0)
            {
                if (e.RowIndex >= 0)
                {
                    if ((bool)this.tbNVTaiKhoan[0, e.RowIndex].Value)
                    {
                        this.tbNVTaiKhoan[0, e.RowIndex].Value = false;
                        foreach (DataGridViewRow r in this.tbNVTaiKhoan.Rows)
                        {
                            if ((bool)r.Cells[0].Value)
                            {
                                unCheckedAllNVTK = false;
                                break;
                            }
                        }
                        checkboxHeaderNVTK.Checked = false;
                    }
                    else
                    {
                        this.tbNVTaiKhoan[0, e.RowIndex].Value = true;
                        bool check = true;
                        foreach (DataGridViewRow r in this.tbNVTaiKhoan.Rows)
                        {
                            if (!((bool)r.Cells[0].Value))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
                        {
                            checkboxHeaderNVTK.Checked = true;
                        }
                    }
                }
            }

            try
            {
                DataGridViewRow row = this.tbNVTaiKhoan.Rows[e.RowIndex];
                if (Convert.ToBoolean(row.Cells[0].Value) || row.Cells[0].Selected)
                {
                    this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    this.tbNVTaiKhoan.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex) { }

            try
            {
                if (this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.tbNVTaiKhoan.CurrentRow.Selected = true;
                    this.txtMaNV.Text = this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.txtTaiKhoan.Text = this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.txtViTri.Text = this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ chọn dòng tương ứng", "Cảnh báo!");
            }
        }

        private void txtTimKiemNVTK_Leave(object sender, EventArgs e)
        {
            if (this.txtTimKiemNVTK.Text == null)
            {
                this.txtTimKiemNVTK.Text = " Tìm kiếm trên bảng";
                this.txtTimKiemNVTK.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiemNVTK_Enter(object sender, EventArgs e)
        {
            if (this.txtTimKiemNVTK.Text == " Tìm kiếm trên bảng")
            {
                this.txtTimKiemNVTK.Text = null;
                this.txtTimKiemNVTK.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemNVTK_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtTimKiemNVTK.Text) || string.IsNullOrEmpty(this.txtTimKiemNVTK.Text) && Convert.ToInt32(e.KeyCode) == 8)
                this.loadDataTableNVTK();
            if (!(string.IsNullOrWhiteSpace(this.txtTimKiemNVTK.Text) && string.IsNullOrEmpty(this.txtTimKiemNVTK.Text)))
            {
                if (this.IsNumber(this.txtTimKiemNVTK.Text))
                    this.loadDataTableNVTK(int.Parse(this.txtTimKiemNVTK.Text));
                if (!this.IsNumber(this.txtTimKiemNVTK.Text))
                    this.loadDataTableNVTK(this.txtTimKiemNVTK.Text.Trim());
            }
        }

        private void txtMKHT_Leave(object sender, EventArgs e)
        {
            if (this.txtMKHT.Text == "")
            {
                this.txtMKHT.UseSystemPasswordChar = false;
                this.txtMKHT.Text = " Mật khẩu hiện tại";
                this.txtMKHT.ForeColor = Color.Gray;
            }
        }

        private void txtMKHT_Enter(object sender, EventArgs e)
        {
            if (this.txtMKHT.Text == " Mật khẩu hiện tại")
            {
                this.txtMKHT.Text = "";
                this.txtMKHT.ForeColor = Color.Black;
                this.txtMKHT.UseSystemPasswordChar = true;
            }
        }

        private void txtMKMoi_Leave(object sender, EventArgs e)
        {
            if (this.txtMKMoi.Text == "")
            {
                this.txtMKMoi.UseSystemPasswordChar = false;
                this.txtMKMoi.Text = " Mật khẩu mới";
                this.txtMKMoi.ForeColor = Color.Gray;
            }
        }

        private void txtMKMoi_Enter(object sender, EventArgs e)
        {
            if (this.txtMKMoi.Text == " Mật khẩu mới")
            {
                this.txtMKMoi.Text = "";
                this.txtMKMoi.ForeColor = Color.Black;
                this.txtMKMoi.UseSystemPasswordChar = true;
            }
        }

        private void txtMKNhapLai_Leave(object sender, EventArgs e)
        {
            if (this.txtMKNhapLai.Text == "")
            {
                this.txtMKNhapLai.UseSystemPasswordChar = false;
                this.txtMKNhapLai.Text = " Nhập lại mật khẩu mới";
                this.txtMKNhapLai.ForeColor = Color.Gray;
            }
        }

        private void txtMKNhapLai_Enter(object sender, EventArgs e)
        {
            if (this.txtMKNhapLai.Text == " Nhập lại mật khẩu mới")
            {
                this.txtMKNhapLai.Text = "";
                this.txtMKNhapLai.ForeColor = Color.Black;
                this.txtMKNhapLai.UseSystemPasswordChar = true;
            }
        }

        private static bool checkBtnHien = true;
        private void btnHienAn_Click(object sender, EventArgs e)
        {
            if (checkBtnHien)
            {
                this.btnHienAn.Text = "Ẩn";
                this.btnHienAn.BackColor = Color.LightGray;
                //this.btnHienAn.FlatAppearance.BorderColor = Color.Black;
                checkBtnHien = false;
            }
            else
            {
                this.btnHienAn.Text = "Hiện";
                this.btnHienAn.BackColor = Color.White;
                //this.btnHienAn.FlatAppearance.BorderColor = Color.White;
                checkBtnHien = true;
            }

            //////////////////////////////////////////////////
            
            if (this.txtMKHT.UseSystemPasswordChar || this.txtMKHT.Text.Equals(" Mật khẩu hiện tại"))
            {
                this.txtMKHT.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMKHT.UseSystemPasswordChar = true;
            }

            //////////////////////////////////////////////////

            if (this.txtMKMoi.UseSystemPasswordChar || this.txtMKMoi.Text.Equals(" Mật khẩu mới"))
            {
                this.txtMKMoi.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMKMoi.UseSystemPasswordChar = true;
            }

            //////////////////////////////////////////////////

            if (this.txtMKNhapLai.UseSystemPasswordChar || this.txtMKNhapLai.Text.Equals(" Nhập lại mật khẩu mới"))
            {
                this.txtMKNhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMKNhapLai.UseSystemPasswordChar = true;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            //k dc trong
            //mk hien tai chinh xac
            //nhap moi + nhap lai phai trung nhau
            if (MessageBox.Show("Xác nhận đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int maNV = int.Parse(this.txtMaNV.Text);
                string matKhau = this.txtMKNhapLai.Text;
                try
                {
                    busNVTaiKhoan.doiMKNV(maNV, matKhau);
                    MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo");
                    this.btnRefeshNVTK_Click(sender, e);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!!!", "Lỗi!");
                }
            }
        }

        private void btnChoPhepSD_Click(object sender, EventArgs e)
        {
            bool checkBoxCells = false;
            for (int i = this.tbNVTaiKhoan.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = this.tbNVTaiKhoan.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    checkBoxCells = true;
                    break;
                }
            }
            if (checkBoxCells)
            {
                bool checkThayDoi = true;
                if (MessageBox.Show("Xác nhận |cho phép sử dụng| các lựa chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = this.tbNVTaiKhoan.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = this.tbNVTaiKhoan.Rows[i];
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            try
                            {
                                int maNV = Convert.ToInt32(row.Cells[1].Value);
                                busNVTaiKhoan.doiChucVu(maNV, 1);
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Mở khóa thất bại!!!", "Lỗi!");
                                checkThayDoi = false;
                                this.btnRefeshNVTK_Click(sender, e);
                            }
                        }
                    }
                }
                if (checkThayDoi)
                {
                    MessageBox.Show("Mở khóa thành công!!!", "Thông báo");
                    this.btnRefeshNVTK_Click(sender, e);
                }
            }
            if (!checkBoxCells)
            {
                MessageBox.Show("Bạn chưa lựa chọn dòng nào để thực hiện chức năng!", "Thông báo");
            }
        }

        private void btnCamSD_Click(object sender, EventArgs e)
        {
            bool checkBoxCells = false;
            for (int i = this.tbNVTaiKhoan.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = this.tbNVTaiKhoan.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    checkBoxCells = true;
                    break;
                }
            }
            if (checkBoxCells)
            {
                bool checkThayDoi = true;
                if (MessageBox.Show("Xác nhận |cấm sử dụng| các lựa chọn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = this.tbNVTaiKhoan.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = this.tbNVTaiKhoan.Rows[i];
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            try
                            {
                                int maNV = Convert.ToInt32(row.Cells[1].Value);
                                busNVTaiKhoan.doiChucVu(maNV, 0);
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Cấm thất bại!!!", "Lỗi!");
                                checkThayDoi = false;
                                this.btnRefeshNVTK_Click(sender, e);
                            }
                        }
                    }
                }
                if (checkThayDoi)
                {
                    MessageBox.Show("Cấm sử dụng thành công!!!", "Thông báo");
                    this.btnRefeshNVTK_Click(sender, e);
                }
            }
            if (!checkBoxCells)
            {
                MessageBox.Show("Bạn chưa lựa chọn dòng nào để thực hiện chức năng!", "Thông báo");
            }
        }

        private void btnRefeshNVTK_Click(object sender, EventArgs e)
        {
            this.txtTimKiemNVTK.ForeColor = Color.Gray;
            this.txtTimKiemNVTK.Text = " Tìm kiếm trên bảng";

            this.txtMaNV.Text = null;
            this.txtTaiKhoan.Text = null;
            this.txtViTri.Text = null;

            this.txtMKHT.ForeColor = Color.Gray;
            this.txtMKHT.Text = " Mật khẩu hiện tại";
            this.txtMKHT.UseSystemPasswordChar = false;

            this.txtMKMoi.ForeColor = Color.Gray;
            this.txtMKMoi.Text = " Mật khẩu mới";
            this.txtMKMoi.UseSystemPasswordChar = false;

            this.txtMKNhapLai.ForeColor = Color.Gray;
            this.txtMKNhapLai.Text = " Nhập lại mật khẩu mới";
            this.txtMKNhapLai.UseSystemPasswordChar = false;

            this.btnHienAn.Text = "Hiện";
            this.btnHienAn.BackColor = Color.White;
            checkBtnHien = true;

            this.loadDataTableNVTK();
        }

        public void resetTextBoxNVTK(string taiKhoan)
        {
            var tk = this.busNVTaiKhoan.getListNV_TK(taiKhoan).First();
            this.txtMaNV.Text = tk.MaNV.ToString();
            this.txtTaiKhoan.Text = tk.Taikhoan.ToString();
            this.txtViTri.Text = tk.Vitri.ToString();
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

        // loi 1 ty phan leave enter txt tim kiem
    }
}
