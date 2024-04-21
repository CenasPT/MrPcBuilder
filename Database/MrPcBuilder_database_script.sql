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