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
        BUS_KHACHHANG_TAIKHOAN bUS_KHACHHANG_TAIKHOAN;
        private static int vitriDK = SELECT_DANGKY.getVitri_DK();
        public GIAODIEN_DANGKY()
        {
            InitializeComponent();
            bUS_KHACHHANG = new BUS_KHACHHANG();
            bUS_KHACHHANG_TAIKHOAN = new BUS_KHACHHANG_TAIKHOAN();
            if(vitriDK == 1)
            {
                lblVitri.Text = "Nhân viên";
            }
            else
                if (vitriDK == 3)
            {
                lblVitri.Text = "Khách hàng";
            }
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
                    if (vitriDK == 3 && bUS_KHACHHANG_TAIKHOAN.SV_checkAccount_KH(bUS_KHACHHANG.getMaKHCurrent() + 1, txtTaikhoan.Text) == 0)
                    {
                        int? maKH = bUS_KHACHHANG.getMaKHCurrent() + 1;
                        ///THÔNG TIN KHÁCH HÀNG
                        string gt = "";
                        if (cbbGioiTinh.SelectedIndex == 0)
                            gt = "Nam";
                        else
                            if (cbbGioiTinh.SelectedIndex == 1)
                            gt = "Nữ";
                        DateTime ngays = Convert.ToDateTime(txtNgaySinh.Text);
                        if (bUS_KHACHHANG.addKhachHang(maKH, txtTen.Text, txtCMND.Text, gt, ngays, txtDiaChi.Text, txtSDT.Text) == 1)
                        {
                            bUS_KHACHHANG.addKhachHang(maKH, txtTen.Text, txtCMND.Text, gt, ngays, txtDiaChi.Text, txtSDT.Text);
                            ///ĐĂNG KÝ TÀI KHOẢN
                            bUS_KHACHHANG_TAIKHOAN.addKhachHang_TaiKhoan(maKH, txtTaikhoan.Text, txtMatKhau.Text);
                            MessageBox.Show("Thông tin và tài khoản khách hàng được thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Có thể CMND hoặc SDT đã được đăng ký rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Tài khoản đã sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ///XỬ LÝ ĐĂNG KÝ ACCOUNT CỦA NHÂN VIÊN

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
    }
}
