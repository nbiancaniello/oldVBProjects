--*************************************************************************************************************************************************************************
--************************************************************ QUERIES DE ACCIÓN Y CONSULTA *******************************************************************************
--*************************************************************************************************************************************************************************

CREATE PROCEDURE registrar_errores
@fechayhora datetime,
@modulo varchar(15),
@mensaje varchar (511),
@usuario varchar(20)
AS
INSERT INTO logerrores
VALUES (@fechayhora,@modulo,@mensaje,@usuario)
GO

CREATE PROCEDURE traer_alumnos_por_carrera
@car tinyint
AS
SELECT nroinscripcion, anioingreso, apellido, nombre
  FROM alumnos
 WHERE codcarrera = @car
 ORDER BY nroinscripcion, anioingreso
GO

CREATE PROCEDURE traer_datos_personales_alumno
@nro smallint,
@anio smallint
AS
SELECT nombre,apellido,legajo,domicilio,codpos,fechanac,sexo,tipodoc,nrodoc,nacionalidad,telefono,celular,email,codcarrera,etapa,activo
  FROM alumnos
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE traer_legajo
@nro smallint,
@anio smallint
AS
SELECT legajo
  FROM alumnos
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE traer_datos_personales_detalles_alumno
@nro smallint,
@anio smallint
AS
SELECT lugarnac,titulosecundario,nombrecolegio,estadocivil,hijos,cantidadhijos,trabaja,cargahoraria,relaciontrabajo
  FROM alumnosdetalles INNER JOIN alumnos
    ON alumnosdetalles.nroinscripcion = alumnos.nroinscripcion
   AND alumnosdetalles.anioingreso = alumnos.anioingreso
 WHERE alumnosdetalles.nroinscripcion = @nro
   AND alumnosdetalles.anioingreso = @anio
GO

CREATE PROCEDURE traer_dp_alumno_baja
@nro smallint,
@anio smallint
AS
SELECT alu.nombre,alu.apellido,alu.legajo, alu.domicilio,loc.descripcion,tip.descripcion,alu.nrodoc,nac.descripcion
  FROM alumnos alu INNER JOIN localidades loc
    ON alu.codpos = loc.codpos
 INNER JOIN tipodocumentos tip
    ON alu.tipodoc = tip.tipodoc
 INNER JOIN nacionalidades nac
    ON alu.nacionalidad = nac.nacionalidad
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE traer_localidades
AS
SELECT codpos, descripcion
  FROM localidades
 WHERE codpos <> 1000
GO

CREATE PROCEDURE traer_tipo_documentos
AS
SELECT tipodoc, descripcion
  FROM tipodocumentos
GO

CREATE PROCEDURE traer_nacionalidades
AS
SELECT nacionalidad, descripcion
  FROM nacionalidades
 WHERE nacionalidad <> 255
GO

CREATE PROCEDURE traer_estados_civiles
AS
SELECT estadocivil, descripcion
  FROM estadosciviles
GO

CREATE PROCEDURE traer_lugares_nacimiento
AS
SELECT lugarnac, descripcion
  FROM lugaresnacimiento
 WHERE lugarnac <> 255
GO

CREATE PROCEDURE traer_titulos
AS
SELECT titulo, descripcion
  FROM titulos
 WHERE titulo <> 255
GO

CREATE PROCEDURE traer_relaciones_trabajo
AS
SELECT relaciontrabajo, descripcion
  FROM relacionestrabajo
GO

