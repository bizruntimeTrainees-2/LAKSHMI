CREATE TABLE AFTERTRIGGER(ID int,NAME nvarchar(50))

CREATE TRIGGER DEMOTRIGGER ON AFTERTRIGGER 
AFTER INSERT
AS
BEGIN
INSERT INTO AFTERTRIGGER VALUES(1,'AMAR')
END
 

 INSERT INTO AFTERTRIGGER VALUES(2,'SUJITH')

 SELECT * FROM AFTERTRIGGER

 CREATE TABLE INSTEADOFTRIGGER(ID int,FIRST_NAME nvarchar(50))

 CREATE TRIGGER INSTEADTR ON INSTEADOFTRIGGER INSTEAD OF DELETE
 AS 
 BEGIN
 DELETE FROM INSTEADOFTRIGGER WHERE ID = 1
 END

 INSERT INTO INSTEADOFTRIGGER VALUES(1,'NOOTAN')
 INSERT INTO INSTEADOFTRIGGER VALUES(2,'SWETHA')
 INSERT INTO INSTEADOFTRIGGER VALUES(3,'HARI')



 DELETE FROM INSTEADOFTRIGGER WHERE ID = 2

 SELECT * FROM INSTEADOFTRIGGER


 CREATE TABLE Employee_Test		/* this is first table */
(  
Emp_ID INT Identity,  
Emp_name Varchar(100),  
Emp_Sal int  
)  
 
INSERT INTO Employee_Test VALUES ('Anees',1000);  
INSERT INTO Employee_Test VALUES ('Rick',1200);  
INSERT INTO Employee_Test VALUES ('John',1100);  
INSERT INTO Employee_Test VALUES ('Stephen',1300);  
INSERT INTO Employee_Test VALUES ('Maria',1400); 


CREATE TABLE Employee_Test_Audit  /*this is second table */
(  
Emp_ID int,  
Emp_name varchar(100),  
Emp_Sal int,  
Audit_Action varchar(100),  
Audit_Timestamp datetime  
) 

CREATE TRIGGER trgAfterInsert ON [dbo].[Employee_Test]   
FOR INSERT  
AS  
declare @empid int;  
declare @empname varchar(100);  
declare @empsal decimal(10,2);  
declare @audit_action varchar(100);  
select @empid=i.Emp_ID from inserted i;   
select @empname=i.Emp_Name from inserted i;   
select @empsal=i.Emp_Sal from inserted i;   
set @audit_action='Inserted Record -- After Insert Trigger.';  
  
insert into Employee_Test_Audit  
(Emp_ID,Emp_Name,Emp_Sal,Audit_Action,Audit_Timestamp)   
values(@empid,@empname,@empsal,@audit_action,getdate());  
  
PRINT 'AFTER INSERT trigger fired.'  
GO  
  
  insert into Employee_Test values('Ravi',1500);

  Select * from Employee_Test_Audit 