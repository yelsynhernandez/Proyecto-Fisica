select *
from equivalencia_medida


select cast(m.id as varchar) + ', ' + m.nombre as [ID, nombre],tm.nombre
from medida m
	inner join tipo_medida tm on (m.id_tipo_medida = tm.id)
where m.id_tipo_medida = 6

select * from medida

EXEC convertir 2,1,2000