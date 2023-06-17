create database XeTuLai
go
use XeTuLai
go 
create table ChiNhanh (maCN char(6) primary key , tenCN nvarchar(100) , DiaChi nvarchar(100))

create table NhanVien (maNV char(6) primary key , tenNV nvarchar(50) , ChucVu nvarchar(50) , NgaySinh date  , CCCD char(12)  , maCN char(6) , Anh image  )
create table Xe (maXe char(6) primary key , tenXe nvarchar(50) , namSX date , DongCo nvarchar(50) , SoChoNgoi int , GiaThue float )
create table HopDong (maHD char(6) primary key , maNV char(6)  , maKH char(6) , maXe char(6) , NgayThue date , NgayTra date , TongTienThue float )
create table KhachHang(maKH char(6) primary key , tenKH nvarchar(100) , NgaySinh date , CCCD char(12) )


insert into Xe values('X001' , 'Inova' , '12/12/2018' , '2.5L' , 7 , 500.000)
go

alter table NhanVien
add constraint FK_NHANVIEN foreign key (maCN) references ChiNhanh(maCN)

-- lay danh sach chi nhanh 
create proc sp_LaydsChiNhanh
as 
begin
  select * from ChiNhanh
  end
 -- them chi nhanh
 create proc sp_ThemChiNhanh(@ma char(6), @ten nvarchar(100) , @diachi nvarchar (100))
as 
 begin
  insert into ChiNhanh(maCN,tenCN , DiaChi)
  values(@ma,@ten , @diachi)
  end
-- xoa chi nhanh 
create proc sp_XoaChiNhanh(@ma char(6))
  as
   begin
      delete 
	  from ChiNhanh
	  where maCN = @ma
	end
--sua chi nhanh
  create proc sp_SuaChiNhanh(@ma char(6), @ten nvarchar(100) , @diachi nvarchar (100))
  as 
  begin
   update ChiNhanh
   set tenCN = @ten , DiaChi = @diachi
   where maCN = @ma
   end

------------------------------------------------------
-- them nhan vien

 create proc sp_ThemNhanVien(@ma char(6), @ten nvarchar(50) , @chucvu nvarchar (50), @ngaysinh datetime , @CCCD char (12) , @anh image , @maCN char(6))
as 

 begin
  insert into NhanVien(maNV,tenNV , ChucVu , NgaySinh,CCCD,Anh , maCN)
  values(@ma,@ten , @chucvu, @ngaysinh , @CCCD , @anh , @maCN)
  end
 
  -- sua nhan vien

  create proc sp_SuaNhanVien(@ma char(6), @ten nvarchar(50) , @chucvu nvarchar (50), @ngaysinh datetime , @CCCD char (12) , @anh image , @maCN char(6) )
  as
  begin 
  update NhanVien
  set tenNV = @ten , ChucVu = @chucvu , NgaySinh = @ngaysinh , CCCD = @CCCD , Anh = @anh , maCN = @maCN
  where maNV = @ma
  end
  -- xoa nhan vien 
  create proc sp_XoaNhanVien(@ma char(6))
  as
  begin
  delete from NhanVien where maNV = @ma
  end


  --lay danh sach nhan vien

  create proc sp_LaydsNhanVien
  as
  begin
  select * from NhanVien end
 exec sp_LaydsNhanVien
  ----------------------------------------------------------------------

  -- lay danh sach khach hang
 
   create proc sp_LaydsKH
  as
  begin
  select * from KhachHang end
  -- them khach hang
  
 create proc sp_ThemKhachHang(@ma char(6) , @ten nvarchar(100) , @NS date , @CCCD char(12)  )
 as
 begin
 insert into KhachHang(maKH , tenKH , NgaySinh , CCCD )
 values (@ma , @ten , @NS , @CCCD )
 end

 -- sua khach hang
 create proc sp_SuaKhachHang(@ma char(6) , @ten nvarchar(100) , @NS date , @CCCD char(12) )
 as
 begin
 update KhachHang
 set tenKH = @ten , NgaySinh = @NS , CCCD = @CCCD 
 where maKH = @ma
 end
 -- xoa khach hang
 create proc sp_XoaKhachHang(@ma char(6))
 as
 begin
 delete KhachHang
 where maKH = @ma
 end
 ----------------------------------------------------------------------
 -- lay ds xe
 create proc sp_layDsXe
 as
 begin
 select * from Xe
 end
 -- them xe 
 create proc sp_themXe(@ma char(6) , @ten nvarchar(50) , @namsx date , @dongco nvarchar(50) , @sochongoi int , @gia float)
 as begin
 insert into Xe(maXe , tenXe , namSX , DongCo , SoChoNgoi , GiaThue)
 values (@ma , @ten , @namsx , @dongco , @sochongoi , @gia)
 end
 -- sua xe
 create proc sp_SuaXe(@ma char(6) , @ten nvarchar(50) , @namsx date , @dongco nvarchar(50) , @sochongoi int , @gia float)
 as 
 begin
 update Xe
 set tenXe = @ten , namSX = @namsx , DongCo = @dongco , SoChoNgoi = @sochongoi , GiaThue = @gia
 where maXe = @ma
 end
 -- xoa xe 
 create proc sp_XoaXe(@ma char(6))
 as
 begin
 delete Xe
 where maXe = @ma
 end
 ------------------------------------------------------------------------------------
 --lay ds hop dong
 create proc sp_LaydsHopDong
 as
 begin
 select * from HopDong
 end
 -- them hop dong
 create proc sp_themHopDong(@ma char(6) , @manv char(6)  , @makh char(6) , @maxe char(6) , @ngaythue date , @ngaytra date , @tongtienthue float)
 as
 begin
 insert into HopDong(maHD , maNV , maXe  , maKH, NgayThue , NgayTra , TongTienThue)
 values (@ma , @manv , @maxe , @makh , @ngaythue , @ngaytra , @tongtienthue)
 end
 -- sua hop dong
 create proc sp_suaHopDong(@ma char(6) , @manv char(6)  , @makh char(6) , @maxe char(6) , @ngaythue date , @ngaytra date , @tongtienthue float)
 as
 begin
 update HopDong
 set maNV = @manv , maKH = @makh , maXe = @maxe , NgayThue = @ngaythue , NgayTra = @ngaytra , TongTienThue = @tongtienthue
 where maHD = @ma
 end
 -- xoa hop dong
 create proc sp_xoaHD(@ma char(16))
 as
 begin
 delete HopDong
 where maHD = @ma
 end
-- sắp xếp nhân viên theo mã
 create proc sp_themHopDong1(@ma char(6) , @manv char(6)  , @makh char(6) , @maxe char(6) , @ngaythue date , @ngaytra date )
 as
 begin
 insert into HopDong(maHD , maNV , maXe  , maKH, NgayThue , NgayTra )
 values (@ma , @manv , @maxe , @makh , @ngaythue , @ngaytra)
 end

 create proc sp_ThemNhanVien1(@ma char(6), @ten nvarchar(50) , @chucvu nvarchar (50), @ngaysinh datetime , @CCCD char (12) , @maCN char(6))
as 

 begin
  insert into NhanVien(maNV,tenNV , ChucVu , NgaySinh,CCCD , maCN)
  values(@ma,@ten , @chucvu, @ngaysinh , @CCCD  , @maCN)
  end
  ---tim kiem 
  create proc sp_timkiem(@ma char(6) )
  as
  begin
  select * from NhanVien where tenNV like @ma
  end