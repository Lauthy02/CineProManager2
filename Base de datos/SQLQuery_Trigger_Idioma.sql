CREATE TRIGGER trg_DespuesDeInsertarIdioma
ON IDIOMA
AFTER INSERT
AS
BEGIN
    -- Insertar traducciones para cada etiqueta existente
    INSERT INTO TRADUCCION (ididioma, idetiqueta, texto)
    SELECT i.id, e.id, 'Traducción pendiente'
    FROM ETIQUETA e
    CROSS JOIN INSERTED i;
END;