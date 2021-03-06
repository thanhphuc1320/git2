create database NGK
use NGK


create table LOAINV(
	MaLoaiNV varchar(10) primary key,
	TenLoaiNV nvarchar(30),
	TrangThai int
)

create table NHANVIEN(
	MaNV varchar(10) primary key,
	HoTen nvarchar(30),
	DiaChi nvarchar(40),
	SDT varchar(11),
	HinhAnhNV varchar(20),
	GioiTinh nvarchar(3),
	NgaySinh Date,
	LoaiNV varchar(10) foreign key (LoaiNV) references LOAINV(MaLoaiNV),
	MatKhau varchar(20),
	TrangThai int,
)


create table LOAISP(
	MaLoaiSP varchar(10) primary key,
	TenLoaiSP nvarchar(30),
	TrangThai int
)

create table NHACUNGCAP(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(30),
	DiaChi nvarchar(40),
	SDT	varchar(11),
	TrangThai int
)

create table SANPHAM(
	MaSP varchar(10) primary key,
	TenSP nvarchar(30),
	LoaiSP varchar(10) foreign key (LoaiSP) references LOAISP(MaLoaiSP),
	NCC varchar(10) foreign key (NCC) references NHACUNGCAP(MaNCC),
	GiaBan bigint,
	SoLuongTon int,
	HinhAnhSP varchar(20),
	HanSuDung Date,
	TrangThai int
)


create table HOADONBAN(
	MaHDBan varchar(10) primary key,
	MaNV varchar(10) foreign key (MaNV) references NHANVIEN(MaNV),
	NgayLap Date,
	ThanhTien bigint,
	TrangThai int
)

create table CTHDBAN(
	MaHDBan varchar(10) foreign key (MaHDBan) references HOADONBAN(MaHDBan),
	MaSP varchar(10) foreign key (MaSP) references SANPHAM(MaSP),
	SoLuongSP int
)

create table HOADONNHAP(
	MaHDNhap varchar(10) primary key,
	MaNV varchar(10) foreign key (MaNV) references NHANVIEN(MaNV),
	NgayNhap Date,
	TrangThai int
)

create table CTHDNHAP(
	MaHDNhap varchar(10) foreign key (MaHDNhap) references HOADONNHAP(MaHDNhap),
	MaSP varchar(10) foreign key (MaSP) references SANPHAM(MaSP),
	SoLuongNhap int,
	DonGiaNhap bigint,
	NSX Date,
)

create table HOADONXUAT(
	MaHDX varchar(10) primary key,
	MaNV varchar(10) foreign key (MaNV) references NHANVIEN(MaNV),
	NgayXuat Date,
	TrangThai int
)

create table CTHDXUAT(
	MaHDXuat varchar(10) foreign key (MaHDXuat) references HOADONXUAT(MaHDX),
	MaSP varchar(10) foreign key (MaSP) references SANPHAM(MaSP),
	SoLuongXuat int,
	DonGiaXuat bigint,
	NSX Date,
)

create table HOADONDAT(
	MaHDDat varchar(10) primary key,
	MaNV varchar(10) foreign key (MaNV) references NHANVIEN(MaNV),
	SoLuongDat int,
	NgayDat Date,
	TrangThai int
)

create table CTHDDAT(
	MaHDDat varchar(10) foreign key (MaHDDat) references HOADONDAT(MaHDDat),
	MaSP varchar(10) foreign key (MaSP) references SANPHAM(MaSP),
	SoLuong int
)



create table CHAMCONG(
	MaChamCong varchar(10) primary key,
	MaNV varchar(10) foreign key (MaNV) references NHANVIEN(MaNV),
	HoTenNV nvarchar(30),
	ChucVu varchar(10),
	NgayCC Date,
	SoNgayNghi int,
	TongOT int
)


CREATE TABLE THONGKE(
	MaThongKe varchar(10) primary key,
	TenThongKe nvarchar(30),
	ChiTiet nvarchar(100),
	NgayLapTK Date,
	MaNV varchar(10) foreign key (MaNV) references NHANVIEN(MaNV),
	TongChiPhi bigint,
	TongDoanhThu bigint,
	TongHaoHutDT bigint,
	LoiNhuan bigint,
	TrangThai int
)


