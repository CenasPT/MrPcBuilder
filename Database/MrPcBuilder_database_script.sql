-- DROP DATABASE IF EXISTS mrpcbuilder_database;

CREATE DATABASE mrpcbuilder_database;

USE mrpcbuilder_database;

CREATE TABLE employee_login (
	id_employee_login	INT AUTO_INCREMENT,
    username			VARCHAR(15) NOT NULL UNIQUE,
    user_password		VARCHAR(128) NOT NULL,
    fails				TINYINT DEFAULT 0 NOT NULL,
    user_status			ENUM('Active','Inactive') DEFAULT 'Active' NOT NULL,
	PRIMARY KEY (id_employee_login)
);

CREATE TABLE employee_role (
	id_role     	    INT AUTO_INCREMENT,
    role_name		VARCHAR(50) DEFAULT 'Undefined' NOT NULL,
	PRIMARY KEY (id_role)
);

CREATE TABLE employee (
	id_employee			INT AUTO_INCREMENT,
	id_employee_login	INT NOT NULL,
    id_role			    INT NOT NULL,
    name_employee		VARCHAR(20) NOT NULL,
    tax_id				VARCHAR(15) NOT NULL DEFAULT '0',
	email				VARCHAR(255) NOT NULL UNIQUE,
    PRIMARY KEY (id_employee),
	FOREIGN KEY (id_employee_login) REFERENCES employee_login (id_employee_login)
		ON UPDATE CASCADE,
    FOREIGN KEY (id_role) REFERENCES employee_role (id_role)
		ON UPDATE CASCADE
);

CREATE TABLE customer_login (
	id_customer_login	INT AUTO_INCREMENT,
    username			VARCHAR(15) NOT NULL UNIQUE,
    user_password		VARCHAR(128) NOT NULL,
    fails				TINYINT DEFAULT 0 NOT NULL,
    user_status			ENUM('Active','Inactive') DEFAULT 'Active' NOT NULL,
	PRIMARY KEY (id_customer_login)
);

CREATE TABLE customer (
	id_customer			INT AUTO_INCREMENT,
	id_customer_login	INT NOT NULL,
    name_customer		VARCHAR(20) NOT NULL,
	last_name_customer	VARCHAR(20) NOT NULL,
    street_customer		VARCHAR(100) NULL,
	zipcode_customer	VARCHAR(20) NULL,
	country_customer	VARCHAR(30) NULL,
    phone_number		VARCHAR(15) NULL DEFAULT '0',
	email				VARCHAR(255) NOT NULL UNIQUE,
	tax_id				VARCHAR(15) NOT NULL DEFAULT '0',
    PRIMARY KEY (id_customer),
	FOREIGN KEY (id_customer_login) REFERENCES customer_login (id_customer_login)
		ON UPDATE CASCADE
);

CREATE TABLE manufacturer (
	id_manufacturer		INT AUTO_INCREMENT,
    name_manufacturer	VARCHAR(100) NOT NULL UNIQUE,
    phone_contact		VARCHAR(15) NULL DEFAULT '0',
	email				VARCHAR(255) NULL,
    PRIMARY KEY (id_manufacturer)
);

CREATE TABLE component_type (
	id_component_type	INT AUTO_INCREMENT,
    component_type		VARCHAR(100) NOT NULL UNIQUE,
    PRIMARY KEY (id_component_type)
);

CREATE TABLE pc_component (
	id_pc_component			INT AUTO_INCREMENT,
    id_component_type		INT NOT NULL,
    name_component			VARCHAR(100) NOT NULL,
    description_component	VARCHAR(250) NOT NULL,
	id_manufacturer			INT NOT NULL,
	model					VARCHAR(100) NOT NULL,
	price					NUMERIC(7,2) NOT NULL,
	status					ENUM('Available','Not Available') DEFAULT 'Available' NOT NULL,
    PRIMARY KEY (id_pc_component),
	FOREIGN KEY (id_manufacturer) REFERENCES manufacturer (id_manufacturer)
		ON UPDATE CASCADE,
	FOREIGN KEY (id_component_type) REFERENCES component_type (id_component_type)
		ON UPDATE CASCADE
);

