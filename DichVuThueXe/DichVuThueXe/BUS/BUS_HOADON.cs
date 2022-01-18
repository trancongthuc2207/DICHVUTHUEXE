using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_HOADON
    {
        DAO_HOADON dAO_HOADON;

        public BUS_HOADON()
        {
            dAO_HOADON = new DAO_HOADON();
        }

        public HOADON getHoaDonFromMaHD(int ma)
        {
            HOADON hd = dAO_HOADON.getHoaDonFromMaHD(ma);
            return hd;
        }
    }
}