--SELECT MAX(MANGK) FROM NGK WHERE LEFT(MANGK, 2) = 'CF' || MANGK LIKE  'CF'



INSERT LOAINV (MaLoaiNV, TenLoaiNV, TrangThai) VALUES ('lnv01', N'Quản lý', 1)
INSERT LOAINV (MaLoaiNV, TenLoaiNV, TrangThai) VALUES ('lnv02', N'Nhân viên', 1)

INSERT NHANVIEN (MaNV, HoTen, DiaChi, SDT, HinhAnhNV, GioiTinh, NgaySinh, LoaiNV, MatKhau, TrangThai) VALUES ('nv01', N'Anh Quản Lý', N'TP Ho Chí Minh' , N'01663982436', N'HinhAnhNV/nv01.png', N'Nam', CAST(N'1998-11-16' AS Date), 'lnv01',N'123', 1)
INSERT NHANVIEN (MaNV, HoTen, DiaChi, SDT, HinhAnhNV, GioiTinh, NgaySinh, LoaiNV, MatKhau, TrangThai) VALUES ('nv02', N'Mạch Hồng Vũ', N'Tiền Giang' , N'01683617373', N'HinhAnhNV/nv02.png', N'Nam', CAST(N'1998-01-30' AS Date), 'lnv02',N'123', 1)
INSERT NHANVIEN (MaNV, HoTen, DiaChi, SDT, HinhAnhNV, GioiTinh, NgaySinh, LoaiNV, MatKhau, TrangThai) VALUES ('nv03', N'Nguyễn Thanh Phúc', N'Bến Tre' , N'01680000000', N'HinhAnhNV/nv03.png', N'Nam', CAST(N'1998-01-12' AS Date), 'lnv02',N'123', 1)
INSERT NHANVIEN (MaNV, HoTen, DiaChi, SDT, HinhAnhNV, GioiTinh, NgaySinh, LoaiNV, MatKhau, TrangThai) VALUES ('nv04', N'Trần Tấn Thông', N'Tiền Giang' , N'01681111111', N'HinhAnhNV/nv04.png', N'Nam', CAST(N'1998-06-07' AS Date), 'lnv02',N'123', 1)


