CREATE TABLE TBLGENDER(ID int NOT NULL PRIMARY KEY,GENDER nvarchar(50) NOT NULL);
/* in this TBLGENDER ID column as primary key and in TBLPERSON GENDERID as foreign key */
insert into TBLGENDER values(1,'MALE');
insert into TBLGENDER values(2,'FEMALE');
insert into TBLGENDER values(3,'UNKNOWN');

create table TBLPERSON(ID int,NAME nvarchar(50),EMAIL nvarchar(50), GENDERID int NULL);

insert into TBLPERSON values(1,'mery','Mr@gamil.com',1);
insert into TBLPERSON values(2,'tery','Mr@gamil.com',3);
insert into TBLPERSON values(3,'vijay','Mr@gamil.com',2);
insert into TBLPERSON values(4,'sneha','Mr@gamil.com',NULL);
insert into TBLPERSON values(5,'neha','Mr@gamil.com',1);
insert into TBLPERSON values(6,'vinay','Mr@gamil.com',2);



insert into TBLPERSON values(8,'POOR','PR@gmail.com',NULL)

ALTER TABLE TBLPERSON add Constraint TBLPERSON_GENDERID_FK
FOREIGN KEY (GENDERID) references TBLGENDER(ID)

ALTER TABLE TBLPERSON add Constraint DF_TBLPERSON_GENDERID default 3 for GENDERID