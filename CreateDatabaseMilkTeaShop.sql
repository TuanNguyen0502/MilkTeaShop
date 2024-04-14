CREATE DATABASE MilkTeaShop 
GO
USE MilkTeaShop 

GO
-- Tao bang CongViec
CREATE TABLE CongViec(
	MaCV NCHAR(10) CONSTRAINT PK_CongViec PRIMARY KEY,
	TenCV NVARCHAR(50) NOT NULL,
	Luong  NUMERIC(18,0) NOT NULL CHECK(Luong > 0)
)

GO 
--Tao bang NhanVien
CREATE TABLE NhanVien(
	MaNV VARCHAR(10) CONSTRAINT PK_NhanVien PRIMARY KEY,
	HoTen NVARCHAR(30) NOT NULL,
	GioiTinh NVARCHAR(3),
	NgaySinh DATE CHECK (DATEDIFF(year, NgaySinh, GETDATE())>=18), 
	DiaChi NVARCHAR(255),
	SDT NCHAR(11) NOT NULL CHECK (len(SDT)=10),
	NgayTuyenDung DATE CHECK (DATEDIFF(day, NgayTuyenDung, GETDATE())>=0),
	MaCV NCHAR(10) CONSTRAINT FK_NhanVien_CV FOREIGN KEY REFERENCES CongViec(MaCV)
)

GO
-- Tao bang KhachHang
CREATE TABLE KhachHang (
    TenKH NVARCHAR(255) NOT NULL,
    SDT NCHAR(11) NOT NULL CONSTRAINT PK_KhachHang PRIMARY KEY CHECK (LEN(SDT) = 10),
    GioiTinh NVARCHAR(3),
    NgaySinh DATE NOT NULL CHECK (DATEDIFF(year, NgaySinh, GETDATE()) >= 8)
);

GO
-- Tao bang NhaCungCap
CREATE TABLE NhaCungCap( 
	MaNCC VARCHAR(10) CONSTRAINT PK_MaNCC PRIMARY KEY, 
	TenNCC NVARCHAR(255) NOT NULL, 
	DiaChi NVARCHAR(255) NOT NULL, 
	SDT VARCHAR(11) NOT NULL CHECK(LEN(Sdt) = 10), 
)

GO
-- Tao bang NguyenLieu
CREATE TABLE NguyenLieu( 
	MaNL VARCHAR(10) CONSTRAINT PK_MaNL PRIMARY KEY, 
	TenNL NVARCHAR(255) NOT NULL, 
	SoLuong INT NOT NULL CHECK(SoLuong >= 0), 
	DonVi NVARCHAR(20) NOT NULL, 
	TrangThai VARCHAR(15) NOT NULL DEFAULT 'Available',
)

GO
-- Tao bang DonNhapNguyenLieu
CREATE TABLE DonNhapNL(
	MaDNNL INT IDENTITY (1,1) CONSTRAINT PK_MaDNNL PRIMARY KEY,
	NgayNhap DATE NOT NULL CHECK(DATEDIFF(year, NgayNhap, GETDATE()) >= 0), 
	TriGiaDonNhap NUMERIC(18,0) NOT NULL CHECK(TriGiaDonNhap > 0),
	MaNCC VARCHAR(10) CONSTRAINT FK_DonNhapNL_NCC FOREIGN KEY REFERENCES NhaCungCap(MaNCC)
)

GO
-- Tao bang ChiTietDNNL
CREATE TABLE ChiTiet_DNNL(
	MaDNNL INT CONSTRAINT ChiTiet_DNNL_DN FOREIGN KEY REFERENCES DonNhapNL(MaDNNL),
	MaNL VARCHAR(10) CONSTRAINT ChiTiet_DNNL_NL FOREIGN KEY REFERENCES NguyenLieu(MaNL),
	CONSTRAINT PK_ChiTiet_DNNL PRIMARY KEY (MaDNNL, MaNL), 
	SoLuong INT NOT NULL CHECK(SoLuong > 0), 
	DonVi NVARCHAR(20) NOT NULL, 
	DonGia NUMERIC(18,0) NOT NULL CHECK(DonGia > 0),
)

