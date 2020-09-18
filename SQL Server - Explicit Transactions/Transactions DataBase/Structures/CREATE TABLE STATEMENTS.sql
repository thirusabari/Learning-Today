

IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='Statements')
BEGIN
CREATE TABLE Statements
(
   StatementId INT PRIMARY KEY IDENTITY NOT NULL,
   StatementName VARCHAR(200)  NULL,
   CreatedBy VARCHAR(100) NULL,
   CreatedDate DATETIME NULL
);
PRINT '---Table Created Successfully---'
END


IF NOT EXISTS(SELECT * FROM Statements)
BEGIN
INSERT INTO Statements(StatementName, CreatedBy,CreatedDate)
VALUES ('Ignitaion Started','Data Setup', GETDATE())
PRINT '---Initial Data Inserted Successfully---'
END
GO