CREATE PROCEDURE actualizar_datos_personales_alumno_introductorio
@nro smallint,
@anio smallint,
@leg smallint,
@nom varchar(20),
@ape varchar(30),
@dom varchar(50),
@cp smallint,
@fec smalldatetime,
@sexo char(1),
@tip tinyint,
@doc integer,
@nac tinyint,
@tel varchar(20),
@cel varchar(20),
@mail varchar(60),
@lug tinyint,
@tit tinyint,
@col varchar(50),
@civ tinyint,
@hij bit,
@cth tinyint,
@tra bit,
@car tinyint,
@rel tinyint,
@carr tinyint
AS
UPDATE alumnos
   SET legajo = @leg,
       nombre = @nom,
       apellido = @ape,
       domicilio = @dom,
       codpos = @cp,
       sexo = @sexo,
       fechanac = @fec,
       tipodoc = @tip,
       nrodoc = @doc,
       nacionalidad = @nac,
       telefono = @tel,
       celular = @cel,
       email = @mail,
       codcarrera = @carr
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
UPDATE alumnosdetalles
   SET lugarnac = @lug,
       titulosecundario = @tit,
       nombrecolegio = @col,
       estadocivil =  @civ,
       hijos = @hij,
       cantidadhijos = @cth,
       trabaja = @tra,
       cargahoraria = @car,
       relaciontrabajo = @rel
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE actualizar_datos_personales_alumno
@nro smallint,
@anio smallint,
@leg smallint,
@nom varchar(20),
@ape varchar(30),
@dom varchar(50),
@cp smallint,
@fec smalldatetime,
@sexo char(1),
@tip tinyint,
@doc integer,
@nac tinyint,
@tel varchar(20),
@cel varchar(20),
@mail varchar(60),
@lug tinyint,
@tit tinyint,
@col varchar(50),
@civ tinyint,
@hij bit,
@cth tinyint,
@tra bit,
@car tinyint,
@rel tinyint,
@carr tinyint,
@cuat tinyint
AS
UPDATE alumnos
   SET legajo = @leg,
       nombre = @nom,
       apellido = @ape,
       domicilio = @dom,
       codpos = @cp,
       sexo = @sexo,
       fechanac = @fec,
       tipodoc = @tip,
       nrodoc = @doc,
       nacionalidad = @nac,
       telefono = @tel,
       celular = @cel,
       email = @mail,
       codcarrera = @carr
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
UPDATE alumnosdetalles
   SET lugarnac = @lug,
       titulosecundario = @tit,
       nombrecolegio = @col,
       estadocivil =  @civ,
       hijos = @hij,
       cantidadhijos = @cth,
       trabaja = @tra,
       cargahoraria = @car,
       relaciontrabajo = @rel
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE registrar_alumno
@nro smallint,
@anio smallint,
@nom varchar(20),
@ape varchar(30),
@dom varchar(50),
@cp smallint,
@fec smalldatetime,
@sexo char(1),
@tip tinyint,
@doc integer,
@nac tinyint,
@tel varchar(20),
@cel varchar(20),
@mail varchar(60),
@lug tinyint,
@tit tinyint,
@col varchar(50),
@civ tinyint,
@hij bit,
@cth tinyint,
@tra bit,
@car tinyint,
@rel tinyint,
@eta tinyint
AS
INSERT INTO alumnos 
VALUES (@nro,@anio,@nom,@ape,@dom,@cp,@tel,@cel,@mail,@sexo,@fec,@tip,@doc,@nac,NULL,0,@eta,getdate(),1)
INSERT INTO alumnosdetalles
VALUES (@nro,@anio,@lug,@tit,@col,@civ,@hij,@cth,@tra,@car,@rel)
GO

CREATE PROCEDURE actualizar_legajo_alumno
@nro smallint,
@leg smallint,
@anio smallint
AS
UPDATE alumnos
   SET legajo = @leg
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO 

CREATE PROCEDURE traer_alumnos_para_eliminar
AS
SELECT nroinscripcion, apellido, nombre
  FROM alumnos
 WHERE activo = 1
 ORDER BY nroinscripcion
GO

CREATE PROCEDURE traer_ultimo_nro_inscripcion
@anio smallint
AS
SELECT MAX(nroinscripcion) + 1
  FROM alumnos
 WHERE anioingreso = @anio 
GO

CREATE PROCEDURE dar_baja_alumno
@nro smallint,
@anio smallint,
@mot varchar(512)
AS
INSERT INTO bajasalumnos
VALUES(@nro,@anio,getdate(),@mot)
GO

CREATE PROCEDURE dar_baja_alumnoxmotivo
@nro smallint,
@anio smallint,
@mot tinyint
AS
INSERT INTO bajasalumnosxmotivos
VALUES (@nro,@anio,@mot)
GO

CREATE PROCEDURE inactivar_alumno
@nro smallint,
@anio smallint
AS
UPDATE alumnos
   SET activo = 0
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE traer_motivo_baja_alumno
@nro smallint,
@anio smallint
AS
SELECT motivos
  FROM bajasalumnos
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE traer_items_motivo_baja_alumno
@nro smallint,
@anio smallint
AS
SELECT nromotivo
  FROM bajasalumnosxmotivos
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE traer_profesores
@tipo char(1)
AS
SELECT codprofesor, apellido, nombre
  FROM profesores
 WHERE tipo = @tipo
ORDER BY codprofesor
GO

CREATE PROCEDURE traer_docentes
AS
SELECT codprofesor, apellido, nombre
  FROM profesores
ORDER BY codprofesor
GO

CREATE PROCEDURE traer_datos_personales_profesores
@cod smallint
AS
SELECT nombre,apellido,domicilio,codpos,fechanac,sexo,tipodoc,nrodoc,nacionalidad,telefono,celular,email,titulo,activo
  FROM profesores
 WHERE codprofesor = @cod
GO

CREATE PROCEDURE traer_dp_docente_baja
@cod smallint
AS
SELECT p.nombre,p.apellido,p.domicilio,loc.localidad,tip.descripcion,p.nrodoc,nac.descripcion, p.tipo
  FROM profesores p INNER JOIN localidades loc
    ON p.codpos = loc.codpos
 INNER JOIN tipodocumentos tip
    ON p.tipodoc = tip.tipodoc
 INNER JOIN nacionalidades nac
    ON p.nacionalidad = nac.nacionalidad
 WHERE codprofesor = @cod
GO

CREATE PROCEDURE traer_docentes_para_eliminar
AS
SELECT codprofesor, apellido, nombre
  FROM profesores
 WHERE activo = 1
 ORDER BY codprofesor
GO

