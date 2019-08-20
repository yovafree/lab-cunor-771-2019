SELECT cp.nombre AS categoria_producto, p.nombre AS producto, pr.nombre AS proveedor
FROM public.cat_producto AS cp
INNER JOIN public.producto AS p ON cp.cod_cat_producto = p.cod_cat_producto
INNER JOIN public.proveedor AS pr ON p.cod_proveedor = pr.cod_proveedor