CREATE PROC FUNCION_INSERTAR
@id int, @idpelicula int, @horario DateTime
AS
BEGIN
	INSERT INTO FUNCION VALUES (@id, @idpelicula, @horario)
END
GO

CREATE PROC FUNCION_BORRAR
@id int
AS
BEGIN
	DELETE FROM FUNCION WHERE id = @id
END
GO

CREATE PROC FUNCION_BUSCAR
@idpelicula int
AS
BEGIN
	SELECT * FROM FUNCION WHERE idpelicula = @idpelicula
END
GO

CREATE PROC FUNCION_BUSCARID
@id int
AS
BEGIN
	SELECT * FROM FUNCION WHERE id = @id
END
GO

CREATE PROC FUNCION_EDITAR
@id int, @idpelicula int, @horario DateTime
AS
BEGIN
	UPDATE FUNCION SET 
		idpelicula = @idpelicula, 
		horario = @horario
    WHERE id = @id
END
GO

CREATE PROC FUNCION_LISTAR
AS
BEGIN 
	SELECT * FROM FUNCION
END
GO

CREATE PROC BUTACA_OCUPADA_BUSCAR
@idfuncion int
AS
BEGIN
	SELECT butaca FROM ENTRADA WHERE idfuncion = @idfuncion AND (estado = 'Pagada' OR estado = 'Emitida')
END
GO
