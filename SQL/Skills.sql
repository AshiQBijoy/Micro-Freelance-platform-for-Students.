IF OBJECT_ID('dbo.Skills', 'U') IS NOT NULL
    DROP TABLE dbo.Skills;


CREATE TABLE dbo.Skills
(
    SkillID INT PRIMARY KEY IDENTITY(1,1),
    StudentId VARCHAR(50) NOT NULL,
    SkillName VARCHAR(100) NOT NULL
);

SELECT * FROM MFFSS.dbo.Skills;
