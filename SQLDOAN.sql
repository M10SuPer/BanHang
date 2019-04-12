CREATE DATABASE Web
GO

USE Web
go
CREATE TABLE Users
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	UserName VARCHAR(70) NOT NULL,
	Password VARCHAR(70) NOT NULL,
	Name NVARCHAR(70),
	Address NVARCHAR(70),
);
go
CREATE TABLE Contact
(
	IDC INT PRIMARY KEY,
	tennguoilienhe NVARCHAR(70),
	email NVARCHAR(70),
	sdt NVARCHAR(20),
	noidung TEXT
);
go
CREATE TABLE FeelBack
(
	IDF  INT PRIMARY KEY,
	email NVARCHAR(70),
);
go
CREATE TABLE Product
(
	IDPro INT IDENTITY(1,1) PRIMARY KEY,
	tensanpham NVARCHAR(70),
	gia DECIMAL(18,0)
);
go
CREATE TABLE OrderA
(
	IDOr INT PRIMARY KEY,
	IDPro INT,
	tensanpham NVARCHAR(70),
	gia DECIMAL(18,0),
	soluong INT,
	thanhtien DECIMAL(18,0),
	CONSTRAINT fk_Order FOREIGN KEY (IDPro) REFERENCES dbo.Product(IDPro)
);
go
CREATE TABLE OrderDetail
(
	IDOrD INT PRIMARY KEY,
	IDOr INT,
	tennguoidathang NVARCHAR(70),
	email NVARCHAR(70),
	diachi NVARCHAR(200),
	sdt NVARCHAR(20),
	CONSTRAINT fk_OrDe FOREIGN KEY (IDOr) REFERENCES dbo.OrderA(IDOr)
);
go
CREATE TABLE Company
(
	ID INT PRIMARY KEY,
	tenncc NVARCHAR(70),
	diachi NVARCHAR(200),
	email NVARCHAR(70),
	sdt NVARCHAR(20)
);