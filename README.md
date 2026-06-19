# HR_Applicant_Process_Windows_Application

HR Applicant Process Windows System

This system allows applicants to register freely as well as find a job; meanwhile, HR can create job opportunities for the applicants. 


Project Overview:

Applicants - Applicants are allowed to search and apply for a job
HR admin - Admin is able to create, open, and close a job as well as have the final hiring decision. 
HR Staff - HR Staff will handle screening, schedule interview, and as well as evaluate the interview.

Technologies used:
IDE: VS community
programming framework: c# windows forms
database: MySQL
database connector: MySQL.data
documentation: GitHub 

Features:


Applicant side:
Applicant dashboard - This is where the applicant is welcomed, and you will be able to see current status, missing documents, interview schedule, and recent updates.
My Profile - Applicants need to fill out this form first before getting access to other forms such as Job vacancy, my application, and etc.
Job Vacancy -  Applicants can search, and look for jobs that are fit for their qualifications.
My Application - Applicants can submit their requirements.
My Documents - Applicants can tell the HR side that they have passed the specific requirement.
Application Status - Applicants can view their status.

HR Staff side:
HR Dashboard - staff will be welcomed here and as well as see how many applicants are registered, and hired.
Applicant List - Staffs can search applicants.
Applicant Review - Staffs can see applicants and mark their documents as “under review”.
Screening - Staff can select applicant, decide whether qualified or not, and put their remarks.
Interview schedule - Staff can decide where and when the applicant will be interviewed.
Interview evaluation - Staff will be able to evaluate the applicant wether the applicant passed or not.

HR Admin side:
Manage Job Vacancies - Admin can create a job and decide if the job is open or closed.
Maintenance Module - Admin can create a reusable values that will be used for job vacancies.
Hiring Decisions - Admin will be able to decide wether if the applicant should be hired or not.
Reports - Admin can create a report.

Contributors:
Amancio, Kalel - Applicant Documents Page Form, HR Applicant Review Form, Screening Module Form 
De Dios, Niño - Applicant Registration and Login Module Forms, HR Login and Role Management Forms 
Dela Rosa, Rovi - Modules / Responsibilities  
Database Design & Management  
Database Connection  
Application Status History  
Audit Trail  
GitHub Repository Management  
Module Integration  
System Testing  
Bug Fixes / QA 
Forms  
ApplicationStatusForm  
AuditTrailForm (optional viewer if needed) 
Estinopo, Bless -  Applicant Dashboard Form, Applicant Profile Page Form
Frias, Lawrence - Job Vacancy Management Form, Interview Scheduling Form, Interview Evaluation Form, Final Hiring Decision Form, Reports Module Form, Maintenance Module Form 
Vistar, Miguela - Job Vacancies Page Form, My Application Page Form

AI Usage:
Amancio -
De Dios - The A.I Usage is mostly used to guide to connect my code to the database especially I have no prior knowledge and debugging. Prompts “How can I append into the database” “How can I match the values from the database using the specific table”

Dela Rosa -
I used ChatGPT for assistance of, "How will I analyze and validate the application status flow which is status transition from submission, screening, interview, evaluation, and final hiring decision. "

How AI helped ME:

- reviewed the relationship between the mentioned modules.

- identify missing validations and debug.

- helped ensure the recruitment stages transition correctly based on the given requirements. 

Frias - I used AI to learn how to connect MySQL to my code in Visual Studio Community 2026 WinForms and how to access the tables in my database. I also used AI to help me fix some of the errors I encountered while coding.

Prompts used:
"How to connect MySQL to my code in Visual Studio Community 2026 WinForms?"
"How to access tables in MySQL into Visual Studio Community?"
"Can you help me fix this error? *provide error message"

How AI helped me:
AI helped me by explaining the steps for connecting my project to MySQL, accessing database tables, and troubleshooting errors. The explanations and suggestions helped me understand the process and continue working on my project.


Estinopo -


Vistar- AI Usage: 

I used AI to guide me in structuring my Job Vacancies and My Application page, fixing MySQL database connection errors, and handling application status controls like draft, submitted, and withdrawn.

What Prompt Did I Use:

* How do I connect a VS Code project to a MySQL database?
* How do I implement application statuses like Draft, Submitted, and Withdrawn in a simple HR system?
* How do I safely update and log application status changes in MySQL?

What I Improved after using Ai?

The AI helped me clean up my code. It also guided me on how to lock applications and handle application status controls, which helped me understand how the system works and how to fix errors in my code.

