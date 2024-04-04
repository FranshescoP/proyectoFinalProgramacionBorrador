-- =============================================
CREATE PROCEDURE spLogin
	@usuario FLOAT,
	@pass VARCHAR(100)
AS
BEGIN
	SELECT TOP 1 COUNT(*) FROM USUARIOS 
		WHERE USUARIOS.usuarioH = @usuario AND USUARIOS.contraseña = @pass
END
GO
-- =============================================
CREATE PROCEDURE obtenerTipoDocumentos
AS
BEGIN
	SELECT * FROM TIPODOCUMENTO
END
GO
-- =============================================
CREATE PROCEDURE sp_registrarHuesped
	@noDocumento FLOAT,
	@nombre VARCHAR(128),
	@apellido VARCHAR(128),
	@direccion VARCHAR(128),
	@telefono FLOAT,
	@tipodc INT,
	@pass VARCHAR(128)
AS
BEGIN

	INSERT INTO HUESPUED (noDocumento, nombre, apellido, direccion, telefono, tipodc, permiso)
		VALUES(@noDocumento, @nombre, @apellido, @direccion, @telefono, @tipodc, 3);


		INSERT INTO USUARIOS (usuarioH, contraseña)
			VALUES(@noDocumento, @pass)

END
GO

EXECUTE sp_registrarHuesped 3606940710103, 'Franshesco', 'Pascual', 'Zona 5', 30964851,2, 'camino2024'


DROP PROCEDURE sp_registrarHuesped