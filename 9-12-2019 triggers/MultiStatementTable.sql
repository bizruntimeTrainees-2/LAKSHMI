CREATE FUNCTION fn_MSTVF_GETEMP()
RETURNS @Table Table(ID int,NAME nvarchar(50),SALARY int)
AS
BEGIN
INSERT INTO @Table
SELECT ID,NAME ,SALARY FROM EMP /*in this MSTVF we do the structure of table  */
RETURN
END

/*The multi-statement-table-valued function is very useful because you can execute 
multiple queries within the function and aggregate results into the returned table.
*/
SELECT * FROM fn_MSTVF_GETEMP();