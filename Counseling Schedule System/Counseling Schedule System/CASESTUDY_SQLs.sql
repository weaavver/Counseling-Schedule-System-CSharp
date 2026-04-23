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

INSERT INTO studentTbl 
(FirstName, LastName, Gender, Section, StudentNo, MobileNo, Email, Username, [Password])
VALUES
('Liam', 'Johnson', 'Male', 'IT-1A', '003570', '09170000001', 'liam.johnson@email.com', 'liamj', 'pass123'),
('Olivia', 'Smith', 'Female', 'IT-1A', '003571', '09170000002', 'olivia.smith@email.com', 'olivias', 'pass123'),
('Noah', 'Williams', 'Male', 'IT-1A', '003572', '09170000003', 'noah.w@email.com', 'noahw', 'pass123'),
('Emma', 'Brown', 'Female', 'IT-1A', '003573', '09170000004', 'emma.brown@email.com', 'emmab', 'pass123'),
('Oliver', 'Jones', 'Male', 'IT-1A', '003574', '09170000005', 'oliver.j@email.com', 'oliverj', 'pass123'),
('Charlotte', 'Garcia', 'Female', 'IT-1A', '003575', '09170000006', 'charlotte.g@email.com', 'charlotteg', 'pass123'),
('Elijah', 'Miller', 'Male', 'IT-1A', '003576', '09170000007', 'elijah.m@email.com', 'elijahm', 'pass123'),
('Amelia', 'Davis', 'Female', 'IT-1A', '003577', '09170000008', 'amelia.d@email.com', 'ameliad', 'pass123'),
('James', 'Rodriguez', 'Male', 'IT-1A', '003578', '09170000009', 'james.r@email.com', 'jamesr', 'pass123'),
('Ava', 'Martinez', 'Female', 'IT-1A', '003579', '09170000010', 'ava.m@email.com', 'avam', 'pass123'),
('William', 'Hernandez', 'Male', 'IT-1A', '003580', '09170000011', 'will.h@email.com', 'willh', 'pass123'),
('Sophia', 'Lopez', 'Female', 'IT-1A', '003581', '09170000012', 'sophia.l@email.com', 'sophial', 'pass123'),
('Benjamin', 'Gonzalez', 'Male', 'IT-1A', '003582', '09170000013', 'ben.g@email.com', 'beng', 'pass123'),
('Isabella', 'Wilson', 'Female', 'IT-1A', '003583', '09170000014', 'isabella.w@email.com', 'isabellaw', 'pass123'),
('Lucas', 'Anderson', 'Male', 'IT-1A', '003584', '09170000015', 'lucas.a@email.com', 'lucasa', 'pass123'),
('Mia', 'Thomas', 'Female', 'IT-1A', '003585', '09170000016', 'mia.t@email.com', 'miat', 'pass123'),
('Henry', 'Taylor', 'Male', 'IT-1A', '003586', '09170000017', 'henry.t@email.com', 'henryt', 'pass123'),
('Evelyn', 'Moore', 'Female', 'IT-1A', '003587', '09170000018', 'evelyn.m@email.com', 'evelynm', 'pass123'),
('Alexander', 'Jackson', 'Male', 'IT-1A', '003588', '09170000019', 'alex.j@email.com', 'alexj', 'pass123'),
('Harper', 'Martin', 'Female', 'IT-1A', '003589', '09170000020', 'harper.m@email.com', 'harperm', 'pass123');

