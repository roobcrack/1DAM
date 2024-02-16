    CREATE TABLE vendedor (
    numvend NUMBER NOT NULL,
    nomvend VARCHAR2(255),
    nombrecomer VARCHAR2(255),
    telefono VARCHAR2(255),
    calle VARCHAR2(255),
    ciudad VARCHAR2(255),
    provincia VARCHAR2(255),
    CONSTRAINT pk_vendedor PRIMARY KEY (numvend)
);

CREATE TABLE pieza (
    numpieza VARCHAR2(20) NOT NULL,
    nompieza VARCHAR2(255),
    preciovent NUMBER,
    descripcion VARCHAR2(255),
    CONSTRAINT pk_pieza PRIMARY KEY(numpieza)
);

CREATE TABLE pedido (
    numpedido NUMBER NOT NULL,
    numvend NUMBER,
    fecha DATE DEFAULT SYSDATE,
    CONSTRAINT pk_pedido PRIMARY KEY (numpedido)
);

CREATE TABLE linped (
    numlinea NUMBER NOT NULL,
    numpedido NUMBER NOT NULL,
    numpieza VARCHAR2(20),
    preciocompra NUMBER,
    cantpedida NUMBER,
    fecharecep DATE DEFAULT SYSDATE,
    cantrecibida NUMBER,
    CONSTRAINT pk_linped PRIMARY KEY (numpedido, numlinea)
);

CREATE TABLE inventario (
    numbin NUMBER NOT NULL,
    numpieza VARCHAR2(20),
    cantdisponible NUMBER,
    fecharecuento DATE DEFAULT SYSDATE,
    periodorecuen NUMBER,
    cantminima NUMBER,
    CONSTRAINT pk_inventario PRIMARY KEY (numbin)
);

CREATE TABLE preciosum (
    numpieza VARCHAR2(20) NOT NULL,
    numvend NUMBER NOT NULL,
    idpreciosum VARCHAR2(20),
    preciounit NUMBER,
    diassum NUMBER,
    descuento NUMBER,
    CONSTRAINT pk_preciosum PRIMARY KEY (numpieza, numvend)
);


ALTER TABLE preciosum
ADD CONSTRAINT fk_preciosum_numpieza
    FOREIGN KEY (numpieza)
    REFERENCES pieza (numpieza)
ADD CONSTRAINT fk_preciosum_numvend
    FOREIGN KEY (numvend)
    REFERENCES vendedor (numvend);

ALTER TABLE pedido
ADD CONSTRAINT fk_pedido_numvend
    FOREIGN KEY (numvend)
    REFERENCES vendedor (numvend);

ALTER TABLE linped
ADD CONSTRAINT fk_linped_numpieza
    FOREIGN KEY (numpieza)
    REFERENCES pieza (numpieza)
ADD CONSTRAINT fk_linped_numpedido
    FOREIGN KEY (numpedido)
    REFERENCES pedido (numpedido);

ALTER TABLE linped
ADD CONSTRAINT uk_linped_numpieza
    UNIQUE (numpieza);






/*ACTIVIDAD 1*/

/*A)*/
INSERT INTO pieza (numpieza, nompieza, preciovent, descripcion)
VALUES ('A-1001-L', 'MOUSE ADL 3B', 7, 'Periferico de entrada');

INSERT INTO pieza (numpieza, preciovent)
VALUES ('C-1002-H', 4);

INSERT INTO pieza (numpieza, preciovent)
VALUES ('C-1002-J', 0);

INSERT INTO pieza (numpieza, nompieza)
VALUES ('C-400-Z', 'FILTRO PANTALLA X200');

INSERT INTO pieza (numpieza, nompieza, preciovent)
VALUES ('DK 144-0001', 'USB 1TB PANASONIC', 65);

INSERT INTO pieza (numpieza, nompieza, preciovent, descripcion)
VALUES ('DK 144-0002-P', 'DISCO EXTERNO 1TB CRUCIAL XD', 80, 'Sin descripcion');

INSERT INTO pieza (numpieza, nompieza, preciovent)
VALUES ('O-0001-PP', 'TECLADO AT''SU', 20);

INSERT INTO pieza (numpieza, nompieza, preciovent, descripcion)
VALUES ('T-0002-AT', 'TECLADO ESTANDAR PC', 25, 'Sin descripcion');

INSERT INTO pieza (numpieza)
VALUES ('X-0001-PC');

INSERT INTO pieza (numpieza, nompieza, preciovent, descripcion)
VALUES ('P-1113-PC', 'POCKET_PC', 30, 'Periferico de salida');

/*B)*/
INSERT INTO vendedor (numvend, nomvend, nombrecomer, telefono, calle, ciudad, provincia)
VALUES (200, 'Severino M''Dowell', 'SEVESOFT', '666777888', 'General Lacy, 17', 'Alicante', 'Alicante');

INSERT INTO vendedor (numvend, nomvend, nombrecomer, telefono, calle, ciudad, provincia)
VALUES (3, 'Godofredo Martinez', 'MECESMSA', '777888999', 'Avda. Valencia, 3', 'San Vicene', 'Alicante');

