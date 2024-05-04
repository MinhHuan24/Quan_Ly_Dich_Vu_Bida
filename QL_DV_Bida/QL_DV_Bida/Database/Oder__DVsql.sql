create database Oder_DV

use Oder_DV

create table Table_Nuoc
(
	Nuoc nvarchar(20)
)
create table Table_MonAn
(
	MonAn nvarchar(30)
)
create table Table_DichVuKhac
(
	DichVuKhac nvarchar(50)
)
create table PhieuDV
(
	MaPhieuDV int IDENTITY(1,1) PRIMARY KEY,
	DichVu nvarchar(20),
	SoLuong int
)
INSERT INTO Table_Nuoc (Nuoc)
VALUES 
    ('Sting'),
    ('Cocacola'),
	('Redbull'),
	('Nước lọc'),
	('Cafe sữa'),
    ('Nước cam');
INSERT INTO Table_MonAn (MonAn)
VALUES 
    ('Bún bò'),
    ('Pho'),
	('Bún riu'),
	('Hu tíu mì'),
	('Cơm gà'),
    ('Cơm bò');
INSERT INTO Table_DichVuKhac (DichVuKhac)
VALUES 
    ('Khăn lạnh');

