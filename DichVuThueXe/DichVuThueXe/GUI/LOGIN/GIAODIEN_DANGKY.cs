using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.BUS;

namespace DichVuThueXe.GUI
{
    public partial class GIAODIEN_DANGKY : Form
    {
        BUS_KHACHHANG bUS_KHACHHANG;
        BUS_NHANVIEN bUS_NHANVIEN;
        BUS_KHACHHANG_TAIKHOAN bUS_KHACHHANG_TAIKHOAN;
        BUS_NHANVIEN_TAIKHOAN bUS_NHANVIEN_TAIKHOAN;
        public GIAODIEN_DANGKY()
        {
            InitializeComponent();
            bUS_KHACHHANG = new BUS_KHACHHANG();
            bUS_NHANVIEN = new BUS_NHANVIEN();
            bUS_KHACHHANG_TAIKHOAN = new BUS_KHACHHANG_TAIKHOAN();
            bUS_NHANVIEN_TAIKHOAN = new BUS_NHANVIEN_TAIKHOAN();
            if (SELECT_DANGKY.getVitri_DK() == 1)
            {
                lblVitri.Text = "Nhân viên";
            }
            else
                if (SELECT_DANGKY.getVitri_DK() == 3)
            {
                lblVitri.Text = "Khách hàng";
            }
            //SET UP GIOI HAN
            this.initGioiHan();

        }

