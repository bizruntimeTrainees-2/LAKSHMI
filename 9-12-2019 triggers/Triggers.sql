CREATE TABLE TRIGGER1(ID int,NAME nvarchar(50),SALARY int,GENDER nvarchar(90),DEPARTMENTID int);
INSERT INTO TRIGGER1 VALUES(1,'JOHN',5000,'MALE',3);
INSERT INTO TRIGGER1 VALUES(2,'MIKE',3400,'MALE',2);
INSERT INTO TRIGGER1 VALUES(3,'POM',6000,'FEMALE',1);
INSERT INTO TRIGGER1 VALUES(4,'TOD',4800,'MALE',4);
INSERT INTO TRIGGER1 VALUES(5,'SARA',3200,'FEMALE',1);
INSERT INTO TRIGGER1 VALUES(65,'VICKY',3700,'MALE',1);
drop table TRIGGER1
SELECT * FROM TRIGGER1;

CREATE TABLE TRIGGER1AUDIT(ID int, AUDITDATA nvarchar(50));
SELECT * FROM TRIGGER1AUDIT;

CREATE TRIGGER tr_TRIGGER1_ForInsert
ON TRIGGER1
FOR INSERT
AS
BEGIN
  SELECT * FROM INSERTED
  /*WHENEVER you inserted a row in TRIGGER1 sql server maintains 
							a copy of that row in  inserted table */
  END



  /*inserted table is a special type of table thats only available in the context of triggers */
  INSERT INTO TRIGGER1 VALUES(12,'NEELOFAR',4500,'FEMALE',2);

INSERT INTO TRIGGER1 VALUES(71,'JENNY',6900,'FEMALE',3);

SELECT * FROM INSERTED	/* if we accessed this, it will show error message because of outside the trigger context */

ALTER TRIGGER tr_TRIGGER1_ForInsert
ON TRIGGER1
FOR INSERT
AS
BEGIN
Declare @ID int
Select @ID = ID from INSERTED
insert into TRIGGER1AUDIT VALUES(CAST(@ID AS int),CAST(@ID AS int))
 END

 CREATE TRIGGER tr_TRIGGER1_ForUpdate
 ON TRIGGER1
 FOR UPDATE
 AS
 BEGIN
 select * from INSERTED
 END

 UPDATE TRIGGER1 SET NAME = 'VIKAS'  WHERE ID = 4;

 