IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='StudentPayments' AND xtype='U')
BEGIN
    CREATE TABLE StudentPayments (
        PaymentID INT PRIMARY KEY IDENTITY(1,1),
        StudentID VARCHAR(50) NOT NULL,   -- string
        WorkID INT NOT NULL,              
        Amount DECIMAL(10,2) NOT NULL,
        PaymentDate DATETIME DEFAULT GETDATE(),
        Description NVARCHAR(200)
    )
END

SELECT * FROM MFFSS.dbo.StudentPayments
