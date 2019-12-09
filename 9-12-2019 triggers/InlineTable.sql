CREATE FUNCTION fnGETEmployee(@GENDER nvarchar(50))
RETURNS TABLE
RETURN (SELECT ID,NAME,SALARY,GENDER,DEPTID
FROM EMP
WHERE GENDER = @GENDER)

/* for inline table returns table and in that we do not use BEGIN and END blocks */

SELECT * FROM fnGETEmployee('MALE')		/*to call the function like this */
SELECT * FROM fnGETEmployee('FEMALE')
/*inline table valued functions can be used to achieve the functionality of parameterized views */

SELECT NAME,GENDER,DEPTNAME
FROM fnGETEmployee('FEMALE') E
JOIN DEPT D ON D.DEPTID = E.DEPTID
/*HERE we retrieve data based upon gender(female) */