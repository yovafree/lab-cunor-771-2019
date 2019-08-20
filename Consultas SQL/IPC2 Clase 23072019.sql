SELECT cp.nombre AS categoria_producto, p.nombre AS producto
FROM public.cat_producto AS cp
INNER JOIN public.producto AS p ON cp.cod_cat_producto = p.cod_cat_producto
WHERE cp.cod_cat_producto IN (1,2,3)