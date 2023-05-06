-- DML

/* Creando la edicion de datos de la base de datos */

-- Crear Registros en la tabla Ciudad
insert into Ciudad(nombreCiudad) values (N'Masaya'), (N'Managua'), (N'Granada'), (N'Leon'), (N'Rivas')
insert into Ciudad(nombreCiudad) values (N'Jinotega'), (N'Chinandega'), (N'Boaco'), (N'Estelí')
insert into Ciudad(nombreCiudad) values (N'Leon')

SELECT Ciudad.*
FROM     Ciudad
go

-- Editar Registros
Update Ciudad set nombreCiudad = N'León', estado = 'True' Where idCiudad = 4
go

-- Elimiar Registros
Delete from Ciudad Where idCiudad = 4
go

-- Insertar Registros a Personas
Insert into Persona(primerNombre, primerApellido, fechaNac, idCiudad) values ('Duran', 'Garcia', '28/4/2023', 1)

Insert into Persona(primerNombre, primerApellido, fechaNac, idCiudad) values ('Abigail', 'Rocha', '6/10/2005', 2), ('Jose', 'Lopez', '3/5/2003', 3), ('Andrea', 'Nuñez', '16/4/2005', 2), ('Jose', 'Perez', '30/5/2004', 2), ('Luswi', 'Torres', '3/8/2004', 1) 

Insert into Persona(primerNombre, primerApellido, fechaNac, idCiudad) values (N'Henry', N'Noel', '9/3/1999', 9), (N'Lia', N'Ramirez', '30/10/2003', 7), (N'Aisha', N'Arevalo', '13/6/2004', 5), (N'Carlos', N'Flores', '7/12/1978', 10), (N'Angie', N'Perez', '15/5/2002', 5), (N'Jessica', N'Helen', '8/12/1999', 6)
go

SELECT Persona.*
FROM     Persona
go

-- Consultas de seleccion
-- Mostrar en una columna el primer nombre y el primer apellido , en otra columna la edad de la persona
--esto lo cree utilizando ctr shift q
SELECT primerNombre, primerApellido, fechaNac, idCiudad
FROM     Persona

SELECT primerNombre + N' ' + primerApellido as N'Nombre Completo', Year(GETDATE()) - Year(fechaNac) as N'Edad'
FROM     Persona

print(GetDate()) --imprime la hora a la que se ejecuta el programa

print(year(getDate())) --solo imprime el año de la fecha
print (Month(GetDate()))  --muestra unicamente el numero del mes
print (Day(GetDate())) --muestra el dia

SELECT Persona.primerNombre AS Nombre, Persona.primerApellido AS Apellido, Ciudad.nombreCiudad AS Ciudad
FROM     Persona INNER JOIN
                  Ciudad ON Persona.idCiudad = Ciudad.idCiudad

--Filtrar
Select * From Persona Where primerNombre like 'A%' and primerApellido like 'A%'

Select *, Ciudad.nombreCiudad from Persona inner join Ciudad on Ciudad.idCiudad = Persona.idCiudad where Ciudad.nombreCiudad like N'%M%'

Select primerNombre, primerApellido, year(getdate())-year(fechaNac) as Edad From Persona Where year(getdate())-year(fechaNac) = 18

Select primerNombre, primerApellido, year(getdate())-year(fechaNac) as Edad From Persona Where year(getdate())-year(fechaNac) >= 18

Select primerNombre, primerApellido, year(getdate())-year(fechaNac) as Edad From Persona Where year(getdate())-year(fechaNac) between 18 and 30

Select primerNombre, primerApellido, year(getdate())-year(fechaNac) as Edad From Persona Where year(getdate())-year(fechaNac) in (18, 20)

Select *, Ciudad.nombreCiudad from Persona inner join Ciudad on Ciudad.idCiudad = Persona.idCiudad where Ciudad.nombreCiudad in (N'Managua', N'Granada') 

Select * From Persona Where telefono is null

Select * from Persona left join Ciudad on Ciudad.idCiudad = Persona.idCiudad

