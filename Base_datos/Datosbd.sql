use BDVentas
go 
INSERT INTO TCategoria (CodCategoria, Nombre, CategoriaPadre) VALUES
('CA001', 'Ropa', NULL), -- Categoría principal de ropa
('CA002', 'Ropa de Hombre', 'CA001'), -- Subcategoría de ropa de hombre
('CA003', 'Ropa de Mujer', 'CA001'), -- Subcategoría de ropa de mujer
('CA004', 'Ropa de Niños', 'CA001'), -- Subcategoría de ropa de niños
('CA005', 'Accesorios de Ropa', 'CA001'); -- Subcategoría de accesorios de ropa
GO
INSERT INTO TVendedor (CodVendedor,Apellidos,Nombres) VALUES
('V0001', 'García', 'Juan'),
('V0002', 'Martínez', 'María'),
('V0003', 'López', 'Carlos'),
('V0004', 'Rodríguez', 'Ana');
 GO
INSERT INTO TCliente (CodCliente, Apellidos, Nombres, Direccion) VALUES
('C0001', 'Pérez', 'Juan', 'Av. Siempre Viva 123'),
('C0002', 'González', 'María', 'Calle Falsa 456'),
('C0003', 'Rodríguez', 'Carlos', 'Calle Real 789'),
('C0004', 'López', 'Ana', 'Av. Libertador 101'),
('C0005', 'Martínez', 'Luis', 'Calle Principal 202'),
('C0006', 'García', 'Laura', 'Av. Central 303'),
('C0007', 'Hernández', 'Miguel', 'Calle Secundaria 404'),
('C0008', 'Ramírez', 'José', 'Av. Independencia 505'),
('C0009', 'Sánchez', 'Carmen', 'Calle Tercera 606'),
('C0010', 'Torres', 'Pedro', 'Av. Victoria 707'),
('C0011', 'Flores', 'Lucía', 'Calle Cuarta 808'),
('C0012', 'Rivera', 'Fernando', 'Av. Progreso 909'),
('C0013', 'Gómez', 'Patricia', 'Calle Quinta 010'),
('C0014', 'Díaz', 'Andrés', 'Av. Esperanza 111'),
('C0015', 'Álvarez', 'Carolina', 'Calle Sexta 212'),
('C0016', 'Castro', 'David', 'Av. Futuro 313'),
('C0017', 'Ortiz', 'Silvia', 'Calle Séptima 414'),
('C0018', 'Vargas', 'Jorge', 'Av. Horizonte 515'),
('C0019', 'Ramos', 'Verónica', 'Calle Octava 616'),
('C0020', 'Morales', 'Francisco', 'Av. Nueva 717');
GO

INSERT INTO TBoleta (NroBoleta, Fecha, CodCliente, CodVendedor, Anulado) VALUES
(1, '2023-01-01', 'C0001', 'V0001', 0),
(2, '2023-01-02', 'C0002', 'V0002', 0),
(3, '2023-01-03', 'C0003', 'V0003', 0),
(4, '2023-01-04', 'C0004', 'V0004', 0),
(5, '2023-01-05', 'C0005', 'V0001', 0),
(6, '2023-01-06', 'C0006', 'V0002', 0),
(7, '2023-01-07', 'C0007', 'V0003', 0),
(8, '2023-01-08', 'C0008', 'V0004', 0),
(9, '2023-01-09', 'C0009', 'V0001', 0),
(10, '2023-01-10', 'C0010', 'V0002', 0),
(11, '2023-01-11', 'C0011', 'V0003', 0),
(12, '2023-01-12', 'C0012', 'V0004', 0),
(13, '2023-01-13', 'C0013', 'V0001', 0),
(14, '2023-01-14', 'C0014', 'V0002', 0),
(15, '2023-01-15', 'C0015', 'V0003', 0),
(16, '2023-01-16', 'C0016', 'V0004', 0),
(17, '2023-01-17', 'C0017', 'V0001', 0),
(18, '2023-01-18', 'C0018', 'V0002', 0),
(19, '2023-01-19', 'C0019', 'V0003', 0),
(20, '2023-01-20', 'C0020', 'V0004', 0),
(21, '2023-01-21', 'C0001', 'V0001', 0),
(22, '2023-01-22', 'C0002', 'V0002', 0),
(23, '2023-01-23', 'C0003', 'V0003', 0),
(24, '2023-01-24', 'C0004', 'V0004', 0),
(25, '2023-01-25', 'C0005', 'V0001', 0),
(26, '2023-01-26', 'C0006', 'V0002', 0),
(27, '2023-01-27', 'C0007', 'V0003', 0),
(28, '2023-01-28', 'C0008', 'V0004', 0),
(29, '2023-01-29', 'C0009', 'V0001', 0),
(30, '2023-01-30', 'C0010', 'V0002', 0);

GO


