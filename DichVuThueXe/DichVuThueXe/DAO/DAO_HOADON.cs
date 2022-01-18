using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_HOADON
    {
        HTTXDataContext conn;
        public DAO_HOADON()
        {
            conn = new HTTXDataContext();
        }

        public HOADON getHoaDonFromMaHD(int ma)
        {
            HOADON hd = conn.HOADONs.FirstOrDefault(s => s.MaHDG == ma);
            return hd;
        }
    }
}
