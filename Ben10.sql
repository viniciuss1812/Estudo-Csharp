CREATE DATABASE Ben10;
go
use Ben10;

create table episodios 
(
episodio varchar (100),
id_numero int primary key,

)

insert into episodios (id_numero, episodio) values (1, 'E Ent�o Eram 10')
insert into episodios (id_numero, episodio) values (2, ' Washington A.C.')
insert into episodios (id_numero, episodio) values (3, 'O Krakken')
insert into episodios (id_numero, episodio) values (4, 'Aposentadoria Permanente')
insert into episodios (id_numero, episodio) values (5, 'Ca�ado')
insert into episodios (id_numero, episodio) values (6, 'O Pega Turista')
insert into episodios (id_numero, episodio) values (7, 'Kevin 11')
insert into episodios (id_numero, episodio) values (8, ' A Alian�a')
insert into episodios (id_numero, episodio) values (9, ' A �ltima Risada')
insert into episodios (id_numero, episodio) values (10, 'Sorteada')
insert into episodios (id_numero, episodio) values (11, 'Um Probleminha')
insert into episodios (id_numero, episodio) values (12, ' Efeitos Colaterais')
insert into episodios (id_numero, episodio) values (13, ' Segredos')


select * from episodios;
alter table episodios add imagem varbinary(max);
--alter table episodios add imagem1 image;


--  Washington A.C., O Krakken, Aposentadoria Permanente, Ca�ado, O Pega Turista, Kevin 11, A Alian�a, A �ltima Risada, Sorteada, Um Probleminha, Efeitos Colaterais, Segredos