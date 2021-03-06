USE GD1C2018
GO
-- Creaci�n de esquema
IF NOT EXISTS (SELECT * FROM SYS.schemas
				WHERE name = 'FOUR_SIZONS'	)
	begin
	EXEC('CREATE SCHEMA FOUR_SIZONS AUTHORIZATION gdHotel2018')
	end


	DECLARE @cmd varchar(1000)
	
	

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
	SELECT DISTINCT concat(hotel_calle,' ',Hotel_Nro_Calle), '', '', Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Hotel_Ciudad, 'Argentina',
	convert(datetime,'01/01/2017',103), 1
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
	VALUES ('SYSADM', '3GGQyLOZ4EO537rLsNN/KiZF4z+ZOEkdJLJOApjZzRc=', 'Administrador Desarrollador', '', '', 0, '', '', convert(datetime,'01/01/2017',103), '',1,0)
	INSERT INTO FOUR_SIZONS.Usuario
	VALUES ('GUEST', '3GGQyLOZ4EO537rLsNN/KiZF4z+ZOEkdJLJOApjZzRc=', 'Guest', '', '', 0, '', '', convert(datetime,'01/01/2017',103), '',1,0)
	INSERT INTO FOUR_SIZONS.Usuario
	VALUES ('admin', '5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c=', 'Administrador General', '', '', 0, '', '', convert(datetime,'01/01/2017',103), '',1,0)

	--UsuarioXRol
	INSERT INTO FOUR_SIZONS.UsuarioXRol VALUES ('SYSADM', 1, 1)
	INSERT INTO FOUR_SIZONS.UsuarioXRol VALUES ('GUEST', 3, 1)
	INSERT INTO FOUR_SIZONS.UsuarioXRol VALUES ('admin', 1, 1)

	-- disponibilidad

begin
declare @aux datetime = convert(datetime, '01-01-2017' ,103)
declare @aux2 datetime
declare @fin datetime= convert(datetime, '01-01-2021' ,103)
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

	

-- se hace un update de la disponibilidad, descontando x cada reserva que haya cargada en el sistema
update FOUR_SIZONS.Disponibilidad 
						set Disp_HabDisponibles = Disp_HabDisponibles - 1
						from FOUR_SIZONS.Reserva r , FOUR_SIZONS.Disponibilidad d
						where (Disp_Fecha between Reserva_Fecha_Inicio and Reserva_Fecha_Fin) and r.Hotel_Codigo = d.Hotel_Codigo and d.Habitacion_Tipo_Codigo = r.habitacion_tipo_codigo


-- se hace un update de las estadias que son anteriores a 2018 y se las marca como inactivas
update FOUR_SIZONS.Estadia
set Estadia_Estado = 0
where Estadia_FechaFin < convert(datetime,'01/01/2018',103)
-- se actualizan todas las reservas que ya fueron efectivizadas o que fueron canceladas x no-show 
update FOUR_SIZONS.Reserva
set Reserva_Estado=6
from FOUR_SIZONS.Estadia e , FOUR_SIZONS.Reserva r
where e.Reserva_Codigo= r.Reserva_Codigo

update FOUR_SIZONS.Reserva
set Reserva_Estado=5
where Reserva_Fecha_inicio<convert(datetime,'01/01/2018',103) and reserva_codigo not in (select r.Reserva_Codigo from FOUR_SIZONS.Estadia e , FOUR_SIZONS.Reserva r where r.Reserva_Codigo=e.reserva_Codigo)
go
-------------------------------------------------------Comienzo de procedures--------------------------------------------------------------

