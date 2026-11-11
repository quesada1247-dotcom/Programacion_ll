-- EJERCICIO 1: CREAR Y USAR BASES DE DATOS

-- 1. Crear la base de datos
CREATE DATABASE IF NOT EXISTS Tienda;

-- 2. Seleccionar la base de datos
USE Tienda;

-- 3. Crear la tabla Clientes
CREATE TABLE IF NOT EXISTS Clientes (
    IdCliente INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100),
    Correo VARCHAR(100)
);

-- 4. Mostrar las tablas
SHOW TABLES;

-- 5. Mostrar la estructura de Clientes
DESCRIBE Clientes;