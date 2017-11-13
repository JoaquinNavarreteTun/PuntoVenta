/*
Created		17/10/2017
Modified		09/11/2017
Project		
Model		
Company		
Author		
Version		
Database		mySQL 5 
*/


Create table ventas (
	id_venta Int NOT NULL AUTO_INCREMENT,
	id_promocion Int NOT NULL,
	id_clientes Int NOT NULL,
	id_empleado Int NOT NULL,
	fecha Date NOT NULL,
	cantidad Int NOT NULL,
	total Decimal(8,2) NOT NULL,
 Primary Key (id_venta)) ENGINE = MyISAM;

Create table clientes (
	id_clientes Int NOT NULL AUTO_INCREMENT,
	nombre Varchar(40) NOT NULL,
	apellido_pa Varchar(20) NOT NULL,
	apellido_ma Varchar(20) NOT NULL,
	direcion Varchar(45) NOT NULL,
	municipio Varchar(30) NOT NULL,
	estado Varchar(50) NOT NULL,
 Primary Key (id_clientes)) ENGINE = MyISAM;

Create table detalle_venta (
	folio_venta Int NOT NULL AUTO_INCREMENT,
	id_producto Int NOT NULL,
	precio Decimal(8,2) NOT NULL,
	cantidad Int NOT NULL,
	total Decimal(8,2) NOT NULL,
	id_venta Int NOT NULL,
 Primary Key (folio_venta)) ENGINE = MyISAM;

Create table productos (
	id_producto Int NOT NULL AUTO_INCREMENT,
	id_departamento Int NOT NULL,
	id_marca Int NOT NULL,
	nombre Varchar(40) NOT NULL,
	descripcion Varchar(50),
	precio_compra Decimal(8,2) NOT NULL,
	precio_venta Decimal(8,2) NOT NULL,
	fecha Date NOT NULL,
	imagen Varchar(100),
	estado Varchar(50) NOT NULL,
	stockmin Int NOT NULL,
 Primary Key (id_producto)) ENGINE = MyISAM;

Create table departamento (
	id_departamento Int NOT NULL AUTO_INCREMENT,
	departamento Varchar(45) NOT NULL,
	descripcion Varchar(50),
 Primary Key (id_departamento)) ENGINE = MyISAM;

Create table detalle_compra (
	folio_compra Int NOT NULL AUTO_INCREMENT,
	id_compra Int NOT NULL,
	id_producto Int NOT NULL,
	fecha_compra Date NOT NULL,
	hora_venta Time NOT NULL,
	cantidad Int NOT NULL,
	total_compra Decimal(8,2) NOT NULL,
 Primary Key (folio_compra)) ENGINE = MyISAM;

Create table compra (
	id_compra Int NOT NULL AUTO_INCREMENT,
	idpersona Int NOT NULL,
	precio Decimal(8,2) NOT NULL,
	cantidad Int NOT NULL,
	total Decimal(8,2) NOT NULL,
 Primary Key (id_compra)) ENGINE = MyISAM;

Create table persona (
	idpersona Int NOT NULL AUTO_INCREMENT,
	tipo_persona Varchar(40) NOT NULL,
	nombre Varchar(14) NOT NULL,
	tipo_documento Varchar(17) NOT NULL,
	num_documento Int NOT NULL,
	direccion Varchar(50) NOT NULL,
	telefono Varchar(20) NOT NULL,
	email Varchar(27),
	estado Char(40),
 Primary Key (idpersona)) ENGINE = MyISAM;

Create table empleados (
	id_empleado Int NOT NULL AUTO_INCREMENT,
	nombre Varchar(40) NOT NULL,
	apellidos Varchar(50) NOT NULL,
	edad Int,
	usuario Varchar(20) NOT NULL,
	contrasenia Varchar(8) NOT NULL,
	nivel_trabajo Varchar(30) NOT NULL,
	estado Varchar(20) NOT NULL,
 Primary Key (id_empleado)) ENGINE = MyISAM;

Create table prod_venta_cancelada (
	id_cacelado Int NOT NULL AUTO_INCREMENT,
	id_venta Int NOT NULL,
	nombre Varchar(50) NOT NULL,
	fecha Date NOT NULL,
	precio Decimal(8,2) NOT NULL,
 Primary Key (id_cacelado)) ENGINE = MyISAM;

Create table promocion (
	id_promocion Int NOT NULL AUTO_INCREMENT,
	nom_paquete Varchar(50),
	precio Decimal(8,2) NOT NULL,
	producto Varchar(50) NOT NULL,
	descuento Decimal(8,2) NOT NULL,
	precio_descuento Decimal(8,2) NOT NULL,
	estado Varchar(50) NOT NULL,
 Primary Key (id_promocion)) ENGINE = MyISAM;

Create table marca (
	id_marca Int NOT NULL AUTO_INCREMENT,
	tipo Varchar(50) NOT NULL,
	descripcion Varchar(50),
 Primary Key (id_marca)) ENGINE = MyISAM;


