SELECT * FROM FAMILY1

SELECT LEFT('ABCDEFG',4) /*here in second parameter we wrote how many spacified characters you want 
 it returns the first 4 characters from left hand side */

 SELECT CHARINDEX('@','LAKSHMIROYAL.1997@GMAIL.COM'); /*here to find the index position of @ */

 SELECT SUBSTRING('LAKSHMI',3,7); /* second parameter is start_location, third parameter is how many you want to print 
  the output is KSHMI */

  SELECT RIGHT('LAKSHMI',3)  /* it prints 3 characters from right side */
 SELECT REPLICATE('LAKSHMI',4) /*by using REPLICATE it repeats the string what u give and in second parameter we give how many times to repeat */

 SELECT FIRST_NAME +SPACE(5)+LAST_NAME AS FULL_NAME FROM FAMILY1; /* IT WILL PRINTS THE SPACE BETWEEN FIRST_NAME AND LAST_NAME */

 SELECT LAST_NAME,PATINDEX('AVULA',LAST_NAME) AS FirstOccurence
 from FAMILY1
 WHERE PATINDEX('AVULA',LAST_NAME) > 0
 /*if the search path is not found then it will returns zero */

 SELECT LAST_NAME,REPLACE(LAST_NAME,'B.K.','B.K.R') AS CHANGELNAME FROM FAMILY1 /*here we change B.K. to B.K.R */

 SELECT FIRST_NAME,LAST_NAME ,STUFF(FIRST_NAME,2,3,'*****') AS STUFFNAME FROM FAMILY1
 /*here after the first character upto 4th letter we have to replaced with stars and remove that before characters */