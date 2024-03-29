﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DichVuThueXe.DAO
{
    class DAO_NHANVIEN_TAIKHOAN
    {
        HTTXDataContext conn;

        public DAO_NHANVIEN_TAIKHOAN()
        {
            conn = new HTTXDataContext();        
        }

        public NHANVIEN_TAIKHOAN getTAIKHOAN_DN(NHANVIEN_TAIKHOAN account){
            NHANVIEN_TAIKHOAN tk = conn.NHANVIEN_TAIKHOANs.FirstOrDefault(a => a.Taikhoan == account.Taikhoan && a.Matkhau == account.Matkhau);
            return tk;
        }

        public List<NHANVIEN_TAIKHOAN> getListNV_TK() 
        {
            List<NHANVIEN_TAIKHOAN> ds = conn.NHANVIEN_TAIKHOANs.Select(s=>s).ToList();
            return ds;
        }

        public int? getCheckTAIKHOAN_DN(String tk, String mk)
        {
            int? check = 0;
            conn.SV_CheckDN(tk, mk, ref check);
            return check;
        }

        public NHANVIEN_TAIKHOAN getNV_TKLogin(String tk, String mk)
        {
            NHANVIEN_TAIKHOAN tkDN = conn.NHANVIEN_TAIKHOANs.FirstOrDefault(s => s.Taikhoan == tk && s.Matkhau == mk) ;
            return tkDN;
        }

        public int? SV_checkAccount_NV(int? makh, string taikhoan)
        {
            int? check = 0;
            conn.SV_checkAccount_NV(makh, taikhoan, ref check);
            return check;
        }

        public int? addNhanVien_TaiKhoan(int? manv, string taikhoan, string matkhau)
        {
            int? checkadd = 0;
            conn.SV_addNhanVien_TaiKhoan(manv, taikhoan, matkhau, ref checkadd);
            return checkadd;
        }

    }
}
