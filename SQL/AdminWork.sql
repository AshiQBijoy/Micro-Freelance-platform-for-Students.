

CREATE TABLE AdminWork (
    WorkID INT IDENTITY(1,1) PRIMARY KEY,
    TaskName NVARCHAR(200) NOT NULL,
    TaskDescription NVARCHAR(MAX) NULL,
    Deadline DATE NOT NULL,
    PaymentAmount DECIMAL(18,2) NOT NULL,
    FilePath NVARCHAR(500) NULL,
    AdminUser NVARCHAR(100) NOT NULL
);

SELECT * FROM MFFSS.dbo.AdminWork