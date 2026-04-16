create database Company
use Company

create table Countries(
Id int primary key identity,
name nvarchar(50)
);

create table Cities (
Id int primary key identity,
name nvarchar(50),
CountryId int,
foreign key (CountryId) references Countries(Id)
);

create table Employees(
Id int primary key identity,
name nvarchar(50),
Salary money,
Surname nvarchar,
Age int,
Position nvarchar(50),
IsDeleted BIT,
CityId INT,
Foreign key (CityId)references Cities(Id)
);

INSERT INTO Countries (Name)
VALUES 
('Azerbaijan'),
('Turkey'),
('Germany');

INSERT INTO Cities (Name, CountryId)
VALUES 
('Baku', 1),
('Ganja', 1),
('Istanbul', 2),
('Ankara', 2),
('Berlin', 3);

INSERT INTO Employees (Name, Surname, Age, Salary, Position, IsDeleted, CityId)
VALUES 
('Aysu', 'Məmtiyeva', 20, 2500, 'IT Project Manager', 0, 1),
('Leyla', 'Həsənova', 25, 1800, 'Reception', 0, 2),
('Murad', 'Aliyev', 30, 3000, 'Manager', 0, 3),
('Nigar', 'Quliyeva', 28, 2200, 'Reception', 1, 4),
('Samir', 'Hüseynov', 35, 4000, 'CEO', 0, 5);

select e.Name,c.Name AS City, co.name AS Country
From Employees e
Join Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id;

select e.Name,c.Name AS Country 
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
Where e.Salary>2000;

select c.name AS City,co.name AS Country
From Cities c
Join Countries co ON c.CountryId = co.Id;

select Name,Surname,Age,Salary ,Position ,IsDeleted,CityId FROM Employees
Where position ='Reception';

select e.Name,e.Surname, c.Name AS City
From Employees e
Join Cities c On e.CityId = c.Id
where e.IsDeleted = 1;