DROP DATABASE IF EXISTS hr_recruitment_db;
CREATE DATABASE hr_recruitment_db;
USE hr_recruitment_db;

-- ==========================================
-- ROLES
-- ==========================================
CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL UNIQUE
);

-- ==========================================
-- HR USERS
-- ==========================================
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- ==========================================
-- APPLICANT ACCOUNTS
-- ==========================================
CREATE TABLE ApplicantAccounts (
    AccountID INT AUTO_INCREMENT PRIMARY KEY,
    Email VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    AccountStatus VARCHAR(20) DEFAULT 'Active',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- ==========================================
-- APPLICANT PROFILES
-- ==========================================
CREATE TABLE Applicants (
    ApplicantID INT AUTO_INCREMENT PRIMARY KEY,
    AccountID INT UNIQUE,

    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,

    ContactNumber VARCHAR(20),
    Address TEXT,
    DateOfBirth DATE,

    HighestEducation VARCHAR(100),
    Skills TEXT,
    WorkExperience TEXT,

    FOREIGN KEY (AccountID)
        REFERENCES ApplicantAccounts(AccountID)
        ON DELETE CASCADE
);

-- ==========================================
-- DEPARTMENTS
-- ==========================================
CREATE TABLE Departments (
    DepartmentID INT AUTO_INCREMENT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);

-- ==========================================
-- JOB VACANCIES
-- ==========================================
CREATE TABLE JobVacancies (
    VacancyID INT AUTO_INCREMENT PRIMARY KEY,

    JobTitle VARCHAR(100) NOT NULL,

    DepartmentID INT,

    JobStatus VARCHAR(20) DEFAULT 'Open',

    Qualifications TEXT,

    FOREIGN KEY (DepartmentID)
        REFERENCES Departments(DepartmentID)
);

-- ==========================================
-- APPLICATIONS
-- ==========================================
CREATE TABLE Applications (
    ApplicationID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicantID INT,
    VacancyID INT,

    CurrentStatus VARCHAR(30) DEFAULT 'Draft',

    AppliedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (ApplicantID)
        REFERENCES Applicants(ApplicantID),

    FOREIGN KEY (VacancyID)
        REFERENCES JobVacancies(VacancyID),

    UNIQUE KEY unique_applicant_job (ApplicantID, VacancyID)
);

-- ==========================================
-- REQUIREMENT TYPES
-- ==========================================
CREATE TABLE RequirementTypes (
    RequirementTypeID INT AUTO_INCREMENT PRIMARY KEY,
    RequirementName VARCHAR(100) NOT NULL
);

-- ==========================================
-- APPLICANT DOCUMENTS
-- ==========================================
CREATE TABLE ApplicantDocuments (
    DocumentID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicantID INT,
    RequirementTypeID INT,

    FilePath VARCHAR(255),

    Status VARCHAR(30),

    FOREIGN KEY (ApplicantID)
        REFERENCES Applicants(ApplicantID),

    FOREIGN KEY (RequirementTypeID)
        REFERENCES RequirementTypes(RequirementTypeID)
);

-- ==========================================
-- SCREENING RESULTS
-- ==========================================
CREATE TABLE ScreeningResults (
    ScreeningID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicationID INT,
    Result VARCHAR(30),
    Remarks TEXT,

    ScreenedBy INT,

    FOREIGN KEY (ApplicationID)
        REFERENCES Applications(ApplicationID),

    FOREIGN KEY (ScreenedBy)
        REFERENCES Users(UserID)
);

-- ==========================================
-- INTERVIEW SCHEDULES
-- ==========================================
CREATE TABLE InterviewSchedules (
    InterviewID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicationID INT,

    InterviewDate DATETIME,

    InterviewerID INT,

    Location VARCHAR(100),

    Status VARCHAR(30),

    FOREIGN KEY (ApplicationID)
        REFERENCES Applications(ApplicationID),

    FOREIGN KEY (InterviewerID)
        REFERENCES Users(UserID)
);

-- ==========================================
-- INTERVIEW EVALUATIONS
-- ==========================================
CREATE TABLE InterviewEvaluations (
    EvaluationID INT AUTO_INCREMENT PRIMARY KEY,

    InterviewID INT,

    Score DECIMAL(5,2),

    Result VARCHAR(30),

    Remarks TEXT,

    FOREIGN KEY (InterviewID)
        REFERENCES InterviewSchedules(InterviewID)
);

-- ==========================================
-- HIRING DECISIONS
-- ==========================================
CREATE TABLE HiringDecisions (
    DecisionID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicationID INT,

    DecisionStatus VARCHAR(30),

    Remarks TEXT,

    DecisionBy INT,

    DecisionDate DATETIME,

    FOREIGN KEY (ApplicationID)
        REFERENCES Applications(ApplicationID),

    FOREIGN KEY (DecisionBy)
        REFERENCES Users(UserID)
);

-- ==========================================
-- APPLICATION STATUS HISTORY
-- ==========================================
CREATE TABLE ApplicationStatusHistory (
    HistoryID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicationID INT,

    Status VARCHAR(30),

    Remarks TEXT,

    ChangedBy INT,

    ChangedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (ApplicationID)
        REFERENCES Applications(ApplicationID),

    FOREIGN KEY (ChangedBy)
        REFERENCES Users(UserID)
);

-- ==========================================
-- AUDIT TRAIL
-- ==========================================
CREATE TABLE AuditTrail (
    AuditID INT AUTO_INCREMENT PRIMARY KEY,

    UserID INT,

    ActionTaken TEXT,

    ActionDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (UserID)
        REFERENCES Users(UserID)
);

-- ==========================================
-- DEFAULT ROLES
-- ==========================================
INSERT INTO Roles (RoleName)
VALUES
('Admin'),
('HR Staff'),
('HR Manager');