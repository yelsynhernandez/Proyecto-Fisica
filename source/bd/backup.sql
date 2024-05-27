USE [proyecto_fisica]
GO
/****** Object:  StoredProcedure [dbo].[resolver_ecuacion]    Script Date: 11/05/2024 00:24:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[resolver_ecuacion](
   @id_ecuacion int,
   @valores nvarchar(max),
   @resultado float output
)
as
begin
    if object_id('tempdb..##temp') is not null drop table ##temp
	declare @id int,
	        @total_variables int,
			@valores_enviados int,
			@variables_ecuacion nvarchar(max),
			@numero nvarchar(max),
			@query nvarchar(max)
	declare @variables as table(id int, valor nvarchar(max))
	create table ##temp(resultado float)

	set @query = (select query_ecuacion from ecuacion where id = @id_ecuacion)
	
	if @query is null
	begin
		raiserror('No se ha configurado la ecuación para operar',16,1)
		return
	end

	set @id = 1

	declare valores_cursor cursor for (
		select 'cast(' + [value] + ' as float) '
		from string_split(@valores, ',')
	)
	open valores_cursor
	fetch next from valores_cursor into @numero
	while @@fetch_status = 0
	begin
		insert into @variables(id, valor) values (@id, @numero)
		fetch next from valores_cursor into @numero
		set @id = @id + 1
	end
	close valores_cursor
	deallocate valores_cursor

	--Calculamos la cantidad de variables necesarias para procesar la ecuación
	SET @variables_ecuacion = (select variables from ecuacion where id = @id_ecuacion)
	SET @total_variables = (select count(1) from string_split(@variables_ecuacion,','))
	SET @valores_enviados = (select count(1) from @variables)

	if @total_variables <> @valores_enviados
	begin
		raiserror('La cantidad de parámetros no coincide con las variables necesarias',16,1)
		return
	end

	set @query = replace(@query, 'valor1', (select valor from @variables where id = 1))
	set @query = replace(@query, 'valor2', (select valor from @variables where id = 2))
	--set @query = replace(@query, 'valor3', (select valor from @variables where id = 3))

	set @query =  'insert into ##temp(resultado) select (' + @query + ')'
	exec sp_executesql @query

	select @resultado = resultado from ##temp

	drop table ##temp
end