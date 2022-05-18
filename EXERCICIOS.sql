USE FUNCIONARIOS

-- Selecionar todas as linhas das tabelas BANCOS, com os nomes dos bancos em ordem alfabética.
--Para os bancos com nomes repetidos, ordenar a agência em ordem crescente.
SELECT * FROM BANCOS 
ORDER BY NM_BANCO ASC

-- Selecionar os bancos que não tem nenhum funcionário vinculado
SELECT B.NM_BANCO FROM BANCOS AS B 
LEFT JOIN FUNCIONARIOS AS F 
ON B.CD_BANCO = F.CD_BANCO 
WHERE F.CD_BANCO IS NULL

--Selecionar os bancos com o numero do banco seja nulo ou o primeiro dígito número do seja igual a 1.
SELECT * FROM BANCOS 
WHERE NU_BANCO LIKE '1%' OR NU_BANCO IS NULL

--Selecionar os funcionários que ganham R$ 200,00 ou menos que nasceram depois depois de 1974
SELECT * FROM FUNCIONARIOS 
WHERE VL_SALARIO < 200.0 OR YEAR(DT_ADMISSAO) < '1974'

--Selecionar os funcionários que foram contratado no mes 2
SELECT * FROM FUNCIONARIOS 
WHERE MONTH(DT_ADMISSAO) = 2


SELECT FORMAT(DT_ADMISSAO, 'dd/MM/yyyy') from FUNCIONARIOS
SELECT * FROM FUNCIONARIOS 


SELECT CD_FUNCIONARIO, 
	NM_FUNCIONARIO, 
	DT_NASCIMENTO, 
	DATEDIFF(year, DT_NASCIMENTO, CONVERT(date, GETDATE())) AS IDADE, 
	DT_ADMISSAO, DATEDIFF(year, DT_ADMISSAO, CONVERT(date, GETDATE())) AS TEMPO_SERVICO 
FROM FUNCIONARIOS
--SOLUÇÃO RICARDO
WHERE DATEADD(YEAR, -15, GETDATE()) > DT_ADMISSAO

--CONSULTA ANINHADA
SELECT * FROM (SELECT CD_FUNCIONARIO, 
			NM_FUNCIONARIO, 
			DT_NASCIMENTO, 
			DATEDIFF(year, DT_NASCIMENTO, CONVERT(date, GETDATE())) AS IDADE, 
			DT_ADMISSAO, DATEDIFF(year, DT_ADMISSAO, CONVERT(date, GETDATE())) AS TEMPO_SERVICO 
		FROM FUNCIONARIOS) AS F
WHERE TEMPO_SERVICO < 15


SELECT GETDATE()

SELECT SYSDATETIME()
    ,SYSDATETIMEOFFSET()
    ,SYSUTCDATETIME()
    ,CURRENT_TIMESTAMP
    ,GETDATE()
    ,GETUTCDATE();

SELECT EOMONTH(GETDATE())

--TESTAR
SELECT CD_FUNCIONARIO, NM_FUNCIONARIO, DT_NASCIMENTO, DATEDIFF(yy, DT_NASCIMENTO, CONVERT(date, GETDATE())) AS IDADE, DT_ADMISSAO, DATEADD(dd, DATEDIFF(dd, DT_NASCIMENTO, CONVERT(date, GETDATE())), '1900-01-01') AS [TEMPO SERVIÇO] FROM FUNCIONARIOS;

--Selecionar funcionários que tem vinculo com banco mas não tem nenhum departamento
SELECT NM_FUNCIONARIO FROM FUNCIONARIOS AS F
WHERE F.CD_BANCO IS NOT NULL AND F.CD_DEPARTAMENTO IS NULL

--Mostrar o nome do funcionário, nome do departamento e nome do banco. Se o funcionario não estiver em nenhum banco exibir a mensagem "Conta Inexistente"
SELECT F.NM_FUNCIONARIO, D.NM_DEPARTAMENTO, ISNULL(B.NM_BANCO, 'Conta Inexistente') AS NM_BANCO FROM FUNCIONARIOS AS F 
JOIN DEPARTAMENTOS AS D 
ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO 
LEFT JOIN BANCOS AS B 
ON F.CD_BANCO = B.CD_BANCO

--MOSTRA SÓ OS FUNCIONARIOS QUE TEM ALGUM BANCO VINCULADO
SELECT F.NM_FUNCIONARIO, D.NM_DEPARTAMENTO, B.NM_BANCO FROM FUNCIONARIOS AS F 
LEFT JOIN DEPARTAMENTOS AS D 
ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO 
JOIN BANCOS AS B ON F.CD_BANCO = B.CD_BANCO

