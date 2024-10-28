CREATE PROC PEDIDO_GOLOSINA_INSERTAR
@idpedido int, @idgolosina int, @cantidad int, @preciounitario float
AS
BEGIN
	INSERT INTO PEDIDO_GOLOSINA VALUES (@idpedido, @idgolosina, @cantidad, @preciounitario)
END
GO

CREATE PROC PEDIDO_GOLOSINA_BUSCAR
@idpedido int
AS
BEGIN
	SELECT * FROM PEDIDO_GOLOSINA WHERE idpedido = @idpedido
END
GO

ALTER PROC PEDIDO_INSERTAR
@id int, @idcliente int, @fecha datetime, @estado varchar(50), @montototal float
AS
BEGIN
	INSERT INTO PEDIDO VALUES (@id, @idcliente, @fecha, @estado, @montototal)
END
GO

CREATE PROC PEDIDO_BORRAR
@id int
AS
BEGIN
	DELETE FROM PEDIDO WHERE id = @id
END
GO

CREATE PROC PEDIDO_EDITAR
@id int, @idcliente int, @fecha datetime, @estado varchar(50), @montototal float
AS
BEGIN
	UPDATE PEDIDO SET 
        idcliente = @idcliente, 
        fecha = @fecha,
        estado = @estado,
        montototal = @montototal
    WHERE id = @id
END
GO

CREATE PROC PEDIDO_BUSCAR
@id int
AS
BEGIN
	SELECT * FROM PEDIDO WHERE id = @id
END
GO

CREATE PROC PEDIDO_BUSCARESTADO
@estado varchar(50)
AS
BEGIN
	SELECT * FROM PEDIDO WHERE estado = @estado
END
GO

CREATE PROC PEDIDO_LISTAR
AS
BEGIN
	SELECT * FROM PEDIDO
END
GO