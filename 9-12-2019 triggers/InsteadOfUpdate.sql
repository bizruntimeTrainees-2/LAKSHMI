SELECT * FROM EMP
SELECT * FROM DEPT

UPDATE vwEMPDEPT set NAME = 'JOHNY' , DEPTNAME = 'IT' WHERE ID = 1
/*
View or function 'vwEMPDEPT' is not updatable because the modification affects multiple base tables.
*/

SELECT * FROM vwEMPDEPT

CREATE TRIGGER tr_vwEMPDEPT_InsteadOfUpdate
ON vwEMPDEPT
Instead of update
AS
BEGIN
	if(update(ID))
	BEGIN
	Raiserror('id cannot be changed',16,1)
	return
END
 if(update(DEPTNAME))
 BEGIN
	DECLARE @DEPTID int
	SELECT @DEPTID = DEPTID
	FROM DEPT
	JOIN INSERTED 
	ON INSERTED.DEPTNAME = DEPT.DEPTNAME
if(@DEPTID IS NULL)
BEGIN
Raiserror('Invalid Department Name',16,1)
return
END
UPDATE EMP SET DEPTID = @DEPTID
FROM INSERTED
JOIN EMP
ON EMP.ID = INSERTED.ID
END
--if employee gender is updated
if(update(GENDER))
BEGIN
UPDATE EMP SET GENDER = inserted.GENDER
FROM INSERTED
JOIN EMP
ON EMP.ID = INSERTED.ID
END
if(update(NAME))
BEGIN
UPDATE EMP SET NAME = inserted.NAME
FROM INSERTED
JOIN EMP
ON EMP.ID = INSERTED.ID
END
END

SELECT * FROM vwEMPDEPT

UPDATE vwEMPDEPT set DEPTNAME = 'IT' WHERE ID = 1 /*here we are changing the dept name of whose id is 1 */
UPDATE vwEMPDEPT set NAME = 'SHANTI', GENDER = 'FEMALE',DEPTNAME = 'PAYROLL' WHERE ID = 2
/* before we updated same statement we got error, but after triggering it will be successfully updated */