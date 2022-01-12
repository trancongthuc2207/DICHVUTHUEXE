using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_NHANVIEN
    {
        HTTXDataContext conn;
        public DAO_NHANVIEN()
        {
            conn = new HTTXDataContext();
        }

        public NHANVIEN getNhanVienFromTK(NHANVIEN_TAIKHOAN acc)
        {
            NHANVIEN nv = conn.NHANVIENs.FirstOrDefault(s => s.MaNV == acc.MaNV);
            return nv;
        }

        public int? getMaNVCurrent() 
        {
            int? maCur = 0;
            conn.getMaNVCurrent(ref maCur);
            return maCur;
        }

        public int? addNhanVien(int? maNV, string ten, string cmnd, string gioitinh, DateTime ngaysinh, string diachi, string sdt)
        {
            int? checkadd = 0;
            conn.SV_addNhanVien(maNV, ten, cmnd, gioitinh, ngaysinh, diachi, sdt, ref checkadd);
            return checkadd;
        }
    }
}
