CREATE TABLE FOUR_SIZONS.Consumibles (
	Consumible_Codigo numeric(18) PRIMARY KEY,
	Consumible_Descripcion nvarchar(255),
	Consumible_Precio numeric(18,2)
)

INSERT INTO FOUR_SIZONS.Consumibles (Consumible_Codigo, Consumible_Descripcion, Consumible_Precio) 
SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
FROM GD1C2018.gd_esquema.Maestra
WHERE Consumible_Codigo IS NOT NULL
ORDER BY Consumible_Codigo

SELECT * FROM FOUR_SIZONS.Consumibles