create database TicketSystem;
use TicketSystem;

create table Users(
UserId int auto_increment primary key,
Username varchar(50),
Password varchar(50),
Role varchar(10)

);

 insert into Users values 
 (1,'srinu','123','user'),
 (2,'venu','143','admin');
 
 select * from Users;

create table Tickets
(
TicketId int auto_increment primary key,
TicketNumber varchar(50),
Subject varchar (100),
Description text,
Priority varchar(50),
Status varchar(50),
CreatedDate datetime,
CreatedBy int,
AssignedTo int
);

select * from Tickets;

create table TicketComments
(
CommentId int auto_increment primary key,
TicketId int,
Comment text,
CommentedBy varchar(100),
CommentDate datetime
);
 
 select * from TicketComments;
 
 create table TicketStatusHistory
 (
  HistoryId int auto_increment primary key,
  TicketId int,
  OldStatus varchar(50),
  NewStatus varchar(50),
  UpdatedBy varchar(50),
  UpdatedDate datetime
 );
 
 select * from TicketStatusHistory;
 
 
 
 
 
 