CREATE PROCEDURE inactivar_docente
@cod smallint
AS
UPDATE profesores
   SET activo = 0
 WHERE codprofesor = @cod
GO

CREATE PROCEDURE actualizar_datos_profesores
@nro smallint,
@nom varchar(20),
@ape varchar(30),
@dom varchar(50),
@cp smallint,
@fec smalldatetime,
@sexo char(1),
@tip tinyint,
@doc integer,
@nac tinyint,
@tel varchar(20),
@cel varchar(20),
@mail varchar(60),
@tit tinyint
AS
UPDATE profesores
   SET nombre = @nom,
       apellido = @ape,
       domicilio = @dom,
       codpos = @cp,
       sexo = @sexo,
       fechanac = @fec,
       tipodoc = @tip,
       nrodoc = @doc,
       nacionalidad = @nac,
       telefono = @tel,
       celular = @cel,
       email = @mail,
       titulo = @tit
 WHERE codprofesor = @nro
GO

CREATE PROCEDURE traer_materias_por_alumno
@nro smallint,
@anio smallint,
@carr tinyint
AS
SELECT mat.codmateria, mat.nombremateria, mxa.cuatrimestre, mxa.anio, mxa.estado
  FROM materias mat INNER JOIN materiasxalumno mxa
    ON mat.codmateria = mxa.codmateria
 WHERE mxa.nroinscripcion = @nro
   AND mxa.anioingreso = @anio
   AND mat.codcarrera = @carr
ORDER BY mat.codmateria
GO

SELECT mat.codmateria, mat.nombremateria, mxa.cuatrimestre, mxa.anio, mxa.estado
  FROM materias mat INNER JOIN materiasxalumno mxa
    ON mat.codmateria = mxa.codmateria
 WHERE mxa.nroinscripcion = 1
GO

CREATE PROCEDURE traer_notas_tps
@nro smallint,
@anio smallint,
@cod tinyint
AS
SELECT nrotp, fechatp, notatp, tipotp
  FROM tps
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
   AND codmateria = @cod
GO

CREATE PROCEDURE traer_notas_parciales
@nro smallint,
@anio smallint,
@cod tinyint
AS
SELECT nroparcial, fechaparcial, notaparcial, tipoparcial
  FROM parciales
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
   AND codmateria = @cod
GO

CREATE PROCEDURE traer_notas_finales
@nro smallint,
@anio smallint,
@cod tinyint
AS
SELECT nrofinal, fechafinal, notafinal, nrolibro, nrofolio
  FROM finales
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
   AND codmateria = @cod
GO

CREATE PROCEDURE traer_ultimo_codigo_profesor
AS
SELECT MAX(codprofesor) + 1
  FROM profesores
GO

CREATE PROCEDURE registrar_profesor
@nro smallint,
@nom varchar(20),
@ape varchar(30),
@dom varchar(50),
@cp smallint,
@fec smalldatetime,
@sexo char(1),
@tip tinyint,
@doc integer,
@nac tinyint,
@tel varchar(20),
@cel varchar(20),
@mail varchar(60),
@tit tinyint,
@tipo char(1)
AS
INSERT INTO profesores
VALUES (@nro,@nom,@ape,@dom,@cp,@tel,@cel,@mail,@sexo,@fec,@tip,@doc,@nac,@tit,1,@tipo)
GO

CREATE PROCEDURE cambiar_password
@usu varchar(20),
@new varchar(15)
AS
UPDATE usuarios
   SET pass = @new
 WHERE usuario = @usu
GO

CREATE PROCEDURE registrar_usuario
@usu varchar(20),
@pass varchar(15),
@tipo char(1)
AS
INSERT INTO usuarios
VALUES (@usu,@pass,@tipo)
GO

CREATE PROCEDURE eliminar_usuario
@usu varchar(20)
AS
DELETE FROM usuarios
 WHERE usuario = @usu
GO

CREATE PROCEDURE cambiar_permiso
@usu varchar(20),
@tipo char(1)
AS
UPDATE usuarios
   SET tipopermiso = @tipo
 WHERE usuario = @usu
GO

CREATE PROCEDURE traer_materias_cabecera_tsp
@car tinyint
AS
SELECT codmateria, nombremateria
  FROM materias
 WHERE codcarrera = @car
   AND cuatrimestre > 1
GO

CREATE PROCEDURE traer_materias_correlativas_cursada
@cod tinyint
AS
SELECT cor.codcorrelativa, mat.nombremateria
  FROM materias mat INNER JOIN correlativas_cursada cor
    ON mat.codmateria = cor.codcorrelativa
 WHERE cor.codmateria = @cod
GO

CREATE PROCEDURE traer_materias_correlativas_aprobada
@cod tinyint
AS
SELECT cor.codcorrelativa, mat.nombremateria
  FROM materias mat INNER JOIN correlativas_aprobada cor
    ON mat.codmateria = cor.codcorrelativa
 WHERE cor.codmateria = @cod
GO

