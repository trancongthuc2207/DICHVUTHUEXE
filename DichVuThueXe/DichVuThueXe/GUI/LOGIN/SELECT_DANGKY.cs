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
    public partial class SELECT_DANGKY : Form
    {
        BUS_NHANVIEN_TAIKHOAN bUS_NHANVIEN_TAIKHOAN;
        BUS_NHANVIEN bUS_NHANVIEN;
        private static int vitri = 0;
        private static int maNVCur = 0;
        public SELECT_DANGKY()
        {
            bUS_NHANVIEN_TAIKHOAN = new BUS_NHANVIEN_TAIKHOAN();
            bUS_NHANVIEN = new BUS_NHANVIEN();
            InitializeComponent();
        }

        private void btnDK_NV_Click(object sender, EventArgs e)
        {
            vitri = 1;
            this.Hide();
            GIAODIEN_DANGKY gd = new GIAODIEN_DANGKY();
            gd.ShowDialog();
            this.Close();
        }

        private void btnDK_KH_Click(object sender, EventArgs e)
        {
            vitri = 3;
            this.Hide();
            GIAODIEN_DANGKY gd = new GIAODIEN_DANGKY();
            gd.ShowDialog();
            this.Close();
        }

        public static int getVitri_DK()
        {
            return vitri;
        }

        public static int getMANV_DK()
        {
            return maNVCur;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
