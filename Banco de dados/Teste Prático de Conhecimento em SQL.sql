CREATE TABLE clientes (
	id int not null primary key identity,
    nome NVARCHAR(100),
    email NVARCHAR(100) UNIQUE,
    telefone NVARCHAR(15),
    data_nascimento DATE,
    endereco NVARCHAR(200),
    cidade NVARCHAR(50),
    estado NVARCHAR(50),
    cep NVARCHAR(10)
);

INSERT INTO clientes (nome, email, telefone, data_nascimento, endereco, cidade, estado, cep)
VALUES
('Ana Moreira', 'ana.moreira@email.com', '3496-1515', '2000-05-14', 'Rua Monte alto, 123', 'S�o Paulo', 'SP', '176601-350'),
('Carlos junior', 'carlos.junin014@email.com', '3441-2303', '2003-07-23', 'Av. anibal davolli, 456', 'Tup�', 'SP', '3452-3526'),
('Mariana Gomes', 'mariana.gomes@email.com', '3496-7890', '2004-11-30', 'Rua Dima bastos, 789', 'Paran�', 'PR', '22060-030'),
('Pedro Pereira', 'pedro.pereira@email.com', '3496-0001', '1988-03-05', 'Rua Armando chimak, 321', 'H�rculandia', 'SP', '30123-456'),
('Juliana Rodrigues', 'juliana.rodrgues@email.com', '3441-2244', '1976-01-17', 'Alameda plymouth, 1551', 'Curitiba', 'PR', '80030-120')

select *from clientes

select nome from clientes c where exists (select 1 from clientes where cidade = 'Tup�' AND id = c.id);

select nome, cidade from clientes;

select id, nome from clientes order by nome;

delete  from clientes where id between 100 and 200

update clientes set estado = 'SP' where estado = 'PR'

insert into clientes (nome, email, telefone, cidade, data_nascimento, endereco)
VALUES ('Jo�o Roberto', 'joao.godoy@email.com', '1234-5678', 'Tup�', '2004-08-18', 'Rua miguel gantus, 935');