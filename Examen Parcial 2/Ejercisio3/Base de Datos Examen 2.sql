-- 1. Crear la base de datos
CREATE DATABASE Tienda_Examen;

-- 2. Seleccionar la base de datos
USE tienda_examen;

-- Crear tabla Categoria
CREATE TABLE Categoria (
    Codigo INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);

-- Crear tabla Producto
CREATE TABLE Producto (
    Codigo INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Cantidad INT NOT NULL,
    Categoria INT NOT NULL,
    FOREIGN KEY (Categoria)
    REFERENCES Categoria(Codigo)
);

-- Insertar dos categorías
INSERT INTO Categoria (Nombre)
VALUES
('Computadoras'),
('Accesorios');

-- Insertar tres productos
INSERT INTO Producto
(Nombre, Precio, Cantidad, Categoria)
VALUES
('Laptop HP', 350000, 10, 1),
('Mouse Logitech', 12000, 25, 2),
('Teclado Gamer', 25000, 15, 2);

-- Eliminar un producto
DELETE FROM Producto
WHERE Codigo = 3;

-- Eliminar la base de datos
-- DROP DATABASE Tienda;