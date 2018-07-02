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

	IF (OBJECT_ID('FOUR_SIZONS.Reserva', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Reserva
	END

	IF (OBJECT_ID('FOUR_SIZONS.Habitacion_Tipo', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Habitacion_Tipo
	END

	

	IF (OBJECT_ID('FOUR_SIZONS.sec_cod_reserva', 'SO') IS NOT NULL)
	BEGIN
		DROP SEQUENCE FOUR_SIZONS.sec_cod_reserva
	END

	IF (OBJECT_ID('FOUR_SIZONS.Regimen', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.Regimen
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
			Parametro_NroItem numeric(18) IDENTITY,
			Parametro_Descripcion nvarchar(255)

			CONSTRAINT PK_Parametros PRIMARY KEY (Parametro_Codigo, Parametro_NroItem)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Funcionalidad')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Funcionalidad (
			Func_Codigo numeric(18,0) IDENTITY,
			Func_Nombre varchar(50),
			Func_Estado bit,
			CONSTRAINT PK_Funcionalidad PRIMARY KEY(Func_Codigo)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Rol')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Rol (
			Rol_Codigo numeric(18,0) IDENTITY,
			Rol_Nombre nvarchar(50) UNIQUE,
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
				Usuario_Password nvarchar(100) NOT NULL,
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
			Habitacion_Descripcion nvarchar(255),
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
			Cliente_Localidad nvarchar(255),
			Cliente_Dom_Calle nvarchar(255),
			Cliente_Nro_Calle numeric(18),
			Cliente_Piso numeric(18),
			Cliente_Depto nvarchar(50) ,
			Cliente_Mail nvarchar(255) NOT NULL,
			Cliente_Telefono nvarchar(18),
			Cliente_Pais nvarchar(50),
			Cliente_Ciudad nvarchar(100),
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
			tarjeta_estado bit,
			Cliente_Codigo numeric(18)

			CONSTRAINT FK_Tarjeta FOREIGN KEY (Cliente_Codigo) REFERENCES FOUR_SIZONS.Cliente(Cliente_Codigo),
			CONSTRAINT PK_Tarjeta PRIMARY KEY (Tarjeta_Numero)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Reserva')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Reserva (
			Reserva_Codigo numeric(18),
			Reserva_FechaCreacion datetime default GETDATE(),
			Reserva_Fecha_Inicio datetime,
			Reserva_Fecha_Fin datetime,
			Reserva_Cant_Noches numeric(18),
			Reserva_Precio decimal(12,2) default 0.00,
			Usuario_ID nvarchar(15),
			Hotel_Codigo numeric(18),
			Cliente_Codigo numeric(18),
			Regimen_Codigo numeric(18),
			Reserva_Estado decimal(1),
			Reserva_cant_hab numeric(18),
			habitacion_tipo_codigo numeric (18),



			CONSTRAINT FK_Reserva_1 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),
			CONSTRAINT FK_Reserva_2 FOREIGN KEY (Hotel_Codigo) REFERENCES FOUR_SIZONS.Hotel(Hotel_Codigo),
			CONSTRAINT FK_Reserva_3 FOREIGN KEY (Cliente_Codigo) REFERENCES FOUR_SIZONS.Cliente(Cliente_Codigo),
			CONSTRAINT FK_Reserva_4 FOREIGN KEY (Regimen_Codigo) REFERENCES FOUR_SIZONS.Regimen(Regimen_Codigo),
			CONSTRAINT FK_Reserva_5 FOREIGN KEY (habitacion_tipo_codigo) REFERENCES FOUR_SIZONS.habitacion_tipo(habitacion_tipo_codigo),

			CONSTRAINT PK_Reserva PRIMARY KEY (Reserva_Codigo)
		)		
	END

	IF NOT EXISTS (SELECT * FROM sys.sequences WHERE name = 'FOUR_SIZONS.sec_cod_reserva')
	BEGIN
		CREATE SEQUENCE FOUR_SIZONS.sec_cod_reserva
		START WITH 110000
		INCREMENT BY 1;
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ReservaMod')
	BEGIN
		CREATE TABLE FOUR_SIZONS.ReservaMod (
			ResMod_Codigo numeric(18),
			Reserva_Codigo numeric(18),
			Usuario_ID nvarchar(15),
			ResMod_Detalle nvarchar(255),
			ResMod_Fecha datetime default GETDATE(),
			
			CONSTRAINT FK_ReservaMod_1 FOREIGN KEY (Reserva_Codigo) REFERENCES FOUR_SIZONS.Reserva(Reserva_Codigo),
			CONSTRAINT FK_ReservaMod_2 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),

			CONSTRAINT PK_ReservaMod PRIMARY KEY (ResMod_Codigo, Reserva_Codigo, Usuario_ID)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Habitacion_TipoXReser')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Habitacion_TipoXReser (
			Reserva_Codigo numeric(18),
			Habitacion_Tipo_Codigo numeric(18),	
			HabTipoXRes_CantHab numeric(18),		

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
			Estadia_DiasRest numeric(18),
			Estadia_PreXNoche numeric(18),
			Usuario_ID nvarchar(15),
			Usuario_OUT nvarchar(15),
			Habitacion_Numero numeric(18),
			Hotel_Codigo numeric(18),
			Estadia_Estado bit

			CONSTRAINT FK_Estadia_1 FOREIGN KEY (Reserva_Codigo) REFERENCES FOUR_SIZONS.Reserva(Reserva_Codigo),
			CONSTRAINT FK_Estadia_2 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),
			CONSTRAINT FK_Estadia_3 FOREIGN KEY (Habitacion_Numero, Hotel_Codigo) REFERENCES FOUR_SIZONS.Habitacion(Habitacion_Numero, Hotel_Codigo),
			CONSTRAINT FK_Estadia_4 FOREIGN KEY (Usuario_OUT) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),

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
			estXcons_cantidad numeric(18) default 1,


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
			Factura_Estado bit,
			Factura_Consistencia bit,
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
			Item_Factura_NroItem numeric(18) IDENTITY(1,1) NOT NULL,
			Item_Factura_Cant numeric(18),
			item_descripcion nvarchar(50),
			Item_Factura_Monto decimal(18,2),
		


			CONSTRAINT FK_Item_Factura FOREIGN KEY (Factura_Nro) REFERENCES FOUR_SIZONS.Factura(Factura_Nro),
			
			CONSTRAINT PK_Item_Factura PRIMARY KEY (Factura_Nro, Item_Factura_NroItem)
		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Disponibilidad')
	BEGIN
		CREATE TABLE FOUR_SIZONS.Disponibilidad (
			Disp_Fecha datetime,
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
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'PASSP')

	-- Roles
	INSERT INTO FOUR_SIZONS.Rol VALUES ('Super Admin', 1)
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
		where R.Rol_Nombre =  'Super Admin' and
				F.Func_Nombre in ('ABM Rol', 'ABM Hotel','ABM Habitacion','ABM Regimen','ABM Usuario',
				'ABM Cliente','Generar/Modificar Reserva','Cancelar Reserva','Registrar Estadia',
				'Registrar Consumibles', 'Listado Estadistico');

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
	Habitacion_Estado)--, Habitacion_Descripcion) 
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
	VALUES ('SYSADM', '3GGQyLOZ4EO537rLsNN/KiZF4z+ZOEkdJLJOApjZzRc=', 'Administrador', '', '', 0, '', '', GETDATE(), '',1,0)
	INSERT INTO FOUR_SIZONS.Usuario
	VALUES ('GUEST', '3GGQyLOZ4EO537rLsNN/KiZF4z+ZOEkdJLJOApjZzRc=', 'Guest', '', '', 0, '', '', GETDATE(), '',1,0)

	--UsuarioXRol
	INSERT INTO FOUR_SIZONS.UsuarioXRol VALUES ('SYSADM', 1, 1)
	INSERT INTO FOUR_SIZONS.UsuarioXRol VALUES ('GUEST', 3, 1)


	-- disponibilidad


	declare @tipohab numeric = 1001