CREATE PROCEDURE traer_materias_correlativas_final
@cod tinyint
AS
SELECT cor.codcorrelativa, mat.nombremateria
  FROM materias mat INNER JOIN correlativas_final cor
    ON mat.codmateria = cor.codcorrelativa
 WHERE cor.codmateria = @cod
GO

CREATE PROCEDURE traer_materias_disp_cor_tsp
@cod tinyint
AS
SELECT codmateria, nombremateria
  FROM materias
 WHERE cuatrimestre < (SELECT cuatrimestre
                         FROM materias
                        WHERE codmateria = @cod)
   AND cuatrimestre <> 0
   AND codcarrera = 1
GO

CREATE PROCEDURE asignar_correlativa_cursada
@cod tinyint,
@cor tinyint
AS
INSERT INTO correlativas_cursada
VALUES (@cod,@cor)
GO

CREATE PROCEDURE asignar_correlativa_aprobada
@cod tinyint,
@cor tinyint
AS
INSERT INTO correlativas_aprobada
VALUES (@cod,@cor)
GO

CREATE PROCEDURE asignar_correlativa_final
@cod tinyint,
@cor tinyint
AS
INSERT INTO correlativas_final
VALUES (@cod,@cor)
GO

CREATE PROCEDURE traer_materias_por_anio_cuatrimestre
@anio smallint,
@cuat tinyint,
@carr tinyint
AS
SELECT pla.nroplanilla, pla.codmateria, mat.nombremateria, pla.estado
  FROM pl_asist_ca pla INNER JOIN materias mat
    ON pla.codmateria = mat.codmateria
 WHERE pla.anio = @anio
   AND pla.cuatrimestre = @cuat
   AND mat.codcarrera = @carr
GO

CREATE PROCEDURE traer_cabecera_planilla
@nro integer
AS
SELECT pro.nombre, pro.apellido, pla.curso, pla.comision, pla.dia, pla.diados
  FROM pl_asist_ca pla INNER JOIN profesores pro
    ON pla.codprofesor = pro.codprofesor
 WHERE pla.nroplanilla = @nro
GO

CREATE PROCEDURE devolver_nroinscripcion_por_legajo
@leg smallint
AS
SELECT nroinscripcion
  FROM legajos
 WHERE legajo = @leg
GO

CREATE PROCEDURE verificar_fecha_repetida_planilla
@nro integer,
@fec smalldatetime
AS
SELECT COUNT(nroplanilla) 
  FROM pl_asist_de
 WHERE nroplanilla = @nro 
   AND fechaclase = @fec
GO

CREATE PROCEDURE traer_ultimo_nro_planilla
AS
SELECT MAX(nroplanilla) + 1
  FROM pl_asist_ca
GO

CREATE PROCEDURE traer_materias
AS
SELECT codmateria, nombremateria
  FROM materias
 ORDER BY codcarrera
GO

CREATE PROCEDURE traer_lista_profesores
AS
SELECT codprofesor, (apellido + ', ' + nombre) as razonsocial
  FROM profesores
 WHERE tipo = 'P'
GO

CREATE PROCEDURE generar_nueva_planilla
@nro integer,
@cod tinyint,
@pro tinyint,
@cur char(6),
@com tinyint,
@anio smallint,
@cuat tinyint,
@dia tinyint,
@diados tinyint,
@est char(1),
@obl char(1)
AS
INSERT INTO pl_asist_ca
VALUES(@nro,@cod,@pro,@cur,@com,@anio,@cuat,@dia,@diados,@est,@obl)
GO

CREATE PROCEDURE traer_cabecera_planilla_seleccionada
@nro integer
AS
SELECT codmateria,codprofesor,curso,comision,anio,cuatrimestre,dia,diados,estado, sen_obligatorio
  FROM pl_asist_ca
 WHERE nroplanilla = @nro
GO

CREATE PROCEDURE traer_nroplanillas
AS
SELECT nroplanilla
  FROM pl_asist_ca
GO

CREATE PROCEDURE actualizar_cursada_por_alumno
@cod tinyint,
@anio smallint,
@cuat tinyint,
@est char(1)
AS
UPDATE materiasxalumno
   SET estado = @est
 WHERE codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
   --AND estado IN('P')
GO

CREATE PROCEDURE traer_materias_disponibles_por_alumno_alta
@nro smallint,
@anio smallint,
@car tinyint
AS
SELECT ma.codmateria, ma.nombremateria
  FROM materias ma
 WHERE ma.codmateria NOT IN (SELECT codmateria
                               FROM materiasxalumno
                              WHERE codmateria = ma.codmateria
                                AND nroinscripcion = @nro
                                AND anioingreso = @anio
                                AND estado NOT IN ('R'))
   AND ma.codcarrera = @car
 ORDER BY ma.nombremateria
GO

CREATE PROCEDURE traer_materias_disponibles_por_alumno_baja
@nro smallint,
@anio smallint,
@car tinyint
AS
SELECT ma.codmateria, ma.nombremateria
  FROM materias ma
 WHERE ma.codmateria IN (SELECT codmateria
                           FROM materiasxalumno
                          WHERE codmateria = ma.codmateria
                            AND nroinscripcion = @nro
                            AND anioingreso = @anio
                            AND estado IN ('P','C'))
   AND ma.codcarrera = @car
 ORDER BY ma.nombremateria
