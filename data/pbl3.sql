CREATE DATABASE pbl3
GO

USE pbl3
GO

-----KhachHang--------
CREATE TABLE [dbo].[KhachHang] (
    [idKhachHang] NVARCHAR (50)  NOT NULL,
    [HoTenKH]     NVARCHAR (MAX) NOT NULL,
    [NgaySinhKH]  NVARCHAR (MAX) NOT NULL,
    [DiaChiKH]    NVARCHAR (MAX) NULL,
    [SDTKH]       NVARCHAR (MAX) NULL,
    [CMNDKH]      NVARCHAR (MAX) NOT NULL,
    [DiemTichLuy] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED ([idKhachHang] ASC)
);
GO
-----NhanVien------
CREATE TABLE [dbo].[NhanVien] (
    [idNhanVien] NVARCHAR (50)  NOT NULL,
    [TenNV]      NVARCHAR (MAX) NOT NULL,
    [NgaySinhNV] DATE           NOT NULL,
    [DiaChiNV]   NVARCHAR (MAX) NULL,
    [SDTNV]      NVARCHAR (MAX) NULL,
    [CMNDNV]     INT            NOT NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED ([idNhanVien] ASC)
);
GO
----TaiKhoan----
CREATE TABLE [dbo].[TaiKhoan] (
    [UserName]   NVARCHAR (MAX) NULL,
    [Pass]       NVARCHAR (MAX) NULL,
    [LoaiTK]     NVARCHAR (MAX) NULL,
    [idNhanVien] NVARCHAR (50) NULL,
	FOREIGN KEY ([idNhanVien]) REFERENCES dbo.NhanVien([idNhanVien])
);
GO
---- TheLoai --------
CREATE TABLE [dbo].[TheLoai] (
    [IDTheLoai]  NVARCHAR (50)  NOT NULL,
    [TenTheLoai] NVARCHAR (MAX) NULL,
    [MoTa]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED ([IDTheLoai] ASC)
);
GO

---------- Phim --------------------
CREATE TABLE [dbo].[Phim] (
    [IDPhim]        NVARCHAR (50)  NOT NULL,
    [TenPhim]       NVARCHAR (MAX) NULL,
    [ThoiLuong]     FLOAT (53)     NULL,
    [NgayKhoiChieu] DATETIME       NULL,
    [NgayKetThuc]   DATETIME       NULL,
    [SanXuat]       NVARCHAR (50)  NULL,
    [DaoDien]       NVARCHAR (50)  NULL,
    [NamSX]         DATE           NULL,
	CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED ([IDPhim] ASC)
	

);
GO
-------- PhanLoaiPhim --------
CREATE TABLE [dbo].[PhanLoaiPhim] (
    [IDPhanLoaiPhim] NVARCHAR (50)  NOT NULL,
    [IDTheLoai]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_PhanLoaiPhim] PRIMARY KEY CLUSTERED ([IDPhanLoaiPhim] ASC),
	FOREIGN KEY ([IDPhanLoaiPhim]) REFERENCES dbo.Phim([IDPhim]),
	FOREIGN KEY (idTheLoai) REFERENCES dbo.TheLoai([IDTheLoai]),
);
GO

CREATE TABLE [dbo].[LoaiManHinh] (
    [IDLoaiManHinh] NVARCHAR (50)  NOT NULL,
    [TenManHinh]    NVARCHAR (MAX) NULL,
	CONSTRAINT [PK_LoaiManHinh] PRIMARY KEY ([IDLoaiManHinh])
);
CREATE TABLE [dbo].[DinhDangPhim] (
    [IDDinhDangPhim] NVARCHAR (50) NOT NULL,
    [IDPhim]         NVARCHAR (50) NOT NULL,
    [IDLoaiManHinh]  NVARCHAR (50) NOT NULL,
	CONSTRAINT [PK_DinhDangPhim] PRIMARY KEY ([IDDinhDangPhim]),
	FOREIGN KEY ([IDPhim]) REFERENCES dbo.Phim([IDPhim]),
	FOREIGN KEY ([IDLoaiManHinh]) REFERENCES dbo.LoaiManHinh([IDLoaiManHinh])
);