-- Borrado de procedures en la base 
IF (OBJECT_ID('FOUR_SIZONS.ValidarUsuario', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.ValidarUsuario
END;

IF (OBJECT_ID('FOUR_SIZONS.modificarRegXhot', 'P') IS NOT NULL)
BEGIN

    DROP PROCEDURE FOUR_SIZONS.modificarRegXhot
END;

IF (OBJECT_ID('FOUR_SIZONS.asignarHab', 'P') IS NOT NULL)
BEGIN

    DROP PROCEDURE FOUR_SIZONS.asignarHab
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

IF (OBJECT_ID('FOUR_SIZONS.altaUserxRol', 'P') IS NOT NULL)
BEGIN
    DROP proc FOUR_SIZONS.altaUserxRol
END;

IF (OBJECT_ID('FOUR_SIZONS.bajaUserxRol', 'P') IS NOT NULL)
BEGIN
    DROP proc FOUR_SIZONS.bajaUserxRol
END;

IF (OBJECT_ID('FOUR_SIZONS.bajaModifConsXestadia', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.bajaModifConsXestadia
END;

IF (OBJECT_ID('FOUR_SIZONS.verificarEstadoReserva', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.verificarEstadoReserva
END;

IF (OBJECT_ID('FOUR_SIZONS.verificarEstadoReserva', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.verificarEstadoReserva
END;

IF (OBJECT_ID('FOUR_SIZONS.DisponibilidadyPrecio', 'P') IS NOT NULL)
BEGIN
    DROP proc FOUR_SIZONS.DisponibilidadyPrecio
END;


GO

--------------------------------------------------------ABM USUARIO------------------------------

create function four_sizons.verificarDisp (@inicio datetime , @fin datetime , @hotel numeric(18) , @tipohab numeric(18) , @canthab numeric(18))
returns bit
as begin 
declare @respuesta bit = 1
declare @aux datetime = convert(datetime,@inicio,103 )
declare @aux2 datetime

while (datediff(day,@aux,convert(datetime,@fin, 103))!=0)
begin
set @aux2=@aux
declare @habDisp numeric(18) = isnull((select Disp_HabDisponibles from FOUR_SIZONS.Disponibilidad where Hotel_Codigo=@hotel and Habitacion_Tipo_Codigo=@tipohab and datediff(day,Disp_Fecha,@aux)=0),0)
if(@habDisp<@canthab )
begin 
set @respuesta = 0
end
set @aux = DATEADD(day, 1, @aux2)
end

return @respuesta
end
go



create procedure four_sizons.altaUserxRol
@userID nvarchar(50),
@rolId numeric(18)
as begin tran
begin try
	if((select Usuario_Estado from FOUR_SIZONS.Usuario where Usuario_ID = @userID) = 1)
	begin
	if(exists (select UsuarioXRol_Estado from FOUR_SIZONS.UsuarioXRol where Usuario_ID=@userID and Rol_Codigo=@rolId))
	begin 
		update FOUR_SIZONS.UsuarioXRol
			set UsuarioXRol_Estado=1
			where  Usuario_ID=@userID and Rol_Codigo=@rolId
	end
	else 
	begin
		insert into FOUR_SIZONS.UsuarioXRol(Rol_Codigo,Usuario_ID,UsuarioXRol_Estado) 
									values (@rolID,@userID,1)
	end
	end
	else raiserror('no se puede asignar el rol ya que el usuario se encuentra inhabilitado',16,1)
	commit tran 
	end try
	begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran  
	end catch 
go


create procedure four_sizons.bajaUserxRol
@userID nvarchar(50),
@rolId numeric(18)
as begin tran
begin try
declare @nombre nvarchar(50)
set @nombre=(select Rol_Nombre from FOUR_SIZONS.Rol where Rol_Codigo=@rolId)
	if(not exists (select UsuarioXRol_Estado from FOUR_SIZONS.UsuarioXRol where Usuario_ID=@userID and Rol_Codigo=@rolId))
	begin
		raiserror ('No se puede dar de baja ya que no existe ese usarioxRol',13,1)
			
	end

	if((select UsuarioXRol_Estado from FOUR_SIZONS.UsuarioXRol where Usuario_ID=@userID and Rol_Codigo=@rolId)=1)
	begin
		if (@nombre='Administrador General' and (select count(Usuario_ID)  from FOUR_SIZONS.UsuarioXRol where Rol_Codigo=@rolId)<=1)
		begin 
			raiserror ('No se puede dar de baja Administrador General, ya que no se puede quedar sin Administrador General el sistema',13,1)
	
		end
		update FOUR_SIZONS.UsuarioXRol
			set UsuarioXRol_Estado=0
			where  Usuario_ID=@userID and Rol_Codigo=@rolId
	end
	else 
	begin
		raiserror ('No se puedo dar de baja ya que no esta activo',13,1)
			
	end
commit tran 
end try
begin catch
	declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	 
end catch
GO

create procedure FOUR_SIZONS.ValidarUsuario
@usuario nvarchar(15), 
@password nvarchar(100)


--@loginOK bit output
as

begin
declare @loginVerif bit
declare @fallalog numeric(1)
declare @passret nvarchar(100)


	set @loginVerif = 0
	if exists(SELECT * FROM FOUR_SIZONS.Usuario WHERE Usuario_ID = @usuario)
	begin


		if exists(SELECT * FROM FOUR_SIZONS.Usuario WHERE Usuario_ID = @usuario AND Usuario_Estado = 1)
		begin


			if exists(SELECT * FROM FOUR_SIZONS.UsuarioXRol WHERE Usuario_ID = @usuario AND Rol_Codigo = 1)
			begin


				--es admin gral --> entonces verifica la contrase�a
				set @loginVerif = 1
			end
			else
			begin
				if(select COUNT(*) from FOUR_SIZONS.Usuario U 
				JOIN FOUR_SIZONS.UsuarioXRol UR ON UR.Usuario_ID = U.Usuario_ID
				JOIN FOUR_SIZONS.Rol R ON R.Rol_Codigo = UR.Rol_Codigo
				JOIN FOUR_SIZONS.RolXFunc RF ON RF.Rol_Codigo = R.Rol_Codigo
				JOIN FOUR_SIZONS.UsuarioXHotel UH ON UH.Usuario_ID = U.Usuario_ID
				JOIN FOUR_SIZONS.Hotel H ON H.Hotel_Codigo = UH.Hotel_Codigo
				WHERE U.Usuario_Estado = 1 AND UR.UsuarioXRol_Estado = 1 AND
				R.Rol_Estado = 1 AND RF.RolXFunc_Estado = 1 AND 
				UH.UsuarioXHotel_Estado = 1 AND H.Hotel_Estado = 1 AND
				R.Rol_Codigo <> 1 AND U.Usuario_ID = @usuario) > 0
				begin




					--tiene al menos un rol y funcionalidades habilitadas
					set @loginVerif = 1
				end
				else
				begin






















					RAISERROR('El usuario no tiene accesos habilitados para operar',16,1)
				end
			end





		end
		else
		begin


			RAISERROR('El usuario no est� habilitado',16,1)
		end
	end

	else
	begin

		RAISERROR('El usuario no existe',16,1)
	end









	if(@loginVerif = 1)
	begin
		select @fallalog = Usuario_FallaLog, @passret = Usuario_Password from FOUR_SIZONS.Usuario where Usuario_ID = @usuario

		if @passret = @password
		begin
			if @fallalog <> 0
				update FOUR_SIZONS.Usuario set Usuario_FallaLog = 0 where Usuario_ID = @usuario
		end
		else
		begin
			if @fallalog = 2
			begin
				update FOUR_SIZONS.Usuario set Usuario_FallaLog = Usuario_FallaLog + 1, Usuario_Estado = 0 where Usuario_ID = @usuario
				RAISERROR('Contrase�a incorrecta. El usuario est� deshabilitado',16,1)
			end

			if @fallalog < 2
			begin
				update FOUR_SIZONS.Usuario set Usuario_FallaLog = Usuario_FallaLog + 1 where Usuario_ID = @usuario
				RAISERROR('Contrase�a incorrecta',16,1)
				--if @fallalog = 1
				--begin
				--	RAISERROR('Contrase�a incorrecta. El usuario se deshabilitar� ante el pr�ximo inicio de sesi�n inv�lido',16,1)
				--end
			end
		end
	end
end
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
	if(not exists (select Usuario_ID from FOUR_SIZONS.Usuario where @username=Usuario_ID))
		begin

			set @rolId= (select Rol_codigo from FOUR_SIZONS.rol where @rolNombre = rol_nombre)
	 
			insert into FOUR_SIZONS.usuario(Usuario_ID,Usuario_Password,Usuario_Nombre,Usuario_Apellido,Usuario_TipoDoc, Usuario_NroDoc,Usuario_Telefono,Usuario_Direccion,Usuario_Fec_Nac,Usuario_Mail, Usuario_Estado , Usuario_FallaLog)
							values(@username,@password,@nombre,@apellido,@tipoDoc,@numDoc,@telefono,@direccion,@fechaNac,@mail,1,0)
	

			insert into FOUR_SIZONS.UsuarioXRol(Rol_Codigo,Usuario_ID,UsuarioXRol_Estado) values (@rolId, @username,1)
		end
	else raiserror ('El nombre de usuario ya existe en el sistema, por favor ingrese otro.',16,1)

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
	if((select Usuario_Estado from FOUR_SIZONS.Usuario where Usuario_ID = @usuario) = 1)
	begin


	if(exists (select Usuario_ID  from FOUR_SIZONS.UsuarioXHotel where @usuario = Usuario_ID and @hotID = Hotel_Codigo))
	update FOUR_SIZONS.UsuarioXHotel 
			set UsuarioXHotel_Estado = @estado
			where Usuario_ID = @usuario and Hotel_Codigo = @hotID

	else
	insert into FOUR_SIZONS.UsuarioXHotel(Hotel_Codigo,Usuario_ID,UsuarioXHotel_Estado) values (@hotId,@usuario,1)
	end
	else raiserror('no se puede asignar un hotel ya que el usuario esta deshabilitado',16,1)
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
	/*if(@estado = 1)
	begin
		update FOUR_SIZONS.usuario
				set Usuario_Password = @username,Usuario_Nombre =@nombre,Usuario_Apellido = @apellido ,
				Usuario_TipoDoc =@tipoDoc,Usuario_NroDoc =@numDoc,Usuario_Telefono =@telefono,
				Usuario_Direccion= @direccion,Usuario_Fec_Nac = @fechaNac,Usuario_Mail =@mail,Usuario_Estado=@estado,
				Usuario_FallaLog = 0
				where Usuario_ID=@username
	end
	else
	begin*/

			update FOUR_SIZONS.usuario
				set Usuario_Password = @password,Usuario_Nombre =@nombre,Usuario_Apellido = @apellido ,
				Usuario_TipoDoc =@tipoDoc,Usuario_NroDoc =@numDoc,Usuario_Telefono =@telefono,
				Usuario_Direccion= @direccion,Usuario_Fec_Nac = @fechaNac,Usuario_Mail =@mail,Usuario_Estado=@estado,
				Usuario_FallaLog = 0

				where Usuario_ID=@username
	--end

	/*update FOUR_SIZONS.UsuarioXRol 
				set Rol_Codigo = @rolId    
				where Usuario_ID=@username   */
	
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
@codigo numeric(18) output,
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
	begin
		if(not exists (select cliente_codigo from cliente where @tipoDoc = Cliente_TipoDoc and @numDoc=Cliente_NumDoc))
			begin
				insert into four_sizons.Cliente(Cliente_Nombre ,cliente_Apellido,cliente_TipoDoc, Cliente_NumDoc,Cliente_Dom_Calle,Cliente_Nro_Calle
								,Cliente_Piso,Cliente_Depto,Cliente_Localidad,Cliente_Mail,Cliente_Telefono, Cliente_Pais, Cliente_Ciudad,
								Cliente_Nacionalidad,Cliente_Fecha_Nac,Cliente_Puntos,Cliente_Estado,Cliente_Consistente)
								values (@nombre,@apellido,@tipoDoc,@numDoc,@calle,@numCalle,@piso,@depto,@localidad,@mail,@telefono,
								@pais,@ciudad,@nacionalidad,@fechaNac,0,1,1)
				set @codigo= (select top 1 Cliente_Codigo from FOUR_SIZONS.Cliente order by Cliente_Codigo desc)
			end 

		else RAISERROR('El tipo y n�mero de documento ya figura en el sistema, por favor ingrese otro.',16,1)
	end
else RAISERROR('El mail ingresado ya figura en el sistema, por favor ingrese otro.',16,1)


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
@codigo nvarchar(50),
@nombre nvarchar(50),
@apellido nvarchar(50),
@numDoc numeric (18),
@tipoDoc nvarchar(50),
@mail nvarchar(50),
@telefono nvarchar(18),
@pais nvarchar(50),
@ciudad nvarchar(50),
@calle nvarchar(255),
@numCalle numeric(18),
@piso numeric(18),
@depto nvarchar(18),
@localidad nvarchar(50),
@nacionalidad nvarchar(50),
@fechaNac datetime,
@estado bit


as begin tran
begin try

if (not exists (select Cliente_codigo from cliente where Cliente_Codigo!=@codigo and Cliente_Mail= @mail))
update FOUR_SIZONS.Cliente
set Cliente_Nombre=@nombre ,cliente_Apellido=@apellido,cliente_TipoDoc=@tipoDoc, Cliente_NumDoc = @numDoc,
		Cliente_Dom_Calle=@calle,Cliente_Nro_Calle=@numCalle,Cliente_Piso=@piso,Cliente_Depto=@depto
		 ,cliente_localidad=@localidad,Cliente_Mail=@mail,Cliente_Nacionalidad=@nacionalidad,
		 Cliente_Fecha_Nac=@fechaNac,Cliente_Estado=@estado

	where Cliente_Codigo = @codigo
else RAISERROR('El mail ingresado ya figura en el sistema, por favor ingrese otro',16,1)
		

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
@codigo numeric(18) output,
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
@usuario nvarchar(15)

as begin try
begin tran

if (not exists (select Hotel_Codigo from FOUR_SIZONS.Hotel where Hotel_Nombre= @nombre))
	begin
		insert into FOUR_SIZONS.Hotel(Hotel_Nombre,Hotel_Mail,Hotel_Telefono,Hotel_Calle,Hotel_Nro_Calle,
					Hotel_CantEstrella,Hotel_Recarga_Estrella, Hotel_Ciudad,Hotel_Pais,Hotel_FechaCreacion,Hotel_Estado)
					values (@nombre,@mail,@telefono,@calle,@numCalle,@cantEstrellas,@recarga_estrella,@ciudad,@pais, convert(datetime,@fechaCreacion,103),1)

		

		set @codigo = (select top 1 Hotel_Codigo from four_sizons.Hotel order by Hotel_Codigo desc)
		insert into FOUR_SIZONS.UsuarioXHotel(Hotel_Codigo,Usuario_ID,UsuarioXHotel_Estado) values (@codigo,@usuario,1)

	end
else raiserror ('Ya existe un hotel con ese nombre en el sistema, por favor ingrese otro.',16,1)

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
@hotID numeric(18)
--@hotel nvarchar(50)

as begin tran 
begin try 

declare @regID nvarchar(50)
--declare @hotID nvarchar(50)

set @regID = (select Regimen_Codigo  from four_sizons.regimen where Regimen_Descripcion = @regimen)
--set @hotID = (select Hotel_Codigo from FOUR_SIZONS.Hotel where Hotel_Nombre = @hotel)
if(not exists (select RegXHotel_Estado from four_sizons.RegXHotel where Regimen_Codigo=@regID and Hotel_Codigo=@hotID))

	insert into FOUR_SIZONS.RegXHotel(Hotel_Codigo,Regimen_Codigo,RegXHotel_Estado) 
							values (@hotID,@regID,1)
else raiserror ('Ya existe este r�gimen en este hotel.',16,1)

commit tran 
end try


begin catch
declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
	rollback tran  
end catch 
go

create procedure four_sizons.modificarRegXhot
@hotel numeric(18),
@reg nvarchar(50),
@estado bit,
@fechaMod datetime
as begin tran 
begin try

	declare @regID numeric(18)	
	
	set @regID = (select Regimen_Codigo from FOUR_SIZONS.regimen where Regimen_Descripcion = @reg)
	set @fechaMod = convert(datetime,@fechaMod,103)

if exists(select * from FOUR_SIZONS.RegXHotel where Hotel_Codigo=@hotel and Regimen_Codigo=@regID)
	begin
		if(@estado!=0)
			begin
				update FOUR_SIZONS.RegXHotel
				set RegXHotel_Estado = @estado
				where Regimen_Codigo=@regID and Hotel_Codigo=@hotel
			end
		else
			begin 
				if(exists (select Reserva_Codigo  from Reserva where Hotel_Codigo=@hotel and Regimen_Codigo=@regID))
					begin
						if(exists(select Reserva_Codigo from Reserva 
							where Hotel_Codigo=@hotel and Regimen_Codigo=@regID and @fechaMod between Reserva_Fecha_Inicio and Reserva_Fecha_Fin)--Que no hayan estadias
							or exists(select Reserva_Codigo from Reserva 
							where Hotel_Codigo=@hotel and Regimen_Codigo=@regID and (Reserva_Estado=1 or Reserva_Estado=2)))--que no hayan reservas activas
							begin
								raiserror ('No se puede realizar la mod ya que hay reservas con este regimen',16,1)
							end
						else
							begin
								update FOUR_SIZONS.RegXHotel
								set RegXHotel_Estado = @estado
								where Regimen_Codigo=@regID and Hotel_Codigo=@hotel
							end
					end
				else 
					begin
						update FOUR_SIZONS.RegXHotel
							set RegXHotel_Estado = @estado
							where Regimen_Codigo=@regID and Hotel_Codigo=@hotel
					end
			end
		end
	else
	begin
		exec four_sizons.altaRegXHotel @reg, @hotel
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
@estado bit,
@fechaCambio datetime
as 
begin tran 
begin try

if(@estado=1 and exists (select * from FOUR_SIZONS.Hotel_Cerrado where Hotel_Codigo=@codigo and (@fechaCambio between Cerrado_FechaI and Cerrado_FechaF)) and (select Hotel_Estado from FOUR_SIZONS.Hotel where @codigo=Hotel_Codigo)=0)
begin
		update FOUR_SIZONS.Hotel
		set Hotel_Nombre= @nombre,Hotel_Mail= @mail,Hotel_Telefono=@telefono,Hotel_Calle=@calle ,
			Hotel_Nro_Calle=@numCalle,Hotel_CantEstrella=@cantEstrellas,Hotel_Recarga_Estrella=@recarga_estrella,
			Hotel_Ciudad=@ciudad,Hotel_Pais=@pais,Hotel_FechaCreacion=@fechaCreacion,Hotel_Estado=@estado

		where Hotel_Codigo=@codigo

		update FOUR_SIZONS.Hotel_Cerrado
		set Cerrado_FechaF=@fechaCambio
		where Hotel_Codigo=@codigo and (@fechaCambio between Cerrado_FechaI and Cerrado_FechaF)
end
else 
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
		if(not exists(select Rol_Codigo from FOUR_SIZONS.Rol where Rol_Nombre=@rolname))
			begin
				insert into FOUR_SIZONS.Rol (rol_nombre,rol_estado) values(@rolname,@estado);
			end
		else raiserror ('ya existe un rol con ese nombre, ingrese otro',16,1)
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
	declare @nombre nvarchar(50)
	set @nombre=(select Rol_Nombre from Rol where Rol_Codigo=@codigo)
	if (@nombre='Administrador General')
		begin 
			raiserror ('No se puede modificar el rol de Administrador General',13,1)
	
		end
	else
		begin
			if (not exists (select Rol_Codigo from FOUR_SIZONS.Rol where Rol_Codigo!=@codigo and Rol_Nombre=@rolname))
				begin
					begin
						update FOUR_SIZONS.Rol
						set Rol_Nombre= @rolname,Rol_Estado= @estado
						where Rol_Codigo=@codigo

							update FOUR_SIZONS.UsuarioXRol
							set UsuarioXRol_Estado= @estado
							where Rol_Codigo=@codigo

							update FOUR_SIZONS.RolXFunc
							set RolXFunc_Estado=@estado
							where Rol_Codigo=@codigo

					end
				end
			else raiserror('Ya existe un rol con este nombre, por favor ingrese otro.',16,1)
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

create procedure four_sizons.altaRolxFunc
@rolname nvarchar(50),


@func nvarchar(50)

as begin tran 
begin try 

	declare @rolID nvarchar(50)
	declare @funcID nvarchar(50)


	set @rolID = (select Rol_Codigo  from four_sizons.Rol where Rol_Nombre = @rolname)

	set @funcID = (select Func_Codigo from FOUR_SIZONS.Funcionalidad where Func_Nombre = @func)
if(not exists(select * from FOUR_SIZONS.RolXFunc where Rol_Codigo=@rolID and Func_Codigo=@funcID))

	insert into FOUR_SIZONS.RolXFunc(Rol_Codigo,Func_Codigo,RolXFunc_Estado) 
							values (@rolID,@funcID,1)
else raiserror('Este rol ya posee esta funcionalidad.',16,1)
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

	declare @rolID numeric(18),	
			@funcID numeric(18),	
			@nombre nvarchar(50)
	
	
	set @rolID = (select Rol_Codigo  from four_sizons.Rol where Rol_Nombre = @rolname)	
	set @funcID = (select Func_Codigo from FOUR_SIZONS.Funcionalidad where Func_Nombre = @func)
	set @nombre=(select Rol_Nombre from Rol where Rol_Codigo=@rolID)
	if (@nombre='Administrador General')
		begin 
			raiserror ('No se pueden modificar las funcionalidades asignadas a Administrador General.',13,1)
			
		end
	else
		begin
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
create procedure four_sizons.asignarHab
@estadia numeric(18),
@reserva numeric(18)
as begin
	declare @tipo_Hab numeric(18), @cant numeric(18) , @hotel numeric(18)
	(select @tipo_Hab=r.habitacion_tipo_codigo , @cant=r.Reserva_cant_hab , @hotel=r.Hotel_Codigo from FOUR_SIZONS.Reserva r where  Reserva_Codigo= @reserva)

	declare @hab_asign table  (hab_codigo numeric(18))
	while((select isnull(count(hab_codigo),0)from @hab_asign)<@cant)
	begin
	INSERT INTO @hab_asign (hab_codigo)
	
	
	SELECT top 1 h.Habitacion_Numero
	FROM  four_sizons.Habitacion h 
	where h.Habitacion_Tipo_Codigo=@tipo_Hab and @hotel=h.Hotel_Codigo and h.Habitacion_Estado=1 and h.Habitacion_Numero not in(select hab_codigo from @hab_asign)
	order by h.Habitacion_Numero asc
	end

	insert into FOUR_SIZONS.EstadiaXHabitacion (Habitacion_numero , Hotel_codigo , Estadia_Codigo)
	select hab_codigo , @hotel , @estadia
	from @hab_asign

	select * from @hab_asign
	update FOUR_SIZONS.Habitacion 
	set Habitacion_Estado=0
	where Habitacion_Numero in (select hab_codigo from @hab_asign)
	return
	end
go

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
		
				declare @aux datetime = convert(datetime, '01-01-2018' ,103)
				
				declare @fin datetime= convert(datetime, '01-01-2021' ,103)
				if(exists (select * from FOUR_SIZONS.Disponibilidad where Hotel_Codigo=@HotelId and Habitacion_Tipo_Codigo=@TipoHabID))
					begin
								 
								update FOUR_SIZONS.Disponibilidad
								set Disp_HabDisponibles= Disp_HabDisponibles+1
								where @TipoHabID=Habitacion_Tipo_Codigo and (Disp_Fecha between @aux and @fin) and Hotel_Codigo =@HotelId
							
					end
				else 
					begin
						while (datediff(day,@aux,@fin)!=0)
							begin
								insert into FOUR_SIZONS.Disponibilidad	(Disp_HabDisponibles,Habitacion_Tipo_Codigo,Disp_Fecha,Hotel_Codigo) values(1,@TipoHabID,@aux,@HotelId)
								set @aux = DATEADD(day, 1, @aux)
							end
					end
			end
		else 
			begin
				RAISERROR('el numero de habitacion ya figura en ese hotel, ingrese otro por favor',16,1)
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

create procedure four_sizons.modificarHabitacion
@numero numeric(18),
@hotId numeric(18),
@piso numeric(18),
@ubicacion nvarchar(50),
@TipoHab nvarchar(255),
@descripcion nvarchar(255),
@estado bit
as 
begin tran 
begin try

declare @TipoHabID numeric(18)
set @TipoHabID = (select Habitacion_Tipo_Codigo from FOUR_SIZONS.Habitacion_Tipo where @TipoHab = Habitacion_Tipo_Descripcion)
declare @estadoAnt bit =(select Habitacion_Estado from FOUR_SIZONS.Habitacion where Habitacion_Numero = @numero and Hotel_Codigo=@hotId)
update FOUR_SIZONS.Habitacion
set Habitacion_Piso= @piso,Habitacion_Frente=@ubicacion,Habitacion_Estado=@estado,Habitacion_Descripcion=@descripcion
where Habitacion_Numero=@numero and Hotel_Codigo= @hotId

declare @aux datetime = convert(datetime, '01-01-2018' ,103)			
declare @fin datetime= convert(datetime, '01-01-2021' ,103)

if(@estado = 1 and @estadoAnt = 0)
begin
	update FOUR_SIZONS.Disponibilidad
	set Disp_HabDisponibles= Disp_HabDisponibles+1
	where @TipoHabID=Habitacion_Tipo_Codigo and (Disp_Fecha between @aux and @fin) and Hotel_Codigo =@hotId
end
if(@estado = 0 and @estadoAnt = 1)
begin
	update FOUR_SIZONS.Disponibilidad
	set Disp_HabDisponibles= Disp_HabDisponibles-1
	where @TipoHabID=Habitacion_Tipo_Codigo and (Disp_Fecha between @aux and @fin) and Hotel_Codigo =@hotId
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
--------------------------------------------------ABM REGIMEN DE ESTADIA---------------------------------------------------










--------------------------------------------------DICE QUE NO HAY QUE DESARROLLARLO----------------------------------
go
create proc four_sizons.DisponibilidadyPrecio
@fechaInicio datetime,
@fechaFin datetime,
@hotid numeric (18),
@regId numeric(18),
@canthab numeric(18),
@tipoHabDesc nvarchar(50)
as begin 
	declare @cantidadNoches numeric(2)
	set @fechaInicio= convert(datetime,@fechaInicio,103)
	set @fechafin= convert(datetime,@fechafin,103)
	declare @preReg decimal(12)  = (select Regimen_Precio from four_sizons.regimen where Regimen_Codigo=@regId)
	declare @recarga decimal(12) = (select Hotel_CantEstrella*Hotel_Recarga_Estrella from FOUR_SIZONS.Hotel where Hotel_Codigo=@hotId)
	declare @tipoHab numeric(18) = (select Habitacion_Tipo_Codigo from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Descripcion=@tipoHabDesc)
	declare @porcentual decimal(12) = (select Habitacion_Tipo_Porcentual from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Codigo =@tipoHab)
	if(not exists(select * from FOUR_SIZONS.Hotel_Cerrado where Hotel_Codigo=@hotid and ((@fechaInicio between Cerrado_FechaI and Cerrado_FechaF)or (@fechaFin between Cerrado_FechaI and Cerrado_FechaF))))
	begin
	-- verifica que haya disponibilidad
	if(1= four_sizons.verificarDisp(@fechaInicio, @fechaFin,@hotId, @tipoHab,@cantHab))
	begin
	set @cantidadNoches = DATEDIFF(day, @fechaInicio, @fechaFin)

	if(@regId=0)
	begin
		select r.Regimen_Codigo,r.Regimen_Descripcion,r.Regimen_Precio*@porcentual+@recarga,@cantidadNoches * @cantHab*(r.Regimen_Precio*@porcentual+@recarga)
		from FOUR_SIZONS.Regimen r, RegXHotel rh 
		where r.Regimen_Codigo = rh.Regimen_Codigo and rh.Hotel_Codigo=@hotid
		order by r.Regimen_Codigo
	end
	else
	begin
		declare @regdesc nvarchar(255) = (select Regimen_Descripcion from FOUR_SIZONS.Regimen where Regimen_Codigo=@regId)
		declare @precio numeric(18)= (select Regimen_Precio from FOUR_SIZONS.Regimen where Regimen_Codigo=@regId)
		select  @regdesc, @precio*@porcentual+@recarga,@cantidadNoches * @cantHab*(@precio*@porcentual+@recarga)
	end

	end

	else RAISERROR('No hay lugar en este hotel para estas fechas, intente nuevamente',16,1) 
	end
	else raiserror('no hay disponibilidad, el hotel esta cerrado entre esas fechas',16,1)
end
go

create procedure four_sizons.GenerarReserva
@fechaInicio datetime,
@fechaFin datetime,
@userId nvarchar(15),
@hotId numeric(18),
@cliId numeric(18),
@regId numeric(18),
@cantHab numeric(18),
@tipoHabDesc nvarchar(50),
@precio decimal(12),
@fechaCreacion datetime

as begin tran
begin try


	begin
		if((select Cliente_Estado from FOUR_SIZONS.Cliente where Cliente_Codigo = @cliId)=1)
			begin

				declare @cantidadNoches numeric(2)
				declare @tipoHab numeric(18) = (select Habitacion_Tipo_Codigo from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Descripcion=@tipoHabDesc)
				set @cantidadNoches = DATEDIFF(day, @fechaInicio, @fechaFin)
				insert into FOUR_SIZONS.Reserva(Reserva_Codigo,Reserva_Fecha_Inicio,Reserva_Fecha_Fin,Reserva_Cant_Noches,
								Reserva_Precio,Usuario_ID,Hotel_Codigo,Cliente_Codigo,Regimen_Codigo,Reserva_Estado,habitacion_tipo_codigo,reserva_cant_hab,Reserva_FechaCreacion)
								values((NEXT VALUE FOR sec_cod_reserva),@fechaInicio,@fechaFin,@cantidadNoches,
								@precio,@userId,@hotId,@cliId,@regId,1,@tipohab,@canthab,convert(datetime,@fechaCreacion,103))
				--aca baja la disponibilidad
				
					begin
						
						update FOUR_SIZONS.Disponibilidad
						set Disp_HabDisponibles = Disp_HabDisponibles - @cantHab
						
						where Disp_Fecha between @fechaInicio and @fechaFin  and Hotel_Codigo = @hotId and Habitacion_Tipo_Codigo = @tipohab
						
					end
			end

		else raiserror ('El cliente esta deshabilitado, no puede hospedarse en los hoteles',16,1)
		
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

CREATE procedure four_sizons.ModificarReserva
	@codigoReserva numeric(18),
	@fechaInicio datetime,
	@fechaFin datetime,
	@userId nvarchar(15),
	@hotid numeric (18),
	@tipoHabDesc nvarchar(50),
	@detalle nvarchar (255),
	@regId numeric(18),
	@estado numeric(1),
	@canthab numeric(18),
	@fechaCambio datetime

	as begin tran
	begin try 
	set @fechaCambio = convert(datetime,@fechaCambio,103)
	declare @fI datetime , @fF datetime , @canth numeric(18) , @tHab numeric (18), @hotel numeric(18),@ClieA numeric(18),@estadoActual numeric(1)

	select @fi = @fechaInicio , @ff = Reserva_Fecha_Fin,@canth=Reserva_cant_hab , @tHab=habitacion_tipo_codigo,
	@hotel= Hotel_Codigo ,@ClieA=Cliente_Codigo,@estadoActual=Reserva_Estado
	from FOUR_SIZONS.Reserva 
	where Reserva_Codigo=@codigoReserva

	declare @mod_numero decimal(18)
	select @mod_numero = isnull(count(*),0)+1 from FOUR_SIZONS.ReservaMod where Reserva_Codigo = @codigoReserva

begin
if(@estadoActual !=6)
	begin
		if(@estadoActual=1 or @estadoActual=2)
			begin
				IF((select datediff(day,@fi,@fechaCambio))>0)-- verifica que que la fecha de inicio de la reserva no alla pasado ya
				begin
					update FOUR_SIZONS.Reserva set Reserva_Estado=5 
					where Reserva_Codigo = @codigoReserva--SE CANCELA LA RESERVA POR NO-SHOW CUANDO ES TARDE
					update FOUR_SIZONS.Disponibilidad
						set Disp_HabDisponibles = Disp_HabDisponibles + @canth
						where Disp_Fecha between @fi and @ff and Hotel_Codigo = @hotel and Habitacion_Tipo_Codigo = @tHab

					insert into FOUR_SIZONS.ReservaMod (ResMod_Codigo,Reserva_Codigo,Usuario_ID, ResMod_Detalle,ResMod_Fecha)
									   values (@mod_numero,@codigoReserva,@userId,@detalle,convert(datetime,@fechaCambio,103))

					commit tran 
					begin tran
					raiserror('La reserva fue cancelada por NO-SHOW',16,1)
				end
				ELSE
				BEGIN
				IF((select datediff(day,@fechaInicio,@fechaCambio))>0)-- verifica que que la nueva fecha de inicio de la reserva no alla pasado ya
				begin
					raiserror('La fecha ingresada es anterior a la fecha actual del sistema',16,1)
				end
				else
				begin
				
				
				IF(@estado=1 or @estado=2)
					begin
						declare @cantidadNoches numeric(2)
						declare @tipoHab numeric(18) = (select Habitacion_Tipo_Codigo from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Descripcion=@tipoHabDesc)

						
						declare @precio decimal(12)
						declare @preReg decimal(12)  = (select Regimen_Precio from four_sizons.regimen where Regimen_Codigo=@regId)
						declare @recarga decimal(12) = (select Hotel_CantEstrella*Hotel_Recarga_Estrella from FOUR_SIZONS.Hotel where Hotel_Codigo=@hotId)
						declare @porcentual decimal(12) = (select Habitacion_Tipo_Porcentual from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Codigo =@tipoHab)
					
						set @cantidadNoches = DATEDIFF(day, @fechaInicio, @fechaFin)
						set @precio = @cantidadNoches * @cantHab*(@preReg*@porcentual+@recarga)
						
						
						if(@canthab != @canth or @tipohab != @thab or @hotid!=@hotel)
							begin
									
										
										update FOUR_SIZONS.Reserva
										set Reserva_Fecha_Inicio= @fechaInicio,
											Reserva_Fecha_Fin = @fechaFin,
											Regimen_Codigo = @regId,
											Reserva_Estado = 2,
											Hotel_Codigo = @hotId,
											habitacion_tipo_codigo = @tipoHab,
											reserva_cant_hab = @canthab,
											Reserva_Precio= @precio,
											Reserva_Cant_Noches=@cantidadNoches
	
										where Reserva_Codigo = @codigoReserva

											--aca baja la disponibilidad
										

												update FOUR_SIZONS.Disponibilidad
												set Disp_HabDisponibles = Disp_HabDisponibles - @cantHab
												where Disp_Fecha between @fechaInicio and @fechaFin and Hotel_Codigo = @hotId and Habitacion_Tipo_Codigo = @tipohab

											update FOUR_SIZONS.Disponibilidad
												set Disp_HabDisponibles = Disp_HabDisponibles + @canth
												where Disp_Fecha between @fi and @ff and Hotel_Codigo = @hotel and Habitacion_Tipo_Codigo = @tHab

												insert into FOUR_SIZONS.ReservaMod (ResMod_Codigo,Reserva_Codigo,Usuario_ID, ResMod_Detalle,ResMod_Fecha)
																				values (@mod_numero,@codigoReserva,@userId,@detalle,convert(datetime,@fechaCambio,103))
									

	
							end


						else
							begin 
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
									   values (@mod_numero,@codigoReserva,@userId,@detalle,convert(datetime,@fechaCambio,103))
							end	
					end

				else -- ESTE ELSE ES DE CUANDO EL ESTADO ES 3/4 O 5
					begin
						update FOUR_SIZONS.Reserva
							set Reserva_Estado = @estado	
							where Reserva_Codigo = @codigoReserva
						--aca aumenta la disponibilidad
						update FOUR_SIZONS.Disponibilidad
						set Disp_HabDisponibles = Disp_HabDisponibles + @canth
						where Disp_Fecha between @fi and @ff and Hotel_Codigo = @hotel and Habitacion_Tipo_Codigo = @tHab

						
					insert into FOUR_SIZONS.ReservaMod (ResMod_Codigo,Reserva_Codigo,Usuario_ID, ResMod_Detalle,ResMod_Fecha)
												values (@mod_numero,@codigoReserva,@userId,@detalle,convert(datetime,@fechaCambio,103))
						
					end
				end
			END
			end
		else raiserror ('La reserva ya fue cancelada, no puede ser modificada.',13,1)
	end	
else
	begin
		raiserror ('La reserva ya fue efectivizada, no puede ser modificada.',13,1)
	end
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
	RAISERROR('La tarjeta ya figura en el sistema, ingrese otra por favor.',16,1)
	

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
	if(not exists(select Reserva_Codigo from four_sizons.Reserva where Hotel_Codigo=@Hotel_Codigo and 
																(@Cerrado_FechaI between Reserva_Fecha_Inicio and Reserva_Fecha_Fin
																or @Cerrado_FechaF between Reserva_Fecha_Inicio and Reserva_Fecha_Fin)))
		begin
			insert into FOUR_SIZONS.Hotel_Cerrado(Cerrado_Detalle, Cerrado_FechaF ,Cerrado_FechaI , Hotel_Codigo)
									values (@Cerrado_Detalle,@Cerrado_FechaF,@Cerrado_FechaI,@Hotel_Codigo)

			update FOUR_SIZONS.Hotel 
			set Hotel_Estado = '0'
			where Hotel_Codigo = @Hotel_Codigo
		 end
	else raiserror ('El hotel tiene reservas entre esas fechas',16,1)
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
@formaPago nvarchar(50),
@fechaI datetime

as begin


declare @reserva numeric(18),
		@total numeric(18,2),
		@cliente numeric(18),
		@user nvarchar(15)
		 --la fecha del sistema

begin tran ta
begin try
if(not exists(select Factura_Nro from Factura where Estadia_Codigo=@estadia))	
	begin
		
		set @reserva = ( select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia)
		set @cliente = ( select Cliente_Codigo from FOUR_SIZONS.Reserva where Reserva_Codigo = @reserva)
		set @user = ( select Usuario_ID from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia)
		set @total = FOUR_SIZONS.calcEstadia(@estadia) + FOUR_SIZONS.calcConsumible(@estadia,0)
			--Es necesario tener al usuario en factura?
		if (@total is Null) set @total=0
		insert into FOUR_SIZONS.Factura(Estadia_Codigo,Factura_FormaPago,Cliente_Codigo,Factura_Fecha,Factura_Total,Factura_Estado,Factura_Consistencia,Usuario_ID)
								 values (@estadia,@formaPago,@cliente,convert(datetime,@fechaI,103),@total,0,1,@user)
	end
else raiserror('Ya existe una factura para esa estadia.',16,1)


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
@estadia numeric(18),
@formaPago nvarchar(50),
@fechaI datetime,
@estado bit
as
begin


declare @reserva numeric(18),
		@estadoA bit,
		@total numeric(18,2),
		@fact_Nro numeric(18),
		@user nvarchar(15)

begin tran ta
begin try
		set @reserva = ( select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia)
		set @fact_Nro = (select Factura_Nro from FOUR_SIZONS.Factura where Estadia_Codigo = @estadia)
		set @estadoA = (select Factura_Estado from FOUR_SIZONS.Factura where Factura_Nro=@fact_Nro)
		set @user = ( select Usuario_OUT from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia)
		if ( @estadoA != 1)

		begin
			set @total = FOUR_SIZONS.calcEstadia(@estadia) + FOUR_SIZONS.calcConsumible(@estadia,0);
			if (@total is Null) set @total=0
			update FOUR_SIZONS.Factura
			set Factura_FormaPago =@formaPago , Factura_Fecha = convert(datetime,@fechaI,103) , Factura_Total = @total, Factura_Estado=@estado, Usuario_ID=@user
			where Factura_Nro = @fact_Nro
		end
		else 
		RAISERROR('La factura ya fue facturada, no se puede realizar cambios',16,1)
		

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

------------------------------------------------------------------------------------------------
create procedure FOUR_SIZONS.RegistrarEstadiaXCliente
@cliente numeric(18),
@estadia numeric(18)
as 
begin
begin tran ta
begin try

if(not exists (select Estadia_Codigo from FOUR_SIZONS.EstadiaXCliente where Estadia_Codigo=@estadia and Cliente_Codigo=@cliente))
begin
	if((select Cliente_Estado from FOUR_SIZONS.Cliente where Cliente_Codigo=@cliente) = 0)
	begin
		raiserror ('El cliente est� deshabilitado. No puede hospedarse en los hoteles',16,1)
	end
	else
	begin
		insert into FOUR_SIZONS.EstadiaXCliente(Cliente_Codigo,Estadia_Codigo) values(@cliente,@estadia)
	end
end
else 
begin
	raiserror('Ya se encuentra registrado este cliente para esta estad�a.',16,1)
end
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
@usuario nvarchar(10),
@fecha datetime,
@codigo numeric(18) output

as begin tran 
begin try

declare @estado decimal = 0 
set @fecha = convert(datetime,@fecha,103)
--verifica que el momento del checkin sea el mismo que el dia de ingreso que dice la reserva

if(not exists (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva ))
	begin 
	raiserror('no existe el codigo de reserva',16,1)
	end
else 




begin
declare @fechaInicio datetime = (select Reserva_Fecha_Inicio from FOUR_SIZONS.Reserva where Reserva_Codigo= @reserva )
	
	declare @fechaFin datetime = (select Reserva_Fecha_Fin from FOUR_SIZONS.Reserva where Reserva_Codigo= @reserva )
	declare @precioXNoche numeric(18),
		@cantNoches numeric(18)
		set @estado =(select Reserva_Estado from Reserva where Reserva_Codigo=@reserva)
		
		declare @hotel numeric(18),@tipo numeric(18),@cant numeric(18)
		select @hotel =Hotel_Codigo , @tipo= habitacion_tipo_codigo, @cant=Reserva_cant_hab from Reserva where Reserva_Codigo=@reserva
		
---------------verifica el estado de la reserva y efectiviza la correcta y modificada
	
	if((select datediff(day,@fechaInicio,@fecha))>0 and (@estado = 1 or @estado = 2 ))
	begin
			update FOUR_SIZONS.Reserva set Reserva_Estado=5 where Reserva_Codigo = @reserva--SE CANCELA LA RESERVA POR NO-SHOW CUANDO ES TARDE
			set @estado = 5
			
				update FOUR_SIZONS.Disponibilidad 
				set Disp_HabDisponibles= Disp_HabDisponibles+@cant
				where Habitacion_Tipo_Codigo=@tipo and Hotel_Codigo=@hotel and Disp_Fecha between @fechaInicio and @fechaFin
				
				
		end

		commit tran 
		begin tran

if(( select c.Cliente_Estado from FOUR_SIZONS.Reserva r, FOUR_SIZONS.Cliente c where r.Reserva_Codigo=@reserva and c.Cliente_Codigo= r.Cliente_Codigo)=1)
begin

	if((select datediff(day,@fechaInicio,@fecha))<0 and (@estado = 1 or @estado = 2 ))
	begin
		set @estado=7
	end

	if(@Estado= 3)
	begin
			RAISERROR('la reserva fue cancelada por recepcionista',16,1)
	end
	
	if(@Estado= 4)
	begin
	RAISERROR('la reserva fue cancelada por cliente',16,1)
	end



	if(@Estado= 5)
	begin
				RAISERROR('Reserva cancelada por No-Show',16,1)
	end

	if(@estado=7)
	begin
	RAISERROR('todavia no es la fecha de ingreso de la reserva',16,1)
	end

	if(@estado=6)
	begin
	RAISERROR('Reserva ya efectivizada',16,1)
	end

	if (@Estado = 1 or @Estado =2)
	begin
	set @estado= 6			
	set @cantNoches = (select Reserva_Cant_Noches from FOUR_SIZONS.Reserva   where Reserva_Codigo = @reserva)
	set @precioXNoche = (select Reserva_Precio from FOUR_SIZONS.Reserva res where res.Reserva_Codigo = @reserva)/@cantNoches
	insert into FOUR_SIZONS.Estadia(Reserva_Codigo,Estadia_FechaInicio,Usuario_ID,Estadia_PreXNoche,Estadia_CantNoches,Estadia_FechaFin,Usuario_OUT,Estadia_DiasRest,Hotel_Codigo,Estadia_Estado) 
							values(@reserva,@fechaInicio,@usuario,@precioXNoche,@cantNoches,@fechaFin,@usuario,0,@hotel,1)
	set @codigo = (select top 1 Estadia_Codigo from FOUR_SIZONS.Estadia order by Estadia_Codigo desc)

	update FOUR_SIZONS.Reserva set Reserva_Estado=@estado where Reserva_Codigo = @reserva


	declare @tipo_Hab numeric(18), @cant2 numeric(18) , @hotel2 numeric(18)
	(select @tipo_Hab=r.habitacion_tipo_codigo , @cant2=r.Reserva_cant_hab , @hotel2=r.Hotel_Codigo from FOUR_SIZONS.Reserva r where Reserva_Codigo = @reserva)

	
	declare @hab_asign table  (hab_codigo numeric(18))
	while((select isnull(count(hab_codigo),0)from @hab_asign)<@cant)
	begin
	INSERT INTO @hab_asign (hab_codigo)
	SELECT top 1 h.Habitacion_Numero
	FROM  four_sizons.Habitacion h 
	where h.Habitacion_Tipo_Codigo=@tipo_Hab and @hotel2=h.Hotel_Codigo and h.Habitacion_Estado=1 and h.Habitacion_Numero not in(select hab_codigo from @hab_asign)
	order by h.Habitacion_Numero asc
	end

	insert into FOUR_SIZONS.EstadiaXHabitacion (Habitacion_numero , Hotel_codigo , Estadia_Codigo)
	select hab_codigo , @hotel2 , @codigo
	from @hab_asign

	select * from @hab_asign
	update FOUR_SIZONS.Habitacion 
	set Habitacion_Estado=0
	where Habitacion_Numero in (select hab_codigo from @hab_asign) and Hotel_Codigo = @hotel2 and Habitacion_Tipo_Codigo=@tipo_Hab
end

	
	end	else raiserror('no se puede realizar el check-in porque el cliente esta deshabilitado',16,1) 
end	
			
commit tran 
end try
begin catch
declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,16,1)
rollback tran
end catch

GO
create proc FOUR_SIZONS.registrarCheckOut
@estadia numeric(18),
@usuario nvarchar(15),
@fecha datetime
as begin tran
begin try
declare @cantDias numeric(18),
		@difDates numeric(18),
		@precioXNoche numeric(18,0),
		@Reserva numeric(18),
		@finR datetime,
		@fact numeric(18),
		@monto numeric(18,2),
		@estadoActual bit,
		@regimen numeric(18),
		@reservaEst numeric(1)
		set @fecha = CONVERT(datetime,@fecha,103) 

	set @cantDias = DATEDIFF(day,( select Estadia_FechaInicio from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia ),@fecha);
	set @Reserva = (select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia);
	set @estadoActual = (select Estadia_Estado from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia);
	set @finR = CONVERT(datetime,(select Reserva_Fecha_Fin from FOUR_SIZONS.Reserva where Reserva_Codigo = @Reserva),121) 
	set @difDates = DATEDIFF(day,@fecha,@finR);
	set @precioXNoche = (select Estadia_PreXNoche from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia);
	set @reservaEst = (select Reserva_estado from FOUR_SIZONS.Reserva where Reserva_Codigo = @Reserva) 
	
	declare @inicio datetime = (select Reserva_Fecha_Inicio from FOUR_SIZONS.Reserva where Reserva_Codigo = @Reserva)
	set identity_insert four_sizons.item_factura on

if(@reservaEst=6)
begin
if(@estadoActual!=0)
begin
	if (@fecha between @inicio and @finR)
	begin
		UPDATE FOUR_SIZONS.Estadia
		set 
				Usuario_OUT = @usuario,
				Estadia_FechaFin = @fecha,
				Estadia_DiasRest = @difDates,
				Estadia_CantNoches =  @cantDias,
				Estadia_Estado=0
				where Estadia_Codigo = @Estadia;

	set @monto = (select Reserva_Precio from FOUR_SIZONS.Reserva where Reserva_Codigo =@Reserva)
	set @fact = (select Factura_Nro from FOUR_SIZONS.Factura where Estadia_Codigo = @Estadia)
	set @regimen=(select Regimen_Codigo from Reserva where Reserva_Codigo=@Reserva)
	if((select Regimen_Descripcion from Regimen where Regimen_Codigo=@regimen)='ALL INCLUSIVE')
	begin
		
		declare @nitem numeric(18) = isnull((select top 1 Item_Factura_NroItem  from FOUR_SIZONS.Item_Factura where Factura_Nro=@fact order by Item_Factura_NroItem desc),0)+1
		insert into FOUR_SIZONS.Item_Factura(Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto,Item_Factura_NroItem)
					values(@fact,'Descuento Por Regimen',1, FOUR_SIZONS.calcConsumible(@Estadia,1)*-1,@nitem)
		
	end
	if(@difDates=0)
		begin
		declare @nitem2 numeric(18) = isnull((select top 1 Item_Factura_NroItem  from FOUR_SIZONS.Item_Factura where Factura_Nro=@fact order by Item_Factura_NroItem desc),0)+1
			insert into FOUR_SIZONS.Item_Factura(Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto,Item_Factura_NroItem)

				values(@fact,'Estadia',(@cantDias), @monto,@nitem2)
				----- EN CANTIDAD DE ESTADIA PONGO LA CANTIDAD DE NOCHES QUE SE QUEDA
		end
	else 
		begin
		declare @nitem3 numeric(18) = isnull((select top 1 Item_Factura_NroItem  from FOUR_SIZONS.Item_Factura where Factura_Nro=@fact order by Item_Factura_NroItem desc),0)+1
			insert into FOUR_SIZONS.Item_Factura(Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto,Item_Factura_NroItem)
				values(@fact,'Estadia',@cantDias, (@cantDias)*@precioXNoche,@nitem3)
			insert into FOUR_SIZONS.Item_Factura(Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto,Item_Factura_NroItem)
				values(@fact,'Recargo de estadia',(@difDates),( @difDates)*@precioXNoche,@nitem3+1)
		end
		declare @habi numeric(18),
				@hotel numeric(18),
				@tipoHab numeric(18)
		set @habi=(select Reserva_cant_hab from Reserva where Reserva_Codigo=@Reserva)
		set @hotel=(select Hotel_Codigo from Reserva where Reserva_Codigo=@Reserva)
		
		while(@habi>0)
		begin
			update FOUR_SIZONS.Habitacion 
			set Habitacion_Estado=1
			where Hotel_Codigo=@hotel and Habitacion_Estado=0 and Habitacion_Tipo_Codigo=@tipoHab
			set @habi=@habi-1
		end
end

else raiserror('la fecha de egreso es posterior a la fecha fin de la estadia',16,1)

end
else raiserror('ya se ha realizado el checkout de esta estadia anteriormente',16,1)
end
else raiserror('No se realizo el check in de esta reserva todavia.',16,1)

set identity_insert four_sizons.item_factura off
commit tran 
end try
begin catch
declare @mensaje_de_error nvarchar(255)
	set @mensaje_de_error = ERROR_MESSAGE()
	RAISERROR(@mensaje_de_error,11,1)
rollback tran
end catch
GO

----------------------------------------------------------------------------------

create procedure four_sizons.RegistrarConsXest
@estadia numeric(18),
@consumible nvarchar(255),
@cant numeric(18)
as begin tran 
	begin try
	declare @total numeric (18,2)
	declare @factura numeric(18)
	declare @monto numeric(18)
	declare @consumibleId numeric(18)

	--set  = (select Consumible_Codigo from FOUR_SIZONS.Consumible where @consumible = Consumible_Descripcion)
	
	select @consumibleId = Consumible_Codigo, @monto = Consumible_Precio from FOUR_SIZONS.Consumible where Consumible_Descripcion = @consumible

	set @factura=(select f.Factura_Nro from FOUR_SIZONS.Factura f where @estadia = f.Estadia_Codigo)
	--set @desc=(select Consumible_Descripcion from FOUR_SIZONS.Consumible where @consumibleId = Consumible_Codigo)
	--set @monto =(select Consumible_Precio from FOUR_SIZONS.Consumible where @consumible = Consumible_Codigo)
	if((select Estadia_Estado from FOUR_SIZONS.Estadia where Estadia_Codigo=@estadia)!=0)
	begin

	if(not exists (select Estadia_Codigo from FOUR_SIZONS.EstadiaXConsumible where Estadia_Codigo= @estadia and Consumible_Codigo = @consumibleId))
		begin
			insert into FOUR_SIZONS.EstadiaXConsumible(Estadia_Codigo,estXcons_cantidad,Consumible_Codigo)
										values(@estadia,@cant,@consumibleId)
			set identity_insert FOUR_SIZONS.Item_Factura on
			declare @nItem numeric(18)= isnull((select top 1 Item_Factura_NroItem from FOUR_SIZONS.Item_Factura where Factura_Nro=@factura order by Item_Factura_NroItem desc),0)+1
			insert into FOUR_SIZONS.Item_Factura(Factura_Nro , item_descripcion , Item_Factura_Cant , Item_Factura_Monto , Item_Factura_NroItem)
								values(@factura,@consumible,@cant,@monto*@cant , @nItem)
			set identity_insert FOUR_SIZONS.Item_Factura off
		end 
	else 
		begin
			declare @numItem numeric(18)

			set @numItem=(select f.Item_Factura_NroItem from FOUR_SIZONS.Item_Factura f where Factura_Nro= @factura and @consumible = item_descripcion)
			
			update FOUR_SIZONS.EstadiaXConsumible 
				set estXcons_cantidad = @cant+ estXcons_cantidad
				where Estadia_Codigo= @estadia and Consumible_Codigo = @consumibleId
			

			update FOUR_SIZONS.Item_Factura
					set Item_Factura_Cant = Item_Factura_Cant+@cant,
						Item_Factura_Monto = Item_Factura_Monto + (@monto*@cant)

					where @factura=Factura_Nro and @numItem = Item_Factura_NroItem


		end
	end 
	else 
	begin
	raiserror('no se puede registrar el consumible ya que se ha realizado el check-out anteriormente',16,1)
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

create proc FOUR_SIZONS.bajaModifConsXestadia
@estadia numeric(18),
@consumible nvarchar(255),
@cant numeric(18)
as begin tran
begin try

	declare @total numeric (18,2)
 	declare @monto numeric(18)
	declare @consumibleId numeric(18)
	declare @fact numeric(18) = (select Factura_Nro from FOUR_SIZONS.Factura where Estadia_Codigo=@estadia)
	select @consumibleId = Consumible_Codigo, @monto = Consumible_Precio from FOUR_SIZONS.Consumible where Consumible_Descripcion = @consumible
	declare @numItem numeric(18)
    set @numItem=(select f.Item_Factura_NroItem from FOUR_SIZONS.Item_Factura f where Factura_Nro= @fact and @consumible = item_descripcion)
	if((select Estadia_Estado from FOUR_SIZONS.Estadia where Estadia_Codigo=@estadia)!=0)
	begin

	if(exists (select * from FOUR_SIZONS.EstadiaXConsumible where Estadia_Codigo=@estadia and Consumible_Codigo=@consumibleId))
begin
	
		declare @cantActual numeric(18) = (select estXcons_cantidad from FOUR_SIZONS.EstadiaXConsumible where @consumibleId= Consumible_Codigo and Estadia_Codigo=@estadia)

		if(@cantActual- @cant !=0 )
			begin 
			if (@cantActual-@cant <0)
			raiserror('La cantidad ingresada es mayor a la cantidad de consumibles pedidos actual para esta estadia',16,1)
			else 
			update FOUR_SIZONS.EstadiaXConsumible
			set estXcons_cantidad = estXcons_cantidad-@cant
			where Consumible_Codigo=@consumibleId and Estadia_Codigo = @estadia

			update FOUR_SIZONS.Item_Factura
			set Item_Factura_Monto = Item_Factura_Monto - (@monto*@cant),
			Item_Factura_Cant = Item_Factura_Cant+@cant
			where Factura_Nro= @fact and Item_Factura_NroItem = @numItem
			end
		else
		begin


		delete FOUR_SIZONS.EstadiaXConsumible
		where Estadia_Codigo=@estadia and Consumible_Codigo=@consumibleId
		set identity_insert FOUR_SIZONS.Item_Factura on

		declare @nItem numeric(18) = isnull((select top 1 Item_Factura_NroItem from FOUR_SIZONS.Item_Factura where Factura_Nro=@fact order by Item_Factura_NroItem desc),0) +1
		declare @precio decimal(18,2) = (select Item_Factura_Monto from FOUR_SIZONS.Item_Factura where Item_Factura_NroItem=@numItem and Factura_Nro=@fact)

		insert into FOUR_SIZONS.Item_Factura (Factura_Nro,item_descripcion,Item_Factura_Cant,Item_Factura_Monto,Item_Factura_NroItem)
								values (@fact,@consumible,-@cant,-@precio,@nItem)

		set identity_insert FOUR_SIZONS.Item_Factura off
		end

end
else 
raiserror('No hay registro de un pedido de este consumible para esta estadia',16,1)
end
else raiserror ('no se puede realizar la operacion ya que se ha realizado el check-out anteriormente',16,1)
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

if(not exists (select *  from four_sizons.Reserva r  
			 where r.Reserva_Estado!=1 and r.Reserva_Estado!=2 and r.Reserva_Estado!=6 and ((r.Reserva_Fecha_Inicio between @inicio and @fin) or (r.Reserva_Fecha_Fin between @inicio and @fin))))
	begin
		raiserror('No hay datos reservas canceladas',13,1)
	end
	begin
		select top 5 h.Hotel_Codigo, h.Hotel_Nombre  ,COUNT(r.Reserva_Codigo)cant_Reservas_cans
		from four_sizons.Hotel h,four_sizons.Reserva r  
		where h.Hotel_Codigo=r.Hotel_Codigo and
			( (r.Reserva_Estado = 3 or r.Reserva_Estado = 4 or r.Reserva_Estado = 5)
			and  ((r.Reserva_Fecha_Inicio between @inicio and @fin) or (r.Reserva_Fecha_Fin between @inicio and @fin)))
		group by h.Hotel_Codigo,h.Hotel_Nombre  
		order by count(r.Reserva_Codigo)
	end
end 
go

create procedure four_sizons.HotelesMayorConsFact
@anio numeric(18),
@tri numeric(18)

as begin
declare @fin datetime
declare @inicio datetime

set @inicio = CONVERT(datetime, FOUR_SIZONS.InicioTRi(@tri,@anio),103)
set @fin = CONVERT(datetime,FOUR_SIZONS.finTri(@tri,@anio),103)

if(not exists (select * from four_sizons.Factura where  (Factura_Fecha between @inicio and @fin) ))
	begin
		raiserror('No hay datos de consumibles facturados para ese trimestre',13,1)
	end
else 

select top 5 h.Hotel_Codigo , h.Hotel_Nombre, sum(FOUR_SIZONS.calcConsumible(e.Estadia_Codigo,0))


from FOUR_SIZONS.Hotel h, FOUR_SIZONS.Estadia e, FOUR_SIZONS.Factura f
where h.Hotel_Codigo=e.Hotel_Codigo and f.Estadia_Codigo=e.Estadia_Codigo and f.Factura_Estado=1 and f.Factura_Fecha between @inicio and @fin
group by h.Hotel_Codigo,h.Hotel_Nombre
order by sum(FOUR_SIZONS.calcConsumible(e.Estadia_Codigo,0)) 
end 
go



create procedure four_sizons.hotelMasCerrado
@anio numeric(18),
@tri numeric(18)

as begin
declare @fin datetime
declare @inicio datetime

set @inicio =CONVERT(datetime, FOUR_SIZONS.InicioTRi(@tri,@anio),103)
set @fin = CONVERT(datetime,FOUR_SIZONS.finTri(@tri,@anio),103)
if(not exists (select * from four_sizons.Hotel_Cerrado where  (Cerrado_FechaI between @inicio and @fin) or (Cerrado_FechaF between @inicio and @fin)))
	begin
		raiserror('No hay datos de hoteles que cerraron',13,1)
		
	end
	else 
	begin
		select top 5 h.Hotel_Codigo , h.Hotel_Nombre,count(c.Cerrado_codigo) as vecesCerrado
		from FOUR_SIZONS.Hotel h , FOUR_SIZONS.Hotel_Cerrado c
		where c.Hotel_Codigo = h.Hotel_Codigo and ((c.Cerrado_FechaI between @inicio and @fin) or (c.Cerrado_FechaF between @inicio and @fin))
		group by h.Hotel_Codigo, h.Hotel_Nombre
		order by count(c.Cerrado_codigo)
	end
end 
go


create proc four_sizons.habOcupadas
@anio numeric(18),
@tri numeric(18)

as begin
declare @fin datetime
declare @inicio datetime

set @inicio = CONVERT(datetime,FOUR_SIZONS.InicioTRi(@tri,@anio),103)
set @fin =CONVERT(datetime, FOUR_SIZONS.finTri(@tri,@anio),103)

if(not exists (select * from four_sizons.Estadia e where (e.Estadia_FechaInicio between @inicio and @fin) or (e.Estadia_FechaFin between @inicio and @fin)))
	begin
		raiserror('No hay habitaciones ocupadas en ese trimestre',13,1)
	end
else

select top 5 h.Habitacion_Numero, h.Hotel_Codigo , sum(e.Estadia_CantNoches)
from FOUR_SIZONS.Estadia e ,FOUR_SIZONS.Habitacion h,FOUR_SIZONS.EstadiaXHabitacion ExH
where exh.Hotel_Codigo = h.Hotel_Codigo and ExH.Estadia_Codigo=e.Estadia_Codigo and ExH.Habitacion_numero = h.Habitacion_Numero and ((e.Estadia_FechaInicio between @inicio and @fin) or (e.Estadia_FechaFin between @inicio and @fin))
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

	set @inicio = convert(datetime,FOUR_SIZONS.InicioTRi(@tri,@anio),103)
	set @fin = convert(datetime,FOUR_SIZONS.finTri(@tri,@anio),103)


if(not exists (select * from four_sizons.Factura where  (Factura_Fecha between @inicio and @fin) and Factura_Estado=1 ))
	begin
		raiserror('No hay clientes con puntos en ese trimestre',13,1)
	end
else 

	select top 5 c.Cliente_Codigo, c.cliente_numdoc , c.cliente_nombre , c.cliente_apellido, sum(FOUR_SIZONS.calcPuntaje(f.Estadia_Codigo))puntos

		from Cliente c JOIN Factura f on c.Cliente_Codigo=f.Cliente_Codigo
		where f.Factura_Estado=1 and f.Factura_Fecha between @inicio and @fin
		group by c.Cliente_Codigo, c.cliente_numdoc , c.cliente_nombre , c.cliente_apellido

		order by sum(FOUR_SIZONS.calcPuntaje(f.Estadia_Codigo)) desc

end
go

create procedure FOUR_SIZONS.verificarEstadoReserva
@reserva numeric(18),
@fechaOperacion datetime
as
begin
	declare @estado numeric(1)
	declare @estadoC bit
	declare @fechaInicio datetime
	declare @fechaFin datetime

	set @fechaOperacion = convert(datetime,@fechaOperacion,123)

	select @estado = R.Reserva_Estado, @estadoC = C.Cliente_Estado, @fechaInicio = R.Reserva_Fecha_Inicio, @fechaFin = Reserva_Fecha_Fin
	from FOUR_SIZONS.Reserva R join FOUR_SIZONS.Cliente C ON C.Cliente_Codigo = R.Cliente_Codigo where R.Reserva_Codigo = @reserva

	if(@estadoC = 1)
	begin

		if((datediff(day,@fechaInicio, @fechaOperacion))<0 and (@estado = 1 or @estado = 2 ))
		begin
			RAISERROR('Todavia no es la fecha de ingreso de la reserva',16,1)
		end

		if((datediff(day,@fechaFin, @fechaOperacion))>0)
		begin
			RAISERROR('La fecha de la reserva ya ha pasado',16,1)
		end

		if((datediff(day,@fechaInicio, @fechaOperacion))=0 and (@estado = 1 or @estado = 2 ))
		begin
			RAISERROR('No se puede agregar consumible porque no se hizo el check-in',16,1)
		end

		if(@Estado= 3)
		begin
			RAISERROR('La reserva fue cancelada por recepcionista',16,1)
		end
	
		if(@Estado= 4)
		begin
			RAISERROR('La reserva fue cancelada por cliente',16,1)
		end

		if(@Estado= 5)
		begin
			RAISERROR('Reserva cancelada por No-Show',16,1)
		end

		if(@estado=6)
		begin
			declare @estadoEstadia bit = (select Estadia_Estado from FOUR_SIZONS.Estadia where Reserva_Codigo=@reserva)
			if (@estadoEstadia!=1)
			begin
			raiserror('no es posible registrar consumibles, ya se hizo el check-out',16,1)
			end
		end

	end	else raiserror('No se puede realizar el check-in porque el cliente esta deshabilitado',16,1) 
end