CREATE PROC USUARIO_INSERTAR
@nombredeusuario varchar(50), @contrasenia varchar(50), @nombre varchar(50), @apellido varchar(50), @correo varchar(50), @ididioma int
AS 
BEGIN
	INSERT INTO USUARIO VALUES (@nombredeusuario, @contrasenia, @nombre, @apellido, @correo, @ididioma)
END
GO

CREATE PROC USUARIO_BORRAR
@id int
AS 
BEGIN
	DELETE FROM USUARIO WHERE id = @id
END
GO

CREATE PROC USUARIO_EDITAR
@id int, @nombredeusuario varchar(50), @contrasenia varchar(50), @nombre varchar(50), @apellido varchar(50), @correo varchar(50), @ididioma int
AS 
BEGIN
	update USUARIO SET 
		nombredeusuario = @nombredeusuario, 
		contrasenia = @contrasenia,
		nombre = @nombre,
		apellido = @apellido,
		correo = @correo,
		ididioma = @ididioma
	WHERE id = @id
END
GO

CREATE PROC USUARIO_BUSCAR
@nombredeusuario varchar(50), @contrasenia varchar(50)
AS
BEGIN
	SELECT * FROM USUARIO WHERE nombredeusuario = @nombredeusuario AND contrasenia = @contrasenia
END
GO

CREATE PROC USUARIO_LISTAR
AS
BEGIN
	SELECT * FROM USUARIO
END
GO

CREATE PROC USUARIO_BUSCARID
@id int
AS
BEGIN
	SELECT * FROM USUARIO WHERE id = @id
END
GO