SELECT ASCII('A'); /*65 */
SELECT ASCII('B'); /* 66 */
SELECT ASCII('D'); /*68*/
SELECT ASCII('Z') /*90*/

SELECT ASCII('a') /*97*/
SELECT ASCII('c') /*99 */
SELECT ASCII('f') /*102 */
SELECT ASCII('z') /*122 */

SELECT ASCII('ABC') /*it gives the ascii code value of first character i.e. 65*/

SELECT CHAR(65)	/*it returns A */
SELECT CHAR(97) /* it returns a */


Declare @Start int
Set @Start = 65
while(@Start <= 90)
BEGIN
	PRINT CHAR(@Start)
	SET @Start = @Start + 1
END		/*it prints all alphabets(capital letters) */

DECLARE @Start int
SET @Start = 97
while(@Start <= 122)
BEGIN
 PRINT CHAR(@Start)
 SET @Start = @Start + 1
END 

SELECT ASCII(0) /*ASCII code value of zero starts at 48 */
SELECT ASCII(1) /*ASCII code value of one is 49 */
SELECT ASCII(6) /*ASCII Code of 6 is 54 */


DECLARE @Start int
SET @Start = 48
while(@Start <= 58)
BEGIN
 PRINT CHAR(@Start)
 SET @Start = @Start + 1
END

SELECT ('         HELLO'); /* it prints HELLO but white spaces also shows */
SELECT LTRIM('    HELLO')	/*by calling LTRIM white spaces not allowed i.e LTRIM removes whitespaces */

SELECT ('HELLO    ') 
SELECT RTRIM('HELLO     ') /* RTRIM removes whitespaces on the right hand side,but we can't see that */

CREATE TABLE FAMILY1(ID int,FIRST_NAME nvarchar(50),LAST_NAME nvarchar(50),PLACE nvarchar(50))

INSERT INTO FAMILY1 VALUES(1,'NAGARAJU','AVULA','TADIPATRI')
INSERT INTO FAMILY1 VALUES(2,'SAVITHRI','AVULA','TADIPATRI')
INSERT INTO FAMILY1 VALUES(3,'LAVANYA','B.K.','TADIPATRI')
INSERT INTO FAMILY1 VALUES(4,'RAM MOHAN REDDY','B.K.','TADIPATRI')
INSERT INTO FAMILY1 VALUES(5,'LAKSHMI','AVULA','TADIPATRI')
INSERT INTO FAMILY1 VALUES(6,'NANDINI','AVULA','TADIPATRI')

SELECT * FROM FAMILY1

SELECT LTRIM(FIRST_NAME) AS FIRST_NAME,LAST_NAME,
RTRIM(LTRIM(FIRST_NAME)) +'   '+ LAST_NAME AS FULL_NAME FROM FAMILY1

SELECT LOWER(LTRIM(FIRST_NAME)) AS FIRST_NAME,LOWER(LAST_NAME),
RTRIM(LTRIM(FIRST_NAME)) +'   '+ LAST_NAME AS FULL_NAME FROM FAMILY1 
/*by using LOWER all letters will be converted to lower case */

SELECT REVERSE(LTRIM(FIRST_NAME)) AS FIRST_NAME,REVERSE(LAST_NAME),
RTRIM(LTRIM(FIRST_NAME)) +'   '+ LAST_NAME AS FULL_NAME FROM FAMILY1 /*by using REVERSE all characters reversed */


SELECT FIRST_NAME FROM FAMILY1

SELECT FIRST_NAME,LEN(FIRST_NAME) AS TOTAL_CHARACTERS FROM FAMILY1 /*IT PRINTS COUNT OF CHARACTERS OF THAT WORD */

