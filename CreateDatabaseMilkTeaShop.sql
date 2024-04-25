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
CREATE TABLE DonNhapNguyenLieu(
	MaDNNL INT IDENTITY (1,1) CONSTRAINT PK_MaDNNL PRIMARY KEY,
	NgayNhap DATE NOT NULL CHECK(DATEDIFF(year, NgayNhap, GETDATE()) >= 0), 
	TriGiaDonNhap NUMERIC(18,0) NOT NULL CHECK(TriGiaDonNhap > 0),
	MaNCC VARCHAR(10) CONSTRAINT FK_DonNhapNL_NCC FOREIGN KEY REFERENCES NhaCungCap(MaNCC)
)

GO
-- Tao bang ChiTietDNNL
CREATE TABLE ChiTiet_DonNhapNguyenLieu(
	MaDNNL INT CONSTRAINT ChiTiet_DNNL_DN FOREIGN KEY REFERENCES DonNhapNguyenLieu(MaDNNL),
	MaNL VARCHAR(10) CONSTRAINT ChiTiet_DNNL_NL FOREIGN KEY REFERENCES NguyenLieu(MaNL),
	CONSTRAINT PK_ChiTiet_DNNL PRIMARY KEY (MaDNNL, MaNL), 
	SoLuong INT NOT NULL CHECK(SoLuong > 0), 
	DonVi NVARCHAR(20) NOT NULL, 
	DonGia NUMERIC(18,0) NOT NULL CHECK(DonGia > 0),
)

GO
-- Tao bang DonXuatNguyenLieu
CREATE TABLE DonXuatNguyenLieu(
	MaDXNL INT IDENTITY (1,1) CONSTRAINT PK_DonXuatNL PRIMARY KEY,
	NgayXuat DATE NOT NULL CHECK(DATEDIFF(year, NgayXuat, GETDATE()) >= 0), 
	MaNV VARCHAR(10) CONSTRAINT FK_DonXuatNL_NV FOREIGN KEY REFERENCES NhanVien(MaNV)
)

