create database duan1
--quanly
create table quanlytonkho (
masp nvarchar(10),
tensp nvarchar(25),
soluong int,
ngaynhap date,
gia int,
vitri nvarchar(5)
primary key ( masp,tensp)
);
drop table quanlytonkho
--sale
create table quanlybanhang(
maspdb nvarchar(10),
tenspdb nvarchar(25),
soluong int,
ngayban date,
gia int,
makhachhang nvarchar(10),
tenkhachhang nvarchar(25),  
manhanvien nvarchar(10),
tennhanvien nvarchar(25)
primary key ( maspdb,tenspdb,manhanvien,tennhanvien )
);
drop table quanlybanhang
alter table quanlybanhang
add constraint fk_hx foreign key (maspdb,tenspdb)references quanlytonkho(masp,tensp)
create table nhanvien(
manhanvien nvarchar(10) ,
tennhanvien nvarchar(25),
chuc_vu nvarchar(25),
sdt nvarchar(10),
mail nvarchar(25),
gioitinh nvarchar(3)
primary key(manhanvien,tennhanvien)
);
alter table quanlybanhang
add constraint fk_nv foreign key (manhanvien,tennhanvien)references nhanvien(manhanvien,tennhanvien)
create table khach_hang(
makhachhang nvarchar(10),
tenkhachhang nvarchar(25),
diemtichluy nvarchar(10)
primary key (makhachhang,tenkhachhang)
);
DROP TABLE khach_hang
update quanlytonkho 
set soluong=soluong+40 where masp='a1'and soluong>=0 
 if quanlytonkho.soluong >0 begin select 'het hang' end
select *from nhanvien
insert into nhanvien values ('pd0','mai van minh','nhan vien sale','0822761718','vanminh@.vom','nam')
insert into nhanvien values ('pd1','tran anh tung','nhan vien sale','039761723','anhtu@.vom','nam')
insert into nhanvien values ('pd2','le quoc anh','nhan vien sale','0822545646','anhq@.vom','nam')
insert into nhanvien values ('pd3','nguyen tuan cong','nhan vien sale','0338721271','tuanc@.vom','nam')
select*from quanlytonkho 

insert into  quanlytonkho values ('a1','ao hutdi',20,'2023-11-10',499,'dãy 1');
insert into  quanlytonkho values ('a2','ao so mi',15,'2023-11-9',200,'dãy 1');
insert into  quanlytonkho values ('a3','ao unisex',25,'2023-11-10',150,'dãy 2');
insert into  quanlytonkho values ('a4','quan zin',20,'2023-11-10',499,'dãy 2');
insert into  quanlytonkho values ('a5','quan tay',20,'2023-11-8',300,'dãy 2');
insert into  quanlytonkho values ('a6','quan caki',30,'2023-11-10',400,'dãy 2');
select * from quanlytonkho where ngaynhap>='2023-11-9' AND ngaynhap <='2023-11-10'
select * from khach_hang
insert into khach_hang values ('kh1','truong vi','1')
select *from quanlybanhang
insert into quanlybanhang values('a1','ao hutdi',41,'2023-11-20',499,'kh1','truong vi','pd0','mai van minh')

CREATE PROCEDURE sp_nkh
 @makh nvarchar(10),  @tenkh nvarchar(25),
 @diemtl int
 AS
 IF EXISTS(SELECT * From khach_hang Where makhachhang = @makh)
 UPDATE khach_hang SET makhachhang =  @makh, tenkhachhang = @tenkh,diemtichluy+=@diemtl
 WHERE makhachhang = @makh
 ELSE
 INSERT INTO khach_hang
 VALUES ( @makh ,  @tenkh ,@diemtl )
GO
drop procedure sp_nkh
exec sp_nkh 'kh1','truong vi',1
delete khach_hang
where makhachhang='System.Win'

CREATE TRIGGER checksoluong ON quanlytonkho  FOR INSERT
AS
IF(SELECT soluong FROM quanlytonkho where masp='a1' )<=0
BEGIN
  PRINT N'mặt hàng đã hết.'
  ROLLBACK TRANSACTION
END
drop trigger checksoluong