GO
-- Tao bang DonXuatNguyenLieu
CREATE TABLE DonXuatNL(
	MaDXNL INT IDENTITY (1,1) CONSTRAINT PK_DonXuatNL PRIMARY KEY,
	NgayXuat DATE NOT NULL CHECK(DATEDIFF(year, NgayXuat, GETDATE()) >= 0), 
	MaNV VARCHAR(10) CONSTRAINT FK_DonXuatNL_NV FOREIGN KEY REFERENCES NhanVien(MaNV)
)

GO
-- Tao bang ChiTietDXNL
CREATE TABLE ChiTiet_DXNL(
	MaDXNL INT CONSTRAINT ChiTiet_DXNL_DN FOREIGN KEY REFERENCES DonXuatNL(MaDXNL),
	MaNL VARCHAR(10) CONSTRAINT ChiTiet_DXNL_NL FOREIGN KEY REFERENCES NguyenLieu(MaNL),
	CONSTRAINT PK_ChiTiet_DXNL PRIMARY KEY (MaDXNL, MaNL), 
	SoLuong INT NOT NULL CHECK(SoLuong > 0), 
	DonVi NVARCHAR(20) NOT NULL
)

GO
-- Tao bang LoaiSanPham
CREATE TABLE LoaiSanPham( 
	MaLoaiSP VARCHAR(10) CONSTRAINT PK_LoaiSP PRIMARY KEY, 
	TenLoaiSP NVARCHAR(255) NOT NULL 
)

GO
-- Tao bang SanPham
CREATE TABLE SanPham( 
	MaSP VARCHAR(10) CONSTRAINT PK_SP PRIMARY KEY,
	TenSP NVARCHAR(255) NOT NULL, 
	SoLuong INT, 
	DonGia NUMERIC(18,0) NOT NULL CHECK(DonGia > 0), 
	MaLoaiSP VARCHAR(10) FOREIGN KEY REFERENCES LoaiSanPham(MaLoaiSP),
	TrangThai NVARCHAR(100) DEFAULT 'Available'
)

GO
-- Tao bang DonNhapSanPham
CREATE TABLE DonNhapSP( 
	MaDNSP INT IDENTITY (1,1) CONSTRAINT PK_DonNhapSP PRIMARY KEY,
	NgayNhap DATE NOT NULL CHECK(DATEDIFF(year, NgayNhap, GETDATE()) >= 0), 
	TriGiaDonNhap NUMERIC(18,0) NOT NULL CHECK(TriGiaDonNhap > 0), 
	MaNCC VARCHAR(10) CONSTRAINT FK_DonNhapSP_NCC FOREIGN KEY REFERENCES NhaCungCap(MaNCC)
)

GO
-- Tao bang ChiTietDNSP
CREATE TABLE ChiTiet_DNSP(
	MaDNSP INT CONSTRAINT ChiTiet_DNSP_DN FOREIGN KEY REFERENCES DonNhapSP(MaDNSP),
	MaSP VARCHAR(10) CONSTRAINT ChiTiet_DNSP_SP FOREIGN KEY REFERENCES SanPham(MaSP),
	CONSTRAINT PK_ChiTiet_DNSP PRIMARY KEY (MaDNSP, MaSP), 
	SoLuong INT NOT NULL CHECK(SoLuong > 0), 
	DonVi NVARCHAR(20) NOT NULL, 
	DonGia NUMERIC(18,0) NOT NULL CHECK(DonGia > 0),
)

GO
-- Tao bang HoaDon
CREATE TABLE HoaDon( 
	MaHD INT IDENTITY (1,1) CONSTRAINT PK_HoaDon PRIMARY KEY, 
	SDT NCHAR(11) NULL CONSTRAINT FK_HoaDon_KH FOREIGN KEY REFERENCES KhachHang(SDT), 
	MaNV VARCHAR(10) NOT NULL CONSTRAINT FK_HoaDon_NV FOREIGN KEY REFERENCES NhanVien(MaNV), 
	ThoiGianDat DATETIME check (DATEDIFF(DAY, ThoiGianDat, GETDATE())>=0), 
	TriGiaHoaDon NUMERIC(18,0) NOT NULL CHECK(TriGiaHoaDon > 0), 
	GhiChu NVARCHAR(MAX)
)

