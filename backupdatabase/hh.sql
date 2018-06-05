select * from quanlyhanghoa.nhanvien where manhanvien = 'KD000001';

insert into quanlyhanghoa.user(tendangnhap, matkhau, manhomuser, manhanvien, email, dienthoai)
 values
(
	 tendangnhap= 'hoatk',
	 matkhau ='123', 
	 manhomuser =1,
	 manhanvien='KD000001', 
	 email ='sdfs@', 
	 dienthoai='0133'
 );
 
 select * from quanlyhanghoa.nhanvien where  manhanvien='KD000001';
 select * from quanlyhanghoa.user;
 
 

 ALTER DATABASE quanlyhanghoa CHARACTER SET utf8 COLLATE utf8_general_ci;
 
 ALTER TABLE user
ADD FOREIGN KEY (manhanvien) REFERENCES nhanvien(manhanvien);



SELECT * FROM information_schema.SCHEMATA 
WHERE schema_name = "sinhvien";
 