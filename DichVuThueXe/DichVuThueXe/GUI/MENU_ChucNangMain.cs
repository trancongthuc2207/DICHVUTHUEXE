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
using DichVuThueXe.GUI;
using DichVuThueXe.PRINT;

namespace DichVuThueXe.GUI
{
    public partial class MENU_ChucNangMain : Form
    {
        BUS_NHANVIEN_TAIKHOAN bUS_NHANVIEN_TAIKHOAN;
        BUS_NHANVIEN bUS_NHANVIEN;
        public NHANVIEN_TAIKHOAN nv_tkCur;
        public MENU_ChucNangMain()
        {
            InitializeComponent();
            bUS_NHANVIEN = new BUS_NHANVIEN();
            bUS_NHANVIEN_TAIKHOAN = new BUS_NHANVIEN_TAIKHOAN();
            nv_tkCur = Form1.getTK_NVCur();
            //LOAD NHAN VIEN CUR LEN GIAO DIEN
            NHANVIEN nvCur = bUS_NHANVIEN.getNVFromTK(nv_tkCur);
            if(nv_tkCur.Vitri == 1)
                lblChucvuNVTruc.Text = "Nhân viên";
            else
                if (nv_tkCur.Vitri == 2)
                    lblChucvuNVTruc.Text = "Quản trị viên";
            lblTenNVTruc.Text = nvCur.TenNV.ToString();

        }

        private void MENU_ChucNangMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hTTX_DataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.hTTX_DataSet.HOADON);

        }

        private void btnDatXe_Click(object sender, EventArgs e)
        {

            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                MENU_ChucNang_DatXe FMenu_Datxe = new MENU_ChucNang_DatXe();
                FMenu_Datxe.ShowDialog();
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnQuantri_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 2)
            {
                MENU_ChucNang_Quantrivien FMenu_Quantri = new MENU_ChucNang_Quantrivien();
                FMenu_Quantri.ShowDialog();
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Print pr = new Print();
        }
    }
}
