create database agendamento_consultas;

create table animal(
	id int primary key not null auto_increment,
    nome varchar(50),
    raça varchar(20),
    codigo int(4),
    nascimento date
);

create table veterinario(
	id int primary key not null auto_increment,
    cpf char(11),
    nome varchar(50),
    registro varchar(50),
    nascimento date
);

create table agendamento(
	id int primary key not null auto_increment,
    data_hora datetime,
    codigo int(4),
    codigoAnimal int(4),
    cpfVeterinario int(11),
    foreign key (codigoAnimal) references animal (codigo),
    foreign key (cpfVeterinario) references veterinario (cpf)
);

delimiter $$
create trigger deletaAgendamento_Animal 
after delete on animal
for each row begin
delete from agendamento where codigoAnimal = old.codigo;
end$$

create trigger deletaAgendamento_Veterinario
after delete on veterinario
for each row begin
delete from agendamento where cpfVeterinario = old.cpf;
end$$

delimiter $$