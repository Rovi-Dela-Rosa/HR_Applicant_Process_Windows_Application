DROP DATABASE IF EXISTS hr_recruitment_db;
CREATE DATABASE hr_recruitment_db;
USE hr_recruitment_db;

-- ==========================================
-- 1. ROLES
-- ==========================================
CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL UNIQUE
);

-- ==========================================
-- 2. HR USERS
-- ==========================================
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Email VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- ==========================================
-- 3. APPLICANT ACCOUNTS
-- ==========================================
CREATE TABLE ApplicantAccounts (
    AccountID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    AccountStatus VARCHAR(20) DEFAULT 'Active',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- ==========================================
-- 4. APPLICANT PROFILES
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
    FOREIGN KEY (AccountID) REFERENCES ApplicantAccounts(AccountID) ON DELETE CASCADE
);

-- ==========================================
-- 5. DEPARTMENTS
-- ==========================================
CREATE TABLE Departments (
    DepartmentID INT AUTO_INCREMENT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL UNIQUE
);

-- ==========================================
-- 6. POSITIONS
-- ==========================================
CREATE TABLE Positions (
    PositionID INT AUTO_INCREMENT PRIMARY KEY,
    PositionName VARCHAR(100) NOT NULL UNIQUE
);

-- ==========================================
-- 7. EMPLOYMENT TYPES
-- ==========================================
CREATE TABLE EmploymentTypes (
    EmploymentTypeID INT AUTO_INCREMENT PRIMARY KEY,
    TypeName VARCHAR(50) NOT NULL UNIQUE
);

-- ==========================================
-- 8. JOB VACANCIES
-- ==========================================
CREATE TABLE JobVacancies (
    VacancyID INT AUTO_INCREMENT PRIMARY KEY,
    PositionID INT,                      
    DepartmentID INT,
    EmploymentTypeID INT,                
    JobStatus VARCHAR(20) DEFAULT 'Open',
    Qualifications TEXT,
    FOREIGN KEY (PositionID) REFERENCES Positions(PositionID),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    FOREIGN KEY (EmploymentTypeID) REFERENCES EmploymentTypes(EmploymentTypeID)
);

-- ==========================================
-- 9. APPLICATIONS
-- ==========================================
CREATE TABLE Applications (
    ApplicationID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicantID INT,
    VacancyID INT,
    CurrentStatus VARCHAR(30) DEFAULT 'Draft',
    AppliedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ApplicantID) REFERENCES Applicants(ApplicantID),
    FOREIGN KEY (VacancyID) REFERENCES JobVacancies(VacancyID),
    UNIQUE KEY unique_applicant_job (ApplicantID, VacancyID)
);

-- ==========================================
-- 10. REQUIREMENT TYPES 
-- ==========================================
CREATE TABLE RequirementTypes (
    RequirementTypeID INT AUTO_INCREMENT PRIMARY KEY,
    RequirementName VARCHAR(100) NOT NULL UNIQUE
);

-- ==========================================
-- 11. APPLICANT DOCUMENTS
-- ==========================================
CREATE TABLE ApplicantDocuments (
    DocumentID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicantID INT,
    RequirementTypeID INT,
    FilePath VARCHAR(255),
    Status VARCHAR(30),
    Remarks TEXT,
    DateSubmitted DATETIME NULL,
    FOREIGN KEY (ApplicantID) REFERENCES Applicants(ApplicantID),
    FOREIGN KEY (RequirementTypeID) REFERENCES RequirementTypes(RequirementTypeID)
);

-- ==========================================
-- 12. SCREENING RESULTS
-- ==========================================
CREATE TABLE ScreeningResults (
    ScreeningID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT,
    Result VARCHAR(30),
    Remarks TEXT,
    ScreenedBy INT,                      
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (ScreenedBy) REFERENCES Users(UserID) 
);

-- ==========================================
-- 13. INTERVIEW TYPES
-- ==========================================
CREATE TABLE InterviewTypes (
    InterviewTypeID INT AUTO_INCREMENT PRIMARY KEY,
    TypeName VARCHAR(50) NOT NULL UNIQUE
);

-- ==========================================
-- 14. INTERVIEW SCHEDULES
-- ==========================================
CREATE TABLE InterviewSchedules (
    InterviewID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT,
    InterviewTypeID INT,                 
    InterviewDate DATETIME,
    InterviewerID INT,
    Location VARCHAR(100),
    Status VARCHAR(30),
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (InterviewerID) REFERENCES Users(UserID),
    FOREIGN KEY (InterviewTypeID) REFERENCES InterviewTypes(InterviewTypeID)
);

-- ==========================================
-- 15. INTERVIEW EVALUATIONS
-- ==========================================
CREATE TABLE InterviewEvaluations (
    EvaluationID INT AUTO_INCREMENT PRIMARY KEY,
    InterviewID INT,
    Score DECIMAL(5,2),
    Result VARCHAR(30),
    Remarks TEXT,
    EvaluatedBy INT,                     
    FOREIGN KEY (InterviewID) REFERENCES InterviewSchedules(InterviewID),
    FOREIGN KEY (EvaluatedBy) REFERENCES Users(UserID) 
);

-- ==========================================
-- 16. ASSESSMENT TYPES
-- ==========================================
CREATE TABLE AssessmentTypes (
    AssessmentTypeID INT AUTO_INCREMENT PRIMARY KEY,
    AssessmentName VARCHAR(100) NOT NULL UNIQUE
);

-- ==========================================
-- 17. APPLICANT ASSESSMENTS
-- ==========================================
CREATE TABLE ApplicantAssessments (
    AssessmentID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT,
    AssessmentTypeID INT,
    Score DECIMAL(5,2),
    Result VARCHAR(30),                  
    Remarks TEXT,
    AssessmentDate DATETIME,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (AssessmentTypeID) REFERENCES AssessmentTypes(AssessmentTypeID)
);

-- ==========================================
-- 18. HIRING DECISIONS
-- ==========================================
CREATE TABLE HiringDecisions (
    DecisionID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT,
    DecisionStatus VARCHAR(30),
    Remarks TEXT,
    DecisionBy INT,
    DecisionDate DATETIME,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (DecisionBy) REFERENCES Users(UserID)
);

-- ==========================================
-- 19. APPLICATION STATUS HISTORY
-- ==========================================
CREATE TABLE ApplicationStatusHistory (
    HistoryID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT,
    Status VARCHAR(30),
    Remarks TEXT,
    ChangedBy INT,
    ChangedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (ChangedBy) REFERENCES Users(UserID)
);

-- ==========================================
-- 20. AUDIT TRAIL
-- ==========================================
CREATE TABLE AuditTrail (
    AuditID INT AUTO_INCREMENT PRIMARY KEY,
    UserType VARCHAR(20),
    UserID INT,
    ActionTaken TEXT,
    ActionDate DATETIME DEFAULT CURRENT_TIMESTAMP
);



INSERT INTO Roles (RoleName) VALUES ('Admin'), ('HR Staff'), ('HR Manager');


USE hr_recruitment_db;


-- Adding of staff and admin
INSERT INTO Users (Username, Email, PasswordHash, FullName, RoleID) 
VALUES ('admin_main', 'admin_main@company.com', 'hashed_pass_1', 'John Doe', 1);



ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'ivor_blunt00';
FLUSH PRIVILEGES;