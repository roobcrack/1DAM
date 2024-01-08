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
<<<<<<< HEAD
    numpieza VARCHAR2(255) NOT NULL,
    nompieza VARCHAR2(255),
    preciovent NUMBER,
=======
    numpieza VARCHAR2(20) NOT NULL,
    nompieza VARCHAR2(20),
    preciovent VARCHAR2(20),
>>>>>>> 40b24d7a195091f105c65ca3c5d10da529ef55ae
    CONSTRAINT pk_pieza PRIMARY KEY(numpieza)
);

CREATE TABLE pedido (
<<<<<<< HEAD
    numpedido NUMBER NOT NULL,
    numvend NUMBER,
    fecha DATE DEFAULT SYSDATE,
=======
    numpedido VARCHAR2 NOT NULL,
    numvend VARCHAR2(20),
    fecha DATE,
>>>>>>> 40b24d7a195091f105c65ca3c5d10da529ef55ae
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
<<<<<<< HEAD
    numbin NUMBER NOT NULL,
    numpieza VARCHAR2(255),
=======
    numbin VARCHAR2(20) NOT NULL,
    numpieza NUMBER,
>>>>>>> 40b24d7a195091f105c65ca3c5d10da529ef55ae
    cantdisponible NUMBER,
    fecharecuento DATE DEFAULT SYSDATE,
    periodorecuen NUMBER,
    cantminima NUMBER,
    CONSTRAINT pk_inventario PRIMARY KEY (numbin)
);

CREATE TABLE preciosum (
<<<<<<< HEAD
    numpieza VARCHAR2(255) NOT NULL,
=======
    numpieza VARCHAR2(20) NOT NULL,
>>>>>>> 40b24d7a195091f105c65ca3c5d10da529ef55ae
    numvend NUMBER NOT NULL,
    preciounit NUMBER,
    diassum NUMBER,
    descuento NUMBER,
    CONSTRAINT pk_preciosum PRIMARY KEY (numpieza, numvend)
);


ALTER TABLE preciosum
ADD CONSTRAINT fk_numpieza
    FOREIGN KEY (numpieza)
    REFERENCES pieza (numpieza);
ADD CONSTRAINT fk_numvend
    FOREIGN KEY (numvend)
    REFERENCES vendedor (numvend);

ALTER TABLE pedido
ADD CONSTRAINT fk_numvend
    FOREIGN KEY (numvend)
    REFERENCES vendedor (numvend);

ALTER TABLE linped
ADD CONSTRAINT fk_numpieza
    FOREIGN KEY (numpieza)
    REFERENCES pieza (numpieza)
ADD CONSTRAINT fk_numpedido
    FOREIGN KEY (numpedido)
    REFERENCES pedido (numpedido);

ALTER TABLE linped
ADD CONSTRAING uk_numpieza
    UNIQUE (numpieza);
