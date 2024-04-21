-- DROP DATABASE IF EXISTS gestaoformandos;

CREATE DATABASE mrpcbuilder_database;

USE mrpcbuilder_database;

CREATE TABLE employee (
	id_employee			INT AUTO_INCREMENT,
    name_employee		VARCHAR(100) NOT NULL,
    tax_id				INT(9) NOT NULL,
    position			VARCHAR(50) NOT NULL,
	email				VARCHAR(50) NOT NULL UNIQUE,
    PRIMARY KEY (id_employee)
);

CREATE TABLE users (
	id_user				INT AUTO_INCREMENT,
    username			VARCHAR(15) NOT NULL UNIQUE,
    user_password		VARCHAR(128) NOT NULL,
    fails				TINYINT DEFAULT 0 NOT NULL,
    user_status			ENUM('Active','Inactive') DEFAULT 'Active' NOT NULL,
	user_role			ENUM('Customer', 'Employee') DEFAULT 'Customer' NOT NULL,
	PRIMARY KEY (id_user)
);

CREATE TABLE customer (
	id_customer			INT AUTO_INCREMENT,
	id_user				INT NOT NULL,
    name_customer		VARCHAR(100) NOT NULL,
    address_customer	VARCHAR(150) NULL,
    phone_number		INT(9) NULL,
	email				VARCHAR(50) NOT NULL UNIQUE,
	tax_id				INT(9) NULL,
    PRIMARY KEY (id_customer),
	FOREIGN KEY (id_user) REFERENCES users (id_user)
		ON UPDATE CASCADE
);

CREATE TABLE manufacturer (
	id_manufacturer		INT AUTO_INCREMENT,
    name_manufacturer	VARCHAR(100) NOT NULL,
    phone_contact		INT(9) NULL,
	email				VARCHAR(50) NOT NULL UNIQUE,
    PRIMARY KEY (id_manufacturer)
);

CREATE TABLE pc_component (
	id_pc_component			INT AUTO_INCREMENT,
    type_component			VARCHAR(100) NOT NULL,
    name_component			VARCHAR(100) NOT NULL,
    description_component	VARCHAR(250) NOT NULL,
	id_manufacturer			INT NOT NULL,
	model					VARCHAR(100) NOT NULL,
	price					NUMERIC(5,2) NOT NULL,
    PRIMARY KEY (id_pc_component),
	FOREIGN KEY (id_manufacturer) REFERENCES manufacturer (id_manufacturer)
		ON UPDATE CASCADE
);

CREATE TABLE components (
	id_components		INT AUTO_INCREMENT,
    id_pc_component		INT NOT NULL,
    PRIMARY KEY (id_components),
	FOREIGN KEY (id_pc_component) REFERENCES pc_component (id_pc_component)
		ON UPDATE CASCADE
);

CREATE TABLE purchase (
	id_purchase			INT AUTO_INCREMENT,
    id_customer			INT NOT NULL,
	id_components		INT NOT NULL,
	quantity			INT NOT NULL,
	order_date			DATE NOT NULL,
	delivery_date		DATE NOT NULL,
    PRIMARY KEY (id_purchase),
	FOREIGN KEY (id_customer) REFERENCES customer (id_customer)
		ON UPDATE CASCADE,
	FOREIGN KEY (id_components) REFERENCES components (id_components)
		ON UPDATE CASCADE
);

CREATE TABLE build (
	id_build			INT AUTO_INCREMENT,
    id_employee			INT NOT NULL,
	id_purchase			INT NOT NULL,
	build_status		ENUM('Pending','In Progress','Completed') DEFAULT 'Pending' NOT NULL,
    PRIMARY KEY (id_build),
	FOREIGN KEY (id_employee) REFERENCES employee (id_employee)
		ON UPDATE CASCADE,
	FOREIGN KEY (id_purchase) REFERENCES purchase (id_purchase)
		ON UPDATE CASCADE
);

CREATE TABLE payment_method (
	id_payment_method	INT AUTO_INCREMENT,
    payment_method		VARCHAR(100) NOT NULL,
    PRIMARY KEY (id_payment_method)
);

CREATE TABLE receipt (
	id_receipt			INT AUTO_INCREMENT,
    id_purchase			INT NOT NULL,
	id_payment_method	INT NOT NULL,
	payment_status		ENUM('Pending','Completed','Failed','Refunded','Cancelled') DEFAULT 'Pending' NOT NULL,
    PRIMARY KEY (id_receipt),
	FOREIGN KEY (id_purchase) REFERENCES purchase (id_purchase)
		ON UPDATE CASCADE,
	FOREIGN KEY (id_payment_method) REFERENCES payment_method (id_payment_method)
		ON UPDATE CASCADE
);










































