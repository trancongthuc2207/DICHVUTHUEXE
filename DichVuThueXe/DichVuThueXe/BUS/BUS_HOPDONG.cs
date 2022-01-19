using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_HOPDONG
    {
        DAO_HOPDONG dAO_HOPDONG;

        public BUS_HOPDONG()
        {
            dAO_HOPDONG = new DAO_HOPDONG();
        }

        public HOPDONG getHopDongFromMaHDG(int ma)
        {
            HOPDONG hdg = dAO_HOPDONG.getHopDongFromMaHDG(ma);
            return hdg;
        }

        public void suaHDG_Xe(int maHDG, int maXe)
        {
            dAO_HOPDONG.suaHDG_Xe(maHDG, maXe);
        }

        public void suaHDG_MaL_Xe(int maHDG, int maL, int maXe)
        {
            dAO_HOPDONG.suaHDG_MaL_Xe(maHDG, maL, maXe);
        }

        public List<HOPDONG> getHopDong()
        {
            return dAO_HOPDONG.getHopDong();
        }
        public int? GetMaxIDContract()
        {
            int? MaxID = dAO_HOPDONG.GetMaxContractID();
            return MaxID;
        }
        public bool AddContract(HOPDONG HopDong)
        {
            try
            {
                dAO_HOPDONG.AddContract(HopDong);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
