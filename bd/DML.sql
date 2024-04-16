use [proyecto_fisica]
go
begin try
begin transaction
	--================================================================== Típos de unidades de medida
	insert into tipo_medida (nombre) values ('masa');
	insert into tipo_medida (nombre) values ('longitud');
	insert into tipo_medida (nombre) values ('tiempo');
	insert into tipo_medida (nombre) values ('volumen');
	insert into tipo_medida (nombre) values ('temperatura');
	insert into tipo_medida (nombre) values ('velocidad');

	--================================================================== Medidas
	-- Unidades de medida para masa
	insert into medida (id_tipo_medida, nombre) values (1, 'kilogramo');
	insert into medida (id_tipo_medida, nombre) values (1, 'gramo');
	insert into medida (id_tipo_medida, nombre) values (1, 'tonelada');
	insert into medida (id_tipo_medida, nombre) values (1, 'libra');
	insert into medida (id_tipo_medida, nombre) values (1, 'onza');
	insert into medida (id_tipo_medida, nombre) values (1, 'miligramo');
	insert into medida (id_tipo_medida, nombre) values (1, 'arroba');

	-- unidades de medida para longitud
	insert into medida (id_tipo_medida, nombre) values (2, 'metro');
	insert into medida (id_tipo_medida, nombre) values (2, 'centímetro');
	insert into medida (id_tipo_medida, nombre) values (2, 'milímetro');
	insert into medida (id_tipo_medida, nombre) values (2, 'kilómetro');
	insert into medida (id_tipo_medida, nombre) values (2, 'milla');
	insert into medida (id_tipo_medida, nombre) values (2, 'yarda');
	insert into medida (id_tipo_medida, nombre) values (2, 'pie');
	insert into medida (id_tipo_medida, nombre) values (2, 'pulgada');

	-- Unidades de medida para tiempo
	insert into medida (id_tipo_medida, nombre) values (3, 'segundo');
	insert into medida (id_tipo_medida, nombre) values (3, 'minuto');
	insert into medida (id_tipo_medida, nombre) values (3, 'hora');
	insert into medida (id_tipo_medida, nombre) values (3, 'día');
	insert into medida (id_tipo_medida, nombre) values (3, 'semana');
	insert into medida (id_tipo_medida, nombre) values (3, 'mes');
	insert into medida (id_tipo_medida, nombre) values (3, 'año');

	-- Insertando medidas de volumen en la tabla medida
	insert into medida (id_tipo_medida, nombre) values (4, 'litro');
	insert into medida (id_tipo_medida, nombre) values (4, 'mililitro');
	insert into medida (id_tipo_medida, nombre) values (4, 'centímetro cúbico');
	insert into medida (id_tipo_medida, nombre) values (4, 'galón');
	insert into medida (id_tipo_medida, nombre) values (4, 'pulgada cúbica');
	insert into medida (id_tipo_medida, nombre) values (4, 'pie cúbico');

	-- Unidades de medida para temperatura
	insert into medida (id_tipo_medida, nombre) values (5, 'celsius');
	insert into medida (id_tipo_medida, nombre) values (5, 'fahrenheit');
	insert into medida (id_tipo_medida, nombre) values (5, 'kelvin');

	-- Unidades de medida para velocidad
	insert into medida (id_tipo_medida, nombre) values (6, 'metros por segundo');
	insert into medida (id_tipo_medida, nombre) values (6, 'kilómetros por hora');
	insert into medida (id_tipo_medida, nombre) values (6, 'millas por hora');
	insert into medida (id_tipo_medida, nombre) values (6, 'pies por segundo');
	insert into medida (id_tipo_medida, nombre) values (6, 'pies por minuto');
	insert into medida (id_tipo_medida, nombre) values (6, 'pulgadas por segundo');
	insert into medida (id_tipo_medida, nombre) values (6, 'pulgadas por minuto');

	-- Equivalencias
	--================================================================== Masa
	-- kilogramo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (1, 2, 1000); -- 1 kilogramo = 1000 gramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (1, 3, 0.001); -- 1 kilogramo = 0.001 toneladas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (1, 4, 2.20462); -- 1 kilogramo = 2.20462 libras
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (1, 5, 35.274); -- 1 kilogramo = 35.274 onzas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (1, 6, 1e6); -- 1 kilogramo = 1e6 miligramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (1, 7, 0.015748); -- 1 kilogramo = 0.015748 arrobas

	-- gramo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (2, 1, 0.001); -- 1 gramo = 0.001 kilogramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (2, 3, 1e-6); -- 1 gramo = 1e-6 toneladas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (2, 4, 0.00220462); -- 1 gramo = 0.00220462 libras
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (2, 5, 0.035274); -- 1 gramo = 0.035274 onzas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (2, 6, 1000); -- 1 gramo = 1000 miligramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (2, 7, 0.000015748); -- 1 gramo = 0.000015748 arrobas

	-- tonelada
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (3, 1, 1000); -- 1 tonelada = 1000 kilogramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (3, 2, 1e6); -- 1 tonelada = 1e6 gramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (3, 4, 2204.62); -- 1 tonelada = 2204.62 libras
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (3, 5, 35274); -- 1 tonelada = 35274 onzas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (3, 6, 1e9); -- 1 tonelada = 1e9 miligramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (3, 7, 15.748); -- 1 tonelada = 15.748 arrobas

	-- libra
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (4, 1, 0.453592); -- 1 libra = 0.453592 kilogramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (4, 2, 453.592); -- 1 libra = 453.592 gramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (4, 3, 0.000453592); -- 1 libra = 0.000453592 toneladas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (4, 5, 16); -- 1 libra = 16 onzas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (4, 6, 453592); -- 1 libra = 453592 miligramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (4, 7, 7.14286); -- 1 libra = 7.14286 arrobas

	-- onza
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (5, 1, 0.0283495); -- 1 onza = 0.0283495 kilogramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (5, 2, 28.3495); -- 1 onza = 28.3495 gramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (5, 3, 2.83495e-5); -- 1 onza = 2.83495e-5 toneladas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (5, 4, 0.0625); -- 1 onza = 0.0625 libras
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (5, 6, 28349.5); -- 1 onza = 28349.5 miligramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (5, 7, 444.444); -- 1 onza = 444.444 arrobas

	-- miligramo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (6, 1, 1e-6); -- 1 miligramo = 1e-6 kilogramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (6, 2, 0.001); -- 1 miligramo = 0.001 gramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (6, 3, 1e-9); -- 1 miligramo = 1e-9 toneladas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (6, 4, 2.20462e-6); -- 1 miligramo = 2.20462e-6 libras
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (6, 5, 3.5274e-5); -- 1 miligramo = 3.5274e-5 onzas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (6, 7, 1.5747e-8); -- 1 miligramo = 1.5747e-8 arrobas

	-- arroba
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (7, 1, 63.5029); -- 1 arroba = 63.5029 kilogramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (7, 2, 63502.9); -- 1 arroba = 63502.9 gramos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (7, 3, 0.0635029); -- 1 arroba = 0.0635029 toneladas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (7, 4, 140.014); -- 1 arroba = 140.014 libras
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (7, 5, 2240.23); -- 1 arroba = 2240.23 onzas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (7, 6, 63502900); -- 1 arroba = 63502900 miligramos

	--==================================================================  Longitud
	-- Metro
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (8, 9, 100); -- 1 metro = 100 centímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (8, 10, 1000); -- 1 metro = 1000 milímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (8, 11, 0.001); -- 1 metro = 0.001 kilómetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (8, 12, 0.000621371); -- 1 metro = 0.000621371 millas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (8, 13, 1.09361); -- 1 metro = 1.09361 yardas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (8, 14, 3.28084); -- 1 metro = 3.28084 pies
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (8, 15, 39.3701); -- 1 metro = 39.3701 pulgadas

	-- centímetro
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (9, 8, 0.01); -- 1 centímetro = 0.01 metros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (9, 10, 10); -- 1 centímetro = 10 milímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (9, 11, 0.00001); -- 1 centímetro = 0.00001 kilómetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (9, 12, 6.21371e-6); -- 1 centímetro = 6.21371e-6 millas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (9, 13, 0.0109361); -- 1 centímetro = 0.0109361 yardas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (9, 14, 0.0328084); -- 1 centímetro = 0.0328084 pies
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (9, 15, 0.393701); -- 1 centímetro = 0.393701 pulgadas

	-- milímetro
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (10, 8, 0.001); -- 1 milímetro = 0.001 metros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (10, 9, 0.1); -- 1 milímetro = 0.1 centímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (10, 11, 1e-6); -- 1 milímetro = 1e-6 kilómetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (10, 12, 6.21371e-7); -- 1 milímetro = 6.21371e-7 millas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (10, 13, 0.00109361); -- 1 milímetro = 0.00109361 yardas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (10, 14, 0.00328084); -- 1 milímetro = 0.00328084 pies
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (10, 15, 0.0393701); -- 1 milímetro = 0.0393701 pulgadas

	-- kilómetro
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (11, 8, 1000); -- 1 kilómetro = 1000 metros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (11, 9, 100000); -- 1 kilómetro = 100000 centímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (11, 10, 1e6); -- 1 kilómetro = 1e6 milímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (11, 12, 0.621371); -- 1 kilómetro = 0.621371 millas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (11, 13, 1093.61); -- 1 kilómetro = 1093.61 yardas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (11, 14, 3280.84); -- 1 kilómetro = 3280.84 pies
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (11, 15, 39370.1); -- 1 kilómetro = 39370.1 pulgadas

	-- milla
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (12, 8, 1609.34); -- 1 milla = 1609.34 metros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (12, 9, 160934); -- 1 milla = 160934 centímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (12, 10, 1.60934e6); -- 1 milla = 1.60934e6 milímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (12, 11, 1.60934); -- 1 milla = 1.60934 kilómetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (12, 13, 1760); -- 1 milla = 1760 yardas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (12, 14, 5280); -- 1 milla = 5280 pies
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (12, 15, 63360); -- 1 milla = 63360 pulgadas

	-- yarda
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (13, 8, 0.9144); -- 1 yarda = 0.9144 metros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (13, 9, 91.44); -- 1 yarda = 91.44 centímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (13, 10, 914.4); -- 1 yarda = 914.4 milímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (13, 11, 0.0009144); -- 1 yarda = 0.0009144 kilómetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (13, 12, 0.000568182); -- 1 yarda = 0.000568182 millas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (13, 14, 3); -- 1 yarda = 3 pies
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (13, 15, 36); -- 1 yarda = 36 pulgadas

	-- pie
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (14, 8, 0.3048); -- 1 pie = 0.3048 metros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (14, 9, 30.48); -- 1 pie = 30.48 centímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (14, 10, 304.8); -- 1 pie = 304.8 milímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (14, 11, 0.0003048); -- 1 pie = 0.0003048 kilómetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (14, 12, 0.000189394); -- 1 pie = 0.000189394 millas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (14, 13, 0.333333); -- 1 pie = 0.333333 yardas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (14, 15, 12); -- 1 pie = 12 pulgadas

	-- pulgada
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (15, 8, 0.0254); -- 1 pulgada = 0.0254 metros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (15, 9, 2.54); -- 1 pulgada = 2.54 centímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (15, 10, 25.4); -- 1 pulgada = 25.4 milímetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (15, 11, 2.54e-5); -- 1 pulgada = 2.54e-5 kilómetros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (15, 12, 1.57828e-5); -- 1 pulgada = 1.57828e-5 millas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (15, 13, 0.0277778); -- 1 pulgada = 0.0277778 yardas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (15, 14, 0.0833333); -- 1 pulgada = 0.0833333 pies

	--================================================================== Tiempo
	-- segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (16, 17, 0.0166667); -- 1 segundo = 0.0166667 minutos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (16, 18, 0.000277778); -- 1 segundo = 0.000277778 horas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (16, 19, 1.15741e-5); -- 1 segundo = 1.15741e-5 días
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (16, 20, 1.65344e-6); -- 1 segundo = 1.65344e-6 semanas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (16, 21, 3.80265e-7); -- 1 segundo = 3.80265e-7 meses
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (16, 22, 3.17098e-8); -- 1 segundo = 3.17098e-8 años

	-- minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (17, 16, 60); -- 1 minuto = 60 segundos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (17, 18, 0.0166667); -- 1 minuto = 0.0166667 horas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (17, 19, 0.000694444); -- 1 minuto = 0.000694444 días
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (17, 20, 9.9206e-5); -- 1 minuto = 9.9206e-5 semanas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (17, 21, 2.28311e-5); -- 1 minuto = 2.28311e-5 meses
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (17, 22, 1.90259e-6); -- 1 minuto = 1.90259e-6 años

	-- hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (18, 16, 3600); -- 1 hora = 3600 segundos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (18, 17, 60); -- 1 hora = 60 minutos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (18, 19, 0.0416667); -- 1 hora = 0.0416667 días
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (18, 20, 0.00595238); -- 1 hora = 0.00595238 semanas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (18, 21, 0.00136986); -- 1 hora = 0.00136986 meses
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (18, 22, 0.000114155); -- 1 hora = 0.000114155 años

	-- día
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (19, 16, 86400); -- 1 día = 86400 segundos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (19, 17, 1440); -- 1 día = 1440 minutos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (19, 18, 24); -- 1 día = 24 horas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (19, 20, 0.142857); -- 1 día = 0.142857 semanas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (19, 21, 0.0328549); -- 1 día = 0.0328549 meses
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (19, 22, 0.00273791); -- 1 día = 0.00273791 años

	-- semana
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (20, 16, 604800); -- 1 semana = 604800 segundos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (20, 17, 10080); -- 1 semana = 10080 minutos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (20, 18, 168); -- 1 semana = 168 horas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (20, 19, 7); -- 1 semana = 7 días
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (20, 21, 0.230137); -- 1 semana = 0.230137 meses
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (20, 22, 0.0191781); -- 1 semana = 0.0191781 años

	-- mes
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (21, 16, 2.62974e6); -- 1 mes = 2.62974e6 segundos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (21, 17, 43829.1); -- 1 mes = 43829.1 minutos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (21, 18, 730.484); -- 1 mes = 730.484 horas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (21, 19, 30.4369); -- 1 mes = 30.4369 días
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (21, 20, 4.34524); -- 1 mes = 4.34524 semanas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (21, 22, 0.0833333); -- 1 mes = 0.0833333 años

	-- año
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (22, 16, 3.15576e7); -- 1 año = 3.15576e7 segundos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (22, 17, 5.2596e5); -- 1 año = 5.2596e5 minutos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (22, 18, 8760); -- 1 año = 8760 horas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (22, 19, 365); -- 1 año = 365 días
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (22, 20, 52.1429); -- 1 año = 52.1429 semanas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (22, 21, 12); -- 1 año = 12 meses

	--==================================================================  Volumen
	-- litro
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (23, 24, 1000); -- 1 litro = 1000 mililitros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (23, 25, 1000); -- 1 litro = 1000 centímetros cúbicos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (23, 26, 0.264172); -- 1 litro = 0.264172 galones
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (23, 27, 61.0237); -- 1 litro = 61.0237 pulgadas cúbicas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (23, 28, 0.0353147); -- 1 litro = 0.0353147 pies cúbicos

	-- mililitro
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (24, 23, 0.001); -- 1 mililitro = 0.001 litros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (24, 25, 1); -- 1 mililitro = 1 centímetro cúbico
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (24, 26, 2.64172e-4); -- 1 mililitro = 2.64172e-4 galones
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (24, 27, 0.0610237); -- 1 mililitro = 0.0610237 pulgadas cúbicas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (24, 28, 3.53147e-5); -- 1 mililitro = 3.53147e-5 pies cúbicos

	-- centímetro cúbico
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (25, 23, 0.001); -- 1 centímetro cúbico = 0.001 litros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (25, 24, 0.001); -- 1 centímetro cúbico = 0.001 mililitros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (25, 26, 0.000264172); -- 1 centímetro cúbico = 0.000264172 galones
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (25, 27, 0.0610237); -- 1 centímetro cúbico = 0.0610237 pulgadas cúbicas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (25, 28, 3.53147e-5); -- 1 centímetro cúbico = 3.53147e-5 pies cúbicos

	-- galón
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (26, 23, 3.78541); -- 1 galón = 3.78541 litros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (26, 24, 3785.41); -- 1 galón = 3785.41 mililitros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (26, 25, 3785.41); -- 1 galón = 3785.41 centímetros cúbicos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (26, 27, 231); -- 1 galón = 231 pulgadas cúbicas
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (26, 28, 0.133681); -- 1 galón = 0.133681 pies cúbicos

	-- pulgada cúbica
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (27, 23, 0.0163871); -- 1 pulgada cúbica = 0.0163871 litros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (27, 24, 16.3871); -- 1 pulgada cúbica = 16.3871 mililitros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (27, 25, 16.3871); -- 1 pulgada cúbica = 16.3871 centímetros cúbicos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (27, 26, 0.004329); -- 1 pulgada cúbica = 0.004329 galones
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (27, 28, 0.000578704); -- 1 pulgada cúbica = 0.000578704 pies cúbicos

	-- pie cúbico
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (28, 23, 28.3168); -- 1 pie cúbico = 28.3168 litros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (28, 24, 28316.8); -- 1 pie cúbico = 28316.8 mililitros
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (28, 25, 28316.8); -- 1 pie cúbico = 28316.8 centímetros cúbicos
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (28, 26, 7.48052); -- 1 pie cúbico = 7.48052 galones
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (28, 27, 1728); -- 1 pie cúbico = 1728 pulgadas cúbicas

	--================================================================== Temperatura
	-- celsius
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (29, 30, 33.8); -- 1 celsius = 33.8 fahrenheit
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (29, 31, 274.15); -- 1 celsius = 274.15 kelvin

	-- fahrenheit
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (30, 29, -17.2222); -- 1 fahrenheit = -17.2222 celsius
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (30, 31, 255.928); -- 1 fahrenheit = 255.928 kelvin

	-- kelvin
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (31, 29, -272.15); -- 1 kelvin = -272.15 celsius
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (31, 30, -457.87); -- 1 kelvin = -457.87 fahrenheit


	--================================================================== Velocidad
	-- metros por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (32, 33, 3.6); -- 1 metro por segundo = 3.6 kilómetros por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (32, 34, 2.23694); -- 1 metro por segundo = 2.23694 millas por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (32, 35, 3.28084); -- 1 metro por segundo = 3.28084 pies por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (32, 36, 196.85); -- 1 metro por segundo = 196.85 pies por minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (32, 37, 39.3701); -- 1 metro por segundo = 39.3701 pulgadas por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (32, 38, 2362.2); -- 1 metro por segundo = 2362.2 pulgadas por minuto

	-- kilómetros por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (33, 32, 0.277778); -- 1 kilómetro por hora = 0.277778 metros por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (33, 34, 0.621371); -- 1 kilómetro por hora = 0.621371 millas por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (33, 35, 0.911344); -- 1 kilómetro por hora = 0.911344 pies por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (33, 36, 54.6807); -- 1 kilómetro por hora = 54.6807 pies por minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (33, 37, 19.685); -- 1 kilómetro por hora = 19.685 pulgadas por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (33, 38, 1181.1); -- 1 kilómetro por hora = 1181.1 pulgadas por minuto

	-- millas por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (34, 32, 0.44704); -- 1 milla por hora = 0.44704 metros por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (34, 33, 1.60934); -- 1 milla por hora = 1.60934 kilómetros por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (34, 35, 1.46667); -- 1 milla por hora = 1.46667 pies por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (34, 36, 88); -- 1 milla por hora = 88 pies por minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (34, 37, 17.6); -- 1 milla por hora = 17.6 pulgadas por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (34, 38, 1056); -- 1 milla por hora = 1056 pulgadas por minuto

	-- pies por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (35, 32, 0.3048); -- 1 pie por segundo = 0.3048 metros por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (35, 33, 1.09728); -- 1 pie por segundo = 1.09728 kilómetros por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (35, 34, 0.681818); -- 1 pie por segundo = 0.681818 millas por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (35, 36, 60); -- 1 pie por segundo = 60 pies por minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (35, 37, 12); -- 1 pie por segundo = 12 pulgadas por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (35, 38, 720); -- 1 pie por segundo = 720 pulgadas por minuto

	-- pies por minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (36, 32, 0.00508); -- 1 pie por minuto = 0.00508 metros por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (36, 33, 0.018288); -- 1 pie por minuto = 0.018288 kilómetros por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (36, 34, 0.0113636); -- 1 pie por minuto = 0.0113636 millas por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (36, 35, 0.0166667); -- 1 pie por minuto = 0.0166667 pies por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (36, 37, 0.2); -- 1 pie por minuto = 0.2 pulgadas por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (36, 38, 12); -- 1 pie por minuto = 12 pulgadas por minuto

	-- pulgadas por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (37, 32, 0.0254); -- 1 pulgada por segundo = 0.0254 metros por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (37, 33, 0.09144); -- 1 pulgada por segundo = 0.09144 kilómetros por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (37, 34, 0.0568182); -- 1 pulgada por segundo = 0.0568182 millas por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (37, 35, 0.0833333); -- 1 pulgada por segundo = 0.0833333 pies por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (37, 36, 5); -- 1 pulgada por segundo = 5 pies por minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (37, 38, 60); -- 1 pulgada por segundo = 60 pulgadas por minuto

	-- pulgadas por minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (38, 32, 0.000423333); -- 1 pulgada por minuto = 0.000423333 metros por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (38, 33, 0.001524); -- 1 pulgada por minuto = 0.001524 kilómetros por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (38, 34, 0.00094697); -- 1 pulgada por minuto = 0.00094697 millas por hora
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (38, 35, 0.00138889); -- 1 pulgada por minuto = 0.00138889 pies por segundo
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (38, 36, 0.0833333); -- 1 pulgada por minuto = 0.0833333 pies por minuto
	insert into equivalencia_medida (id_medida_origen, id_medida_destino, valor) values (38, 37, 0.0166667); -- 1 pulgada por minuto = 0.0166667 pulgadas por segundo

commit transaction
end try
begin catch
   if @@trancount > 0
       rollback transaction

   select error_line() [error_line],
          error_message() [error_message],
          error_number() [error_number],
          error_procedure() [error_procedure],
          error_severity() [error_severity],
          error_state() [error_state]
end catch
