CREATE DATABASE DICHVUTHUEXE
GO

USE DICHVUTHUEXE
GO

create table LOAIDV
(
	MaL int primary key CLUSTERED NOT NULL
	, Tenloai nvarchar(25) NOT NULL
	, Gia money NOT NULL
)

create table XE
(
	Maxe int primary key CLUSTERED NOT NULL
	, Tenxe nvarchar(50) NOT NULL
	, Bienso varchar(25) NOT NULL
	, Trangthai bit NOT NULL	  ---- BIT 1 :đại diện cho xe đang bận ; 0 : đại diện cho xe đang rảnh
	, MaL int NOT NULL
	, constraint C_MaLoai  Foreign Key (MaL) REFERENCES LOAIDV(MaL)
)

create table KHACHHANG
(
	MaKH int primary key CLUSTERED NOT NULL
	, Ten nvarchar(50) NOT NULL
	, CMND varchar(12) NOT NULL
	, Gioitinh nvarchar(5) NOT NULL
	, Ngaysinh datetime check (Ngaysinh < getdate()) NOT NULL
	, Diachi nvarchar(50) NOT NULL
	, SDT varchar(10) 
	, Constraint CHECK_GIOITINHKH check (Gioitinh = N'Nữ' or Gioitinh = N'Nam')
	, Constraint CHECK_NGAYSINHKH check (Ngaysinh < getdate()) 
)

create table NHANVIEN
(
	MaNV int primary key CLUSTERED NOT NULL
	, TenNV nvarchar(50) NOT NULL
	, CMND nvarchar(12) NOT NULL
	, Gioitinh nvarchar(10) NOT NULL
	, Ngaysinh datetime 
	, Diachi nvarchar(50) NOT NULL
	, SDT varchar(10) 
	, Constraint CHECK_GIOITINHNV check (Gioitinh = N'Nữ' or Gioitinh = N'Nam')
	, Constraint CHECK_NGAYSINHNV check (Ngaysinh < getdate()) 
)

create table QUYENHAN
(
	MaQ int primary key NOT NULL
	, TenQ nvarchar(25) NOT NULL
	, Mota nvarchar(50) NOT NULL 
)

create table NHANVIEN_TAIKHOAN
(
	MaNV int foreign key references NHANVIEN 
	, Taikhoan nvarchar(25) NOT NULL
	, Matkhau nvarchar(25) NOT NULL
	, Vitri int NOT NULL ----------- nv: nhân viên ; qt: quản trị
	, CONSTRAINT C_ViTri FOREIGN KEY (Vitri) REFERENCES QuyenHan(MaQ)
)

create table KHACHHANG_TAIKHOAN
(
	MaKH int foreign key references KHACHHANG 
	, Taikhoan nvarchar(25) NOT NULL
	, Matkhau nvarchar(25) NOT NULL
	, Vitri int NOT NULL ----------- nv: nhân viên ; qt: quản trị
	, CONSTRAINT C_ViTriKH FOREIGN KEY (Vitri) REFERENCES QuyenHan(MaQ)
)

create table HOPDONG
(
	MaHDG int primary key CLUSTERED NOT NULL
	, Maxe int NOT NULL
	, MaKH int NOT NULL
	, MaL int NOT NULL
	, MaNV int  NOT NULL
	, NgayBD date NOT NULL
    , NgayKT date NOT NULL
	, Trangthai bit NOT NULL  ---- BIT 1 :đại diện cho hợp đồng đang có hiệu lực, 0 :đại diện cho hợp đồng chưa được thực thi
	, CONSTRAINT C_Maxe_HDG FOREIGN KEY (Maxe) REFERENCES XE(Maxe)
	, CONSTRAINT C_MaNV_HDG FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
	, CONSTRAINT C_MaKH_HDG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
	, CONSTRAINT C_MaL_HDG FOREIGN KEY (MaL) REFERENCES LOAIDV(MaL)
)

create table HOADON
(
	MaHD int primary key CLUSTERED NOT NULL
	,MaHDG int foreign key references HOPDONG
	, SogioSD decimal 
	, Thanhtien money
	, Ngayin datetime
	, Trangthai bit    ---- BIT 1 : đại diện cho hoá đơn đã đc thanh toán; 0 :đại diện cho hoá đơn chưa được thanh toán
)


select o.MaHDG , o.MaKH, k.Ten ,h.Maxe ,h.Tenxe, hd.SogioSD, hd.Thanhtien  from HOADON hd,HOPDONG o, XE h, KHACHHANG k where o.Maxe = h.Maxe and o.MaKH = k.MaKH and hd.MaKH = k.MaKH




