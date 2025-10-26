

CREATE TABLE WorkApplications (
    ApplicationID INT PRIMARY KEY IDENTITY(1,1),
    WorkID INT NOT NULL,
    StudentID INT NOT NULL,
    Status NVARCHAR(50) DEFAULT 'Pending',
    AppliedDate DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (WorkID) REFERENCES AdminWork(WorkID)
);



SELECT * FROM MFFSS.dbo.WorkApplications
