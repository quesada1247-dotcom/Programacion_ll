-- EJERCICIO 3: SENTENCIAS DE MANIPULACION
-- Y ELIMINACION

-- 1. Seleccionar la base de datos
USE Tienda;

-- 2. Limpiar los registros anteriores de la practica
DELETE FROM Clientes;

-- 3. Insertar el primer cliente
INSERT INTO Clientes (Nombre, Correo)
VALUES ('Juan Pérez', 'juan@mail.com');

-- 4. Insertar el segundo cliente
INSERT INTO Clientes (Nombre, Correo)
VALUES ('Ana López', 'ana@mail.com');

-- 5. Mostrar los clientes registrados
SELECT * FROM Clientes;

-- 6. Eliminar a Ana López
DELETE FROM Clientes
WHERE Nombre = 'Ana López';

-- 7. Mostrar los clientes restantes
SELECT * FROM Clientes;    

-- 8. Eliminar toda la base de datos
-- IMPORTANTE: Ejecutar solamente al finalizar
-- y después de guardar todas las evidencias.

-- DROP DATABASE Tienda;


