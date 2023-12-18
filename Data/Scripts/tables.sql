-- Active: 1700955922591@@127.0.0.1@3306@locadora
USE LOCADORA;
/* CREATE TABLES */
CREATE TABLE tbendereco(
	id_endereco INT auto_increment primary key,
    CEP varchar(9),
    endereco varchar(100),
    numero INT,
    bairro varchar(50),
    cidade varchar(25),
    estado varchar(2) default 'BA',
    pais varchar(20) default 'Brasil'
);

CREATE TABLE
    tbclientes (
        id_cliente INT AUTO_INCREMENT PRIMARY KEY,
        nome VARCHAR(50),
        CPF VARCHAR(14),
        email VARCHAR(60),
        telefone VARCHAR(20),
		fk_id_endereco INT,
        FOREIGN KEY (fk_id_endereco) references tbendereco(id_endereco)
    );

CREATE TABLE
    tbfilme (
        id_filme INT AUTO_INCREMENT PRIMARY KEY,
        titulo VARCHAR(100),
        sinopse VARCHAR(280),
        quantidade INT,
        valor_filme DECIMAL(10, 2),
        taxa_dia DECIMAL(10, 2),
        classificacao varchar(10),
        genero VARCHAR(50)
);

CREATE TABLE
    tblocacoes(
        id_locacao INT auto_increment PRIMARY KEY,
        fk_id_cliente INT,
        fk_id_filme INT,
        data_locacao DATETIME,
        data_limite DATETIME,
        status_locacao ENUM('Atrasado','Devolvido','Locando') DEFAULT 'Locando',
        total_locacao DECIMAL(10,2),
        FOREIGN KEY (fk_id_cliente) REFERENCES tbclientes (id_cliente),
        FOREIGN KEY (fk_id_filme) REFERENCES tbfilme (id_filme)
);

CREATE TABLE
    tbitenslocacao(
		id_item_locacao INT auto_increment PRIMARY KEY,
        fk_id_locacao INT,
        fk_id_filme INT,
        valor_filme DECIMAL(10,2),
        quantidade_filme INT,
        subtotal DECIMAL(10,2),
        FOREIGN KEY (fk_id_locacao) REFERENCES tblocacoes(id_locacao),
        FOREIGN KEY (fk_id_filme) REFERENCES tbfilme(id_filme)
    );