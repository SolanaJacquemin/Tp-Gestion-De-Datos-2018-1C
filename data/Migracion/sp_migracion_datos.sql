USE GD1C2018
GO

IF (OBJECT_ID('dbo.migracion_datos', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE dbo.migracion_datos
END;
GO

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

	--Eliminar tablas anteriormente creadas
	IF (OBJECT_ID('FOUR_SIZONS.Parametros', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Parametros
	END

	IF (OBJECT_ID('FOUR_SIZONS.EstadiaXCliente', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.EstadiaXCliente
	END

	IF (OBJECT_ID('FOUR_SIZONS.EstadiaXConsumible', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.EstadiaXConsumible
	END

	IF (OBJECT_ID('FOUR_SIZONS.Habitacion_TipoXReser', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Habitacion_TipoXReser
	END

	IF (OBJECT_ID('FOUR_SIZONS.RegXHotel', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.RegXHotel
	END

	IF (OBJECT_ID('FOUR_SIZONS.UsuarioXRol', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.UsuarioXRol
	END

	IF (OBJECT_ID('FOUR_SIZONS.UsuarioXHotel', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.UsuarioXHotel
	END

	IF (OBJECT_ID('FOUR_SIZONS.Disponibilidad', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Disponibilidad
	END

	IF (OBJECT_ID('FOUR_SIZONS.Consumible', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Consumible
	END

	IF (OBJECT_ID('FOUR_SIZONS.Hotel_Cerrado', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Hotel_Cerrado
	END

	IF (OBJECT_ID('FOUR_SIZONS.Item_Factura', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Item_Factura
	END

	IF (OBJECT_ID('FOUR_SIZONS.RolXFunc', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.RolXFunc
	END

	IF (OBJECT_ID('FOUR_SIZONS.Tarjeta', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Tarjeta
	END

	IF (OBJECT_ID('FOUR_SIZONS.Regimen', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Regimen
	END

	IF (OBJECT_ID('FOUR_SIZONS.Funcionalidad', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Funcionalidad
	END

	IF (OBJECT_ID('FOUR_SIZONS.ReservaMod', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.ReservaMod
	END

	IF (OBJECT_ID('FOUR_SIZONS.Rol', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Rol
	END

	IF (OBJECT_ID('FOUR_SIZONS.Factura', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Factura
	END

	IF (OBJECT_ID('FOUR_SIZONS.Estadia', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Estadia
	END

	IF (OBJECT_ID('FOUR_SIZONS.Habitacion', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Habitacion
	END

	IF (OBJECT_ID('FOUR_SIZONS.Habitacion_Tipo', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Habitacion_Tipo
	END

	IF (OBJECT_ID('FOUR_SIZONS.Reserva', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Reserva
	END

	IF (OBJECT_ID('FOUR_SIZONS.Usuario', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Usuario
	END

	IF (OBJECT_ID('FOUR_SIZONS.Cliente', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Cliente
	END

	IF (OBJECT_ID('FOUR_SIZONS.Hotel', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Hotel
	END

	-- Creación de tablas
	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Parametros')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Parametros(
			Parametro_Codigo nvarchar(10),
			Paramentro_NroItem numeric(18) IDENTITY,
			Parametro_Descripcion nvarchar(255)

			CONSTRAINT PK_Parametros PRIMARY KEY (Parametro_Codigo, Paramentro_NroItem)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Funcionalidad')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Funcionalidad (
			Func_Codigo numeric(18,0) IDENTITY,
			Func_Nombre varchar(50),
			Func_Descripcion nvarchar(255),
			Func_Estado bit,
			CONSTRAINT PK_Funcionalidad PRIMARY KEY(Func_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Rol')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Rol (
			Rol_Codigo numeric(18,0) IDENTITY,
			Rol_Nombre nvarchar(50),
			Rol_Estado bit,
			CONSTRAINT PK_Rol PRIMARY KEY(Rol_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'RolXFunc')
	BEGIN
		CREATE TABLE FOUR_SIZONS.RolXFunc (
			Rol_Codigo numeric(18,0),
			Func_Codigo numeric(18,0),
			RolXFunc_Estado bit,

			CONSTRAINT FK_RolXFunc_1 FOREIGN KEY (Rol_Codigo) REFERENCES FOUR_SIZONS.Rol(Rol_Codigo),
			CONSTRAINT FK_RolXFunc_2 FOREIGN KEY (Func_Codigo) REFERENCES FOUR_SIZONS.Funcionalidad(Func_Codigo),

			CONSTRAINT PK_RolXFunc PRIMARY KEY(Rol_Codigo, Func_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Usuario')
		BEGIN
			CREATE TABLE FOUR_SIZONS.Usuario (
				Usuario_ID nvarchar(15),
				Usuario_Password nvarchar(15) NOT NULL,
				Usuario_Nombre nvarchar(50) NOT NULL,
				Usuario_Apellido nvarchar(50) NOT NULL,
				Usuario_TipoDoc nvarchar(50) NOT NULL,
				Usuario_NroDoc numeric(18) NOT NULL,
				Usuario_Telefono nvarchar(18) NOT NULL,
				Usuario_Direccion nvarchar(255) NOT NULL,
				Usuario_Fec_Nac datetime NOT NULL,
				Usuario_Mail nvarchar(50) NOT NULL,
				Usuario_Estado bit NOT NULL,
				Usuario_FallaLog numeric(1) NOT NULL
				CONSTRAINT PK_Usuario PRIMARY KEY (Usuario_ID)
			)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'UsuarioXRol')
	BEGIN
		CREATE TABLE FOUR_SIZONS.UsuarioXRol (
			Usuario_ID nvarchar(15),
			Rol_Codigo numeric(18,0),
			UsuarioXRol_Estado bit,

			CONSTRAINT FK_UsuarioXRol_1 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),
			CONSTRAINT FK_UsuarioXRol_2 FOREIGN KEY (Rol_Codigo) REFERENCES FOUR_SIZONS.Rol(Rol_Codigo),

			CONSTRAINT PK_UsuarioXRol PRIMARY KEY (Usuario_ID, Rol_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hotel')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Hotel (
			Hotel_Codigo numeric(18) IDENTITY(1,1),
			Hotel_Nombre nvarchar(50),
			Hotel_Mail nvarchar(50),
			Hotel_Telefono nvarchar(18),
			Hotel_Calle nvarchar(255),
			Hotel_Nro_Calle numeric(18),
			Hotel_CantEstrella numeric(18),
			Hotel_Recarga_Estrella numeric(18),
			Hotel_Ciudad nvarchar(255),
			Hotel_Pais nvarchar(50),			
			Hotel_FechaCreacion datetime,
			Hotel_Estado bit
			CONSTRAINT PK_Hotel PRIMARY KEY (Hotel_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'UsuarioXHotel')
	BEGIN
		CREATE TABLE FOUR_SIZONS.UsuarioXHotel (
			Usuario_ID nvarchar(15),
			Hotel_Codigo numeric(18),
			UsuarioXHotel_Estado bit,

			CONSTRAINT FK_UsuarioXHotel_1 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),
			CONSTRAINT FK_UsuarioXHotel_2 FOREIGN KEY (Hotel_Codigo) REFERENCES FOUR_SIZONS.Hotel(Hotel_Codigo),

			CONSTRAINT PK_UsuarioXHotel PRIMARY KEY (Usuario_ID, Hotel_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Regimen')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Regimen (
			Regimen_Codigo numeric(18) IDENTITY(1,1),
			Regimen_Descripcion nvarchar(255),
			Regimen_Precio numeric(18,2),
			Regimen_Estado bit
			CONSTRAINT PK_Regimen PRIMARY KEY (Regimen_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'RegXHotel')
	BEGIN
		CREATE TABLE FOUR_SIZONS.RegXHotel (
			Hotel_Codigo numeric(18),
			Regimen_Codigo numeric(18,0), 
			RegXHotel_Estado bit,

			CONSTRAINT FK_RegXHotel_1 FOREIGN KEY (Hotel_Codigo) REFERENCES FOUR_SIZONS.Hotel(Hotel_Codigo),
			CONSTRAINT FK_RegXHotel_2 FOREIGN KEY (Regimen_Codigo) REFERENCES FOUR_SIZONS.Regimen(Regimen_Codigo),

			CONSTRAINT PK_RegXHotel PRIMARY KEY (Hotel_Codigo, Regimen_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Hotel_Cerrado')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Hotel_Cerrado (
			Cerrado_codigo numeric(18),
			Cerrado_FechaI datetime,
			Cerrado_FechaF datetime,
			Cerrado_Detalle nvarchar(255),
			Hotel_Codigo numeric(18),

			CONSTRAINT FK_Hotel_Cerrado FOREIGN KEY (Hotel_Codigo) REFERENCES FOUR_SIZONS.Hotel(Hotel_Codigo),

			CONSTRAINT PK_Hotel_Cerrado PRIMARY KEY (Cerrado_codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Habitacion_Tipo')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Habitacion_Tipo (
			   Habitacion_Tipo_Codigo numeric(18),
			   Habitacion_Tipo_Descripcion nvarchar(255),
			   Habitacion_Tipo_Porcentual numeric(18,2),
			   CONSTRAINT PK_Habitacion_Tipo PRIMARY KEY (Habitacion_Tipo_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Consumible')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Consumible (
			Consumible_Codigo numeric(18),
			Consumible_Descripcion nvarchar(255),
			Consumible_Precio numeric(18,2),
			CONSTRAINT PK_Consumible PRIMARY KEY (Consumible_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Habitacion')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Habitacion (
			Habitacion_Numero numeric(18),
			Hotel_Codigo numeric(18),
			Habitacion_Piso numeric(18),
			Habitacion_Frente nvarchar(50),
			Habitacion_Tipo_Codigo numeric(18),  
			Habitacion_Estado bit,

			CONSTRAINT FK_Habitacion_1 FOREIGN KEY (Hotel_Codigo) REFERENCES FOUR_SIZONS.Hotel(Hotel_Codigo),
			CONSTRAINT FK_Habitacion_2 FOREIGN KEY (Habitacion_Tipo_Codigo) REFERENCES FOUR_SIZONS.Habitacion_Tipo(Habitacion_Tipo_Codigo),
			
			CONSTRAINT PK_Habitacion PRIMARY KEY (Habitacion_Numero, Hotel_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cliente')
		CREATE TABLE FOUR_SIZONS.Cliente (
			Cliente_Codigo numeric(18) IDENTITY (1,1),
			Cliente_Nombre nvarchar(255),
			Cliente_Apellido nvarchar(255),
			Cliente_TipoDoc nvarchar(255),
			Cliente_NumDoc numeric(18,0),
			Cliente_Dom_Calle nvarchar(255),
			Cliente_Nro_Calle numeric(18),
			Cliente_Piso numeric(18),
			Cliente_Depto nvarchar(50) ,
			Cliente_Mail nvarchar(255) NOT NULL,
			Cliente_Nacionalidad nvarchar(50),
			Cliente_Fecha_Nac datetime,
			Cliente_Puntos decimal(18,2),
			Cliente_Estado bit,
			Cliente_Consistente bit
			CONSTRAINT PK_Cliente PRIMARY KEY (Cliente_Codigo)

		)

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tarjeta')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Tarjeta (
			Tarjeta_Numero numeric(18),
			Tarjeta_Venc datetime,
			Tarjeta_Cod numeric(3),
			Tarjeta_Titular nvarchar(50),
			Tarjeta_Marca nvarchar(50),
			Cliente_Codigo numeric(18)

			CONSTRAINT FK_Tarjeta FOREIGN KEY (Cliente_Codigo) REFERENCES FOUR_SIZONS.Cliente(Cliente_Codigo),
			CONSTRAINT PK_Tarjeta PRIMARY KEY (Tarjeta_Numero)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Reserva')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Reserva (
			Reserva_Codigo numeric(18),
			Reserva_FechaCreacion datetime,
			Reserva_Fecha_Inicio datetime,
			Reserva_Fecha_Fin datetime,
			Reserva_Cant_Noches numeric(18),
			Reserva_Precio decimal(12,2),
			Usuario_ID nvarchar(15),
			Hotel_Codigo numeric(18),
			Cliente_Codigo numeric(18),
			Reserva_Estado bit,

			CONSTRAINT FK_Reserva_1 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),
			CONSTRAINT FK_Reserva_2 FOREIGN KEY (Hotel_Codigo) REFERENCES FOUR_SIZONS.Hotel(Hotel_Codigo),
			CONSTRAINT FK_Reserva_3 FOREIGN KEY (Cliente_Codigo) REFERENCES FOUR_SIZONS.Cliente(Cliente_Codigo),

			CONSTRAINT PK_Reserva PRIMARY KEY (Reserva_Codigo)
		)		
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ReservaMod')
	BEGIN
		CREATE TABLE FOUR_SIZONS.ReservaMod (
			Reserva_Codigo numeric(18),
			Usuario_ID nvarchar(15),
			ResMod_Detalle nvarchar(255),
			ResMod_Fecha datetime,
			
			CONSTRAINT FK_ReservaMod_1 FOREIGN KEY (Reserva_Codigo) REFERENCES FOUR_SIZONS.Reserva(Reserva_Codigo),
			CONSTRAINT FK_ReservaMod_2 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),

			CONSTRAINT PK_ReservaMod PRIMARY KEY (Reserva_Codigo, Usuario_ID)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Habitacion_TipoXReser')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Habitacion_TipoXReser (
			Reserva_Codigo numeric(18),
			Habitacion_Tipo_Codigo numeric(18),			

			CONSTRAINT FK_Habitacion_TipoXReser_1 FOREIGN KEY (Reserva_Codigo) REFERENCES FOUR_SIZONS.Reserva(Reserva_Codigo),
			CONSTRAINT FK_Habitacion_TipoXReser_2 FOREIGN KEY (Habitacion_Tipo_Codigo) REFERENCES FOUR_SIZONS.Habitacion_Tipo(Habitacion_Tipo_Codigo),

			CONSTRAINT PK_Habitacion_TipoXReser PRIMARY KEY (Reserva_Codigo, Habitacion_Tipo_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Estadia')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Estadia (
			Estadia_Codigo numeric(18) IDENTITY(1,1),
			Reserva_Codigo numeric(18), 
			Estadia_FechaInicio datetime,
			Estadia_FechaFin datetime,
			Estadia_CantNoches numeric(18),
			Usuario_ID nvarchar(15),
			Habitacion_Numero numeric(18),
			Hotel_Codigo numeric(18),
			Estadia_Estado bit

			CONSTRAINT FK_Estadia_1 FOREIGN KEY (Reserva_Codigo) REFERENCES FOUR_SIZONS.Reserva(Reserva_Codigo),
			CONSTRAINT FK_Estadia_2 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),
			CONSTRAINT FK_Estadia_3 FOREIGN KEY (Habitacion_Numero, Hotel_Codigo) REFERENCES FOUR_SIZONS.Habitacion(Habitacion_Numero, Hotel_Codigo),

			CONSTRAINT PK_Estadia PRIMARY KEY (Estadia_Codigo)

		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EstadiaXCliente')
	BEGIN
		CREATE TABLE FOUR_SIZONS.EstadiaXCliente (
			Cliente_Codigo numeric(18),
			Estadia_Codigo numeric(18),

			CONSTRAINT FK_EstadiaXCliente_1 FOREIGN KEY (Cliente_Codigo) REFERENCES FOUR_SIZONS.Cliente(Cliente_Codigo),
			CONSTRAINT FK_EstadiaXCliente_2 FOREIGN KEY (Estadia_Codigo) REFERENCES FOUR_SIZONS.Estadia(Estadia_Codigo),

			CONSTRAINT PK_EstadiaXCliente PRIMARY KEY (Cliente_Codigo, Estadia_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EstadiaXConsumible')
	BEGIN
		CREATE TABLE FOUR_SIZONS.EstadiaXConsumible (
			Estadia_Codigo numeric(18),
			Consumible_Codigo numeric(18),

			CONSTRAINT FK_EstadiaXConsumible_1 FOREIGN KEY (Estadia_Codigo) REFERENCES FOUR_SIZONS.Estadia(Estadia_Codigo),
			CONSTRAINT FK_EstadiaXConsumible_2 FOREIGN KEY (Consumible_Codigo) REFERENCES FOUR_SIZONS.Consumible(Consumible_Codigo),

			CONSTRAINT PK_EstadiaXConsumible PRIMARY KEY (Estadia_Codigo, Consumible_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Factura')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Factura (
			Factura_Nro numeric(18),
			Factura_Fecha datetime,
			Factura_Total decimal(18,2),
			Factura_FormaPago nvarchar(50),
			Usuario_ID nvarchar(15),
			Estadia_Codigo numeric(18),
			Cliente_Codigo numeric(18),

			CONSTRAINT FK_Factura_1 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),
			CONSTRAINT FK_Factura_2 FOREIGN KEY (Estadia_Codigo) REFERENCES FOUR_SIZONS.Estadia(Estadia_Codigo),
			CONSTRAINT FK_Factura_3 FOREIGN KEY (Cliente_Codigo) REFERENCES FOUR_SIZONS.Cliente(Cliente_Codigo),

			CONSTRAINT PK_Factura PRIMARY KEY (Factura_Nro)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Item_Factura')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Item_Factura (
			Factura_Nro numeric(18),
			Item_Factura_NroItem numeric(18) IDENTITY(1,1),
			Item_Factura_Cant numeric(18),
			Item_Factura_Monto decimal(18,2),


			CONSTRAINT FK_Item_Factura FOREIGN KEY (Factura_Nro) REFERENCES FOUR_SIZONS.Factura(Factura_Nro),
			
			CONSTRAINT PK_Item_Factura PRIMARY KEY (Factura_Nro, Item_Factura_NroItem)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Disponibilidad')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Disponibilidad (
			Disp_Fecha numeric(18),
			Habitacion_Tipo_Codigo numeric(18),
			Hotel_Codigo numeric(18),
			Disp_HabDisponibles numeric(3),
			
			CONSTRAINT FK_Disponibilidad_1 FOREIGN KEY (Habitacion_Tipo_Codigo) REFERENCES FOUR_SIZONS.Habitacion_Tipo(Habitacion_Tipo_Codigo),
			CONSTRAINT FK_Disponibilidad_2 FOREIGN KEY (Hotel_Codigo) REFERENCES FOUR_SIZONS.Hotel(Hotel_Codigo),

			CONSTRAINT PK_Disponibilidad PRIMARY KEY (Disp_Fecha, Habitacion_Tipo_Codigo, Hotel_Codigo)
		)
	END

	-- Migración de datos de la tabla maestra
	-- Parámetros
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'DNI')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'CUIL')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'CUIT')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'LE')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'LC')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'PASS')

	-- Roles
	INSERT INTO FOUR_SIZONS.Rol VALUES ('Administrador', 1)
	INSERT INTO FOUR_SIZONS.Rol VALUES ('Recepcionista', 1)
	INSERT INTO FOUR_SIZONS.Rol VALUES ('Guest', 1)
	DELETE FROM FOUR_SIZONS.Funcionalidad
	--Funcionalidades
	INSERT INTO FOUR_SIZONS.Funcionalidad (Func_Nombre, Func_Estado) VALUES  
				('ABM Rol', 1),
				('ABM Usuario', 1),
				('ABM Cliente', 1),
				('ABM Hotel', 1),
				('ABM Habitacion', 1),
				('ABM Regimen', 1),
				('Generar/Modificar Reserva', 1),
				('Cancelar Reserva', 1),
				('Registrar Estadia', 1),
				('Registrar Consumibles', 1),
				('Listado Estadistico', 1);
	
	--ROLXFUNC
	insert into FOUR_SIZONS.RolXFunc (Rol_Codigo,Func_Codigo, RolXFunc_Estado)
		select distinct R.Rol_Codigo, F.Func_Codigo, 1 from FOUR_SIZONS.Rol R,FOUR_SIZONS.Funcionalidad F
		where R.Rol_Nombre =  'Administrador' and
				F.Func_Nombre in ('ABM Hotel','ABM Habitacion','ABM Regimen','ABM Usuario');

	insert into FOUR_SIZONS.RolXFunc(Rol_Codigo,Func_Codigo, RolXFunc_Estado)
		select distinct R.Rol_Codigo, F.Func_Codigo, 1 from FOUR_SIZONS.Rol R,FOUR_SIZONS.Funcionalidad F
		where R.Rol_Nombre = 'Recepcionista' and
				F.Func_Nombre in ('ABM Cliente','Generar/Modificar Reserva','Cancelar Reserva','Registrar Estadia','Registrar Consumibles');
			
	insert into FOUR_SIZONS.RolXFunc(Rol_Codigo,Func_Codigo, RolXFunc_Estado)
		select distinct R.Rol_Codigo, F.Func_Codigo, 1 from FOUR_SIZONS.Rol R,FOUR_SIZONS.Funcionalidad F
		where R.Rol_Nombre = 'Guest' and
				F.Func_Nombre in ('Generar/Modificar Reserva','Cancelar Reserva');
	
	-- Tipos de Habitaciones
	INSERT INTO FOUR_SIZONS.Habitacion_Tipo (Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual) 
	SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
	FROM GD1C2018.gd_esquema.Maestra
	ORDER BY Habitacion_Tipo_Codigo

	-- Regímenes
	INSERT INTO FOUR_SIZONS.Regimen (Regimen_Descripcion, Regimen_Precio, Regimen_Estado)
	SELECT DISTINCT Regimen_Descripcion, Regimen_Precio, 1
	FROM GD1C2018.gd_esquema.Maestra

	-- Consumibles
	INSERT INTO FOUR_SIZONS.Consumible(Consumible_Codigo, Consumible_Descripcion, Consumible_Precio) 
	SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
	FROM GD1C2018.gd_esquema.Maestra
	WHERE Consumible_Codigo IS NOT NULL
	ORDER BY Consumible_Codigo

	-- Hoteles
	INSERT INTO FOUR_SIZONS.Hotel (Hotel_Nombre, Hotel_Mail, Hotel_Telefono, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, 
	Hotel_Recarga_Estrella, Hotel_Ciudad, Hotel_Pais, Hotel_FechaCreacion, Hotel_Estado) 
	SELECT DISTINCT '', '', '', Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Hotel_Ciudad, '',
	GETDATE(), 1
	FROM GD1C2018.gd_esquema.Maestra

	-- RegXHotel
	INSERT INTO FOUR_SIZONS.RegXHotel(Hotel_Codigo, Regimen_Codigo, RegXHotel_Estado)
	SELECT DISTINCT H.Hotel_Codigo, R.Regimen_Codigo, 1
	FROM gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Nro_Calle = M.Cliente_Nro_Calle
	JOIN FOUR_SIZONS.Regimen AS R ON R.Regimen_Descripcion = M.Regimen_Descripcion
	ORDER BY H.Hotel_Codigo, R.Regimen_Codigo

	-- Habitaciones
	INSERT INTO FOUR_SIZONS.Habitacion (Habitacion_Numero, Hotel_Codigo, Habitacion_Piso, Habitacion_Frente, Habitacion_Tipo_Codigo,
	Habitacion_Estado) 
	SELECT DISTINCT M.Habitacion_Numero, H.Hotel_Codigo, M.Habitacion_Piso, M.Habitacion_Frente, M.Habitacion_Tipo_Codigo, 1
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Ciudad = M.Hotel_Ciudad and H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	ORDER BY M.Habitacion_Numero, H.Hotel_Codigo

	-- Clientes
	INSERT INTO FOUR_SIZONS.Cliente (Cliente_Nombre, Cliente_Apellido, Cliente_TipoDoc, Cliente_NumDoc, Cliente_Dom_Calle,
	Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Mail, Cliente_Nacionalidad, Cliente_Fecha_Nac, Cliente_Puntos, Cliente_Estado, Cliente_Consistente)
	SELECT DISTINCT Cliente_Nombre, Cliente_Apellido, 'PASSP', Cliente_Pasaporte_Nro, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, 
	Cliente_Depto, Cliente_Mail, Cliente_Nacionalidad, Cliente_Fecha_Nac, 0, 1, 1
	FROM GD1C2018.gd_esquema.Maestra
	ORDER BY Cliente_Pasaporte_Nro

	/**Toma los clientes con igual número de pasaporte y actualiza su estado a 1. Se deja el nro de pasaporte en negativo para uno de 
	los clientes generados **/
	DECLARE @updateDupli TABLE(
		clienteD numeric(18)
	)

	INSERT INTO @updateDupli (clienteD)
	SELECT C1.Cliente_Codigo
	FROM FOUR_SIZONS.Cliente as C1
	JOIN FOUR_SIZONS.Cliente as C2 on c1.Cliente_NumDoc = c2.Cliente_NumDoc and c1.Cliente_Codigo > c2.Cliente_Codigo
	
	UPDATE FOUR_SIZONS.Cliente
	SET Cliente_NumDoc = (Cliente_NumDoc)*(-1),
	Cliente_Consistente = 0
	WHERE Cliente_Codigo IN (select clienteD from @updateDupli)

	-- Usuario
	-- Inserta usuario administrador
	INSERT INTO FOUR_SIZONS.Usuario
	VALUES ('SYSADM', 'SYSADM', 'Administrador', '', '', 0, '', '', GETDATE(), '',1,0)

	-- Reservas
	INSERT INTO FOUR_SIZONS.Reserva (Reserva_Codigo, Reserva_FechaCreacion, Reserva_Fecha_Inicio, Reserva_Fecha_Fin,
	Reserva_Cant_Noches, Reserva_Precio, Usuario_ID, Hotel_Codigo, Cliente_Codigo, Reserva_Estado)
	SELECT DISTINCT M.Reserva_Codigo, M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio, 
	M.Reserva_Cant_Noches, 0, 'SYSADM', H.Hotel_Codigo, C.Cliente_Codigo, 1
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Ciudad = M.Hotel_Ciudad and H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	JOIN FOUR_SIZONS.Regimen AS R ON R.Regimen_Descripcion = M.Regimen_Descripcion
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	ORDER BY H.Hotel_Codigo

	-- Habitacion_TipoXReserva
	INSERT INTO FOUR_SIZONS.Habitacion_TipoXReser(Reserva_Codigo, Habitacion_Tipo_Codigo)
	SELECT DISTINCT Reserva_Codigo, Habitacion_Tipo_Codigo
	FROM gd_esquema.Maestra
	ORDER BY Reserva_Codigo

	-- Estadia
	INSERT INTO FOUR_SIZONS.Estadia (Reserva_Codigo, Estadia_FechaInicio, Estadia_FechaFin, Estadia_CantNoches, Usuario_ID,
	Habitacion_Numero, Hotel_Codigo, Estadia_Estado)
	SELECT DISTINCT M.Reserva_Codigo, M.Estadia_Fecha_Inicio, NULL, M.Estadia_Cant_Noches, 'SYSADM', M.Habitacion_Numero, H.Hotel_Codigo, 1
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	WHERE M.Estadia_Fecha_Inicio IS NOT NULL AND M.Estadia_Cant_Noches IS NOT NULL
	ORDER BY M.Reserva_Codigo

	--EstadiaXCliente
	INSERT INTO FOUR_SIZONS.EstadiaXCliente(Cliente_Codigo, Estadia_Codigo)
	SELECT DISTINCT C.Cliente_Codigo, E.Estadia_Codigo 
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	JOIN FOUR_SIZONS.Estadia AS E ON E.Reserva_Codigo = M.Reserva_Codigo
	ORDER BY C.Cliente_Codigo

	--EstadiaXConsumible
	INSERT INTO FOUR_SIZONS.EstadiaXConsumible(Estadia_Codigo, Consumible_Codigo)
	SELECT DISTINCT E.Estadia_Codigo, M.Consumible_Codigo
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	JOIN FOUR_SIZONS.Estadia AS E ON E.Reserva_Codigo = M.Reserva_Codigo
	WHERE M.Consumible_Codigo IS NOT NULL
	ORDER BY E.Estadia_Codigo

	--Factura
	INSERT INTO FOUR_SIZONS.Factura (Factura_Nro, Factura_Fecha, Factura_Total, Factura_FormaPago, Usuario_ID, Estadia_Codigo, Cliente_Codigo)
	SELECT DISTINCT M.Factura_Nro, M.Factura_Fecha, M.Factura_Total, NULL, 'SYSADM', EC.Estadia_Codigo, C.Cliente_Codigo
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	JOIN FOUR_SIZONS.Reserva AS R ON R.Reserva_Codigo = M.Reserva_Codigo
	JOIN FOUR_SIZONS.EstadiaXCliente AS EC ON EC.Cliente_Codigo = C.Cliente_Codigo
	JOIN FOUR_SIZONS.Estadia AS E ON E.Estadia_Codigo = EC.Estadia_Codigo AND E.Reserva_Codigo = R.Reserva_Codigo
	WHERE Factura_Nro IS NOT NULL
	ORDER BY M.Factura_Nro

	--Item_Factura
	INSERT INTO FOUR_SIZONS.Item_Factura (Factura_Nro, Item_Factura_Cant, Item_Factura_Monto)
	SELECT DISTINCT M.Factura_Nro,Item_Factura_Cantidad, Item_Factura_Monto
	FROM gd_esquema.Maestra AS M
	WHERE Factura_Nro IS NOT NULL
	ORDER BY M.Factura_Nro

	
END
go

create procedure FOUR_SIZONS.AltaUsuario
	@username nvarchar(15),
	@password nvarchar(15),
	@rolNombre nvarchar(50),
	@nombre nvarchar(50),
	@apellido nvarchar(50),
	@tipoDoc nvarchar(50),
	@numDoc numeric (18),
	@mail nvarchar(50),
	@telefono nvarchar(18),
	@direccion nvarchar(255),
	@fechaNac datetime,
	@hotelNombre nvarchar(50)

	AS
	BEGIN try
	begin tran
	
	declare @hotelId numeric(18)
	declare @rolId numeric(18)
	
	set @rolId= (select Rol_codigo from FOUR_SIZONS.rol where @rolNombre = rol_nombre)
	set @hotelId = (select hotel_codigo from FOUR_SIZONS.hotel where @hotelNombre = hotel_nombre)
	 
	insert into FOUR_SIZONS.usuario(Usuario_ID,Usuario_Password,Usuario_Nombre,Usuario_Apellido,Usuario_TipoDoc, Usuario_NroDoc ,Usuario_Direccion,Usuario_Fec_Nac,Usuario_Mail, Usuario_Estado , Usuario_FallaLog)
							values(@username,@password,@nombre,@apellido,@tipoDoc,@numDoc,@direccion,@fechaNac,@mail,1,0)

	insert into FOUR_SIZONS.UsuarioXHotel(Hotel_Codigo,Usuario_ID,UsuarioXHotel_Estado) values (@hotelId,@username,1)
	insert into FOUR_SIZONS.UsuarioXRol(Rol_Codigo,Usuario_ID,UsuarioXRol_Estado) values (@rolId, @username,1)
	commit tran 
end try
begin catch
 select ERROR_MESSAGE () as mensaje_de_error;
rollback tran 
end catch
	
go



create procedure FOUR_SIZONS.ModificacionUsuario
	@username nvarchar(15),
	@password nvarchar(15),
	@rolNombre nvarchar(50),
	@nombre nvarchar(50),
	@apellido nvarchar(50),
	@tipoDoc nvarchar(50),
	@numDoc numeric (18),
	@mail nvarchar(50),
	@telefono nvarchar(18),
	@direccion nvarchar(255),
	@fechaNac datetime,
	@hotelNombre nvarchar(50),
	@estado bit

	as begin tran
	begin try

	declare @hotelId numeric(18)
	declare @rolId numeric(18)

	set @rolId= (select Rol_codigo from FOUR_SIZONS.rol where @rolNombre = rol_nombre)
	set @hotelId = (select hotel_codigo from FOUR_SIZONS.hotel where @hotelNombre = hotel_nombre)
	
	update FOUR_SIZONS.usuario
				set Usuario_Password = @username,Usuario_Nombre =@nombre,Usuario_Apellido = @apellido ,
				Usuario_TipoDoc =@tipoDoc,Usuario_NroDoc =@numDoc,Usuario_Telefono =@telefono,
				Usuario_Direccion= @direccion,Usuario_Fec_Nac = @fechaNac,Usuario_Mail =@mail,Usuario_Estado=@estado

				where Usuario_ID=@username

	update FOUR_SIZONS.UsuarioXRol 
				set Rol_Codigo = @rolId    
				where Usuario_ID=@username   
	
	-- me faltaria hacer la modificacion de hotel, pero ahi deberia poder agregarle un hotel o cambiarselo (ya que los users pueden estar en muchos hoteles)
	-- creo que deberia ser en un proc aparte
	commit tran 
end try
begin catch
 select ERROR_MESSAGE () as mensaje_de_error;
rollback tran 
end catch
go
-- la baja de un usuario no la hago, ya que en la modificacion se puede hacer directamente cambiandole el estado a 0

create procedure four_sizons.AltaCliente
@nombre nvarchar(50),
@apellido nvarchar(50),
@numDoc numeric (18),
@tipoDoc nvarchar(50),
@mail nvarchar(50),
@telefono nvarchar(18),
@calle nvarchar(255),
@numCalle numeric(18),
@piso numeric(18),
@depto nvarchar(18),
--@localidad nvarchar(50),
@nacionalidad nvarchar(50),
@fechaNac datetime

as begin try
begin tran

if(not exists (select cliente_codigo from cliente where @mail = Cliente_Mail))
insert into four_sizons.Cliente(Cliente_Nombre ,cliente_Apellido,cliente_TipoDoc, Cliente_NumDoc,Cliente_Dom_Calle,Cliente_Nro_Calle
								,Cliente_Piso,Cliente_Depto /*,cliente_localidad*/,Cliente_Mail,Cliente_Nacionalidad,Cliente_Fecha_Nac,Cliente_Puntos,Cliente_Estado,Cliente_Consistente)
								values (@nombre,@apellido,@tipoDoc,@numDoc,@calle,@numCalle,@piso,@depto,/*@localidad,*/ @mail,@nacionalidad,@fechaNac,0,1,1)
else 
PRINT N'el mail ingresado ya figura en el sistema, ingrese otro por favor';
commit tran 
end try
begin catch
 select ERROR_MESSAGE () as mensaje_de_error;
rollback tran 
end catch
go

create procedure four_sizons.modificacionCliente
@nombre nvarchar(50),
@apellido nvarchar(50),
@numDoc numeric (18),
@tipoDoc nvarchar(50),
@mail nvarchar(50),
@telefono nvarchar(18),
@calle nvarchar(255),
@numCalle numeric(18),
@piso numeric(18),
@depto nvarchar(18),
--@localidad nvarchar(50),
@nacionalidad nvarchar(50),
@fechaNac datetime,
@estado bit,
@codigo nvarchar(50)


as begin tran
begin try

if (not exists (select Cliente_codigo from cliente where Cliente_Codigo!=@codigo and Cliente_Mail= @mail))
update FOUR_SIZONS.Cliente
set Cliente_Nombre=@nombre ,cliente_Apellido=@apellido,cliente_TipoDoc=@tipoDoc, Cliente_NumDoc = @numDoc,
		Cliente_Dom_Calle=@calle,Cliente_Nro_Calle=@numCalle,Cliente_Piso=@piso,Cliente_Depto=@depto
		 /*,cliente_localidad=@localidad*/,Cliente_Mail=@mail,Cliente_Nacionalidad=@nacionalidad,
		 Cliente_Fecha_Nac=@fechaNac,Cliente_Estado=@estado

	where Cliente_Codigo = @codigo
else print N'el mail ingresado ya figura en el sistema, ingrese otro por favor'

commit tran 
end try
begin catch
 select ERROR_MESSAGE () as mensaje_de_error;
rollback tran 
end catch
go
-- la localidad deberiamos agregarla, xq se carga en el momento de hacer el alta de cliente

create procedure four_sizons.AltaHotel
@nombre nvarchar(50),
@mail nvarchar(50),
@telefono nvarchar(50),
@calle nvarchar(50),
@numCalle numeric(18),
@cantEstrellas numeric(18),
@ciudad nvarchar(50),
@pais nvarchar(50),
@fechaCreacion datetime

as begin try
begin tran 

insert into FOUR_SIZONS.Hotel(Hotel_Nombre,Hotel_Mail,Hotel_Telefono,Hotel_Calle,Hotel_Nro_Calle,
					Hotel_CantEstrella,Hotel_Ciudad,Hotel_Pais,Hotel_FechaCreacion,Hotel_Estado)
					values (@nombre,@mail,@telefono,@calle,@numCalle,@cantEstrellas,@ciudad,@pais,@fechaCreacion,1)
--faltaria cargar los regimenes, pero al ser uno o muchos deberia hacer un proc a parte para regXhot?
commit tran 
end try
begin catch
 select ERROR_MESSAGE () as mensaje_de_error;
rollback tran 
end catch
go

create procedure four_sizons.modificarHotel
@nombre nvarchar(50),
@mail nvarchar(50),
@telefono nvarchar(50),
@calle nvarchar(50),
@numCalle numeric(18),
@cantEstrellas numeric(18),
@ciudad nvarchar(50),
@pais nvarchar(50),
@fechaCreacion datetime,
@estado bit,
@codigo nvarchar(50)

as 
begin tran 
begin try
update FOUR_SIZONS.Hotel
set Hotel_Nombre= @nombre,Hotel_Mail= @mail,Hotel_Telefono=@telefono,Hotel_Calle=@calle ,
	Hotel_Nro_Calle=@numCalle,Hotel_CantEstrella=@cantEstrellas,Hotel_Ciudad=@ciudad,
	Hotel_Pais=@pais,Hotel_FechaCreacion=@fechaCreacion,Hotel_Estado=@estado

	where Hotel_Codigo=@codigo
commit tran 
end try
begin catch
 select ERROR_MESSAGE () as mensaje_de_error;
rollback tran 
end catch
go





