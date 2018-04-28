CREATE TABLE Regimenes (
	Regimen_Codigo int IDENTITY(1,1) PRIMARY KEY,
	Regimen_Descripcion nvarchar(255),
	Regimen_Precio numeric(18,2),
	Regimen_Estado char(1)
)

INSERT INTO Regimenes (Regimen_Descripcion, Regimen_Precio) 
SELECT DISTINCT Regimen_Descripcion, Regimen_Precio
FROM GD1C2018.gd_esquema.Maestra

SELECT * FROM Regimenes