INSERT INTO contribuyentes_estatus
select * from
(
select 1 id, 'Activo' nombre 
UNION 
select 2, 'Inactivo'
) a where not exists (select * from contribuyentes_estatus);

GO

INSERT INTO contribuyentes_tipos
select * from
(
select 1 id, 'Persona juridica' nombre 
UNION 
select 2, 'Persona física'
) a where not exists (select * from contribuyentes_tipos);

