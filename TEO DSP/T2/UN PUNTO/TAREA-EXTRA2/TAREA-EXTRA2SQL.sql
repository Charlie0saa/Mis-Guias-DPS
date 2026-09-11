CREATE TABLE Estudiantes (

	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre NVARCHAR(100) NOT NULL,
	Carrera NVARCHAR(50) NOT NULL,
	Promedio DECIMAL(4,2) NOT NULL
);

INSERT INTO Estudiantes (Nombre,Carrera,Promedio) VALUES
	('Ana lopez','Ingenieria',9.10), ('Luis Perez','Ingenieria',7.45),
	('Marta Diaz','Diseno',8.80), ('Jose Cruz','Ingenieria',6.20),
	('Sofia Mena','Diseno',9.55);


SELECT * FROM Estudiantes;