while(@tipohab<1006)
begin
declare @hotel numeric = 1


while(@hotel <16)
begin
declare @aux datetime = convert(datetime, '01-01-2017' ,121)

declare @aux2 datetime
declare @fin datetime= convert(datetime, '01-01-2021' ,121)
declare @cantHab numeric(18) = isnull((select count(h.Habitacion_Numero) from FOUR_SIZONS.Hotel ho , FOUR_SIZONS.Habitacion_Tipo ht , FOUR_SIZONS.Habitacion h where ho.Hotel_Codigo=@hotel and h.Hotel_Codigo= ho.Hotel_Codigo and h.Habitacion_Tipo_Codigo= ht.Habitacion_Tipo_Codigo and ht.Habitacion_Tipo_Codigo=@tipohab group by ho.Hotel_Codigo,ht.Habitacion_Tipo_Descripcion),0)


while (@aux != @fin)
begin
set @aux2= @aux 
insert into FOUR_SIZONS.Disponibilidad(Disp_Fecha,Disp_HabDisponibles,Habitacion_Tipo_Codigo,Hotel_Codigo)
								values(@aux , @cantHab,@tipohab,@hotel)
set @aux = DATEADD(day, 1, @aux2)
end

set @hotel = @hotel+1
end
set @tipohab = @tipohab+1
end












	-- Reservas
	INSERT INTO FOUR_SIZONS.Reserva (Reserva_Codigo, Reserva_FechaCreacion, Reserva_Fecha_Inicio, Reserva_Fecha_Fin,
	Reserva_Cant_Noches, Reserva_Precio, Usuario_ID, Hotel_Codigo, Cliente_Codigo, Reserva_Estado,regimen_codigo,habitacion_tipo_codigo,reserva_cant_hab)
	SELECT DISTINCT M.Reserva_Codigo, M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio, 
	M.Reserva_Cant_Noches, 0, 'SYSADM', H.Hotel_Codigo, C.Cliente_Codigo, 1 , r.regimen_codigo,HT.habitacion_tipo_codigo,1
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Ciudad = M.Hotel_Ciudad and H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	JOIN FOUR_SIZONS.Regimen AS R ON R.Regimen_Descripcion = M.Regimen_Descripcion
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	JOIN FOUR_SIZONS.habitacion_tipo AS HT ON ht.habitacion_tipo_codigo = M.habitacion_tipo_codigo
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

	
	

    --PRIMERO TIENE QUE SER LA MIGRACION DE FACTURA E ITEMS
		/**Toma las Facturas, en la que la suma de sus items no es igual a la fact_total **/
	DECLARE @facturaInc TABLE(
		facturaI numeric(18)
	)

	INSERT INTO @facturaInc (facturaI)
	SELECT F.Factura_Nro
	FROM FOUR_SIZONS.Factura F JOIN FOUR_SIZONS.Item_Factura i on f.Factura_Nro = i.Factura_Nro
	group by F.Factura_Nro,F.Factura_Total
	having F.Factura_Total != sum(i.Item_Factura_Monto)
	
	UPDATE FOUR_SIZONS.Factura
	SET Factura_Consistencia = 0
	WHERE Factura_Nro IN (select facturaI from @facturaInc)

END
go
-------------------------------------------------------Comienzo de procedures--------------------------------------------------------------

