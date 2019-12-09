CREATE TABLE EMP(ID int,NAME nvarchar(50),SALARY int,GENDER nvarchar(50),DEPTID int)

INSERT INTO EMP VALUES(1,'JOHN',5000,'MALE',3)
INSERT INTO EMP VALUES(2,'MIKE',4500,'MALE',2)
INSERT INTO EMP VALUES(3,'RIYA',6000,'FEMALE',1)
INSERT INTO EMP VALUES(4,'VICKY',3600,'MALE',3)
INSERT INTO EMP VALUES(5,'SANA',7000,'FEMALE',4)
INSERT INTO EMP VALUES(6,'RITCH',6500,'MALE',3)

CREATE TABLE DEPT(DEPTID int,DEPTNAME nvarchar(50))
INSERT INTO DEPT VALUES(1,'IT')
INSERT INTO DEPT VALUES(2,'HR')
INSERT INTO DEPT VALUES(3,'PAYROLL')
INSERT INTO DEPT VALUES(4,'MANAGER')

SELECT * FROM EMP
SELECT * FROM DEPT

CREATE VIEW vwEMPDEPT 
AS SELECT ID,NAME,GENDER,DEPTNAME
FROM EMP
JOIN DEPT
ON DEPT.DEPTID = EMP.DEPTID

SELECT * FROM vwEMPDEPT
INSERT INTO vwEMPDEPT VALUES(7,'VALLI','FEMALE','HR') /*An error will be raised showing not updatable */


CREATE TRIGGER tr_vwEMPDEPT_InsteadOfTrigger
ON vwEMPDEPT
Instead of Insert
AS
BEGIN
	SELECT * from INSERTED
	SELECT * from DELETED
END

INSERT INTO vwEMPDEPT VALUES(7,'VALLI','FEMALE','HR')

ALTER TRIGGER tr_vwEMPDEPT_InsteadOfTrigger
ON vwEMPDEPT
Instead of Insert
AS
BEGIN
	DECLARE @DEPTID int
	SELECT @DEPTID = DEPTID
	FROM DEPT
	JOIN INSERTED
	ON INSERTED.DEPTNAME = DEPT.DEPTNAME
	if(@DEPTID is null)
BEGIN
/*if you provide invalid department name, at that time we will get this error */
	Raiserror('Invalid Department Name, Statement terminated',16,1)
	/*
	We are passing 3 parameters to the Raiserror() method. The first parameter is the error message,
	the second parameter is the severity level. Severity level 16 indicates general errors that can 
	be corrected by the user. The final parameter is the state */
	return
END
INSERT INTO EMP(ID,NAME,GENDER,DEPTID)
SELECT ID,NAME,GENDER,@DEPTID
FROM INSERTED
END

INSERT INTO vwEMPDEPT VALUES(7,'VALLI','FEMALE','HR')	/* THIS WILL BE INSERTED IN vwEMPDEPT AND EMP TABLES ALSO */

