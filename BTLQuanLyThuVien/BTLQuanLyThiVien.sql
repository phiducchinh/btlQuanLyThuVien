/*
CREATE DATABASE BTLQuanLyThuVien
GO

USE BTLQuanLyThuVien
GO

CREATE Table PhanLoai(
	MaLoai varchar(10) primary key,
	TenLoai nvarchar(50) not null
)
GO

Create Table NhanVien(
	MaNhanVien varchar(30) primary key,
	HoTen nvarchar(100) not null,
	DiaChi nvarchar(200),
	QuyenHan varchar(10)
)
Go

Create Table Account(
	UserName varchar(200) primary key,
	PassWord varchar(200) not null,
	MaNhanVien varchar(30),
	QuyenHan int default 0,--0: nhân viên, 1 là thủ thư
	foreign key (MaNhanVien) references dbo.NhanVien(MaNhanVien)
	
)
GO

Create Table DocGia(
	MaDG varchar(100) primary key,
	HoTen nvarchar(100) not null,
	MaSV int not null,
	NgaySinh date null default getdate(),
	TenKhoa nvarchar(100),
	DiaChi nvarchar(200) null,
	NgayLapThe date default getdate(),

)
GO

Create Table PhieuMuon(
	MaPhieuMuon varchar(300) primary key,
	MaDG varchar(100) not null,
	NgayMuon date not null default GETDATE(),
	NgayTra date null,
	MaNhanVien varchar(30) not null,
	TrangThaiTong int--đã trả =1 , chưa trả =0--
	MaSach varchar(200),
	SoLuong int ,
	foreign key (MaSach) references dbo.Sach(MaSach),
	foreign key (MaNhanVien) references dbo.NhanVien(MaNhanVien),
	foreign key (MaDG) references dbo.DocGia(MaDG)

)
GO



Create Table Sach(
	MaSach varchar(200) primary key,
	NhanDe nvarchar(200) not null,
	TacGia nvarchar(200) not null,
	SoTrang int not null,
	SoLuongTong int not null,
	SoLuongCon int not null,
	NamSX int,
	LanXB int,
	NhaXuatBan nvarchar(200),
	SoLanMuon int,
	MaLoai varChar(10),
	NgayNhap date default getdate()
	foreign key (MaLoai) references dbo.PhanLoai(MaLoai),


)
Go




--Nhân viên--
Insert into NhanVien values('NV01',N'Trần Văn Đức',N'Hà Nội')
Insert into NhanVien values('NV02',N'Nguyễn Thị Lan',N'Hà Nội')
Insert into NhanVien values('NV03',N'Trần Đức Anh',N'Hà Nội')
Insert into NhanVien values('NV04',N'Lê Đào Xuân',N'Bắc Giang')
Insert into NhanVien values('NV05',N'Đinh Đức Đạt',N'Hà Nam')


-- Account--

Insert into Account values('admin','1','NV01',1)
Insert into Account values('admin1','1','NV02',1)
Insert into Account values('nhanvien','1','NV03',0)
Insert into Account values('nhanvien1','1','NV04',0)
Insert into Account values('nhanvien2','1','NV05',0)
go

Create Proc USP_Login
@UserName varchar(200),
@PassWord varchar(200)
as
begin
	select * from dbo.Account where UserName=@UserName and PassWord=@PassWord
end
go

--Phân loại--
Insert Into PhanLoai values ('L01',N'Đại Cương')
Insert Into PhanLoai values ('L02',N'Báo')
Insert Into PhanLoai values ('L03',N'Tài liệu nghiên cứu khoa học')
Insert Into PhanLoai values ('L04',N'Công nghệ')
Insert Into PhanLoai values ('L05',N'Kinh tế')

--Sach--

Insert Into dbo.Sach values ('M001',N'Giải tích I',N'Nguyễn Lan',125,600,600,2010,6,N'NXB Giáo Dục',30,'L01',GETDATE())
Insert Into dbo.Sach values ('M002',N'Giải tích II',N'Nguyễn Bắc',130,600,600,2010,7,N'NXB Giáo Dục',70,'L01',GETDATE())
Insert Into dbo.Sach values ('M003',N'Lao động',N'Trần Văn Diệu',10,60,60,2019,1,N'Báo Lao Động',10,'L02',GETDATE())
Insert Into dbo.Sach values ('M004',N'Lập trình C',N'Lê Đức Nam',200,700,700,2017,5,N'NXB Kim Đồng',70,'L04',GETDATE())
Insert Into dbo.Sach values ('M005',N'Khí hậu Toàn cầu',N'Nguyễn Thị Lan',15,60,60,2015,2,N'NXB Giáo Dục',30,'L03',GETDATE())

Create table NgonNgu(
	MaNgonNgu varchar(20) primary key,
	TenNgonNgu nvarchar(100)
)
go

Alter table dbo.Sach
Add MaNgonNgu varchar(20) null,
foreign key (MaNgonNgu) references dbo.NgonNgu(MaNgonNgu)
go
---Ngôn ngữ--
Insert Into NgonNgu values('NN01',N'Tiếng Việt')
Insert Into NgonNgu values('NN02',N'Tiếng Anh')
Insert Into NgonNgu values('NN03',N'Tiếng Trung')
Insert Into NgonNgu values('NN04',N'Tiếng Nhật')
*/


