﻿using System;
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
    }
}
