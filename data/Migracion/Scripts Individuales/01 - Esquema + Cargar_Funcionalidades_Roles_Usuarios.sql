CREATE SCHEMA FOUR_SIZONS
GO

CREATE TABLE FOUR_SIZONS.Funcionalidades (
	Funcionalidad_Codigo nvarchar(10) PRIMARY KEY,
	Funcionalidad_Descripcion nvarchar(255) 
)

CREATE TABLE FOUR_SIZONS.Roles (
	Rol_Nombre nvarchar(10) PRIMARY KEY,
	Rol_Funcionalidad nvarchar(10) REFERENCES FOUR_SIZONS.Funcionalidades(Funcionalidad_Codigo),
	Rol_Estado char(1) NOT NULL
)

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