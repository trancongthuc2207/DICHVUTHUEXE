using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_KHACHHANG
    {
        HTTXDataContext conn;
        public DAO_KHACHHANG()
        {
            conn = new HTTXDataContext();
        }

        public KHACHHANG getKhachHangFromTK(KHACHHANG_TAIKHOAN acc)
        {
            KHACHHANG kh = conn.KHACHHANGs.FirstOrDefault(s => s.MaKH == acc.MaKH);
            return kh;
        }

        public int? getMaKHCurrent()
        {
            int? maCur = 0;
            conn.getMaKHCurrent(ref maCur);
            return maCur;
        }

        public int? addKhachHang(int? maKH, string ten, string cmnd, string gioitinh, DateTime ngaysinh,string diachi, string sdt) 
        {
            int? checkadd = 0;
            conn.SV_addKhachHang(maKH, ten, cmnd, gioitinh, ngaysinh, diachi, sdt, ref checkadd);
            return checkadd;
        }
        public KHACHHANG getKH1(int maKH)
        {
            var get = (from s in conn.KHACHHANGs where s.MaKH == maKH select s).First();
            return get;
        }
    }
}
