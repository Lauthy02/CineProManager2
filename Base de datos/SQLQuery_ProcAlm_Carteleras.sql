CREATE PROC CARTELERA_BUSCAR
@idcine int
AS
BEGIN
	SELECT * FROM CARTELERA WHERE idcine = @idcine
END
GO