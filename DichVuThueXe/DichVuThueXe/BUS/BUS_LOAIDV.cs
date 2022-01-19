using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public void ListServiceType(ComboBox cb)
        {
            cb.DataSource = dAO_LOAIDV.ListServiceType();
            cb.DisplayMember = "Tenloai";
            cb.ValueMember = "MaL";
        }
    }
}
