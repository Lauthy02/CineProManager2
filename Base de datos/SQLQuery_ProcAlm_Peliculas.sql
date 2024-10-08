CREATE PROC PELICULA_INSERTAR
@titulo varchar(50), @director varchar(50), @duracion int, @genero varchar(50), @descripcion varchar(MAX), @imagen varbinary(MAX)
AS
BEGIN
	INSERT INTO PELICULA VALUES (@titulo, @director, @duracion, @genero, @descripcion, @imagen)
END
GO

CREATE PROC PELICULA_BORRAR
@id int
AS
BEGIN
	DELETE FROM PELICULA WHERE id = @id
END
GO

CREATE PROC PELICULA_EDITAR
@id int, @titulo varchar(50), @director varchar(50), @duracion int, @genero varchar(50), @descripcion varchar(MAX), @imagen varbinary(MAX)
AS
BEGIN
	UPDATE PELICULA SET 
        titulo = @titulo, 
        director = @director,
        duracion = @duracion,
        genero = @genero,
		descripcion = @descripcion,
        imagen = @imagen
    WHERE id = @id
END
GO

CREATE PROC PELICULA_BUSCAR
@titulo varchar(50)
AS
BEGIN
	SELECT * FROM PELICULA WHERE titulo = @titulo
END
GO

CREATE PROC PELICULA_BUSCARID
@id int
AS
BEGIN
	SELECT * FROM PELICULA WHERE id = @id
END
GO

CREATE PROC PELICULA_LISTAR
AS
BEGIN
	SELECT * FROM PELICULA
END
GO