GO
-- Tao bang ChiTietDXNL
CREATE TABLE ChiTiet_DonXuatNguyenLieu(
	MaDXNL INT CONSTRAINT ChiTiet_DXNL_DN FOREIGN KEY REFERENCES DonXuatNguyenLieu(MaDXNL),
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
CREATE TABLE DonNhapSanPham( 
	MaDNSP INT IDENTITY (1,1) CONSTRAINT PK_DonNhapSP PRIMARY KEY,
	NgayNhap DATE NOT NULL CHECK(DATEDIFF(year, NgayNhap, GETDATE()) >= 0), 
	TriGiaDonNhap NUMERIC(18,0) NOT NULL CHECK(TriGiaDonNhap > 0), 
	MaNCC VARCHAR(10) CONSTRAINT FK_DonNhapSP_NCC FOREIGN KEY REFERENCES NhaCungCap(MaNCC)
)

GO
-- Tao bang ChiTietDNSP
CREATE TABLE ChiTiet_DonNhapSanPham(
	MaDNSP INT CONSTRAINT ChiTiet_DNSP_DN FOREIGN KEY REFERENCES DonNhapSanPham(MaDNSP),
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
	INSERT INTO DonNhapNguyenLieu(NgayNhap, TriGiaDonNhap, MaNCC) VALUES
	('2024-03-28', 6150000, 'NCC001'),
	('2024-03-28', 7375000, 'NCC002'),
	('2024-04-01', 6400000, 'NCC003'),
	('2024-04-01', 2975000, 'NCC004');

GO
	-- Chi tiết đơn nhập nguyên liệu
	INSERT INTO ChiTiet_DonNhapNguyenLieu(MaDNNL, MaNL, SoLuong, DonVi, DonGia) VALUES
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
	INSERT INTO DonXuatNguyenLieu(NgayXuat, MaNV) VALUES
	('2024-04-04', 'NV001'),
	('2024-04-05', 'NV007');

GO
	-- Chi tiết đơn xuất nguyên liệu
	INSERT INTO ChiTiet_DonXuatNguyenLieu(MaDXNL, MaNL, SoLuong, DonVi) VALUES
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
	INSERT INTO DonNhapSanPham(NgayNhap, TriGiaDonNhap, MaNCC) VALUES 
	('2024-04-01', 4000000, 'NCC006'),
	('2024-04-02', 1500000, 'NCC009');

GO
	-- Chi tiết đơn nhập sản phẩm
	INSERT INTO ChiTiet_DonNhapSanPham(MaDNSP, MaSP, SoLuong, DonVi, DonGia) VALUES
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

GO

-- View thông tin nhân viên và công việc của nhân viên đó
CREATE VIEW V_ThongTinNhanVien
AS
	SELECT nv.MaNV, nv.HoTen, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.NgayTuyenDung, cv.TenCV, cv.Luong
	FROM NhanVien nv, CongViec cv
	WHERE nv.MaCV = cv.MaCV

GO

-- Tạo view xem thông tin sản phẩm
CREATE VIEW v_ThongTinSanPham 
AS
	SELECT lsp.TenLoaiSP, sp.TenSP, sp.SoLuong, sp.DonGia
	FROM SanPham AS sp
	JOIN LoaiSanPham AS lsp ON sp.MaLoaiSP = lsp.MaLoaiSP

GO

-- Tạo view xem doanh thu đã bán tại quầy trong ngày
CREATE VIEW v_DoanhThuTaiQuayTrongNgay AS
	SELECT sp.MaSP, sp.TenSP, SUM(cthd.SoLuong*sp.DonGia) AS 'Doanh thu tại quầy',
			cthd.SoLuong AS 'Số lượng tại quầy'
	FROM HoaDon AS hd
	JOIN ChiTietHoaDon AS cthd ON hd.MaHD = cthd.MaHD
	JOIN SanPham AS sp ON cthd.MaSP = sp.MaSP 
	WHERE CONVERT(DATE, hd.ThoiGianDat) = CONVERT(DATE, GETDATE())
	GROUP BY sp.MaSP,sp.TenSP, cthd.SoLuong
GO

-- Xem thông tin nhà cung cấp
CREATE VIEW v_ThongTinNhaCungCap AS
    SELECT 
        MaNCC, 
        TenNCC, 
        DiaChi, 
        SDT
    FROM NhaCungCap
GO

-- Xem cách chế biến sản phẩm
CREATE VIEW v_CachCheBienSanPham AS
    SELECT 
        SP.TenSP, 
        NL.TenNL, 
        CB.LieuLuong, 
        CB.DonVi
    FROM SanPham SP
        INNER JOIN CheBien CB ON SP.MaSP = CB.MaSP
        INNER JOIN NguyenLieu NL ON CB.MaNL = NL.MaNL
GO

-- View xem số lượng nguyên liệu còn lại
CREATE VIEW v_NguyenLieuConLai AS
	SELECT MaNL, TenNL, SoLuong, DonVi
	FROM NguyenLieu
	WHERE SoLuong > 0

GO

-- Tạo view xem thông tin khách hàng
CREATE VIEW v_ThongTinKhacHang
AS
	SELECT * FROM KhachHang

GO

-- Xem lịch sử mua hàng của khách hàng
CREATE VIEW v_LichSuMuaHang AS
	SELECT 
		k.TenKH,
		K.SDT,
		H.MaHD,
		H.ThoiGianDat,
		S.TenSP,
		C.SoLuong,
		S.DonGia
	FROM KhachHang K 
		INNER JOIN HoaDon H ON K.SDT = H.SDT
		INNER JOIN ChiTietHoaDon C ON H.MaHD = C.MaHD
		INNER JOIN SanPham S ON C.MaSP = S.MaSP

GO

--Trigger kiểm tra tên sản phẩm đã tồn tại chưa (khi thêm hoặc update sp)
CREATE TRIGGER TG_TrungTenSanPham ON SanPham
FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (
		SELECT *
		FROM inserted i
		WHERE EXISTS (
			SELECT *
			FROM SanPham sp
			WHERE sp.TenSP = i.TenSP AND sp.MaSP <> i.MaSP
		)
	)
	BEGIN
		PRINT N'Tên sản phẩm bị trùng'
		ROLLBACK;
	END
END

GO

-- Trigger kiểm tra nguyên liệu còn để bán không
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

GO

-- TRigger kiểm tra sản phẩm còn để bán không
CREATE TRIGGER tg_KiemTraTrangThaiSanPham
ON ChiTietHoaDon
AFTER INSERT
AS
BEGIN
	Declare @MaSP nvarchar(10)
	Select @MaSP = i.MaSP From inserted i
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

GO

-- Trigger cập nhật số lượng nguyên liệu sau khi nhập hàng
CREATE TRIGGER trg_CapNhatSoLuongNguyenLieuKhiNhap
ON ChiTiet_DonNhapNguyenLieu
AFTER INSERT
AS
BEGIN
    UPDATE NguyenLieu
    SET NguyenLieu.SoLuong = NguyenLieu.SoLuong + i.SoLuong 
    FROM inserted i
    WHERE NguyenLieu.MaNL = i.MaNL; 
END;

GO

-- Trigger cập nhật số lượng sản phẩm sau khi nhập hàng
CREATE TRIGGER trg_CapNhatSoLuongSanPhamKhiNhap
ON ChiTiet_DonNhapSanPham
AFTER INSERT
AS
BEGIN
	UPDATE SanPham
	SET SanPham.SoLuong = SanPham.SoLuong + i.SoLuong
	From inserted i
	WHERE SanPham.MaSP = i.MaSP
END;

GO

-- Trigger cập nhật số lượng nguyên liệu khi xuất hàng.
CREATE TRIGGER trg_CapNhatSoLuongNguyenLieuKhiXuat
ON ChiTiet_DonXuatNguyenLieu
AFTER INSERT
AS
BEGIN
    DECLARE @MaNL VARCHAR(10);
    DECLARE @SoLuong INT;

    SELECT @MaNL = i.MaNL, @SoLuong = i.SoLuong
    FROM inserted i;

    IF NOT EXISTS (SELECT 1 FROM NguyenLieu WHERE MaNL = @MaNL AND SoLuong >= @SoLuong)
    BEGIN
        PRINT N'Số lượng nguyên liệu không đủ để xuất.';
        ROLLBACK;
    END
    ELSE
    BEGIN
        UPDATE NguyenLieu
        SET SoLuong = SoLuong - @SoLuong
        WHERE MaNL = @MaNL;
    END
END;

GO

-- Trigger cập nhật số lượng sản phẩm sau khi bán
CREATE TRIGGER trg_CapNhatSoLuongSanPhamKhiBan
ON ChiTietHoaDon
AFTER INSERT
AS
BEGIN
    DECLARE @MaSP VARCHAR(10);
    DECLARE @SoLuong INT;

    SELECT @MaSP = i.MaSP, @SoLuong = i.SoLuong
    FROM inserted i;

    IF NOT EXISTS (SELECT 1 FROM CheBien WHERE MaSP = @MaSP)
    BEGIN
        IF EXISTS (SELECT 1 FROM SanPham WHERE MaSP = @MaSP AND SoLuong >= @SoLuong)
        BEGIN
            UPDATE SanPham
            SET SoLuong = SoLuong - @SoLuong
            WHERE MaSP = @MaSP;
        END
        ELSE
        BEGIN
            PRINT N'Số lượng sản phẩm không đủ để bán.';
            ROLLBACK;
            RETURN;
        END
    END
END;

GO
-- thủ tục khôi phục
CREATE PROCEDURE proc_CreateBill
@SDT varchar(12), 
@MaNV varchar(10), 
@ThoiGianDat datetime, 
@TriGiaHoaDon NUMERIC(18,0)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra số lượng sản phẩm trước khi thêm hóa đơn
        DECLARE @OutOfStock INT;
        SET @OutOfStock = (
            SELECT COUNT(*)
            FROM SanPham s 
            WHERE s.SoLuong < 3 AND s.MaSP IN ('SP15', 'SP16', 'SP17', 'SP18', 'SP19', 'SP20','SP21')
        );

        IF @OutOfStock > 0
        BEGIN
            -- Nếu có sản phẩm hết hàng, hủy bỏ transaction và không thêm hóa đơn
            RAISERROR ('Sản phẩm đã chọn hết hàng. Thông báo khách hàng chọn món khác, và thông báo đến nhập nguyên liệu.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Thêm hóa đơn vào bảng HoaDon
        INSERT INTO HoaDon(SDT, MaNV, ThoiGianDat, TriGiaHoaDon)
        VALUES(@SDT, @MaNV, @ThoiGianDat, @TriGiaHoaDon);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, hủy bỏ transaction và trả về lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO
-- Procedure tạo hóa đơn

--CREATE PROCEDURE proc_ChuyenNLSangSP
SELECT * 
FROM CheBien cb
JOIN NguyenLieu nl ON cb.MaNL = nl.MaNL
WHERE cb.MaSP = 'SP10'
SELECT * FROM ChiTietHoaDon
GO
CREATE PROCEDURE proc_CreateBill_Test_
@SDT varchar(12), 
@MaNV varchar(10), 
@ThoiGianDat datetime, 
@TriGiaHoaDon NUMERIC(18,0)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra số lượng sản phẩm trước khi thêm hóa đơn
        DECLARE @HetSanPham INT;
        SET @HetSanPham = (
            SELECT COUNT(*)
            FROM ChiTietHoaDon c
            JOIN SanPham s ON c.MaSP = s.MaSP
            WHERE (c.SoLuong > s.SoLuong - 3) OR (MaSP = 'SP15' OR MaSP = 'SP16' OR MaSP = 'SP17' OR MaSP = 'SP18' 
											OR MaSP = 'SP19' OR MaSP = 'SP20' OR MaSP = 'SP21')
        );
		DECLARE @sl1 int, @sl2 int, @sl3 int
		SELECT *
		FROM ChiTietHoaDon cthd
		JOIN CheBien cb ON cthd.MaSP = cb.MaSP
		JOIN NguyenLieu nl ON cb.MaNL = nl.MaNL

        IF @HetSanPham > 0
        BEGIN
            -- Nếu có sản phẩm hết hàng, hủy bỏ transaction và không thêm hóa đơn
            RAISERROR ('Some products are out of stock. Please check your order.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Thêm hóa đơn vào bảng HoaDon
        INSERT INTO HoaDon(SDT, MaNV, ThoiGianDat, TriGiaHoaDon)
        VALUES(@SDT, @MaNV, @ThoiGianDat, @TriGiaHoaDon);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, hủy bỏ transaction và trả về lỗi
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO
-- Procedure tạo chi tiết hóa đơn
CREATE PROCEDURE proc_CreateBillDetails
@MaHD int, @MaSP nvarchar(10), @SoLuong int
AS
BEGIN
	INSERT INTO ChiTietHoaDon(MaHD, MaSP, SoLuong)
	VALUES (@MaHD, @MaSP, @SoLuong);
END
GO
-- Procedure tìm kiếm hóa đơn
CREATE PROCEDURE proc_FindBill
@Keyword nvarchar(100)
AS
BEGIN
	SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon
	FROM HoaDon hd
	JOIN NhanVien nv ON hd.MaNV = nv.MaNV
	JOIN KhachHang kh ON hd.SDT = kh.SDT
	WHERE hd.MaHD LIKE '%'+@Keyword+'%' OR nv.HoTen LIKE '%'+@Keyword+'%' OR kh.TenKH LIKE '%'+@Keyword+'%' OR
		  hd.ThoiGianDat LIKE '%'+@Keyword+'%' OR hd.TriGiaHoaDon LIKE '%'+@Keyword+'%' OR hd.GhiChu LIKE '%'+@Keyword+'%'
END;
GO
-- View xem hóa đơn khi  bán
CREATE VIEW vie_XemHoaDon AS
	SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon
	FROM HoaDon hd
	JOIN NhanVien nv ON hd.MaNV = nv.MaNV
	JOIN KhachHang kh ON hd.SDT = kh.SDT
GO

-- Procedure thêm nguyên liệu
CREATE PROCEDURE proc_themNguyenLieu
@MaNL varchar(10),
@TenNL nvarchar(255),
@SoLuong int,
@DonVi nvarchar(20),
@TrangThai varchar(15)
AS
BEGIN
	BEGIN TRY
		--Thêm mới sản phẩm
		INSERT INTO dbo.NguyenLieu (MaNL, TenNL, SoLuong, DonVi, TrangThai)
		VALUES (@MaNL, @TenNL, @SoLuong, @DonVi, @TrangThai)
	END TRY
	BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
	END CATCH
END

GO
	-- Test proc_themNguyenLieu
	Execute proc_themNguyenLieu 'NL020', N'Trà Test', 50, N'Túi','Available' 
	select * from NguyenLieu
	delete nguyenlieu where MaNL= 'NL020'

GO

-- Hàm tìm kiếm nguyên liệu
CREATE FUNCTION func_timNguyenLieu (@string NVARCHAR(255))
RETURNS @IngreList TABLE (MaNL varchar(10), TenNL nvarchar(255),SoLuong int, DonVi nvarchar(10), TrangThai varchar(15))
AS
BEGIN
	INSERT INTO @IngreList
	SELECT *
	FROM dbo.NguyenLieu
	WHERE CONCAT(MaNL, TenNL, DonVi, TrangThai) LIKE N'%' + @string + '%'
	RETURN
END

GO
--(MaSP varchar(10), TenSP nvarchar(255), SoLuong int, DonGia numeric(18,0), MaLoaiSP varchar(10), TrangThai nvarchar(100) )
CREATE FUNCTION func_timSanPhamTheoTen (
	@keyword nvarchar(255)
)
RETURNS TABLE AS
RETURN (
	SELECT *
	FROM SanPham
	WHERE TenSP LIKE N'%'+@keyword+'%' OR MaLoaiSP LIKE N'%'+@keyword+'%'
)

GO
CREATE TRIGGER trg_CheckNhanVien
ON NhanVien
FOR INSERT, UPDATE
AS
BEGIN
    -- check HoTen
    IF EXISTS (SELECT * FROM inserted WHERE TRIM(HoTen) = '' )
    BEGIN
        RAISERROR('Tên nhân viên không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    -- Check Địa Chỉ
    IF EXISTS (SELECT * FROM inserted WHERE TRIM(DiaChi) = '' )
    BEGIN
        RAISERROR('Địa chỉ không được để trống', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    -- check SĐT
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN NhanVien n ON i.MaNV != n.MaNV
    AND TRIM(i.SDT) = TRIM(n.SDT))
    BEGIN
        RAISERROR('Số điện thoại đã tồn tại', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    -- check Tuổi
    IF EXISTS (
    SELECT * FROM inserted WHERE
    datediff(year, inserted.NgaySinh, getdate()) < 18)
    BEGIN
        RAISERROR ('Nhân viên phải trên 18 tuổi', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    -- check ngay tuyen dung
    IF EXISTS (
    SELECT * FROM inserted WHERE
    datediff(day, inserted.NgayTuyenDung, getdate()) < 0)
    BEGIN
        RAISERROR ('Ngày tuyển dụng không thể là trong tương lai', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    -- check Giới Tính
    IF EXISTS (SELECT * FROM inserted WHERE NOT (TRIM(GioiTinh) IN ('Nam', 'Nữ', '')))
    BEGIN
        RAISERROR('Giới tính phải là Nam, Nữ.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END;

GO
CREATE PROC proc_EditStaff
    @manv nchar(10), 
    @hoten nvarchar(30), 
    @ngaysinh date,
    @gioitinh nvarchar(3), 
    @diachi nvarchar(255), 
    @sdt nchar(11), 
    @macv nchar(10),
    @ngaytuyendung date
AS
BEGIN
    BEGIN TRY
        UPDATE NhanVien
        SET
            HoTen = @hoten,
            NgaySinh = @ngaysinh,
            GioiTinh = @gioitinh,
            DiaChi = @diachi,
            SDT = @sdt,
            MaCV = @macv,
            NgayTuyenDung = @ngaytuyendung
        WHERE MaNV = @manv
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
        RAISERROR(@err, 16, 1)
    END CATCH
END

GO
CREATE PROCEDURE proc_AddStaff
    @manv nchar(10),
    @hoten nvarchar(30),
    @ngaysinh date,
    @gioitinh nvarchar(3),
    @diachi nvarchar(255),
    @sdt nchar(11),
    @ngaytuyendung date,
    @macv nchar(10)
AS
BEGIN
    INSERT INTO NhanVien (
        MaNV, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, NgayTuyenDung, MaCV
    )
    VALUES (
        @manv, @hoten, @ngaysinh, @gioitinh, @diachi, @sdt, @ngaytuyendung, @macv
    )
END
GO
-- Tạo view xem Chi tiết hóa đơn
CREATE VIEW vie_XemCTHD AS
	SELECT cthd.MaHD, STRING_AGG(cthd.MaSP + ' (' + CAST(cthd.SoLuong as varchar) + ') ', ' ') AS 'Danh sách sản phẩm', hd.ThoiGianDat, hd.TriGiaHoaDon
	FROM ChiTietHoaDon cthd
	JOIN HoaDon hd ON cthd.MaHD = hd.MaHD
	GROUP BY cthd.MaHD, hd.ThoiGianDat, hd.TriGiaHoaDon
GO
-- Procedure xếp hóa đơn giảm dần theo ngày đặt
CREATE PROCEDURE proc_HoaDonGiamTheoOrderTime AS 
BEGIN
	SET NOCOUNT ON;

	SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon
	FROM HoaDon hd
	JOIN NhanVien nv ON hd.MaNV = nv.MaNV
	JOIN KhachHang kh ON hd.SDT = kh.SDT
	ORDER BY hd.ThoiGianDat Desc
END
GO
-- Procedure xếp hóa đơn tăng dần theo ngày đặt
CREATE PROCEDURE proc_HoaDonTangTheoOrderTime AS 
BEGIN
	SET NOCOUNT ON;

	SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon
	FROM HoaDon hd
	JOIN NhanVien nv ON hd.MaNV = nv.MaNV
	JOIN KhachHang kh ON hd.SDT = kh.SDT
	ORDER BY hd.ThoiGianDat
END
GO
-- Procedure xếp hóa đơn giảm dần theo tổng giá trị đơn hàng

CREATE PROCEDURE proc_HoaDonGiamTheoTotalBill AS 
BEGIN
	SET NOCOUNT ON;

	SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon
	FROM HoaDon hd
	JOIN NhanVien nv ON hd.MaNV = nv.MaNV
	JOIN KhachHang kh ON hd.SDT = kh.SDT
	ORDER BY hd.TriGiaHoaDon Desc
END
GO
-- Procedure xếp hóa đơn tăng dần theo tổng giá trị đơn hàng
CREATE PROCEDURE proc_HoaDonTangTheoTotalBill AS 
BEGIN
	SET NOCOUNT ON;

	SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon
	FROM HoaDon hd
	JOIN NhanVien nv ON hd.MaNV = nv.MaNV
	JOIN KhachHang kh ON hd.SDT = kh.SDT
	ORDER BY hd.TriGiaHoaDon 
END
GO

-- Thống kê doanh thu và chi phí
CREATE FUNCTION func_tinhDoanhThuTheoNgay
(@ngay INT, @thang INT, @nam INT)
RETURNS DECIMAL
AS
BEGIN
	 DECLARE @doanhThu DECIMAL = 0;
	 SELECT @doanhThu = COALESCE(SUM(TriGiaHoaDon), 0)
	 FROM HoaDon
	 WHERE DAY(ThoiGianDat) = @ngay AND MONTH(ThoiGianDat) = @thang AND
			YEAR(ThoiGianDat) = @nam;
	RETURN @doanhThu;
END;
GO
CREATE FUNCTION func_tinhDoanhThuTheoThang
(@thang INT, @nam INT)
RETURNS DECIMAL
BEGIN
	 DECLARE @doanhThu decimal = 0;
	 SELECT @doanhthu = COALESCE(SUM(TriGiaHoaDon), 0)
	 FROM HoaDon
	 WHERE MONTH(ThoiGianDat) = @thang AND YEAR(ThoiGianDat) = @nam;
	 RETURN @doanhThu;
END;
GO
CREATE FUNCTION func_tinhDoanhThuTheoNam
(@nam INT) 
RETURNS DECIMAL
BEGIN
	 DECLARE @doanhThu decimal = 0;
	 SELECT @doanhthu = COALESCE(SUM(TriGiaHoaDon), 0)
	 FROM HoaDon
	 WHERE YEAR(ThoiGianDat) = @nam;
	 RETURN @doanhThu;
END;
GO
-- Viết các function thống kê chi phí nhập nguyên liệu và sản phẩm
CREATE FUNCTION func_ChiPhiTheoThang
(@thang int, @nam int)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @ChiPhi decimal = 0;
	SELECT @ChiPhi = @ChiPhi + COALESCE(SUM(TriGiaDonNhap), 0)
					FROM DonNhapNguyenLieu
					WHERE MONTH(NgayNhap) = @thang AND YEAR(NgayNhap) = @nam;
	SELECT @ChiPhi = @ChiPhi + COALESCE(SUM(TriGiaDonNhap), 0)
					FROM DonNhapSanPham
					WHERE MONTH(NgayNhap) = @thang AND YEAR(NgayNhap) = @nam;
	RETURN @ChiPhi;
END;
GO
CREATE FUNCTION func_ChiPhiTheoNam
(@nam int)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @ChiPhi decimal = 0;
	SELECT @ChiPhi = @ChiPhi + COALESCE(SUM(TriGiaDonNhap), 0)
					FROM DonNhapNguyenLieu
					WHERE YEAR(NgayNhap) = @nam;
	SELECT @ChiPhi = @ChiPhi + COALESCE(SUM(TriGiaDonNhap), 0)
					FROM DonNhapSanPham
					WHERE YEAR(NgayNhap) = @nam;
	RETURN @ChiPhi;
END;
GO
-- Procedure tính doanh thu và khoản chi theo thời điểm
CREATE FUNCTION func_ChiPhiTheoGiaiDoan
(@startDate date, @endDate date)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @ChiPhi decimal = 0;
	SELECT @ChiPhi = @ChiPhi + COALESCE(SUM(TriGiaDonNhap),0)
	FROM DonNhapNguyenLieu
	WHERE NgayNhap BETWEEN @startDate AND @endDate

	SELECT @ChiPhi = @ChiPhi + COALESCE(SUM(TriGiaDonNhap),0)
	FROM DonNhapSanPham
	WHERE NgayNhap BETWEEN @startDate AND @endDate

	RETURN @ChiPhi
END;
GO
CREATE FUNCTION func_DoanhThuTheoGiaiDoan
(@startDate date, @endDate date)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @doanhThu decimal = 0;
	 SELECT @doanhthu = COALESCE(SUM(TriGiaHoaDon), 0)
	 FROM HoaDon
	 WHERE ThoiGianDat BETWEEN @startDate AND @endDate

	 RETURN @doanhThu;
END;
GO


SELECT nl.TenNL, cb.LieuLuong, cb.DonVi as 'Don vi che bien', nl.SoLuong, nl.DonVi as 'Don vi nguyen lieu'
FROM CheBien cb
JOIN NguyenLieu nl ON cb.MaNL = nl.MaNL
WHERE MaSP = 'SP18'
GO
-- Procedure lấy ra chế biến và số lượng nguyên liệu còn lại của sản phẩm
CREATE PROCEDURE proc_LayCongThucCheBien
(@MaSP varchar(10))
AS
BEGIN
	BEGIN TRANSACTION Tran_LayCongThucCheBien
    BEGIN TRY
        IF @MaSP IN ('SP15', 'SP16', 'SP17', 'SP18', 'SP19', 'SP20', 'SP21')
        BEGIN
            PRINT ('Sản phẩm '+@MaSP+' không được chế biến theo công thức')
			ROLLBACK TRANSACTION Tran_LayCongThucCheBien
        END;

        ELSE
        BEGIN
            SELECT nl.TenNL, cb.LieuLuong, cb.DonVi as 'Don vi che bien', nl.SoLuong, nl.DonVi as 'Don vi nguyen lieu'
            FROM CheBien cb
            JOIN NguyenLieu nl ON cb.MaNL = nl.MaNL
            WHERE MaSP = @MaSP
        END;
		COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        RAISERROR ('Lấy công thức chế biến thất bại', 16, 1)
    END CATCH;
END;
SELECT * FROM CheBien
exec proc_LayCongThucCheBien 'SP15'
DROP PROCEDURE proc_LayCongThucCheBien
GO
-- Procedure lấy sản phẩm theo loại
CREATE PROCEDURE proc_GetProductByCategory
(@MaLoaiSP varchar(10))
AS
BEGIN
	SELECT MaSP, TenSP, DonGia 
	FROM SanPham sp 
	WHERE sp.MaLoaiSP = @MaLoaiSP
END;
GO
CREATE PROCEDURE GetProductLastest
AS
BEGIN
	SELECT TOP 1 MaHD
    FROM HoaDon
    ORDER BY MaHD Desc
END
GO
-- Tạo bảng UserAccount
CREATE TABLE UserAccount(
	Username varchar(50),
	UserPassword varchar(100),
	MaNV varchar(10)
)
GO
CREATE PROCEDURE proc_CreateAccount(
	@Username varchar(50),
	@UserPassword varchar(100),
	@MaNV varchar(10)
)
AS
BEGIN
	INSERT INTO UserAccount(Username, UserPassword, MaNV)
	VALUES (@Username, @UserPassword, @MaNV)
END;
-- Tạo phân quyền user
-- Ứng dụng gồm 2 đối tượng (Nhân viên (Nhân viên gồm: nhân viên bán hàng và nhân viên thông thường) và người quản lý)
-- Gán các quyền chỉ định cho nhân viên bán hàng và nhân viên thông thường
-- Role Staff_Sell cho các nhân viên làm công việc có mã CV003
CREATE ROLE Staff_Sell
CREATE ROLE Staff_Regular
-- Cho phép nhân viên bán hàng xem và tham chiếu trên mọi bảng
GRANT SELECT, REFERENCES TO Staff_Sell
-- Cho phép nhân viên bán hàng có quyền thực thi mọi procedure và function, trigger
GRANT EXECUTE TO Staff_Sell
-- Hạn chế một số quyền quản trị khỏi nhân viên bán hàng
DENY EXECUTE ON proc_AddStaff TO Staff_Sell
DENY EXECUTE ON proc_EditStaff TO Staff_Sell
DENY EXECUTE ON proc_themNguyenLieu TO Staff_Sell
DENY EXECUTE ON func_tinhDoanhThuTheoNgay TO Staff_Sell
DENY EXECUTE ON func_tinhDoanhThuTheoThang TO Staff_Sell
DENY EXECUTE ON func_tinhDoanhThuTheoNam TO Staff_Sell
DENY EXECUTE ON func_ChiPhiTheoThang TO Staff_Sell
DENY EXECUTE ON func_ChiPhiTheoNam TO Staff_Sell
DENY EXECUTE ON func_ChiPhiTheoGiaiDoan TO Staff_Sell
DENY EXECUTE ON func_DoanhThuTheoGiaiDoan TO Staff_Sell
DENY EXECUTE ON proc_CreateDonNhapSP TO Staff_Sell
DENY EXECUTE ON proc_CreateDonNhapNL TO Staff_Sell
DENY EXECUTE ON proc_CreateDonXuatNguyenLieu TO Staff_Sell
DENY EXECUTE ON proc_CreateDonNhapNL TO Staff_Sell
DENY EXECUTE ON proc_DeleteStaff TO Staff_Sell
DENY EXECUTE ON proc_themNhaCungCap TO Staff_Sell
DENY EXECUTE ON proc_UpdateCustomer TO Staff_Sell
DENY EXECUTE ON proc_DeleteCustomer TO Staff_Sell

-- Cho phép nhân viên thông thường có quyền xem trên mọi bảng
GRANT SELECT TO Staff_Regular

-- Với administrator cấp quyền sysadmin với nhân viên làm công việc có mã CV006
GO

-- Tạo trigger tạo login và user cho nhân viên tương ứng khi được đăng ký tài khoản
CREATE TRIGGER trg_CreateSQLServerAccount
ON UserAccount
AFTER INSERT
AS
	DECLARE @Username varchar(50), @UserPassword varchar(100), @MaNV varchar(10)
	SELECT @Username = i.Username, @UserPassword = i.UserPassword, @MaNV = i.MaNV 
	FROM inserted i
BEGIN
	DECLARE @sqlString nvarchar(MAX), @mavc varchar(10)

END;

CREATE PROCEDURE proc_CreateDonNhapSP
    @NgayNhap DATE,
    @MaNCC VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION
        BEGIN TRY
            INSERT INTO DonNhapSanPham(NgayNhap, TriGiaDonNhap, MaNCC)
            VALUES (@NgayNhap, 0, @MaNCC)

            -- Lấy ID mới được tạo ra từ bản ghi vừa chèn vào
            DECLARE @NewMaDNSP INT = SCOPE_IDENTITY();

            COMMIT TRANSACTION

            SELECT @NewMaDNSP AS NewMaDNSP
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            SELECT ERROR_MESSAGE() AS ErrorMessage
        END CATCH
END
GO
CREATE PROCEDURE proc_CreateDonNhapNL
    @NgayNhap DATE,
    @MaNCC VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION
        BEGIN TRY
            INSERT INTO DonNhapNguyenLieu (NgayNhap, TriGiaDonNhap, MaNCC)
            VALUES (@NgayNhap, 0, @MaNCC) 

            -- Lấy ID mới được tạo ra từ bản ghi vừa chèn vào
            DECLARE @NewMaDNNL INT = SCOPE_IDENTITY();

            COMMIT TRANSACTION

            SELECT @NewMaDNNL AS NewMaDNNL
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            SELECT ERROR_MESSAGE() AS ErrorMessage
        END CATCH
END
GO
-- Procedure tạo đơn xuất nguyên liệu
CREATE PROCEDURE proc_CreateDonXuatNguyenLieu
    @NgayXuat DATE,
    @MaNhanVien VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION
        BEGIN TRY
            INSERT INTO DonXuatNguyenLieu (NgayXuat, MaNV)
            VALUES (@NgayXuat, @MaNhanVien) 

            -- Lấy ID mới được tạo ra từ bản ghi vừa chèn vào
            DECLARE @NewMaDXNL INT = SCOPE_IDENTITY();

            COMMIT TRANSACTION

            SELECT @NewMaDXNL AS NewMaDXNL
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            SELECT ERROR_MESSAGE() AS ErrorMessage
        END CATCH
END
GO
CREATE PROCEDURE proc_CreateDonNhapNL
    @NgayNhap DATE,
    @MaNCC VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION
        BEGIN TRY
            INSERT INTO DonNhapNguyenLieu (NgayNhap, TriGiaDonNhap, MaNCC)
            VALUES (@NgayNhap, 0, @MaNCC) 

            -- Lấy ID mới được tạo ra từ bản ghi vừa chèn vào
            DECLARE @NewMaDNNL INT = SCOPE_IDENTITY();

            COMMIT TRANSACTION

            SELECT @NewMaDNNL AS NewMaDNNL
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            SELECT ERROR_MESSAGE() AS ErrorMessage
        END CATCH
END
GO
CREATE PROCEDURE proc_CreateDonNhapSP
    @NgayNhap DATE,
    @MaNCC VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION
        BEGIN TRY
            INSERT INTO DonNhapSanPham(NgayNhap, TriGiaDonNhap, MaNCC)
            VALUES (@NgayNhap, 0, @MaNCC)

            -- Lấy ID mới được tạo ra từ bản ghi vừa chèn vào
            DECLARE @NewMaDNSP INT = SCOPE_IDENTITY();

            COMMIT TRANSACTION

            SELECT @NewMaDNSP AS NewMaDNSP
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION
            SELECT ERROR_MESSAGE() AS ErrorMessage
        END CATCH
END
GO
CREATE PROCEDURE proc_DeleteStaff
    @MaNV VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @MaDonXuat TABLE (MaDXNL INT);
        INSERT INTO @MaDonXuat
        SELECT MaDXNL FROM DonXuatNguyenLieu WHERE MaNV = @MaNV;

        DELETE FROM ChiTiet_DonXuatNguyenLieu
        WHERE MaDXNL IN (SELECT MaDXNL FROM @MaDonXuat);

        DELETE FROM DonXuatNguyenLieu WHERE MaNV = @MaNV;

        DECLARE @MaHoaDon TABLE (MaHD INT);
        INSERT INTO @MaHoaDon
        SELECT MaHD FROM HoaDon WHERE MaNV = @MaNV;

        DELETE FROM ChiTietHoaDon
        WHERE MaHD IN (SELECT MaHD FROM @MaHoaDon);

        DELETE FROM HoaDon WHERE MaNV = @MaNV;

        DELETE FROM NhanVien WHERE MaNV = @MaNV;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
        SELECT @err = ERROR_MESSAGE();
        RAISERROR(@err, 16, 1);
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
-- PROCEDURE thêm nhà cung cấp
CREATE PROCEDURE proc_themNhaCungCap
@MaNCC varchar(10),
@TenNCC nvarchar(255),
@DiaChi nvarchar(255),
@SDT varchar(11)
AS
BEGIN
	BEGIN TRY
		--Thêm mới nhà cung cấp
		INSERT INTO dbo.NhaCungCap(MaNCC, TenNCC, DiaChi, SDT)
		VALUES (@MaNCC, @TenNCC, @DiaChi, @SDT)
	END TRY
	BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
	END CATCH
END
GO
CREATE PROCEDURE proc_UpdateCustomer
@TenKhachHang nvarchar(255), @SDT nchar(11), @GioiTinh nvarchar(3), @NgaySinh date
AS
BEGIN
	BEGIN TRY
		UPDATE KhachHang SET TenKH = @TenKhachHang, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh
		WHERE SDT = @SDT;
	END TRY
	BEGIN CATCH
		DECLARE @error NVARCHAR(MAX)
		SELECT @error = N'Error: ' + ERROR_MESSAGE()
		RAISERROR(@error, 16, 1)
	END CATCH
END;
go
CREATE PROCEDURE proc_DeleteCustomer
@SDT NCHAR(11)
AS
BEGIN
	SET NOCOUNT ON;

    BEGIN TRANSACTION;
    BEGIN TRY
		DECLARE @MaHoaDon int
		SELECT @MaHoaDon = MaHD FROM HoaDon WHERE SDT = @SDT
		DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHoaDon;
        DELETE FROM HoaDon WHERE SDT = @SDT;
        DELETE FROM KhachHang WHERE SDT = @SDT;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX);
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE();
        RAISERROR(@err, 16, 1);
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO