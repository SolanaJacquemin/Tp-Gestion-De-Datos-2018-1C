CREATE TABLE Habitaciones_Tipo (
       Habitacion_Tipo_Codigo numeric(18) PRIMARY KEY,
       Habitacion_Tipo_Descripcion nvarchar(255),
       Habitacion_Tipo_Porcentual numeric(18,2),
)

INSERT INTO Habitaciones_Tipo (Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual) 
SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
FROM GD1C2018.gd_esquema.Maestra
ORDER BY Habitacion_Tipo_Codigo

SELECT * FROM Habitaciones_Tipo