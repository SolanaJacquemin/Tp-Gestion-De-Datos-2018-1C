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

INSERT INTO FOUR_SIZONS.Hoteles (Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella) 
SELECT DISTINCT Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella
FROM GD1C2018.gd_esquema.Maestra

SELECT * FROM FOUR_SIZONS.Hoteles