CREATE TABLE CUSTOMER(Customer_Id int identity primary key,First_Name nvarchar(50),Last_Name nvarchar(50));

INSERT INTO CUSTOMER VALUES('DEEKSHA','B.K.R');
INSERT INTO CUSTOMER VALUES('NITHYA','B.K.R');

SELECT * FROM CUSTOMER;

CREATE PROCEDURE spAddCustomers
@First_Name nvarchar(50),
@Last_name nvarchar(50)
AS
BEGIN
INSERT INTO CUSTOMER VALUES(@First_Name,@Last_Name)
return SCOPE_IDENTITY()
END

SELECT * FROM CUSTOMER