GO
-- Tao bang ChiTietHoaDon
CREATE TABLE ChiTietHoaDon( 
	MaHD INT CONSTRAINT FK_ChiTietHoaDon_HD FOREIGN KEY REFERENCES HoaDon(MaHD), 
	MaSP VARCHAR(10) CONSTRAINT FK_ChiTietHoaDon_SP FOREIGN KEY REFERENCES SanPham(MaSP), 
	CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (MaHD, MaSP), 
	SoLuong INT NOT NULL CHECK (SoLuong > 0)
)

GO
-- Tao bang CheBien
CREATE TABLE CheBien ( 
	MaSP VARCHAR(10) CONSTRAINT FK_CheBien_SP FOREIGN KEY REFERENCES SanPham(MaSP), 
	MaNL VARCHAR(10) CONSTRAINT FK_CheBien_NL FOREIGN KEY REFERENCES NguyenLieu(MaNL), 
	CONSTRAINT PK_CheBien PRIMARY KEY (MaSP, MaNL), 
	LieuLuong INT NOT NULL, 
	DonVi NVARCHAR(20) NOT NULL 
)
	
-- Nhập bảng giá trị---------------------------------------------------------------------------------------------------------------------------
GO
	-- CongViec
	INSERT INTO CongViec (MaCV, TenCV, Luong) VALUES 
		('CV001', N'Pha chế', 5500000),
		('CV002', N'Phục vụ', 5000000),
		('CV003', N'Thu ngân',3000000),
		('CV004', N'Vệ sinh', 2200000),
		('CV005', N'Bảo vệ', 4000000),
		('CV006', N'Quản lí', 7000000);

GO
	-- Nhân Viên
	INSERT INTO NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, SDT, NgayTuyenDung, MaCV) VALUES 
	('NV001', N'Nguyễn Vân Anh', N'Nam', '1990-05-15', N'123 Điện Biên Phủ, Quận 1, TP.HCM', '0923456789', '2020-01-10', 'CV001'),
	('NV002', N'Trần Thùy Trang', N'Nữ', '1995-07-20', N'456 Lê Lai, Quận 3, TP.HCM', '0943456790', '2021-03-05', 'CV002'),
	('NV003', N'Lê Hoàng Long', N'Nam', '1993-10-12', N'789 Nguyễn Huệ, Quận 5, TP.HCM', '0873456791', '2019-11-20', 'CV003'),
	('NV004', N'Phạm Thị Bích Ngọc', N'Nữ', '1998-02-28', N'101 Trần Hưng Đạo, Quận 10, TP.HCM', '0313456792', '2022-02-15', 'CV004'),
	('NV005', N'Hoàng Văn Thùy', N'Nam', '1991-09-05', N'202 Bình Thạnh, Quận Bình Thạnh, TP.HCM', '0903456793', '2018-05-20', 'CV005'),
	('NV006', N'Nguyễn Khánh Linh', N'Nữ', '1994-04-10', N'303 Phan Xích Long, Quận Phú Nhuận, TP.HCM', '0223456794', '2023-04-02', 'CV006'),
	('NV007', N'Lê Nguyễn Chính', N'Nam', '1997-11-25', N'505 LÝ Thái Tổ, Quận Tân Bình, TP.HCM', '0123456795', '2022-08-15', 'CV001'),
	('NV008', N'Trần Lê Hoàng Kim', N'Nam', '1990-12-12', N'707 Nguyễn Đình Chiểu, Quận 3, TP.HCM', '0983456796', '2021-01-20', 'CV002'),
	('NV009', N'Phạm Linh Anh', N'Nữ', '1996-08-20', N'909 CMT8, Quận 10, TP.HCM', '0373456797', '2020-06-05', 'CV004'),
	('NV010', N'Lê Hoàng Nhã Uyên', N'Nữ', '1992-05-15', N'111 Nguyễn Thị Minh Khai, Quận 1, TP.HCM', '0853456798', '2019-09-10', 'CV004'),
	('NV011', N'Nguyễn Lê Minh Phương', N'Nam', '1993-03-12', N'212 Nguyễn Đình Chiểu, Quận 3, TP.HCM', '0973456799', '2018-04-15', 'CV002');