GO

CREATE PROCEDURE actualizar_alumno_por_materia
@cod tinyint,
@ing smallint,
@nro smallint,
@anio smallint,
@cuat tinyint,
@est char(1)
AS
INSERT INTO materiasxalumno
VALUES(@nro,@ing,@cod,@anio,@cuat,@est)
GO

--CREATE PROCEDURE registrar_legajo
--@nro smallint,
--@leg smallint,
--@anio smallint,
--@car tinyint
--AS
--INSERT INTO legajos
--VALUES(@nro,@leg,@anio,@car)
--GO

CREATE PROCEDURE verificar_existencia_planilla
@cod tinyint,
@anio smallint,
@cuat tinyint
AS
SELECT COUNT(nroplanilla)
  FROM pl_asist_ca
 WHERE codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
GO

CREATE PROCEDURE buscar_legajo
@leg smallint
AS
SELECT COUNT(legajo)
  FROM alumnos
 WHERE legajo = @leg
GO

-- Se necesita actualizar para implementar nueva tabla
--CREATE PROCEDURE dar_baja_alumno_por_materia
--@nro smallint
--AS
--UPDATE materiasxalumno
--   SET estado = 'B'
-- WHERE nroinscripcion = @nro
--   AND estado NOT IN ('A','F','R')
--GO

--CREATE PROCEDURE verificar_introductorio_aprobado
--@nro smallint
--AS
--SELECT COUNT(mxa.nroinscripcion)
--  FROM materiasxalumno mxa INNER JOIN materias mat
--    ON mat.codmateria = mxa.codmateria
-- WHERE mat.nombremateria LIKE 'INTRODUCTORIO %'
--   AND mxa.nroinscripcion = @nro
--   AND mxa.estado = 'A'
--GO

CREATE PROCEDURE verificar_introductorio_aprobado
@nro smallint,
@anio smallint
AS
SELECT COUNT(mxa.nroinscripcion)
  FROM materiasxalumno mxa INNER JOIN materias mat
    ON mat.codmateria = mxa.codmateria
 WHERE mat.codcarrera = 0
   AND mxa.nroinscripcion = @nro
   AND mxa.anioingreso = @anio
   AND mxa.estado = 'A'
GO

CREATE PROCEDURE verificar_cantidad_alumnos_inscriptos_a_materia
@cod smallint,
@anio smallint,
@cuat tinyint
AS
SELECT COUNT(nroinscripcion)
  FROM materiasxalumno
 WHERE codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
GO

CREATE PROCEDURE traer_materias_introductorio
AS
SELECT codmateria, nombremateria
  FROM materias
 WHERE codcarrera = 0
 ORDER BY codcarrera 
GO

CREATE PROCEDURE traer_materias_tsp
AS
SELECT codmateria, nombremateria
  FROM materias
 WHERE codcarrera = 1
 ORDER BY codcarrera 
GO

CREATE PROCEDURE traer_materias_tssi
AS
SELECT codmateria, nombremateria
  FROM materias
 WHERE codcarrera = 2
GO

CREATE PROCEDURE verificar_carrera_aprobada
@nro smallint,
@car tinyint
AS
SELECT COUNT(mxa.nroinscripcion)
  FROM materiasxalumno mxa INNER JOIN materias mat
    ON mat.codmateria = mxa.codmateria
 WHERE mat.codcarrera = @car
   AND mxa.nroinscripcion = @nro
   AND mxa.estado = 'A'
GO

CREATE PROCEDURE traer_alumno_cursante
@nro integer
AS
SELECT mat.nroinscripcion, de.nroclase, de.fechaclase
  FROM pl_asist_ca ca INNER JOIN pl_asist_de de
    ON ca.nroplanilla = de.nroplanilla 
 INNER JOIN materiasxalumno mat
    ON mat.codmateria = ca.codmateria
 WHERE ca.nroplanilla = @nro
   AND mat.estado = 'C'
   AND mat.nroinscripcion NOT IN (SELECT nroinscripcion
                                     FROM pl_asist_de 
                                   WHERE nroinscripcion = mat.nroinscripcion)
GO

CREATE PROCEDURE traer_carreras
AS
SELECT codcarrera, descripcion
  FROM carreras
GO

--------------

CREATE PROCEDURE traer_ultimo_estado_correlativa
@nro smallint,
@cod tinyint
AS
SELECT TOP 1 estado
  FROM materiasxalumno
 WHERE codmateria = @cod
   AND nroinscripcion = @nro
 ORDER BY anio, cuatrimestre desc
GO

CREATE PROCEDURE traer_alumnos_activos_por_carrera
@car tinyint
AS
SELECT nroinscripcion, anioingreso, apellido, nombre, codcarrera
  FROM alumnos
 WHERE codcarrera = @car
   AND activo = 1
GO

CREATE PROCEDURE bajar_alumno_de_materia
@nro smallint,
@anio smallint,
@cod tinyint
AS
DELETE FROM materiasxalumno
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
   AND codmateria = @cod
   AND estado IN ('P','C')
