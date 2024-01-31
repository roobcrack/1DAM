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