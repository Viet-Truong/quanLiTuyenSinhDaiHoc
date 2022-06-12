create database tuyensinhdaihoc2
go
use tuyensinhdaihoc2

go 
create table nam
(
	idnam int not null primary key,
	nam int not null
)
go 
create table nganh
(
	idNganh int not null,
	nameNganh nvarchar(40) null,
	toHopMon varchar(40) null,
	diemChuan float null,
	nam int not null
	primary key(nam, idNganh)
	foreign key(nam) references nam(idnam)
	on delete
		cascade
	on update
		cascade
)



go
create table account
(
	userName varchar(10) not null primary key,
	passWord varchar(10) not null,
)


create table nguoidung
(
	nameUser nvarchar(30) null,
	ngaySinh date null,
	gioiTinh nvarchar(3) null,
	queQuan nvarchar(20) null,
	sdt varchar(10) not null,
	email varchar(25) null,
	cmnd varchar(12) not null primary key,
	userName varchar(10) null
	foreign key(userName) references account(userName)
	on delete
		cascade
	on update
		cascade
)

create table nguyenvong
(
	idNganh int not null,
	nameUser nvarchar(30) null,
	cmnd varchar(12) not null,
	nam int not null
	primary key(idNganh, cmnd, nam)
	foreign key(cmnd) references nguoidung(cmnd)
	on delete
		cascade
	on update
		cascade,
)

go
insert into nam
values
(2019, '2019'),
(2020, '2020'),
(2021, '2021')
go
insert into account
values
('truong', '123')

go
insert into nganh
values
('7510303', N'Tự động hóa', 'A00, A16, D01, D90', 22.8, 2021),
('7480201', N'Công nghệ thông tin', 'A00, A16, D01, D90', 23.45, 2020),
('7140214', N'Sư phạm Kỹ thuật công nghiệp', 'A00, A16, D01, D90', 18.9, 2020),
('7480201', N'Công nghệ thông tin', 'A00, A01, D01, D90', 24.25, 2021),
('7510303', N'Tự động hóa', 'A00, A16, D01, D90', 21.67, 2020),
('7140214', N'Sư phạm Kỹ thuật công nghiệp', 'A00, A16, D01, D90', 19.1, 2021)

set dateformat dmy
go
insert into nguoidung
values
(N'Bùi Viết Trường', '02-08-2002', 'Nam', N'Thừa Thiên Huế', '0789416451', 'viettruong0825@gmail', '201830627', 'truong')
