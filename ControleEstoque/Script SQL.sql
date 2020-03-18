CREATE TABLE [categoria]
( 
	[cat_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[cat_nome]           varchar(95)  NULL 
)
go

ALTER TABLE [categoria]
	ADD CONSTRAINT [XPKcategoria] PRIMARY KEY  NONCLUSTERED ([cat_cod] ASC)
go

CREATE TABLE [cliente]
( 
	[cli_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[cli_nome]           varchar(95)  NULL ,
	[cli_cpfcnpj]        varchar(95)  NULL ,
	[cli_rsocial]        varchar(95)  NULL ,	
	[cli_cep]            varchar(20)  NULL ,
	[cli_endereco]       varchar(95)  NULL ,
	[cli_bairro]         varchar(95)  NULL ,
	[cli_fone]           varchar(95)  NULL ,	
	[cli_email]          varchar(95)  NULL ,
	[cli_endnumero]      varchar(10)  NULL ,
	[cli_cidade]         varchar(95)  NULL ,
	[cli_estado]         varchar(95)  NULL 
)
go

ALTER TABLE [cliente]
	ADD CONSTRAINT [XPKcliente] PRIMARY KEY  NONCLUSTERED ([cli_cod] ASC)
go

CREATE TABLE [fornecedor]
( 
	[for_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[for_nome]           varchar(95)  NULL ,	
	[for_cnpj]           varchar(95)  NULL ,
	[for_cep]            varchar(95)  NULL ,
	[for_endereco]       varchar(95)  NULL ,
	[for_bairro]         varchar(95)  NULL ,
	[for_fone]           varchar(95)  NULL ,	
	[for_email]          varchar(95)  NULL ,
	[for_endnumero]      varchar(95)  NULL ,
	[for_cidade]         varchar(95)  NULL ,
	[for_estado]         varchar(95)  NULL 
)
go

ALTER TABLE [fornecedor]
	ADD CONSTRAINT [XPKfornecedor] PRIMARY KEY  NONCLUSTERED ([for_cod] ASC)
go

CREATE TABLE [produto]
( 
	[pro_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[pro_nome]           varchar(95)  NULL ,
	[pro_descricao]      text  NULL ,
	[pro_foto]           image  NULL ,
	[pro_valorpago]      money  NULL ,
	[pro_valorvenda]     money  NULL ,
	[pro_qtde]           float  NULL ,
	[umed_cod]           int  NULL ,
	[cat_cod]            int  NULL ,
	[scat_cod]           int  NULL 
)
go

ALTER TABLE [produto]
	ADD CONSTRAINT [XPKproduto] PRIMARY KEY  NONCLUSTERED ([pro_cod] ASC)
go

CREATE TABLE [subcategoria]
( 
	[scat_cod]           int  NOT NULL  IDENTITY ( 1,1 ) ,
	[scat_nome]          varchar(95)  NULL ,
	[cat_cod]            int  NULL 
)
go

ALTER TABLE [subcategoria]
	ADD CONSTRAINT [XPKsubcategoria] PRIMARY KEY  NONCLUSTERED ([scat_cod] ASC)
go

CREATE TABLE [undmedida]
( 
	[umed_cod]           int  NOT NULL  IDENTITY ( 1,1 ) ,
	[umed_nome]          varchar(95)  NULL 
)
go

ALTER TABLE [undmedida]
	ADD CONSTRAINT [XPKmedida] PRIMARY KEY  NONCLUSTERED ([umed_cod] ASC)
go

ALTER TABLE [produto]
	ADD CONSTRAINT [R_9] FOREIGN KEY ([umed_cod]) REFERENCES [undmedida]([umed_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [produto]
	ADD CONSTRAINT [R_11] FOREIGN KEY ([cat_cod]) REFERENCES [categoria]([cat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [produto]
	ADD CONSTRAINT [R_12] FOREIGN KEY ([scat_cod]) REFERENCES [subcategoria]([scat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [subcategoria]
	ADD CONSTRAINT [R_10] FOREIGN KEY ([cat_cod]) REFERENCES [categoria]([cat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

