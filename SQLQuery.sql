-- Create Database
CREATE DATABASE ExamBrowserDB;
GO

USE ExamBrowserDB;
GO

-- Table Admin
CREATE TABLE Admin (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- Table Teacher
CREATE TABLE Teacher (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100) NOT NULL
);
GO

-- Table Student
CREATE TABLE Student (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    NIS int NOT NULL UNIQUE
);
GO

CREATE TABLE Subject (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SubjectName NVARCHAR(100) NOT NULL UNIQUE
);
GO

-- Table Exam
CREATE TABLE Exam (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ExamName NVARCHAR(200) NOT NULL,
    TeacherId INT NOT NULL,
    SubjectId int NOT NULL,
    GoogleFormLink NVARCHAR(200) NOT NULL,
    Token NVARCHAR(50) NULL,
    TokenExpiry DATETIME NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (TeacherId) REFERENCES Teacher(Id),
	FOREIGN KEY (SubjectId) REFERENCES Subject(Id)
);
GO

-- Table StudentAnswer
CREATE TABLE StudentAnswer (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    ExamId INT NOT NULL,
    SubmitDate DATETIME DEFAULT GETDATE(),
    Status BIT DEFAULT 1,
    FOREIGN KEY (StudentId) REFERENCES Student(Id),
    FOREIGN KEY (ExamId) REFERENCES Exam(Id)
);
GO