-- Borrado de procedures en la base
IF (OBJECT_ID('FOUR_SIZONS.ValidarUsuario', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.ValidarUsuario
END;


IF (OBJECT_ID('FOUR_SIZONS.AltaUsuario', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.AltaUsuario
END;

IF (OBJECT_ID('FOUR_SIZONS.altaUserXHot', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.altaUserXHot
END;

IF (OBJECT_ID('FOUR_SIZONS.ModificacionUsuario', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.ModificacionUsuario
END;

IF (OBJECT_ID('FOUR_SIZONS.AltaCliente', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.AltaCliente
END;

IF (OBJECT_ID('FOUR_SIZONS.modificacionCliente', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.modificacionCliente
END;

IF (OBJECT_ID('FOUR_SIZONS.AltaHotel', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.AltaHotel
END;

IF (OBJECT_ID('FOUR_SIZONS.altaRegXHotel', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.altaRegXHotel
END;

IF (OBJECT_ID('FOUR_SIZONS.modificarHotel', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.modificarHotel
END;

IF (OBJECT_ID('FOUR_SIZONS.InsertarRol', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.InsertarRol
END;

IF (OBJECT_ID('FOUR_SIZONS.ModificacionRol', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.ModificacionRol
END;

IF (OBJECT_ID('FOUR_SIZONS.altaRolxFunc', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.altaRolxFunc
END;

IF (OBJECT_ID('FOUR_SIZONS.modificacionRolxFunc', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.modificacionRolxFunc
END;

IF (OBJECT_ID('FOUR_SIZONS.AltaHabitacion', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.AltaHabitacion
END;

IF (OBJECT_ID('FOUR_SIZONS.modificarHabitacion', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.modificarHabitacion
END;

IF (OBJECT_ID('FOUR_SIZONS.GenerarReserva', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.GenerarReserva
END;

IF (OBJECT_ID('FOUR_SIZONS.modificarReserva', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.modificarReserva
END;

IF (OBJECT_ID('FOUR_SIZONS.altaTipoHabXRes', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.altaTipoHabXRes
END;
GO

IF (OBJECT_ID('FOUR_SIZONS.agregarTarjeta', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.AgregarTarjeta
END;

IF (OBJECT_ID('FOUR_SIZONS.cancelarTarjeta', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.cancelarTarjeta
END;

IF (OBJECT_ID('FOUR_SIZONS.bajarDisponibilidad', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.bajarDisponibilidad
END;

IF (OBJECT_ID('FOUR_SIZONS.cerrarHotel', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.cerrarHotel
END;

IF (OBJECT_ID('FOUR_SIZONS.generarFactura', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.generarFactura
END;

IF (OBJECT_ID('FOUR_SIZONS.ModificarFactura', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.ModificarFactura
END;

IF (OBJECT_ID('FOUR_SIZONS.registrarCheckIn', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.registrarCheckIn
END;

IF (OBJECT_ID('FOUR_SIZONS.registrarCheckOut', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.registrarCheckOut
END;

IF (OBJECT_ID('FOUR_SIZONS.HotelesMasReservasC', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.HotelesMasReservasC
END;

IF (OBJECT_ID('FOUR_SIZONS.RegistrarConsXest', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.RegistrarConsXest
END;

IF (OBJECT_ID('FOUR_SIZONS.HotelesMayorConsFact', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.HotelesMayorConsFact
END;

IF (OBJECT_ID(N'FOUR_SIZONS.calcConsumible', 'FN' ) IS NOT NULL)
BEGIN

    DROP FUNCTION FOUR_SIZONS.calcConsumible
END;

IF (OBJECT_ID(N'FOUR_SIZONS.verificarDisp', 'FN' ) IS NOT NULL)
BEGIN

    DROP FUNCTION FOUR_SIZONS.verificarDisp
END;

IF (OBJECT_ID('FOUR_SIZONS.calcEstadia', 'IF') IS NOT NULL)
BEGIN
    DROP FUNCTION FOUR_SIZONS.calcEstadia
END;

IF (OBJECT_ID('FOUR_SIZONS.inicioTri', 'FN') IS NOT NULL)
BEGIN

    DROP FUNCTION FOUR_SIZONS.inicioTri
END;

IF (OBJECT_ID('FOUR_SIZONS.finTri', 'FN') IS NOT NULL)
BEGIN
    DROP FUNCTION FOUR_SIZONS.finTri
END;

IF (OBJECT_ID('FOUR_SIZONS.calcPuntaje', 'FN') IS NOT NULL)
BEGIN
    DROP FUNCTION FOUR_SIZONS.calcPuntaje
END;

IF (OBJECT_ID('FOUR_SIZONS.calcEstadia', 'FN') IS NOT NULL)
BEGIN
    DROP FUNCTION FOUR_SIZONS.calcEstadia
END;

IF (OBJECT_ID('FOUR_SIZONS.RegistrarEstadiaXCliente', 'P') IS NOT NULL)
BEGIN
    DROP proc FOUR_SIZONS.RegistrarEstadiaXCliente
END;

IF (OBJECT_ID('FOUR_SIZONS.hotelMasCerrado', 'P') IS NOT NULL)
BEGIN
    DROP proc FOUR_SIZONS.hotelMasCerrado
END;

IF (OBJECT_ID('FOUR_SIZONS.habOcupadas', 'P') IS NOT NULL)
BEGIN
    DROP proc FOUR_SIZONS.habOcupadas
END;

IF (OBJECT_ID('FOUR_SIZONS.clieMayorPuntaje', 'P') IS NOT NULL)
BEGIN
    DROP proc FOUR_SIZONS.clieMayorPuntaje
END;

GO

--------------------------------------------------------ABM USUARIO------------------------------
create procedure FOUR_SIZONS.ValidarUsuario
@usuario nvarchar(15), 
@password nvarchar(100),
@loginok decimal(1) output,
@errorMsg nvarchar(100) output
as
begin try
	declare @fallalog decimal(1)
	declare @passret nvarchar(100)
	declare @estado bit
	if exists (select * from FOUR_SIZONS.Usuario where Usuario_ID = @usuario)
	begin
		select @fallalog = Usuario_FallaLog, @passret = Usuario_Password, @estado = Usuario_Estado from FOUR_SIZONS.Usuario where Usuario_ID = @usuario
		if @estado = 1
		begin


			if @fallalog <> 3
			begin

				if @passret = @password
				begin

					set @loginok = 1
					if @fallalog <> 0
						update FOUR_SIZONS.Usuario set Usuario_FallaLog = 0
				end
				else
				begin
					if @fallalog = 2
					begin



						update FOUR_SIZONS.Usuario set Usuario_FallaLog = Usuario_FallaLog + 1, Usuario_Estado = 0
						set @loginok = 0
						set @errorMsg = 'Contraseña incorrecta. El usuario está deshabilitado'
					end

					if @fallalog < 2
					begin


						update FOUR_SIZONS.Usuario set Usuario_FallaLog = Usuario_FallaLog + 1
						set @loginok = 0
						set @errorMsg = 'Contraseña incorrecta.'

						if @fallalog = 1
						begin





							set @errorMsg = 'Contraseña incorrecta. El usuario se deshabilitará ante el próximo inicio de sesión inválido'

						end
					end
				end





			end
			else
			begin
				set @loginok = 0
				set @errorMsg = 'El usuario está deshabilitado'
			end
		end
		else
		begin
			set @loginok = 0
			set @errorMsg = 'El usuario está deshabilitado'
		end
	end

	else
	begin
		set @loginok = 0
		set @errorMsg = 'El usuario no existe'
	end
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
end catch
go












create procedure FOUR_SIZONS.AltaUsuario
	@username nvarchar(15),
	@password nvarchar(100),
	@rolNombre nvarchar(50),
	@nombre nvarchar(50),
	@apellido nvarchar(50),
	@tipoDoc nvarchar(50),
	@numDoc numeric (18),
	@mail nvarchar(50),
	@telefono nvarchar(18),
	@direccion nvarchar(255),

	@fechaNac datetime

	AS
	BEGIN try
	begin tran
	
	declare @hotelId numeric(18)
	declare @rolId numeric(18)
	
	set @rolId= (select Rol_codigo from FOUR_SIZONS.rol where @rolNombre = rol_nombre)
	 
	insert into FOUR_SIZONS.usuario(Usuario_ID,Usuario_Password,Usuario_Nombre,Usuario_Apellido,Usuario_TipoDoc, Usuario_NroDoc,Usuario_Telefono,Usuario_Direccion,Usuario_Fec_Nac,Usuario_Mail, Usuario_Estado , Usuario_FallaLog)
							values(@username,@password,@nombre,@apellido,@tipoDoc,@numDoc,@telefono,@direccion,@fechaNac,@mail,1,0)

	insert into FOUR_SIZONS.UsuarioXRol(Rol_Codigo,Usuario_ID,UsuarioXRol_Estado) values (@rolId, @username,1)
	commit tran 
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
end catch
	
go

create procedure four_sizons.altaUserXHot
	@hotId numeric(18),
	@usuario nvarchar(50),
	@estado bit

	as begin tran 
	begin try
	--declare @hotID numeric (18)

	--set @hotId = (select hotel_codigo from FOUR_SIZONS.hotel where @hotel = hotel_nombre)

	if(exists (select Usuario_ID  from FOUR_SIZONS.UsuarioXHotel where @usuario = Usuario_ID and @hotID = Hotel_Codigo))
	update FOUR_SIZONS.UsuarioXHotel 
			set UsuarioXHotel_Estado = @estado
			where Usuario_ID = @usuario and Hotel_Codigo = @hotID

	else
	insert into FOUR_SIZONS.UsuarioXHotel(Hotel_Codigo,Usuario_ID,UsuarioXHotel_Estado) values (@hotId,@usuario,1)
	commit tran
	end try
	begin catch 
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
	end catch

go

create procedure FOUR_SIZONS.ModificacionUsuario
	@username nvarchar(15),
	@password nvarchar(100),
	@rolNombre nvarchar(50),
	@nombre nvarchar(50),
	@apellido nvarchar(50),
	@tipoDoc nvarchar(50),
	@numDoc numeric (18),
	@mail nvarchar(50),
	@telefono nvarchar(18),
	@direccion nvarchar(255),

	@fechaNac datetime,
	@estado bit

	as begin tran
	begin try

	declare @hotelId numeric(18)
	declare @rolId numeric(18)

	set @rolId= (select Rol_codigo from FOUR_SIZONS.rol where @rolNombre = rol_nombre)
	--set @hotelId = (select hotel_codigo from FOUR_SIZONS.hotel where @hotelNombre = hotel_nombre)

	--si estado se modifica a activo se resetea el campo falla_log
	if(@estado = 1)
	begin

		update FOUR_SIZONS.usuario
				set Usuario_Password = @username,Usuario_Nombre =@nombre,Usuario_Apellido = @apellido ,
				Usuario_TipoDoc =@tipoDoc,Usuario_NroDoc =@numDoc,Usuario_Telefono =@telefono,
				Usuario_Direccion= @direccion,Usuario_Fec_Nac = @fechaNac,Usuario_Mail =@mail,Usuario_Estado=@estado,
				Usuario_FallaLog = 0

				where Usuario_ID=@username
	end
	else
	begin

			update FOUR_SIZONS.usuario
				set Usuario_Password = @username,Usuario_Nombre =@nombre,Usuario_Apellido = @apellido ,
				Usuario_TipoDoc =@tipoDoc,Usuario_NroDoc =@numDoc,Usuario_Telefono =@telefono,
				Usuario_Direccion= @direccion,Usuario_Fec_Nac = @fechaNac,Usuario_Mail =@mail,Usuario_Estado=@estado

				where Usuario_ID=@username
	end

	update FOUR_SIZONS.UsuarioXRol 
				set Rol_Codigo = @rolId    
				where Usuario_ID=@username   
	
	-- me faltaria hacer la modificacion de hotel, pero ahi deberia poder agregarle un hotel o cambiarselo (ya que los users pueden estar en muchos hoteles)
	-- creo que deberia ser en un proc aparte
	commit tran 
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
end catch
go

------------------------------------------------ABM CLIENTE------------------------------------------------------------
create procedure four_sizons.AltaCliente
@nombre nvarchar(50),
@apellido nvarchar(50),
@numDoc numeric (18),
@tipoDoc nvarchar(50),
@mail nvarchar(50),
@telefono nvarchar(18),
@pais nvarchar(50),
@ciudad nvarchar(100),
@calle nvarchar(255),
@numCalle numeric(18),
@piso numeric(18),
@depto nvarchar(18),
@localidad nvarchar(50),
@nacionalidad nvarchar(50),
@fechaNac datetime

as begin try
begin tran

if(not exists (select cliente_codigo from cliente where @mail = Cliente_Mail))
insert into four_sizons.Cliente(Cliente_Nombre ,cliente_Apellido,cliente_TipoDoc, Cliente_NumDoc,Cliente_Dom_Calle,Cliente_Nro_Calle
								,Cliente_Piso,Cliente_Depto,Cliente_Localidad,Cliente_Mail,Cliente_Telefono, Cliente_Pais, Cliente_Ciudad,
								Cliente_Nacionalidad,Cliente_Fecha_Nac,Cliente_Puntos,Cliente_Estado,Cliente_Consistente)
								values (@nombre,@apellido,@tipoDoc,@numDoc,@calle,@numCalle,@piso,@depto,@localidad,@mail,@telefono,
								@pais,@ciudad,@nacionalidad,@fechaNac,0,1,1)
else 
RAISERROR('el mail ingresado ya figura en el sistema, ingrese otro por favor',1,1)
		ROLLBACK TRANSACTION
commit tran 
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
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
@localidad nvarchar(50),
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
		 ,cliente_localidad=@localidad,Cliente_Mail=@mail,Cliente_Nacionalidad=@nacionalidad,
		 Cliente_Fecha_Nac=@fechaNac,Cliente_Estado=@estado

	where Cliente_Codigo = @codigo
else RAISERROR('el mail ingresado ya figura en el sistema, ingrese otro por favor',1,1)
		ROLLBACK TRANSACTION

commit tran 
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
end catch
go


-------------------------------------------------ABM HOTEL------------------------------------------------------------------------
create procedure four_sizons.AltaHotel
@nombre nvarchar(50),
@mail nvarchar(50),
@telefono nvarchar(50),
@calle nvarchar(50),
@numCalle numeric(18),
@cantEstrellas numeric(18),
@recarga_estrella numeric(5),
@ciudad nvarchar(50),
@pais nvarchar(50),
@fechaCreacion datetime

as begin try
begin tran

insert into FOUR_SIZONS.Hotel(Hotel_Nombre,Hotel_Mail,Hotel_Telefono,Hotel_Calle,Hotel_Nro_Calle,
					Hotel_CantEstrella,Hotel_Recarga_Estrella, Hotel_Ciudad,Hotel_Pais,Hotel_FechaCreacion,Hotel_Estado)
					values (@nombre,@mail,@telefono,@calle,@numCalle,@cantEstrellas,@recarga_estrella,@ciudad,@pais,@fechaCreacion,1)

commit tran 
end try
begin catch
	
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
end catch
go


create procedure four_sizons.altaRegXHotel
@regimen nvarchar(50),
@hotel nvarchar(50)

as begin tran 
begin try 

declare @regID nvarchar(50)
declare @hotID nvarchar(50)

set @regID = (select Regimen_Codigo  from four_sizons.regimen where Regimen_Descripcion = @regimen)
set @hotID = (select Hotel_Codigo from FOUR_SIZONS.Hotel where Hotel_Nombre = @hotel)

insert into FOUR_SIZONS.RegXHotel(Hotel_Codigo,Regimen_Codigo,RegXHotel_Estado) 
							values (@hotID,@regID,1)

commit tran 
end try


begin catch
declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran  
end catch 
go

-- faltaria poder modificar el regXhotel, para poder darle de baja (seria igual al de userXhotel)

create procedure four_sizons.modificarHotel
@codigo nvarchar(50),
@nombre nvarchar(50),
@mail nvarchar(50),
@telefono nvarchar(50),
@calle nvarchar(50),
@numCalle numeric(18),
@cantEstrellas numeric(18),
@recarga_estrella numeric(5),
@ciudad nvarchar(50),
@pais nvarchar(50),
@fechaCreacion datetime,
@estado bit

as 
begin tran 
begin try
update FOUR_SIZONS.Hotel
set Hotel_Nombre= @nombre,Hotel_Mail= @mail,Hotel_Telefono=@telefono,Hotel_Calle=@calle ,
	Hotel_Nro_Calle=@numCalle,Hotel_CantEstrella=@cantEstrellas,Hotel_Recarga_Estrella=@recarga_estrella,
	Hotel_Ciudad=@ciudad,Hotel_Pais=@pais,Hotel_FechaCreacion=@fechaCreacion,Hotel_Estado=@estado

	where Hotel_Codigo=@codigo
commit tran 
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
end catch
go

------------------------------------------------ABM ROL---------------------------------------------------------------------------
create proc FOUR_SIZONS.InsertarRol
		
		@rolname nvarchar(50),
		@estado bit
		
		as
		BEGIN TRY
		BEGIN TRANSACTION
		
		insert into FOUR_SIZONS.Rol (rol_nombre,rol_estado) values(@rolname,@estado);
		
		COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
		declare @mensaje_de_error nvarchar(255)
		set @mensaje_de_error = ERROR_MESSAGE()
		RAISERROR(@mensaje_de_error,11,1)
		rollback tran  




		END CATCH
	GO

create procedure FOUR_SIZONS.ModificacionRol




	@rolname nvarchar(50),

	@codigo numeric(18),




	@estado bit



	as begin tran
	begin try
		
	update FOUR_SIZONS.Rol



				set Rol_Nombre= @rolname,Rol_Estado= @estado
			where Rol_Codigo=@codigo


	
	commit tran 
	end try
	begin catch
	
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
	end catch
go




create procedure four_sizons.altaRolxFunc
@rolname nvarchar(50),
@func nvarchar(50)

as begin tran 
begin try 
	declare @rolID nvarchar(50)
	declare @funcID nvarchar(50)


	set @rolID = (select Rol_Codigo  from four_sizons.Rol where Rol_Nombre = @rolname)

	set @funcID = (select Func_Codigo from FOUR_SIZONS.Funcionalidad where Func_Nombre = @func)

	insert into FOUR_SIZONS.RolXFunc(Rol_Codigo,Func_Codigo,RolXFunc_Estado) 
							values (@rolID,@funcID,1)
	commit tran

end try

begin catch
	declare @mensaje_de_error nvarchar(255)

	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran  
end catch 
go


create procedure four_sizons.modificacionRolxFunc
@rolname nvarchar(50),
@func nvarchar(50),
@estado bit

as begin tran 
begin try

	declare @rolID numeric(18)	
	declare @funcID numeric(18)	
	
	set @rolID = (select Rol_Codigo  from four_sizons.Rol where Rol_Nombre = @rolname)	
	set @funcID = (select Func_Codigo from FOUR_SIZONS.Funcionalidad where Func_Nombre = @func)

	if exists(select * from FOUR_SIZONS.RolXFunc where Rol_Codigo=@rolID and Func_Codigo=@funcID)
	begin
		update FOUR_SIZONS.RolXFunc
			set RolXFunc_Estado = @estado
		where Rol_Codigo=@rolID and Func_Codigo=@funcID
	end
	else
	begin
		exec four_sizons.altaRolxFunc @rolname, @func
	end

	commit tran 
	end try

	begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran  
	end catch 
go


--------------------------------------------------ABM HABITACION-------------------------------------------------------------
create procedure four_sizons.AltaHabitacion
@numero numeric(18),
@piso numeric(18),
@frente nvarchar(50),
@HotelId numeric(18),
@TipoHab nvarchar(255),
@descripcion nvarchar(255)


as begin try
begin tran 
declare @TipoHabID numeric(18)
	


		set @TipoHabID = (select Habitacion_Tipo_Codigo from FOUR_SIZONS.Habitacion_Tipo where @TipoHab = Habitacion_Tipo_Descripcion)

		--Valida que no haya dos hab con el mismo numero en el mismo hotel		

		if (not exists (select Habitacion_Numero from Habitacion where Hotel_Codigo=@HotelId and Habitacion_Numero= @numero))
		begin
			insert into FOUR_SIZONS.Habitacion(Habitacion_Numero,Hotel_Codigo,Habitacion_Piso,Habitacion_Frente,Habitacion_Tipo_Codigo,
			Habitacion_Descripcion,Habitacion_Estado)
					values (@numero,@HotelId,@piso,@frente,@TipoHabID,@descripcion,1)
		
		declare @aux datetime = convert(datetime, '01-01-2017' ,121)

		declare @aux2 datetime
		declare @fin datetime= convert(datetime, '01-01-2021' ,121)


		while (@aux != @fin)
		begin
		set @aux2= @aux 
		update FOUR_SIZONS.Disponibilidad
		set Disp_HabDisponibles= Disp_HabDisponibles+1
		where @TipoHab=Habitacion_Tipo_Codigo and @aux= Disp_Fecha and Hotel_Codigo =@HotelId


		set @aux = DATEADD(day, 1, @aux2)

		end

		end
		else 
		RAISERROR('el numero de habitacion ya figura en ese hotel, ingrese otro por favor',1,1)
		ROLLBACK TRANSACTION
commit tran 
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
end catch
go


create procedure four_sizons.modificarHabitacion
@numero numeric(18),
@hotId numeric(18),

@piso numeric(18),
@ubicacion nvarchar(50), 
@descripcion nvarchar(255),
@estado bit
as 
begin tran 
begin try

update FOUR_SIZONS.Habitacion

set Habitacion_Piso= @piso,Habitacion_Frente=@ubicacion,Habitacion_Estado=@estado,Habitacion_Descripcion=@descripcion
	
where Habitacion_Numero=@numero and Hotel_Codigo= @hotId

commit tran 
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran  
end catch
go
--------------------------------------------------ABM REGIMEN DE ESTADIA---------------------------------------------------










--------------------------------------------------DICE QUE NO HAY QUE DESARROLLARLO----------------------------------

create procedure four_sizons.GenerarReserva
@fechaInicio datetime,
@fechaFin datetime,
@userId nvarchar(15),
@hotId numeric(18),
@cliId numeric(18),
@regId numeric(18),
@cantHab numeric(18),
@tipoHab numeric(18)

as begin tran
begin try
declare @cantidadNoches numeric(2)
declare @precio decimal(12)
declare @preReg decimal(12)  = (select Regimen_Precio from four_sizons.regimen where Regimen_Codigo=@regId)
declare @recarga decimal(12) = (select Hotel_CantEstrella*Hotel_Recarga_Estrella from FOUR_SIZONS.Hotel where Hotel_Codigo=@hotId)
declare @porcentual decimal(12) = (select Habitacion_Tipo_Porcentual from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Codigo =@tipoHab)

set @cantidadNoches = DATEDIFF(day, @fechaInicio, @fechaFin)
set @precio = @cantidadNoches * @cantHab*(@preReg*@porcentual+@recarga)

if(1= four_sizons.verificarDisp(@fechaInicio, @fechaFin,@hotId, @tipoHab,@cantHab))
begin
insert into FOUR_SIZONS.Reserva(Reserva_Codigo,Reserva_Fecha_Inicio,Reserva_Fecha_Fin,Reserva_Cant_Noches,
								Reserva_Precio,Usuario_ID,Hotel_Codigo,Cliente_Codigo,Regimen_Codigo,Reserva_Estado,habitacion_tipo_codigo,reserva_cant_hab)
								values((NEXT VALUE FOR sec_cod_reserva),@fechaInicio,@fechaFin,@cantidadNoches,
								@precio,@userId,@hotId,@cliId,@regId,1,@tipohab,@canthab)


--aca baja la disponibilidad
declare @aux datetime = convert(datetime,@fechaInicio,121 )
declare @aux2 datetime 
while(@aux!= convert(datetime,@fechaFin, 121))
begin
set @aux2= @aux
update FOUR_SIZONS.Disponibilidad
	set Disp_HabDisponibles = Disp_HabDisponibles - @cantHab
	where Disp_Fecha= @aux and Hotel_Codigo = @hotId and Habitacion_Tipo_Codigo = @tipohab
set @aux = DATEADD(day, 1, @aux2)
end
end
else 
RAISERROR('no hay lugar en este hotel para estas fechas, intente nuevamente',1,1)
		ROLLBACK TRANSACTION
commit tran 
end try

begin catch
declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
rollback tran
end catch

go

create procedure four_sizons.ModificarReserva
	@codigoReserva numeric(18),
	@fechaInicio datetime,
	@fechaFin datetime,
	@userId nvarchar(15),
	@hotid numeric (18),
	@tipoHab numeric(18),
	@detalle nvarchar (255),
	@regId numeric(18),
	@estado numeric(1),
	@canthab numeric(18)


	as begin tran
	begin try 
	declare @cantidadNoches numeric(2)
	declare @fechaCambio datetime
	set @fechaCambio = GETDATE()
	declare @precio decimal(12)
	declare @preReg decimal(12)  = (select Regimen_Precio from four_sizons.regimen where Regimen_Codigo=@regId)
	declare @recarga decimal(12) = (select Hotel_CantEstrella*Hotel_Recarga_Estrella from FOUR_SIZONS.Hotel where Hotel_Codigo=@hotId)
	declare @porcentual decimal(12) = (select Habitacion_Tipo_Porcentual from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Codigo =@tipoHab)

	set @cantidadNoches = DATEDIFF(day, @fechaInicio, @fechaFin)
	set @precio = @cantidadNoches * @cantHab*(@preReg*@porcentual+@recarga)

	declare @mod_numero decimal(18)

	select @mod_numero = count(*) from FOUR_SIZONS.ReservaMod where Reserva_Codigo = @codigoReserva
	if(@canthab != (select reserva_cant_hab from four_sizons.reserva where reserva_codigo = @codigoReserva) or @tipohab != (select habitacion_tipo_codigo from four_sizons.reserva where reserva_codigo = @codigoReserva ))
	begin
	if(1= four_sizons.verificarDisp(@fechaInicio, @fechaFin,@hotId, @tipoHab,@cantHab))
	begin
	update FOUR_SIZONS.Reserva
		set Reserva_Fecha_Inicio= @fechaInicio,
		Reserva_Fecha_Fin = @fechaFin,
		Regimen_Codigo = @regId,
		Reserva_Estado = @estado,
		Hotel_Codigo = @hotId,
		habitacion_tipo_codigo = @tipoHab,
		reserva_cant_hab = @canthab,
		Reserva_Precio= @precio,
		Reserva_Cant_Noches=@cantidadNoches

		where Reserva_Codigo = @codigoReserva

		--aca baja la disponibilidad
declare @aux datetime = convert(datetime,@fechaInicio,121 )
declare @aux2 datetime 
while(@aux!= convert(datetime,@fechaFin, 121))
begin
set @aux2= @aux
update FOUR_SIZONS.Disponibilidad
	set Disp_HabDisponibles = Disp_HabDisponibles - @cantHab
	where Disp_Fecha= @aux and Hotel_Codigo = @hotId and Habitacion_Tipo_Codigo = @tipohab
set @aux = DATEADD(day, 1, @aux2)
end
	end
	else RAISERROR('no hay lugar en este hotel para estas fechas, intente nuevamente',1,1)
		ROLLBACK TRANSACTION


	end

	else 
	update FOUR_SIZONS.Reserva
		set Reserva_Fecha_Inicio= @fechaInicio,
		Reserva_Fecha_Fin = @fechaFin,
		Regimen_Codigo = @regId,
		Reserva_Estado = @estado,
		Hotel_Codigo = @hotId,
		Reserva_Precio= @precio,
		Reserva_Cant_Noches=@cantidadNoches

		where Reserva_Codigo = @codigoReserva

	insert into FOUR_SIZONS.ReservaMod (ResMod_Codigo,Reserva_Codigo,Usuario_ID, ResMod_Detalle,ResMod_Fecha)
							   values (@mod_numero,@codigoReserva,@userId,@detalle,@fechaCambio)

	commit tran
	end try
	begin catch
		declare @mensaje_de_error nvarchar(255)
		set @mensaje_de_error = ERROR_MESSAGE()
		RAISERROR(@mensaje_de_error,11,1)
		rollback tran 
	end catch
	go




create function four_sizons.verificarDisp (@inicio datetime , @fin datetime , @hotel numeric(18) , @tipohab numeric(18) , @canthab numeric(18))
returns bit
as begin 
declare @respuesta bit = 1
declare @aux datetime = convert(datetime,@inicio,121 )
declare @aux2 datetime

while (@aux!= convert(datetime,@fin, 121))
begin
set @aux2=@aux
declare @habDisp numeric(18) = (select Disp_HabDisponibles from FOUR_SIZONS.Disponibilidad where Hotel_Codigo=@hotel and Habitacion_Tipo_Codigo=@tipohab and Disp_Fecha=@aux)
if(@habDisp<@canthab )
begin 
set @respuesta = 0
end
set @aux = DATEADD(day, 1, @aux2)
end

return @respuesta
end
go


-- este no va mas xq no es bueno ejecutar un proc dentro de otro proc
create proc four_sizons.bajarDisponibilidad
@inicio datetime,
@fin datetime,
@hab_tipo numeric(18),
@Hotel numeric(18),
@cantHab numeric(18)

as begin tran 
begin try
declare @aux datetime = convert(datetime,@inicio,121 )
declare @aux2 datetime 
while(@aux!= convert(datetime,@fin, 121))
begin
set @aux2= @aux
update FOUR_SIZONS.Disponibilidad
	set Disp_HabDisponibles = Disp_HabDisponibles - @cantHab
	where Disp_Fecha= @aux and Hotel_Codigo = @hotel and Habitacion_Tipo_Codigo = @hab_tipo
set @aux = DATEADD(day, 1, @aux2)
end

	commit tran
	end try
	begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
	end catch
go




create procedure four_sizons.AgregarTarjeta
	@Tarjeta_Numero numeric(18),
	@Tarjeta_Venc datetime,
	@Tarjeta_Cod numeric(3),
	@Tarjeta_Titular nvarchar(50),

	@Tarjeta_Marca nvarchar(50),
	@Cliente_Codigo numeric(18)

	as begin tran 
	begin try

	if(not exists (select Tarjeta_Numero from FOUR_SIZONS.Tarjeta where Tarjeta_Numero = @Tarjeta_Numero))
	insert into FOUR_SIZONS.Tarjeta (Tarjeta_Numero, Tarjeta_Venc,Tarjeta_Cod,Tarjeta_Titular,Tarjeta_Marca,Cliente_Codigo ,tarjeta_estado)
								values (@Tarjeta_Numero, @Tarjeta_Venc,@Tarjeta_Cod,@Tarjeta_Titular,@Tarjeta_Marca,@Cliente_Codigo,1)

	else
	RAISERROR('la tarjeta ya figura en el sistema, ingrese otra por favor',1,1)
		ROLLBACK TRANSACTION
	commit tran
	end try

	begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
	end catch

go

create procedure four_sizons.cancelarTarjeta
	@Tarjeta_Numero numeric(18)
	as begin tran 
	begin try
	
	update FOUR_SIZONS.Tarjeta
	set Tarjeta_estado = '0'
	where Tarjeta_Numero= @Tarjeta_Numero
	
	commit tran
	end try
	begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
	end catch
go

create proc four_sizons.cerrarHotel
			@Cerrado_FechaI datetime,
			@Cerrado_FechaF datetime,
			@Cerrado_Detalle nvarchar(255),
			@Hotel_Codigo numeric(18)

	as begin tran 
	begin try

	insert into FOUR_SIZONS.Hotel_Cerrado(Cerrado_Detalle, Cerrado_FechaF ,Cerrado_FechaI , Hotel_Codigo)
									values (@Cerrado_Detalle,@Cerrado_FechaF,@Cerrado_FechaI,@Hotel_Codigo)

	update FOUR_SIZONS.Hotel 
	 set Hotel_Estado = '0'
	 where Hotel_Codigo = @Hotel_Codigo

	commit tran
	end try
	begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
	end catch
go

-----------------------------------------------------------FUNCIONES---------------------------------------------------------------------
create function four_sizons.InicioTRi(@Tri numeric(18) , @anio numeric(18))
	returns datetime
as begin
declare @inicio datetime,
		@Aaux char(4)
set @Aaux = CAST(@anio as CHAR(4))
if(@tri = 1)
set @inicio = '01-01-'+@Aaux
else if(@tri = 2)
	   set @inicio = '01-04-'+@Aaux
	 else if(@tri = 3)
			set @inicio = '01-07-'+@Aaux
		  else if(@tri = 4)
				set @inicio = '01-10-'+@Aaux

return @inicio
end
go

create function four_sizons.finTri(@Tri numeric(18) , @anio numeric(18))
	returns datetime
as begin
declare @fin datetime,
		@Aaux char(4)
set @Aaux = CAST(@anio as CHAR(4))
if(@Tri = 1)
set @fin = '31-03-'+@Aaux
else if(@Tri = 2)
	   set @fin = '30-06-'+@Aaux
	 else if(@Tri = 3)
			set @fin = '30-09-'+@Aaux
		  else if(@Tri = 4)
				set @fin = '31-12-'+@Aaux

return @fin
end
go


create FUNCTION FOUR_SIZONS.calcConsumible ( @estadia numeric(18),@ignora bit)

	RETURNS numeric(18,2) 

AS BEGIN

	DECLARE @total numeric(18,2),
			@regimen numeric(18),
			@reserva numeric(18)
	set @reserva=(select Reserva_Codigo from Estadia where Estadia_Codigo=@estadia)
	set @regimen=(select Regimen_Codigo  from Reserva where Reserva_Codigo=@reserva)
	if((select Regimen_Descripcion from Regimen where Regimen_Codigo=@regimen)='ALL INCLUSIVE' and @ignora=0)
		begin
			set @total=0
		end
	else
		begin
			set @total=(select sum(c.Consumible_Precio*isnull(exc.estXcons_cantidad,1)) 
				from EstadiaXConsumible exc join Consumible c on exc.Consumible_Codigo=c.Consumible_Codigo
				where exc.Estadia_Codigo=@estadia
				group by exc.Estadia_Codigo)
	end
	
RETURN @total
END	
go

create FUNCTION four_sizons.calcEstadia ( @estadia numeric(18))

	RETURNS numeric(18,2)

AS BEGIN

	DECLARE @total numeric(18,2)
	set @total=(select r.Reserva_Precio 
				from Estadia e join Reserva r on e.Reserva_Codigo=r.Reserva_Codigo
				where e.Estadia_Codigo=@estadia



				group by e.Estadia_Codigo,r.Reserva_Precio)
	if(@total is null)



	begin
	set @total=0
	end
	


RETURN @total
END	
go

---------------------------------------------------FACTURA------------------------------------------------------------------------------

create procedure four_sizons.generarFactura 
@estadia numeric(18),
@formaPago numeric(18),
@fechaI datetime --la fecha del sistema
as begin


declare @reserva numeric(18),
		@total numeric(18,2),
		@cliente numeric(18)

begin tran ta
begin try
		set @reserva = ( select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia);
		set @cliente = ( select Cliente_Codigo from FOUR_SIZONS.Reserva where Reserva_Codigo = @reserva);


		set @total = FOUR_SIZONS.calcEstadia(@estadia) + FOUR_SIZONS.calcConsumible(@estadia,0);
			--Es necesario tener al usuario en factura?
		insert into FOUR_SIZONS.Factura(Estadia_Codigo,Factura_FormaPago,Cliente_Codigo,Factura_Fecha,Factura_Total,Factura_Estado,Factura_Consistencia) values (@estadia,@formaPago,@cliente,@fechaI,@total,0,1);


commit tran
end try
begin catch
declare @mensaje_de_error nvarchar(255)
set @mensaje_de_error = ERROR_MESSAGE()
RAISERROR(@mensaje_de_error,11,1)
rollback tran 
end catch
end
GO
--------------------------------------------------------------
create procedure FOUR_SIZONS.ModificarFactura 
@estadia numeric(18,0),
@formaPago numeric(18,0),
@fechaI datetime,
@estado bit
as
begin


declare @reserva numeric(18),
		@estadoA bit,

		@total numeric(18,2),

		@fact_Nro numeric(18)
begin tran ta
begin try
		set @reserva = ( select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia);



		set @fact_Nro = (select Factura_Nro from FOUR_SIZONS.Factura where Estadia_Codigo = @estadia);
		if ( @estadoA != 1)

		begin

			set @total = FOUR_SIZONS.calcEstadia(@estadia) + FOUR_SIZONS.calcConsumible(@estadia,0);
			update FOUR_SIZONS.Factura
			set Factura_FormaPago =@formaPago , Factura_Fecha = @fechaI, Factura_Total = @total, Factura_Estado=@estado
			where Factura_Nro = @fact_Nro
		end
		else 
		RAISERROR('La factura ya fue facturada, no se puede realizar cambios',1,1)
		ROLLBACK TRANSACTION

commit tran
end try
begin catch
declare @mensaje_de_error nvarchar(255)
set @mensaje_de_error = ERROR_MESSAGE()
RAISERROR(@mensaje_de_error,11,1)
rollback tran 
end catch
end
GO
------------------------------------------------------------------------------------------------
create procedure FOUR_SIZONS.RegistrarEstadiaXCliente
@cliente numeric(18),
@estadia numeric(18)
as 
begin
begin tran ta
begin try
	insert into FOUR_SIZONS.EstadiaXCliente(Cliente_Codigo,Estadia_Codigo) values(@cliente,@estadia);
commit tran
end try
begin catch
declare @mensaje_de_error nvarchar(255)
set @mensaje_de_error = ERROR_MESSAGE()
RAISERROR(@mensaje_de_error,11,1)
rollback tran 
end catch
end
GO
----------------------------------------------------------------------------------
create proc FOUR_SIZONS.registrarCheckIn
@reserva numeric(18),
@usuario nvarchar(15),
@fecha datetime

as begin
--verifica que el momento del checkin sea el mismo que el dia de ingreso que dice la reserva
if (not exists (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva and Reserva_Fecha_Inicio= @fecha))	
	IF(EXISTS (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva and Reserva_Fecha_Inicio< @fecha))
		update FOUR_SIZONS.Reserva set Reserva_Estado=5 where Reserva_Codigo = @reserva--SE CANCELA LA RESERVA POR NO-SHOW CUANDO ES TARDE
	else 
	begin
	RAISERROR('el numero de reserva esta mal o todavia no es la fecha',1,1)
		ROLLBACK TRANSACTION
		end
else
declare @precioXNoche numeric(18),
		@cantNoches numeric(18),
		@estado decimal(1)
begin tran ta
begin try
---------------verifica el estado de la reserva y efectiviza la correcta y modificada
	if (exists (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva and (Reserva_Estado= 1 or Reserva_Estado=2)))
		if(not exists (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva and Reserva_Estado= 3))
			if(not exists (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva and Reserva_Estado= 4))
				if(not exists (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva and Reserva_Estado= 5))
					if(not exists (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva and Reserva_Estado= 6))
						begin
						RAISERROR('Error de estado',1,1)
						ROLLBACK TRANSACTION
						end
					else 
					begin
					RAISERROR('Reserva ya efectivizada',1,1)
					ROLLBACK TRANSACTION
					end
				else 
				begin
				RAISERROR('Reserva cancelada por No-Show',1,1)
				ROLLBACK TRANSACTION
				end
			else 
			begin
			RAISERROR('la reserva fue cancelada por cliente',1,1)
			ROLLBACK TRANSACTION
			end
		else 
			begin
			RAISERROR('la reserva fue cancelada por recepcionista',1,1)
			ROLLBACK TRANSACTION
			end
	else set @estado= 6			
	set @cantNoches = (select Reserva_Cant_Noches from FOUR_SIZONS.Reserva   where Reserva_Codigo = @reserva)
	set @precioXNoche = (select Reserva_Precio from FOUR_SIZONS.Reserva res where res.Reserva_Codigo = @reserva)/@cantNoches
	insert into FOUR_SIZONS.Estadia(Reserva_Codigo,Estadia_FechaInicio,Usuario_ID,Estadia_PreXNoche,Estadia_CantNoches) values(@reserva,@fecha,@usuario,@precioXNoche,@cantNoches);
	update FOUR_SIZONS.Reserva set Reserva_Estado=@estado where Reserva_Codigo = @reserva
	
commit tran 
end try

begin catch
declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
rollback tran
end catch
END
GO

create proc FOUR_SIZONS.registrarCheckOut
@Estadia numeric(18),
@fecha datetime,
@usuario numeric(18)
as
begin

declare @cantDias numeric(18),
		@difDates numeric(18),
		@precioXNoche numeric(18,0),
		@Reserva numeric(18),
		@finR datetime,
		@fact numeric(18),
		@monto numeric(18,2),

		@regimen numeric(18)
begin tran ta
begin try
	set @cantDias = DATEDIFF(day,( select Estadia_FechaInicio from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia ),@fecha);
	set @Reserva = (select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia);
	set @finR = (select Reserva_Fecha_Fin from FOUR_SIZONS.Reserva where Reserva_Codigo = @Reserva);
	set @difDates = DATEDIFF(day,@fecha,@finR);
	set @precioXNoche = (select Estadia_PreXNoche from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia);
	
	UPDATE FOUR_SIZONS.Estadia
	set 
		Usuario_OUT = @usuario,
		Estadia_FechaFin = @fecha,
		Estadia_DiasRest = @difDates,
		Estadia_CantNoches =  @cantDias
		where Estadia_Codigo = @Estadia;

	set @monto = (select Reserva_Precio from FOUR_SIZONS.Reserva where Reserva_Codigo =@Reserva)
	set @fact = (select Factura_Nro from FOUR_SIZONS.Factura where Estadia_Codigo = @Estadia)
	set @regimen=(select Regimen_Codigo from Reserva where Reserva_Codigo=@Reserva)
	if((select Regimen_Descripcion from Regimen where Regimen_Codigo=@regimen)='ALL INCLUSIVE')
	begin
		insert into FOUR_SIZONS.Item_Factura(Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto)
					values(@fact,'Descuento Por Regimen',1, FOUR_SIZONS.calcConsumible(@Estadia,1)*-1)
	end
	if(@difDates=0)
		begin
			insert into FOUR_SIZONS.Item_Factura(Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto)

				values(@fact,'Estadia',(@cantDias-1), @monto)
				----- EN CANTIDAD DE ESTADIA PONGO LA CANTIDAD DE NOCHES QUE SE QUEDA
				---- EL -1 SE DEBE A QUE EL DIA EN EL QUE SE RETIRAN NO SE COBRA SUPONGO, YA QUE NO PASAN LA NOCHE EN EL HOTEL
		end







	else 
		begin
			insert into FOUR_SIZONS.Item_Factura(Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto)
				values(@fact,'Estadia',@cantDias, (@cantDias-1)*@precioXNoche)
			insert into FOUR_SIZONS.Item_Factura(Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto)
				values(@fact,'Recargo de estadia',(@difDates-1),( @difDates-1)*@precioXNoche)
		end


commit tran 
end try

begin catch
declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
rollback tran
end catch
END
GO

----------------------------------------------------------------------------------

create procedure four_sizons.RegistrarConsXest
@estadia numeric(18),
@consumible numeric(18),
@cant numeric(18)
as begin tran 
	begin try
	declare @total numeric (18,2)
	declare @factura numeric(18)
	declare @desc nvarchar(50)
	declare @monto numeric(18)


	set @factura=(select f.Factura_Nro from FOUR_SIZONS.Factura f where @estadia = f.Estadia_Codigo)
	set @desc=(select Consumible_Descripcion from FOUR_SIZONS.Consumible where @consumible = Consumible_Codigo)
	set @monto =(select Consumible_Precio from FOUR_SIZONS.Consumible where @consumible = Consumible_Codigo)


	if(not exists (select Estadia_Codigo from FOUR_SIZONS.EstadiaXConsumible where Estadia_Codigo= @estadia and Consumible_Codigo = @consumible))
		begin
			insert into FOUR_SIZONS.EstadiaXConsumible(Estadia_Codigo,estXcons_cantidad,Consumible_Codigo)
										values(@estadia,@cant,@consumible)
	
			insert into FOUR_SIZONS.Item_Factura(Factura_Nro , item_descripcion , Item_Factura_Cant , Item_Factura_Monto)
								values(@factura,@desc,@cant,@monto*@cant)

		end 
	else 
		begin
			declare @numItem numeric(18)

			set @numItem=(select f.Item_Factura_NroItem from FOUR_SIZONS.Item_Factura f where Factura_Nro= @factura and @desc = item_descripcion)
			
			update FOUR_SIZONS.EstadiaXConsumible 
				set estXcons_cantidad = @cant+ estXcons_cantidad
				where Estadia_Codigo= @estadia and Consumible_Codigo = @consumible
			

			update FOUR_SIZONS.Item_Factura
					set Item_Factura_Cant = Item_Factura_Cant+@cant,
						Item_Factura_Monto = Item_Factura_Monto + (@monto*@cant)

					where @factura=Factura_Nro and @numItem = Item_Factura_NroItem


		end
	commit tran
	end try
	begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran 
	end catch
go

--------------------------------------PROCEDURES PARA LISTADO ESTADISTICO---------------------------------------------

create procedure four_sizons.HotelesMasReservasC
@anio numeric(18),
@tri numeric(18)

as begin
declare @fin datetime
declare @inicio datetime

set @inicio = FOUR_SIZONS.InicioTRi(@tri,@anio)
set @fin = FOUR_SIZONS.finTri(@tri,@anio)

select top 5 h.Hotel_Codigo--, COUNT(r.Reserva_Codigo)???????????????????????
from Hotel h,Reserva r, ReservaMod m  
where h.Hotel_Codigo=r.Hotel_Codigo and
	( (r.Reserva_Estado = 3 or r.Reserva_Estado = 4 or r.Reserva_Estado = 5)
	and m.Reserva_Codigo=r.Reserva_Codigo  and m.ResMod_Fecha between @inicio and @fin)
group by h.Hotel_Codigo
order by count(r.Reserva_Codigo)
end 
go


create procedure four_sizons.HotelesMayorConsFact
@anio numeric(18),
@tri numeric(18)

as begin
declare @fin datetime
declare @inicio datetime

set @inicio = CONVERT(datetime, FOUR_SIZONS.InicioTRi(@tri,@anio),121)
set @fin = CONVERT(datetime,FOUR_SIZONS.finTri(@tri,@anio),121)

select top 5 h.Hotel_Codigo


from FOUR_SIZONS.Hotel h, FOUR_SIZONS.Estadia e
where h.Hotel_Codigo=e.Hotel_Codigo and e.Estadia_FechaInicio between @inicio and @fin
group by h.Hotel_Codigo
order by sum(FOUR_SIZONS.calcConsumible(e.Estadia_Codigo,0))
end 
go


create procedure four_sizons.hotelMasCerrado
@anio numeric(18),
@tri numeric(18)

as begin
declare @fin datetime
declare @inicio datetime

set @inicio =CONVERT(datetime, FOUR_SIZONS.InicioTRi(@tri,@anio),121)
set @fin = CONVERT(datetime,FOUR_SIZONS.finTri(@tri,@anio),121)

select top 5 h.Hotel_Codigo
from FOUR_SIZONS.Hotel h , FOUR_SIZONS.Hotel_Cerrado c
where c.Hotel_Codigo = h.Hotel_Codigo and ((c.Cerrado_FechaI between @inicio and @fin) or (c.Cerrado_FechaF between @inicio and @fin))
group by h.Hotel_Codigo
order by count(c.Cerrado_codigo)

end 
go


create proc four_sizons.habOcupadas
@anio numeric(18),
@tri numeric(18)

as begin
declare @fin datetime
declare @inicio datetime

set @inicio = CONVERT(datetime,FOUR_SIZONS.InicioTRi(@tri,@anio),121)
set @fin =CONVERT(datetime, FOUR_SIZONS.finTri(@tri,@anio),121)

select top 5 h.Habitacion_Numero, h.Hotel_Codigo 
from FOUR_SIZONS.Estadia e ,FOUR_SIZONS.Habitacion h
where e.Hotel_Codigo = h.Hotel_Codigo and e.Habitacion_Numero = h.Habitacion_Numero and ((e.Estadia_FechaInicio between @inicio and @fin) or (e.Estadia_FechaFin between @inicio and @fin))
group by h.Habitacion_Numero, h.Hotel_Codigo
order by sum(e.Estadia_CantNoches) desc

end 
go

create FUNCTION FOUR_SIZONS.calcPuntaje ( @estadia numeric(18))

	RETURNS numeric(18)

AS BEGIN

	DECLARE @puntaje numeric(18),
			@puntajeEst numeric(18),
			@puntajeCons numeric(18),
			@reserva numeric(18),
			@descripcion nvarchar(255),

			@regimen numeric(18)

	set @puntajeEst= FOUR_SIZONS.calcEstadia(@estadia)/20
	set @puntajeCons=FOUR_SIZONS.calcConsumible(@estadia,0)/10
	set @reserva=(select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia)
	set @regimen = ( select regimen_Codigo from FOUR_SIZONS.Reserva where Reserva_Codigo = @reserva);
	set @descripcion=(select regimen_descripcion from FOUR_SIZONS.Regimen where Regimen_Codigo=@regimen);

	set @puntaje = @puntajeEst+@puntajeCons

	if(@puntaje is null)
	begin
	set @puntaje=0


	end
RETURN @puntaje
END	

go


create procedure four_sizons.clieMayorPuntaje
@anio numeric(18),
@tri numeric(18)

as begin
	declare @fin datetime
	declare @inicio datetime

	set @inicio = convert(datetime,FOUR_SIZONS.InicioTRi(@tri,@anio),121)
	set @fin = convert(datetime,FOUR_SIZONS.finTri(@tri,@anio),121)



	select top 5 c.Cliente_Codigo, c.cliente_numdoc , c.cliente_nombre , c.cliente_apellido
		from Cliente c JOIN Factura f on c.Cliente_Codigo=f.Cliente_Codigo
		where f.Factura_Fecha between @inicio and @fin-- and f.Factura_Consistencia=1 lo comente porque sino no devuelve nada ya que ninguna fact es cons
		group by c.Cliente_Codigo, c.cliente_numdoc , c.cliente_nombre , c.cliente_apellido
		order by sum(FOUR_SIZONS.calcPuntaje(f.Estadia_Codigo)) desc
end 
go