create database CompanyMM;
USE CompanyMM;

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1)PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100) UNIQUE,
    BirthDate Date Check  (BirthDate < '2007-01-01'),
);

CREATE TABLE Projects (
    ProjectID INT IDENTITY(1,1)  PRIMARY KEY,
    ProjectName VARCHAR(100),
    StartDate DATE,
    EndDate DATE,
    CHECK (EndDate >= StartDate)
);

CREATE TABLE EmployeeProjects (
    EmployeeID INT,
    ProjectID INT,
    AssignedDate DATE,
    PRIMARY KEY (EmployeeID, ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
);

INSERT INTO Employees (FirstName, LastName, BirthDate, Email) VALUES
('Aydin', 'Mammadov', '1995-05-10', 'aydin@mail.com'),
('Aysel', 'Aliyeva', '2000-08-15', 'aysel@mail.com'),
('Nigar', 'Hasanova', '1998-03-22', 'nigar@mail.com'),
('Orxan', 'Quliyev', '1992-11-30', 'orxan@mail.com'),
('Lala', 'Kerimova', '1997-07-19', 'lala@mail.com');


INSERT INTO Projects (ProjectName, StartDate, EndDate) VALUES
('Website Development', '2024-01-01', '2024-06-01'),
('Mobile App', '2024-02-01', '2024-07-01'),
('AI System', '2024-03-01', '2024-12-01');


INSERT INTO EmployeeProjects (EmployeeID, ProjectID) VALUES
(1,1),(1,2),
(2,1),(2,3),
(3,2),
(4,1),(4,2),(4,3),
(5,3);


SELECT * FROM Employees;


SELECT * FROM Projects;


SELECT e.EmployeeID, e.FirstName, e.LastName, p.ProjectName
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;


SELECT p.ProjectName, COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectID;


SELECT e.EmployeeID, e.FirstName, COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID
HAVING COUNT(ep.ProjectID) > 2;

CREATE VIEW EmployeeProjectView AS
SELECT 
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    p.ProjectID,
    p.ProjectName,
    ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;


SELECT * FROM EmployeeProjectView
WHERE EmployeeID = 1;

CREATE PROCEDURE sp_AssignEmployeeToProject(IN empId INT, IN projId INT)
BEGIN
    IF NOT EXISTS (
        SELECT * FROM EmployeeProjects 
        WHERE EmployeeID = empId AND ProjectID = projId
    ) THEN
        INSERT INTO EmployeeProjects(EmployeeID, ProjectID)
        VALUES (empId, projId);
    END IF;
END ;



CREATE FUNCTION fn_GetProjectCount(empId INT)
RETURNS INT
BEGIN
    DECLARE total INT;
    
    SELECT COUNT(*) INTO total
    FROM EmployeeProjects
    WHERE EmployeeID = empId;
    
    RETURN total;
END

