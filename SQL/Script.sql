CREATE TABLE tags (
	tagId INT NOT NULL PRIMARY KEY Identity
	,tagName VARCHAR(12)
	,isActive INT
	)

go

CREATE TABLE technologies (
	technologyId INT NOT NULL PRIMARY KEY Identity
	,technologyName VARCHAR(15)
	,isActive INT
	);
go
CREATE TABLE contactPersons (
	contactPersonId INT NOT NULL PRIMARY KEY Identity
	,contactPersonName VARCHAR(20)
	,contactNumber DECIMAL(10, 0)
	,isActive TINYINT
	)
go

CREATE TABLE locations (
	locationId INT NOT NULL PRIMARY KEY Identity
	,locationName VARCHAR(15)
	,subLocationName VARCHAR(25)
	,isActive TINYINT
	)
go

CREATE TABLE companies (
	companyId INT NOT NULL primary key Identity
	,grade VARCHAR(15)
	,rounds TINYINT
	,tagId INT FOREIGN KEY REFERENCES tags(tagId)
	,AppliedDate DATETIME
	,responseDate DATETIME
	,packageMin TINYINT
	,packageMax TINYINT
	,locationId INT FOREIGN KEY REFERENCES locations(locationId)
	,condition VARCHAR(255)
	,response VARCHAR(255)
	,Scheduled TINYINT
	,interviewDAte DATETIME
	,isActive TINYINT
	,website VARCHAR(50)
	);
	Go
	insert into tags(tagName,isActive) values('Cancelled', 1);
	insert into tags(tagName,isActive) values('Scheduled', 1);
	insert into tags(tagName,isActive) values('Interviewed', 1);
	insert into tags(tagName,isActive) values('Rejected', 1);
	insert into tags(tagName,isActive) values('Backed Out', 1);
	insert into tags(tagName,isActive) values('Shortlisted', 1);
	insert into tags(tagName,isActive) values('HR pending', 1);
	insert into tags(tagName,isActive) values('offerPending', 1);
	go

	insert into technologies(technologyName, isActive) values('.Net',1)
	insert into technologies(technologyName, isActive) values('NodeJs',1)
	insert into technologies(technologyName, isActive) values('MVC',1)
	insert into technologies(technologyName, isActive) values('SQL Server',1)
	insert into technologies(technologyName, isActive) values('.Net core',1)
	insert into technologies(technologyName, isActive) values('JQuery',1)
	insert into technologies(technologyName, isActive) values('Web API',1)
	insert into technologies(technologyName, isActive) values('MVVM',1)
	insert into technologies(technologyName, isActive) values('Micro services',1)
	insert into technologies(technologyName, isActive) values('WCF services',1)
	go

	insert into locations(locationName, subLocationName, isActive) values ('Pune', 'Aundh',1)
	insert into locations(locationName, subLocationName, isActive) values ('Pune', 'Baner',1)
	insert into locations(locationName, subLocationName, isActive) values ('Pune', 'Viman Naagar',1)
	insert into locations(locationName, subLocationName, isActive) values ('Pune', 'Hinjewadi I',1)
	insert into locations(locationName, subLocationName, isActive) values ('Pune', 'Hinjewadi II',1)
	insert into locations(locationName, subLocationName, isActive) values ('Pune', 'Hinjewadi III',1)
	insert into locations(locationName, subLocationName, isActive) values ('Pune', 'Kharadi',1)
	go






