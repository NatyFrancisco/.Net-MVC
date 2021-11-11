CREATE DATABASE Proyect

--Entrada a la base de datos
SET QUOTED_IDENTIFIER OFF;
GO

USE Proyect
GO

IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

--Creacion de la Tabla
CREATE TABLE [dbo].[tabla] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NOT NULL,
    [correo] varchar(50)  NOT NULL,
    [fecha_nacimiento] datetime  NOT NULL
);
GO