USE Visual_Basic_CRUD;

sp_helptext --ELEMENTO


-------------------------------------------------------------------------------
--TIENDA
-------------------------------------------------------------------------------

CREATE PROCEDURE SP_Agregar_Tienda
@Nombre NVARCHAR(100),
@Ubicacion NVARCHAR(100)
AS
BEGIN
-- Lógica del procedimiento
 INSERT INTO Tienda (Nombre, Ubicacion, EstadoID)
    VALUES (@Nombre, @Ubicacion, 1);
END;
GO

CREATE PROCEDURE SP_Mostrar_Tienda
AS
BEGIN
-- Lógica del procedimiento
SELECT 
TiendaID AS [#],
Nombre AS [Nombre],
Ubicacion AS [Ubicacion]
FROM Tienda
WHERE EstadoID = 1;
END;
GO

CREATE PROCEDURE SP_Buscar_Tienda
@Buscar NVARCHAR(100)
AS
BEGIN
-- Lógica del procedimiento
SELECT 
    TiendaID AS [# Tienda],
    Nombre AS [Nombre],
    Ubicacion AS [Ubicacion]
FROM Tienda
WHERE EstadoID = 1 
  AND (CAST(TiendaID AS NVARCHAR) + Nombre + Ubicacion) LIKE '%' + @Buscar + '%';
END;
GO

CREATE PROCEDURE SP_Modificar_Tienda
@TiendaID INT,
@Nombre NVARCHAR(100),
@Ubicacion NVARCHAR(100)
AS
BEGIN
-- Lógica del procedimiento
 UPDATE Tienda SET
 Nombre = @Nombre, 
 Ubicacion = @Ubicacion
 WHERE TiendaID = @TiendaID;
END;
GO

CREATE PROCEDURE SP_Eliminar_Tienda
@TiendaID INT
AS
BEGIN
-- Lógica del procedimiento
 UPDATE Tienda SET
 EstadoID = 2
 WHERE TiendaID = @TiendaID;
END;
GO
-------------------------------------------------------------------------------
-- EMPLEADO
-------------------------------------------------------------------------------
CREATE PROCEDURE SP_AGREGAR_EMPLEADO
@NOMBRE NVARCHAR(100),
@TIENDA INT
AS
BEGIN
INSERT INTO Empleado (Nombre,TiendaID,EstadoID)
VALUES (@NOMBRE, @TIENDA,1);
END;
GO

CREATE PROCEDURE SP_BUSCAR_EMPLEADO
@Buscar NVARCHAR(100)
AS
BEGIN
SELECT        
Empleado.EmpleadoID AS [#], 
Empleado.Nombre AS [Nombre], 
Empleado.TiendaID as [ID_de_la_tienda], 
Tienda.Nombre AS [Nombre_de_la_Tienda]
FROM            
Empleado INNER JOIN
Tienda ON Empleado.TiendaID = Tienda.TiendaID WHERE Empleado.EstadoID = 1 AND (CAST (Empleado.EmpleadoID AS nvarchar) + Empleado.Nombre + Tienda.Nombre) Like '%' + @Buscar + '%';
END;
GO

CREATE PROCEDURE SP_MODIFICAR_EMPLEADO
@EMPLEADOID INT,
@NOMBRE NVARCHAR(100),
@TIENDAID INT
AS
BEGIN
UPDATE Empleado SET 
EMPLEADO.Nombre = @NOMBRE,
EMPLEADO.TiendaID = @TIENDAID 
WHERE EMPLEADO.EmpleadoID = @EMPLEADOID
END;
GO

CREATE PROCEDURE SP_ELIMINAR_EMPLEADO
@EMPLEADOID INT
AS
BEGIN
UPDATE Empleado SET 
EMPLEADO.EstadoID = 2
WHERE EMPLEADO.EmpleadoID = @EMPLEADOID
END;
GO
-------------------------------------------------------------------------------
--PRODUCTOS
-------------------------------------------------------------------------------
CREATE PROCEDURE SP_AGREGAR_PRODUCTOS
@NOMBRE NVARCHAR(100)
AS
BEGIN
INSERT INTO PRODUCTO (Nombre,EstadoID)
VALUES (@NOMBRE,1);
END;
GO

CREATE PROCEDURE SP_BUSCAR_PRODUCTOS
@Buscar NVARCHAR(100)
AS
BEGIN
SELECT        
PRODUCTO.EstadoID AS [#], 
PRODUCTO.Nombre AS [Nombre]
FROM            
Producto 
END;
GO

CREATE PROCEDURE SP_MODIFICAR_PRODUCTOS
@PRODUCTOID INT,
@NOMBRE NVARCHAR(100)
AS
BEGIN
UPDATE Producto SET 
PRODUCTO.Nombre = @NOMBRE
WHERE PRODUCTO.ProductoID = @PRODUCTOID
END;
GO

CREATE PROCEDURE SP_ELIMINAR_PRODUCTOS
@PRODUCTOID INT
AS
BEGIN
UPDATE Producto SET 
Producto.EstadoID = 2
WHERE producto.ProductoID = @PRODUCTOID
END;
GO
-------------------------------------------------------------------------------