/*
Selacionar os funcionários que
tenham conta no banco do brasil e trabalhem no departamento de desenvolvimento ou
que trabalhem no departamento de recursos humanos e não tenham conta em nenhum banco,
mostrando o nome do funcionário, o departamento e o banco
*/

SELECT * FROM FUNCIONARIOS AS F
LEFT JOIN BANCOS AS B
ON B.CD_BANCO = F.CD_BANCO
JOIN DEPARTAMENTOS AS D
ON D.CD_DEPARTAMENTO = F.CD_DEPARTAMENTO
WHERE (B.NM_BANCO = 'Banco do Brasil' AND D.NM_DEPARTAMENTO = 'Desenvolvimento') OR (D.NM_DEPARTAMENTO = 'Recursos Humanos' AND F.CD_BANCO IS NULL)

/*
Selecionar os funcionários, mostrando o nome do funcionário, a data de admissão,
Salário atual, uma mensagem nas seguintes condições:
1 - Se foram admitidos antes do ano 2000. Mensagem: "Senior"
2 - Se foi admitido entre o ano 2000 e 2014. Mensagem: "Pleno"
3 - Se foi admitido depois de 2014. Mensagem: "Novato"
e uma coluna chamada "Salário Previsto"
com o aumento de 10% para os funcionários novatos com conta no bradesco da agencia 500-4
e aumento de 15% para os funcionários plenos que tiverem conta na caixa econômica Federal.
*/


SELECT F.NM_FUNCIONARIO, F.DT_ADMISSAO, F.VL_SALARIO,
CASE
	WHEN (CONVERT(date, GETDATE())) < '2000' THEN 'SÊNIOR'
	WHEN ((CONVERT(date, GETDATE())) >= '2000' AND (CONVERT(date, GETDATE())) <= '2014') THEN 'PLENO'
	WHEN (CONVERT(date, GETDATE())) > '2014' THEN 'JUNIOR'
END AS NIVEL, 
CASE
	WHEN (CONVERT(date, GETDATE())) > '2014' AND B.CD_BANCO = '2') THEN (F.VL_SALARIO + (F.VL_SALARIO * 0.1))
	WHEN (((CONVERT(date, GETDATE())) >= '2000' AND (CONVERT(date, GETDATE())) <= '2014') AND B.NM_BANCO = 'Caixa Econômica Federal') THEN F.VL_SALARIO + (F.VL_SALARIO * 0.15)
END AS SALARIO_PREVISTO
	FROM FUNCIONARIOS AS F
	JOIN BANCOS AS B
	ON B.CD_BANCO = F.CD_BANCO

--DIEGO
	SELECT F.NM_FUNCIONARIO, F.DT_ADMISSAO, F.SALARIO,
CASE
	WHEN YEAR(F.DT_ADMISSAO) < 2000 THEN 'Senior'
	WHEN YEAR(F.DT_ADMISSAO) BETWEEN 2000 AND 2014 THEN 'Pleno'
	WHEN YEAR(F.DT_ADMISSAO) > 2014 THEN 'Novato'
END AS TIPO,
CASE
	WHEN YEAR(F.DT_ADMISSAO) > 2014 AND NM_BANCO = 'Bradesco' AND NU_AGENCIA = 5004 THEN SALARIO *1.1235
	WHEN YEAR(F.DT_ADMISSAO) BETWEEN 2000 AND 2014 AND NM_BANCO = 'Caixa Econômica Federal' THEN SALARIO *1.15
END AS [Salário Previsto]
FROM FUNCIONARIOS F JOIN BANCOS B ON F.CD_BANCO = B.CD_BANCO

/*
Fazer um relatório que para cada departamento mostre o nome do departamento e a quantidade
de pessoas que foram admitidos antes do ano 2000, entre o ano 2000 e 2014 e depois de 2014.
*/


SELECT D.NM_DEPARTAMENTO,
	QTD_SENIOR = SUM(IIF(YEAR(F.DT_ADMISSAO) < 2000, 1, 0)),
	QTD_PLENO = SUM(IIF(YEAR(F.DT_ADMISSAO) BETWEEN 2000 AND 2014, 1, 0)),
	QTD_JUNIO = SUM(IIF(YEAR(F.DT_ADMISSAO) > 2014, 1, 0))
	FROM DEPARTAMENTOS AS D
	JOIN FUNCIONARIOS AS F
	ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO
	GROUP BY D.NM_DEPARTAMENTO
