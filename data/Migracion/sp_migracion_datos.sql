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
	-- Creaci�n de esquema
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

	IF (OBJECT_ID('FOUR_SIZONS.EstadiaXHabitacion', 'U') IS NOT NULL)
	BEGIN
		DROP TABLE FOUR_SIZONS.EstadiaXHabitacion
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

	-- Creaci�n de tablas
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
			Cerrado_codigo numeric(18) IDENTITY(1,1),
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
			   Habitacion_Tipo_Descripcion nvarchar(255) default ' ',
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
			Habitacion_Descripcion nvarchar(255) default ' ',
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
			Cliente_Localidad nvarchar(255) default ' ',
			Cliente_Dom_Calle nvarchar(255),
			Cliente_Nro_Calle numeric(18),
			Cliente_Piso numeric(18),
			Cliente_Depto nvarchar(50) ,
			Cliente_Mail nvarchar(255) NOT NULL,
			Cliente_Telefono nvarchar(18) default ' ',
			Cliente_Pais nvarchar(50) default ' ',
			Cliente_Ciudad nvarchar(100) default ' ',
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
			Reserva_FechaCreacion datetime ,
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
			ResMod_Fecha datetime,
			
			CONSTRAINT FK_ReservaMod_1 FOREIGN KEY (Reserva_Codigo) REFERENCES FOUR_SIZONS.Reserva(Reserva_Codigo),
			CONSTRAINT FK_ReservaMod_2 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),

			CONSTRAINT PK_ReservaMod PRIMARY KEY (ResMod_Codigo, Reserva_Codigo, Usuario_ID)
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
			Estadia_DiasRest numeric(18) default 0,
			Estadia_PreXNoche numeric(18) ,
			Usuario_ID nvarchar(15),
			Usuario_OUT nvarchar(15),
			Hotel_Codigo numeric(18),
			Estadia_Estado bit

			CONSTRAINT FK_Estadia_1 FOREIGN KEY (Reserva_Codigo) REFERENCES FOUR_SIZONS.Reserva(Reserva_Codigo),
			CONSTRAINT FK_Estadia_2 FOREIGN KEY (Usuario_ID) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),
			CONSTRAINT FK_Estadia_3 FOREIGN KEY (Hotel_Codigo) REFERENCES FOUR_SIZONS.Hotel(Hotel_Codigo),
			CONSTRAINT FK_Estadia_4 FOREIGN KEY (Usuario_OUT) REFERENCES FOUR_SIZONS.Usuario(Usuario_ID),


			CONSTRAINT PK_Estadia PRIMARY KEY (Estadia_Codigo)

		)
	END

	IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EstadiaXHabitacion')
	BEGIN
		CREATE TABLE FOUR_SIZONS.EstadiaXHabitacion (
			Habitacion_numero numeric(18),
			Estadia_Codigo numeric(18),
			Hotel_codigo numeric(18),


			CONSTRAINT FK_EstadiaXHabitacion_1 FOREIGN KEY (Habitacion_numero,Hotel_codigo) REFERENCES FOUR_SIZONS.Habitacion(Habitacion_numero, Hotel_Codigo),
			CONSTRAINT FK_EstadiaXHabitacion_2 FOREIGN KEY (Estadia_Codigo) REFERENCES FOUR_SIZONS.Estadia(Estadia_Codigo),

			CONSTRAINT PK_EstadiaXHabitacion PRIMARY KEY (Habitacion_numero, Estadia_Codigo,Hotel_Codigo)
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
			Factura_Nro numeric(18) IDENTITY(2396745,1) NOT NULL,
			Factura_Fecha datetime,
			Factura_Total decimal(18,2),
			Factura_FormaPago nvarchar(50),
			Factura_Estado bit default 1,
			Factura_Consistencia bit default 1,
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


	-- Migraci�n de datos de la tabla maestra

	-- Par�metros
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'DNI')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'CUIL')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'CUIT')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'LE')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'LC')
	INSERT INTO FOUR_SIZONS.Parametros VALUES ('DOCUMENTO', 'PASSP')

	-- Roles
	INSERT INTO FOUR_SIZONS.Rol VALUES ('Administrador General', 1)
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
		where R.Rol_Nombre =  'Administrador General' and
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

	-- Reg�menes
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
	SELECT DISTINCT '', '', '', Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Hotel_Ciudad, 'Argentina',
	convert(datetime,'01/01/2017',121), 1
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

	/**Toma los clientes con igual n�mero de pasaporte y actualiza su estado a 1. Se deja el nro de pasaporte en negativo para uno de 
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
	Cliente_Consistente = 0, Cliente_Estado=0
	WHERE Cliente_Codigo IN (select clienteD from @updateDupli)

	DECLARE @updateDupli2 TABLE(
		clienteD numeric(18)
	)
	INSERT INTO @updateDupli2 (clienteD)
	SELECT C1.Cliente_Codigo
	FROM FOUR_SIZONS.Cliente C1 , FOUR_SIZONS.Cliente C2 
	where c1.Cliente_mail = c2.Cliente_mail  and c1.Cliente_Codigo > c2.Cliente_Codigo  

	UPDATE FOUR_SIZONS.Cliente
	SET Cliente_mail = 'mail repetido',
	Cliente_Consistente = 0, Cliente_Estado=0
	WHERE Cliente_Codigo IN (select clienteD from @updateDupli2)
	 
	-- Usuario
	-- Inserta usuarios
	INSERT INTO FOUR_SIZONS.Usuario
	VALUES ('SYSADM', '3GGQyLOZ4EO537rLsNN/KiZF4z+ZOEkdJLJOApjZzRc=', 'Administrador', '', '', 0, '', '', convert(datetime,'01/01/2017',121), '',1,0)
	INSERT INTO FOUR_SIZONS.Usuario
	VALUES ('GUEST', '3GGQyLOZ4EO537rLsNN/KiZF4z+ZOEkdJLJOApjZzRc=', 'Guest', '', '', 0, '', '', convert(datetime,'01/01/2017',121), '',1,0)
	INSERT INTO FOUR_SIZONS.Usuario
	VALUES ('admin', '5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c=', 'Administrador', '', '', 0, '', '', convert(datetime,'01/01/2017',121), '',1,0)

	--UsuarioXRol
	INSERT INTO FOUR_SIZONS.UsuarioXRol VALUES ('SYSADM', 1, 1)
	INSERT INTO FOUR_SIZONS.UsuarioXRol VALUES ('GUEST', 3, 1)
	INSERT INTO FOUR_SIZONS.UsuarioXRol VALUES ('admin', 1, 1)

	-- disponibilidad

begin
declare @aux datetime = convert(datetime, '01-01-2017' ,121)
declare @aux2 datetime
declare @fin datetime= convert(datetime, '01-01-2021' ,121)
while (@aux != @fin)
begin
set @aux2= @aux 
insert into FOUR_SIZONS.Disponibilidad(Hotel_Codigo,Disp_Fecha,Habitacion_Tipo_Codigo,Disp_HabDisponibles)
select h.Hotel_Codigo , @aux, ht.Habitacion_Tipo_Codigo ,isnull(count(hab.Habitacion_Numero),0) 
from FOUR_SIZONS.Hotel h 
join FOUR_SIZONS.Habitacion hab on Hab.Hotel_Codigo = h.Hotel_Codigo
join FOUR_SIZONS.Habitacion_Tipo ht on hab.Habitacion_Tipo_Codigo = ht.Habitacion_Tipo_Codigo
group by h.Hotel_Codigo , ht.Habitacion_Tipo_Codigo
set @aux = DATEADD(day, 1, @aux2)
end
end



	-- Reservas
	INSERT INTO FOUR_SIZONS.Reserva (Reserva_Codigo, Reserva_FechaCreacion, Reserva_Fecha_Inicio, Reserva_Fecha_Fin,
	Reserva_Cant_Noches, Reserva_Precio, Usuario_ID, Hotel_Codigo, Cliente_Codigo, Reserva_Estado,regimen_codigo,habitacion_tipo_codigo,reserva_cant_hab)
	SELECT DISTINCT M.Reserva_Codigo, M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio, dateadd(day,M.Reserva_Cant_Noches,M.Reserva_Fecha_Inicio), 
	M.Reserva_Cant_Noches,M.Reserva_Cant_Noches*(r.regimen_precio*ht.Habitacion_Tipo_Porcentual+h.Hotel_Recarga_Estrella*h.Hotel_CantEstrella), 'SYSADM', H.Hotel_Codigo, C.Cliente_Codigo, 1 , r.regimen_codigo,HT.habitacion_tipo_codigo,1
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Ciudad = M.Hotel_Ciudad and H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	JOIN FOUR_SIZONS.Regimen AS R ON R.Regimen_Descripcion = M.Regimen_Descripcion
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	JOIN FOUR_SIZONS.habitacion_tipo AS HT ON ht.habitacion_tipo_codigo = M.habitacion_tipo_codigo
	ORDER BY H.Hotel_Codigo

	--@cantidadNoches * @cantHab*(@preReg*@porcentual+@recarga)

	-- Habitacion_TipoXReserva
	
	-- Estadia
	INSERT INTO FOUR_SIZONS.Estadia (Reserva_Codigo, Estadia_FechaInicio, Estadia_FechaFin, Estadia_CantNoches, Usuario_ID, Hotel_Codigo, Estadia_Estado,Estadia_PreXNoche,usuario_out)
	SELECT DISTINCT M.Reserva_Codigo, M.Estadia_Fecha_Inicio, dateadd(day, M.Estadia_Cant_Noches,M.Estadia_Fecha_Inicio), M.Estadia_Cant_Noches, 'SYSADM', H.Hotel_Codigo, 1,r.regimen_precio*ht.Habitacion_Tipo_Porcentual+h.Hotel_Recarga_Estrella*h.Hotel_CantEstrella,'SYSADM'
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	JOIN FOUR_SIZONS.Regimen AS R ON R.Regimen_Descripcion = M.Regimen_Descripcion
	JOIN FOUR_SIZONS.habitacion_tipo AS HT ON ht.habitacion_tipo_codigo = M.habitacion_tipo_codigo
	WHERE M.Estadia_Fecha_Inicio IS NOT NULL AND M.Estadia_Cant_Noches IS NOT NULL
	ORDER BY M.Reserva_Codigo

	--EstadiaXHabitacion
	INSERT INTO FOUR_SIZONS.EstadiaXHabitacion (Estadia_Codigo,Habitacion_numero,Hotel_codigo)
	select distinct E.Estadia_Codigo,M.Habitacion_Numero,H.Hotel_Codigo
	from GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Hotel AS H ON H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
	JOIN FOUR_SIZONS.Estadia AS E ON E.Reserva_Codigo = M.Reserva_Codigo

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
	SET IDENTITY_INSERT four_sizons.Factura ON
	INSERT INTO FOUR_SIZONS.Factura (Factura_Nro, Factura_Fecha, Factura_Total, Factura_FormaPago, Usuario_ID, Estadia_Codigo, Cliente_Codigo)
	SELECT DISTINCT M.Factura_Nro, M.Factura_Fecha, M.Factura_Total, NULL, 'SYSADM', EC.Estadia_Codigo, C.Cliente_Codigo
	FROM GD1C2018.gd_esquema.Maestra AS M
	JOIN FOUR_SIZONS.Cliente AS C ON C.Cliente_NumDoc = M.Cliente_Pasaporte_Nro
	JOIN FOUR_SIZONS.Reserva AS R ON R.Reserva_Codigo = M.Reserva_Codigo
	JOIN FOUR_SIZONS.EstadiaXCliente AS EC ON EC.Cliente_Codigo = C.Cliente_Codigo
	JOIN FOUR_SIZONS.Estadia AS E ON E.Estadia_Codigo = EC.Estadia_Codigo AND E.Reserva_Codigo = R.Reserva_Codigo
	WHERE Factura_Nro IS NOT NULL
	ORDER BY M.Factura_Nro
	SET IDENTITY_INSERT four_sizons.Factura OFF

	--Item_Factura
	
	INSERT INTO FOUR_SIZONS.Item_Factura (Factura_Nro, Item_Factura_Cant, Item_Factura_Monto)
	SELECT DISTINCT m.Factura_Nro, m.Item_Factura_Cantidad, (m.Item_Factura_Monto)
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

	declare @h1 nvarchar(2) = 1
while (@h1<16)
begin
update FOUR_SIZONS.Hotel 
set Hotel_Nombre = 'four sizons '+@h1
where Hotel_Codigo=@h1
set @h1 = @h1+1
end


update FOUR_SIZONS.Disponibilidad 
						set Disp_HabDisponibles = Disp_HabDisponibles - 1
						from FOUR_SIZONS.Reserva r , FOUR_SIZONS.Disponibilidad d
						where (Disp_Fecha between Reserva_Fecha_Inicio and Reserva_Fecha_Fin) and r.Hotel_Codigo = d.Hotel_Codigo and d.Habitacion_Tipo_Codigo = r.habitacion_tipo_codigo


END