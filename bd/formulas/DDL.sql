USE proyecto_fisica;
go
--======================================ecuacions
-- Eliminación de tablas
if object_id('ecuacion') is not null drop table ecuacion
if object_id('categoria_ecuacion') is not null drop table categoria_ecuacion

-- eliminación de procedimientos almacenados
if object_id('listar_categoria_ecuacion','p') is not null drop procedure listar_categoria_ecuacion
go
create table categoria_ecuacion(
   id int not null,
   nombre varchar(50) not null,
   constraint pk_categoria_ecuacion
       primary key(id)
);
go
create table ecuacion(
	id int identity(1,1) not null,
	id_categoria_ecuacion int not null,
	nombre varchar(100) not null,
	imagen varchar(max) not null,
	constraint pk_ecuacion
	    primary key(id),
    constraint fk_ecuacion_tipo
	    foreign key(id_categoria_ecuacion) references categoria_ecuacion(id)
);
go
create procedure listar_categoria_ecuacion
as
begin
    select nombre as valor
	from categoria_ecuacion
	order by nombre
end
go
create procedure ecuaciones(
	@categoria_ecuacion varchar(50)
)
as
begin
	declare @id_categoria int

	set @id_categoria = (select id from categoria_ecuacion where nombre = @categoria_ecuacion)

    select e.nombre clave, 
	       e.imagen valor
	from ecuacion e
	    inner join categoria_ecuacion ce on (e.id_categoria_ecuacion = ce.id)
    where e.id_categoria_ecuacion = @id_categoria
end