GO
	-- KhachHang
	INSERT INTO KhachHang (TenKH, SDT, GioiTinh, NgaySinh) VALUES 
    (N'Nguyễn Ngọc Linh', '0123156789', N'Nữ', '2010-05-15'),
    (N'Tran Phúc Bảo', '0123456791', 'Nam', '2005-07-20'),
    (N'Lê Thùy Chi', '0123458791', N'Nữ', '2013-10-12'),
    (N'Phạm Huỳnh Anh', '0123186792', 'Nam', '2008-02-28'),
    (N'Hoàng Kim Anh', '0123459793', N'Nữ', '2011-09-05'),
    (N'Trịnh Thị Mỹ Linh', '0934167890', N'Nữ', '2009-03-12'),
    (N'Trần Quốc Minh', '0934463791', 'Nam', '2005-07-18'),
    (N'Lê Huỳnh Kim Vân', '0341234567', N'Nữ', '2013-09-25'),
    (N'Phạm Anh Kiệt', '0394506792', 'Nam', '2008-11-30'),
    (N'Hoàng Nguyễn Thu Phuong', '0934267893', N'Nữ', '2011-06-20'),
    (N'Nguyễn Trần Khánh An', '0934567870', N'Nữ', '2009-03-12'),
    (N'Trần Minh Tuấn', '0934562991', 'Nam', '2005-07-18'),
    (N'Lê Bích Vân', '0391233567', N'Nữ', '2013-09-25'),
    (N'Phạm Khánh Chi', '0394561792', 'Nam', '2008-11-30'),
    (N'Hoàng Nguyễn Bảo Như', '0934467893', N'Nữ', '2011-06-20');

GO
	-- Nhà Cung Cấp
	INSERT INTO NhaCungCap(MaNCC, TenNCC, DiaChi, Sdt) VALUES	 
	('NCC001', N'Công ty Cung Ứng Tiên Tiến', N'123 Lê Lợi, Quận 1, TP.HCM', '0934567890'),
	('NCC002', N'Công ty Nhật Minh', N'456 Nguyễn Huệ, Quận 1, TP.HCM', '0356789123'),
	('NCC003', N'Công ty TNHH Thương Mại Thuận Hương ', N'789 Trần Hưng Đạo, Quận 5, TP.HCM', '0939876541'),
	('NCC004', N'Công ty TNHH Sản Xuất Thương Mại Dasaque', N'64 Phạm Ngũ Lão, Quận 3, TP.HCM', '0351234567'),
	('NCC005', N' Công ty TNHH thực phẩm Orion Vina', N'561A Điện Biên Phủ, Phường 25, Quận Bình Thạnh, TP. HCM', '0283123123'),
	('NCC006', N'Công ty cổ phần Bibica', N'545 Kinh Dương Vương, Phường An Lạc, Quận Bình Tân, TP.HCM', '0289362877'),
	('NCC007', N'Công ty CP bánh kẹo Á Châu', N'12 Phạm Ngũ Lão, Quận 3, TP.HCM', '0953237422'),
	('NCC008', N'Thuận Thiên Food', N'12 Huỳnh Thị Na, Ấp 6, Đông Thạnh, Hóc Môn, TPHCM', '0932050522'),
	('NCC009', N'Sữa chua Wel Yo', N'120 Đường D1,  TP Thủ Dầu Một, Tỉnh Bình Dương', '0938345177'),
	('NCC010', N'Sữa chua Emmi ', N'182 Hồ Văn Huê, Phường 9, Quận Phú Nhuận, TPHCM', '0911205052');

