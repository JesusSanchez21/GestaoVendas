create table fornecedores(
    id int PRIMARY KEY identity(1,1),
    nome varchar(150) not null,
    nomeEmpresa varchar(150) not null,
    numeroInterno bigint
);

create table produtos(
    id int PRIMARY KEY identity(1,1),
    nome varchar(150) not null,
    fornecedor_id int not null,
    FOREIGN KEY(fornecedor_id) REFERENCES fornecedores(id)
);

create TABLE clientes(
    id int PRIMARY KEY identity(1,1),
    nome varchar(150) not null,
    morada varchar(200),
    telefone varchar(15),
    email varchar(255) not null
);

create TABLE funcionarios(
    id int PRIMARY KEY identity(1,1),
    nome varchar(150) not null,
    morada varchar(200),
    telefone varchar(15),
    email varchar(255),
    numeroInterno bigint
);

create TABLE encomendas(
    id int PRIMARY KEY,
    cliente_id int,
    funcionario_id int,
    dataEncomenda DateTime not null,
    valorTotal float not null,
    Foreign key(cliente_id) REFERENCES clientes(id),
    Foreign key(funcionario_id) REFERENCES funcionarios(id)
);

create table encomendas_produtos(
 id int PRIMARY KEY identity(1,1),
    produto_id int FOREIGN KEY REFERENCES produtos(id),
    encomenda_id int FOREIGN KEY REFERENCES encomendas(id),
    quantidade int
);

create TABLE pagamento(
    id int PRIMARY KEY identity(1,1),
    encomenda_id int not null,
    FOREIGN KEY(encomenda_id) REFERENCES encomendas(id),
    prontoPagamento bit not null,
    entidade int,
    referencia int,
    dataPagamento DateTime not null
);