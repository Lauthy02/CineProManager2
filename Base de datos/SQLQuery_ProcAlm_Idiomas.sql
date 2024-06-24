CREATE PROC IDIOMA_INSERTAR
@nombre varchar(50), @pordefecto bit
AS
BEGIN
	INSERT INTO IDIOMA VALUES (@nombre, @pordefecto)
END
GO

CREATE PROC IDIOMA_BORRAR
@id int
AS
BEGIN
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
@id int, @nombre varchar(50)
AS
BEGIN
	UPDATE IDIOMA SET 
		nombre = @nombre
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
	SELECT t.ididioma,t.texto AS traduccion_traduccion, e.id, e.nombre AS nombre_etiqueta FROM TRADUCCION t 
	INNER JOIN ETIQUETA e ON t.idetiqueta = e.id WHERE t.ididioma = @ididioma
END
GO