GO
GO
CREATE TABLE [dbo].[PhongChieu] (
    [IDPhongChieu] NVARCHAR (50)  NOT NULL,
    [TenPhong]     NVARCHAR (MAX) NULL,
    [IDManHinh]    NVARCHAR (50)  NOT NULL,
    [SoChoNgoi]    INT            NULL,
    [TinhTrang]    NVARCHAR (50)  NULL,
    [SoHangGhe]    INT            NULL,
    [SoGheMotHang] INT            NULL,
	CONSTRAINT [PK_PhongChieu] PRIMARY KEY ([IDPhongChieu]),
	FOREIGN KEY ([IDManHinh]) REFERENCES dbo.LoaiManHinh([IDLoaiManHinh])
);
CREATE TABLE [dbo].[LichChieu] (
    [IDLichChieu]   NVARCHAR (50) NOT NULL,
    [ThoiGianChieu] DATETIME      NULL,
    [IDPhong]       NVARCHAR (50) NOT NULL,
    [IDDinhDang]    NVARCHAR (50) NOT NULL,
    [GiaVe]         NVARCHAR (50) NULL,
    [TrangThai]     NVARCHAR (20) NULL,
	CONSTRAINT [PK_LichChieu] PRIMARY KEY ([IDLichChieu]),
	FOREIGN KEY ([IDPhong]) REFERENCES dbo.PhongChieu([IDPhongChieu]),
	FOREIGN KEY ([IDDinhDang]) REFERENCES dbo.DinhDangPhim([IDDinhDangPhim]),
);
--------- Ve -----------------
CREATE TABLE [dbo].[Ve] (
    [IDVe]        NVARCHAR (50)  NOT NULL ,
    [LoaiVe]      NVARCHAR (MAX) NULL,
    [IDLichChieu] NVARCHAR (50)  NULL,
    [MaGheNgoi]   NVARCHAR (50)  NULL,
    [IDKhachHang] NVARCHAR (50)  NULL,
    [TrangThai]   NVARCHAR (50)  NULL,
    [TienBanVe]   FLOAT (53)     NULL,
    CONSTRAINT [PK_Ve] PRIMARY KEY CLUSTERED ([IDVe] ASC),
	FOREIGN KEY (idLichChieu) REFERENCES dbo.LichChieu([IDLichChieu]),
	FOREIGN KEY ([IDKhachHang]) REFERENCES dbo.KhachHang([idKhachHang])
);

GO
--PHIM
CREATE PROC USP_GetMovie
AS
BEGIN
	SELECT IDPhim AS [Mã phim], TenPhim AS [Tên phim], ThoiLuong AS [Thời lượng], NgayKhoiChieu AS [Ngày khởi chiếu], NgayKetThuc AS [Ngày kết thúc], SanXuat AS [Sản xuất], DaoDien AS [Đạo diễn], NamSX AS [Năm SX]
	FROM dbo.Phim
END
GO

-- thêm phim
CREATE PROC USP_InsertMovie
@id VARCHAR(50), @tenPhim NVARCHAR(100), @moTa NVARCHAR(1000), @thoiLuong FLOAT, @ngayKhoiChieu DATE, @ngayKetThuc DATE, @sanXuat NVARCHAR(50), @daoDien NVARCHAR(100), @namSX INT, @apPhich IMAGE
AS
BEGIN
	INSERT dbo.Phim (IDPhim , TenPhim , ThoiLuong , NgayKhoiChieu , NgayKetThuc , SanXuat , DaoDien , NamSX)
	VALUES (@id , @tenPhim  , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX)
END
GO

-- sữa phim CREATE PROC
alter proc USP_UpdateMovie
@id VARCHAR(50), @tenPhim nvarchar(50), @moTa nvarchar(50), @thoiLuong nvarchar(50), @ngayKhoiChieu DATE, @ngayKetThuc DATE, @sanXuat NVARCHAR(50), @daoDien nvarchar(50), @namSX int
AS
BEGIN
	UPDATE dbo.Phim SET TenPhim = @tenPhim, ThoiLuong = @thoiLuong, NgayKhoiChieu = @ngayKhoiChieu, NgayKetThuc = @ngayKetThuc, SanXuat = @sanXuat, DaoDien = @daoDien, NamSX = @namSX  WHERE IDPhim = @id
END
GO

INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL01', N'Hành Động', NULL)
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL02', N'Hoạt Hình', NULL)
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL03', N'Hài', NULL)
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL04', N'Viễn Tưởng', NULL)
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL05', N'Phiêu lưu', NULL)
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL06', N'Gia đình', NULL)
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL07', N'Tình Cảm', NULL)
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai], [MoTa]) VALUES (N'TL08', N'Tâm Lý', NULL)


INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX]) VALUES (N'P01', N'Avengers: Cuộc Chiến Vô Cực',  150, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Mỹ', N'Anthony Russo,  Joe Russo', 2018)
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX]) VALUES (N'P02', N'Lật Mặt: 3 Chàng Khuyết',  100, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Việt Nam', N'Lý Hải', 2018)
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX]) VALUES (N'P03', N'100 Ngày Bên Em',  100, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Việt Nam', N'Vũ Ngọc Phượng', 2018)
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX]) VALUES (N'P04', N'Ngỗng Vịt Phiêu Lưu Ký', 91, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Mỹ', N'Christopher Jenkins', 2018)