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
CREATE PROCEDURE registrarHuesped
	@noDocumento FLOAT,
	@nombre VARCHAR(128),
	@apellido VARCHAR(128),
	@direccion VARCHAR(128),
	@telefono FLOAT,
	@tipodc INT,
	@pass VARCHAR(128),
	@permiso INT
AS
BEGIN
	INSERT INTO HUESPUED (noDocumento, nombre, apellido, direccion, telefono, tipodc, permiso)
		VALUES(@noDocumento, @nombre, @apellido, @direccion, @telefono, @tipodc, 3);

	INSERT INTO USUARIOS (usuarioH, contraseña)
		SELECT H.noDocumento FROM USUARIOS AS U
			 JOIN HUESPUED AS H ON U.usuarioH = H.ID
				WHERE U.usuarioH = H.ID
END
GO

DROP PROCEDURE registrarHuesped

