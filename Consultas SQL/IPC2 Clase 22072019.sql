-- INSERCIÓN SQL

INSERT INTO public.cliente(nombre,direccion, nit) VALUES('Luis Marcial', 'Barrio El Cangrejo', '777774-4');
-- SELECCIÓN SQL

SELECT * FROM public.cliente ORDER BY nombre ASC

-- ACTUALIZACIÓN SQL

UPDATE public.cliente SET nombre='Juan Pan' WHERE cod_cliente = 1

UPDATE public.cliente SET telefono='8489392', fec_nacimiento='1990-09-16', dpi='2486632911601' WHERE cod_cliente = 4
UPDATE public.cliente SET telefono='88284', fec_nacimiento='1998-10-31', dpi='8483928384845' WHERE cod_cliente = 5

-- ELIMINACIÓN SQL

DELETE FROM public.cliente WHERE nombre LIKE 'J%'
