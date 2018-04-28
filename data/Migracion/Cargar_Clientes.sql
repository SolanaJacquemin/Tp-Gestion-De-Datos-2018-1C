CREATE TABLE Clientes (
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

INSERT INTO Clientes (Cliente_Nacionalidad, Cliente_Tipo_Ident, Cliente_Nro_Ident, Cliente_Mail, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac,
Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto) 
SELECT DISTINCT Cliente_Nacionalidad, 'PASSP', Cliente_Pasaporte_Nro, Cliente_Mail, Cliente_Apellido, Cliente_Nombre, Cliente_Fecha_Nac,
Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto
FROM GD1C2018.gd_esquema.Maestra
ORDER BY Cliente_Pasaporte_Nro

SELECT * FROM Clientes