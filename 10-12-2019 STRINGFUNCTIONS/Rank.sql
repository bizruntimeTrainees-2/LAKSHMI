SELECT * FROM EMP;

INSERT INTO EMP VALUES(7,'SHYAM',7000,'MALE',2)
INSERT INTO EMP VALUES(8,'SITA',6000,'FEMALE',1)

SELECT NAME,GENDER,SALARY,
RANK() OVER(ORDER BY SALARY DESC) AS [RANK],
DENSE_RANK() OVER (ORDER BY SALARY DESC) AS DENSE_RANK
FROM EMP;	/*RANK() function skips rank if two values are same , but dense will not do that */

SELECT NAME,GENDER,SALARY,
RANK() OVER(PARTITION BY GENDER ORDER BY SALARY DESC) AS [RANK],
DENSE_RANK() OVER (PARTITION BY GENDER ORDER BY SALARY DESC) AS DENSE_RANK
FROM EMP; /*When we are applying partition then it will divide into male and female and again rank will start seperately for male and female */

SELECT * FROM EMP ORDER BY SALARY DESC;

