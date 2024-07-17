CREATE PROCEDURE [dbo].[sp_contribuyentes_ncf_get]
@id INT
AS
SELECT c.rnc AS RncCedula, 
cn.ncf,
cn.monto,
ROUND(cn.monto * 0.18, 2) AS Itebis18
FROM dbo.contribuyentes_ncfs cn
INNER JOIN dbo.contribuyentes c ON cn.contribuyente = c.id
WHERE c.id = @id