GO

CREATE PROCEDURE traer_alumnos_planilla_asistencia
@nro integer
AS
SELECT alu.nroinscripcion, alu.anioingreso, alu.nombre, alu.apellido
  FROM alumnos alu INNER JOIN materiasxalumno mat
    ON mat.nroinscripcion = alu.nroinscripcion
   AND mat.anioingreso = alu.anioingreso
 INNER JOIN pl_asist_ca ca
    ON mat.codmateria = ca.codmateria
 WHERE ca.nroplanilla = @nro
   AND ca.anio = mat.anio
   AND mat.cuatrimestre =  ca.cuatrimestre
   AND alu.activo = 1
   --AND mat.estado IN ('P','C')
 ORDER BY alu.apellido, alu.nombre
GO

CREATE PROCEDURE traer_fechas_detalle_planillas
@nro integer
AS
SELECT DISTINCT(de.fechaclase)
  FROM pl_asist_de de
 WHERE nroplanilla = @nro
GO

CREATE PROCEDURE traer_asistencias_por_planilla
@nro integer,
@ins smallint,
@anio smallint
AS
SELECT de.asistencia
  FROM pl_asist_de de INNER JOIN alumnos alu
    ON de.nroinscripcion = alu.nroinscripcion 
   AND de.anioingreso = alu.anioingreso
 WHERE de.nroplanilla = @nro
   AND de.nroinscripcion = @ins
   AND de.anioingreso = @anio
 ORDER BY de.nroclase
GO

CREATE PROCEDURE insertar_detalles_en_planilla
@nro smallint,
@cla tinyint,
@fec smalldatetime,
@alu smallint,
@anio smallint,
@est char(1)
AS
INSERT INTO pl_asist_de
VALUES(@nro,@cla,@fec,@alu,@anio,@est)
GO

CREATE PROCEDURE agregar_nota_tp
@nro smallint,
@ain smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint,
@fec smalldatetime,
@not tinyint,
@tip char(1)
AS
INSERT INTO tps
VALUES(@nro,@ain,@cod,@anio,@cuat,@num,@fec,@not,@tip)
GO

CREATE PROCEDURE agregar_nota_final
@nro smallint,
@ain smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint,
@fec smalldatetime,
@not tinyint,
@lib smallint,
@fol smallint
AS
INSERT INTO finales
VALUES(@nro,@ain,@cod,@anio,@cuat,@num,@fec,@not,@lib,@fol)
GO

CREATE PROCEDURE agregar_nota_parcial
@nro smallint,
@ain smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint,
@fec smalldatetime,
@not tinyint,
@tip char(1)
AS
INSERT INTO parciales
VALUES(@nro,@ain,@cod,@anio,@cuat,@num,@fec,@not,@tip)
GO

CREATE PROCEDURE modificar_nota_tp
@nro smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint,
@fec smalldatetime,
@not tinyint,
@tip char(1)
AS
UPDATE tps
   SET nrotp = @num,
       fechatp = @fec,
       notatp = @not,
       tipotp = @tip
 WHERE nroinscripcion = @nro
   AND codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
GO

CREATE PROCEDURE modificar_nota_parcial
@nro smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint,
@fec smalldatetime,
@not tinyint,
@tip char(1)
AS
UPDATE parciales
   SET nroparcial = @num,
       fechaparcial = @fec,
       notaparcial = @not,
       tipoparcial = @tip
 WHERE nroinscripcion = @nro
   AND codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
GO

CREATE PROCEDURE modificar_nota_final
@nro smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint,
@fec smalldatetime,
@not tinyint,
@lib smallint,
@fol smallint
AS
UPDATE finales
   SET nrofinal = @num,
       fechafinal = @fec,
       notafinal = @not,
       nrolibro = @lib,
       nrofolio = @fol
 WHERE nroinscripcion = @nro
   AND codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
GO

CREATE PROCEDURE eliminar_nota_tp
@nro smallint,
@ing smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint
AS
DELETE FROM tps
 WHERE nroinscripcion = @nro
   AND anioingreso = @ing
   AND codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
   AND nrotp = @num
GO

CREATE PROCEDURE eliminar_nota_parcial
@nro smallint,
@ing smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint
AS
DELETE FROM parciales
 WHERE nroinscripcion = @nro
   AND anioingreso = @ing
   AND codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
   AND nroparcial = @num
GO

CREATE PROCEDURE eliminar_nota_final
@nro smallint,
@ing smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@num tinyint
AS
DELETE FROM finales
 WHERE nroinscripcion = @nro
   AND anioingreso = @ing
   AND codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
   AND nrofinal = @num
GO

CREATE PROCEDURE actualizar_estado_materia_por_alumno
@nro smallint,
@ing smallint,
@cod tinyint,
@anio smallint,
@cuat tinyint,
@est char(1)
AS
UPDATE materiasxalumno
   SET estado = @est
 WHERE nroinscripcion = @nro
   AND anioingreso = @ing
   AND codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
