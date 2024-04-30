CREATE TABLE [dbo].[NhanVien] (
    [MaNV]          VARCHAR (10)   NOT NULL,
    [HoTen]         NVARCHAR (30)  NOT NULL,
    [GioiTinh]      NVARCHAR (3)   NULL,
    [NgaySinh]      DATE           NULL,
    [DiaChi]        NVARCHAR (255) NULL,
    [SDT]           NCHAR (11)     NOT NULL,
    [NgayTuyenDung] DATE           NULL,
    [MaCV]          NCHAR (10)     NULL,
    [TrangThaiLamViec] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED ([MaNV] ASC),
    CONSTRAINT [FK_NhanVien_CV] FOREIGN KEY ([MaCV]) REFERENCES [dbo].[CongViec] ([MaCV]),
    CHECK (datediff(year,[NgaySinh],getdate())>=(18)),
    CHECK (len([SDT])=(10)),
    CHECK (datediff(day,[NgayTuyenDung],getdate())>=(0))
);


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