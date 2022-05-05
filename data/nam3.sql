CREATE DATABASE nam3
GO

USE nam3
GO

-------------KhachHang-------------
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
-------------NhanVien-------------
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
-------------TaiKhoan-------------
CREATE TABLE [dbo].[TaiKhoan] (
    [UserName]   NVARCHAR (MAX) NULL,
    [Pass]       NVARCHAR (MAX) NULL,
    [LoaiTK]     NVARCHAR (MAX) NULL,
    [idNhanVien] NVARCHAR (50) NULL,
	FOREIGN KEY ([idNhanVien]) REFERENCES dbo.NhanVien([idNhanVien])
);
GO
------------- TheLoai -------------
CREATE TABLE [dbo].[TheLoai] (
    [IDTheLoai]  NVARCHAR (50)  NOT NULL,
    [TenTheLoai] NVARCHAR (MAX) NULL,
    [MoTa]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED ([IDTheLoai] ASC)
);
GO

------------- [Phim] --------------------
CREATE TABLE [dbo].[Phim] (
    [IDPhim]        NVARCHAR (50) NOT NULL,
    [TenPhim]       NVARCHAR (50) NULL,
    [ThoiLuong]     FLOAT (53)    NULL,
    [NgayKhoiChieu] DATE          NULL,
    [NgayKetThuc]   DATE          NULL,
    [SanXuat]       NVARCHAR (50) NULL,
    [DaoDien]       NVARCHAR (50) NULL,
    [NamSX]         INT           NULL,
    [IDTheLoai]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED ([IDPhim] ASC),
    CONSTRAINT [FK_Phim_TheLoai1] FOREIGN KEY ([IDTheLoai]) REFERENCES [dbo].[TheLoai] ([IDTheLoai])
);


GO

------------- [LoaiManHinh] -----------------
CREATE TABLE [dbo].[LoaiManHinh] (
    [IDLoaiManHinh] NVARCHAR (50)  NOT NULL,
    [TenManHinh]    NVARCHAR (MAX) NULL,
	CONSTRAINT [PK_LoaiManHinh] PRIMARY KEY ([IDLoaiManHinh])
);

------------- [DinhDangPhim] -----------------
CREATE TABLE [dbo].[DinhDangPhim] (
    [IDDinhDangPhim] NVARCHAR (50) NOT NULL,
    [IDPhim]         NVARCHAR (50) NOT NULL,
    [IDLoaiManHinh]  NVARCHAR (50) NOT NULL,
	CONSTRAINT [PK_DinhDangPhim] PRIMARY KEY ([IDDinhDangPhim]),
	FOREIGN KEY ([IDPhim]) REFERENCES dbo.Phim([IDPhim]),
	FOREIGN KEY ([IDLoaiManHinh]) REFERENCES dbo.LoaiManHinh([IDLoaiManHinh])
);


GO
------------- [PhongChieu] -----------------
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
GO
------------- [LichChieu] -----------------
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
------------- Ve -----------------
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
-----Stored Procedures
-------------------- Phim ------------------
-- Get Phim
CREATE PROC USP_GetMovie
AS
BEGIN
	SELECT IDPhim AS [Mã phim], TenPhim AS [Tên phim], ThoiLuong AS [Thời lượng], NgayKhoiChieu AS [Ngày khởi chiếu], NgayKetThuc AS [Ngày kết thúc], SanXuat AS [Sản xuất], DaoDien AS [Đạo diễn], NamSX AS [Năm SX] , IDTheLoai AS [TheLoai]
	FROM dbo.Phim
END

GO

-- thêm phim
alter PROC USP_InsertMovie
@idPhim nvarchar(50), @tenPhim nvarchar(50), @thoiLuong FLOAT, @ngayKhoiChieu DATE, @ngayKetThuc DATE, @sanXuat NVARCHAR(50), @daoDien nvarchar(50), @namSX INT , @idTheLoai nvarchar(50)
AS
BEGIN
	INSERT dbo.Phim (IDPhim , TenPhim , ThoiLuong , NgayKhoiChieu , NgayKetThuc , SanXuat , DaoDien , NamSX , IDTheLoai)
	VALUES (@idPhim , @tenPhim  , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX , @idTheLoai)
END
GO

