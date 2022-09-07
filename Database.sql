create database EmpPayRol

use EmpPayRol

create table EmpDetail(
Id int Primary Key Identity (1,1),
Name varchar (200),
Salary varchar(150),
StartDate date,
Gender varchar(1),
ContactNumber varchar(10),
Address varchar(50),
Pay int,
Deduction int,
Texable int,
IncomeTax int,
NetPay int
)

select * from EmpDetail