INSERT INTO vendedor (numvend, nomvend, nombrecomer, calle, ciudad, provincia)
VALUES (5, 'Juanito Reina Princesa', 'LA''DECAI', 'Asis, 10', 'Gijon', 'Asturias');

INSERT INTO vendedor (numvend, nomvend, nombrecomer, calle, ciudad, provincia)
VALUES (6, 'Manuel Perez Rodriguez', 'SOFTHARD', '2223344567', 'Temul, 1', 'Toledo');

INSERT INTO vendedor (numvend, nomvend, nombrecomer)
VALUES (100, 'Toñi Garcia', 'SOFTHARD'); 

/*C)*/
CREATE SEQUENCE seq_pedidos
START WITH 1
INCREMENT BY 1;

INSERT INTO pedido (numpedido, numvend, fecha)
VALUES (seq_pedidos.nextval, 200, TO_DATE('10/10/2010', 'DD/MM/YYYY'));

INSERT INTO pedido (numpedido, numvend, fecha)
VALUES (seq_pedidos.nextval, 200, TO_DATE('05/08/2023', 'DD/MM/YYYY'));

INSERT INTO pedido (numpedido, numvend, fecha)
VALUES (seq_pedidos.nextval, 3, TO_DATE('05/04/2009', 'DD/MM/YYYY'));

INSERT INTO pedido (numpedido, numvend, fecha)
VALUES (seq_pedidos.nextval, 5, TO_DATE('01/03/2021', 'DD/MM/YYYY'));

/*D)*/
CREATE SEQUENCE seq_preciosum
START WITH 1
INCREMENT BY 1;

INSERT INTO preciosum (idpreciosum, numvend, numpieza, preciounit, diassum, descuento)
VALUES (seq_preciosum.nextval, 3, 'A-1001-L', 5, 3, 10);

INSERT INTO preciosum (idpreciosum, numvend, numpieza, preciounit, diassum)
VALUES (seq_preciosum.nextval, 200, 'C-1002-H', 2, 5);

INSERT INTO preciosum (idpreciosum, numvend, numpieza, diassum)
VALUES (seq_preciosum.nextval, 5, 'DK 144-0002-P', 2);

INSERT INTO preciosum (idpreciosum, numvend, numpieza, diassum, descuento)
VALUES (seq_preciosum.nextval, 100, 'O-0001-PP', 2, 5);

/*G)*/
INSERT INTO pieza (numpieza, preciovent,)
VALUES ('M-0002-JT', 100000000000,50);
/*
No, no lo permite e imprime este error: 

Error starting at line : 86 in command -
INSERT INTO pieza (numpieza, preciovent,)
VALUES ('M-0002-JT', 100000000000,50)
Error at Command Line : 86 Column : 41
Error report -
SQL Error: ORA-01747: invalid user.table.column, table.column, or column specification
01747. 00000 -  "invalid user.table.column, table.column, or column specification"
*Cause:    
*Action:*/





/*ACTIVIDAD 2*/
/*A)*/
UPDATE pedido
SET fecha = TO_DATE('01/01/2024', 'DD/MM/YYYY');

/*B)*/
UPDATE vendedor
SET telefono = 'SIN TELEFONO' WHERE telefono IS NULL;

/*C)*/
UPDATE vendedor
SET (ciudad, provincia) = (
    SELECT provincia, ciudad FROM vendedor WHERE numvend = 6
) WHERE provincia <> 'Alicante';

/*D)*/
UPDATE preciosum
SET preciounit = 10 WHERE preciounit IS NULL;

/*E)*/
UPDATE pieza
SET preciovent = preciovent + 100 WHERE nompieza IN ('USB', 'DISCO INTERNO%', 'DISCO EXTERNO%');

/*F)*/
SAVEPOINT savepoint1;

UPDATE pieza
SET preciovent = 3 WHERE numpieza IN ('A-1001-L', 'C-1002-H', 'C-1002-J', 'C-400-Z', 'DK 144-0001', 'DK 144-0002-P', 'O-0001-PP');

ROLLBACK TO SAVEPOINT savepoint1;





/*ACTIVIDAD 3*/

/*A)*/
DELETE FROM pieza WHERE descripcion IS NULL;

/*B)*/
DELETE FROM pieza WHERE numvend IN (
    SELECT numvend FROM vendedor WHERE nombre = 'JUANITOO REINA PRINCESA'
);

/*C)*/
TRUNCATE TABLE pedido;

/*D)*/
DELETE FROM pieza WHERE numpieza IN ('C-1002-H', 'A-1001-L');






/*ACTIVIDAD 4*/
/*ON DELETE CASCADE: si eliminas una fila de la tabla principal, se elimina en el resto de tablas asociadas

ON DELETE SET NULL: si eliminas una fila de la tabla principal, aparecerá como null en el resto de tablas asociadas 
*/




/*ACTIVIDAD 5*/
/*
COMMIT: confirma y guarda permanentemente los cambios realizados
ROLLBACK: deshace todos los cambios y vuelve al punto de guardado
SAVEPOINT: establece un punto de guardado
SET TRANSACTION: establece caracteristicas de una transaccion como diversas propiedades de control
*/