DROP TABLE IF EXISTS #RELATORIOS
CREATE TABLE #RELATORIOS(
    ANO INT,
    QTD INT
)

USE FUNCIONARIOS
DECLARE @ANO_MIN INT = (SELECT ANO_MIN = MIN(YEAR(DT_ADMISSAO))
						FROM FUNCIONARIOS)
DECLARE @ANO_MAX INT = (SELECT ANO_MAX = MAX(YEAR(DT_ADMISSAO))
						FROM FUNCIONARIOS)

WHILE @ANO_MIN <= @ANO_MAX
BEGIN 
	INSERT INTO #RELATORIOS VALUES
	(@ANO_MIN, (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) = @ANO_MIN))
	SET @ANO_MIN = @ANO_MIN + 1
END


SELECT * FROM #RELATORIOS WHERE QTD = 0
SELECT * FROM FUNCIONARIOS



--COM MESES
USE FUNCIONARIOS

DROP TABLE IF EXISTS #RELATORIOS
CREATE TABLE #RELATORIOS(
    ANO INT,
	MES INT,
    QTD INT
)

DECLARE @ANO_MIN INT = (SELECT ANO_MIN = MIN(YEAR(DT_ADMISSAO))
						FROM FUNCIONARIOS)
DECLARE @ANO_MAX INT = (SELECT ANO_MAX = MAX(YEAR(DT_ADMISSAO))
						FROM FUNCIONARIOS)
DECLARE @MES INT = 1

WHILE @ANO_MIN <= @ANO_MAX
BEGIN 
	WHILE @MES <= 12
	BEGIN
		INSERT INTO #RELATORIOS VALUES
		(@ANO_MIN, @MES, (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE MONTH(DT_ADMISSAO) = @MES AND YEAR(DT_ADMISSAO) = @ANO_MIN))
		SET @MES = @MES + 1		
	END
	SET @MES = 1
	SET @ANO_MIN = @ANO_MIN + 1
END


SELECT * FROM #RELATORIOS
SELECT ANO FROM #RELATORIOS WHERE QTD = 0
GROUP BY ANO


--TESTE
SELECT MONTH(DT_ADMISSAO) FROM FUNCIONARIOS
SELECT * FROM FUNCIONARIOS


DECLARE @TESTE INT = 1
CREATE TABLE 

WHILE @TESTE <= 12
BEGIN
	
END


--SALARIO ACUMULADO

DROP TABLE IF EXISTS #SL_ACUMULADO
CREATE TABLE #SL_ACUMULADO(
	NOME VARCHAR(30),

)

(SELECT NM_FUNCIONARIO, DT_ADMISSAO, TEMPO_EMPRESA = (DATEDIFF(YY, DT_ADMISSAO, GETDATE())), VL_SALARIO
FROM FUNCIONARIOS) AS C


