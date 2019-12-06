CREATE TABLE EMPLOYEE1(ID INT, NAME NVARCHAR(90), AGE INT, SALARY INT,ADDRESS NVARCHAR(90));

INSERT INTO EMPLOYEE1 VALUES(1,'LAKKY',21,34000,'BANGLORE');
INSERT INTO EMPLOYEE1 VALUES(2,'lEHA',23,32000,'HYDERABAD');
INSERT INTO EMPLOYEE1 VALUES(3,'NIHA',21,31000,'MUMBAI');
INSERT INTO EMPLOYEE1 VALUES(4,'SNEHA',26,45000,'NOIDA');
INSERT INTO EMPLOYEE1 VALUES(5,'PRIYA',27,54000,'PUNE');
INSERT INTO EMPLOYEE1 VALUES(6,'DEEKSHA',23,25000,'MP');
INSERT INTO EMPLOYEE1 VALUES(7,'VINAY',34,50000,'INDORE');

CREATE VIEW VIEWEMPLOYEE
AS
SELECT * FROM EMPLOYEE1

SELECT * FROM VIEWEMPLOYEE;

UPDATE VIEWEMPLOYEE SET ADDRESS = 'MADRAS' WHERE ID = 5;
SELECT * FROM VIEWEMPLOYEE;

SELECT * FROM EMPLOYEE1 WHERE SALARY BETWEEN 35000 AND 50000;