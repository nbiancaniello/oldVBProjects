CREATE TABLE tipodocumentos
(
tipodoc tinyint not null CONSTRAINT PK_tipdoc PRIMARY KEY CHECK (tipodoc > 0),
descripcion varchar (20) not null
)
GO

CREATE TABLE localidades
(
codpos smallint not null CONSTRAINT PK_codpos PRIMARY KEY CHECK ((codpos >= 1000) AND (codpos <= 9999)),
descripcion varchar (75) not null
)
GO

CREATE TABLE lugaresnacimiento
(
lugarnac tinyint not null CONSTRAINT PK_lugnac PRIMARY KEY CHECK (lugarnac > 0),
descripcion varchar (50) not null
)
GO

CREATE TABLE carreras
(
codcarrera tinyint not null CONSTRAINT PK_codcar PRIMARY KEY CHECK (codcarrera > 0),
descripcion varchar (45)
)
GO

CREATE TABLE titulos
(
titulo tinyint not null CONSTRAINT PK_titulo PRIMARY KEY CHECK (titulo > 0),
descripcion varchar (45) not null
)
GO

CREATE TABLE nacionalidades
(
nacionalidad tinyint not null CONSTRAINT PK_nacion PRIMARY KEY CHECK (nacionalidad > 0),
descripcion varchar (20) not null
)
GO

CREATE TABLE estadosciviles
(
estadocivil tinyint not null CONSTRAINT PK_estciv PRIMARY KEY CHECK (estadocivil > 0),
descripcion varchar (15) not null
)
GO

CREATE TABLE relacionestrabajo
(
relaciontrabajo tinyint not null CONSTRAINT PK_reltra PRIMARY KEY,
descripcion varchar (20) 
)
GO

CREATE TABLE profesores
(
codprofesor smallint not null CONSTRAINT PK_codpro PRIMARY KEY CHECK (codprofesor > 0),
nombre varchar (20) not null,
apellido varchar (30) not null,
domicilio varchar (50) not null,
codpos smallint not null REFERENCES localidades(codpos),
telefono varchar(20),
celular varchar(20),
email varchar(60),
sexo char(1) not null CHECK (sexo IN ('F','M')),
fechanac smalldatetime not null,
tipodoc tinyint not null REFERENCES tipodocumentos(tipodoc),
nrodoc integer not null CONSTRAINT IX_prof_doc UNIQUE,
nacionalidad tinyint not null REFERENCES nacionalidades(nacionalidad), 
titulo tinyint not null REFERENCES titulos(titulo),
activo bit not null,
tipo char(1) not null CHECK (tipo IN ('A','P'))
)
GO

CREATE TABLE materias
(
codmateria tinyint not null CONSTRAINT PK_codmat PRIMARY KEY CHECK (codmateria > 0),
anio tinyint not null,
cuatrimestre tinyint not null,
nombremateria varchar(40) not null,
codcarrera tinyint not null REFERENCES carreras(codcarrera),
cargahoraria tinyint not null
)
GO

CREATE TABLE usuarios
(
usuario varchar(20) not null CONSTRAINT PK_usuario PRIMARY KEY,
pass varchar(15) not null,
tipopermiso char(1) not null
)
GO

CREATE TABLE logerrores
(
fechayhora datetime not null,
modulo varchar(15) not null,
mensaje varchar (1024) not null,
usuario varchar(20) not null
)
GO

CREATE TABLE alumnos
(
nroinscripcion smallint not null,
anioingreso smallint not null,
nombre varchar (20) not null,
apellido varchar (30) not null,
domicilio varchar (50) not null,
codpos smallint not null REFERENCES localidades(codpos),
telefono varchar(20),
celular varchar(20),
email varchar(60),
sexo char(1) not null CHECK (sexo IN ('F','M')),
fechanac smalldatetime not null,
tipodoc tinyint not null REFERENCES tipodocumentos(tipodoc),
nrodoc integer not null CONSTRAINT IX_alu_doc UNIQUE,
nacionalidad tinyint not null REFERENCES nacionalidades(nacionalidad),
legajo smallint,
codcarrera tinyint not null,
etapa tinyint not null,
fechaingreso smalldatetime not null,
activo bit not null,
CONSTRAINT PK_alu_nro PRIMARY KEY (nroinscripcion,anioingreso)
)
GO

