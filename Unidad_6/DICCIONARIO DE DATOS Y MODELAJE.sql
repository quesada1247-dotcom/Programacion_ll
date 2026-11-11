-- EJERCICIO 2: DICCIONARIO DE DATOS Y MODELAJE

USE Tienda;

-- Crear la tabla Pedidos
CREATE TABLE IF NOT EXISTS Pedidos (
    IdPedido INT AUTO_INCREMENT PRIMARY KEY,
    IdCliente INT,
    FechaPedido DATE,
    Total DECIMAL(10,2),
    FOREIGN KEY (IdCliente)
        REFERENCES Clientes(IdCliente)
);

-- Consultar estructura de Clientes
DESCRIBE Clientes;

-- Consultar estructura de Pedidos
DESCRIBE Pedidos;