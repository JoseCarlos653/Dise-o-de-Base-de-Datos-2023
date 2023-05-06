-- DML

/* Creando la edicion de datos de la base de datos */

-- Crear Registros en la tabla Ciudad
insert into Ciudad(nombreCiudad) values (N'Masaya'), (N'Managua'), (N'Granada'), (N'Leon'), (N'Rivas')

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

-- Consultas de seleccion
-- Mostrar en una columna el primer nombre y el primer apellido , en otra columna la edad de la persona


SELECT primerNombre + N' ' + primerApellido as N'Nombre Completo', Year(GETDATE()) - Year(fechaNac) as N'Edad'
FROM     Persona

print(GetDate()) --imprime la hora a la que se ejecuta el programa

print(year(getDate())) --solo imprime el año de la fecha
print (Month(GetDate()))  --muestra unicamente el numero del mes
print (Day(GetDate())) --muestra el dia
