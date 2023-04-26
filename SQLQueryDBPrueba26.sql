--DDL
/*Crear Base de Datos*/
create database DBPrueba26;
go
use DBPrueba26
go

create table Ciudad (
	id int primary key identity (1, 1),
	nombre nvarchar(50) not null,
	estado bit default 1
);
go

create table Persona (
	id int primary key identity (1, 1)
	, primerNombre nvarchar(50) not null
	, segundoNombre nvarchar(50) 
	, primerApellido nvarchar(50) not null
	, segundoApellido nvarchar(50) 
	, fechaNac datetime not null
	, sexo bit default 1 not null
	, telefono nchar(15) not null
	, email nvarchar(100) 
	, direccion nvarchar(100) not null
	, estado bit default 'true'
);
go 

--DML
/*Crear o Insertar un Registro*/
insert into Ciudad(nombre) values(N'Masaya') 
insert into Ciudad(nombre) values(N'Managua'), (N'Granada'), (N'Jinotepe'), (N'León') 

--Mostrar Registro
select * from Ciudad 