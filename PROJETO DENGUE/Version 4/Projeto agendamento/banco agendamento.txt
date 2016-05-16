create database bdDengue;
use bdDengue;
create table Agendamento


(
Codigo varchar(50) not null,
Nome varchar(30) not null,
Bairro varchar(10) not null,
Data_Visita varchar (10)not null,
Periodo varchar(15) not null,
Grupo varchar(25),
primary key (Codigo));


drop table Agendamento;

select * from  Agendamento