-- sữa phim 
alter PROC USP_UpdateMovie
@id NVARCHAR(50), @tenPhim NVARCHAR(50), @thoiLuong FLOAT, @ngayKhoiChieu DATE, @ngayKetThuc DATE, @sanXuat NVARCHAR(50), @daodien NVARCHAR(50), @namSX INT , @idTheloai  NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Phim SET TenPhim = @tenPhim, ThoiLuong = @thoiLuong, NgayKhoiChieu = @ngayKhoiChieu, NgayKetThuc = @ngayKetThuc, SanXuat = @sanXuat,DaoDien=@daodien , NamSX = @namSX, IDTheLoai=@idTheloai WHERE IDPhim = @id
END
GO
-------------------- TheLoai ------------------
-- thêm the Loai
create PROC USP_InsertTheLoai
@idTheLoai nvarchar(50), @tenTheLoai nvarchar(50)
AS
BEGIN
	INSERT dbo.TheLoai(IDTheLoai , TenTheLoai)
	VALUES (@idTheLoai , @tenTheLoai  )
END
GO

-- sữa the loai 
alter PROC UpdateTheloai
@idtheloai NVARCHAR(50), @tentheloai NVARCHAR(50) 
AS
BEGIN
	UPDATE dbo.TheLoai SET TenTheLoai = @tentheloai  WHERE IDTheLoai = @idtheloai
END
GO
-------------------- DinhDangPhim ------------------
alter proc UpdateDinhDangPhim
@idLoaiManHinh nvarchar(50) , @idPhim nvarchar(50), @idDinhDang nvarchar(50)
as
begin 
	update dbo.DinhDangPhim set IDLoaiManHinh = @idLoaiManHinh , IDPhim=@idPhim where IDDinhDangPhim = @idDinhDang
end
go
-------------------- ADD------------------
-- Add Thể Loại
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai]) VALUES (N'TL01', N'Hành Động')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai]) VALUES (N'TL02', N'Hoạt Hình')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai]) VALUES (N'TL03', N'Hài')
INSERT [dbo].[TheLoai] ([IDTheLoai], [TenTheLoai]) VALUES (N'TL04', N'Viễn Tưởng')

-- Add Phim
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX] ,[IDTheLoai]) VALUES (N'P01', N'Avengers: Cuộc Chiến Vô Cực',  150, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Mỹ', N'Anthony Russo,  Joe Russo', 2018 , N'TL01')
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX] , [IDTheLoai]) VALUES (N'P02', N'Lật Mặt: 3 Chàng Khuyết',  100, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Việt Nam', N'Lý Hải', 2018 , N'TL02')
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX] , [IDTheLoai]) VALUES (N'P03', N'100 Ngày Bên Em',  100, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Việt Nam', N'Vũ Ngọc Phượng', 2018 , N'TL03')
INSERT into [Phim] ([IDPhim], [TenPhim],  [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX] , [IDTheLoai]) VALUES (N'P04', N'Ngỗng Vịt Phiêu Lưu Ký', 91, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Mỹ', N'Christopher Jenkins', 2018, N'TL04')
-- Add Loại màn hình
INSERT [dbo].[LoaiManHinh] ([IDLoaiManHinh], [TenManHinh]) VALUES (N'MH01', N'2D')
INSERT [dbo].[LoaiManHinh] ([IDLoaiManHinh], [TenManHinh]) VALUES (N'MH02', N'3D')
INSERT [dbo].[LoaiManHinh] ([IDLoaiManHinh], [TenManHinh]) VALUES (N'MH03', N'IMAX')
INSERT [dbo].[LoaiManHinh] ([IDLoaiManHinh], [TenManHinh]) VALUES (N'MH04', N'4D')
-- Add Định dạng phim
INSERT [dbo].[DinhDangPhim] ([IDDinhDangPhim], [IDPhim], [IDLoaiManHinh]) VALUES (N'DD01', N'P01', N'MH01')
INSERT [dbo].[DinhDangPhim] ([IDDinhDangPhim], [IDPhim], [IDLoaiManHinh]) VALUES (N'DD02', N'P01', N'MH03')
INSERT [dbo].[DinhDangPhim] ([IDDinhDangPhim], [IDPhim], [IDLoaiManHinh]) VALUES (N'DD03', N'P02', N'MH01')
INSERT [dbo].[DinhDangPhim] ([IDDinhDangPhim], [IDPhim], [IDLoaiManHinh]) VALUES (N'DD04', N'P03', N'MH02')
