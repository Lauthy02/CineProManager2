CREATE PROC SALA_INSERTAR
@capacidad int, @formato varchar(50)
AS
BEGIN
	INSERT INTO SALA VALUES (@capacidad, @formato)
END
GO

CREATE PROC SALA_BORRAR
@id int
AS
BEGIN
	DELETE FROM SALA WHERE id = @id
END
GO

CREATE PROC SALA_BUSCAR
@id int
AS
BEGIN
	SELECT * FROM SALA WHERE id = @id
END
GO

CREATE PROC SALA_BUSCARID
@id int
AS
BEGIN
	SELECT * FROM SALA WHERE id = @id
END
GO

CREATE PROC SALA_EDITAR
@id int, @capacidad int, @formato varchar(50)
AS
BEGIN
	UPDATE SALA SET 
		capacidad = @capacidad, 
		formato = @formato
    WHERE id = @id
END
GO

