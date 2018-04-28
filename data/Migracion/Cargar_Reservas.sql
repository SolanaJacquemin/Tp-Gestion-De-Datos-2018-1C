CREATE TABLE Reservas (
	Reserva_Codigo numeric(18) NOT NULL,
	Reserva_Hotel_Codigo int NOT NULL REFERENCES Hoteles(Hotel_Codigo),
	Reserva_Fecha datetime,
	Reserva_Cant_Noches numeric(18),
	Reserva_Fecha_Desde datetime,
	Reserva_Fecha_Hasta datetime,
	Reserva_Tipo_Habitacion numeric(18) REFERENCES Habitaciones_Tipo(Habitacion_Tipo_Codigo),
	Reserva_Tipo_Regimen int REFERENCES Regimenes(Regimen_Codigo),
	Reserva_Cli_Nac nvarchar(50),
	Reserva_Cli_Tipo_Ident nvarchar(5),
	Reserva_Cli_Nro_Ident numeric(18)
	PRIMARY KEY(Reserva_Codigo, Reserva_Hotel_Codigo)
)

INSERT INTO Reservas (Reserva_Codigo, Reserva_Hotel_Codigo, Reserva_Fecha, Reserva_Cant_Noches, 
Reserva_Fecha_Desde, Reserva_Fecha_Hasta, Reserva_Tipo_Habitacion, Reserva_Tipo_Regimen,
Reserva_Cli_Nac, Reserva_Cli_Tipo_Ident, Reserva_Cli_Nro_Ident)
SELECT DISTINCT M.Reserva_Codigo, H.Hotel_Codigo, GETDATE(), M.Reserva_Cant_Noches, 
M.Reserva_Fecha_Inicio, M.Reserva_Fecha_Inicio, M.Habitacion_Tipo_Codigo, R.Regimen_Codigo, 
M.Cliente_Nacionalidad, 'PASSP', M.Cliente_Pasaporte_Nro
FROM GD1C2018.gd_esquema.Maestra AS M
JOIN Hoteles AS H ON H.Hotel_Ciudad = M.Hotel_Ciudad and H.Hotel_Nro_Calle = M.Hotel_Nro_Calle
JOIN Regimenes AS R ON R.Regimen_Descripcion = M.Regimen_Descripcion
ORDER BY H.Hotel_Codigo

SELECT * FROM Reservas