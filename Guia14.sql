CREATE DATABASE DBCONTACTO
GO

USE DBCONTACTO
GO

CREATE TABLE CONTACTO(
IdContacto int identity,
Nombres varchar(100),
Apellidos varchar(100),
Telefono varchar(100),
Correo varchar(100)
)
GO

insert into CONTACTO(Nombres,Apellidos,Telefono,Correo) values
('Jose','Perez','22577777','jose@gmail.com'),
('Maria','Paz','78179878','mar@gmail.com'),
('Roxana','Melendez','71968945','roxana.m@gmail.com'),
('Victor','Barrera','65789456','victorb@gmail.com'),
('Alex','Espinoza','75457498','alex@gmail.com'),
('Carmen','Morales','77449988','carmen.morales@outlook.com')
GO

select * from CONTACTO
GO

create procedure sp_Registrar(
@Nombres varchar(100),
@Apellidos varchar(100),
@Telefono varchar(100),
@Correo varchar(100)
)
as
begin
	insert into CONTACTO(Nombres,Apellidos,Telefono,Correo) values (@Nombres,@Apellidos,@Telefono,@Correo)
end
GO

create procedure sp_Editar(
@IdContacto int,
@Nombres varchar(100),
@Apellidos varchar(100),
@Telefono varchar(100),
@Correo varchar(100)
)
as
begin
	update CONTACTO set Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono , Correo = @Correo where IdContacto = @IdContacto
end
GO

create procedure sp_Eliminar(
@IdContacto int
)
as
begin
	delete from CONTACTO where IdContacto = @IdContacto
end
GO
