CREATE TABLE pontos_turisticos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_Loc VARCHAR(100) NOT NULL,
    est_Loc VARCHAR(2) NOT NULL,
    desc_Loc VARCHAR(100) NOT NULL,
    ref_Loc VARCHAR(100) NOT NULL,
    descritivos_Loc VARCHAR(100) NOT NULL,
);



INSERT INTO pontos_turisticos (nome_Loc, est_Loc, desc_Loc, ref_Loc, descritivos_Loc) 
VALUES 
('Lagoa azul', 'MT', 'Primavera do Leste', 'Fazenda Tupã III, na rodovia MT-130, sentido Paranatinga.', 'Águas cristalinas perfeitas'),

('Lençóis Maranhenses', 'MA', 'Barreirinhas', 'Barreirinhas', 'Imensidão de areia, dunas fantásticas e lagoas que surgem no meio do nada'),

('Pelourinho', 'BA', 'Salvador', 'Centro Histórico de Salvador', 'Ruas estreitas, enladeiradas e com calçamento em paralelepípedos.'),

('Cristo Redentor', 'RJ', 'Rio de Janeiro', 'Morro do Corcovado', 'Estátua que retrata Jesus Cristo com trinta metros de altura'),

('Cataratas do Iguaçu', 'PR', 'Paraná', 'Bacia hidrográfica do rio Paraná', 'Conjunto de cerca de 275 quedas de água no rio Iguaçu'),

('Fernando de Noronha', 'PE', 'Pernambuco', 'Oceano Atlântico a nordeste do Brasil continental, distando 350 km do Rio Grande do Norte e 545 km da capital pernambucana, Recife', 'Arquipélago brasileiro do estado de Pernambuco, formado por 21 ilhas'),

('Jardim Botânico', 'PR', 'Curitiba', 'Bairro Jardim Botânico', 'Exemplares vegetais do Brasil e de outros países, espalhados por alamedas e estufas de ferro e vidro');
