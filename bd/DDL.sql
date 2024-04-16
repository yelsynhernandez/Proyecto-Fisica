use [master];
go
if not exists(select 1
			from sys.databases
			where [name] = 'proyecto_fisica')
begin
	create database proyecto_fisica
end
go
use proyecto_fisica;
go
-- Eliminación de tablas
if object_id('equivalencia_medida') is not null drop table equivalencia_medida
if object_id('medida') is not null drop table medida
if object_id('tipo_medida') is not null drop table tipo_medida
go
-- eliminación de procedimientos almacenados
if object_id('listado_categorias','p')  is not null drop procedure listado_categorias
if object_id('listado_medidas','p')  is not null drop procedure listado_medidas
if object_id('convertir','p')  is not null drop procedure convertir
if object_id('tabla_equivalencias','V') is not null drop view tabla_equivalencias
GO
create table tipo_medida(
	id int identity(1,1) not null,
	nombre varchar(50) not null,
	constraint pk_tipo_medida
	    primary key(id)
);
go
create table medida(
    id int identity(1,1) not null,
	id_tipo_medida int not null,
	nombre varchar(50) not null,
	constraint pk_medida
        primary key(id)
);
go
create table equivalencia_medida(
	id_medida_origen int not null,
	id_medida_destino int not null,
	valor float not null
	constraint pk_equivalencias
	    primary key(id_medida_origen,id_medida_destino),
	constraint fk_medida_origen
	    foreign key(id_medida_origen) references medida(id),
	constraint fk_medida_destino
	    foreign key(id_medida_destino) references medida(id)
);
go
create procedure listado_categorias
as
begin
	select id, nombre
	from tipo_medida
end
GO
--SPs
create procedure listado_medidas(
    @tipo_medida varchar(50)
)
as
begin
	select m.id, m.nombre
	from medida m
	    inner join tipo_medida tm on (m.id_tipo_medida = tm.id)
	where tm.nombre = @tipo_medida
end
go
create procedure convertir(
	@medida_origen varchar(50),
	@medida_destino varchar(50),
	@cantidad float,
	@valor float output
)
as
begin
	if @medida_origen = @medida_destino
	begin
		raiserror ('El ID es igual', 16,1)
	end

	declare @id_medida_origen int,
	        @id_medida_destino int

	set @id_medida_origen = (select id from medida where nombre = @medida_origen)
	set @id_medida_destino = (select id from medida where nombre = @medida_destino)

	set @valor = (select @cantidad * valor 
				  from equivalencia_medida em
				      inner join medida m1 on (em.id_medida_origen = m1.id)
					  inner join medida m2 on (em.id_medida_destino = m2.id)
				  where em.id_medida_origen = @id_medida_origen 
				      and em.id_medida_destino = @id_medida_destino)

	select @valor
end
go
create view tabla_equivalencias
as
	select tm.nombre [Unidad de medida],
		   m1.nombre [Medida origen],
	       m2.nombre [Medida destino],
		   em.valor
	from equivalencia_medida em
	    inner join medida m1 on (em.id_medida_origen = m1.id)
		inner join medida m2 on (em.id_medida_destino = m2.id)
		inner join tipo_medida tm on (m1.id_tipo_medida = tm.id)
