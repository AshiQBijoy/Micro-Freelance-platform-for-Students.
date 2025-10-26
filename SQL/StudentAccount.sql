IF OBJECT_ID('dbo.StudentAccount', 'U') IS NULL
BEGIN
    CREATE TABLE StudentAccount (
        StudentID VARCHAR(50) PRIMARY KEY,   -- string ID
        TotalBalance DECIMAL(18,2) DEFAULT 0,
        LastUpdated DATETIME DEFAULT GETDATE()
        -- FOREIGN KEY constraint বাদ দেওয়া হলো
    )
END




SELECT * FROM MFFSS.dbo.StudentAccount



-- Check if user exists
SELECT * FROM dbo.users;

-- Suppose user with id = 3 exists
INSERT INTO dbo.StudentAccount (StudentID, TotalBalance)
VALUES (3, 2000);


