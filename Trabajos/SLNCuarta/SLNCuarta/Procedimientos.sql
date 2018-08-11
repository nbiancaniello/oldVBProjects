CREATE PROCEDURE AgregarPersona
@legajo smallint,
@nombre varchar(40),
@telefono varchar(20),
@celular varchar(12),
@email varchar(40),
@fecha smalldatetime,
@sexo char(1)
AS
INSERT INTO Datos (legajo,nombre,telefono,celular,email,fecha_nacimiento,sexo)
VALUES (@legajo,@nombre,@telefono,@celular,@email,@fecha,@sexo)

CREATE PROCEDURE ModificarPersona
@legajo smallint,
@nombre varchar(40),
@telefono varchar(20),
@celular varchar(12),
@email varchar(40),
@fecha smalldatetime,
@sexo char(1)
AS
UPDATE Datos 
SET 	nombre = @nombre,
	telefono = @telefono,
	celular = @celular,
	email = @email,
	fecha_nacimiento = @fecha,
	sexo = @sexo
WHERE legajo = @legajo

CREATE PROCEDURE VerificarExistencia
@legajo smallint
AS
SELECT COUNT(legajo)
FROM Datos
WHERE legajo = @legajo

CREATE PROCEDURE EliminarPersona
@legajo smallint
AS
DELETE FROM Datos 
WHERE legajo = @legajo