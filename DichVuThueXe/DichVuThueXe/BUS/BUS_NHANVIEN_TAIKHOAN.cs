using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_NHANVIEN_TAIKHOAN
    {
        DAO_NHANVIEN_TAIKHOAN dAO_NHANVIEN_TAIKHOAN;

        public BUS_NHANVIEN_TAIKHOAN()
        {
            dAO_NHANVIEN_TAIKHOAN = new DAO_NHANVIEN_TAIKHOAN();
        }

        public int? getCheckDangNhap(String tk, String mk) 
        {
            int? check = dAO_NHANVIEN_TAIKHOAN.getCheckTAIKHOAN_DN(tk, mk);
            return check;
        }

        public NHANVIEN_TAIKHOAN getNV_TKLogin(String tk, String mk) 
        {
            NHANVIEN_TAIKHOAN tkDN = dAO_NHANVIEN_TAIKHOAN.getNV_TKLogin(tk, mk);
            return tkDN;
        }

        public int? SV_checkAccount_NV(int? makh, string taikhoan)
        {
            int? check = dAO_NHANVIEN_TAIKHOAN.SV_checkAccount_NV(makh, taikhoan);
            return check;
        }

        public int? addNhanVien_TaiKhoan(int? manv, string taikhoan, string matkhau)
        {
            int? checkadd = dAO_NHANVIEN_TAIKHOAN.addNhanVien_TaiKhoan(manv, taikhoan, matkhau);
            return checkadd;
        }
    }
}
