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
using DichVuThueXe.GUI;

namespace DichVuThueXe
{
    public partial class Form1 : Form
    {
        BUS_NHANVIEN_TAIKHOAN bUS_NHANVIEN_TAIKHOAN;
        BUS_KHACHHANG_TAIKHOAN bUS_KHACHHANG_TAIKHOAN;
        private static NHANVIEN_TAIKHOAN nvCur;
        private static KHACHHANG_TAIKHOAN khCur;
        public Form1()
        {
            InitializeComponent();
            bUS_NHANVIEN_TAIKHOAN = new BUS_NHANVIEN_TAIKHOAN();
            bUS_KHACHHANG_TAIKHOAN = new BUS_KHACHHANG_TAIKHOAN();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (cbbKindAccount.SelectedItem.ToString() == "Hệ Thống") 
            {
                int? check = bUS_NHANVIEN_TAIKHOAN.getCheckDangNhap(txtTK.Text, txtMK.Text);
                if (check == 1)
                {
                    MessageBox.Show("Chào mừng bạn đăng nhập vào hệ thống cho thuê xe với tư cách là User", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nvCur = bUS_NHANVIEN_TAIKHOAN.getNV_TKLogin(txtTK.Text, txtMK.Text);
                    MENU_ChucNangMain fMenu = new MENU_ChucNangMain();
                    fMenu.ShowDialog();
                }
                else
                    if (check == 2)
                {
                    MessageBox.Show("Chào mừng bạn đăng nhập vào hệ thống cho thuê xe với tư cách là Quản trị viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nvCur = bUS_NHANVIEN_TAIKHOAN.getNV_TKLogin(txtTK.Text, txtMK.Text);
                    nvCur = bUS_NHANVIEN_TAIKHOAN.getNV_TKLogin(txtTK.Text, txtMK.Text);
                    MENU_ChucNangMain fMenu = new MENU_ChucNangMain();
                    fMenu.ShowDialog();
                }
                else
                            if (check == 3)
                {
                    MessageBox.Show("Chào mừng bạn đăng nhập vào hệ thống cho thuê xe với tư cách là Khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nvCur = bUS_NHANVIEN_TAIKHOAN.getNV_TKLogin(txtTK.Text, txtMK.Text);
                    nvCur = bUS_NHANVIEN_TAIKHOAN.getNV_TKLogin(txtTK.Text, txtMK.Text);
                    MENU_ChucNangMain fMenu = new MENU_ChucNangMain();
                    fMenu.ShowDialog();
                }
                else
                    MessageBox.Show("SAI TÀI KHOẢN HOẶC MẬT KHẨU!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                if (cbbKindAccount.SelectedItem.ToString() == "Khách Hàng")
                {
                    int? check = bUS_KHACHHANG_TAIKHOAN.getCheckDangNhap(txtTK.Text, txtMK.Text);
                    if (check == 3)
                    {
                        MessageBox.Show("Chào mừng bạn đăng nhập vào hệ thống cho thuê xe với tư cách là Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        khCur = bUS_KHACHHANG_TAIKHOAN.getKH_TKLogin(txtTK.Text, txtMK.Text);
                        MENU_USER_KHACHHANG fMenuKH = new MENU_USER_KHACHHANG();
                        fMenuKH.ShowDialog();
                    }
                    else
                    {
                    MessageBox.Show("Có thể bạn chưa tài khoản hoặc sai thông tin đăng nhập, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }


        }

        public static NHANVIEN_TAIKHOAN getTK_NVCur() 
        {
            NHANVIEN_TAIKHOAN tkCur = new NHANVIEN_TAIKHOAN();
            return tkCur = nvCur;
        }

        public static KHACHHANG_TAIKHOAN getTKKH_NVCur()
        {
            KHACHHANG_TAIKHOAN tkCur = new KHACHHANG_TAIKHOAN();
            return tkCur = khCur;
        }
    }
}
