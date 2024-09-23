USE Visual_Basic_CRUD;

sp_helptext --ELEMENTO

CREATE VIEW V_MOSTRAR_EMPLEADO AS
SELECT          
Empleado.EmpleadoID AS [#],   
Empleado.Nombre AS [Nombre],   
Empleado.TiendaID as [ID de la tienda],   
Tienda.Nombre AS [Nombre Tienda]  
FROM              
Empleado INNER JOIN  
Tienda ON Empleado.TiendaID = Tienda.TiendaID WHERE Empleado.EstadoID = 1;
GO



CREATE VIEW V_Mostrar_Tienda AS
SELECT          
TiendaID AS [#],         
Nombre AS [Nombre],         
Ubicacion AS [Ubicacion]     
FROM Tienda     
WHERE EstadoID = 1;
GO

CREATE VIEW V_Mostrar_Productos AS
SELECT          
ProductoID AS [#],         
Nombre AS [Nombre]   
FROM Producto     
WHERE EstadoID = 1; 