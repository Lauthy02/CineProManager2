CREATE PROC PERMISO_INSERTAR
@nombre varchar(50), @permiso varchar(50)
AS
BEGIN
	INSERT INTO PERMISOS VALUES (@nombre, @permiso)
	--SELECT id AS LastID FROM PERMISOS WHERE id = @@Identity
END
GO

CREATE PROC PERMISO_PERMISO_BORRAR
@id int
AS
BEGIN
	DELETE FROM PERMISOS_PERMISOS WHERE idpermisopadre = @id
END
GO

CREATE PROC PERMISO_PERMISO_INSERTAR
@idpermisopadre int, @idpermisohijo int
AS
BEGIN
	INSERT INTO PERMISOS_PERMISOS VALUES (@idpermisopadre, @idpermisohijo) 
END
GO

CREATE PROC PERMISO_LISTAR_RECURSIVO
@where varchar(50)
AS
BEGIN
	WITH recursivo AS	(
							SELECT PP2.idpermisopadre, PP2.idpermisohijo FROM PERMISOS_PERMISOS PP2
							WHERE PP2.idpermisopadre = @where --acá se va variando la familia que busco
							UNION ALL 
							SELECT PP1.idpermisopadre, PP1.idpermisohijo FROM PERMISOS_PERMISOS PP1 
							inner join recursivo rec ON rec.idpermisohijo = PP1.idpermisopadre
						)
						SELECT rec.idpermisopadre, rec.idpermisohijo, P.id, P.nombre, P.permiso
						FROM recursivo rec 
						inner join PERMISOS P ON rec.idpermisohijo = P.id
END
GO

CREATE PROC ACCION_LISTAR
AS
BEGIN
	SELECT * FROM PERMISOS WHERE permiso IS NOT NULL
END
GO

CREATE PROC ROL_LISTAR
AS
BEGIN
	SELECT * FROM PERMISOS WHERE permiso IS NULL
END
GO

CREATE PROC USUARIO_PERMISO_LISTAR
@id int
AS
BEGIN
	SELECT P.* FROM USUARIOS_PERMISOS UP INNER JOIN PERMISOS P ON UP.idpermiso = P.id WHERE idusuario = @id
END
GO