create table cadastro_cliente (
	id_cliente int not null auto_increment, 
    nome_cliente varchar(30) not null,
    nasc_cliente date not null,
    email_cliente varchar(50) not null,
    senha_cliente varchar(15) not null,
    cpf_cliente varchar(20) not null,
    endereco_cliente varchar(30) not null,
    numEnd_cliente varchar(10) not null,
    tel_cliente varchar (15) not null,
    primary key (id_cliente)
) default charset = utf8;
 
 create table cadastro_profissional (
 	id_profissional int not null auto_increment,
    id_cliente int not null,
    nome_profissional varchar(30) not null,
    nasc_profissional date not null,
    email_profissional varchar(50) not null,
    senha_profissional varchar(15) not null,
    cpf_profissional varchar(20) not null,
    endereco_profissional varchar(30) not null,
    numEnd_profissional varchar(10) not null,
    tel_profissional varchar (15) not null,
    primary key (id_profissional)
) default charset = utf8;

 create table servico (
 	profissao varchar(30) not null,
    especializacao varchar(30) not null,
    descricao varchar(30) not null
) default charset = utf8;