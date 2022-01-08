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

    }
}
