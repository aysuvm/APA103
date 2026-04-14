create database Company;
use Company;

create table Employees(
EmployeeID INT,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    HireDate DATE,
    JobTitle NVARCHAR(50),
    Salary DECIMAL(10,2),
    Department NVARCHAR(50)
);

INSERT INTO Employees (EmployeeID, Firstname,LastName, Email, PhoneNumber, HireDate, JobTitle, Salary, Department)
VALUES
(1,'Aysu', 'Məmmtiyeva', 'aysu@company.az', '0501112233', '2021-05-10', 'Developer', 2500, 'IT project manager'),
(2,'Leyla', 'Həsənova', 'leyla@company.az', '0512223344', '2019-03-15', 'HR', 1800, 'HR'),
(3,'Kamal', 'Əliyev', 'kamal@company.az', '0553334455', '2022-07-20', 'Analyst', 2200, 'Finance'),
(4,'Nigar', 'Quliyeva', 'nigar@company.az', '0704445566', '2018-01-25', 'Manager', 3000, 'Management'),
(5,'Bəylər', 'Rzayev', 'orxan@company.az', '0775556677', '2023-09-01', 'Support', 1400, 'IT');




select*  from  Employees;

select * from Employees where Salary>2000;

select * from Employees where Department = 'IT';

select * from Employees
order by salary DESC;

select Salary,Firstname from Employees;

select*from Employees  where HireDate>'2021-01-01';

select * from Employees where Email LIKE '%company.az%';

select MAX (Salary) from Employees;
select AVG(Salary)  from Employees;

select MIN(Salary) from Employees;

select  COUNT(*) from Employees;

select SUM(Salary) from Employees;

Select Department,COUNT(*) AS EmployeeCount
from Employees
Group by Department;

Select Department,AVG(Salary) AS Salary
from Employees
Group by Department;

Select Department,MAX(Salary)AS Salary
from Employees
Group by Department;

UPDATE Employees SET
Salary = 2800
where EmployeeID = 1;

UPDATE Employees 
SET Salary = Salary *1.10
where Department = 'IT';

UPDATE Employees
SET Department ='HR manager'
where Department ='HR';

DELETE FROM Employees WHERE EmployeeID = 5;
Delete from Employees where Salary<1500;

Select * from Employees where FirstName LIKE '%a%';

SELECT*from Employees where Salary BETWEEN 2000 and 2500;
select*from Employees where Department IN ('Finance' ,'IT');
