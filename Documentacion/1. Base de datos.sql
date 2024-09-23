-- Crear la base de datos
CREATE DATABASE Visual_Basic_CRUD;
GO

-- Usar la base de datos
USE Visual_Basic_CRUD;
GO

-- Crear la tabla Estado
CREATE TABLE Estado (
    EstadoID INT PRIMARY KEY IDENTITY(1,1),
    Estado NVARCHAR(50) NOT NULL
);
GO

-- Crear la tabla Tienda
CREATE TABLE Tienda (
    TiendaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Ubicacion NVARCHAR(100) NOT NULL,
    EstadoID INT NOT NULL,
    FOREIGN KEY (EstadoID) REFERENCES Estado(EstadoID)
);
GO

-- Crear la tabla Empleado
CREATE TABLE Empleado (
    EmpleadoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    TiendaID INT NOT NULL,
    EstadoID INT NOT NULL,
    FOREIGN KEY (TiendaID) REFERENCES Tienda(TiendaID),
    FOREIGN KEY (EstadoID) REFERENCES Estado(EstadoID)
);
GO

-- Crear la tabla Producto
CREATE TABLE Producto (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    EstadoID INT NOT NULL,
    FOREIGN KEY (EstadoID) REFERENCES Estado(EstadoID)
);
GO

--Inserts para estado
INSERT INTO Estado(Estado) VALUES (1);
INSERT INTO Estado(Estado) VALUES (2);
