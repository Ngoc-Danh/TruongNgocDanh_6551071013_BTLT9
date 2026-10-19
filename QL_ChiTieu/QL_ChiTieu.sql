IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QL_ChiTieu')
BEGIN
    CREATE DATABASE QL_ChiTieu COLLATE Vietnamese_CI_AS;
END
GO

USE QL_ChiTieu;
GO

IF OBJECT_ID('ChiTieu', 'U') IS NOT NULL
    DROP TABLE ChiTieu;
GO

CREATE TABLE ChiTieu (
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    NgayChi DATE NOT NULL,
    NoiDung NVARCHAR(100) NOT NULL,
    LoaiChi NVARCHAR(30) NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL,
    GhiChu NVARCHAR(200) NULL
);
GO

-- Chèn ít nhất 10 dòng dữ liệu mẫu
INSERT INTO ChiTieu (NgayChi, NoiDung, LoaiChi, SoTien, GhiChu) VALUES
('2026-10-01', N'Cơm trưa', N'Ăn uống', 35000, N'Cơm văn phòng'),
('2026-10-02', N'Xăng xe', N'Đi lại', 60000, N'Đổ xăng xe máy'),
('2026-10-03', N'Photo giáo trình', N'Học tập', 25000, N'Tài liệu môn LTTQ'),
('2026-10-04', N'Xem phim', N'Giải trí', 90000, N'Vé xem phim cuối tuần'),
('2026-10-05', N'Trà sữa', N'Ăn uống', 40000, N'Trà sữa trân châu đường đen'),
('2026-10-06', N'Mua sắm', N'Khác', 150000, N'Đồ dùng cá nhân'),
('2026-10-07', N'Tiền điện', N'Khác', 500000, N'Thanh toán tiền điện tháng trước'),
('2026-10-08', N'Ăn sáng', N'Ăn uống', 25000, N'Bánh mì chả'),
('2026-10-10', N'Mua sách tham khảo', N'Học tập', 120000, N'Sách C# nâng cao'),
('2026-10-12', N'Vé xe buýt tháng', N'Đi lại', 100000, N'Vé xe buýt liên tuyến'),
('2026-10-15', N'Cà phê với bạn', N'Ăn uống', 45000, N'Gặp bạn đại học'),
('2026-10-18', N'Chơi bowling', N'Giải trí', 85000, N'Đi chơi cùng nhóm bạn');
GO