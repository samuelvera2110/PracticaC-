-- Crear base de datos
CREATE DATABASE RecetasDB;
GO
USE RecetasDB;
GO
-- Tabla de Categorías
CREATE TABLE Categorias (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);
-- Tabla de Recetas
CREATE TABLE Recetas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Titulo VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(500) NULL,
    TiempoPreparacion INT NOT NULL,
    Dificultad VARCHAR(20) NOT NULL,
    CategoriaId INT NOT NULL,
    CONSTRAINT FK_Recetas_Categorias FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id)
);
-- Tabla de Ingredientes
CREATE TABLE Ingredientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RecetaId INT NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Cantidad DECIMAL(10,2) NOT NULL,
    Unidad VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Ingredientes_Recetas FOREIGN KEY (RecetaId) REFERENCES Recetas(Id)
);
GO

-- ===== DATOS DE PRUEBA =====

-- Categorías (5)
INSERT INTO Categorias (Nombre) VALUES
('Desayunos'), ('Sopas'), ('Platos Fuertes'), ('Postres'), ('Bebidas');
GO

-- Recetas (20)
INSERT INTO Recetas (Titulo, Descripcion, TiempoPreparacion, Dificultad, CategoriaId) VALUES
('Tortilla de patata', 'Clásica tortilla española', 30, 'Media', 1),
('Pancakes', 'Panqueques esponjosos con miel', 20, 'Facil', 1),
('Huevos rancheros', 'Huevos con salsa picante mexicana', 15, 'Facil', 1),
('Sopa de tomate', 'Sopa cremosa de tomate asado', 40, 'Facil', 2),
('Caldo de gallina', 'Caldo tradicional ecuatoriano', 90, 'Media', 2),
('Sopa de lentejas', 'Sopa nutritiva con lentejas y verduras', 50, 'Facil', 2),
('Locro de papa', 'Sopa cremosa de papa con queso', 45, 'Media', 2),
('Arroz con pollo', 'Plato completo con arroz y pollo', 60, 'Media', 3),
('Seco de carne', 'Carne guisada con arroz y menestra', 75, 'Media', 3),
('Lasaña de carne', 'Lasaña clásica con salsa boloñesa', 90, 'Dificil', 3),
('Ceviche de camarón', 'Ceviche fresco con limón y cebolla', 30, 'Media', 3),
('Pollo al horno', 'Pollo entero horneado con especias', 80, 'Media', 3),
('Tacos de carne', 'Tacos mexicanos con carne asada', 35, 'Facil', 3),
('Flan de vainilla', 'Postre cremoso con caramelo', 50, 'Media', 4),
('Brownie de chocolate', 'Brownie húmedo con nueces', 45, 'Facil', 4),
('Tres leches', 'Pastel tradicional latinoamericano', 60, 'Media', 4),
('Helado de mango', 'Helado casero de mango natural', 240, 'Facil', 4),
('Jugo de maracuyá', 'Jugo natural refrescante', 10, 'Facil', 5),
('Batido de fresa', 'Batido cremoso de fresa con leche', 10, 'Facil', 5),
('Limonada de coco', 'Limonada fusión con leche de coco', 15, 'Facil', 5);
GO

-- Ingredientes (2 por receta = 40 filas)
INSERT INTO Ingredientes (RecetaId, Nombre, Cantidad, Unidad) VALUES
(1, 'Papa', 500.00, 'gramos'), (1, 'Huevo', 6.00, 'unidades'),
(2, 'Harina', 250.00, 'gramos'), (2, 'Leche', 300.00, 'ml'),
(3, 'Huevo', 4.00, 'unidades'), (3, 'Tomate', 200.00, 'gramos'),
(4, 'Tomate', 800.00, 'gramos'), (4, 'Cebolla', 100.00, 'gramos'),
(5, 'Gallina', 1.00, 'unidades'), (5, 'Zanahoria', 150.00, 'gramos'),
(6, 'Lenteja', 300.00, 'gramos'), (6, 'Cebolla', 100.00, 'gramos'),
(7, 'Papa', 600.00, 'gramos'), (7, 'Queso', 200.00, 'gramos'),
(8, 'Arroz', 400.00, 'gramos'), (8, 'Pollo', 500.00, 'gramos'),
(9, 'Carne de res', 600.00, 'gramos'), (9, 'Maní', 100.00, 'gramos'),
(10, 'Pasta lasaña', 250.00, 'gramos'), (10, 'Carne molida', 400.00, 'gramos'),
(11, 'Camarón', 500.00, 'gramos'), (11, 'Limón', 6.00, 'unidades'),
(12, 'Pollo entero', 1.50, 'kg'), (12, 'Ajo', 20.00, 'gramos'),
(13, 'Tortilla de maíz', 8.00, 'unidades'), (13, 'Carne de res', 400.00, 'gramos'),
(14, 'Leche condensada', 1.00, 'unidades'), (14, 'Huevo', 5.00, 'unidades'),
(15, 'Chocolate', 200.00, 'gramos'), (15, 'Nueces', 100.00, 'gramos'),
(16, 'Leche evaporada', 1.00, 'unidades'), (16, 'Harina', 200.00, 'gramos'),
(17, 'Mango', 500.00, 'gramos'), (17, 'Crema de leche', 300.00, 'ml'),
(18, 'Maracuyá', 6.00, 'unidades'), (18, 'Azúcar', 100.00, 'gramos'),
(19, 'Fresa', 250.00, 'gramos'), (19, 'Leche', 300.00, 'ml'),
(20, 'Coco', 1.00, 'unidades'), (20, 'Limón', 4.00, 'unidades');
GO