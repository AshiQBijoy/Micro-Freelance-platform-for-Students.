-- Check if table exists, create if not
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='StudentSubmittedWork' AND xtype='U')
BEGIN
    CREATE TABLE StudentSubmittedWork (
        WorkID INT IDENTITY(1,1) PRIMARY KEY,   -- Auto-increment WorkID
        StudentID INT NOT NULL,                 -- Must match users.id
        WorkName NVARCHAR(200) NOT NULL,
        FilePath NVARCHAR(500) NULL,
        SubmitDate DATETIME DEFAULT GETDATE(),
        -- FOREIGN KEY constraint optional, only if StudentID matches users.id
        FOREIGN KEY (StudentID) REFERENCES users(id)
    )
END




SELECT * FROM MFFSS.dbo.StudentSubmittedWork


