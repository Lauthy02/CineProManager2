CREATE PROC IDIOMA_INSERTAR
@nombre varchar(50), @pordefecto bit, @listoparausar bit
AS
BEGIN
	INSERT INTO IDIOMA VALUES (@nombre, @pordefecto, @listoparausar)
END
GO

CREATE PROC IDIOMA_BORRAR
@id int
AS
BEGIN
	DELETE FROM TRADUCCION WHERE ididioma = @id
	DELETE FROM IDIOMA WHERE id = @id
END
GO

CREATE PROC IDIOMA_BUSCAR
@nombre varchar(50)
AS
BEGIN
	SELECT * FROM IDIOMA WHERE nombre = @nombre
END
GO

CREATE PROC IDIOMA_EDITAR
@id int, @nombre varchar(50), @listoparausar bit
AS
BEGIN
	UPDATE IDIOMA SET 
		nombre = @nombre,
		listoparausar = @listoparausar
	WHERE id = @id
END
GO

CREATE PROC IDIOMA_LISTAR
AS
BEGIN
	SELECT * FROM IDIOMA
END
GO

CREATE PROC OBTENER_TRADUCCIONES
@ididioma int
AS
BEGIN
	SELECT t.id AS 'idtraduccion', i.id AS 'ididioma', i.nombre AS 'nombreidioma', i.pordefecto, e.id AS 'idetiqueta', e.nombre AS 'nombreetiqueta', t.texto AS 'traduccion' FROM TRADUCCION t INNER JOIN IDIOMA i ON t.ididioma = i.id INNER JOIN ETIQUETA e ON t.idetiqueta = e.id WHERE i.id = @ididioma;
END
GO