GO
	-- Nguyên Liệu
	INSERT INTO NguyenLieu(MaNL, TenNL, SoLuong, DonVi, TrangThai) VALUES
	('NL001', N'Trà đen', 50, N'Túi','Available'),
	('NL002', N'Sữa đặc', 30, N'Lon','Available'), 
	('NL003', N'Trân châu đen', 15, N'Hủ','Available'),
	('NL004', N'Trà xanh Thái', 30, N'Túi','Available'),
	('NL005', N'Trân châu đường đen', 10, N'Hủ','Available'),
	('NL006', N'Bột Matcha', 30, N'Túi','Available'),
	('NL007', N'Thạch Matcha', 20, N'Hủ','Available'),
	('NL008', N'Kem cheese', 20, N'Lon','Available'),
	('NL009', N'Dâu tây ', 20, N'Kg','Available'),
	('NL010', N'Sữa tươi', 50, N'Hộp','Available'),
	('NL011', N'Bơ chín', 20, N'Kg','Available'),
	('NL012', N'Sapoche', 20, N'Kg','Available'),
	('NL013', N'Đào', 15, N'Kg','Available'),
	('NL014', N'Cam', 20, N'Kg','Available'),
	('NL015', N'Xả', 10, N'Kg','Available'), 
	('NL016', N'Vải', 10, N'Kg','Available'),
	('NL017', N'Chanh', 10, N'Kg','Available'),
	('NL018', N'Dưa hấu', 30, N'Kg','Available'),
	('NL019', N'Lựu', 10, N'Kg','Available'); 

GO
	-- Đơn nhập nguyên liệu
	INSERT INTO DonNhapNL(NgayNhap, TriGiaDonNhap, MaNCC) VALUES
	('2024-03-28', 6150000, 'NCC001'),
	('2024-03-28', 7375000, 'NCC002'),
	('2024-04-01', 6400000, 'NCC003'),
	('2024-04-01', 2975000, 'NCC004');

GO
	-- Chi tiết đơn nhập nguyên liệu
	INSERT INTO ChiTiet_DNNL(MaDNNL, MaNL, SoLuong, DonVi, DonGia) VALUES
	-- DNNL1
	(1, 'NL001', 55, N'Túi', 50000),
	(1, 'NL003', 20, N'Hủ', 30000), 
	(1, 'NL004', 20, N'Túi', 60000), 
	(1, 'NL006', 20, N'Túi', 80000), 
	-- DNNL2
	(2, 'NL002', 35, N'Lon', 25000), 
	(2, 'NL005', 20, N'Hủ', 100000),
	(2, 'NL007', 20, N'Hủ', 100000), 
	(2, 'NL008', 25, N'Lon', 100000), 
	-- DNNL3
	(3, 'NL009', 25, N'Kg', 100000), 
	(3, 'NL010', 55, N'Hộp', 30000), 
	(3, 'NL011', 25, N'Kg', 60000), 
	(3, 'NL012', 25, N'Kg', 30000), 
	-- DNNL4
	(4, 'NL013', 20, N'Kg', 20000), 
	(4, 'NL014', 20, N'Kg', 15000),
	(4, 'NL015', 15, N'Kg', 15000), 
	(4, 'NL016', 15, N'Kg', 30000), 
	(4, 'NL017', 15, N'Kg', 15000),
	(4, 'NL018', 30, N'Kg', 30000), 
	(4, 'NL019', 10, N'Kg', 10000);


GO
	-- Đơn xuất nguyên liệu
	INSERT INTO DonXuatNL(NgayXuat, MaNV) VALUES
	('2024-04-04', 'NV001'),
	('2024-04-05', 'NV007');

GO
	-- Chi tiết đơn xuất nguyên liệu
	INSERT INTO ChiTiet_DXNL(MaDXNL, MaNL, SoLuong, DonVi) VALUES
	(1, 'NL001', 5, N'Túi'),
	(1, 'NL002', 5, N'Lon'),
	(1, 'NL003', 5, N'Hủ'),
	(1, 'NL004', 10, N'Túi'),
	(1, 'NL005', 10, N'Hủ'),
	(1, 'NL006', 10, N'Túi'),
	(1, 'NL008', 5, N'Lon'),
	(2, 'NL009', 5, N'Kg'),
	(2, 'NL010', 5, N'Hộp'),
	(2, 'NL011', 5, N'Kg'),
	(2, 'NL012', 5, N'Kg'),
	(2, 'NL013', 5, N'Kg'),
	(2, 'NL015', 5, N'Kg'),
	(2, 'NL016', 5, N'Kg'),
	(2, 'NL017', 5, N'Kg'),
	(2, 'NL018', 5, N'Kg');

