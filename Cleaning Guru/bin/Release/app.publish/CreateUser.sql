:setvar DatabaseName "Cleaning Guru"
:setvar DatabaseUserName ""
:setvar DatabaseUserPassword ""
GO

USE [$(DatabaseName)]

DECLARE @usercount int
SELECT @usercount=COUNT(name) FROM sys.database_principals WHERE name = '$(DatabaseUserName)'
IF @usercount = 0
	CREATE USER $(DatabaseUserName) FOR LOGIN $(DatabaseUserName)
GO

EXEC sp_addrolemember db_datareader, $(DatabaseUserName)
EXEC sp_addrolemember db_datawriter, $(DatabaseUserName)
GO

