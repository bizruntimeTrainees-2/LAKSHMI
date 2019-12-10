CREATE LOGIN [testuser] WITH PASSWORD = N'testuser@123' ,DEFAULT_DATABASE = [master],CHECK_EXPIRATION = OFF,
CHECK_POLICY = OFF	/* to create the SQL Login "testuser". */

GRANT VIEW SERVER STATE TO [testuser]	/*apply the view server 
state permission to this login that enables a login to view the results of Dynamic Management Objects.*/


CREATE TRIGGER LOGIN_TIME_SLOT
ON ALL SERVER
FOR LOGON
AS
BEGIN
IF((ORIGINAL_LOGIN() = 'testuser')
AND
(DATEPART(HOUR,GETDATE()) BETWEEN 18 AND 24)
OR
(DATEPART(HOUR,GETDATE()) BETWEEN 0 AND 9)
)
BEGIN
ROLLBACK
END
END

CREATE TABLE Auditing  /* this is first table */
(  
SessionId INT,  
LogonTime DATETIME,		
HostName VARCHAR(50),  
ProgramName VARCHAR(500),  
LoginName VARCHAR(50),  
ClientHost VARCHAR(50))  


CREATE TRIGGER Audit_TR  
ON ALL SERVER WITH EXECUTE AS 'sa'  /*this is second */ /*sa is original login */
FOR LOGON  
AS  
BEGIN  
DECLARE @LogonTRData XML,  
@EventTime datetime,  
@LoginName varchar(50),  
@ClientHost varchar(50),  
@LoginType varchar(50),  
@HostName varchar(50),  
@AppName varchar(500)  
SET @LogonTRData = EVENTDATA()  
SET @EventTime = @LogonTRData.value('(/EVENT_INSTANCE/PostTime)[1]', 'datetime')  
SET @LoginName = @LogonTRData.value('(/EVENT_INSTANCE/LoginName)[1]', 'varchar(50)')  
SET @ClientHost = @LogonTRData.value('(/EVENT_INSTANCE/ClientHost)[1]', 'varchar(50)')  
SET @HostName = HOST_NAME()  
SET @AppName = APP_NAME()--,program_name()  
INSERT INTO DBATest.dbo.Auditing  
(  
SessionId,  
LogonTime,  
HostName,  
ProgramName,  
LoginName,  
ClientHost  
)  
SELECT  
@@SPID,  
@EventTime,  
@HostName,  
@AppName,  
@LoginName,  
@ClientHost  
END  