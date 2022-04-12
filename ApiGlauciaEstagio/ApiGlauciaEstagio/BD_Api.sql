create database api_cliente;
use api_cliente;

CREATE TABLE Cliente(
Id integer primary key auto_increment,
Nome varchar(200),
Cidade varchar(200),
Idade integer

);

#INSERINDO DADOS NA TABELA:

insert into Cliente (Id, Nome, Cidade, Idade) values (1, "Glaucia", "Goiânia", 10);
insert into Cliente (Id, Nome, Cidade, Idade) values (2, "Joao", "Brasilia", 35);
insert into Cliente (Id, Nome, Cidade, Idade) values (3, "Ana", "Sao Paulo", 26);
insert into Cliente (Id, Nome, Cidade, Idade) values (4, "Henrique", "Parana", 55);



#EDITANDO DADOS NA TABELA:

update Cliente set Nome = "Paulo" where (Id = 1);
update Cliente set Idade = 18 where (Id = 4);


#REMOVENDO DADOS DA TABELA:

delete from Cliente where (Id = 2);



select*from Cliente;