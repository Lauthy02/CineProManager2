CREATE PROC PELICULA_INSERTAR
@titulo varchar(50), @director varchar(50), @duracion int, @genero varchar(50), @imagen varbinary(MAX)
AS
BEGIN
	INSERT INTO PELICULAS VALUES (@titulo, @director, @duracion, @genero, @imagen)
END
GO

CREATE PROC PELICULA_BORRAR
@id int
AS
BEGIN
	DELETE FROM PELICULAS WHERE id = @id
END
GO

CREATE PROC PELICULA_EDITAR
@id int, @titulo varchar(50), @director varchar(50), @duracion int, @genero varchar(50), @imagen varbinary(MAX)
AS
BEGIN
	UPDATE PELICULAS SET 
        titulo = @titulo, 
        director = @director,
        duracion = @duracion,
        genero = @genero,
        imagen = @imagen
    WHERE id = @id
END
GO

CREATE PROC PELICULA_BUSCAR
@titulo varchar(50)
AS
BEGIN
	SELECT * FROM PELICULAS WHERE titulo = @titulo
END
GO
CREATE PROC PELICULA_LISTAR
AS
BEGIN
	SELECT * FROM PELICULAS
END
GO

