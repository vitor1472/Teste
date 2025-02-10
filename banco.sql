create table pontos_turisticos(
	codigo tinyint not null primary key identity,
	nome_Loc nvarchar(50) not null,
	est_Loc nvarchar(50) not null,
	desc_Loc nvarchar(50) not null,
	ref_Loc real not null,
	descritivos_Loc nvarchar(50) not null,
)

select*from pontos_turisticos

ALTER TABLE pontos_turisticos
ALTER COLUMN ref_Loc NVARCHAR(50);

insert into pontos_turisticos values('Cristo Redentor', 'RJ', 'Rio de janeiro','topo do Corcovado','Estatua referencial religiosa de Jesus Cristo')