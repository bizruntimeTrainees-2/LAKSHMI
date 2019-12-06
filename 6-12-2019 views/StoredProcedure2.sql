CREATE PROC spGETTOTALCOUNT
@TotalCount int out
AS
BEGIN
SELECT @TotalCount = COUNT(ID) FROM TBLEMPLOYEE
END;

DECLARE @Total int
EXECUTE spGETTOTALCOUNT @Total out		/* prints the total count of rows */
PRINT @Total

create proc spGETTOTALCOUNT2
as
begin
return (select COUNT(ID) from TBLEMPLOYEE)
end;

DECLARE @Total int		/*here we initialise the totalcount */
EXECUTE @Total = spGETTOTALCOUNT2
PRINT @Total;			/* it prints the total count of rows */

select * from TBLEMPLOYEE;

CREATE PROC spGETEMPLOYEE3
@ID int,
@NAME NVARCHAR(30) output
as
begin
select @NAME = NAME FROM TBLEMPLOYEE WHERE @ID = ID 
END;



