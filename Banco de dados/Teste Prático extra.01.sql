CREATE TABLE T2Cdd (
    id int not null primary key identity,
    nome VARCHAR(100) NOT NULL,
    estado VARCHAR(100) NOT NULL,
    pais VARCHAR(100) NOT NULL,
);

INSERT INTO T2Cdd (nome, estado, pais) VALUES
('São Paulo', 'São Paulo', 'Brasil'),
('Rio de Janeiro', 'Rio de Janeiro', 'Brasil'),
('Paris', 'Île-de-France', 'França'),
('Tóquio', 'Tóquio', 'Japão'),
('Nova Iorque', 'Nova Iorque', 'Estados Unidos'),
('Londres', 'Inglaterra', 'Reino Unido'),
('Buenos Aires', 'Buenos Aires', 'Argentina'),
('Barcelona', 'Catalunha', 'Espanha'),
('Belo Horizonte', 'Minas Gerais', 'Brasil'),
('Cidade do México', 'CDMX', 'México');

select *from T2Cdd

create view ct_T2Cdd as
select id, nome, estado, pais
from T2Cdd;

select *from ct_T2Cdd

