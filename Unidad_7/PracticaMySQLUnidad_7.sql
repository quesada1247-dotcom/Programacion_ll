-- BASE DE DATOS: TIENDA

-- Crear la base de datos si no existe
CREATE DATABASE IF NOT EXISTS tienda;

-- Seleccionar la base de datos
USE tienda;

-- =====================================
-- TABLA: CLIENTES
-- =====================================

CREATE TABLE IF NOT EXISTS Clientes (
    IdCliente INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) NOT NULL
);

-- =====================================
-- VERIFICAR LA BASE DE DATOS Y LA TABLA
-- =====================================

SHOW DATABASES;

SHOW TABLES;

DESCRIBE Clientes;

-- =====================================
-- CONSULTAR LOS CLIENTES REGISTRADOS
-- =====================================

SELECT * FROM Clientes;