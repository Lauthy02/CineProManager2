CREATE PROC BITACORA_CAMBIOS_ENTRADA_INSERTAR
@idusuarioquemodifica int, @fechadecambio DateTime, @activo bit, @b_identrada int, @b_idusuario int, @b_idfuncion int, @b_idsala int, @b_butaca varchar(50), @b_precio float, @b_fechadereserva DateTime, @b_estado bit, @b_digitohorizontal varchar(70)
AS
BEGIN
	UPDATE BITACORACAMBIOS_ENTRADA SET activo = 0;
	INSERT INTO BITACORACAMBIOS_ENTRADA VALUES (@idusuarioquemodifica, @fechadecambio, @activo, @b_identrada, @b_idusuario, @b_idfuncion, @b_idsala, @b_butaca, @b_precio, @b_fechadereserva, @b_estado, @b_digitohorizontal);
END
GO

CREATE PROC BITACORA_CAMBIOS_ENTRADA_MODIFICAR
@fechadecambio DateTime, @activo bit
AS
BEGIN
	--Setear todos los activos en 0
	UPDATE BITACORACAMBIOS_ENTRADA SET activo = 0;

	--Setear solo el activo en 1
	UPDATE BITACORACAMBIOS_ENTRADA SET 
		activo = @activo
	WHERE fechadecambio = @fechadecambio;
END
GO

CREATE PROC BITACORA_CAMBIOS_ENTRADA_LISTAR
AS
BEGIN
	SELECT * FROM BITACORACAMBIOS_ENTRADA
END
GO