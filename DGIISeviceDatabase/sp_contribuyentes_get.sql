CREATE PROCEDURE [dbo].[sp_contribuyentes_get]
AS
SELECT c.id, 
rnc as rncCedula, 
UPPER(c.nombre) as nombre, 
UPPER(t.nombre) as tipo, 
LOWER(e.nombre) as estatus
from contribuyentes c 
inner join contribuyentes_tipos t on t.id = c.tipo
inner join contribuyentes_estatus e on e.id = c.estatus
