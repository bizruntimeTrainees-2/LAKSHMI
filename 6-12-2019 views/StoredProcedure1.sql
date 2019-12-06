SELECT * FROM TBLEMPLOYEE;
SELECT NAME,GENDER FROM TBLEMPLOYEE;

CREATE PROCEDURE spEMPLOYEE
AS
BEGIN
SELECT NAME,GENDER FROM TBLEMPLOYEE
END;

SELECT * FROM TBLEMPLOYEE;

CREATE PROC spEMPLOYEEGENDERANDDEPT_ID1
@GENDER NVARCHAR
AS
BEGIN
SELECT GENDER FROM TBLEMPLOYEE WHERE GENDER = @GENDER
END

 spEMPLOYEE1 'FEMALE',2;

CREATE PROC spEMPLOYEE1
@GENDER nvarchar(20),
@DEPT_ID int
AS BEGIN SELECT NAME,GENDER,DEPT_ID FROM TBLEMPLOYEE WHERE GENDER = @GENDER AND DEPT_ID = @DEPT_ID
END;

SELECT * FROM TBLEMPLOYEE;

CREATE PROC spEMPLOYEE2
@GENDER nvarchar(20),
@EmployeeCount int OUTPUT
AS 
BEGIN 
SELECT @EmployeeCount = COUNT(ID) FROM TBLEMPLOYEE WHERE GENDER = @GENDER
END;

DECLARE @TotalCount int
EXECUTE spEMPLOYEE2 'MALE',@TotalCount out  /* if u specify out keyword it will sow total count is not null */
if(@TotalCount is null)
print 'TotalCount is null';
else
print 'TotalCount is not null';


DECLARE @TotalCount int
EXECUTE spEMPLOYEE2 'MALE',@TotalCount 
PRINT  @TotalCount

DECLARE @TotalCount int
EXECUTE spEMPLOYEE2 @EmployeeCount = @TotalCount out, @GENDER = 'FEMALE'		/* It prints count of female employees */
PRINT  @TotalCount


sp_helptext spEMPLOYEE2;	/* it will show the text of the query */

sp_depends spEMPLOYEE2;		/* it shows where we getting the information(tablename) */


