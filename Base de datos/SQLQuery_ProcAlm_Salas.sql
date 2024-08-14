CREATE PROC SALA_INSERTAR
@id int, @numerodesala int, @capacidad int, @formato varchar(50), @precio float
AS
BEGIN
	INSERT INTO SALA VALUES (@id, @numerodesala, @capacidad, @formato, @precio)
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
@id int, @numerodesala int, @capacidad int, @formato varchar(50), @precio float
AS
BEGIN
    UPDATE SALA SET 
        numerodesala = @numerodesala,
        capacidad = @capacidad, 
        formato = @formato,
        precio = @precio
    WHERE id = @id
END
GO

CREATE PROC SALA_LISTAR
AS
BEGIN 
	SELECT * FROM SALA
END
GO

CREATE PROC CINE_SALA_INSERTAR
@idcine int, @idsala int
AS
BEGIN
	INSERT INTO CINE_SALA VALUES (@idcine, @idsala)
END
GO

CREATE PROC SALA_FUNCION_INSERTAR
@idsala int, @idfuncion int
AS
BEGIN
	INSERT INTO SALA_FUNCION VALUES (@idsala, @idfuncion)
END
GO

CREATE PROC SALA_FUNCION_BUSCAR
@idsala int
AS
BEGIN
	SELECT * FROM SALA_FUNCION WHERE idsala = @idsala
END
GO