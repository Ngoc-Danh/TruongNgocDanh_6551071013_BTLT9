IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QL_TraSua')
BEGIN
    CREATE DATABASE QL_TraSua COLLATE Vietnamese_CI_AS;
END
GO

USE QL_TraSua;
GO

IF OBJECT_ID('ChiTietHoaDon', 'U') IS NOT NULL
    DROP TABLE ChiTietHoaDon;
GO

IF OBJECT_ID('HoaDon', 'U') IS NOT NULL
    DROP TABLE HoaDon;
GO

IF OBJECT_ID('MonUong', 'U') IS NOT NULL
    DROP TABLE MonUong;
GO

IF OBJECT_ID('DanhMucMon', 'U') IS NOT NULL
    DROP TABLE DanhMucMon;
GO

CREATE TABLE DanhMucMon (
    MaDM INT IDENTITY(1,1) PRIMARY KEY,
    TenDM NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE MonUong (
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    GiaBan DECIMAL(18,0) NOT NULL,
    DangBan BIT NOT NULL DEFAULT 1,
    MaDM INT NOT NULL FOREIGN KEY REFERENCES DanhMucMon(MaDM)
);
GO

CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME NOT NULL,
    TongTien DECIMAL(18,0) NOT NULL,
    HinhThucTT NVARCHAR(20) NOT NULL, -- N'Tiền mặt' / N'Chuyển khoản'
    DaThanhToan BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE ChiTietHoaDon (
    MaHD INT NOT NULL FOREIGN KEY REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    MaMon INT NOT NULL FOREIGN KEY REFERENCES MonUong(MaMon),
    SoLy INT NOT NULL,
    DonGia DECIMAL(18,0) NOT NULL,
    PRIMARY KEY (MaHD, MaMon)
);
GO

-- 1. Chèn sẵn 4 danh mục
INSERT INTO DanhMucMon (TenDM) VALUES
(N'Trà sữa'),
(N'Trà trái cây'),
(N'Topping'),
(N'Đồ ăn vặt');
GO

-- 2. Chèn sẵn ít nhất 12 món uống / món ăn
INSERT INTO MonUong (TenMon, GiaBan, DangBan, MaDM) VALUES
-- Trà sữa (MaDM = 1)
(N'Trà sữa trân châu', 35000, 1, 1),
(N'Trà sữa matcha', 40000, 1, 1),
(N'Hồng trà sữa', 32000, 1, 1),
(N'Trà sữa khoai môn', 38000, 1, 1),
(N'Trà sữa ô long nướng', 42000, 1, 1),

-- Trà trái cây (MaDM = 2)
(N'Trà đào cam sả', 35000, 1, 2),
(N'Trà vải hoa hồng', 38000, 1, 2),
(N'Trà xoài macchiato', 40000, 1, 2),
(N'Trà dâu tây', 36000, 1, 2),

-- Topping (MaDM = 3)
(N'Trân châu đen', 5000, 1, 3),
(N'Trân châu trắng', 5000, 1, 3),
(N'Thạch phô mai', 8000, 1, 3),
(N'Pudding trứng', 7000, 1, 3),

-- Đồ ăn vặt (MaDM = 4)
(N'Bánh tráng trộn', 20000, 1, 4),
(N'Khoai tây lắc phô mai', 25000, 1, 4),
(N'Cá viên chiên', 25000, 1, 4);
GO

-- 3. Hóa đơn mẫu
INSERT INTO HoaDon (NgayLap, TongTien, HinhThucTT, DaThanhToan) VALUES
('2026-10-19 09:30:00', 120000, N'Chuyển khoản', 1),
('2026-10-19 10:15:00', 70000, N'Tiền mặt', 1);
GO

-- 4. Chi tiết hóa đơn mẫu
INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLy, DonGia) VALUES
(1, 1, 2, 35000), -- 2 Trà sữa trân châu = 70,000
(1, 2, 1, 40000), -- 1 Trà sữa matcha = 40,000
(1, 11, 2, 5000),  -- 2 Trân châu trắng = 10,000 -> Tổng: 120,000
(2, 6, 2, 35000);  -- 2 Trà đào cam sả = 70,000
GO