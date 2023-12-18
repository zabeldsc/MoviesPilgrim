-- Active: 1700955922591@@127.0.0.1@3306@locadora
USE LOCADORA;

/* INSERTS */
INSERT INTO `locadora`.`tbendereco` (`CEP`, `endereco`, `numero`, `bairro`, `cidade`, `estado`, `pais`) 
VALUES ('45632-650', 'Rua dos Jardineiros', '22', 'Hiberin', 'Guandi', 'RE', 'Angola'),
('56899-780', 'Rua dos Talismãs', '12', 'Pituba', 'Salvador', 'BA', 'Brasil'),
('15935-741', 'Avenida Liomar Segundo', '9', 'Rio Vermelho', 'Salvador', 'BA', 'Brasil'),
('35785-685', 'Avenida Jefferson Salgueiro', '22', 'Mussurunga', 'Salvador', 'BA', 'Brasil'),
('35795-850', 'Rua Pastor Aldemar Santos', '35', 'Pitangas', 'Feira de Santana', 'BA', 'Brasil'),
('65423-556', 'Rua Miguel Lancelo Dutra', '40', 'Pitangas', 'Feira de Santana', 'BA', 'Brasil'),
('78423-855', 'Rua Vereador Pascal Lima', '22', 'Limoeiro', 'Feira de Santana', 'BA', 'Brasil'),
('12345-678', 'Rua das Flores', '123', 'Centro', 'São Paulo', 'SP', 'Brasil'),
('98765-432', 'Avenida dos Pássaros', '456', 'Copacabana', 'Rio de Janeiro', 'RJ', 'Brasil'),
('54321-876', 'Alameda das Árvores', '789', 'Copacabana', 'Rio de Janeiro', 'RJ', 'Brasil');


INSERT INTO
    tbclientes(
        nome,
        CPF,
        email,
        telefone,
        fk_id_endereco
    )
VALUES (
        "João Neto",
        "45230585",
        "joaoneto2023@gmail.com",
        "(71)98885-6563",
        2
    ), (
        "Maria Barbosa",
        "30250275",
        "mariabarbosa2023@gmail.com",
        "(71)98877-6563",
        3
    ), (
        "Juarez Fernandes",
        "60230295",
        "juarezfernandes2023@gmail.com",
        "(71)98888-7777",
        4
    );

INSERT INTO
    tbfilme (
        titulo,
        sinopse,
        quantidade,
        valor_filme,
        taxa_dia,
        classificacao,
        genero
    )
VALUES
(
        'Carros 2',
        'Um carro de corrida muito louco',
        '10',
        '15.00',
        '5.80',
        '10',
        'Infantil'
    ), (
        'Panico 5',
        'homem que mata muita gente por puro prazer ',
        '20',
        '15.50',
        '6.10',
        '18',
        'Terror'
    ), (
        'Indiana Jones 2',
        'Um aventureiro curioso leva seus amigos para uma nova descoberta',
        '25',
        '25.50',
        '3.90',
        '14',
        'Aventura'
    ),
(
'Harry Potter e A Pedra Filosofal',
'Harry Potter descobre que é um bruxo e ingressa na Escola de Magia e Bruxaria de Hogwarts.',
 30, 
 24.90, 
 2.80, 
 'Livre', 
 'Fantasia'),
('Harry Potter and the Goblet of Fire',
 'Harry é selecionado inesperadamente para competir no Torneio Tribruxo',
 20,
 24.90,
 2.80,
 12, 
 'Fantasia'),
( 'Harry Potter and the Order of the Phoenix',
 'Harry enfrenta a indiferença do Ministério da Magia e forma a Ordem da Fênix para enfrentar o retorno de Lord Voldemort.', 
 '20',
 '24.90',
 '2.80',
 '12',
 'Fantasia'),
( 'Harry Potter and the Half-Blood Prince',
 'Harry descobre segredos sobre o passado de Voldemort enquanto Hogwarts se prepara para a batalha iminente entre as forças do bem e do mal.',
 '20',
 '24.90',
 '2.80',
 '10',
 'Fantasia');

INSERT INTO
    tblocacoes(
        data_locacao,
        fk_id_cliente,
        fk_id_filme
    )
VALUES 
	(current_timestamp(),2, 1), 
	(current_timestamp(),1, 2), 
	(current_timestamp(),2, 3),
	(current_timestamp(),3, 4);

INSERT INTO
	tbitenslocacao(fk_id_locacao,quantidade_filme)
    VALUES
    (1,2),
    (1,4),
    (2,8),
    (2,6),
    (3,5),
    (4,4);


-- ATRASADOS

INSERT INTO `locadora`.`tblocacoes` (`fk_id_cliente`, `fk_id_filme`, `data_locacao`, `data_limite`, `status_locacao`) 
VALUES 
('2', '4', '2023-12-18 13:34:07', '2023-12-28 13:34:07', 'Atrasado'),
('1', '5', '2023-12-18 13:34:07', '2023-12-28 13:34:07', 'Atrasado'),
('3', '2', '2023-12-18 13:34:07', '2023-12-28 13:34:07', 'Atrasado'),
('1', '5', '2023-12-18 13:34:07', '2023-12-28 13:34:07', 'Atrasado'),
('2', '3', '2023-12-18 13:34:07', '2023-12-28 13:34:07', 'Atrasado');

-- DEVOLVIDOS




