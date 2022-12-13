--Crea base de datos
create database AdminPharm
--Comando para eliminar(drop database AdminPharm)

use AdminPharm

create table CAJA(
Id_Caja varchar(12) primary key not null,
Fecha_De_Apertura varchar(20) not null,
Fecha_De_Cierre varchar(20) not null,
Estado varchar(10) not null,
Monto int
);
create table CLIENTE(
Codigo_Cliente nvarchar(10) not null,
Id varchar(12) primary key not null,
Tipo_De_Id char(2)not null,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int,
Sexo varchar(5),
Direccion_Domicilio text,
Telefono varchar(15),
Correo varchar(100)
);
create table EMPLEADO(
Codigo_Empleado nvarchar(10) not null,
Id varchar(12) primary key not null,
Tipo_De_Id char(2)not null,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int,
Sexo varchar(5),
Direccion_Domicilio text,
Telefono varchar(15),
Correo varchar(100)
);
create table ESTANTE(
Codigo_De_Estante nvarchar(10) not null,
Numero_De_Estante int,
Cantidad_De_Productos int
);
create table PRODUCTO(
Referencia nvarchar(100) not null,
Detalle text,
Fecha_De_Registro datetime not null,
Fecha_De_Vencimiento datetime not null,
Lote nvarchar(100) not null,
Estado varchar(12),
Porcentaje_De_Venta int,
Precio_De_Negocio int,
Precio_De_Venta int,
GananciaPorProducto int
);

