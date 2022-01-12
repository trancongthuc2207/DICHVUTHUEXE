using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_NHANVIEN
    {
        DAO_NHANVIEN dAO_NHANVIEN;

        public BUS_NHANVIEN()
        {
            dAO_NHANVIEN = new DAO_NHANVIEN();
        }

        public NHANVIEN getNVFromTK(NHANVIEN_TAIKHOAN acc) 
        {
            NHANVIEN nv = dAO_NHANVIEN.getNhanVienFromTK(acc);
            return nv;
        }
        public int? getMaNVCurrent()
        {
            int? maCur = dAO_NHANVIEN.getMaNVCurrent();
            return maCur;
        }
        public int? addNhanVien(int? maNV, string ten, string cmnd, string gioitinh, DateTime ngaysinh, string diachi, string sdt)
        {
            int? checkadd = dAO_NHANVIEN.addNhanVien(maNV, ten, cmnd, gioitinh, ngaysinh, diachi, sdt);
            return checkadd;
        }
    }
}
