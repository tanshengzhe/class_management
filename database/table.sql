--CREATE DATABASE classmanage_Library
USE classmanage_Library

-- If the tables exist, delete them
IF OBJECT_ID('appointment ', 'U') IS NOT NULL
	DROP TABLE appointment;
IF OBJECT_ID('teacher', 'U') IS NOT NULL
	DROP TABLE teacher;
IF OBJECT_ID('class ', 'U') IS NOT NULL
	DROP TABLE class;
GO

create table appointment     --Ô¤Ô¼±í
(
	--app_id			varchar(20),
	week			varchar(20),
	day				varchar(20),
	classtime		varchar(20),
	class_id			varchar(20),
	class_name		varchar(20),
	teacher_id		varchar(20),
	teacher_name		varchar(10),
	enable			int,
	primary key (week,day,classtime)
);

create table class
(
	class_id		varchar(20),
	class_name		varchar(20),
	teacher_name	varchar(10),
	std_quatity		int,
	primary key (class_id)
);

create table teacher
(
	teacher_id		varchar(20),
	teacher_name	varchar(10),
	teacher_password		int,
	primary key (teacher_id)
);
