create database VEHICULOS

create table Placa(
idPlaca int identity(1,1),
NumPlaca nvarchar(6) UNIQUE,
idUsuario int,
Monto money DEFAULT 0,
constraint pk_placa primary key(idPlaca),
CONSTRAINT fk_idUsuario FOREIGN KEY (idUsuario) REFERENCES Usuarios (idUsuario)
)

create table Usuarios(
idUsuario int identity (1,1),
Usuario nvarchar(50) UNIQUE,
Clave nvarchar(30),
Nombre nvarchar(50),
Apellido nvarchar(50),
constraint pk_usuario primary key(idUsuario)
)

create procedure agregarUsuarios @usuario nvarchar(50), @clave nvarchar(30), @nombre nvarchar(50), @apellido nvarchar(50)
as
insert into Usuarios (Usuario,Clave,Nombre,Apellido) values (@usuario,@clave,@nombre,@apellido)

exec agregarUsuarios 'allan@uh.ac.cr', 'Examen3', 'Allan', 'Picado'

create procedure borrarUsuarios @usuario nvarchar(50)
as
delete from Usuarios where Usuario = @usuario

create procedure actualizarUsuarios @usuario nvarchar(50), @clave nvarchar(30), @nombre nvarchar(50), @apellido nvarchar(50)
as
update Usuarios set Clave =@clave, Nombre = @nombre, Apellido = @apellido
where Usuario = @usuario

create procedure agregarPlaca @placa nvarchar(6), @usuario int, @monto money
as
insert into Placa(NumPlaca,idUsuario, Monto) values (@placa,@usuario, @monto)

create procedure borrarPlaca @numPlaca varchar(6)
as
delete from Placa where NumPlaca = @numPlaca

create procedure actualizarPlaca @numPlaca varchar(6), @nuevo varchar(69), @usuario int, @monto money
as
update Placa set NumPlaca = @nuevo, idUsuario = @usuario, Monto = @monto
where NumPlaca = @numPlaca

create procedure reporte @numPlaca nvarchar(6)
as
select Nombre, Apellido, Placa.Monto, (Placa.Monto * 0.13) as IVA, ((Placa.Monto*0.13)+Placa.Monto) as Total from Usuarios
join Placa
on Usuarios.idUsuario = Placa.idUsuario
where NumPlaca = @numPlaca

create procedure selectLogin @usuario nvarchar(50), @clave nvarchar(30)
as
select * from Usuarios
where Usuario = @usuario and Clave = @clave

create procedure selectUsuarios
as
select * from Usuarios

create procedure selectPlaca
as
select * from Placa

select * from Placa