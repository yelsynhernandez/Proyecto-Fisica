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

	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(5, 'Distancia', 'C:/img/distancia.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(5, 'Velocidad', 'C:/img/velocidad.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(5, 'Tiempo', 'C:/img/tiempo.png');
	insert into ecuacion(id_categoria_ecuacion, nombre, imagen) values(5, 'Distancia final', 'C:/img/distancia_final.png');
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