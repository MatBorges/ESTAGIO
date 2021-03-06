USE FUNCIONARIOS

SELECT *
FROM FUNCIONARIOS
WHERE CD_DEPARTAMENTO IN (3)

SELECT *
FROM FUNCIONARIOS AS F
WHERE F.CD_BANCO IN (SELECT CD_BANCO 
					 FROM BANCOS 
					 WHERE NU_AGENCIA = '500-4')


SELECT *
FROM FUNCIONARIOS AS F
WHERE EXISTS(SELECT *
			 FROM BANCOS AS B
			 WHERE B.NU_AGENCIA = '345-1'
				AND B.CD_BANCO = F.CD_BANCO)


SELECT *
FROM BANCOS AS B
WHERE B.NU_AGENCIA = '345-1'



SELECT VL_SALARIO, COUNT(*) TOTAL
FROM FUNCIONARIOS GROUP BY VL_SALARIO

SELECT * 
FROM( SELECT VL_SALARIO
FROM FUNCIONARIOS) T
PIVOT(
COUNT(VL_SALARIO)
FOR VL_SALARIO IN (
[180.00],
[189.00],
[200.00],
[500.00],
[800.00],
[1500.00])
) AS PIVOT_TABLE;

SELECT D.NM_DEPARTAMENTO, F.VL_SALARIO FROM DEPARTAMENTOS AS D
JOIN FUNCIONARIOS AS F
ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO



--MEU
SELECT D.NM_DEPARTAMENTO, AVG(F.VL_SALARIO) AS MEDIA_SALARIO
FROM DEPARTAMENTOS AS D
JOIN FUNCIONARIOS AS F
ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO
GROUP BY D.NM_DEPARTAMENTO

SELECT *
FROM (SELECT D.NM_DEPARTAMENTO, F.VL_SALARIO
      FROM DEPARTAMENTOS AS D
      JOIN FUNCIONARIOS AS F
      ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO
	  ) AS TP
PIVOT (AVG(TP.VL_SALARIO) 
       FOR TP.NM_DEPARTAMENTO 
	   IN ([Desenvolvimento], 
	       [Editoração], 
		   [Financeiro], 
		   [Recursos Humanos])) AS PT
FOR JSON AUTO


--DIEGO SEGOVIA
SELECT *
FROM (SELECT CD_DEPARTAMENTO,VL_SALARIO
FROM FUNCIONARIOS) T
PIVOT ( AVG(VL_SALARIO)
FOR CD_DEPARTAMENTO IN ([1],[2],[3],[4])
) AS PIVOT_table;

--DIEGO TAVARES
SELECT D.NM_DEPARTAMENTO, AVG(F.VL_SALARIO) MEDIA_SALARIO
FROM FUNCIONARIOS F JOIN DEPARTAMENTOS D ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO GROUP BY D.NM_DEPARTAMENTO

SELECT * FROM
( SELECT D.NM_DEPARTAMENTO, F.VL_SALARIO
FROM FUNCIONARIOS F JOIN DEPARTAMENTOS D ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO) t
PIVOT(
AVG(t.VL_SALARIO)
FOR t.NM_DEPARTAMENTO IN ([Desenvolvimento], [Editoração], [Financeiro], [Recursos Humanos])
) AS pivot_table;


--GERAR ARQUIVOS .JSON
SELECT *
FROM FUNCIONARIOS
FOR JSON AUTO

SELECT *
FROM OPENJSON(@JS)
WITH(
	CD_FUNCIONARIO INT,
	NM_FUNCIONARIO VARCHAR(150),
	CD_DEPARTAMENTO INT,
	DT_ADMISSAO DATETIME,
	DT_NASCIMENTO DATETIME,
	VL_SALARIO MONEY
) AS F

SELECT CD_FUNCIONARIO, VL_SALARIO
FROM FUNCIONARIOS AS F
FOR JSON AUTO


--GERAR ARQUIVOS .XML
SELECT *
FROM FUNCIONARIOS
FOR XML AUTO


--COLOCA TODOS OS FUNCIONARIOS DO MESMO DEPARTAMENTO NA MESMA LINHA DA TABELA RESULTANTE
DROP TABLE IF EXISTS #X
SELECT F.CD_DEPARTAMENTO, F.NM_FUNCIONARIO
INTO #X
FROM FUNCIONARIOS F
ORDER BY CD_DEPARTAMENTO

SELECT X1.CD_DEPARTAMENTO
, FUNCS = STUFF(( SELECT CONCAT(',', X2.NM_FUNCIONARIO)
FROM #X X2
WHERE X2.CD_DEPARTAMENTO = X1.CD_DEPARTAMENTO
ORDER BY X2.NM_FUNCIONARIO
FOR XML PATH(''))
, 1, 1, '')
FROM #X X1
GROUP BY X1.CD_DEPARTAMENTO


--COM SUM
SELECT D.NM_DEPARTAMENTO,
	   QTD_SENIOR = SUM(IIF(YEAR(F.DT_ADMISSAO) < 2000, 1, 0)),
	   QTD_PLENO = SUM(IIF(YEAR(F.DT_ADMISSAO) BETWEEN 2000 AND 2014, 1, 0)),
	   QTD_JUNIOR = SUM(IIF(YEAR(F.DT_ADMISSAO) > 2014, 1, 0))
FROM FUNCIONARIOS AS F
JOIN DEPARTAMENTOS AS D
ON D.CD_DEPARTAMENTO = F.CD_DEPARTAMENTO
GROUP BY D.NM_DEPARTAMENTO

--COM SELECT ANINHADO
SELECT NM_DEPARTAMENTO,
       QTD_SENIOR = (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) < 2000 AND D.CD_DEPARTAMENTO = CD_DEPARTAMENTO),
	   QTD_PLENO = (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) BETWEEN 2000 AND 2014 AND D.CD_DEPARTAMENTO = CD_DEPARTAMENTO),
	   QTD_JUNIO = (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) > 2014 AND D.CD_DEPARTAMENTO = CD_DEPARTAMENTO)
FROM DEPARTAMENTOS AS D
ORDER BY D.NM_DEPARTAMENTO

--SEPARADO
SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) < 2000


SELECT ANO = MIN(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS


SELECT *
FROM FUNCIONARIOS
EXISTS 

DECLARE @ANO_MIN INT = 1993
SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) = @ANO_MIN