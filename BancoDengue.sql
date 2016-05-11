Create database bancoDengue;


use bancoDengue;


create table fichavisita
(
id_ficha int NOT NULL AUTO_INCREMENT,

nome_agente varchar(100) not null ,
cod_agente int (10) not null,
equipe varchar(10) not null,
data_visita varchar(9) not null,
horario_visita varchar(6)  not null,
nome_morador varchar(50) not null  ,
estado varchar(5) not null,
cidade varchar(20) not null,
bairro varchar(20) not null,
rua varchar(20) not null,
complemento varchar(15) not null,
num_casa int (5) not null,
atividades varchar(255) not null,
situacao_imovel varchar(15) not null,
motivo_visita varchar(15) not null,
primary key (id_ficha)) ;


create table registrodefocos
(
id_focos int NOT NULL AUTO_INCREMENT,
nome_agente varchar(100) not null ,
cod_agente int(10) not null,
equipe varchar(10) not null,
nome_morador varchar(20) not null ,
estado varchar(10) not null,
cidade varchar(20) not null,
rua varchar(40) not null,
num_casa int(4) null,
data_visita varchar(20),
local_Visita varchar (15),
quantidade_focosAgua int(4) not null,
quantidade_criadouros int(4) not null,
local_tem_entulho varchar(15) not null,
tipofocos1 varchar(20) not null,
num_focos1 int(4) null,
tipofocos2 varchar(20) not null,
num_focos2  int(4) null,
tipofocos3 varchar(20) not null,
num_focos3  int(4) null,
situacao_imovel varchar(40) not null,
primary key (id_focos));


create table questionario
(
id_quest int NOT NULL AUTO_INCREMENT,
perguntas varchar(255) not null,
respostas varchar(255) not null,
primary key (id_quest));




create table cadastroAgente

(
nomeProfissional varchar(50) not null,
codigoAgente int(4) NOT NULL AUTO_INCREMENT,
equipe varchar(10) not null,
idade int(2) not null,
cpf varchar(15) not null,
n_identidade int(9) null,
DataNascimentoProfissional varchar(10) null,
email varchar(30) not null,
sexo varchar(1)  null,
estadoCivil varchar(15) not null,
endereçoProfissional varchar(50),
municipio varchar(20) not null,
estado varchar(2) not null,
telefone varchar(15) not null,
primary key (codigoAgente));


create table agendamentos

(
id_agendamentos int not null AUTO_INCREMENT,
Codigo varchar(50) not null,
Nome varchar(30) not null,
Bairro varchar(10) not null,
Data_Visita varchar (10)not null,
Periodo varchar(15) not null,
equipe varchar(10) not null,
primary key (id_agendamentos));


create table cadastro_unidade
(
id_filial int not null AUTO_INCREMENT, /* inserir o CNPJ/CEI */

cnpj varchar(20) not null,

nome_Fantasia varchar(50),/* Nome Fantasia do Estab/Razão social do estabelecimento */

Codigo_uf int null,/* Código da UF ou município da Secretaria de Saúde em que é lotado */

endereco_filial varchar(50),

cep int(8) not null,

municipio_filial varchar(20) not null,

estado_filial varchar(20) not null,

tel_filial int(11) null,

email_filial varchar(40) not null,

primary key (id_filial));





