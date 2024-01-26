CREATE TABLE marcas(
    cifm VARCHAR2(255) NOT NULL,
    nombre VARCHAR2(255),
    ciudad VARCHAR2(255),
    CONSTRAINT pk_marcas PRIMARY KEY (cifm)
);

CREATE TABLE coches(
    codCoche VARCHAR2(255) NOT NULL,
    nombre VARCHAR2(255),
    modelo VARCHAR2(255),
    CONSTRAINT pk_coches PRIMARY KEY (codCoche)
);

CREATE TABLE concesionario(
    cifc VARCHAR2(255) NOT NULL,
    nombre VARCHAR2(255),
    ciudad VARCHAR2(255),
    CONSTRAINT pk_concesionario PRIMARY KEY (cifc)
);

CREATE TABLE clientes(
    dni VARCHAR2(255) NOT NULL,
    nombre VARCHAR2(255),
    apellidos VARCHAR2(255),
    ciudad VARCHAR2(255),
    CONSTRAINT pk_clientes PRIMARY KEY (dni)
);

CREATE TABLE distribucion(
    cifc VARCHAR2(255) NOT NULL,
    codCoche VARCHAR2(255) NOT NULL,
    cantidad NUMBER,
    CONSTRAINT pk_distribucion PRIMARY KEY (cifc, codcoche),
    CONSTRAINT fk_distribucion_cifc FOREIGN KEY (cifc) REFERENCES concesionario (cifc),
    CONSTRAINT fk_distribucion_codCoche FOREIGN KEY (codCoche) REFERENCES coches (codCoche)
);

CREATE TABLE ventas(
    cifc VARCHAR2(255) NOT NULL,
    dni VARCHAR2(255) NOT NULL,
    codCoche VARCHAR2(255) NOT NULL,
    color VARCHAR2(255),
    CONSTRAINT pk_ventas PRIMARY KEY (cifc, dni, codCoche),
    CONSTRAINT fk_ventas_cifc FOREIGN KEY (cifc) REFERENCES concesionario (cifc),
    CONSTRAINT fk_ventas_codCoche FOREIGN KEY (codCoche) REFERENCES coches (codCoche),
    CONSTRAINT fk_ventas_dni FOREIGN KEY (dni) REFERENCES clientes (dni)
);

CREATE TABLE marco(
    cifm VARCHAR2(255) NOT NULL,
    codCoche VARCHAR2(255) NOT NULL,
    CONSTRAINT pk_marco PRIMARY KEY (cifm, codCoche),
    CONSTRAINT fk_marco_cifm FOREIGN KEY (cifm) REFERENCES marcas (cifm),
    CONSTRAINT fk_marco_codCoche FOREIGN KEY (codCoche) REFERENCES coches (codCoche)
);

DROP TABLE clientes CASCADE CONSTRAINTS;
DROP TABLE coches CASCADE CONSTRAINTS;
DROP TABLE concesionario CASCADE CONSTRAINTS;
DROP TABLE distribucion CASCADE CONSTRAINTS;
DROP TABLE marcas CASCADE CONSTRAINTS;
DROP TABLE marco CASCADE CONSTRAINTS;
DROP TABLE ventas CASCADE CONSTRAINTS;