GO

CREATE PROCEDURE llenar_planilla_asistencia
@nro smallint,
@ing smallint,
@anio smallint
AS
DECLARE @fec smalldatetime
DECLARE @cla tinyint

DECLARE c_cursor CURSOR FOR
 SELECT fechaclase, nroclase
   FROM pl_asist_de
  WHERE nroplanilla = @nro
 GROUP BY fechaclase, nroclase

OPEN c_cursor

FETCH NEXT FROM c_cursor INTO @fec, @cla

WHILE (@@FETCH_STATUS = 0)
BEGIN
INSERT INTO pl_asist_de VALUES (@nro,@cla,@fec,@ing,@anio,'A')
FETCH FROM c_cursor INTO @fec, @cla
END
CLOSE c_cursor

DEALLOCATE c_cursor
GO

CREATE PROCEDURE traer_numero_planilla
@cod tinyint,
@anio smallint,
@cuat tinyint
AS
SELECT nroplanilla
  FROM pl_asist_ca
 WHERE codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @cuat
GO

CREATE PROCEDURE asignar_introductorio
@nro smallint,
@ing smallint,
@anio smallint,
@eta tinyint,
@est char(1)
AS
DECLARE @var tinyint
DECLARE @cant tinyint
DECLARE c_cursor CURSOR FOR 
 SELECT COUNT(codmateria) 
   FROM materias 
  WHERE codcarrera = 0

SET @var = 1

OPEN c_cursor

FETCH NEXT FROM c_cursor INTO @cant

CLOSE c_cursor

DEALLOCATE c_cursor

WHILE @var <= @cant
BEGIN
   INSERT INTO materiasxalumno
   VALUES(@nro,@ing,@var,@anio,@eta,@est)
   SET @var = @var + 1
   IF (@var) > @cant
      BREAK
   ELSE
      CONTINUE
END
GO

CREATE PROCEDURE verificar_estado_introductorio
@nro smallint,
@anio smallint
AS
SELECT COUNT(mxa.codmateria)
  FROM materiasxalumno mxa
 INNER JOIN materias mat
    ON mat.codmateria = mxa.codmateria
 WHERE mxa.estado IN ('A')
   AND mat.codcarrera = 0
   AND mxa.nroinscripcion = @nro
   AND mxa.anioingreso = @anio
GO

CREATE PROCEDURE inscripcion_primer_cuatrimestre
@nro smallint,
@ing smallint,
@anio smallint,
@cuat tinyint
AS
DECLARE @mat tinyint

DECLARE c_cursor CURSOR FOR
 SELECT codmateria
   FROM materias
  WHERE codcarrera = 1
    AND anio = 1
    AND cuatrimestre = 1

OPEN c_cursor

FETCH NEXT FROM c_cursor INTO @mat

WHILE (@@FETCH_STATUS = 0)
BEGIN
INSERT INTO materiasxalumno VALUES (@nro,@ing,@mat,@anio,@cuat,'P')
FETCH FROM c_cursor INTO @mat
END
CLOSE c_cursor

DEALLOCATE c_cursor

DECLARE @carr tinyint

SET @carr = (
SELECT codcarrera
  FROM alumnos
 WHERE nroinscripcion = @nro
   AND anioingreso = @ing)

IF @carr = 0 
BEGIN
UPDATE alumnos 
   SET codcarrera = 1
 WHERE nroinscripcion = @nro
   AND anioingreso = @ing
END
GO

CREATE PROCEDURE traer_conocimientos_alumnos
@nro smallint,
@anio smallint
AS
SELECT codigo1, codigo2, codigo3, codigo4, codigo5, codigo6, codigo7, codigo8
  FROM conocimientos_alumnos
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE traer_planillas_abiertas
@carr tinyint
AS
SELECT ca.nroplanilla, ca.anio, ca.cuatrimestre, mat.nombremateria, mat.codmateria
  FROM pl_asist_ca ca INNER JOIN materias mat
    ON ca.codmateria = mat.codmateria
 WHERE ca.estado = 'A'
   AND mat.codcarrera = @carr
GO

CREATE PROCEDURE traer_planillas_abiertas_introductorio
AS
SELECT ca.nroplanilla, ca.anio, i.mes, mat.nombremateria, mat.codmateria
  FROM pl_asist_ca ca INNER JOIN materias mat
    ON ca.codmateria = mat.codmateria
 INNER JOIN instancias i
    ON i.anio = ca.anio
   AND i.nroinstancia = ca.cuatrimestre
 WHERE ca.estado = 'A'
   AND mat.codcarrera = 0
 ORDER BY ca.nroplanilla
GO

drop procedure traer_planillas_abiertas

CREATE PROCEDURE traer_nombre_materia
@cod tinyint
AS
SELECT nombremateria
  FROM materias
 WHERE codmateria = @cod
GO

CREATE PROCEDURE traer_alumnos_por_busqueda
@alu varchar(30)
AS
SELECT nroinscripcion, anioingreso, apellido, nombre, codcarrera
  FROM alumnos
 WHERE apellido LIKE @alu
