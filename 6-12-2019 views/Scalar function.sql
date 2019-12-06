SELECT SQUARE(5)	/* it prints square of that number */

SELECT GETDATE()	/*it prints the date and time */


CREATE FUNCTION CalculateAge(@DOB DATE)
RETURNS INT
AS BEGIN
DECLARE @AGE INT

SET @AGE = DATEDIFF(YEAR,@DOB,GETDATE())-
CASE
WHEN (MONTH(@DOB)>MONTH(GETDATE())) OR 
	 (MONTH(@DOB)=MONTH(GETDATE()) AND DAY(@DOB) > DAY(GETDATE()))
	 THEN 1
	 ELSE 0
	 END
	 RETURN @AGE
	 END


