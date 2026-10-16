-- Guia 11/12: Entity Framework - Ejercicio 1
-- Ejecutar cada bloque (separado por GO) en SQL Server Management Studio
use master
GO

create database bdd_udb
GO

use bdd_udb
GO

create table persona(
id int Primary Key,
nombre varchar(50),
correo varchar(50),
fecha_nacimiento datetime)
GO
