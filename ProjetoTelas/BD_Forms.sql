create database api_cliente;
use api_cliente;

CREATE TABLE Cliente(
Nome varchar(200),
Sobrenome varchar(350),
Cpf varchar(13),
Endereco varchar(500),
Email varchar(150),
Telefone varchar(100),
TelRecado varchar(100),
Cidade varchar(200),
Idade integer

);


CREATE TABLE OutrasInfos(
Estado_Civil varchar(150),
Escolaridade varchar(185),
Rede_Social varchar(150)


);



select*from Cliente;
select*from OutrasInfos;