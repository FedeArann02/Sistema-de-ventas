CREATE DATABASE TP_3;
USE TP_3;

-- Tablas principales

CREATE TABLE ROL
(
    IdRol INT PRIMARY KEY IDENTITY,
    Descripcion VARCHAR(50) NOT NULL
);

CREATE TABLE USUARIO
(
    ID_usuario INT IDENTITY PRIMARY KEY,
	Estado BIT default 1,
    Contraseña VARCHAR(100) NOT NULL UNIQUE,
    DNI VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(30) NOT NULL,
    Apellido VARCHAR(30) NOT NULL,
    IdRol INT,
    FOREIGN KEY (IdRol) REFERENCES ROL(IdRol)
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

CREATE TABLE VENDEDOR (
    ID_vendedor INT IDENTITY PRIMARY KEY,
    DNI VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(30) NOT NULL,
    Apellido VARCHAR(30) NOT NULL,
    Comision DECIMAL(10, 2)
);

CREATE TABLE CATEGORIA (
    Cod_categoria INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(50) NOT NULL
);

CREATE TABLE H_Remito (
    id_remito INT IDENTITY PRIMARY KEY,
	Nro_remito VARCHAR(30) NOT NULL UNIQUE,
    fecha_hora DATETIME NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    tel VARCHAR(50),
    email VARCHAR(50),
    entidad VARCHAR(50),
    dni VARCHAR(50),
    subtotal DECIMAL(10, 2),
    descuento DECIMAL(10, 2),
    total DECIMAL(10, 2),
    total_costos DECIMAL(10, 2),
    mes VARCHAR(30),
    año CHAR(4),
    direccion VARCHAR(50)
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
    Compras DECIMAL(10, 2),
    Pagos DECIMAL(10, 2),
    Fecha DATE,
    FOREIGN KEY (ID_Proveedor) REFERENCES PROVEEDOR(ID_Proveedor)
);

CREATE TABLE VENDEDOR_PAGO (
    ID_pago INT IDENTITY PRIMARY KEY,
    ID_vendedor INT,
    Fecha_pago DATE,
    Monto DECIMAL(10, 2),
    FOREIGN KEY (ID_vendedor) REFERENCES VENDEDOR(ID_vendedor)
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
	compras DECIMAL(10, 2),
    Fecha DATE,
    FOREIGN KEY (Documentacion) REFERENCES CLIENTE(Documentacion)
);

CREATE TABLE VENDEDOR_VENTA (
    ID_vendedor_venta INT IDENTITY PRIMARY KEY,
    ID_vendedor INT NOT NULL,
    id_remito INT NOT NULL,
    Fecha DATE NOT NULL,
    Remito_total DECIMAL(10, 2),
    Remito_costo DECIMAL(10, 2),
    Comision DECIMAL(10, 2),
    Comision_total DECIMAL(10, 2),
    Mes VARCHAR(2),
    Año CHAR(4),
    FOREIGN KEY (ID_vendedor) REFERENCES VENDEDOR(ID_vendedor),
    FOREIGN KEY (id_remito) REFERENCES  H_Remito(id_remito)
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

CREATE TABLE INGRESO_EGRESO (
    ID_movimiento INT IDENTITY PRIMARY KEY,
    ID_vendedor INT,
    tipo CHAR(1) NOT NULL,
    detalle VARCHAR(250),
    monto DECIMAL(10, 2),
    fecha DATE NOT NULL,
    mes VARCHAR(20),
    año CHAR(4),
    FOREIGN KEY (ID_vendedor) REFERENCES VENDEDOR(ID_vendedor)
);

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

INSERT INTO PROVEEDOR (Nombre,Apellido,Telefono,Correo) VALUES ('FABIO', 'GOMEZ', '1159444354', 'DATOS@EJEMPLO1.COM');
INSERT INTO PROVEEDOR (Nombre,Apellido,Telefono,Correo) VALUES ('JORGE', 'DIAZ', '222446788476', 'DATOS@EJEMPLO2.COM');

INSERT INTO CATEGORIA (Nombre) VALUES ( 'HARDWARE');
INSERT INTO CATEGORIA (Nombre) VALUES ('PERIFERICOS');

INSERT INTO SUBCATEGORIA (Cod_categoria, Nombre) VALUES (1, 'PLACAS DE VIDEO');
INSERT INTO SUBCATEGORIA (Cod_categoria, Nombre) VALUES (1, 'PROCESADORES');
INSERT INTO SUBCATEGORIA (Cod_categoria, Nombre) VALUES (1, 'MOTHERBOARDS');
INSERT INTO SUBCATEGORIA (Cod_categoria, Nombre) VALUES (2, 'TECLADOS');
INSERT INTO SUBCATEGORIA (Cod_categoria, Nombre) VALUES (2, 'MICROFONOS');
INSERT INTO SUBCATEGORIA (Cod_categoria, Nombre) VALUES (2, 'MOUSES');

INSERT INTO ARTICULO (Cod_categoria,Cod_subcategoria,ID_Proveedor,Cod_articulo,Descripcion)
VALUES (1, 1, 1, 'F1001', 'RTX NVIDIA 4090 24 GB'),
       (2, 5, 2, 'J1001', 'SHURE PDX'),
       (2, 6, 2, 'J1002', 'LOGITECH G406 HERO');

INSERT INTO STOCK (Cod_articulo, Cantidad, Costo, Ganancia)
VALUES ('F1001', 10, 120000.00, 35.00), 
       ('J1001', 20, 90000.00, 33.00),
       ('J1002', 50, 70000.00, 30.00);

INSERT INTO VENDEDOR (Nombre, Apellido, DNI, Comision)
VALUES ('Leo', 'Yamil', '35499330', 10),
       ('Pepe', 'Ruiz', '3389873378', 14),
       ('Federico', 'Palmieri', '44395339', 20),
       ('leandro', 'Pini', '32499330', 9),
       ('Jorge', 'Aran', '22499330', 10);

INSERT INTO CLIENTE (Documentacion, Nombre, Apellido, Direccion, Telefono, Correo, Entidad) VALUES 
('12345678A', 'Juan', 'Pérez', 'Calle Falsa 123', '555-1234', 'juan.perez@example.com', 'Entidad A'),
('44395339', 'Federico', 'Aran', 'Calle Falsa 123', '1159444354', 'aranfederico3@gmail.com', 'Entidad A');

INSERT INTO CTA_CTE_CLIENTE(Documentacion, compras, pagos, Fecha) VALUES
('12345678A', 0, 0, '2024-09-28'),
('44395339', 0, 0, '2024-09-28')

INSERT INTO H_Presupuesto(Nro_Presupuesto, nombre, Apellido, tel, email, direccion, entidad, dni, subtotal, descuento, total, fecha_hora) VALUES
('AAAA-0001', 'Federico', 'Aran', '115944354', 'aranfederico3@gmail.com', 'Calle Falsa 123', 'Entidad A', '44395339', 0, 0, 0,'2024-09-25')

INSERT INTO H_Presupuesto_Detalle(Nro_Presupuesto, Cod_articulo, descripcion, precio_unitario, cantidad, precio_x_cantidad) VALUES
('AAAA-0001', 'f1001', 'RTX NVIDIA 4090 24 GB', 120000+120000*35/100, 5, (120000+120000*35/100)*5),
('AAAA-0001', 'j1001', 'SHURE PDX', 90000+90000*33/100, 3, (90000+90000*33/100)*3),
('AAAA-0001', 'j1002', 'LOGITECH G406 HERO', 70000+70000*30/100, 7, (70000+70000*30/100)*7)


select * from H_Presupuesto_Detalle
select * from H_Remito

select * from CTA_CTE_CLIENTE

truncate table H_Presupuesto

update CTA_CTE_CLIENTE set compras = 450000 where Documentacion = '12345678A'

SELECT ID_cliente, Documentacion, Nombre, Apellido, Direccion, Telefono, Correo, Entidad FROM CLIENTE

--INSERT INTO CTA_CTE_PROVEEDOR (ID_Proveedor, Compras, Pagos, Fecha)
--VALUES (1, 5000.00, 3000.00, '2024-08-01'),
--       (2, 6000.00, 2500.00, '2024-08-02'),
--       (2, 7000.00, 4000.00, '2024-08-03');

--INSERT INTO VENDEDOR_PAGO (ID_vendedor, Fecha_pago, Monto)
--VALUES (1, '2024-08-01', 500.00),
--       (2, '2024-08-02', 750.00),
--       (3, '2024-08-03', 600.00);

--INSERT INTO CLIENTE_PAGO (ID_cliente, Fecha, Monto)
--VALUES (1, '2024-08-01', 450.00),
--       (2, '2024-08-02', 630.00),
--	 (2, '2024-08-02', 1200.00),
--       (3, '2024-08-03', 270.00);

	   
--INSERT INTO H_Remito (fecha_hora, nombre, tel, email, entidad, dni, subtotal, descuento, total, total_costos, mes, año, direccion)
--VALUES ('2024-08-08 14:30:00', 'Juan Pérez', '1234567890', 'juan.perez@example.com', 'Empresa A', '12345678', 1000.00, 50.00, 950.00, 100.00, 'Agosto', '2024', 'Calle Falsa 123'),
--       ('2024-08-08 15:00:00', 'Ana Gómez', '0987654321', 'ana.gomez@example.com', 'Empresa B', '87654321', 1500.00, 75.00, 1425.00, 150.00, 'Agosto', '2024', 'Avenida Siempre Viva 742'),
--       ('2024-08-08 15:30:00', 'Luis Martínez', '1122334455', 'luis.martinez@example.com', 'Empresa C', '55667788', 2000.00, 100.00, 1900.00, 200.00, 'Agosto', '2024', 'Boulevard de los Sueños 456');

--INSERT INTO VENDEDOR_VENTA (ID_vendedor, id_remito, Fecha, Remito_total, Remito_costo, Comision, Comision_total, Mes, Año)
--VALUES (1, 1, '2024-08-01', 450.00, 200.00, 50.00, 50.00, '08', '2024'),
--       (2, 1,'2024-08-02', 630.00, 300.00, 70.00, 70.00, '08', '2024'),
--       (3, 1, '2024-08-03', 270.00, 100.00, 30.00, 30.00, '08', '2024');

--INSERT INTO H_Remito_detalle (id_remito, cod_articulo, descripcion, precio_unitario, cantidad, precio_x_cantidad)
--VALUES (1, 'F1001', 'RTX NVIDIA 4090 24 GB', 120000.00, 2, 240000.00),
--       (1, 'J1001', 'SHURE PDX', 90000.00, 1, 90000.00),
--       (2, 'J1002', 'LOGITECH G406 HERO', 70000.00, 2, 140000.00),
--       (3, 'F1001', 'RTX NVIDIA 3060 12 GB', 120000.00, 3, 360000.00),
--       (3, 'J1002', 'LOGITECH G406 HERO', 70000.00, 4, 280000.00);

--INSERT INTO Ingreso_egreso (ID_vendedor, tipo, detalle, monto, fecha, mes, año)
--VALUES (1, 'I', 'Venta de productos', 500.00, '2024-08-01', 'Agosto', '2024'),
--       (2, 'E', 'Pago a proveedor', 250.00, '2024-08-02', 'Agosto', '2024'),
--       (3, 'I', 'Venta de productos', 600.00, '2024-08-03', 'Agosto', '2024');

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
SELECT d.id_presupuesto_detalle, d.Nro_presupuesto, d.Cod_articulo, d.descripcion AS 'Descripción', d.precio_unitario AS 'Precio unitario', d.cantidad AS Cantidad, d.precio_x_cantidad AS 'Precio por cantidad'
FROM H_Presupuesto_detalle d
WHERE d.Nro_presupuesto = 'AAAA-0009'

-----------------CONSULTAR PRESUPUESTO O REMITO por Documento/cliente:
SELECT Nro_Presupuesto, total, descuento, fecha_hora from H_Presupuesto where dni = '44395339'
SELECT Nro_Remito, total, descuento, fecha_hora from H_Remito where dni = '44395339'

----------------CONSULTAR DETALLES P o R por codigo