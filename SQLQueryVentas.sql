CREATE DATABASE SistemaVentasFede;
USE SistemaVentasFede;

-- Tablas principales

CREATE TABLE ROL
(
    IdRol INT PRIMARY KEY IDENTITY,
    Descripcion VARCHAR(50) NOT NULL
);

CREATE TABLE CLIENTE (
    ID_cliente INT PRIMARY KEY IDENTITY,
    Documentacion VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(30) NOT NULL,
    Apellido VARCHAR(30) NOT NULL,
    Direccion VARCHAR(100),
    Telefono VARCHAR(15),
    Correo VARCHAR(100),
    Entidad VARCHAR(60)
);

CREATE TABLE PROVEEDOR (
    ID_Proveedor INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(30) NOT NULL,
    Apellido VARCHAR(30),
    Telefono VARCHAR(15),
    Correo VARCHAR(100)
);

CREATE TABLE CATEGORIA (
    Cod_categoria INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50) NOT NULL
);

CREATE TABLE H_Presupuesto (
    id_presupuesto INT IDENTITY PRIMARY KEY,
    Nro_Presupuesto VARCHAR(30) NOT NULL UNIQUE,
    nombre VARCHAR(50) NOT NULL,
    Apellido varchar (30) NOT NULL,
    tel VARCHAR(50),
    email VARCHAR(50),
    entidad VARCHAR(50),
    dni VARCHAR(50),
    subtotal DECIMAL(10, 2),
    descuento DECIMAL(10, 2),
    total DECIMAL(10, 2),
    direccion VARCHAR(50),
    fecha_hora DATETIME NOT NULL
);

-- Tablas dependientes
CREATE TABLE USUARIO
(
    ID_usuario INT IDENTITY PRIMARY KEY,
	Estado BIT default 1,
    Contraseña VARCHAR(100) NOT NULL,
    DNI VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(30) NOT NULL,
    Apellido VARCHAR(30) NOT NULL,
	Comision DECIMAL(10, 2) default 0,
    IdRol INT,
    FOREIGN KEY (IdRol) REFERENCES ROL(IdRol)
);

CREATE TABLE PERMISO
(
    IdPermiso INT PRIMARY KEY IDENTITY,
    IdRol INT,
    NombreMenu VARCHAR(50) NOT NULL,
    FOREIGN KEY (IdRol) REFERENCES ROL(IdRol)
);

CREATE TABLE SUBCATEGORIA (
    Cod_subcategoria INT IDENTITY PRIMARY KEY,
    Cod_categoria INT,
    Nombre VARCHAR(100) NOT NULL,
    FOREIGN KEY (Cod_categoria) REFERENCES CATEGORIA(Cod_categoria)
);

CREATE TABLE ARTICULO (
    ID_articulo INT IDENTITY PRIMARY KEY,
    Cod_articulo VARCHAR(20) NOT NULL UNIQUE,
    Descripcion VARCHAR(500),
    ID_Proveedor INT,
    Cod_subcategoria INT,
    Cod_categoria INT,
    FOREIGN KEY (ID_Proveedor) REFERENCES PROVEEDOR(ID_Proveedor),
    FOREIGN KEY (Cod_subcategoria) REFERENCES SUBCATEGORIA(Cod_subcategoria),
    FOREIGN KEY (Cod_categoria) REFERENCES CATEGORIA(Cod_categoria)
);

CREATE TABLE CTA_CTE_PROVEEDOR (
    ID_CtaCteProv INT PRIMARY KEY IDENTITY,
    ID_Proveedor INT,
    Compras DECIMAL(10, 2) default 0,
    Pagos DECIMAL(10, 2) default 0,
    Fecha DATE,
    FOREIGN KEY (ID_Proveedor) REFERENCES PROVEEDOR(ID_Proveedor)
);

CREATE TABLE CTA_CTE_USUARIO (
    ID_pago INT IDENTITY PRIMARY KEY,
    ID_usuario INT,
    Fecha_pago DATE,
    Monto DECIMAL(10, 2) default 0,
    FOREIGN KEY (ID_usuario) REFERENCES USUARIO(ID_usuario)
);

