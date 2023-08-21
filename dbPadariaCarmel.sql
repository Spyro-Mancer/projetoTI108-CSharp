-- apagando banco de dados
drop database dbPadariaCarmel;
-- criando banco de dados
create database dbPadariaCarmel;
-- acessando banco de dados
use dbPadariaCarmel;
-- criando as tabelas
create table tbFuncionarios(
codFunc int not null auto_increment,
nome varchar(100),
email varchar(100),
telCel char(15),
cpf char(14) unique,
endereco varchar(100),
numero varchar(10),
bairro varchar(100),
cidade varchar(100),
estado char(2),
cep char(9),
primary key(codFunc)
);

create table tbUsuarios(
codUsu int not null auto_increment,
nome varchar(50) not null,
senha varchar(14) not null,
codFunc int not null,
primary key(codUsu),
foreign key(codFunc) references tbFuncionarios(codFunc)
);

insert into tbFuncionarios(nome,email,telCel,cpf,endereco,numero,bairro,cidade,estado,cep) values('Willian Brito','willianhenriquevb@gmail.com','(11) 95824-7859','403.180.848-80','Av. João Caiaffa','40','Vila Sônia','São Paulo','SP','05742-100');

insert into tbUsuarios(nome,senha,codFunc) values('Willian','Locaweb@102030',1);

desc tbFuncionarios;
select * from tbFuncionarios;

-- pesquisa por código
select nome from tbFuncionarios where codFunc = 1;

-- pesquisa por nome
select nome from tbFuncionarios where nome like '%a%';

select * from tbFuncionarios where like '%" + nome + "%'

-- alterar funcionario
-- update tbFuncionarios set nome = @nome,email = @email,telCel = @telCel,cpf = @cpf,endereco = @endereco,numero = @numero,bairro = @bairro,cidade = @cidade,cep = @cep where codFunc = @codFunc;

-- excluir funcionario
-- delete from tbFuncionarios where codFunc = 1;

-- buscar usuario e senha se existir
select * from tbUsuarios where nome = 'Willian' and senha = 'Locawe@102030'