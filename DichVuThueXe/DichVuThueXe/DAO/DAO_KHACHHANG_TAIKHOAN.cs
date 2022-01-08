using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_KHACHHANG_TAIKHOAN
    {
        HTTXDataContext conn;

        public DAO_KHACHHANG_TAIKHOAN()
        {
            conn = new HTTXDataContext();
        }

        public KHACHHANG_TAIKHOAN getTAIKHOANKH_DN(KHACHHANG_TAIKHOAN account)
        {
            KHACHHANG_TAIKHOAN tk = conn.KHACHHANG_TAIKHOANs.FirstOrDefault(a => a.Taikhoan == account.Taikhoan && a.Matkhau == account.Matkhau);
            return tk;
        }

        public List<KHACHHANG_TAIKHOAN> getListKH_TK()
        {
            List<KHACHHANG_TAIKHOAN> ds = conn.KHACHHANG_TAIKHOANs.Select(s => s).ToList();
            return ds;
        }

        public int? getCheckTAIKHOANKH_DN(String tk, String mk)
        {
            int? check = 0;
            conn.SV_CheckDN_KH(tk, mk, ref check);
            return check;
        }

        public KHACHHANG_TAIKHOAN getKH_TKLogin(String tk, String mk)
        {
            KHACHHANG_TAIKHOAN tkDN = conn.KHACHHANG_TAIKHOANs.FirstOrDefault(s => s.Taikhoan == tk && s.Matkhau == mk);
            return tkDN;
        }
    }
}
