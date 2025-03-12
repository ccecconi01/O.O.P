CREATE DATABASE poo24;
use poo24;
go

CREATE TABLE Users(
    id INT NULL ,
    login_name NCHAR(20) NOT NULL,
    password NCHAR(20) NOT NULL,
    user_role NCHAR(20) NOT NULL            -
);
CREATE TABLE Product ( 
    product_id NCHAR(10) NOT NULL , 
    product_name NCHAR(20) NOT NULL,
    product_status NCHAR(20) NOT NULL,
    product_price NCHAR(10) NOT NULL,
    product_quantity NCHAR(10) NOT NULL
);

CREATE TABLE Staff (
	Nome_Staff NCHAR(20) NOT NULL,
	Idade_Staff NCHAR(3) NOT NULL,
	ID_Staff NCHAR(10) NOT NULL,
	Cargo_Staff NCHAR(20) NOT NULL
);