GO
	-- Loại sản phẩm
	INSERT INTO LoaiSanPham(MaLoaiSP, TenLoaiSP) VALUES
	('LSP01', N'Trà Sữa'),
	('LSP02', N'Sinh Tố'),
	('LSP03', N'Trà Trái Cây'),
	('LSP04', N'Nước Ép'),
	('LSP05', N'Sữa Chua'),
	('LSP06', N'Đồ Ăn');

GO
	-- Sản phẩm
	INSERT INTO SanPham(MaSP, TenSP, SoLuong, DonGia, MaLoaiSP) VALUES
	('SP01', N'Trà Sữa Truyền Thống', 0, 30000, 'LSP01'),
	('SP02', N'Trà Sữa Thái Xanh', 0, 35000, 'LSP01'),
	('SP03', N'Trà Sữa Trân Châu Đường Đen', 0, 40000, 'LSP01'),
	('SP04', N'Trà Sữa Matcha', 0, 45000, 'LSP01'),
	('SP05', N'Trà Sữa Kem Cheese', 0, 50000, 'LSP01'),
	('SP06', N'Sinh Tố Dâu', 0, 35000, 'LSP02'),
	('SP07', N'Sinh Tố Bơ', 0, 40000, 'LSP02'),
	('SP08', N'Sinh Tố Sapoche', 0, 45000, 'LSP02'),
	('SP09', N'Trà Đào Cam Xả', 0, 30000, 'LSP03'),
	('SP10', N'Trà Vải', 0, 35000, 'LSP03'),
	('SP11', N'Trà Chanh', 0, 30000, 'LSP03'),
	('SP12', N'Nước Ép Dưa Hấu', 0, 25000, 'LSP04'),
	('SP13', N'Nước Ép Cam', 0, 25000, 'LSP04'),
	('SP14', N'Nước Ép Lựu', 0, 30000, 'LSP04'),
	('SP15', N'Sữa Chua Truyền Thống', 50, 20000, 'LSP05'),
	('SP16', N'Sữa Chua Việt Quất', 48, 25000, 'LSP05'),
	('SP17', N'Sữa Chua Nha Đam', 50, 25000, 'LSP05'),
	('SP18', N'Bánh Tiramisu', 1, 50000, 'LSP06'),
	('SP19', N'Bánh Panna Cotta', 50, 45000, 'LSP06'),
	('SP20', N'Bánh Cheese Cake', 50, 55000, 'LSP06'),
	('SP21', N'Bánh Cookies', 48, 30000, 'LSP06');

GO
	-- Đơn nhập sản phẩm
	INSERT INTO DonNhapSP(NgayNhap, TriGiaDonNhap, MaNCC) VALUES 
	('2024-04-01', 4000000, 'NCC006'),
	('2024-04-02', 1500000, 'NCC009');

GO
	-- Chi tiết đơn nhập sản phẩm
	INSERT INTO ChiTiet_DNSP(MaDNSP, MaSP, SoLuong, DonVi, DonGia) VALUES
	(1, 'SP18', 50, N'Bánh', 1000000),
	(1, 'SP19', 50, N'Bánh', 1000000),
	(1, 'SP20', 50, N'Bánh', 1000000),
	(1, 'SP21', 50, N'Bánh', 1000000),
	(2, 'SP15', 50, N'Hủ', 500000),
	(2, 'SP16', 50, N'Hủ', 500000),
	(2, 'SP17', 50, N'Hủ', 500000);