INSERT LOAISP (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('lsp01', N'Sản phẩm loại 1', 1)
INSERT LOAISP (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('lsp02', N'Sản phẩm loại 2', 1)
INSERT LOAISP (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('lsp03', N'Sản phẩm loại 3', 1)
INSERT LOAISP (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('lsp04', N'Sản phẩm loại 4', 1)
INSERT LOAISP (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('lsp05', N'Sản phẩm loại 5', 1)
INSERT LOAISP (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('lsp06', N'Sản phẩm loại 6', 1)


INSERT INTO NHACUNGCAP (MaNCC, TenNCC, DiaChi, SDT, TrangThai) VALUES ('ncc01', N'Nhà cung cấp 1', N'TP HCM', '01687899877', 1)
INSERT INTO NHACUNGCAP (MaNCC, TenNCC, DiaChi, SDT, TrangThai) VALUES ('ncc02', N'Nhà cung cấp 2', N'Hà Nội', '01687777777', 1)
INSERT INTO NHACUNGCAP (MaNCC, TenNCC, DiaChi, SDT, TrangThai) VALUES ('ncc03', N'Nhà cung cấp 3', N'Huế', '01665555554', 1)
INSERT INTO NHACUNGCAP (MaNCC, TenNCC, DiaChi, SDT, TrangThai) VALUES ('ncc04', N'Nhà cung cấp 4', N'New York', '01685455654', 1)


INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp01', N'Sản phẩm 01', 'lsp01' , 'ncc01', '5000', '40', N'HinhAnhSP/sp01.png', CAST(N'2019-01-07' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp02', N'Sản phẩm 02', 'lsp01' , 'ncc01', '3000', '31', N'HinhAnhSP/sp02.png', CAST(N'2019-01-07' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp03', N'Sản phẩm 03', 'lsp01' , 'ncc01', '4000', '24', N'HinhAnhSP/sp03.png', CAST(N'2019-01-06' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp04', N'Sản phẩm 04', 'lsp01' , 'ncc01', '3500', '53', N'HinhAnhSP/sp04.png', CAST(N'2019-01-05' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp05', N'Sản phẩm 05', 'lsp02' , 'ncc01', '2600', '23', N'HinhAnhSP/sp05.png', CAST(N'2019-01-03' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp06', N'Sản phẩm 06', 'lsp02' , 'ncc02', '4500', '40', N'HinhAnhSP/sp06.png', CAST(N'2019-01-05' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp07', N'Sản phẩm 07', 'lsp03' , 'ncc02', '5200', '52', N'HinhAnhSP/sp07.png', CAST(N'2019-01-02' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp08', N'Sản phẩm 08', 'lsp01' , 'ncc02', '4200', '40', N'HinhAnhSP/sp08.png', CAST(N'2019-01-05' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp09', N'Sản phẩm 09', 'lsp01' , 'ncc03', '3100', '40', N'HinhAnhSP/sp09.png', CAST(N'2019-01-07' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp10', N'Sản phẩm 10', 'lsp01' , 'ncc03', '4400', '40', N'HinhAnhSP/sp10.png', CAST(N'2019-01-06' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp11', N'Sản phẩm 11', 'lsp04' , 'ncc01', '5000', '52', N'HinhAnhSP/sp11.png', CAST(N'2019-01-08' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp12', N'Sản phẩm 12', 'lsp01' , 'ncc01', '5000', '38', N'HinhAnhSP/sp12.png', CAST(N'2019-01-12' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp13', N'Sản phẩm 13', 'lsp05' , 'ncc01', '5000', '43', N'HinhAnhSP/sp13.png', CAST(N'2019-01-11' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp14', N'Sản phẩm 14', 'lsp05' , 'ncc04', '2600', '42', N'HinhAnhSP/sp14.png', CAST(N'2019-01-10' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp15', N'Sản phẩm 15', 'lsp05' , 'ncc04', '2800', '40', N'HinhAnhSP/sp15.png', CAST(N'2019-01-09' AS Date), 1)
INSERT SANPHAM (MaSP, TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai) VALUES ('sp16', N'Sản phẩm 16', 'lsp06' , 'ncc04', '5200', '37', N'HinhAnhSP/sp16.png', CAST(N'2019-01-07' AS Date), 1)


INSERT INTO HOADONBAN (MaHDBan, MaNV, NgayLap, ThanhTien, TrangThai) VALUES ('hdb01', 'nv02', CAST(N'2018-12-11' AS Date), null, 1)
INSERT INTO HOADONBAN (MaHDBan, MaNV, NgayLap, ThanhTien, TrangThai) VALUES ('hdb02', 'nv03', CAST(N'2018-11-11' AS Date), null, 1)
INSERT INTO HOADONBAN (MaHDBan, MaNV, NgayLap, ThanhTien, TrangThai) VALUES ('hdb03', 'nv03', CAST(N'2018-10-11' AS Date), null, 1)
INSERT INTO HOADONBAN (MaHDBan, MaNV, NgayLap, ThanhTien, TrangThai) VALUES ('hdb04', 'nv04', CAST(N'2018-09-11' AS Date), null, 1)
INSERT INTO HOADONBAN (MaHDBan, MaNV, NgayLap, ThanhTien, TrangThai) VALUES ('hdb05', 'nv03', '2018-10-11', null, 1)


INSERT INTO CTHDBAN (MaHDBan, MaSP, SoLuongSP) VALUES ('hdb01', 'sp02', '2')
INSERT INTO CTHDBAN (MaHDBan, MaSP, SoLuongSP) VALUES ('hdb02', 'sp05', '3')
INSERT INTO CTHDBAN (MaHDBan, MaSP, SoLuongSP) VALUES ('hdb03', 'sp03', '5')
INSERT INTO CTHDBAN (MaHDBan, MaSP, SoLuongSP) VALUES ('hdb04', 'sp07', '4')
INSERT INTO CTHDBAN (MaHDBan, MaSP, SoLuongSP) VALUES ('hdb05', 'sp12', '8')

