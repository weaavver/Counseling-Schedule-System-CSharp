CREATE DATABASE CounselingScheduleSystem
USE CounselingScheduleSystem
SELECT * FROM requestTbl


DROP TABLE studentTbl;
DROP TABLE counselorTbl;
DROP TABLE requestTbl;

--CREATE TABLE FOR STUDENT
CREATE TABLE studentTbl(
	studentID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Gender VARCHAR(10) CHECK (Gender IN ('Male','Female')),
    Section VARCHAR(20) NOT NULL,
    StudentNo VARCHAR(20) NOT NULL,
    MobileNo VARCHAR(13) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Username VARCHAR(100) NOT NULL,
    [Password] VARCHAR(255) NOT NULL,

    --Unique Constraints
    CONSTRAINT UQ_Email UNIQUE (Email),
    CONSTRAINT UQ_StudentNo UNIQUE (StudentNo),
    CONSTRAINT UQ_MobileNo UNIQUE (MobileNo),
    CONSTRAINT UQ_Username UNIQUE (Username)
);

--Counselor table
CREATE TABLE counselorTbl(
	counselorID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,    
    LastName VARCHAR(100) NOT NULL,
    Gender VARCHAR(10) CHECK (Gender IN ('Male','Female')),
    Specialization VARCHAR(50) NOT NULL,
    PRCLicenseNumber VARCHAR(50) NOT NULL,
    MobileNo VARCHAR(13) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Username VARCHAR(100) NOT NULL,
    [Password] VARCHAR(255) NOT NULL,

    --Unique Constraints
    CONSTRAINT UQ_CounselorPRC UNIQUE (PRCLicenseNumber),   
    CONSTRAINT UQ_CounselorEmail UNIQUE (Email),
    CONSTRAINT UQ_CounselorMobileNo UNIQUE (MobileNo),
    CONSTRAINT UQ_CounselorUsername UNIQUE (Username)
);

--CREATE TABLE FOR REQUESTS
CREATE TABLE requestTbl(
    requestID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT NOT NULL,
    CounselorID INT NULL,
    PreferredDateTime DATETIME NOT NULL,
    ScheduledDateTime DATETIME NULL,
    [Status] VARCHAR(20) CHECK ([Status] IN ('Pending','Scheduled','Cancelled','Completed')) DEFAULT 'Pending',
    Reason VARCHAR(255) NULL,
    CounselingNotes VARCHAR(255) NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,

    --ForeignKeys
    CONSTRAINT FK_Request_Student 
    FOREIGN KEY (StudentID) 
    REFERENCES studentTbl(studentID)
    ON DELETE CASCADE,

    -- If counselor is deleted keep request but remove assignment
    CONSTRAINT FK_Request_Counselor 
    FOREIGN KEY (CounselorID) 
    REFERENCES counselorTbl(counselorID)
    ON DELETE SET NULL
);

SELECT Concat(FirstName,' ',LastName) FROM studentTbl WHERE studentID = @StudentID

--For getting the counselor name using the counselorID in requestTbl
--This is for loading the pending requests for counselor dashboard table.
SELECT 
    r.[Status],
    r.PreferredDate,
    s.StudentName AS [Student Name],
    s.MobileNo,
    s.Email,
    s.Section,
    r.Reason,
    r.CreatedAt
FROM requestTbl r
INNER JOIN studentTbl s
    ON r.studentID = s.studentID;


SELECT * FROM requestTbl WHERE [Status] = 'Pending'
SELECT * FROM studentTbl
SELECT * FROM requestTbl
SELECT * FROM counselorTbl

UPDATE requestTbl
SET [Status] = 'Pending'
WHERE requestID = 1;

SELECT Username, Password FROM studentTbl;

EXEC sp_rename 'studentTbl.Pass', 'Password', 'COLUMN';

INSERT INTO studentTbl(StudentName, Section, StudentNo, MobileNo, Email, Username, [Password])
VALUES('Naruto Shipudden','IT32a','202400592','0949282819','jssjsj@gmail.com','sjsjs123','ososso213');
















