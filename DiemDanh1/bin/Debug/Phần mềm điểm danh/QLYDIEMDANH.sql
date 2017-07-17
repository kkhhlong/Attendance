CREATE DATABASE QLYDIEMDANH
GO	
USE QLYDIEMDANH
GO


--Lop
--BuoiGocCuaLop
--SinhVien
--ĐiemDanh



 CREATE TABLE Lop
 (
 MaLop NVARCHAR(30) PRIMARY KEY,
 TenLop	NVARCHAR(100) NOT NULL 
 )
 GO
 
  CREATE TABLE BuoiHocCuaLop
 (
 
 id INT IDENTITY PRIMARY KEY,
 idLop NVARCHAR(30)  NOT NULL,
 BuoiHoc	DATETIME  NOT NULL
 FOREIGN KEY(idLop) REFERENCES lop(MaLop)
 ON DELETE CASCADE
 ON UPDATE CASCADE
 
 

 )
 GO	
 
 CREATE TABLE SinhVien
 (
 idLop NVARCHAR(30) NOT NULL,
 Mssv	VARCHAR(20) PRIMARY KEY,
 HoTen	NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tên',
 maLop  nvarchar(30) NOT NULL
 FOREIGN KEY (idLop) REFERENCES Lop(MaLop)
  ON DELETE CASCADE
 ON UPDATE CASCADE
 )
 GO

 CREATE TABLE DiemDanh
 (
 id int IDENTITY  PRIMARY KEY,
 NgayHoc DATE   ,
 Mssv	VARCHAR(20) NOT NULL,
 DiHoc	INT	NOT NULL DEFAULT 0  --0:Vắng && 1:Đi học && 2: Có Phép
 
 FOREIGN KEY(Mssv) REFERENCES dbo.SinhVien(Mssv)
 ON DELETE CASCADE
 ON UPDATE CASCADE
 
 )
 GO

 

 CREATE PROC USP_LayTenLop 
 @MaLop nvarchar(30) 
 AS
 BEGIN
	SELECT TenLop FROM dbo.Lop WHERE MaLop = @MaLop
 END
 GO 
 
 CREATE PROC USP_LayBuoiHocTheoLop
 @maLop nvarchar(30)
 AS
 BEGIN
		SELECT BuoiHoc FROM dbo.BuoiHocCuaLop WHERE idLop = @maLop
 END
 GO

 
 CREATE PROC USP_ThongTinSinhVienMotLop
 @maLop nvarchar(30)
 AS
 BEGIN
	SELECT Mssv AS 'MSSV',HoTen AS 'Họ và tên',maLop AS 'Mã Lớp' FROM dbo.SinhVien  WHERE  idLop = @maLop
 END
 GO
 
 CREATE PROC USP_SoBuoiHocCuaLop
 @maLop nvarchar(30)
 AS
 BEGIN
	SELECT COUNT(*) FROM dbo.BuoiHocCuaLop  WHERE  idLop = @maLop
 END
 GO

 CREATE PROC USP_ThongTinSinhVien
 @mssv nvarchar(30)
 AS
 BEGIN
	SELECT Mssv,HoTen,maLop FROM dbo.SinhVien  WHERE  Mssv = @mssv
 END
 GO


 CREATE PROC USP_MSSVCuMotLop
 @maLop nvarchar(30)
 AS
 BEGIN
	SELECT Mssv FROM dbo.SinhVien  WHERE  idLop = @maLop
 END
 GO
 

 
 
 CREATE PROC USP_LayIdDiemDanh
 @mssv nvarchar(20),@ngayHoc DATE
 AS
 BEGIN
	SELECT id FROM dbo.DiemDanh WHERE Mssv = @mssv AND NgayHoc = @ngayHoc
 END
 GO

 
 
 
 CREATE PROC USP_DanhSachDiemDanh
 @ngayHoc DATE,@mssv NVARCHAR(20)
 AS
 BEGIN
  SELECT DiHoc FROM dbo.DiemDanh WHERE NgayHoc = @ngayHoc  AND Mssv = @mssv
 END
 GO
 
 
 

  CREATE PROC USP_HienThiSinhVien
  AS
  BEGIN
	  SELECT Lop.MaLop AS 'Mã Lớp Học',TenLop AS 'Tên Lớp học',SinhVien.Mssv AS'MSSV', dbo.SinhVien.HoTen AS'Họ Tên', SinhVien.maLop AS 'Thuộc Lớp',
	SUM(CASE WHEN DiHoc = 1 THEN 1 ELSE 0 end) AS 'Đi học',SUM(CASE WHEN DiHoc = 0 THEN 1 ELSE 0 end) AS 'Vắng',SUM(CASE WHEN DiHoc = 2 THEN 1 ELSE 0 end) AS 'Vắng Phép' 
	FROM dbo.SinhVien JOIN dbo.DiemDanh ON DiemDanh.Mssv = SinhVien.Mssv JOIN lop ON Lop.MaLop = SinhVien.idLop
	GROUP BY dbo.SinhVien.Mssv,Lop.MaLop,TenLop,HoTen,SinhVien.maLop
  END
  GO
  EXEC dbo.USP_HienThiSinhVien
  
  
 
  
  
  

 
  


 
  