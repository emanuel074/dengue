Create database bancodengue;

use bancodengue;

create table cadastroAgente
(
codigoAgente int(11)  AUTO_INCREMENT ,

nomeProfissional varchar(50) not null,

idade int(3) not null,

cpf varchar(15) not null,

n_identidade varchar(9) null,

DataNascimentoProfissional varchar(10) null,

email varchar(30) not null,

sexo varchar(1)  null,

estadoCivil varchar(15) not null,

endereçoProfissional varchar(50),

bairroProfissional varchar(50),

N_residencia varchar(50),

municipio varchar(20) not null,

estado varchar(2) not null,

telefone varchar(15) not null,

celular varchar(16) not null,

primary key (codigoAgente));



create table Agendamento
(

Codigo varchar(11) not null ,

Nome varchar(40) not null,

Bairro varchar(255) not null,

Data_Visita varchar (10)not null,

Periodo varchar(15) not null,

Grupo varchar(25),

primary key (Codigo));




create table cadastro_unidade
(
id_filial int not null AUTO_INCREMENT, /* inserir o CNPJ/CEI */

cnpj varchar(20) not null,

nome_Fantasia varchar(50),/* Nome Fantasia do Estab/Razão social do estabelecimento */

Codigo_uf varchar(50) null,/* Código da UF ou município da Secretaria de Saúde em que é lotado */

endereco_filial varchar(50),

bairro_filial varchar(50),

N_filial varchar(50),

cep varchar(50) not null,

municipio_filial varchar(20) not null,

estado_filial varchar(20) not null,

tel_filial varchar(50) null,

email_filial varchar(40) not null,

primary key (id_filial));



create table login
(
id int(3) not null auto_increment,

usuario varchar(255) not null,

senha varchar(255) not null,

primary key (id));