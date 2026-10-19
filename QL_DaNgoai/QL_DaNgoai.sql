IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QL_DaNgoai')
BEGIN
    CREATE DATABASE QL_DaNgoai COLLATE Vietnamese_CI_AS;
END
GO

USE QL_DaNgoai;
GO

IF OBJECT_ID('ChuyenDi', 'U') IS NOT NULL
    DROP TABLE ChuyenDi;
GO

CREATE TABLE ChuyenDi (
    MaChuyen INT IDENTITY(1,1) PRIMARY KEY,
    TenChuyen NVARCHAR(100) NOT NULL,
    DiaDiem NVARCHAR(100) NOT NULL,
    NgayDi DATE NOT NULL,
    SoNguoi INT NOT NULL,
    NganSach DECIMAL(18,0) NOT NULL,
    PhuongTien NVARCHAR(30) NOT NULL,
    DaHoanThanh BIT NOT NULL DEFAULT 0,
    GhiChu NVARCHAR(200) NULL
);
GO

-- Chèn sẵn 8 chuyến đi với ngày đi trải từ vài ngày đến vài tuần tới
INSERT INTO ChuyenDi (TenChuyen, DiaDiem, NgayDi, SoNguoi, NganSach, PhuongTien, DaHoanThanh, GhiChu) VALUES
(N'Cắm trại đồi chè', N'Đà Lạt', '2026-10-25', 6, 3500000, N'Ô tô', 0, N'Chuẩn bị lều bạt và áo ấm'),
(N'Khám phá nóc nhà Đông Dương', N'Sa Pa', '2026-10-28', 4, 5000000, N'Tàu hỏa', 0, N'Chinh phục đỉnh Fansipan'),
(N'Nghỉ dưỡng cuối tuần', N'Vũng Tàu', '2026-10-24', 5, 2500000, N'Xe máy', 0, N'Tắm biển và ăn hải sản'),
(N'Phố cổ về đêm', N'Hội An', '2026-11-02', 4, 4000000, N'Xe khách', 0, N'Thả hoa đăng sông Hoài'),
(N'Lặn ngắm san hô', N'Nha Trang', '2026-11-05', 8, 6000000, N'Ô tô', 0, N'Tham quan các đảo'),
(N'Check-in hoa tam giác mạch', N'Hà Giang', '2026-11-10', 4, 4500000, N'Xe máy', 0, N'Chạy xe máy ngắm cảnh Mã Pí Lèng'),
(N'Chèo thuyền Tràng An', N'Ninh Bình', '2026-10-30', 6, 3000000, N'Ô tô', 0, N'Chụp ảnh tại Hang Múa'),
(N'Hoàng hôn Sunset Sanato', N'Phú Quốc', '2026-11-15', 2, 7000000, N'Xe khách', 1, N'Chuyến đi đã hoàn thành');
GO