CREATE TABLE Habitaciones (
	Habitacion_Numero numeric(18),
	Habitacion_Piso numeric(18),
	Habitacion_Hotel int REFERENCES Hoteles(Hotel_Codigo),
	Habitacion_Frente nvarchar(50),
	Habitacion_Tipo numeric(18)  REFERENCES Habitaciones_Tipo(Habitacion_Tipo_Codigo)
	PRIMARY KEY(Habitacion_Numero, Habitacion_Piso, Habitacion_Hotel)
)

INSERT INTO Habitaciones (Habitacion_Numero, Habitacion_Piso, Habitacion_Hotel, Habitacion_Frente, Habitacion_Tipo) 
SELECT DISTINCT H.Hotel_Codigo, M.Habitacion_Numero, M.Habitacion_Piso, M.Habitacion_Frente, M.Habitacion_Tipo_Codigo
FROM GD1C2018.gd_esquema.Maestra AS M
JOIN Hoteles AS H ON H.Hotel_Ciudad = M.Hotel_Ciudad and H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
ORDER BY H.Hotel_Codigo

SELECT * FROM Habitaciones AS H
JOIN Habitaciones_Tipo AS HT ON H.Habitacion_Tipo = HT.Habitacion_Tipo_Codigo 