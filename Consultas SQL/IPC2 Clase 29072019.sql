-- Agrupamientos y Funciones de Agregación

SELECT p.nombre AS producto, p.cantidad*p.precio AS total
FROM producto AS p
ORDER BY total ASC

-- Suma la cantidad de productos por categoria, usando agrupamiento
SELECT c.nombre categoria, SUM(p.cantidad) AS total
FROM cat_producto AS c
INNER JOIN producto p ON p.cod_cat_producto = c.cod_cat_producto
GROUP BY c.nombre

-- Suma todos los productos
SELECT SUM(p.cantidad) AS total
FROM producto p

-- AVG todos los productos
SELECT AVG(p.cantidad) AS total
FROM producto p

-- COUNT todos los productos
SELECT COUNT(p.cantidad) AS total
FROM producto p

-- Promedio utilizando SUM y COUNT
SELECT SUM(p.cantidad)/COUNT(p.cantidad) AS total
FROM producto p

-- Funciones del sistema.
SELECT CURRENT_TIMESTAMP

-- Cantidad de productos que ha entregado un proveedor.
SELECT pr.nombre proveedor, SUM(p.cantidad) total
FROM producto p 
INNER JOIN proveedor pr ON p.cod_proveedor = pr.cod_proveedor
GROUP BY pr.nombre

SELECT pr.nombre proveedor, AVG(p.cantidad) total
FROM producto p 
INNER JOIN proveedor pr ON p.cod_proveedor = pr.cod_proveedor
GROUP BY pr.nombre

-- Agrupamientos involucrando varias tablas.
SELECT pr.nombre proveedor, c.nombre categoria, SUM(p.cantidad) total
FROM producto p 
INNER JOIN proveedor pr ON p.cod_proveedor = pr.cod_proveedor
INNER JOIN cat_producto c ON c.cod_cat_producto = p.cod_cat_producto
GROUP BY pr.nombre, c.nombre
ORDER BY proveedor