insert into formando values
(1,'Sérgio Conceição','Rua Principal',null,'0000','M','2000-10-13');
insert into formando values
(5,'Francisco Conceição','Rua Principal',null,'0000','M','2006-10-13');

select * from formando;

select max(id_formando) from formando;

select md5('1234');
select sha1('1234');
select sha2('1234',0);
select sha2('1234',224);
select sha2('1234',256);
select sha2('1234',384);
select sha2('1234',512);

select nome, sha2(nome,512) from formando;

create table users (
	uname			varchar(15) primary key,
	pwd				varchar(25) not null,
	userRole		varchar(25) not null
);

insert into users (uname, pwd, userRole) values
('user1','user1','Manager'),
('user2','user2','Admin'),
('user3','user3','User');

select * from users where binary uname = 'UsEr1' and binary pwd = 'user1'; -- binary torna o select case sensitive. sem o binary não é case sensitive.
select * from users where binary uname = 'user1' and binary pwd = 'user1';

select uname, pwd, sha2(pwd,512) from users;

alter table users modify column pwd varchar(128);

update users set pwd = sha2(pwd, 512);

select * from users where binary uname = 'user1';

select * from users where binary uname = 'user1' and pwd = sha2('user1',512);

insert into users (uname, pwd, userRole) values
('user4',sha2('user4',512),'Manager');

select * from users;

create table utilizador (
	id_utilizador		int auto_increment primary key,
    nome_utilizador		varchar(15) not null unique,
    palavra_passe		varchar(128) not null,
    falhas				tinyint default 0,
    estado				enum('A','I') default 'A'
);

insert into utilizador (nome_utilizador, palavra_passe) values
	('user1', sha2('user1',512)),
    ('user2', sha2('user2',512)),
    ('user3', sha2('user3',512));
    
delimiter //
create procedure pUSuccessLogin (userName varchar(15), result char(1))
begin
	if (result = 'S') then
		update utilizador set falhas = 0 where nome_utilizador = userName;
	else
		update utilizador set falhas = falhas +1 where nome_utilizador = userName;
	end if;
end //
delimiter ;

select * from utilizador;

call pUSuccessLogin('user1', 'U'); -- acrescenta falhas ao utilizador 
call pUSuccessLogin('user1', 'U');
call pUSuccessLogin('user1', 'U');
call pUSuccessLogin('user1', 'S');

delimiter // 
create trigger tLogin before update on utilizador
for each row
begin
	if (new.falhas = 5) then 
		set new.estado = 'I';
	end if;
end //
delimiter ;

select nome_utilizador from utilizador where binary nome_utilizador = 'user1' and palavra_passe = sha2('user1',512) and estado = 'A';

update utilizador set estado = 'A' where id_utilizador = 1;

CREATE TABLE Nacionalidade(
	id_nacionalidade		int NOT NULL auto_increment,
    alf2					varchar(2) DEFAULT NULL UNIQUE,
    nacionalidade			varchar(100) NOT NULL,
    PRIMARY KEY				(id_nacionalidade)
);

select * from Nacionalidade;

select * from paisesiso3166; -- Depois de importar o ficheiro csv com a lista dos países

insert into nacionalidade (alf2, nacionalidade)
select
	paisesiso3166.`Cód. Alf2`, paisesiso3166.Designação
from 
	paisesiso3166;

-- A tabela paisesiso3166 continua a existir, posso apagar mais tarde já que não é mais necessária

alter table formando
	add column id_nacionalidade int,
    add constraint FK_nacionalidade foreign key (id_nacionalidade) references nacionalidade (id_nacionalidade);
    
select * from formando;

-- para mostrar nacionalidade

select
	formando.id_formando, formando.nome, formando.iban, formando.sexo, nacionalidade.nacionalidade
from
	formando, nacionalidade
where
	formando.id_nacionalidade = nacionalidade.id_nacionalidade;
    
-- para mostrar todos (nacionalidade preenchida ou null)
select
	formando.id_formando, formando.nome, formando.iban, formando.sexo, nacionalidade.nacionalidade
from
	formando left join nacionalidade
on
	formando.id_nacionalidade = nacionalidade.id_nacionalidade;

-- View para pesquisa de formandos
create view ViewFormando as
select
	formando.id_formando,
    formando.nome,
    formando.iban,
    formando.contacto,
    formando.sexo,
    nacionalidade.nacionalidade,
    nacionalidade.id_nacionalidade
from
	formando
left join nacionalidade on	formando.id_nacionalidade = nacionalidade.id_nacionalidade;

-- Exemplo de utilização da view para pesquisa
select * from 
	ViewFormando 
where 
	id_nacionalidade is Null and nome like '%u%' and sexo = 'M';




