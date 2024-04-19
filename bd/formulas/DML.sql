use [proyecto_fisica]
go
begin try
begin transaction
	--================================================================== Categoría de fórmulas
	insert into categoria_ecuacion (id, nombre) values (1, 'Movimiento rectilíneo uniforme');
	insert into categoria_ecuacion (id, nombre) values (2, 'Movimiento rectilíneo uniformemente variado');
	insert into categoria_ecuacion (id, nombre) values (3, 'Caída libre');
	insert into categoria_ecuacion (id, nombre) values (4, 'Tiro parabólico');
	insert into categoria_ecuacion (id, nombre) values (5, 'Movimiento circular uniforme');


	--MRU
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(1, 'Distancia', 'C:/img/mru/distancia.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(1, 'Velocidad', 'C:/img/mru/velocidad.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(1, 'Tiempo', 'C:/img/mru/tiempo.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(1, 'Distancia final', 'C:/img/mrua/distancia_final.png');
	--MRUA
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(2, 'Velocidad final al cuadrado', 'C:/img/mrua/velocidad_final_cuadrado.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(2, 'Velocidad final', 'C:/img/mrua/velocidad_final.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(2, 'Distancia (Sin aceleración)', 'C:/img/mrua/distancia_sa.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(2, 'Aceleración', 'C:/img/mrua/aceleracion.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(2, 'Distancia (Con aceleración)', 'C:/img/mrua/distancia_ca.png');
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