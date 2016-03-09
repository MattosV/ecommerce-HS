/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DECLARE	@id INT;

SELECT @id = Id FROM dbo.Users WHERE Username = 'olivia';

IF @id IS NULL
BEGIN
	INSERT INTO dbo.Users VALUES('olivia', 'batatinha123', NULL);
END

SELECT @id = Id FROM dbo.Client WHERE Name = 'Mateus da Luz Leonardi';

IF @id IS NULL
BEGIN
	INSERT INTO dbo.Client VALUES('Mateus da Luz Leonardi', 0440044004400440, '1990-09-01');
END

SELECT @id = Id FROM dbo.Users WHERE Username = 'mleonardi';

IF @id IS NULL
BEGIN
	INSERT INTO dbo.Users VALUES('mleonardi', 'batatinha123', (SELECT Id FROM dbo.Client WHERE Name = 'Mateus da Luz Leonardi'));
END