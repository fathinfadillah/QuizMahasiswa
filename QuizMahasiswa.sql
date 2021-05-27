CREATE DATABASE QuizMahasiswa

USE QuizMahasiswa

CREATE TABLE tbl_barang (
	id_barang INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nama_barang NVARCHAR(20) NOT NULL,
	harga int null,
    stok int null,
    nama_supplier nvarchar(20) null,
	)
