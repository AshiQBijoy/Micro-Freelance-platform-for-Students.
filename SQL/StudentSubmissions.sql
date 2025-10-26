-- StudentSubmissions table
IF OBJECT_ID('dbo.StudentSubmissions', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.StudentSubmissions
    (
        SubmissionID INT IDENTITY(1,1) PRIMARY KEY,
        WorkID INT NOT NULL,
        StudentID VARCHAR(50) NOT NULL,
        TaskName NVARCHAR(255) NOT NULL,
        FilePath NVARCHAR(500) NULL,
        SubmissionDate DATETIME NOT NULL DEFAULT GETDATE(),
        Status NVARCHAR(50) NOT NULL DEFAULT 'Pending',

        FOREIGN KEY (WorkID) REFERENCES AdminWork(WorkID),
        
    )
END
SELECT * FROM MFFSS.dbo.StudentSubmissions
