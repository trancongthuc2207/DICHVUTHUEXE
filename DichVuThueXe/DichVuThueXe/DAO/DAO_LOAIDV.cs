using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_LOAIDV
    {
        HTTXDataContext conn;
        public DAO_LOAIDV()
        {
            conn = new HTTXDataContext();
        }

        public LOAIDV getLOAIDV(int mdv)
        {
            LOAIDV dvData = conn.LOAIDVs.FirstOrDefault(s => s.MaL == mdv);
            return dvData;
        }
        public dynamic ListServiceType()
        {
            dynamic ds = conn.LOAIDVs.Select(s => new
            {
                s.MaL,
                s.Tenloai
            }).ToList();
            return ds;
        }
    }
}
