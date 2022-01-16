using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_XE
    {
        HTTXDataContext conn;
        public DAO_XE()
        {
            conn = new HTTXDataContext();
        }
        public List<XE> getXe()
        {
            var get = from s in conn.XEs select s;
            return get.ToList();
            //return conn.XEs.Select(s => s).ToList();
        }
        public List<XE> getXe(int maXe)
        {
            var get = from s in conn.XEs where s.Maxe == maXe select s;
            return get.ToList();
        }
        public List<XE> getXe(string tenXe)
        {
            var get = from s in conn.XEs where (s.Tenxe.ToLower()).Contains(tenXe.ToLower()) select s;
            return get.ToList();
        }
        public int getMaXeHT()
        {
            return conn.XEs.Select(s => s.Maxe).Max();
        }
        public bool checkXeTonTai(int maXe)
        {
            bool exist = false;
            conn.SP_CheckXeTonTai(maXe, exist);
            return exist;
        }
        public void themXe(int maXe, string tenXe, string bienSo, bool trangThai, int maLoai)
        {
            conn.SP_ThemXe(maXe, tenXe, bienSo, trangThai, maLoai);
        }
        public void suaXe(int maXe, string tenXe, string bienSo, bool trangThai, int maLoai)
        {
            //conn.SP_SuaXe(maXe, tenXe, bienSo, trangThai, maLoai);
            var sua = (from s in conn.XEs where s.Maxe == maXe select s).First();
            sua.Tenxe = tenXe;
            sua.Bienso = bienSo;
            sua.Trangthai = trangThai;
            sua.MaL = maLoai;
            conn.SubmitChanges();
        }
        public void xoaXe(int maXe)
        {
            conn.SP_XoaXe(maXe);
        }
    }
}
