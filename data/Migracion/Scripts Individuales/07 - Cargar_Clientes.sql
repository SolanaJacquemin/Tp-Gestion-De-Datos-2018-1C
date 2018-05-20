CREATE TABLE FOUR_SIZONS.Cliente (
		Cliente_Codigo numeric(18) IDENTITY (1,1),
		Cliente_Nombre nvarchar(255),
		Cliente_Apellido nvarchar(255),
		Cliente_TipoDoc nvarchar(255),
		Cliente_NumDoc numeric(18,0),
		Cliente_Dom_Calle nvarchar(255),
		Cliente_Nro_Calle numeric(18),
		Cliente_Piso numeric(18),
		Cliente_Depto nvarchar(50),
		Cliente_Mail nvarchar(255),
		Cliente_Nacionalidad nvarchar(50),
		Cliente_Fecha_Nac datetime,
		Cliente_Puntos decimal(18,2),
		Cliente_Estado nvarchar(5)
		CONSTRAINT PK_Cliente PRIMARY KEY (Cliente_Codigo)
)

INSERT INTO FOUR_SIZONS.Cliente (Cliente_Nombre, Cliente_Apellido, Cliente_TipoDoc, Cliente_NumDoc, Cliente_Dom_Calle,
Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, Cliente_Mail, Cliente_Nacionalidad, Cliente_Fecha_Nac, Cliente_Puntos, Cliente_Estado)
SELECT DISTINCT Cliente_Nombre, Cliente_Apellido, 'PASSP', Cliente_Pasaporte_Nro, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, 
Cliente_Depto, Cliente_Mail, Cliente_Nacionalidad, Cliente_Fecha_Nac, 0, 0
FROM GD1C2018.gd_esquema.Maestra
ORDER BY Cliente_Pasaporte_Nro


declare @updateDupli table(
	clienteD numeric(18)
)

insert into @updateDupli (clienteD)
select C1.Cliente_Codigo
from FOUR_SIZONS.Cliente as C1 
join FOUR_SIZONS.Cliente as C2 on c1.Cliente_NumDoc = c2.Cliente_NumDoc and c1.Cliente_Codigo > c2.Cliente_Codigo
	
	update FOUR_SIZONS.Cliente
	set Cliente_NumDoc = (Cliente_NumDoc)*(-1),
	Cliente_Estado = 1
	where Cliente_Codigo in (select clienteD from @updateDupli)