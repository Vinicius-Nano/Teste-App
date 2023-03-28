create database app_contato_bd;
use app_contato_bd;

create table contato (
con_id int not null auto_increment primary key,
con_nome varchar (200),
con_email varchar (200),
con_sexo varchar (100),
con_dataNasc date,
con_telefone varchar (100)
);

insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (1, 'Jacqui', 'jgrumble0@lycos.com', 'Female', '1983-11-08', '(489) 8244280');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (2, 'Garrot', 'gziemsen1@webnode.com', 'Male', '1984-09-23', '(913) 9893750');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (3, 'Selma', 'sdimitrov2@google.pl', 'Female', '1984-11-19', '(578) 2495013');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (4, 'Reynolds', 'redgworth3@forbes.com', 'Male', '1983-06-29', '(217) 6963291');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (5, 'Wittie', 'wmacrury4@google.co.uk', 'Male', '1983-08-27', '(785) 3276315');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (6, 'Cirstoforo', 'cchat5@blog.com', 'Male', '1995-05-04', '(120) 4267841');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (7, 'Alexandro', 'avines6@cdbaby.com', 'Male', '1984-03-07', '(148) 1156537');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (8, 'Kendal', 'kfavill7@constantcontact.com', 'Male', '1982-05-07', '(564) 3274138');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (9, 'Garner', 'glanglais8@quantcast.com', 'Male', '1987-06-24', '(722) 6520575');
insert into contato (con_id, con_nome, con_email, con_sexo, con_dataNasc, con_telefone) values (10, 'Marianne', 'mraikes9@ihg.com', 'Female', '1998-07-17', '(766) 3735098');

Select * from contato;