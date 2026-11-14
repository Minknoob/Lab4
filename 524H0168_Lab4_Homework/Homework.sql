USE SchoolDB;
GO

CREATE TABLE tblStudents (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Age INT NOT NULL,
    YearOfEnroll INT NOT NULL,
    Major NVARCHAR(50),
    GPA DECIMAL(3, 2)
);