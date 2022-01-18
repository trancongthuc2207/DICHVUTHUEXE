//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using DichVuThueXe.BUS;
//using DichVuThueXe.GUI;
//using Spire.Doc;
//using Spire.Doc.Documents;
//using HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment;

//namespace DichVuThueXe.PRINT
//{
//    class Print
//    {
//        BUS_NHANVIEN bUS_NHANVIEN = new BUS_NHANVIEN();
//        BUS_KHACHHANG bUS_KHACHHANG = new BUS_KHACHHANG();
//        BUS_XE bUS_XE = new BUS_XE();
//        BUS_LOAIDV bUS_LOAIDV = new BUS_LOAIDV();
//        BUS_HOADON bUS_HOADON = new BUS_HOADON();
//        public Print(HOPDONG hdg)
//        {
//            // Tạo đối tượng tài liệu (Document)
//            Document doc = new Document();

//            // Tạo đối tượng đoạn (Paragraph)
//            Paragraph paragraph = doc.AddSection().AddParagraph();

//            string maKH = hdg.MaKH.ToString();
//            string maHDon = bUS_HOADON.getHoaDonFromMaHD(hdg.MaHDG).MaHD.ToString();
//            string TenDV = bUS_LOAIDV.getLOAIDV(hdg.MaL).Tenloai;
//            string maxe = hdg.Maxe.ToString();
//            string Tenxe = bUS_XE.getXe1(hdg.Maxe).Tenxe;
//            string Sogio = bUS_HOADON.getHoaDonFromMaHD(hdg.MaHDG).SogioSD.ToString();
//            string gia = bUS_HOADON.getHoaDonFromMaHD(hdg.MaHDG).Thanhtien.ToString();
//            string ghichu = " ";
//            string tenKH = bUS_KHACHHANG.getKH1(hdg.MaKH).Ten;
//            string soHopDong = hdg.MaHDG.ToString();
//            string gt = bUS_KHACHHANG.getKH1(hdg.MaKH).Gioitinh;
//            string cmnd = bUS_KHACHHANG.getKH1(hdg.MaKH).CMND;
//            string sdt = bUS_KHACHHANG.getKH1(hdg.MaKH).SDT;
//            string nhanvien_hopdong = bUS_NHANVIEN.getNV1(hdg.MaNV).TenNV;
//            string nhanvein_tructiepthu = bUS_NHANVIEN.getNVFromTK(MENU_ChucNangMain.nv_tkCur).TenNV;
//            DateTime ngayin = DateTime.Now;

//            Spire.Doc.Fields.TextRange title = paragraph.AppendText("\n\n~~~~~~~~DỊCH VỤ THUÊ XE~~~~~~~~~\n");
//            Spire.Doc.Fields.TextRange text = paragraph.AppendText("~~~~~~~~~~~~~PHIẾU THU~~~~~~~~~~~~~\n\n");

//            Paragraph paragraph_body = doc.Sections[0].AddParagraph();
//            Spire.Doc.Fields.TextRange body = paragraph_body.AppendText(" ---- MÃ HOÁ ĐƠN : " + maHDon + "\n" +
//                                                                   " - Tên khách hàng: " + tenKH + "                            Số hợp đồng: " + soHopDong + "\n" +
//                                                                   " - Giới tính: " + gt + "                                     Số CMND: " + cmnd + "\n" +
//                                                                   " - SDT: " + sdt + "\n" +
//                                                                   " - Nhân viên trách nhiệm hợp đồng: " + nhanvien_hopdong + "\n" +
//                                                                   " - Nhân viên trực tiếp thu: " + nhanvein_tructiepthu + "\n" +
//                                                                   " - Ngày in: " + ngayin.ToString() + "\n\n");

//            //text.CharacterFormat.Italic = true;  // in nghiêng
//            //text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single; // gạch chân
//            text.CharacterFormat.Bold = true;                                   // kiểu in đậm
//            title.CharacterFormat.Bold = true;

//            paragraph.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
//            paragraph.Format.HorizontalAlignment = HorizontalAlignment.Center;  // đoạn canh giữa
//                                                                                //paragraph.Format.HorizontalAlignment = HorizontalAlignment.Left;  // đoạn canh trái  
//                                                                                //paragraph.Format.HorizontalAlignment = HorizontalAlignment.Right; // đoạn canh phải
//            paragraph_body.Format.HorizontalAlignment = HorizontalAlignment.Left;
//            ////////////////////////////////////////////////////////////////////////////////////////////
//            // Tạo đối tượng bảng Table
//            Spire.Doc.Table table = doc.Sections[0].AddTable(true);

//            // Tạo cột
//            String[] Header = { "STT", "Tên Dịch Vụ", "Mã xe", "Tên xe", "Số giờ thuê", "Giá", "Ghi chú" };

//            // Số dòng và số cột cho bảng
//            table.ResetCells(2, Header.Length);

//            // Độ rộng bảng ở dòng 0 và 2 cột STT và Tên (tạo tiêu đề bảng)
//            doc.Sections[0].Tables[0].Rows[0].Cells[0].Width = 200;
//            doc.Sections[0].Tables[0].Rows[0].Cells[1].Width = 200;
//            doc.Sections[0].Tables[0].Rows[0].Cells[2].Width = 200;
//            doc.Sections[0].Tables[0].Rows[0].Cells[3].Width = 200;
//            doc.Sections[0].Tables[0].Rows[0].Cells[4].Width = 200;
//            doc.Sections[0].Tables[0].Rows[0].Cells[5].Width = 200;
//            doc.Sections[0].Tables[0].Rows[0].Cells[6].Width = 200;

