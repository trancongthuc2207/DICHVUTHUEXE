using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_KHACHHANG
    {
        DAO_KHACHHANG dAO_KHACHHANG;

        public BUS_KHACHHANG()
        {
            dAO_KHACHHANG = new DAO_KHACHHANG();
        }

        public int? getMaKHCurrent()
        {
            int? maCur = dAO_KHACHHANG.getMaKHCurrent();
            return maCur;
        }

        public int? addKhachHang(int? maKH, string ten, string cmnd, string gioitinh, DateTime ngaysinh, string diachi, string sdt)
        {
            int? checkadd = dAO_KHACHHANG.addKhachHang(maKH, ten, cmnd, gioitinh, ngaysinh, diachi, sdt);
            return checkadd;
        }
        public KHACHHANG getKH1(int maKH)
        {
            KHACHHANG kh = dAO_KHACHHANG.getKH1(maKH);
            return kh;
        }
        public void ListCustomers(DataGridView dg)
        {
            dg.DataSource = dAO_KHACHHANG.ListCustomers();
        }
        public void SearchCustomer(DataGridView dg, String CustomerName)
        {
            dg.DataSource = dAO_KHACHHANG.SearchCustomer(CustomerName);
        }
    }
}