CREATE TABLE STOCK (
    ID_stock INT IDENTITY PRIMARY KEY,
    Cod_articulo VARCHAR(20),
    Cantidad INT,
    Costo DECIMAL(10, 2),
    Ganancia DECIMAL(10, 2),
    FOREIGN KEY (Cod_articulo) REFERENCES ARTICULO(Cod_articulo)
);

CREATE TABLE CTA_CTE_CLIENTE (
    ID_pago INT PRIMARY KEY IDENTITY,
    Documentacion VARCHAR(15) NOT NULL UNIQUE,
	pagos DECIMAL(10, 2),
	compras DECIMAL(10, 2) default 0,
    Fecha DATE,
    FOREIGN KEY (Documentacion) REFERENCES CLIENTE(Documentacion)
);

CREATE TABLE H_Remito (
    id_remito INT IDENTITY PRIMARY KEY,
	ID_usuario INT NOT NULL,
	Nro_remito VARCHAR(30) NOT NULL UNIQUE,
    fecha_hora DATETIME NOT NULL,
    nombre VARCHAR(50) NOT NULL,
	Apellido varchar (30) NOT NULL,
    tel VARCHAR(50),
    email VARCHAR(50),
    entidad VARCHAR(50),
    dni VARCHAR(50),
    subtotal DECIMAL(10, 2),
    descuento DECIMAL(10, 2),
    total DECIMAL(10, 2),
    total_costos DECIMAL(10, 2),
    direccion VARCHAR(50)
	FOREIGN KEY (ID_usuario) REFERENCES USUARIO(ID_usuario)
);

CREATE TABLE H_Remito_detalle (
    id_remito_detalle INT IDENTITY PRIMARY KEY,
    Nro_remito VARCHAR(30) NOT NULL,
    cod_articulo VARCHAR(20),
    descripcion VARCHAR(250),
    precio_unitario DECIMAL(10, 2),
    cantidad INT,
    precio_x_cantidad DECIMAL(10, 2),
    FOREIGN KEY (Nro_remito) REFERENCES H_Remito(Nro_remito),
    FOREIGN KEY (cod_articulo) REFERENCES ARTICULO(Cod_articulo)
);

--CREATE TABLE INGRESO_EGRESO (
--    ID_movimiento INT IDENTITY PRIMARY KEY,
--    ID_vendedor INT,
--    tipo CHAR(1) NOT NULL,
--    detalle VARCHAR(250),
--    monto DECIMAL(10, 2),
--    fecha DATE NOT NULL,
--    mes VARCHAR(20),
--    año CHAR(4),
--    FOREIGN KEY (Usuario) REFERENCES VENDEDOR(Usuario)
--);

create table H_Presupuesto_Detalle(
    id_presupuesto_detalle int identity (1,1) not null,
    Nro_Presupuesto VARCHAR(30) not null,
    Cod_articulo varchar (20) not null,
    descripcion varchar (250) not null,
    precio_unitario DECIMAL (10 ,2) not null,
    cantidad int not null,
    precio_x_cantidad DECIMAL (10,2) not null,
    primary key (id_presupuesto_detalle),
    foreign key (Nro_Presupuesto) references H_Presupuesto(Nro_Presupuesto)
);

--INSERTS

insert into PERMISO(IdRol, NombreMenu) values
(1, 'Administrar'),
(2, 'Ventas');



--CONSULTAS

--SELECT VENDEDOR.Nombre, VENDEDOR.Apellido, VENDEDOR.DNI, VENDEDOR_VENTA.Fecha, VENDEDOR_VENTA.Comision, 
--VENDEDOR_VENTA.Comision_total, H_Remito.nombre, H_Remito.subtotal, H_Remito.total, H_Remito_detalle.cantidad, 
--H_Remito_detalle.descripcion, H_Remito_detalle.precio_unitario, H_Remito_detalle.precio_x_cantidad 
--FROM VENDEDOR
--INNER JOIN VENDEDOR_VENTA ON VENDEDOR.ID_vendedor = VENDEDOR_VENTA.ID_vendedor
--INNER JOIN H_Remito ON VENDEDOR_VENTA.id_remito = H_Remito.id_remito
--INNER JOIN H_Remito_detalle ON H_Remito.id_remito = H_Remito_detalle.id_remito


