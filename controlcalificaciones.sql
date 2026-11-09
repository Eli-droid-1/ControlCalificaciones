--CREATE DATABASE control_calificaciones;
--GO
USE control_calificaciones;
GO

CREATE TABLE estudiantes(
id_estudiante INT IDENTITY(1,1) PRIMARY KEY,
carnet VARCHAR(10) NOT NULL UNIQUE,
nombres VARCHAR(60) NOT NULL,
apellidos VARCHAR(60) NOT NULL
);
GO

CREATE TABLE materias(
id_materia INT IDENTITY(1,1) PRIMARY KEY,
nombre_materia VARCHAR(80) NOT NULL UNIQUE
);
GO

CREATE TABLE calificaciones(
id_calificacion INT IDENTITY(1,1) PRIMARY KEY,
id_estudiante INT NOT NULL,
id_materia INT NOT NULL,
nota1 DECIMAL(4,2) NOT NULL CHECK (nota1 BETWEEN 0 AND 10),
nota2 DECIMAL(4,2) NOT NULL CHECK (nota2 BETWEEN 0 AND 10),
nota3 DECIMAL(4,2) NOT NULL CHECK (nota3 BETWEEN 0 AND 10),
promedio AS ((nota1 + nota2 + nota3) / 3) PERSISTED,
CONSTRAINT FK_calif_estudiante FOREIGN KEY (id_estudiante) REFERENCES estudiantes(id_estudiante),
CONSTRAINT FK_calif_materia FOREIGN KEY (id_materia) REFERENCES materias(id_materia),
CONSTRAINT UQ_calif_estudiante_materia UNIQUE (id_estudiante, id_materia)
);
GO

CREATE OR ALTER PROCEDURE dbo.sp_listar_calificaciones
AS
BEGIN
    SELECT c.id_calificacion, c.id_estudiante, c.id_materia, e.carnet,
           e.nombres + ' ' + e.apellidos AS estudiante,
           m.nombre_materia, c.nota1, c.nota2, c.nota3,
           CAST(ROUND(c.promedio, 2) AS DECIMAL(4,2)) AS promedio,
           CASE WHEN c.promedio >= 6 THEN 'Aprobado' ELSE 'Reprobado' END AS estado
    FROM calificaciones c
    INNER JOIN estudiantes e ON c.id_estudiante = e.id_estudiante
    INNER JOIN materias m ON c.id_materia = m.id_materia
    ORDER BY c.id_calificacion;
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_insertar_calificacion
    @id_estudiante INT,
    @id_materia INT,
    @nota1 DECIMAL(4,2),
    @nota2 DECIMAL(4,2),
    @nota3 DECIMAL(4,2)
AS
BEGIN
    INSERT INTO calificaciones (id_estudiante, id_materia, nota1, nota2, nota3)
    VALUES (@id_estudiante, @id_materia, @nota1, @nota2, @nota3);
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_actualizar_calificacion
    @id_calificacion INT,
    @id_estudiante INT,
    @id_materia INT,
    @nota1 DECIMAL(4,2),
    @nota2 DECIMAL(4,2),
    @nota3 DECIMAL(4,2)
AS
BEGIN
    UPDATE calificaciones
    SET id_estudiante = @id_estudiante,
        id_materia = @id_materia,
        nota1 = @nota1,
        nota2 = @nota2,
        nota3 = @nota3
    WHERE id_calificacion = @id_calificacion;
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_eliminar_calificacion
    @id_calificacion INT
AS
BEGIN
    DELETE FROM calificaciones WHERE id_calificacion = @id_calificacion;
END
GO
--Ejemplos
INSERT INTO estudiantes (carnet, nombres, apellidos) VALUES
('000001', 'Ana', 'Ejemplo Uno'),
('000002', 'Luis', 'Ejemplo Dos'),
('000003', 'Marta', 'Ejemplo Tres');
GO

INSERT INTO materias (nombre_materia) VALUES
('Base de Datos I'),
('Programacion I'),
('Matematica I');
GO

INSERT INTO calificaciones (id_estudiante, id_materia, nota1, nota2, nota3) VALUES
(1, 1, 9.00, 8.50, 10.00),
(2, 1, 5.00, 6.50, 4.00),
(3, 2, 7.00, 7.50, 8.00);
GO