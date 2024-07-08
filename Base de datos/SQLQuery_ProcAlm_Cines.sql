CREATE PROC CINE_INSERTAR
@nombre varchar(50), @zona varchar(50), @direccion varchar(MAX)
AS
BEGIN
	INSERT INTO CINE VALUES (@nombre, @zona, @direccion)
END
GO

CREATE PROC CINE_BORRAR
@id int
AS
BEGIN
	DELETE FROM CINE WHERE id = @id
END
GO

CREATE PROC CINE_EDITAR
@id int, @nombre varchar(50), @zona varchar(50), @direccion varchar(MAX)
AS
BEGIN
	UPDATE CINE SET 
		nombre = @nombre, 
		zona = @zona,
		direccion = @direccion
	WHERE id = @id
END
GO

CREATE PROC CINE_BUSCAR
@nombre varchar(50)
AS
BEGIN
	SELECT * FROM CINE WHERE nombre = @nombre
END
GO

CREATE PROC CINE_LISTAR
AS
BEGIN
	SELECT * FROM CINE
END
GO

CREATE PROC CINE_SALA_BUSCAR
@idcine int
AS
BEGIN
	SELECT * FROM CINE_SALA WHERE idcine = @idcine
END
GO
