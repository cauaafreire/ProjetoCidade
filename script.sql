-- CRIANDO O BANCO DE DADOS
CREATE DATABASE BDProjeto;

-- USANDO BANCO DE DADOS 
USE BDProjeto;

-- CRIANDO AS TABELAS DO BANCO DE DADOS 
CREATE TABLE tbPedido (
	CodPedido int primary key auto_increment,
	tipoCarro Varchar(50),
    valorCarro Varchar(50),
    valorAcessorios Varchar(50),
    valorTotal Varchar(50)
)

-- CONSULTANDO A TABELA DO BANCO DE DADOS 
SELECT * FROM tbPedido;