GO

CREATE PROCEDURE traer_alumnos_introductorio_filtro1
@anio smallint,
@eta tinyint
AS
SELECT alu.nroinscripcion, alu.anioingreso, alu.apellido, alu.nombre
  FROM alumnos alu INNER JOIN materiasxalumno mxa
    ON alu.nroinscripcion = mxa.nroinscripcion
   AND alu.anioingreso = mxa.anioingreso
 WHERE mxa.anio = @anio
   AND mxa.cuatrimestre = @eta
   AND alu.codcarrera = 0
   AND alu.activo = 1
 GROUP BY alu.nroinscripcion, alu.anioingreso, alu.apellido, alu.nombre
GO

CREATE PROCEDURE traer_info_notas_introductorio
@nro smallint,
@ing smallint,
@cod tinyint,
@anio smallint,
@eta tinyint
AS
SELECT fecha, nota, evaluacion
  FROM notas_introductorio
 WHERE nroinscripcion = @nro
   AND anioingreso = @ing
   AND codmateria = @cod
   AND anio = @anio
   AND etapa = @eta
 ORDER BY evaluacion
GO

CREATE PROCEDURE asignar_nota_introductorio
@nro smallint,
@ing smallint,
@cod tinyint,
@anio smallint,
@eta tinyint,
@eva char(1),
@nota tinyint
AS
INSERT INTO notas_introductorio
VALUES (@nro,@ing,@cod,@anio,@eta,@eva,getdate(),@nota)
GO

CREATE PROCEDURE actualizar_estado_introductorio
@nro smallint,
@ing smallint,
@cod tinyint,
@anio smallint,
@eta tinyint,
@est char(1)
AS
UPDATE materiasxalumno
   SET estado = @est
 WHERE nroinscripcion = @nro
   AND anioingreso = @ing
   AND codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @eta
GO

CREATE PROCEDURE traer_cantidad_materias_por_etapa
@carr tinyint
AS
SELECT COUNT(codmateria)
  FROM materias
 WHERE codcarrera = @carr
GO

CREATE PROCEDURE traer_instancias_anio
@anio smallint
AS
SELECT nroinstancia, mes
  FROM instancias
 WHERE anio = @anio
GO

CREATE PROCEDURE registrar_instancia
@anio smallint,
@inst tinyint,
@mes tinyint
AS
INSERT INTO instancias
VALUES(@anio,@inst,@mes)
GO

CREATE PROCEDURE modificar_instancia
@anio smallint,
@inst tinyint,
@mes tinyint
AS
UPDATE instancias
   SET mes = @mes
 WHERE anio = @anio
   AND nroinstancia = @inst
GO

CREATE PROCEDURE eliminar_instancia
@anio smallint,
@inst tinyint
AS
DELETE FROM instancias
 WHERE anio = @anio
   AND nroinstancia = @inst
GO

CREATE PROCEDURE almacenar_documentaciones
@nro smallint,
@anio smallint,
@doc1 bit,
@doc2 bit,
@doc3 bit
AS
DELETE FROM documentaciones
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
INSERT INTO documentaciones
VALUES (@nro,@anio,@doc1,@doc2,@doc3)
GO

CREATE PROCEDURE traer_documentaciones
@nro smallint,
@anio smallint
AS
SELECT doc1, doc2, doc3
  FROM documentaciones
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE verificar_cursada_obligatoria
@cod tinyint,
@anio smallint,
@eta tinyint
AS
SELECT sen_obligatorio
  FROM pl_asist_ca
 WHERE codmateria = @cod
   AND anio = @anio
   AND cuatrimestre = @eta
GO

CREATE PROCEDURE reincorporar_alumno
@nro smallint,
@anio smallint
AS
UPDATE alumnos
   SET activo = 1
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
GO

CREATE PROCEDURE dar_baja_materias_alumno
@nro smallint,
@anio smallint
AS
UPDATE materiasxalumno
   SET estado = 'B'
 WHERE nroinscripcion = @nro
   AND anioingreso = @anio
   AND estado IN ('P','C','R','D')
GO

CREATE PROCEDURE reasignar_materia_introductorio
@nro smallint,
@ing smallint,
@cod tinyint,
@anio smallint,
@eta tinyint,
@est char(1)
AS
INSERT INTO materiasxalumno
VALUES (@nro,@ing,@cod,@anio,@eta,@est)
GO

CREATE PROCEDURE traer_materias_por_alumno_introductorio
@nro smallint,
@ing smallint,
@anio smallint,
@inst tinyint,
@carr tinyint
AS
SELECT mat.codmateria, mat.nombremateria, mxa.cuatrimestre, mxa.anio, mxa.estado
  FROM materias mat INNER JOIN materiasxalumno mxa
    ON mat.codmateria = mxa.codmateria
 WHERE mxa.nroinscripcion = @nro
   AND mxa.anioingreso = @ing
   AND mxa.anio = @anio
   AND mxa.cuatrimestre = @inst
   AND mat.codcarrera = @carr
ORDER BY mat.codmateria
GO