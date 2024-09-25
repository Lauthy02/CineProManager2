CREATE PROC TABLA_DVV_INSERTAR --Digito verificador vertical
@nombretabla varchar(50), @digitovertical varchar(70)
AS
BEGIN
	IF EXISTS (SELECT * FROM TABLA_DVV WHERE nombretabla = @nombretabla)
		BEGIN
			UPDATE TABLA_DVV SET 
				digitovertical = @digitovertical
			WHERE nombretabla = @nombretabla
		END
		ELSE
		BEGIN
			INSERT INTO TABLA_DVV VALUES (@nombretabla, @digitovertical)
		END
END
GO