INSERT INTO counselorTbl
(FirstName, LastName, Gender, Specialization, PRCLicenseNumber, MobileNo, Email, Username, [Password])
VALUES
('Mark', 'Anthony', 'Male', 'Academic', 'PRC001', '09270000001', 'mark.a@email.com', 'marka', 'pass123'),
('Anna', 'Reyes', 'Female', 'Career', 'PRC002', '09270000002', 'anna.r@email.com', 'annar', 'pass123'),
('John', 'Cruz', 'Male', 'Behavioral', 'PRC003', '09270000003', 'john.c@email.com', 'johnc', 'pass123'),
('Maria', 'Santos', 'Female', 'Academic', 'PRC004', '09270000004', 'maria.s@email.com', 'marias', 'pass123'),
('Paul', 'Dela Cruz', 'Male', 'Career', 'PRC005', '09270000005', 'paul.dc@email.com', 'pauldc', 'pass123'),
('Grace', 'Lopez', 'Female', 'Behavioral', 'PRC006', '09270000006', 'grace.l@email.com', 'gracel', 'pass123'),
('Kevin', 'Reyes', 'Male', 'Academic', 'PRC007', '09270000007', 'kevin.r@email.com', 'kevinr', 'pass123'),
('Liza', 'Garcia', 'Female', 'Career', 'PRC008', '09270000008', 'liza.g@email.com', 'lizag', 'pass123'),
('Brian', 'Torres', 'Male', 'Behavioral', 'PRC009', '09270000009', 'brian.t@email.com', 'briant', 'pass123'),
('Sophia', 'Reyes', 'Female', 'Academic', 'PRC010', '09270000010', 'sophia.r@email.com', 'sophiar', 'pass123'),
('Daniel', 'Mendoza', 'Male', 'Career', 'PRC011', '09270000011', 'daniel.m@email.com', 'danielm', 'pass123'),
('Clara', 'Villanueva', 'Female', 'Behavioral', 'PRC012', '09270000012', 'clara.v@email.com', 'clarav', 'pass123'),
('Eric', 'Navarro', 'Male', 'Academic', 'PRC013', '09270000013', 'eric.n@email.com', 'ericn', 'pass123'),
('Nina', 'Castro', 'Female', 'Career', 'PRC014', '09270000014', 'nina.c@email.com', 'ninac', 'pass123'),
('Oscar', 'Ramos', 'Male', 'Behavioral', 'PRC015', '09270000015', 'oscar.r@email.com', 'oscarr', 'pass123'),
('Paula', 'Diaz', 'Female', 'Academic', 'PRC016', '09270000016', 'paula.d@email.com', 'paulad', 'pass123'),
('Victor', 'Flores', 'Male', 'Career', 'PRC017', '09270000017', 'victor.f@email.com', 'victorf', 'pass123'),
('Elena', 'Aquino', 'Female', 'Behavioral', 'PRC018', '09270000018', 'elena.a@email.com', 'elenaa', 'pass123'),
('George', 'Lim', 'Male', 'Academic', 'PRC019', '09270000019', 'george.l@email.com', 'georgel', 'pass123'),
('Hannah', 'Tan', 'Female', 'Career', 'PRC020', '09270000020', 'hannah.t@email.com', 'hannaht', 'pass123');

INSERT INTO requestTbl

(StudentID, CounselorID, PreferredDateTime, ScheduledDateTime, Status, Reason, CounselingNotes)
VALUES
(1,1,'2026-04-23 09:00',NULL,'Pending','Academic stress',NULL),
(2,2,'2026-04-23 10:00',NULL,'Scheduled','Career guidance','Initial session'),
(3,3,'2026-04-23 11:00',NULL,'Pending','Behavior issues',NULL),
(4,4,'2026-04-23 13:00',NULL,'Scheduled','Study habits','Follow-up needed'),
(5,5,'2026-04-24 09:00',NULL,'Pending','Personal concerns',NULL),
(6,6,'2026-04-24 10:00',NULL,'Scheduled','Anxiety',NULL),
(7,7,'2026-04-24 11:00',NULL,'Pending','Academic improvement',NULL),
(8,8,'2026-04-24 13:00',NULL,'Scheduled','Career planning','Good progress'),
(9,9,'2026-04-25 09:00',NULL,'Pending','Behavioral issue',NULL),
(10,10,'2026-04-25 10:00',NULL,'Scheduled','Study stress',NULL),
(11,11,'2026-04-25 11:00',NULL,'Pending','Time management',NULL),
(12,12,'2026-04-25 13:00',NULL,'Scheduled','Career direction',NULL),
(13,13,'2026-04-26 09:00',NULL,'Pending','Academic pressure',NULL),
(14,14,'2026-04-26 10:00',NULL,'Scheduled','Personal issue','Needs monitoring'),
(15,15,'2026-04-26 11:00',NULL,'Pending','Motivation loss',NULL),
(16,16,'2026-04-26 13:00',NULL,'Scheduled','Career confusion',NULL),
(17,17,'2026-04-27 09:00',NULL,'Pending','Exam anxiety',NULL),
(18,18,'2026-04-27 10:00',NULL,'Scheduled','Behavior tracking',NULL),
(19,19,'2026-04-27 11:00',NULL,'Pending','Academic help',NULL),
(20,20,'2026-04-27 13:00',NULL,'Scheduled','Career advice',NULL);





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

--THE LIST OF STUDENTS FOR CHECKING IN REGISTER

CREATE TABLE studentList (
    StudentNo VARCHAR(10) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL 
);

INSERT INTO studentList (StudentNo, Name) VALUES
('003570', 'Liam Johnson'),
('003571', 'Olivia Smith'),
('003572', 'Noah Williams'),
('003573', 'Emma Brown'),
('003574', 'Oliver Jones'),
('003575', 'Charlotte Garcia'),
('003576', 'Elijah Miller'),
('003577', 'Amelia Davis'),
('003578', 'James Rodriguez'),
('003579', 'Ava Martinez'),
('003580', 'William Hernandez'),
('003581', 'Sophia Lopez'),
('003582', 'Benjamin Gonzalez'),
('003583', 'Isabella Wilson'),
('003584', 'Lucas Anderson'),
('003585', 'Mia Thomas'),
('003586', 'Henry Taylor'),
('003587', 'Evelyn Moore'),
('003588', 'Alexander Jackson'),
('003589', 'Harper Martin'),
('003590', 'Mark Anthony');












