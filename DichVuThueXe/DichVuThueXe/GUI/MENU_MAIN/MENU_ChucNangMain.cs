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
using DichVuThueXe.GUI.MENU_MAIN.NHANVIEN;
//using DichVuThueXe.PRINT;

namespace DichVuThueXe.GUI
{
    public partial class MENU_ChucNangMain : Form
    {
        BUS_NHANVIEN_TAIKHOAN bUS_NHANVIEN_TAIKHOAN;
        BUS_NHANVIEN bUS_NHANVIEN;
        BUS_HOPDONG bUS_HOPDONG;
        public static NHANVIEN_TAIKHOAN nv_tkCur;
        private static HOPDONG hdgCur; 
        public MENU_ChucNangMain()
        {
            InitializeComponent();
            bUS_NHANVIEN = new BUS_NHANVIEN();
            bUS_NHANVIEN_TAIKHOAN = new BUS_NHANVIEN_TAIKHOAN();
            bUS_HOPDONG = new BUS_HOPDONG();
            nv_tkCur = Form1.getTK_NVCur();
            //LOAD NHAN VIEN CUR LEN GIAO DIEN
            NHANVIEN nvCur = bUS_NHANVIEN.getNVFromTK(nv_tkCur);
            if(nv_tkCur.Vitri == 1)
                lblChucvuNVTruc.Text = "Nhân viên";
            else
                if (nv_tkCur.Vitri == 2)
                    lblChucvuNVTruc.Text = "Quản trị viên";
                else
                    if (nv_tkCur.Vitri == 0)
                        lblChucvuNVTruc.Text = "Nhân viên - BANNED";
            lblTenNVTruc.Text = nvCur.TenNV.ToString();

        }

        private void MENU_ChucNangMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hTTX_DataSet.HOPDONG' table. You can move, or remove it, as needed.
            gridV_HOPDONG.DataSource = bUS_HOPDONG.getHopDong();
            // TODO: This line of code loads data into the 'hTTX_DataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.hTTX_DataSet.HOADON);


            this.reportViewer1.RefreshReport();
        }

        //ĐẶT XE
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

        //QUẢN TRỊ
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
        //THEO DÕI HOÁ ĐƠN
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                try
                {
                    int index = gridV_HOADON.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                    txtVD.Text = gridV_HOADON.Rows[index].Cells[1].Value.ToString().Trim(); //xxx tương ứng với column trong datagridview của bạn, và column đầu tiên có thứ tự là 0.
                    HOPDONG hdg = bUS_HOPDONG.getHopDongFromMaHDG(int.Parse(txtVD.Text));
                    //Print pr = new Print(hdg);
                }
                catch
                { }
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //BÁO CÁO DOANH THU
        private void btn_xemBC_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                DateTime ngayBD = dtP_NgayBD.Value;
                DateTime ngayKT = dtP_NgayKT.Value;

                this.reportHDByNgayBDandNgayKTTableAdapter.Fill(this.dICHVUTHUEXEDataSet.reportHDByNgayBDandNgayKT,ngayBD, ngayKT);
                this.reportViewer1.RefreshReport();
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //SWITCH TAB
        private void btnQuanLyKH_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectTab(2);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectTab(3);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectTab(0);
        }

        private void gridV_HOADON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = gridV_HOADON.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                txtVD.Text = gridV_HOADON.Rows[index].Cells[1].Value.ToString().Trim(); //xxx tương ứng với column trong datagridview của bạn, và column đầu tiên có thứ tự là 0.
                HOPDONG hdg = bUS_HOPDONG.getHopDongFromMaHDG(int.Parse(txtVD.Text));
                txtVD.Text = hdg.NgayBD.ToString();
            }
            catch
            { }
        }

        //HOP DONG
        private void btnSuaHDG_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                if (hdgCur != null)
                {
                    MENU_SuaHopDong shd = new MENU_SuaHopDong();
                    shd.ShowDialog();
                }
                else
                    MessageBox.Show("Chọn hợp đồng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXuLyHDG_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectTab(1);
        }

        private void gridV_HOPDONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                int index = gridV_HOPDONG.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                string cell = gridV_HOPDONG.Rows[index].Cells[0].Value.ToString().Trim();
                hdgCur = bUS_HOPDONG.getHopDongFromMaHDG(int.Parse(cell));
            } 
            catch
            {
            }
        }

        private void btnRefreshHD_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                this.gridV_HOPDONG.DataSource = bUS_HOPDONG.getHopDong();
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //TRẢ VỀ HỢP ĐỒNG CẦN SỬA
        public static HOPDONG HopDongCurrentToEdit()
        {
            return hdgCur;
        }

        
    }
}
