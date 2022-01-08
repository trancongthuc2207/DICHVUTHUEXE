using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;


namespace DichVuThueXe.BUS
{
    class BUS_LOAIDV
    {
        DAO_LOAIDV dAO_LOAIDV;
        public BUS_LOAIDV()
        {
            dAO_LOAIDV = new DAO_LOAIDV();
        }

        public LOAIDV getLOAIDV(int ldv)
        {
            LOAIDV loai = dAO_LOAIDV.getLOAIDV(ldv);
            return loai ;
        }
    }
}