//            // Tạo dòng tiêu đề cho bảng (dòng 0)
//            Spire.Doc.TableRow FRow = table.Rows[0];
//            FRow.IsHeader = true;
//            FRow.Height = 23;

//            for (int i = 0; i < Header.Length; i++)
//            {
//                // Định dạng cell
//                Paragraph p = FRow.Cells[i].AddParagraph();
//                FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
//                p.Format.HorizontalAlignment = HorizontalAlignment.Center;

//                // Định dạng văn bản trong bảng
//                Spire.Doc.Fields.TextRange TR = p.AppendText(Header[i]);
//                TR.CharacterFormat.FontName = "Times New Roman";
//                TR.CharacterFormat.FontSize = 13;
//                TR.CharacterFormat.Bold = true;
//            }

//            // Định dạng dữ liệu từng dòng (lấy từ list)
//            for (int r = 0; r < 1; r++)
//            {
//                doc.Sections[0].Tables[0].Rows[r + 1].Cells[0].Width = 200;
//                doc.Sections[0].Tables[0].Rows[r + 1].Cells[1].Width = 200;
//                doc.Sections[0].Tables[0].Rows[r + 1].Cells[2].Width = 200;
//                doc.Sections[0].Tables[0].Rows[r + 1].Cells[3].Width = 200;
//                doc.Sections[0].Tables[0].Rows[r + 1].Cells[4].Width = 200;
//                doc.Sections[0].Tables[0].Rows[r + 1].Cells[5].Width = 200;
//                doc.Sections[0].Tables[0].Rows[r + 1].Cells[6].Width = 200;

//                // Định dạng dòng thứ r + 1 (bỏ dòng đầu là tiêu đề)
//                Spire.Doc.TableRow DataRow = table.Rows[r + 1];
//                DataRow.Height = 20;

//                DataRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
//                Paragraph p1 = DataRow.Cells[0].AddParagraph();
//                Spire.Doc.Fields.TextRange TR1 = p1.AppendText((r + 1).ToString()); // STT
//                p1.Format.HorizontalAlignment = HorizontalAlignment.Center;

//                DataRow.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
//                Paragraph p2 = DataRow.Cells[1].AddParagraph();
//                Spire.Doc.Fields.TextRange TR2 = p2.AppendText(TenDV); // Tên dịch vụ
//                p2.Format.HorizontalAlignment = HorizontalAlignment.Center;

//                DataRow.Cells[2].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
//                Paragraph p3 = DataRow.Cells[2].AddParagraph();
//                Spire.Doc.Fields.TextRange TR3 = p3.AppendText(maxe); // Mã xe
//                p3.Format.HorizontalAlignment = HorizontalAlignment.Center;

//                DataRow.Cells[3].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
//                Paragraph p4 = DataRow.Cells[3].AddParagraph();
//                Spire.Doc.Fields.TextRange TR4 = p4.AppendText(Tenxe); // Tên xe
//                p4.Format.HorizontalAlignment = HorizontalAlignment.Center;

//                DataRow.Cells[4].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
//                Paragraph p5 = DataRow.Cells[4].AddParagraph();
//                Spire.Doc.Fields.TextRange TR5 = p5.AppendText(Sogio); // Giờ thuê xe
//                p5.Format.HorizontalAlignment = HorizontalAlignment.Center;

//                DataRow.Cells[5].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
//                Paragraph p6 = DataRow.Cells[5].AddParagraph();
//                Spire.Doc.Fields.TextRange TR6 = p6.AppendText(gia); // Giá thuê
//                p6.Format.HorizontalAlignment = HorizontalAlignment.Center;

//                DataRow.Cells[6].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
//                Paragraph p7 = DataRow.Cells[6].AddParagraph();
//                Spire.Doc.Fields.TextRange TR7 = p7.AppendText(ghichu); // Giá thuê
//                p7.Format.HorizontalAlignment = HorizontalAlignment.Center;
//            }


//            Paragraph paragraph_LastZone = doc.Sections[0].AddParagraph();
//            Spire.Doc.Fields.TextRange last = paragraph_LastZone.AppendText("\n\n\n - Tổng thu:  " + gia + "\n" +
//                                                                            "\n\n\n                     Người nhận                                                                                     Người nộp\n");
//            string fmNgayin = String.Format("{0:yyyy_MM_dd_hh_mm_ss}", ngayin);
//            string pathDoc = "C:/Users/Admin/Documents/trancongthuc/DICHVUTHUEXE/DichVuThueXe/PhieuThu/KH_" + maKH + "_" + fmNgayin + ".doc";
//            string pathPdf = "C:/Users/Admin/Documents/trancongthuc/DICHVUTHUEXE/DichVuThueXe/PhieuThu/KH_" + maKH + "_" + fmNgayin + ".pdf";
//            doc.SaveToFile(pathDoc, Spire.Doc.FileFormat.Doc);
//            doc.SaveToFile(pathPdf, Spire.Doc.FileFormat.PDF); //-- tạo PDF
//            MessageBox.Show("In hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            // đóng đối tượng
//            doc.Close();

//        }

//    }
//}