CREATE TABLE alumnosdetalles
(
nroinscripcion smallint not null,
anioingreso smallint not null,
lugarnac tinyint not null REFERENCES lugaresnacimiento(lugarnac),
titulosecundario tinyint not null REFERENCES titulos(titulo),
nombrecolegio varchar (50),
estadocivil tinyint not null REFERENCES estadosciviles(estadocivil),
hijos bit not null,
cantidadhijos tinyint not null,
trabaja bit not null,
cargahoraria tinyint,
relaciontrabajo tinyint,
CONSTRAINT PK_alu_nrodet PRIMARY KEY (nroinscripcion,anioingreso)
)
GO

CREATE TABLE conocimientos_alumnos
(
nroinscripcion smallint not null,
anioingreso smallint not null,
codigo1 bit not null,
codigo2 bit not null,
codigo3 bit not null,
codigo4 bit not null,
codigo5 bit not null,
codigo6 bit not null,
codigo7 bit not null,
codigo8 varchar(50),
CONSTRAINT PK_alu_know PRIMARY KEY (nroinscripcion,anioingreso)
)
GO

CREATE TABLE notas
(
nroinscripcion smallint not null,
anioingreso smallint not null,
codmateria tinyint not null REFERENCES materias(codmateria),
anio smallint not null,
etapa tinyint not null,
evaluacion char(1) not null  CHECK (evaluacion IN ('R','F','D')),
fecha smalldatetime not null,
nota tinyint not null
)
GO

CREATE TABLE pl_asist_de
(
nroplanilla integer not null REFERENCES pl_asist_ca(nroplanilla),
nroclase tinyint not null,
fechaclase smalldatetime not null,
nroinscripcion smallint not null,
anioingreso smallint not null,
asistencia char(1) not null CHECK (asistencia IN ('P','A','T','V'))
)
GO

CREATE TABLE materiasxalumno
(
nroinscripcion smallint not null,
anioingreso smallint not null,
codmateria tinyint not null,
anio smallint,
cuatrimestre tinyint,
estado char(1) not null CHECK (estado IN ('P','C','A','F','R','B','D'))
)
GO

-- .:ESTADOS:.
-- P - Pendiente
-- C - Cursando
-- A - Aprobada
-- F - Final
-- R - Recursa
-- B - Abandono
-- D - Diagnóstico
-- T - Recuperatorio

CREATE TABLE bajasalumnos
(
nroinscripcion smallint not null,
anioingreso smallint not null,
fecha smalldatetime not null,
motivos varchar(512)
CONSTRAINT PK_alu_nrobaj PRIMARY KEY (nroinscripcion,anioingreso)
)
GO

CREATE TABLE bajasalumnosxmotivos
(
nroinscripcion smallint not null,
anioingreso smallint not null,
nromotivo tinyint not null
)
GO

CREATE TABLE correlativas_cursada
(
codmateria tinyint not null REFERENCES materias(codmateria),
codcorrelativa tinyint not null REFERENCES materias(codmateria)
)
GO

CREATE TABLE correlativas_aprobada
(
codmateria tinyint not null REFERENCES materias(codmateria),
codcorrelativa  tinyint not null REFERENCES materias(codmateria)
)
GO

CREATE TABLE correlativas_final
(
codmateria tinyint not null REFERENCES materias(codmateria),
codcorrelativa  tinyint not null REFERENCES materias(codmateria)
)
GO

CREATE TABLE instancias
(
anio smallint not null,
nroinstancia tinyint not null,
mes tinyint not null
)
GO