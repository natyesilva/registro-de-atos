-- Nascimento
-- Data do Registro
--  Data de Nascimento
--   Nome do Registrado 
--   Nome do Pai
-- Nome da Mãe
-- Data de Nascimento do Pai
--  Data de Nascimento da Mãe 
--  CPF do Pai
-- CPF da Mãe
create database registro;
create table nascimento(
    id int(12) NOT NULL AUTO_INCREMENT,
    data_registro date NOT NULL,
    data_nascimento date NOT NULL,
    nome_registro varchar(255) NOT NULL,
    nome_pai varchar(255),
    nome_mae varchar(255) NOT NULL,
    data_nascimento_pai date,
    data_nascimento_mae date NOT NULL,
    cpf_pai varchar(16),
    cpf_mae varchar(16) NOT NULL,
    PRIMARY KEY (id)
)
-----casamento
-- Data do Registro
-- Data do Casamento 
------Cônjuge 1
-- Data de Nascimento Nome
-- CPF
-- Nome do Pai Nome da Mãe
-- Data de Nascimento do Pai 
-- Data de Nascimento da Mãe CPF do Pai
-- CPF da Mãe
-- Cônjuge 2
-- Mesmos dados do cônjuge 1
create table casamento(
    id int(12) NOT NULL AUTO_INCREMENT,
    data_registro date NOT NULL,
    data_casamento date NOT NULL,
    conjuge_um varchar(255) NOT NULL,
    conjuge_dois varchar(255) NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (conjuge_um) REFERENCES conjuge(cpf),
    FOREIGN KEY (conjuge_dois) REFERENCES conjuge(cpf)
)
create table conjuge(
    cpf varchar(16) NOT NULL,
    nome varchar(255) NOT NULL,
    data_nascimento date NOT NULL,
    nome_pai varchar(255),
    nome_mae varchar(255) NOT NULL,
    data_nascimento_pai date,
    data_nascimento_mae date NOT NULL,
    cpf_pai varchar(16),
    cpf_mae varchar(16) NOT NULL,
    PRIMARY KEY (cpf)
)
--obito
-- Data do Registro
--  Data do óbito
--   Nome do Falecido
--    Data de Nascimento
--     Nome do Pai
-- Nome da Mãe
-- Data de Nascimento do Pai
--  Data de Nascimento da Mãe
create table obito(
    id int(12) NOT NULL AUTO_INCREMENT,
    data_registro date NOT NULL,
    data_obito date NOT NULL,
    nome_falecido varchar(255) NOT NULL,
    data_nascimento date NOT NULL,
    nome_pai varchar(255),
    nome_mae varchar(255) NOT NULL,
    data_nascimento_pai date,
    data_nascimento_mae date NOT NULL,
    PRIMARY KEY(id)

)