GO
	-- Công thức chế biến
	INSERT INTO CheBien(MaSP, MaNL, LieuLuong, DonVi) VALUES
	-- Trà sữa truyền thống
    ('SP01', 'NL001', 2, N'Túi lọc'), --Trà đen
    ('SP01', 'NL002', 100, N'ml'),  -- Sữa đặc
    ('SP01', 'NL003', 50, N'g'),  -- Trân châu đen
	-- Trà sữa thái xanh
	('SP02', 'NL004', 2, N'Túi lọc'), -- Trà xanh Thái
	('SP02', 'NL002', 100, N'ml'), -- Sữa đặc
	('SP02', 'NL003', 50, N'g'), -- Trân châu đen
	-- Trà sữa Trân Châu Đường Đen
	('SP03', 'NL001', 2, N'Túi lọc'), -- Trà đen
	('SP03', 'NL002', 100, N'ml'), -- Sữa đặc
	('SP03', 'NL005', 50, N'g'), -- Trân châu đường đen
	-- Trà sữa Matcha
	('SP04', 'NL006', 10, N'g'), -- Bột Matcha
	('SP04', 'NL002', 100, N'ml'), -- Sữa đặc có đường
	('SP04', 'NL007', 30, N'g'), -- Thạch Matcha
	-- Trà sữa Kem Cheese
	('SP05', 'NL001', 2, N'Túi lọc'), -- Trà đen
	('SP05', 'NL002', 100, N'ml'), -- Sữa đặc
	('SP05', 'NL008', 20, N'ml'), -- Kem cheese
	('SP05', 'NL003', 50, N'g'), -- Trân châu đen
	-- Sinh tố Dâu
	('SP06', 'NL009', 6, N'Trái'), -- Dâu tây 
	('SP06', 'NL010', 200, N'ml'), -- Sữa tươi
	-- Sinh tố Bơ
	('SP07', 'NL011', 1, N'Trái'), -- Bơ chín
	('SP07', 'NL010', 200, N'ml'), -- Sữa tươi
	-- Sinh tố Sapoche
	('SP08', 'NL012', 2, N'Trái'), -- Sapoche
	('SP08', 'NL010', 200, N'ml'), -- Sữa tươi
	-- Trà Đào Cam Xả
	('SP09', 'NL001', 1, N'Túi'), -- Trà đen
	('SP09', 'NL013', 5, N'Miếng'), -- Đào
	('SP09', 'NL014', 3, N'Lát'), -- Cam
	('SP09', 'NL015', 1, N'Tép'), -- Xả
	-- Trà Vải
	('SP10', 'NL001', 1, N'Túi lọc'), -- Trà đen
	('SP10', 'NL016', 5, N'Trái'), -- Vải
	-- Trà Chanh
	('SP11', 'NL001', 2, N'Túi lọc'), -- Trà đen
	('SP11', 'NL017', 3, N'Trái'), -- Chanh
	-- Nước ép Dưa Hấu
	('SP12', 'NL018', 1, N'Kg'), -- Dưa hấu
	-- Nước ép Cam
	('SP13', 'NL014', 3, N'Trái'), -- Cam
	-- Nước ép Lựu
	('SP14', 'NL019', 2, N'Quả'); -- Lựu

GO
	-- Hoá đơn 
	INSERT INTO HoaDon(SDT, MaNV, ThoiGianDat, TriGiaHoaDon, GhiChu) VALUES 
	('0123156789', 'NV003', '2024-03-28 08:30:00', 90000, NULL),
	('0123456791', 'NV003', '2024-03-28 09:45:00', 60000, NULL),
	('0123458791', 'NV003', '2024-03-28 10:15:00', 130000, NULL),
	('0123186792', 'NV003', '2024-03-28 11:20:00', 65000, NULL),
	('0123459793', 'NV003', '2024-03-28 13:00:00', 95000, NULL),
	('0934467893', 'NV003', '2024-03-28 13:30:00', 180000, NULL);
GO
	-- Chi tiết hoá đơn
	INSERT INTO ChiTietHoaDon(MaHD, MaSP, SoLuong) VALUES
	-- HD1
	(1, 'SP01', 1),
	(1, 'SP02', 1),
	(1, 'SP16', 1),
	-- HD2
	(2, 'SP01', 2),
	-- HD3
	(3, 'SP02', 2),
	(3, 'SP11', 2),
	-- HD4
	(4, 'SP03', 1),
	(4, 'SP16', 1),
	-- HD5
	(5, 'SP04', 1),
	(5, 'SP18', 1),
	-- HD6
	(6, 'SP07', 3),
	(6, 'SP21', 2);

-- Tạo view xem thông tin khách hàng
CREATE VIEW vie_ThongTinKH AS
	SELECT * FROM KhachHang
