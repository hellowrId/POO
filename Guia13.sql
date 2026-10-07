-- Parte 1: Login sa
ALTER LOGIN sa ENABLE;
GO
ALTER LOGIN sa WITH PASSWORD = '123456';
GO

-- Parte 2: Creacion de la base de datos, esquemas y tablas
-- Todo esto se creo en el login sa
CREATE DATABASE Alumnos_Carnet
GO

USE Alumnos_Carnet
GO

--Creacion de esquemas
CREATE SCHEMA alumno;
GO

CREATE SCHEMA nota
GO

--Creacion de la tabla alumnos en el esquema alumno
CREATE TABLE alumno.alumnos(
carnet int PRIMARY KEY,
nombres varchar(50),
apellidos varchar(50))
GO

--Creacion de la tabla notas en el esquema nota
CREATE TABLE nota.notas(
idnotas int identity,
carnet int FOREIGN KEY REFERENCES alumno.alumnos(carnet),
nota1 decimal(10,2),
nota2 decimal(10,2),
nota3 decimal(10,2),
promedio as (nota1+nota2+nota3)/3
)
GO

--Agregando datos
INSERT INTO alumno.alumnos VALUES(111,'Juan Jose','Perez')
INSERT INTO alumno.alumnos VALUES(222,'Luisa ','Flores')
INSERT INTO alumno.alumnos VALUES(333,'Francisco ','Gavidia')
INSERT INTO alumno.alumnos VALUES(444,'Evelyn','Rivas')

INSERT INTO nota.notas VALUES(111,7.6,10,5.5)
INSERT INTO nota.notas VALUES(222,8.5,9,10)
INSERT INTO nota.notas VALUES(333,9.3,8.5,5.7)

--Seleccione los datos
select * from alumno.alumnos
select * from nota.notas
GO

-- Parte 3: Creacion de inicio de sesion
CREATE LOGIN ca201301
WITH PASSWORD = 'ca201301', CHECK_POLICY = OFF, DEFAULT_DATABASE = Alumnos_Carnet
GO

CREATE LOGIN guiaCarnet WITH PASSWORD = '12345'
GO

-- Parte 4: Eliminando inicio de sesion
DROP LOGIN guiaCarnet
GO

-- Parte 4: Creacion de usuarios de base de datos
USE Alumnos_Carnet
GO

CREATE USER SuNombre FOR LOGIN ca201301
WITH DEFAULT_SCHEMA = alumno
GO

ALTER AUTHORIZATION ON SCHEMA::alumno TO SuNombre
GO

-- Con el login ca201301: alumno.alumnos es accesible
select * from alumno.alumnos
-- Con el login ca201301: genera error de permiso SELECT denegado
Select * from nota.Notas
GO

-- Parte 5: Asignacion de permisos (login sa)
CREATE TABLE Materias
(ID int,
nombre varchar(50)
)
GO

INSERT INTO Materias VALUES(101,'Fisica')
INSERT INTO Materias VALUES(102,'Programacion')
INSERT INTO Materias VALUES(103,'Diseño Web')
INSERT INTO Materias VALUES(104,'Algebra')
GO

GRANT SELECT, UPDATE ON OBJECT::dbo.Materias TO SuNombre
GO

-- Con el login ca201301
--Haciendo uso de SELECT
SELECT * FROM dbo.Materias

--Haciendo uso de UPDATE
UPDATE dbo.Materias SET nombre='Fisica Tecnica' WHERE ID=101

--Haciendo uso de INSERT
INSERT INTO dbo.Materias VALUES(105,'SQL Server')
GO

-- Parte 6: Agregando permisos a esquemas (login sa)
GRANT CREATE PROCEDURE, CREATE TABLE TO SuNombre
GO

-- Con el login ca201301
USE Alumnos_Carnet
GO
CREATE TABLE Prueba
(column1 INT NOT NULL,
column2 CHAR(10) NOT NULL
)
GO

CREATE VIEW Reporte
as
SELECT carnet,nombres,apellidos FROM alumno.alumnos
GO

-- Login sa
GRANT CREATE VIEW
TO SuNombre
GO

-- Con el login ca201301
CREATE VIEW Reporte
as
SELECT carnet,nombres,apellidos FROM alumno.alumnos
GO
