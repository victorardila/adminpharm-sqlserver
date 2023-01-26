--Crea base de datos
create database AdminPharm
--Comando para eliminar(drop database AdminPharm)

use AdminPharm

create table CAJA(
Id_Caja varchar(12) primary key not null,
Fecha_De_Apertura varchar(20) not null,
Hora_De_Apertura varchar(15)not null,
Fecha_De_Cierre varchar(20) not null,
Hora_De_Cierre varchar(15)not null,
Estado varchar(10) not null,
Monto int
);
create table CLIENTE(
Id varchar(12) primary key not null,
Codigo_Cliente nvarchar(10) not null,
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
Id varchar(12) primary key not null,
Codigo_Empleado nvarchar(10) not null,
Tipo_De_Id char(2)not null,
Nombres varchar(30) not null,
Apellidos varchar(30) not null,
Fecha_De_Nacimiento datetime not null,
Edad int,
Sexo varchar(5),
Direccion_Domicilio text,
Telefono varchar(15),
Rol varchar(15),
Correo varchar(100),
Usuario nvarchar(50),
Contraseña nvarchar(50)
);
create table ESTANTE(
Codigo_De_Estante nvarchar(10) primary key not null,
Numero_De_Estante int,
Cantidad_De_Productos int,
Estado varchar(12)
);
create table PRODUCTO(
Cantidad int not null,
Referencia nvarchar(100) primary key not null,
Nombre varchar(100)not null,
Detalle text,
Fecha_De_Registro datetime not null,
Fecha_De_Vencimiento datetime not null,
Lote nvarchar(100) not null,
Laboratorio varchar(80)not null,
Estado varchar(12),
Tipo varchar(20),
Via varchar(20),
Porcentaje_De_Venta int,
Precio_De_Negocio int,
Precio_De_Venta int,
GananciaPorProducto int,
Numero_Estante int
);
create table DROGUERIA(
Id_Drogueria nvarchar(6) primary key not null,
Nombre_De_Drogueria nvarchar(100)not null,
NIT nvarchar(50)not null,
CodigoCamara varchar(6)not null,
Frase_Distintiva text,
Regimen varchar(20)not null,
PBX nvarchar(30),
Direccion nvarchar(100),
Telefono varchar(15)
);
create table FACTURA(
Id_Factura varchar(15) primary key not null,
Secuencia_De_Factura int not null,
FechaYHora datetime not null,
Nombre_De_Empleado varchar(50) not null,
Ciudad varchar(20) not null,
Id_Caja varchar(12) not null,
Nombre_De_Cliente varchar(50) not null,
Total_Sin_Redondeo int,
Total_Con_Redondeo int,
Total_De_Factura int,
Forma_De_Pago varchar(20)
);
