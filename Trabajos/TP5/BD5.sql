USE master
GO
CREATE DATABASE BD5
ON 
( NAME = bd5_dat,
   FILENAME = 'E:\BD5.mdf',
   SIZE = 1MB,
   MAXSIZE = 2MB,
   FILEGROWTH = 1MB )
LOG ON
( NAME = 'bd5_log',
   FILENAME = 'E:\BD5.ldf',
   SIZE = 1MB,
   MAXSIZE = 2MB,
   FILEGROWTH = 1MB )
GO


CREATE TABLE Personas
(   codigo smallint NOT NULL,
    nombre varchar(30) NOT NULL,
    fecha_nac smalldatetime NOT NULL,
    estado tinyint NOT NULL
)

DROP TABLE Personas

ALTER TABLE Personas
ADD CONSTRAINT pk_codigo PRIMARY KEY (codigo)

INSERT INTO Personas (codigo, nombre, fecha_nac, estado)
VALUES (1,'Alejandro', '01/06/1984',0)

INSERT INTO Personas (codigo, nombre, fecha_nac, estado)
VALUES (2,'Pablo', '18/09/1986',0)

INSERT INTO Personas (codigo, nombre, fecha_nac, estado)
VALUES (3,'Daniel', '13/02/1973',0)

CREATE PROCEDURE TraerDatosPersonas
AS
SELECT 	codigo,
	nombre,
	fecha_nac,
	estado
FROM Personas
ORDER BY nombre

CREATE PROCEDURE AgregarPersona
@cod smallint,
@nombre varchar(30),
@fecha_nac smalldatetime
AS
INSERT INTO Personas (codigo,nombre,fecha_nac,estado)
VALUES (@cod,@nombre,@fecha_nac,0)

DROP PROCEDURE TraerDatosPersonas

CREATE PROCEDURE ActualizarPersona
@cod smallint,
@nombre varchar(30),
@fecha_nac smalldatetime,
@estado tinyint
AS
UPDATE Personas SET nombre = @nombre, fecha_nac = @fecha_nac, estado = @estado
WHERE codigo = @cod

CREATE PROCEDURE VerificarSiExiste
@codigo smallint
AS
SELECT COUNT(codigo) AS cantidad
FROM Personas
WHERE codigo = @codigo

CREATE PROCEDURE EliminarPersona
@codigo smallint
AS
DELETE FROM Personas 
WHERE codigo = @codigo