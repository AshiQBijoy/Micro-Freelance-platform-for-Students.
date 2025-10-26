-- 1. Verify বা create table যদি আগে থেকে না থাকে
IF OBJECT_ID('dbo.users', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.users
    (
        id INT PRIMARY KEY IDENTITY(1,1),
        username VARCHAR(100) NOT NULL UNIQUE,
        password VARCHAR(100) NOT NULL,
        role VARCHAR(20) NOT NULL CHECK (role IN ('Admin','Student')),
        studentId VARCHAR(50) NULL,
        studentName VARCHAR(200) NULL,
        date DATE DEFAULT GETDATE(),
        CONSTRAINT chk_studentId_required CHECK (
            (role = 'Admin' AND studentId IS NULL) OR
            (role = 'Student' AND studentId IS NOT NULL)
        )
    );
END
GO

-- 2. Verify data
SELECT * FROM MFFSS.dbo.users;