--độc giả
Insert Into DocGia values ('DG001',N'Nguyễn Văn B',1821051029,GETDATE(),N'Công nghệ thông tin','Hà Nội',GETDATE())
Insert Into DocGia values ('DG002',N'Nguyễn Văn C',1821051028,GETDATE(),N'Công nghệ thông tin','Hà Nội',GETDATE())
Insert Into DocGia values ('DG003',N'Nguyễn Văn D',1821051027,GETDATE(),N'Kinh tế','Hà Nội',GETDATE())
Insert Into DocGia values ('DG004',N'Nguyễn Văn E',1821051026,GETDATE(),N'Xây dựng','Hà Nội',GETDATE())
Insert Into DocGia values ('DG005',N'Nguyễn Văn F',1821051025,GETDATE(),N'Dầu mỏ','Hà Nội',GETDATE())



-- phieu mượn---
Insert into PhieuMuon values('P001','DG001',GETDATE(),'9/5/2021','NV01','0','M001',1)
Insert into PhieuMuon values('P002','DG002',GETDATE(),'9/5/2021','NV02','0','M002',2)
Insert into PhieuMuon values('P003','DG002',GETDATE(),'9/5/2021','NV02','0','M003',1)
Insert into PhieuMuon values('P004','DG003',GETDATE(),'9/5/2021','NV01','0','M004',1)
Insert into PhieuMuon values('P007','DG004',GETDATE(),'9/10/2021','NV03','0','M005',2)
Insert into PhieuMuon values('P008','DG005',GETDATE(),'9/11/2021','NV04','0','M003',1)

go

create proc USP_InsertPhieuMuon
@MaPhieuMuon varchar(100),
@MaDG varchar(100),
@NgayMuon Date,
@NgayTra Date,
@MaNhanVien varchar(100),
@TrangThai int=0,
@MaSach varchar(100),
@soluong int
as
begin
	declare @slcon int
	
	select @slcon=SoLuongCon from Sach where MaSach=@MaSach
	declare @slsau int

	if(@slcon>@soluong)
	Begin
		Insert into PhieuMuon values(@MaPhieuMuon,@MaDG,@NgayMuon,@NgayTra,@MaNhanVien,@TrangThai,@MaSach,@soluong)
		Set @slsau=@slcon-@soluong
		update Sach Set SoLuongCon=@slsau where MaSach=@MaSach
	end
end
go

alter proc USP_TraSach
@MaPhieu varchar(100),
@Soluong int,
@MaSach varchar(100)
as
Begin
	declare @soluongcon int
	select @soluongcon=SoLuongCon from Sach Where MaSach=@MaSach
	declare @slSau int
	declare @slMuon int
	declare @slMuonSau int

	select @slMuon=SoLanMuon from Sach Where MaSach=@MaSach
	Set @slSau= @Soluong+@soluongcon
	Set @slMuonSau= @slMuon+@Soluong;
	Update PhieuMuon Set TrangThaiTong=1 where MaPhieuMuon=@MaPhieu
	update Sach Set SoLuongCon=@slSau, SoLanMuon=@slMuonSau where MaSach=@MaSach

end
go

Alter Proc USP_GetListPhieuMuonByPage
@page int ,
@trangthai int--0:chua tra ,1 quahan
as
Begin
	declare @PageRow int =10
	declare @start int=@Page*@PageRow
	declare @end int = (@Page-1)*@PageRow
	if(@trangthai=0)
	Begin 
		select top(@start) * from PhieuMuon where TrangThaiTong=0
		except
		select top(@end) * from PhieuMuon where TrangThaiTong=0

	end

	if(@trangthai=1)
	begin
		select top(@start) * from PhieuMuon where TrangThaiTong=0 and NgayTra < GETDATE()
		except
		select top(@end) * from PhieuMuon where TrangThaiTong=0 and NgayTra < GETDATE()
	end

end
Go

create proc USP_DoiMatKhau
@userName varchar(200),
@newPass varchar(200)
as 
begin
	update Account set PassWord=@newPass where UserName=@userName
end
go

