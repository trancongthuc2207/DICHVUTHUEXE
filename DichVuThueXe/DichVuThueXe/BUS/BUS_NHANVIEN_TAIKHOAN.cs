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

        public List<NHANVIEN_TAIKHOAN> getListNV_TK()
        {
            List<NHANVIEN_TAIKHOAN> listNVTK = dAO_NHANVIEN_TAIKHOAN.getListNV_TK();
            return listNVTK;
        }
        public List<NHANVIEN_TAIKHOAN> getListNV_TK(int maNV)
        {
            List<NHANVIEN_TAIKHOAN> listNVTK = dAO_NHANVIEN_TAIKHOAN.getListNV_TK(maNV);
            return listNVTK;
        }
        public List<NHANVIEN_TAIKHOAN> getListNV_TK(string taiKhoan)
        {
            List<NHANVIEN_TAIKHOAN> listNVTK = dAO_NHANVIEN_TAIKHOAN.getListNV_TK(taiKhoan);
            return listNVTK;
        }
        public void doiMKNV(int maNV, string matKhau)
        {
            dAO_NHANVIEN_TAIKHOAN.doiMKNV(maNV, matKhau);
        }
        public void doiChucVu(int maNV, int viTri)
        {
            dAO_NHANVIEN_TAIKHOAN.doiChucVu(maNV, viTri);
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

        public void xoaNVTaiKhoan(int maNV)
        {
            dAO_NHANVIEN_TAIKHOAN.xoaNVTaiKhoan(maNV);
        }
    }
}
