CREATE PROC REALIZAR_BACKUP
@nombrebd varchar(50), @rutabackup varchar(200)
AS
BEGIN
	BACKUP DATABASE [CineProManagerTEST2] TO DISK = @rutabackup
END
GO