INSERT INTO TProducto (CodProduto, Nombre, UnidadDeMedida, Precio, Stock, CodCategoria) VALUES
('P0001', 'Camiseta Hombre', 'M', 15.50, 100, 'CA002'),
('P0002', 'Pantalón Hombre', 'L', 25.00, 50, 'CA002'),
('P0003', 'Chaqueta Mujer', 'S', 35.00, 30, 'CA003'),
('P0004', 'Falda Mujer', 'M', 20.00, 70, 'CA003'),
('P0005', 'Vestido Mujer', 'L', 40.00, 40, 'CA003'),
('P0006', 'Camiseta Niños', 'S', 10.00, 80, 'CA004'),
('P0007', 'Pantalón Niños', 'M', 15.00, 60, 'CA004'),
('P0008', 'Abrigo Niños', 'L', 30.00, 20, 'CA004'),
('P0009', 'Gorro', 'Talla Única', 5.00, 200, 'CA005'),
('P0010', 'Bufanda', 'Talla Única', 7.50, 150, 'CA005'),
('P0011', 'Guantes', 'Talla Única', 8.00, 120, 'CA005'),
('P0012', 'Calcetines Hombre', 'Talla Única', 3.00, 250, 'CA002'),
('P0013', 'Zapatos Hombre', '42', 50.00, 25, 'CA002'),
('P0014', 'Blusa Mujer', 'M', 18.00, 60, 'CA003'),
('P0015', 'Short Niños', 'S', 12.00, 40, 'CA004'),
('P0016', 'Corbata', 'Talla Única', 10.00, 90, 'CA005'),
('P0017', 'Cinturón', 'Talla Única', 12.50, 80, 'CA005'),
('P0018', 'Jersey Hombre', 'L', 22.00, 35, 'CA002'),
('P0019', 'Chaqueta Hombre', 'XL', 45.00, 20, 'CA002'),
('P0020', 'Sombrero Mujer', 'Talla Única', 15.00, 50, 'CA003'),
('P0021', 'Camiseta Mujer', 'M', 15.50, 100, 'CA003'),
('P0022', 'Pantalón Mujer', 'L', 25.00, 50, 'CA003'),
('P0023', 'Chaqueta Hombre', 'S', 35.00, 30, 'CA002'),
('P0024', 'Falda Niña', 'M', 20.00, 70, 'CA004'),
('P0025', 'Vestido Niña', 'L', 40.00, 40, 'CA004'),
('P0026', 'Camiseta Bebé', 'S', 10.00, 80, 'CA004'),
('P0027', 'Pantalón Bebé', 'M', 15.00, 60, 'CA004'),
('P0028', 'Abrigo Bebé', 'L', 30.00, 20, 'CA004'),
('P0029', 'Guantes Hombre', 'Talla Única', 8.00, 120, 'CA002'),
('P0030', 'Bufanda Mujer', 'Talla Única', 7.50, 150, 'CA003');


INSERT INTO TDetalle (NroBoleta, CodProducto, Cantidad, PrecioUnitario) VALUES
(1, 'P0001', 2, 15.50),
(1, 'P0002', 1, 25.00),
(2, 'P0003', 3, 35.00),
(2, 'P0004', 2, 20.00),
(3, 'P0005', 1, 40.00),
(3, 'P0006', 2, 10.00),
(4, 'P0007', 1, 15.00),
(4, 'P0008', 1, 30.00),
(5, 'P0009', 4, 5.00),
(5, 'P0010', 2, 7.50),
(6, 'P0011', 3, 8.00),
(6, 'P0012', 5, 3.00),
(7, 'P0013', 1, 50.00),
(7, 'P0014', 2, 18.00),
(8, 'P0015', 3, 12.00),
(8, 'P0016', 1, 10.00),
(9, 'P0017', 1, 12.50),
(9, 'P0018', 2, 22.00),
(10, 'P0019', 1, 45.00),
(10, 'P0020', 2, 15.00),
(11, 'P0021', 1, 15.50),
(11, 'P0022', 1, 25.00),
(12, 'P0023', 1, 35.00),
(12, 'P0024', 2, 20.00),
(13, 'P0025', 1, 40.00),
(13, 'P0026', 2, 10.00),
(14, 'P0027', 1, 15.00),
(14, 'P0028', 1, 30.00),
(15, 'P0029', 3, 8.00),
(15, 'P0030', 2, 7.50),
(16, 'P0001', 2, 15.50),
(16, 'P0002', 1, 25.00),
(17, 'P0003', 3, 35.00),
(17, 'P0004', 2, 20.00),
(18, 'P0005', 1, 40.00),
(18, 'P0006', 2, 10.00),
(19, 'P0007', 1, 15.00),
(19, 'P0008', 1, 30.00),
(20, 'P0009', 4, 5.00),
(20, 'P0010', 2, 7.50),
(21, 'P0011', 3, 8.00),
(21, 'P0012', 5, 3.00),
(22, 'P0013', 1, 50.00),
(22, 'P0014', 2, 18.00),
(23, 'P0015', 3, 12.00),
(23, 'P0016', 1, 10.00),
(24, 'P0017', 1, 12.50),
(24, 'P0018', 2, 22.00),
(25, 'P0019', 1, 45.00),
(25, 'P0020', 2, 15.00),
(26, 'P0021', 1, 15.50),
(26, 'P0022', 1, 25.00),
(27, 'P0023', 1, 35.00),
(27, 'P0024', 2, 20.00),
(28, 'P0025', 1, 40.00),
(28, 'P0026', 2, 10.00),
(29, 'P0027', 1, 15.00),
(29, 'P0028', 1, 30.00),
(30, 'P0029', 3, 8.00),
(30, 'P0030', 2, 7.50);


SELECT * FROM TBoleta
SELECT * FROM TCategoria
SELECT * FROM TCliente
SELECT * FROM TProducto
SELECT * FROM TDetalle
SELECT * FROM TVendedor