-- DATA OF KHACHHANG
INSERT INTO KHACHHANG (MaKH, Ten, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (1, N'Trần Công Thức', '072201002451', N'Nam', '2001-07-22',N'Hoà Thành, Tây Ninh', '0792767795');
INSERT INTO KHACHHANG (MaKH, Ten, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (2, N'Võ Văn Hưng', '072201002971', N'Nam', '2001-06-02',N'Hoà Thành, An Giang', '0796545965');
INSERT INTO KHACHHANG (MaKH, Ten, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (3, N'Nguyễn Văn Minh', '072201002691', N'Nam', '2001-06-28','Hoà Thành, Quảng Bình', '0756945896');
INSERT INTO KHACHHANG (MaKH, Ten, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (4, N'Nguyễn Thị Hồng', '092201006451', N'Nữ', '1998-03-21',N'Hoà Thành, Bắc Giang', '0785214553');
INSERT INTO KHACHHANG (MaKH, Ten, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (5, N'Đinh Thị Thuý Hạnh', '082602005491', N'Nữ', '2000-04-25',N'Gò Vấp, TP.HCM', '0256982365');
INSERT INTO KHACHHANG (MaKH, Ten, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (6, N'Nguyễn Hữu Phúc', '032205007489', N'Nam', '2001-05-26',N'Hoà Thành, Bắc Giang', '0785216553');

-- DATA OF LOAIDV , PRICE FOR 2 DAYS
INSERT INTO LOAIDV (MaL, Tenloai, Gia) VALUES (1,N'XE MOTO','1000000');
INSERT INTO LOAIDV (MaL, Tenloai, Gia) VALUES (2,N'XE CON 4 CHỖ','2000000');
INSERT INTO LOAIDV (MaL, Tenloai, Gia) VALUES (3,N'XE CON 7 CHỖ','2500000');
INSERT INTO LOAIDV (MaL, Tenloai, Gia) VALUES (4,N'XE KHÁCH 16 CHỖ','5000000');

-- DATA OF HOADON
INSERT INTO HOADON(MaHD, MaHDG, SogioSD, Thanhtien, Ngayin, Trangthai) VALUES (1,2,'48','1000000',null,1);
INSERT INTO HOADON(MaHD, MaHDG, SogioSD, Thanhtien, Ngayin, Trangthai) VALUES (2,1,'48','2500000',null,1);
INSERT INTO HOADON(MaHD, MaHDG, SogioSD, Thanhtien, Ngayin, Trangthai) VALUES (3,4,'96','4000000',null,1);
INSERT INTO HOADON(MaHD, MaHDG, SogioSD, Thanhtien, Ngayin, Trangthai) VALUES (4,3,'24','2500000',null,1);
INSERT INTO HOADON(MaHD, MaHDG, SogioSD, Thanhtien, Ngayin, Trangthai) VALUES (5,5,'48','2000000',null,1);
INSERT INTO HOADON(MaHD, MaHDG, SogioSD, Thanhtien, Ngayin, Trangthai) VALUES (6,6,'120','3000000',null,1);

-- DATA OF XE
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (1,N'EXCITER 2019 150','70F1-66666',1,1);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (2,N'WINNER 2020 150','59C1-25612',0,1);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (3,N'MOTO PHÂN KHỐI 175','56C3-95421',1,1);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (4,N'Kia Morning','59C2-2651',0,2);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (5,N'Hyundai Grand i10','63C7-73559',1,2);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (6,N'VinFast Fadil','69F3-29995',0,2);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (7,N'Mitsubishi Xpander','36F2-26353',1,3);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (8,N'Toyota Rush','72C2-59784',1,3);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (9,N'Mazda CX-8','30H6-16542',0,3);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (10,N'Ford Transit','70C9-15623',0,4);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (11,N'Toyota Hiace','68A2-56985',1,4);
INSERT INTO XE(Maxe, Tenxe, Bienso, Trangthai, MaL) VALUES (12,N'Mercedes Sprinter','26A7-11452',0,4);

-- DATA OF NHANVIEN
INSERT INTO NHANVIEN(MaNV, TenNV, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (1,N'Nguyễn Thị Hưng','072203621256',N'Nam','1987-02-26',N'Bình Thạnh, TP.HCM','0795635589')
INSERT INTO NHANVIEN(MaNV, TenNV, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (2,N'Lê Thị Kiều','075521552369',N'Nữ','1990-06-12',N'Thủ Đức, TP.HCM','0795833214')
INSERT INTO NHANVIEN(MaNV, TenNV, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (3,N'Trần Chuẩn','035521012365',N'Nam','1995-03-16',N'Gò Dầu, Tây Ninh','0785244565')
INSERT INTO NHANVIEN(MaNV, TenNV, CMND, Gioitinh, Ngaysinh, Diachi, SDT) VALUES (4,N'Nguyễn Thị Kim Cúc','022356220125',N'Nữ','2000-01-17',N'Gò Vấp, TP.HCM','0365623336')


-- DATA OF HOPDONG 
INSERT INTO HOPDONG(MaHDG, Maxe, MaKH, MaL, MaNV, NgayBD, NgayKT,Trangthai) VALUES (1,1,2,1,1,'2021-10-01','2021-10-03',1);
INSERT INTO HOPDONG(MaHDG, Maxe, MaKH, MaL, MaNV, NgayBD, NgayKT, Trangthai) VALUES (2,8,1,3,1,'2021-10-02','2021-10-04',1);
INSERT INTO HOPDONG(MaHDG, Maxe, MaKH, MaL, MaNV, NgayBD, NgayKT, Trangthai) VALUES (3,5,4,2,2,'2021-10-03','2021-10-07',1);
INSERT INTO HOPDONG(MaHDG, Maxe, MaKH, MaL, MaNV, NgayBD, NgayKT, Trangthai) VALUES (4,11,3,4,4,'2021-10-04','2021-10-05',1);
INSERT INTO HOPDONG(MaHDG, Maxe, MaKH, MaL, MaNV, NgayBD, NgayKT, Trangthai) VALUES (5,7,5,2,3,'2021-10-06','2021-10-08',1);
INSERT INTO HOPDONG(MaHDG, Maxe, MaKH, MaL, MaNV, NgayBD, NgayKT, Trangthai) VALUES (6,3,6,1,2,'2021-10-08','2021-10-14',1);

-- DATA OF QUYENHAN
INSERT INTO QuyenHan(MaQ, TenQ, Mota) VALUES (1,N'Nhân viên',N'Thực hiện thao tác với quyền hạn bình thường');
INSERT INTO QuyenHan(MaQ, TenQ, Mota) VALUES (2,N'Quản trị',N'Thực hiện thao tác với quyền hạn cao nhất');
INSERT INTO QuyenHan(MaQ, TenQ, Mota) VALUES (3,N'Khách hàng',N'Thực hiện thao tác đặt xe');


-- DATA OF NHANVIEN_TAIKHOAN
INSERT INTO NHANVIEN_TAIKHOAN(MaNV, Taikhoan, Matkhau, Vitri) VALUES (1,'hungnv','hung1',1);
INSERT INTO NHANVIEN_TAIKHOAN(MaNV, Taikhoan, Matkhau, Vitri) VALUES (2,'kieunv','kieu1',1);
INSERT INTO NHANVIEN_TAIKHOAN(MaNV, Taikhoan, Matkhau, Vitri) VALUES (3,'chuannv','chuan1',1);
INSERT INTO NHANVIEN_TAIKHOAN(MaNV, Taikhoan, Matkhau, Vitri) VALUES (4,'cucnv','cuc1',2);

-- DATA OF KHACHHANG_TAIKHOAN
INSERT INTO KHACHHANG_TAIKHOAN(MaKH, Taikhoan, Matkhau, Vitri) VALUES (1,'thuckh','thuc1',3);
INSERT INTO KHACHHANG_TAIKHOAN(MaKH, Taikhoan, Matkhau, Vitri) VALUES (2,'hungkh','hung1',3);
INSERT INTO KHACHHANG_TAIKHOAN(MaKH, Taikhoan, Matkhau, Vitri) VALUES (3,'minhkh','minh1',3);
INSERT INTO KHACHHANG_TAIKHOAN(MaKH, Taikhoan, Matkhau, Vitri) VALUES (4,'hongkh','hong1',3);


------------- TEST DU LIEU - KO RUN LUC KHOI TAO DATABASE
Select nv.MaNV , nt.Taikhoan, q.TenQ, q.Mota From QuyenHan q, NHANVIEN_TAIKHOAN nt , NHANVIEN nv where nv.MaNV = nt.MaNV and nt.Vitri = q.MaQ
Select * From QUYENHAN
select *from XE 
select *from HOPDONG 
select *from LOAIDV
select *from KHACHHANG
select *from HOADON
select *from NHANVIEN_TAIKHOAN
select o.MaHDG , o.MaKH, k.Ten ,h.Maxe ,h.Tenxe, hd.SogioSD, hd.Thanhtien  from HOADON hd,HOPDONG o, XE h, KHACHHANG k where o.Maxe = h.Maxe and o.MaKH = k.MaKH and hd.MaKH = k.MaKH
Select nv.MaNV , nt.Taikhoan, q.TenQ, q.Mota From QuyenHan q, NHANVIEN_TAIKHOAN nt , NHANVIEN nv where nv.MaNV = nt.MaNV and nt.Vitri = q.MaQ
Select nt.MaL , n.Tenxe From XE n , LOAIDV nt where n.MaL = nt.MaL
UPDATE KHACHHANG SET Ten = N'abcxyz' Where MaKH = 2