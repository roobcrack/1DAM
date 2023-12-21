CREATE TABLE clientes (
    clave VARCHAR2(10) NOT NULL,
    codigo_cliente NUMBER(5,2),
    importe NUMBER(10,2),
    iva NUMBER(2),
    observacions BLOB,
    documentacion CLOB,
    fecha_alta DATE DEFAULT SYSDATE,
    fecha_vencimiento TIMESTAMP,
    CONSTRAINT pk_cliente PRIMARY KEY (clave)
);

CREATE TABLE facturas(
    clave CHAR(10) NOT NULL,
    codigocliente NUMBER(9,2) NOT NULL,
    importetotal NUMBER(10,2),
    baseimponible NUMBER(10,2),
    importeiva NUMBER(10,2),
    porventajeiva NUMBER(2,0),
    observacion VARCHAR2(2000),
    documentacion CLOB,
    ficheroescaneado BLOB,
    fechaalta DATE DEFAULT SYSDATE,
    fechavencimiento DATE,
    serie VARCHAR2(10),
    CONSTRAINT pk_facturas PRIMARY KEY (clave)
);

ALTER TABLE facturas DROP CONSTRAINT pk_facturas;
ALTER TABLE facturas
    ADD CONSTRAINT pk_facturas
    PRIMARY KEY(nif);


SELECT ACC.COLUMN_NAME
FROM ALL_CONS_COLUMNS ACC
JOIN ALL_CONSTRAINTS AC ON
ACC.CONSTRAINT_NAME =
AC.CONSTRAINT_NAME
WHERE ACC.TABLE_NAME = 'clientes' AND
AC.CONSTRAINT_TYPE = 'P';