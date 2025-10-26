IF OBJECT_ID('dbo.StudentAccount', 'U') IS NULL
BEGIN
    CREATE TABLE StudentAccount (
        StudentID VARCHAR(50) PRIMARY KEY,   
        TotalBalance DECIMAL(18,2) DEFAULT 0,
        LastUpdated DATETIME DEFAULT GETDATE()

    )
END




SELECT * FROM MFFSS.dbo.StudentAccount




SELECT * FROM dbo.users;
INSERT INTO dbo.StudentAccount (StudentID, TotalBalance)
VALUES (3, 2000);


