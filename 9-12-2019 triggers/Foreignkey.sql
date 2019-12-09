CREATE TABLE Persons (
    ID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int CHECK (Age>=18)
); /* check is one of the default constarints */

CREATE TABLE CUSTOM(PERSONID int primary key,NAME nvarchar(20),AGE int);

INSERT INTO CUSTOM VALUES(1,'LAKSHMI',21)
INSERT INTO CUSTOM VALUES(2,'LAVANYA',25)
INSERT INTO CUSTOM VALUES(3,'NANDINI',19)
INSERT INTO CUSTOM VALUES(4,'CUTIEE',15)

SELECT * FROM CUSTOM

CREATE TABLE Orders (
    ORDERID int NOT NULL PRIMARY KEY,
    ORDERNUMBER int NOT NULL,
    PERSONID int FOREIGN KEY REFERENCES CUSTOM(PERSONID)
);


INSERT INTO Orders VALUES(1,20,3)
INSERT INTO Orders VALUES(2,16,1)
INSERT INTO Orders VALUES(3,25,2)
INSERT INTO Orders VALUES(4,28,4)

SELECT * FROM Orders


CREATE TABLE TB (
    ID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int,
    City varchar(255) DEFAULT 'LONDON'
);
/*
The DEFAULT constraint is used to provide a default value for a column.
The default value will be added to all new records IF no other value is specified.
*/

SELECT * FROM TB

INSERT INTO TB VALUES(1,'AVULA','NAGARAJU',41,NULL)

UPDATE TB SET City = 'TADIPATRI' WHERE ID = 1