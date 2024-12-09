-- Verificar datos en la tabla CINE
SELECT * FROM CINE;

-- Verificar datos en la tabla SALA y su relaci�n con CINE
SELECT * FROM SALA WHERE id IN (SELECT Id FROM CINE);

-- Verificar datos en la tabla FUNCION y su relaci�n con SALA
SELECT * FROM FUNCION WHERE id IN (SELECT Id FROM SALA);

-- Verificar datos en la tabla ENTRADA y su relaci�n con FUNCION
SELECT * FROM ENTRADA 

SELECT COUNT(ENTRADA.Id) AS CantidadEntradasVendidas
FROM ENTRADA
INNER JOIN FUNCION ON ENTRADA.IdFuncion = FUNCION.Id
INNER JOIN SALA_FUNCION ON FUNCION.Id = SALA_FUNCION.IdFuncion
INNER JOIN SALA ON SALA_FUNCION.IdSala = SALA.Id
INNER JOIN CINE_SALA ON SALA.Id = CINE_SALA.IdSala
WHERE CINE_SALA.IdCine = 1;


SELECT CINE.Id AS IdCine, CINE.Nombre AS NombreCine, COUNT(ENTRADA.Id) AS CantidadEntradasVendidas
FROM CINE
INNER JOIN CINE_SALA ON CINE.Id = CINE_SALA.IdCine
INNER JOIN SALA ON CINE_SALA.IdSala = SALA.Id
INNER JOIN SALA_FUNCION ON SALA.Id = SALA_FUNCION.IdSala
INNER JOIN FUNCION ON SALA_FUNCION.IdFuncion = FUNCION.Id
INNER JOIN ENTRADA ON FUNCION.Id = ENTRADA.IdFuncion
WHERE CINE.Id = 1
AND ENTRADA.Estado = 'Pagada'
GROUP BY CINE.Id, CINE.Nombre;



DECLARE @FechaInicio DATE = '2023-01-01'; -- Reemplaza con la fecha de inicio deseada
DECLARE @FechaFin DATE = '2025-12-31'; -- Reemplaza con la fecha de fin deseada

SELECT CINE.Id AS IdCine, CINE.Nombre AS NombreCine, COUNT(ENTRADA.Id) AS CantidadEntradasVendidas
FROM CINE
INNER JOIN CINE_SALA ON CINE.Id = CINE_SALA.IdCine
INNER JOIN SALA ON CINE_SALA.IdSala = SALA.Id
INNER JOIN SALA_FUNCION ON SALA.Id = SALA_FUNCION.IdSala
INNER JOIN FUNCION ON SALA_FUNCION.IdFuncion = FUNCION.Id
INNER JOIN ENTRADA ON FUNCION.Id = ENTRADA.IdFuncion
WHERE CINE.Id = 1
AND ENTRADA.Fechadereserva BETWEEN @FechaInicio AND @FechaFin
AND ENTRADA.Estado = 'Pagada'
GROUP BY CINE.Id, CINE.Nombre;