CREATE TABLE build_order (
	id_build_order		INT AUTO_INCREMENT,
    id_employee         INT NULL,
    id_customer			INT NOT NULL,
    total_quantity      INT NOT NULL,
    total_price         NUMERIC(7,2) NOT NULL,
	order_date			DATE NOT NULL,
	delivery_date		DATE NOT NULL,
    build_status		ENUM('Pending','In Progress','Completed') DEFAULT 'Pending' NOT NULL,
    PRIMARY KEY (id_build_order),
	FOREIGN KEY (id_customer) REFERENCES customer (id_customer)
		ON UPDATE CASCADE,
    FOREIGN KEY (id_employee) REFERENCES employee (id_employee)
		ON UPDATE CASCADE
);

CREATE TABLE build_components (
    id_build_components	INT AUTO_INCREMENT,
    id_pc_component     INT NOT NULL,
    id_build_order		INT NOT NULL,
    quantity 			INT NOT NULL,
    PRIMARY KEY (id_build_components),
    FOREIGN KEY (id_pc_component) REFERENCES pc_component(id_pc_component)
        ON UPDATE CASCADE,
    FOREIGN KEY (id_build_order) REFERENCES build_order(id_build_order)
        ON UPDATE CASCADE
);

CREATE TABLE payment_method (
	id_payment_method	INT AUTO_INCREMENT,
    payment_method		VARCHAR(100) NOT NULL,
    PRIMARY KEY (id_payment_method)
);

CREATE TABLE receipt (
	id_receipt			INT AUTO_INCREMENT,
    id_build_order		INT NOT NULL,
	id_payment_method	INT NOT NULL,
	payment_status		ENUM('Pending','Completed','Failed','Refunded','Cancelled') DEFAULT 'Pending' NOT NULL,
    PRIMARY KEY (id_receipt),
	FOREIGN KEY (id_build_order) REFERENCES build_order (id_build_order)
		ON UPDATE CASCADE,
	FOREIGN KEY (id_payment_method) REFERENCES payment_method (id_payment_method)
		ON UPDATE CASCADE
);

-- VIEWS
create view component_view as
select
	pc_component.id_pc_component,
	component_type.component_type,
    pc_component.name_component,
    pc_component.model,
    manufacturer.name_manufacturer,
    pc_component.price,	
    pc_component.description_component
from
	pc_component
left join component_type on	pc_component.id_component_type = component_type.id_component_type
left join manufacturer on pc_component.id_manufacturer = manufacturer.id_manufacturer;

--
create view build_view as
select
    build_order.id_build_order,
    employee.name_employee,
    customer.name_customer,
    build_order.order_date,
    build_order.delivery_date,
    build_order.total_price,
    build_order.total_quantity,
    build_order.build_status,
    payment_method.payment_method
from
    build_order
left join employee on build_order.id_employee = employee.id_employee
left join customer on build_order.id_customer = customer.id_customer
left join receipt on build_order.id_build_order = receipt.id_build_order
left join payment_method on receipt.id_payment_method = payment_method.id_payment_method;
--
create view build_components_view as
select
    build_components.id_build_order,
    component_type.component_type,
    pc_component.name_component,
    manufacturer.name_manufacturer,
    pc_component.model,
    pc_component.price,
    build_components.quantity
from 
    build_components
join 
    pc_component on build_components.id_pc_component = pc_component.id_pc_component
join 
    component_type on pc_component.id_component_type = component_type.id_component_type
join 
    manufacturer on pc_component.id_manufacturer = manufacturer.id_manufacturer;
--
create view employee_view as
select
    employee.id_employee,
	employee.name_employee,
	employee_role.role_name,
    employee.email,
    employee.tax_id,
    employee_login.user_status
from
	employee
left join employee_login on	employee.id_employee_login = employee_login.id_employee_login
left join employee_role on employee.id_role = employee_role.id_role;

-- INSERT ADMIN TO DATABASE
INSERT INTO employee_login (username, user_password) VALUES ('admin', 'admin');

INSERT INTO employee_role (role_name) VALUES ('Administrator');

INSERT INTO employee (id_employee_login, id_role, name_employee, email, tax_id) 
VALUES ((SELECT id_employee_login FROM employee_login WHERE username = 'admin'), 
        (SELECT id_role FROM employee_role WHERE role_name = 'Administrator'), 
        'Administrator',
        'admin@mail.com', 
        '123456789123456');

