CREATE DATABASE QLNHATHUOC
GO
USE QLNHATHUOC
GO
CREATE TABLE KHACHHANG(MaKH char(10) not null,TenKH nvarchar(30), SDT char(10),GioiTinh nvarchar(3) check(GioiTinh=N'Nam' or GioiTinh=N'Nữ'),NgaySinh date,Diachi nvarchar(30),Email nvarchar(30) not null
primary key (MaKH)
)
GO
CREATE TABLE NHANVIEN(MaNV Char(10) not null,TenNv nvarchar(30),SDT char(10),GioiTinh nvarchar(3) check(GioiTinh=N'Nam' or GioiTinh=N'Nữ'),NgaySinh date,Diachi nvarchar(30),Email nvarchar(30) not null,Luong int, hsluong float, maql char(10),primary key(MaNV))