 CREATE DATABASE EmployeeDB

 USE EmployeeDB

CREATE TABLE Department(
	DepartmentId INT IDENTITY(1,1),
	DepartmentName VARCHAR(500)
)

CREATE TABLE Employee(
	EmployeeId INT IDENTITY(1,1),
	EmployeeName VARCHAR(500),
	Department VARCHAR(500),
	DateOfJoining DATE,
	PhotoFileName VARCHAR(500)
)

select * from Department
select * from Employee

insert into Department values ('IT'), ('Support'), ('Sales')
insert into Employee values ('John Smith', 'IT', '2021-09-01', 'anonymous.png'), ('Jane Monet', 'Support', '2020-05-20', 'anonymous.png')

select * from Department
select * from Employee