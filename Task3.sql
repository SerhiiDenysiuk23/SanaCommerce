create database sanaTask
use sanaTask


create table task_plan (
	Id int primary key identity,
	"Text" varchar(45) not null,
	Deadline datetime,
	Complete bit,
	Category varchar
)