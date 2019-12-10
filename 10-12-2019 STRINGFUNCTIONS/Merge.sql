CREATE TABLE StudentSource(ID int,NAME nvarchar(50))

CREATE TABLE StudentTarget(ID int,NAME nvarchar(50))

INSERT INTO StudentSource VALUES(1,'MIKE')
INSERT INTO StudentSource VALUES(2,'SARA')


INSERT INTO StudentTarget VALUES(1,'MIKE M')
INSERT INTO StudentTarget VALUES(2,'JOHN')

MERGE StudentTarget AS T
USING StudentSource AS S
ON T.ID = S.ID
WHEN MATCHED THEN
UPDATE SET T.NAME = S.NAME
WHEN NOT MATCHED BY TARGET THEN 
INSERT (ID,NAME) VALUES (S.ID,S.NAME)
WHEN NOT MATCHED BY SOURCE THEN
DELETE;

SELECT * FROM StudentTarget
/*here in this merge two tables are there,source table and target table ,if data present in source table and not present in target table at that 
time we need to insert data */
/*if data present in target table not present in source table at that time u need to delete the data */


SELECT * FROM StudentTarget
SELECT * FROM StudentSource