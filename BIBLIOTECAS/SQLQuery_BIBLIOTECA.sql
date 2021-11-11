CREATE DATABASE BIBLIOTECA

USE BIBLIOTECA
GO

-----------------------------------------------------------------
CREATE TABLE USUARIO (
NOMBRE VARCHAR (30) PRIMARY KEY,
CONTRASEŅA VARCHAR (50)
)



-----------------------------------------------------------------
CREATE TABLE LIBRO(
ID INT PRIMARY KEY IDENTITY (1000,1),
NOMBRE NVARCHAR (MAX),
AUTOR CHAR (30),
FECHA DATETIME
)

CREATE TABLE BIBLIOTECA(
ID INT PRIMARY KEY IDENTITY (1000, 1),
NOMBRE_USUARIO VARCHAR (30),
ID_LIBRO INT
)

ALTER TABLE BIBLIOTECA ADD FOREIGN KEY (NOMBRE_USUARIO) REFERENCES USUARIO (NOMBRE) 
ALTER TABLE BIBLIOTECA ADD FOREIGN KEY (ID_LIBRO) REFERENCES LIBRO (ID) 

select*from USUARIO