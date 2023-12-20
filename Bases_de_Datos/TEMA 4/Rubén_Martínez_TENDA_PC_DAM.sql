CREATE TABLE vendedor (
    numvend NUMBER() NOT NULL,
    nomvend VARCHAR2(),
    nombrecomer VARCHAR2(),
    telefono NUMBER(),
    calle VARCHAR2(),
    ciudad VARCHAR2(),
    provincia VARCHAR2(),
    CONSTRAINT pk_vendedor PRIMARY KEY (numvend)
);

CREATE TABLE pieza (
    numpieza NUMBER() NOT NULL,
    nompieza VARCHAR2(),
    preciovent NUMBER(),
    CONSTRAINT pk_pieza PRIMARY KEY(numpieza)
);

CREATE TABLE pedido (
    numpedido  NUMBER()
);