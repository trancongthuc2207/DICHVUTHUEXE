using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_XE
    {
        DAO_XE daoXe;
        public BUS_XE()
        {
            daoXe = new DAO_XE();
        }
        public List<XE> getXe()
        {
            List<XE> listXe = daoXe.getXe();
            return listXe;
        }
        public List<XE> getXe(int maXe)
        {
            List<XE> listXe = daoXe.getXe(maXe);
            return listXe;
        }
        public List<XE> getXe(string tenXe)
        {
            List<XE> listXe = daoXe.getXe(tenXe);
            return listXe;
        }
        public XE getXe1(int maXe)
        {
            XE xe = daoXe.getXe1(maXe);
            return xe;
        }
        public int getMaXeHT()
        {
            int maXeHT = daoXe.getMaXeHT();
            return maXeHT;
        }
        public bool checkXeTonTai(int maXe)
        {
            bool exist = daoXe.checkXeTonTai(maXe);
            return exist;
        }
        public void themXe(int maXe, string tenXe, string bienSo, bool trangThai, int maLoai)
        {
            daoXe.themXe(maXe, tenXe, bienSo, trangThai, maLoai);
        }
        public void suaXe(int maXe, string tenXe, string bienSo, bool trangThai, int maLoai)
        {
            daoXe.suaXe(maXe, tenXe, bienSo, trangThai, maLoai);
        }
        public void xoaXe(int maXe)
        {
            daoXe.xoaXe(maXe);
        }
    }
}
