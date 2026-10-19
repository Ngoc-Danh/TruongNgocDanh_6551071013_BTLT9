IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QL_NhaTro')
BEGIN
    CREATE DATABASE QL_NhaTro COLLATE Vietnamese_CI_AS;
END
GO

USE QL_NhaTro;
GO

IF OBJECT_ID('KhachThue', 'U') IS NOT NULL
    DROP TABLE KhachThue;
GO

IF OBJECT_ID('PhongTro', 'U') IS NOT NULL
    DROP TABLE PhongTro;
GO

CREATE TABLE PhongTro (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(20) NOT NULL,
    GiaThue DECIMAL(18,0) NOT NULL,
    TinhTrang NVARCHAR(20) NOT NULL DEFAULT N'Trống' -- 'Trống' / 'Đang thuê'
);
GO

CREATE TABLE KhachThue (
    MaKhach INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(5) NOT NULL,
    NgaySinh DATE NOT NULL,
    SoDienThoai VARCHAR(15) NOT NULL,
    MaTinh INT NOT NULL,
    TenTinh NVARCHAR(100) NOT NULL,
    MaPhuongXa INT NOT NULL,
    TenPhuongXa NVARCHAR(100) NOT NULL,
    DaDangKyTamTru BIT NOT NULL DEFAULT 0,
    MaPhong INT NOT NULL FOREIGN KEY REFERENCES PhongTro(MaPhong)
);
GO

-- Chèn sẵn 6 phòng trọ
INSERT INTO PhongTro (TenPhong, GiaThue, TinhTrang) VALUES
(N'P01', 1500000, N'Đang thuê'),
(N'P02', 1600000, N'Đang thuê'),
(N'P03', 1800000, N'Đang thuê'),
(N'P04', 2000000, N'Đang thuê'),
(N'P05', 1700000, N'Đang thuê'),
(N'P06', 1900000, N'Trống');
GO

-- Chèn một số khách thuê mẫu
INSERT INTO KhachThue (HoTen, GioiTinh, NgaySinh, SoDienThoai, MaTinh, TenTinh, MaPhuongXa, TenPhuongXa, DaDangKyTamTru, MaPhong) VALUES
(N'Trần Thị Bình', N'Nữ', '2002-05-10', '0876543210', 36, N'Nam Định', 13783, N'Phường Trần Hưng Đạo', 0, 1),
(N'Lê Văn Cường', N'Nam', '2001-08-20', '0901234567', 38, N'Thanh Hóa', 14590, N'Phường Ba Đình', 0, 2),
(N'Nguyễn Văn An', N'Nam', '2004-05-12', '0912345678', 1, N'Thành phố Hà Nội', 40, N'Phường Ba Đình', 1, 3),
(N'Phạm Minh Đức', N'Nam', '2003-11-15', '0987654321', 38, N'Thanh Hóa', 14614, N'Phường Điện Biên', 1, 4),
(N'Hoàng Thị Dung', N'Nữ', '2000-03-25', '0765432109', 27, N'Bắc Ninh', 9781, N'Phường Suối Hoa', 0, 5);
GO