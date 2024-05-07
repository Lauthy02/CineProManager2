CREATE PROC USUARIO_INSERTAR
@nombredeusuario varchar(50), @contrasenia varchar(50), @nombre varchar(50), @apellido varchar(50), @correo varchar(50)
AS 
BEGIN
	INSERT INTO USUARIOS VALUES (@nombredeusuario, @contrasenia, @nombre, @apellido, @correo)
END
GO

CREATE PROC USUARIO_BORRAR
@id int
AS 
BEGIN
	DELETE FROM USUARIOS WHERE id = @id
END
GO

CREATE PROC USUARIO_EDITAR
@id int, @nombredeusuario varchar(50), @contrasenia varchar(50), @nombre varchar(50), @apellido varchar(50), @correo varchar(50) 
AS 
BEGIN
	update USUARIOS SET 
		nombredeusuario = @nombredeusuario, 
		contrasenia = @contrasenia,
		nombre = @nombre,
		apellido = @apellido,
		correo = @correo
	WHERE id = @id
END
GO

CREATE PROC USUARIO_BUSCAR
@nombredeusuario varchar(50), @contrasenia varchar(50)
AS
BEGIN
	SELECT * FROM USUARIOS WHERE nombredeusuario = @nombredeusuario AND contrasenia = @contrasenia
END
GO

CREATE PROC USUARIO_LISTAR
AS
BEGIN
	SELECT * FROM USUARIOS
END
GO

