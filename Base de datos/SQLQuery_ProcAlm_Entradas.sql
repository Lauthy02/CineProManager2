CREATE PROC ENTRADA_INSERTAR
@idusuario int, @idfuncion int, @idsala int, @butaca varchar(50), @precio float, @fehcadereserva datetime, @estado varchar(50)
AS 
BEGIN
	INSERT INTO ENTRADA VALUES (@idusuario, @idfuncion,@idsala, @butaca, @precio, @fehcadereserva, @estado)
END

CREATE PROC ENTRADA_BORRAR
@id int
AS 
BEGIN
	DELETE FROM ENTRADA WHERE id = @id
END
GO

CREATE PROC ENTRADA_EDITAR
@id int, @idusuario int, @idfuncion int, @idsala int, @butaca varchar(50), @precio float, @fechadereserva DateTime, @estado varchar(50)
AS 
BEGIN
    UPDATE ENTRADA SET 
        idusuario = @idusuario, 
        idfuncion = @idfuncion,
        idsala = @idsala,
        butaca = @butaca,
        precio = @precio,
        fechadereserva = @fechadereserva,
        estado = @estado
    WHERE id = @id
END
GO

CREATE PROC ENTRADA_BUSCAR
@id int
AS
BEGIN
	SELECT * FROM ENTRADA WHERE id = @id
END
GO

CREATE PROC ENTRADA_BUSCARESTADO
@estado varchar(50)
AS
BEGIN
	SELECT * FROM ENTRADA WHERE estado = @estado
END
GO

CREATE PROC ENTRADA_LISTAR
AS
BEGIN
	SELECT * FROM ENTRADA
END
GO