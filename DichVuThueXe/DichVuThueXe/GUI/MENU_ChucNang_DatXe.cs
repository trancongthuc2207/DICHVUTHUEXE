using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.BUS;

namespace DichVuThueXe.GUI
{
    public partial class MENU_ChucNang_DatXe : Form
    {
        BUS_LOAIDV bUS_LOAIDV;
        public MENU_ChucNang_DatXe()
        {
            InitializeComponent();
            bUS_LOAIDV = new BUS_LOAIDV();
        }

        private void MENU_ChucNang_DatXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hTTX_DataSet.LOAIDV' table. You can move, or remove it, as needed.
            this.lOAIDVTableAdapter.Fill(this.hTTX_DataSet.LOAIDV);

        }

        private void SelectItem_LOAIDV(object sender, EventArgs e)
        {
            LOAIDV dv = new LOAIDV();
            dv =  bUS_LOAIDV.getLOAIDV((int)cbb_LOAIDV.SelectedValue);
            lblMa.Text = dv.MaL.ToString();
            lblGia.Text = dv.Gia.ToString();
        }
    }
}