        public bool inputFullOption()
        {
            bool check = false;
            if (!string.IsNullOrEmpty(txtTen.Text) && !string.IsNullOrEmpty(txtCMND.Text) && cbbGioiTinh.SelectedIndex != -1 && !string.IsNullOrEmpty(txtNgaySinh.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTaikhoan.Text) && !string.IsNullOrEmpty(txtMatKhau.Text) && !string.IsNullOrEmpty(txtXacNhanMK.Text))
                check = true;
            return check;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (inputFullOption())
            {
                if (isXacNhanMK())
                {
                    ////XỬ LÝ ĐĂNG KÝ ACCOUNT CỦA KHÁCH HÀNG
                    if (SELECT_DANGKY.getVitri_DK() == 3 && bUS_KHACHHANG_TAIKHOAN.SV_checkAccount_KH(bUS_KHACHHANG.getMaKHCurrent() + 1, txtTaikhoan.Text) == 0)
                    {
                        int? maKH = bUS_KHACHHANG.getMaKHCurrent() + 1;
                        ///THÔNG TIN KHÁCH HÀNG
                        string gt = "";
                        if (cbbGioiTinh.SelectedIndex == 0)
                            gt = "Nam";
                        else
                            if (cbbGioiTinh.SelectedIndex == 1)
                            gt = "Nữ";
                        try
                        {
                            DateTime ngays = Convert.ToDateTime(txtNgaySinh.Text);
                            if (bUS_KHACHHANG.addKhachHang(maKH, txtTen.Text, txtCMND.Text, gt, ngays, txtDiaChi.Text, txtSDT.Text) == 1)
                            {
                                bUS_KHACHHANG.addKhachHang(maKH, txtTen.Text, txtCMND.Text, gt, ngays, txtDiaChi.Text, txtSDT.Text);
                                ///ĐĂNG KÝ TÀI KHOẢN
                                bUS_KHACHHANG_TAIKHOAN.addKhachHang_TaiKhoan(maKH, txtTaikhoan.Text, txtMatKhau.Text);
                                MessageBox.Show("Thông tin và tài khoản khách hàng được thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.initTextBox();
                            }
                            else
                                MessageBox.Show("Có thể CMND hoặc SDT đã được đăng ký rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch 
                        {
                            MessageBox.Show("Lỗi định dạng ngày sinh!! Phải nhập đúng yyyy-mm-dd ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                            
                        }
                     }
                    else
                        if (SELECT_DANGKY.getVitri_DK() == 3 && bUS_KHACHHANG_TAIKHOAN.SV_checkAccount_KH(bUS_KHACHHANG.getMaKHCurrent() + 1, txtTaikhoan.Text) == 1)
                            MessageBox.Show("Tài khoản đã sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ///XỬ LÝ ĐĂNG KÝ ACCOUNT CỦA NHÂN VIÊN
                    ///
                    if (SELECT_DANGKY.getVitri_DK() == 1 && bUS_NHANVIEN_TAIKHOAN.SV_checkAccount_NV(bUS_NHANVIEN.getMaNVCurrent() + 1, txtTaikhoan.Text) == 0)
                    {
                        int? maNV = bUS_NHANVIEN.getMaNVCurrent() + 1;
                        ///THÔNG TIN NHÂN VIÊN
                        string gt = "";
                        if (cbbGioiTinh.SelectedIndex == 0)
                            gt = "Nam";
                        else
                            if (cbbGioiTinh.SelectedIndex == 1)
                            gt = "Nữ";
                        try
                        {
                            DateTime ngays = Convert.ToDateTime(txtNgaySinh.Text);
                            if (bUS_NHANVIEN.addNhanVien(maNV, txtTen.Text, txtCMND.Text, gt, ngays, txtDiaChi.Text, txtSDT.Text) == 1)
                            {
                                bUS_NHANVIEN.addNhanVien(maNV, txtTen.Text, txtCMND.Text, gt, ngays, txtDiaChi.Text, txtSDT.Text);
                                ///ĐĂNG KÝ TÀI KHOẢN
                                bUS_NHANVIEN_TAIKHOAN.addNhanVien_TaiKhoan(maNV, txtTaikhoan.Text, txtMatKhau.Text);
                                MessageBox.Show("Thông tin và tài khoản nhân viên được thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.initTextBox();
                            }
                            else
                                MessageBox.Show("Có thể CMND hoặc SDT đã được đăng ký rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi định dạng ngày sinh!! Phải nhập đúng yyyy-mm-dd ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                        if (SELECT_DANGKY.getVitri_DK() == 1 && bUS_NHANVIEN_TAIKHOAN.SV_checkAccount_NV(bUS_NHANVIEN.getMaNVCurrent() + 1, txtTaikhoan.Text) == 1)
                        MessageBox.Show("Tài khoản đã sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Mật khẩu xác nhận không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("CHƯA ĐỦ THÔNG TIN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public bool isXacNhanMK() 
        {
            bool check = false; // không trùng
            if (this.txtMatKhau.Text.Equals(this.txtXacNhanMK.Text))
                check = true;
            return check;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SELECT_DANGKY fSelect = new SELECT_DANGKY();
            if (inputFullOption()) 
            {
                DialogResult dlr = MessageBox.Show("Hiện tại, thông tin của bạn đang nhập. Bạn có muốn trở về không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    this.Hide();
                    fSelect.ShowDialog();
                    this.Close();
                }
            }
            else 
            {
                this.Hide();
                fSelect.ShowDialog();
                this.Close();
            }
            
        }


        /// XỬ LÝ BẮT LỖI NHẬP
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(txtSDT.Text))
                    this.lblNhacnhoSDT.Hide();
                else
                    if(string.IsNullOrEmpty(txtSDT.Text))
                        this.lblNhacnhoSDT.Show();
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNgaySinh.Text))
                this.lblNhacnhoNgaySinh.Hide();
            else
                if (string.IsNullOrEmpty(txtNgaySinh.Text))
                    this.lblNhacnhoNgaySinh.Show();
        }

        public void initGioiHan() 
        {
            this.txtSDT.MaxLength = 10;
            this.txtMatKhau.MaxLength = 25;
            this.txtXacNhanMK.MaxLength = 25;
            this.txtCMND.MaxLength = 12;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatKhau.Text))
                this.lblNhacnhoMK.Hide();
            else
                    if (string.IsNullOrEmpty(txtMatKhau.Text))
                this.lblNhacnhoMK.Show();
        }

        private void check_XemMK_CheckedChanged(object sender, EventArgs e)
        {
            if(check_XemMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtXacNhanMK.UseSystemPasswordChar = false;
            }
            else
                if (!check_XemMK.Checked)
                {
                    txtMatKhau.UseSystemPasswordChar = true;
                    txtXacNhanMK.UseSystemPasswordChar = true;
                }    
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void initTextBox()
        {
            this.txtTen.Text = "";
            this.txtCMND.Text = "";
            this.cbbGioiTinh.SelectedIndex = -1;
            this.txtDiaChi.Text = "";
            this.txtSDT.Text = "";
            this.txtNgaySinh.Text = "   -   -   ";
            this.txtTaikhoan.Text = "";
            this.txtMatKhau.Text = "";
            this.txtXacNhanMK.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.initTextBox();
        }
    }
}
