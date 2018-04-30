CREATE PROCEDURE migracion_datos
AS
BEGIN

	DECLARE @cmd varchar(1000)
	-- Creación de esquema
	IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'FOUR_SIZONS')
	BEGIN
		SET @cmd = 'CREATE SCHEMA FOUR_SIZONS'
		EXEC (@cmd)
	END

	-- Creación de tablas
	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Funcionalidades')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Funcionalidades (
			Funcionalidad_Codigo nvarchar(10) PRIMARY KEY,
			Funcionalidad_Descripcion nvarchar(255) 
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Roles')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Roles (
			Rol_Nombre nvarchar(10) PRIMARY KEY,
			Rol_Funcionalidad nvarchar(10) REFERENCES FOUR_SIZONS.Funcionalidades(Funcionalidad_Codigo),
			Rol_Estado char(1) NOT NULL
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Usuarios')
		BEGIN
			CREATE TABLE FOUR_SIZONS.Usuarios (
				Usuario_Codigo nvarchar(10) PRIMARY KEY,
				Usuario_Password nvarchar(50) NOT NULL,
				Usuario_Rol_Asig nvarchar(10) REFERENCES FOUR_SIZONS.Roles(Rol_Nombre) NOT NULL,
				Usuario_Nombre_Apellido nvarchar(100) NOT NULL,
				Usuario_Tip_Doc nvarchar(5) NOT NULL,
				Usuario_Nro_Doc numeric(18) NOT NULL,
				Usuario_Mail nvarchar(255) NOT NULL,
				Usuario_Telefono numeric(18) NOT NULL,
				Usuario_Direccion nvarchar(255) NOT NULL,
				Usuario_Fec_Nac datetime NOT NULL,
				Usuario_Hotel int NOT NULL
			)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Habitaciones_Tipo')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Habitaciones_Tipo (
			   Habitacion_Tipo_Codigo numeric(18) PRIMARY KEY,
			   Habitacion_Tipo_Descripcion nvarchar(255),
			   Habitacion_Tipo_Porcentual numeric(18,2),
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Regimenes')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Regimenes (
			Regimen_Codigo int IDENTITY(1,1) PRIMARY KEY,
			Regimen_Descripcion nvarchar(255),
			Regimen_Precio numeric(18,2),
			Regimen_Estado char(1)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Consumibles')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Consumibles (
			Consumible_Codigo numeric(18) PRIMARY KEY,
			Consumible_Descripcion nvarchar(255),
			Consumible_Precio numeric(18,2)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hoteles')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Hoteles (
			Hotel_Codigo int IDENTITY(1,1) PRIMARY KEY,
			Hotel_Nombre nvarchar(255),
			Hotel_Ciudad nvarchar(255),
			Hotel_Calle nvarchar(255),
			Hotel_Nro_Calle numeric(18),
			Hotel_Telefono numeric(18),
			Hotel_Email nvarchar(50),
			Hotel_CantEstrella numeric(18),
			Hotel_FechaCreacion datetime,
			Hotel_Recarga_Estrella numeric(18)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Habitaciones')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Habitaciones (
			Habitacion_Numero numeric(18),
			Habitacion_Piso numeric(18),
			Habitacion_Hotel int REFERENCES FOUR_SIZONS.Hoteles(Hotel_Codigo),
			Habitacion_Frente nvarchar(50),
			Habitacion_Tipo numeric(18)  REFERENCES FOUR_SIZONS.Habitaciones_Tipo(Habitacion_Tipo_Codigo)
			PRIMARY KEY(Habitacion_Numero, Habitacion_Piso, Habitacion_Hotel)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Clientes')
		CREATE TABLE FOUR_SIZONS.Clientes (
			Cliente_Nacionalidad nvarchar(50),
			Cliente_Tipo_Ident nvarchar(5),
			Cliente_Nro_Ident numeric(18),
			Cliente_Mail nvarchar(255),
			Cliente_Apellido nvarchar(255),
			Cliente_Nombre nvarchar(255),
			Cliente_Fecha_Nac datetime,
			Cliente_Dom_Calle nvarchar(255),
			Cliente_Nro_Calle numeric(18),
			Cliente_Piso numeric(18),
			Cliente_Depto nvarchar(50),
			PRIMARY KEY (Cliente_Nacionalidad, Cliente_Tipo_Ident, Cliente_Nro_Ident, Cliente_Mail)
		)

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Reservas')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Reservas (
			Reserva_Codigo numeric(18) NOT NULL,
			Reserva_Hotel_Codigo int NOT NULL REFERENCES FOUR_SIZONS.Hoteles(Hotel_Codigo),
			Reserva_Fecha datetime,
			Reserva_Cant_Noches numeric(18),
			Reserva_Fecha_Desde datetime,
			Reserva_Fecha_Hasta datetime,
			Reserva_Tipo_Habitacion numeric(18) REFERENCES FOUR_SIZONS.Habitaciones_Tipo(Habitacion_Tipo_Codigo),
			Reserva_Tipo_Regimen int REFERENCES FOUR_SIZONS.Regimenes(Regimen_Codigo),
			Reserva_Cli_Nac nvarchar(50),
			Reserva_Cli_Tipo_Ident nvarchar(5),
			Reserva_Cli_Nro_Ident numeric(18)
			PRIMARY KEY(Reserva_Codigo, Reserva_Hotel_Codigo)
		)		
	END

	-- Migración de datos de la tabla maestra
	-- Tipos de Habitaciones
	INSERT INTO FOUR_SIZONS.Habitaciones_Tipo (Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual) 
	SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
	FROM GD1C2018.gd_esquema.Maestra
	ORDER BY Habitacion_Tipo_Codigo

	-- Regímenes
	INSERT INTO FOUR_SIZONS.Regimenes (Regimen_Descripcion, Regimen_Precio) 
	SELECT DISTINCT Regimen_Descripcion, Regimen_Precio
	FROM GD1C2018.gd_esquema.Maestra

	-- Consumibles
	INSERT INTO FOUR_SIZONS.Consumibles (Consumible_Codigo, Consumible_Descripcion, Consumible_Precio) 
	SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
	FROM GD1C2018.gd_esquema.Maestra
	WHERE Consumible_Codigo IS NOT NULL
	ORDER BY Consumible_Codigo

	-- Hoteles
	INSERT INTO FOUR_SIZONS.Hoteles (Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella) 
	SELECT DISTINCT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella
	FROM GD1C2018.gd_esquema.Maestra

	-- Habitaciones
	INSERT INTO FOUR_SIZONS.Habitaciones (Habitacion_Numero, Habitacion_Piso, Habitacion_Hotel, Habitacion_Frente, Habitacion_Tipo) 
	SELECT DISTINCT H.Hotel_Codigo, M.Habitacion_Numero, M.Habitacion_Piso, M.Habitacion_Frente, M.Habitacion_Tipo_Codigo
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hoteles AS H ON H.Hotel_Ciudad = M.Hotel_Ciudad and H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	ORDER BY H.Hotel_Codigo

	-- Clientes
	INSERT INTO FOUR_SIZONS.Clientes (Cliente_Nacionalidad, Cliente_Tipo_Ident, Cliente_Nro_Ident, Cliente_Mail, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac,
	Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto) 
	SELECT DISTINCT Cliente_Nacionalidad, 'PASSP', Cliente_Pasaporte_Nro, Cliente_Mail, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac,
	Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto
	FROM GD1C2018.gd_esquema.Maestra
	ORDER BY Cliente_Pasaporte_Nro

	-- Reservas
	INSERT INTO FOUR_SIZONS.Reservas (Reserva_Codigo, Reserva_Hotel_Codigo, Reserva_Fecha, Reserva_Cant_Noches, 
	Reserva_Fecha_Desde, Reserva_Fecha_Hasta, Reserva_Tipo_Habitacion, Reserva_Tipo_Regimen,
	Reserva_Cli_Nac, Reserva_Cli_Tipo_Ident, Reserva_Cli_Nro_Ident)
	SELECT DISTINCT M.Reserva_Codigo, H.Hotel_Codigo, GETDATE(), M.Reserva_Cant_Noches, 
	M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio, M.Habitacion_Tipo_Codigo, R.Regimen_Codigo, 
	M.Cliente_Nacionalidad, 'PASSP', M.Cliente_Pasaporte_Nro
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hoteles AS H ON H.Hotel_Ciudad = M.Hotel_Ciudad and H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	JOIN FOUR_SIZONS.Regimenes AS R ON R.Regimen_Descripcion = M.Regimen_Descripcion
	ORDER BY H.Hotel_Codigo

END

EXEC migracion_datos