-- Tạo view xem doanh thu đã bán tại quầy trong ngày
CREATE VIEW vie_DoanhThuTaiQuayTrongNgay AS
	SELECT sp.MaSP, sp.TenSP, SUM(cthd.SoLuong*sp.DonGia) AS 'Doanh thu tại quầy',
			cthd.SoLuong AS 'Số lượng tại quầy'
	FROM HoaDon AS hd
	JOIN ChiTietHoaDon AS cthd ON hd.MaHD = cthd.MaHD
	JOIN SanPham AS sp ON cthd.MaSP = sp.MaSP 
	WHERE CONVERT(DATE, hd.ThoiGianDat) = CONVERT(DATE, GETDATE())
	GROUP BY sp.MaSP,sp.TenSP, cthd.SoLuong
-- Tạo view xem thông tin sản phẩm
CREATE VIEW vie_ThongTinSP AS
	SELECT lsp.TenLoaiSP, sp.TenSP, sp.SoLuong, sp.DonGia
	FROM SanPham AS sp
	JOIN LoaiSanPham AS lsp ON sp.MaLoaiSP = lsp.MaLoaiSP
-- Trigger kiểm tra nguyên liệu hoặc sản phẩm còn để bán không

CREATE TRIGGER tg_KiemTraTrangThaiNguyenLieu
ON NguyenLieu
AFTER INSERT, UPDATE
AS
BEGIN
	IF EXISTS (Select * From NguyenLieu Where SoLuong < 3)
	BEGIN
		UPDATE NguyenLieu
		SET TrangThai = 'Unvailable'
	END
	ELSE
	BEGIN
		UPDATE NguyenLieu
		SET TrangThai = 'Available'
	END
END
-- 
CREATE TRIGGER tg_KiemTraTrangThaiSanPham
ON ChiTietHoaDon
AFTER INSERT
AS
BEGIN
	Declare @MaSP nvarchar(10)
	Select @MaSP = i.MaSP From inserted i
	IF (@MaSP = 'SP15' OR @MaSP = 'SP16' OR @MaSP = 'SP17' OR @MaSP = 'SP18' 
		OR @MaSP = 'SP19' OR @MaSP = 'SP20' OR @MaSP = 'SP21')
	BEGIN
		IF EXISTS (SELECT * FROM SanPham WHERE SoLuong < 10 
					AND (MaSP = 'SP15' OR MaSP = 'SP16' OR MaSP = 'SP17' OR MaSP = 'SP18' 
							OR MaSP = 'SP19' OR MaSP = 'SP20' OR MaSP = 'SP21'))
		BEGIN
			UPDATE SanPham
			SET TrangThai = 'Unvailable'
			WHERE MaSP = 'SP15' OR MaSP = 'SP16' OR MaSP = 'SP17' OR MaSP = 'SP18' 
							OR MaSP = 'SP19' OR MaSP = 'SP20' OR MaSP = 'SP21'
		END
		ELSE
		BEGIN
			UPDATE SanPham
			SET TrangThai = 'Available'
			WHERE MaSP = 'SP15' OR MaSP = 'SP16' OR MaSP = 'SP17' OR MaSP = 'SP18' 
							OR MaSP = 'SP19' OR MaSP = 'SP20' OR MaSP = 'SP21'
		END
	END
END

-- Procedure tạo hóa đơn
CREATE PROCEDURE proc_CreateBill
@SDT varchar(12), @MaNV varchar(10), @ThoiGianDat datetime, @TriGiaHoaDon NUMERIC(18,0)
AS
BEGIN
	INSERT INTO HoaDon(SDT, MaNV, ThoiGianDat, TriGiaHoaDon)
	VALUES(@SDT, @MaNV, @ThoiGianDat, @TriGiaHoaDon);
END;
-- Procedure tìm kiếm hóa đơn
CREATE PROCEDURE proc_FindBill
AS
BEGIN
	Declare @Keyword nvarchar(100)
	SELECT *
	FROM HoaDon
	WHERE MaHD LIKE '%'+@Keyword+'%' OR MaNV LIKE '%'+@Keyword+'%' OR MaHD LIKE '%'+@Keyword+'%' OR
		  ThoiGianDat LIKE '%'+@Keyword+'%' OR TriGiaHoaDon LIKE '%'+@Keyword+'%'
END;

SELECT * FROM SanPham
SELECT * FROM LoaiSanPham
SELECT * FROM SanPham sp WHERE sp.MaLoaiSP = 'LSP01'