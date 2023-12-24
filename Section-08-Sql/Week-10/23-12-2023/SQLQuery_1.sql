use master
GO

drop database if exists MoviesDB
GO

CREATE DATABASE MoviesDB
go

USE MoviesDB
go

CREATE TABLE Categories(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    IsActive bit DEFAULT 1 not null,
    CreatedDate datetime DEFAULT GETDATE() not null
)
go

CREATE TABLE Directors(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Gender bit not null,
    Age SMALLINT,
    IsActive bit DEFAULT 1 not null
)
go

CREATE TABLE Films(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    IsActive bit DEFAULT 1 not null,
    CreatedDate datetime DEFAULT GETDATE() not null,
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
    DirectorId INT FOREIGN KEY REFERENCES Directors(Id)
)

go

create TABLE Stars(
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) not null,
    LastName NVARCHAR(50) not null,
    Age SMALLINT,
    Gender bit not null,
    IsActive bit DEFAULT 1 not null,
    CreatedDate DATETIME DEFAULT getdate()not null
)
go

CREATE table FilmsStars(
    StarId int FOREIGN key REFERENCES Stars(Id),
    FilmId int FOREIGN key REFERENCES Films(Id),
    CONSTRAINT [PK_FilmStars] PRIMARY key CLUSTERED(
        StarId, FilmId
    ) on [PRIMARY]
)
GO

INSERT into Categories(Name) VALUES
('Komedi'),
('Korku'),
('Macera')
go

INSERT into Directors(Name, Gender) VALUES
('Ferzan',1),
('Kemal',0),
('Suzan',1),
('Cemal',0),
('Zeynep',1),
('Baransel',0)
go

INSERT into Films(Name, CategoryId,DirectorId) VALUES
('interstellar',1,1),
('cilgin dersane',1,3),
('olumlu dunya',1,4),
('cinayet susu',1,2),
('yuzuklerin efendisi',2,3),
('kaybedenler',3,2),
('Ferzan',2,5),
('Ferzan',2,6)
go

INSERT into Stars(FirstName,LastName, Gender) VALUES
('Ali','Basal',1),
('Sezen','Can',1),
('Kamil','Tas',1),
('Yunus','Canatan',1),
('Ozgur','Kaya',1)
go

INSERT into FilmsStars VALUES
(1,1),(1,4),(1,7),(1,4),(1,8),
(2,4),(2,3),(2,1),
(3,4),
(4,6),(4,4),(4,2),
(5,1),(5,7),(5,8),(5,2),(5,5),
(6,1),(6,6)
go