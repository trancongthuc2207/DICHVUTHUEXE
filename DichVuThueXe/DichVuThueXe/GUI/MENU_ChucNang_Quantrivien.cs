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
        private bool unCheckedAll = true;
        private CheckBox checkboxHeader;
        BUS_XE busXe;
        public MENU_ChucNang_Quantrivien()
        {
            InitializeComponent();
            busXe = new BUS_XE();
        }
        private void MENU_ChucNang_Quantrivien_Load(object sender, EventArgs e)
        {
            this.loadDataTableXe();
            this.initInput();

            ///////////////////////////////////////////
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbXe.Columns.Insert(0, checkBoxColumn);

            Rectangle rect = this.tbXe.GetCellDisplayRectangle(0, -1, false);

            rect.X = rect.Location.X + (rect.Width / 14);
            rect.Y = rect.Location.Y + (rect.Height / 12);
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
        }
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
        public void loadDataTableXe()
        {
            this.tbXe.DataSource = busXe.getXe();
        }
        public void loadDataTableXe(int maXe)
        {
            this.tbXe.DataSource = busXe.getXe(maXe);
        }
        public void loadDataTableXe(string tenXe)
        {
            this.tbXe.DataSource = busXe.getXe(tenXe);
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            this.loadDataTableXe();
            this.initInput();
        }
        private void tbXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tbXe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null || this.tbXe.SelectedCells.Count == 0)
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
            if (this.tbXe.SelectedCells.Count == 0) //CON MOT SO VAN DE VOI CLICK
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
        }
        public void initInput()
        {
            maXeHT = busXe.getMaXeHT();
            var xe = busXe.getXe(maXeHT).First();
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
        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(this.txtTimKiem.Text) || string.IsNullOrEmpty(this.txtTimKiem.Text)) && Convert.ToInt32(e.KeyCode) == 8)
                this.loadDataTableXe();
            if (!(string.IsNullOrWhiteSpace(this.txtTimKiem.Text) || string.IsNullOrEmpty(this.txtTimKiem.Text)))
                if (this.IsNumber(this.txtTimKiem.Text))
                    this.loadDataTableXe(int.Parse(this.txtTimKiem.Text));
            //if (!kw.Equals("") || !kw.Equals(null))
            //    this.loadDataTableXe(kw);
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
            bool trangThai = false;
            if (rbtnDiChuyen.Checked)
                trangThai = true;
            int maLoai = int.Parse(this.txtMaLoai.Text);
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
            try
            {
                busXe.xoaXe(int.Parse(this.txtMaXe.Text));
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                this.loadDataTableXe();
                this.btnRefresh_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa thất bại!!!", "Lỗi!");
            }
        }
        private void btnXoaNhieu_Click(object sender, EventArgs e)
        {

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
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
    }
}
