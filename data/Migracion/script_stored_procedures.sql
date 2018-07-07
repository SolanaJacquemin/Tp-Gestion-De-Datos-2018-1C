-------------------------------------------------------Comienzo de procedures--------------------------------------------------------------
go 
-- Borrado de procedures en la base 
IF (OBJECT_ID('FOUR_SIZONS.ValidarUsuario', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE FOUR_SIZONS.ValidarUsuario
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

GO

--------------------------------------------------------ABM USUARIO------------------------------
create procedure four_sizons.altaUserxRol
@userID nvarchar(50),
@rolId numeric(18)
as begin tran
begin try
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
		if (@nombre='Super Admin' and (select count(Usuario_ID)  from FOUR_SIZONS.UsuarioXRol where Rol_Codigo=@rolId)<=1)
		begin 
			raiserror ('No se puede dar de baja super admin, ya que no se puede quedar sin super admin el sistema',13,1)
	
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
						set @errorMsg = 'Contrase�a incorrecta. El usuario est� deshabilitado'
					end

					if @fallalog < 2
					begin

						update FOUR_SIZONS.Usuario set Usuario_FallaLog = Usuario_FallaLog + 1
						set @loginok = 0
						set @errorMsg = 'Contrase�a incorrecta.'

						if @fallalog = 1
						begin

							set @errorMsg = 'Contrase�a incorrecta. El usuario se deshabilitar� ante el pr�ximo inicio de sesi�n inv�lido'

						end
					end
				end
			end
			else
			begin
				set @loginok = 0
				set @errorMsg = 'El usuario est� deshabilitado'
			end
		end
		else
		begin
			set @loginok = 0
			set @errorMsg = 'El usuario est� deshabilitado'
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
else RAISERROR('el mail ingresado ya figura en el sistema, ingrese otro por favor',1,1)
		

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
	declare @nombre nvarchar(50)
	set @nombre=(select Rol_Nombre from Rol where Rol_Codigo=@codigo)
	if (@nombre='Super Admin')
	begin 
		raiserror ('No se puede modificar el rol de super admin',13,1)
	
	end
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
	declare @nombre nvarchar(50)
	
	
	set @rolID = (select Rol_Codigo  from four_sizons.Rol where Rol_Nombre = @rolname)	
	set @funcID = (select Func_Codigo from FOUR_SIZONS.Funcionalidad where Func_Nombre = @func)
	set @nombre=(select Rol_Nombre from Rol where Rol_Codigo=@rolID)
	if (@nombre='Super Admin')
		begin 
			raiserror ('No se puede modificar la funcion asignada de super admin',13,1)
			
		end
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
create procedure four_sizons.asignarHab
@estadia numeric(18)
as begin
	declare @tipo_Hab numeric(18), @cant numeric(18) , @hotel numeric(18)
	(select @tipo_Hab=r.habitacion_tipo_codigo , @cant=r.Reserva_cant_hab , @hotel=r.Hotel_Codigo from FOUR_SIZONS.Estadia e, FOUR_SIZONS.Reserva r where e.Estadia_Codigo=@estadia and r.Reserva_Codigo= e.Reserva_Codigo)

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
		
						declare @aux datetime = convert(datetime, '01-01-2017' ,121)

						declare @aux2 datetime
						declare @fin datetime= convert(datetime, '01-01-2021' ,121)


					if(exists (select * from FOUR_SIZONS.Disponibilidad where Hotel_Codigo=@HotelId and Habitacion_Tipo_Codigo=@TipoHab))
					begin
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
						begin
							while (@aux != @fin)
							begin
							set @aux2= @aux 
							insert into FOUR_SIZONS.Disponibilidad	(Disp_HabDisponibles,Habitacion_Tipo_Codigo,Disp_Fecha,Hotel_Codigo) values(1,@TipoHab,@aux,@HotelId)
							set @aux = DATEADD(day, 1, @aux2)
							end
						end
				end
					else 
						begin
						RAISERROR('el numero de habitacion ya figura en ese hotel, ingrese otro por favor',1,1)

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

IF (OBJECT_ID('FOUR_SIZONS.DisponbilidadyPrecio', 'P') IS NOT NULL)
BEGIN
    DROP proc FOUR_SIZONS.DisponbilidadyPrecio
END;
go
create proc four_sizons.DisponbilidadyPrecio
@fechaInicio datetime,
@fechaFin datetime,
@hotid numeric (18),
@regId numeric(18),
@canthab numeric(18),
@tipoHabDesc nvarchar(50),
@precio decimal(12) output
as begin 
	declare @cantidadNoches numeric(2)
	declare @preReg decimal(12)  = (select Regimen_Precio from four_sizons.regimen where Regimen_Codigo=@regId)
	declare @recarga decimal(12) = (select Hotel_CantEstrella*Hotel_Recarga_Estrella from FOUR_SIZONS.Hotel where Hotel_Codigo=@hotId)
	declare @tipoHab numeric(18) = (select Habitacion_Tipo_Codigo from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Descripcion=@tipoHabDesc)
	declare @porcentual decimal(12) = (select Habitacion_Tipo_Porcentual from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Codigo =@tipoHab)


	if(1= four_sizons.verificarDisp(@fechaInicio, @fechaFin,@hotId, @tipoHab,@cantHab))
	begin
	set @cantidadNoches = DATEDIFF(day, @fechaInicio, @fechaFin)
	set @precio = @cantidadNoches * @cantHab*(@preReg*@porcentual+@recarga)
	end

	else RAISERROR('No hay lugar en este hotel para estas fechas, intente nuevamente',1,1) 

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
@precio decimal(12)

as begin tran
begin try
declare @cantidadNoches numeric(2)

declare @tipoHab numeric(18) = (select Habitacion_Tipo_Codigo from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Descripcion=@tipoHabDesc)



set @cantidadNoches = DATEDIFF(day, @fechaInicio, @fechaFin)

insert into FOUR_SIZONS.Reserva(Reserva_Codigo,Reserva_Fecha_Inicio,Reserva_Fecha_Fin,Reserva_Cant_Noches,
								Reserva_Precio,Usuario_ID,Hotel_Codigo,Cliente_Codigo,Regimen_Codigo,Reserva_Estado,habitacion_tipo_codigo,reserva_cant_hab)
								values((NEXT VALUE FOR sec_cod_reserva),@fechaInicio,@fechaFin,@cantidadNoches,
								@precio,@userId,@hotId,@cliId,@regId,1,@tipohab,@canthab)


--aca baja la disponibilidad
declare @aux datetime = convert(datetime,@fechaInicio,121 )
declare @aux2 datetime,
		@aux3 datetime 
set @aux3=DATEADD(day, 1, @fechaFin)
while(@aux!= convert(datetime,@aux3, 121))
begin
set @aux2= @aux
update FOUR_SIZONS.Disponibilidad
	set Disp_HabDisponibles = Disp_HabDisponibles - @cantHab
	where Disp_Fecha= @aux and Hotel_Codigo = @hotId and Habitacion_Tipo_Codigo = @tipohab
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
create  procedure four_sizons.ModificarReserva
	@codigoReserva numeric(18),
	@fechaInicio datetime,
	@fechaFin datetime,
	@userId nvarchar(15),
	@hotid numeric (18),
	@tipoHabDesc nvarchar(50),
	@detalle nvarchar (255),
	@regId numeric(18),
	@estado numeric(1),
	@canthab numeric(18)


	as begin tran
	begin try 

if(@estado !=6)
	IF(@estado=1 or @estado=2)
		begin
	declare @cantidadNoches numeric(2)
	declare @tipoHab numeric(18) = (select Habitacion_Tipo_Codigo from FOUR_SIZONS.Habitacion_Tipo where Habitacion_Tipo_Descripcion=@tipoHabDesc)

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
declare @aux2 datetime,
		@aux3 datetime
set @aux3= DATEADD(day, 1, @fechaFin)
while(@aux!= convert(datetime,@aux3, 121))
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
		end
	else
		begin
					--aca aumenta la disponibilidad
			declare @a datetime = convert(datetime,@fechaInicio,121 )
			declare @a2 datetime,
					@a3 datetime
			set @a3= DATEADD(day, 1, @fechaFin)
			while(@a!= convert(datetime,@a3, 121))
				begin
					set @a2= @a

					update FOUR_SIZONS.Disponibilidad
					set Disp_HabDisponibles = Disp_HabDisponibles + @cantHab
					where Disp_Fecha= @aux and Hotel_Codigo = @hotId and Habitacion_Tipo_Codigo = @tipohab
					set @aux = DATEADD(day, 1, @aux2)
				end

		end	
else
	begin
		raiserror ('La reserva ya fue efectivizada, no puede ser modificada',13,1)
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
@formaPago nvarchar(50)

as begin


declare @reserva numeric(18),
		@total numeric(18,2),
		@cliente numeric(18),
		@fechaI datetime --la fecha del sistema

begin tran ta
begin try
		set @fechaI= CONVERT(datetime,getdate(),121) 
		set @reserva = ( select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia);
		set @cliente = ( select Cliente_Codigo from FOUR_SIZONS.Reserva where Reserva_Codigo = @reserva);


		set @total = FOUR_SIZONS.calcEstadia(@estadia) + FOUR_SIZONS.calcConsumible(@estadia,0);
			--Es necesario tener al usuario en factura?
		if (@total is Null) set @total=0
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
@estadia numeric(18),
@formaPago nvarchar(50),
@estado bit
as
begin


declare @reserva numeric(18),
		@estadoA bit,
		@fechaI datetime,
		@total numeric(18,2),
		@fact_Nro numeric(18)
begin tran ta
begin try
		set @fechaI= CONVERT(datetime,getdate(),121) 
		set @reserva = ( select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @estadia);
		set @fact_Nro = (select Factura_Nro from FOUR_SIZONS.Factura where Estadia_Codigo = @estadia);
		if ( @estadoA != 1)

		begin
			set @total = FOUR_SIZONS.calcEstadia(@estadia) + FOUR_SIZONS.calcConsumible(@estadia,0);
			if (@total is Null) set @total=0
			update FOUR_SIZONS.Factura
			set Factura_FormaPago =@formaPago , Factura_Fecha = @fechaI, Factura_Total = @total, Factura_Estado=@estado
			where Factura_Nro = @fact_Nro
		end
		else 
		RAISERROR('La factura ya fue facturada, no se puede realizar cambios',1,1)
		

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
@usuario nvarchar(10)

as begin tran 
begin try

declare @fecha datetime = getdate()
declare @estado decimal = 0 
--verifica que el momento del checkin sea el mismo que el dia de ingreso que dice la reserva

if(not exists (select Reserva_Codigo from Reserva where Reserva_Codigo=@reserva ))
	begin 
	raiserror('no existe el codigo de reserva',1,1)
	end
else 

begin
declare @fechaInicio datetime = (select convert(datetime,Reserva_Fecha_Inicio,121) from FOUR_SIZONS.Reserva where Reserva_Codigo= @reserva )
	
	declare @fechaFin datetime = (select convert(datetime,Reserva_Fecha_Fin,121) from FOUR_SIZONS.Reserva where Reserva_Codigo= @reserva )
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
			declare @aux3 datetime=@fechaInicio,
					@aux4 datetime
			while(DATEDIFF(day,@aux3,@fechaFin)>=0)
				begin
				set @aux4=@aux3
				update FOUR_SIZONS.Disponibilidad set Disp_HabDisponibles= Disp_HabDisponibles+@cant
				where Habitacion_Tipo_Codigo=@tipo and Hotel_Codigo=@hotel 
				set @aux3=dateadd(day,1,@aux4)
				end
		end
	if((select datediff(day,@fechaInicio,@fecha))<0 and (@estado = 1 or @estado = 2 ))
	begin
		set @estado=7
	end

	if(@Estado= 3)
	begin
			RAISERROR('la reserva fue cancelada por recepcionista',1,1)
	end
	
	if(@Estado= 4)
	begin
	RAISERROR('la reserva fue cancelada por cliente',1,1)
	end



	if(@Estado= 5)
	begin
				RAISERROR('Reserva cancelada por No-Show',1,1)
	end

	if(@estado=7)
	begin
	RAISERROR('todavia no es la fecha de ingreso de la reserva',1,1)
	end

	if(@estado=6)
	begin
	RAISERROR('Reserva ya efectivizada',1,1)
	end

	if (@Estado = 1 or @Estado =2)
	begin
	set @estado= 6			
	set @cantNoches = (select Reserva_Cant_Noches from FOUR_SIZONS.Reserva   where Reserva_Codigo = @reserva)
	set @precioXNoche = (select Reserva_Precio from FOUR_SIZONS.Reserva res where res.Reserva_Codigo = @reserva)/@cantNoches
	insert into FOUR_SIZONS.Estadia(Reserva_Codigo,Estadia_FechaInicio,Usuario_ID,Estadia_PreXNoche,Estadia_CantNoches,Estadia_FechaFin,Usuario_OUT,Estadia_DiasRest,Estadia_Codigo,Hotel_Codigo) 
							values(@reserva,@fechaInicio,@usuario,@precioXNoche,@cantNoches,@fechaFin,@usuario,0,1,@hotel)
	
	update FOUR_SIZONS.Reserva set Reserva_Estado=@estado where Reserva_Codigo = @reserva
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

GO

create proc FOUR_SIZONS.registrarCheckOut
@Estadia numeric(18),
@usuario nvarchar(15)
as begin tran
begin try
declare @cantDias numeric(18),
		@difDates numeric(18),
		@precioXNoche numeric(18,0),
		@Reserva numeric(18),
		@finR datetime,
		@fact numeric(18),
		@monto numeric(18,2),
		@regimen numeric(18),
		@fecha datetime = CONVERT(datetime,getdate(),121) 

	set @cantDias = DATEDIFF(day,( select Estadia_FechaInicio from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia ),@fecha);
	set @Reserva = (select Reserva_Codigo from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia);
	set @finR = CONVERT(datetime,(select Reserva_Fecha_Fin from FOUR_SIZONS.Reserva where Reserva_Codigo = @Reserva),121) 
	set @difDates = DATEDIFF(day,@fecha,@finR);
	set @precioXNoche = (select Estadia_PreXNoche from FOUR_SIZONS.Estadia where Estadia_Codigo = @Estadia);
	
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

if(not exists (select *  from four_sizons.Reserva r join FOUR_SIZONS.ReservaMod m on r.Reserva_Codigo=m.Reserva_Codigo 
			 where r.Reserva_Codigo!=1 and r.Reserva_Codigo!=2 and r.Reserva_Codigo!=6 and m.ResMod_Fecha between @inicio and @fin))
	begin
		raiserror('No hay datos reservas canceladas',13,1)
	end
	begin
		select top 5 h.Hotel_Codigo, COUNT(r.Reserva_Codigo)cant_Reservas_cans
		from four_sizons.Hotel h,four_sizons.Reserva r, four_sizons.ReservaMod m  
		where h.Hotel_Codigo=r.Hotel_Codigo and
			( (r.Reserva_Estado = 3 or r.Reserva_Estado = 4 or r.Reserva_Estado = 5)
			and m.Reserva_Codigo=r.Reserva_Codigo  and m.ResMod_Fecha between @inicio and @fin)
		group by h.Hotel_Codigo
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

set @inicio = CONVERT(datetime, FOUR_SIZONS.InicioTRi(@tri,@anio),121)
set @fin = CONVERT(datetime,FOUR_SIZONS.finTri(@tri,@anio),121)

if(not exists (select * from four_sizons.Factura where  (Factura_Fecha between @inicio and @fin) ))
	begin
		raiserror('No hay datos de consumibles facturados para ese trimestre',13,1)
	end
else 

select top 5 h.Hotel_Codigo


from FOUR_SIZONS.Hotel h, FOUR_SIZONS.Estadia e, FOUR_SIZONS.Factura f
where h.Hotel_Codigo=e.Hotel_Codigo and f.Estadia_Codigo=e.Estadia_Codigo and f.Factura_Estado=1 and f.Factura_Fecha between @inicio and @fin
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
if(not exists (select * from four_sizons.Hotel_Cerrado where  (Cerrado_FechaI between @inicio and @fin) or (Cerrado_FechaF between @inicio and @fin)))
	begin
		raiserror('No hay datos de hoteles que cerraron',13,1)
		
	end
	else 
	begin
		select top 5 h.Hotel_Codigo
		from FOUR_SIZONS.Hotel h , FOUR_SIZONS.Hotel_Cerrado c
		where c.Hotel_Codigo = h.Hotel_Codigo and ((c.Cerrado_FechaI between @inicio and @fin) or (c.Cerrado_FechaF between @inicio and @fin))
		group by h.Hotel_Codigo
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

set @inicio = CONVERT(datetime,FOUR_SIZONS.InicioTRi(@tri,@anio),121)
set @fin =CONVERT(datetime, FOUR_SIZONS.finTri(@tri,@anio),121)

if(not exists (select * from four_sizons.Estadia e where (e.Estadia_FechaInicio between @inicio and @fin) or (e.Estadia_FechaFin between @inicio and @fin)))
	begin
		raiserror('No hay habitaciones ocupadas en ese trimestre',13,1)
	end
else

select top 5 h.Habitacion_Numero, h.Hotel_Codigo 
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

	set @inicio = convert(datetime,FOUR_SIZONS.InicioTRi(@tri,@anio),121)
	set @fin = convert(datetime,FOUR_SIZONS.finTri(@tri,@anio),121)


if(not exists (select * from four_sizons.Factura where  (Factura_Fecha between @inicio and @fin) and Factura_Estado=1 ))
	begin
		raiserror('No hay datos de consumibles facturados para ese trimestre',13,1)
	end
else 

	select top 5 c.Cliente_Codigo, c.cliente_numdoc , c.cliente_nombre , c.cliente_apellido, sum(FOUR_SIZONS.calcPuntaje(f.Estadia_Codigo))puntos

		from Cliente c JOIN Factura f on c.Cliente_Codigo=f.Cliente_Codigo
		where f.Factura_Estado=1 and f.Factura_Fecha between @inicio and @fin
		group by c.Cliente_Codigo, c.cliente_numdoc , c.cliente_nombre , c.cliente_apellido

		order by sum(FOUR_SIZONS.calcPuntaje(f.Estadia_Codigo)) desc

end
go