--select a.Cod_articulo, a.Descripcion, c.Nombre, s.Nombre, p.Nombre, st.Cantidad, st.Costo, st.Ganancia from ARTICULO a
--inner join CATEGORIA c on a.Cod_categoria = c.Cod_categoria
--inner join SUBCATEGORIA s on a.Cod_subcategoria = s.Cod_subcategoria
--inner join PROVEEDOR p on a.ID_Proveedor = p.ID_Proveedor
--inner join STOCK st on a.Cod_articulo = st.Cod_articulo


--SELECT * FROM USUARIO;

--SELECT PROVEEDOR.Nombre as 'Proveedor', ARTICULO.Descripcion as 'Articulo', STOCK.Cantidad, 
--STOCK.Costo, STOCK.Ganancia, CATEGORIA.Nombre as 'Categoría', SUBCATEGORIA.Nombre as 'Subcategoría'
--FROM PROVEEDOR
--INNER JOIN ARTICULO ON PROVEEDOR.ID_Proveedor = ARTICULO.ID_Proveedor
--INNER JOIN SUBCATEGORIA ON ARTICULO.Cod_subcategoria = SUBCATEGORIA.Cod_subcategoria
--INNER JOIN CATEGORIA ON SUBCATEGORIA.Cod_categoria = CATEGORIA.Cod_categoria
--INNER JOIN STOCK ON ARTICULO.Cod_articulo = STOCK.Cod_articulo;


-----------------CONSULTAR PRESUPUESTO Y DETALLE
--SELECT p.id_presupuesto, p.Nro_presupuesto, p.nombre, p.Apellido, p.tel, p.email, p.entidad, p.dni, p.subtotal, p.descuento, p.total, p.direccion, p.fecha_hora AS 'Fecha y Hora',
--d.id_presupuesto_detalle, d.id_presupuesto_detalle, d.Cod_articulo, d.descripcion AS 'Descripción', d.precio_unitario AS 'Precio unitario', d.cantidad AS Cantidad, d.precio_x_cantidad AS 'Precio por cantidad'
--FROM H_Presupuesto p
--INNER JOIN H_Presupuesto_Detalle d ON p.Nro_presupuesto = d.Nro_presupuesto
--WHERE p.Nro_presupuesto = 'AAAA-0009'

-----------------CONSULTAR PRESUPUESTO DETALLE
--SELECT d.id_presupuesto_detalle, d.Nro_presupuesto, d.Cod_articulo, d.descripcion AS 'Descripción', d.precio_unitario AS 'Precio unitario', d.cantidad AS Cantidad, d.precio_x_cantidad AS 'Precio por cantidad'
--FROM H_Presupuesto_detalle d
--WHERE d.Nro_presupuesto = 'AAAA-0009'

-------------------CONSULTAR PRESUPUESTO O REMITO por Documento/cliente:
--SELECT Nro_Presupuesto, total, descuento, fecha_hora from H_Presupuesto where dni = '44395339'
--SELECT Nro_Remito, total, descuento, fecha_hora from H_Remito where dni = '44395339'

------------------CONSULTAR DETALLES P o R por codigo


------------------CONSULTAR SUBCATEGORIA Y CATEGORIA NOMBRES
--select s.Nombre as 'SUB CATEGORÍA', c.Nombre as 'CATEGORÍA'
--from CATEGORIA c
--inner join SUBCATEGORIA s on c.Cod_categoria = s.Cod_categoria

------------------------
--SELECT ID_cliente, Documentacion, Nombre, Apellido, Direccion, Telefono, Correo, Entidad FROM CLIENTE
----------------------------

--SELECT rd.id_remito_detalle, rd.Nro_remito, rd.cod_articulo, rd.descripcion AS 'Descripción', rd.precio_unitario AS 'Precio unitario', rd.cantidad AS Cantidad, rd.precio_x_cantidad AS 'Precio por cantidad'
--FROM H_remito_detalle rd
--WHERE rd.Nro_remito = 'AAAA-0001';

---------- update de compras cliente

--update CTA_CTE_CLIENTE set compras = 20000 where Documentacion = '44395339'

---------- consulta de monto de compras

--select Compras from CTA_CTE_CLIENTE where Documentacion = '44395339'

--------

--select * from H_Remito
--select * from CTA_CTE_CLIENTE