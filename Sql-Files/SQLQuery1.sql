--DDL
/*

*/


--create database
Create database Sample
--for slecting database
use Sample;
--create table table name (columns)
create table Names (ID int,Name varchar(2000))
--to see the data inside table
select * from Names
--to see only specific columns
select ID from Names

--insert data into tables
insert into Names values(1,'Vikash 1')
insert into Names values(2,'Vikash2')
insert into Names values(3,'Vikash3')
insert into Names values(4,'Vikash4')

--to update the data we have update command

update Names set Name='Vikash 1' 
--clauses where
update Names set Name='Vikash 2'  where ID=2;
--delete data from tables
delete Names where  ID=3;
--In clause
delete Names where  ID in (2,4)
--drop --remove something from schema
drop table Names;
--truncate --remove all data from table
truncate table Names;