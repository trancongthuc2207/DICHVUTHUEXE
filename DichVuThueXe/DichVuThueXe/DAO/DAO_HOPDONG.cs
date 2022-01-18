using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_HOPDONG
    {
        HTTXDataContext conn;
        public DAO_HOPDONG()
        {
            conn = new HTTXDataContext();
        }

        public HOPDONG getHopDongFromMaHDG(int ma)
        {
            HOPDONG hdg = conn.HOPDONGs.FirstOrDefault(s => s.MaHDG == ma);
            return hdg;
        }

        public void suaHDG_Xe(int maHDG,int maXe)
        {
            var sua = (from s in conn.HOPDONGs where s.MaHDG == maHDG select s).First();
            sua.Maxe = maXe;
            conn.SubmitChanges();
        }

        public void suaHDG_MaL_Xe(int maHDG,int maL ,int maXe)
        {
            var sua = (from s in conn.HOPDONGs where s.MaHDG == maHDG select s).First();
            sua.MaL = maL;
            sua.Maxe = maXe;
            conn.SubmitChanges();
        }

        public List<HOPDONG> getHopDong()
        {
            var get = from s in conn.HOPDONGs select s;
            return get.ToList();
        }
    }
}
