IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [CLIENTES] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Cpf] int NOT NULL,
    [Rg] int NOT NULL,
    [Endereco] varchar(200) NOT NULL,
    [Email] varchar(200) NOT NULL,
    CONSTRAINT [PK_CLIENTES] PRIMARY KEY ([Id])
);

CREATE TABLE [PARTIDAS] (
    [Id] int NOT NULL IDENTITY,
    [Data] datetime2 NOT NULL,
    [Estadio] varchar(200) NOT NULL,
    [TimeCasa] varchar(200) NOT NULL,
    [TimeFora] varchar(200) NOT NULL,
    CONSTRAINT [PK_PARTIDAS] PRIMARY KEY ([Id])
);

CREATE TABLE [TIMES] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Sigla] varchar(200) NOT NULL,
    [FundadoEm] datetime2 NOT NULL,
    [Cidade] varchar(200) NOT NULL,
    [Estado] varchar(200) NOT NULL,
    [Pais] varchar(200) NOT NULL,
    [Estadio] varchar(200) NOT NULL,
    [MaiorRival] varchar(200) NOT NULL,
    [Mascote] varchar(200) NOT NULL,
    [Logo] varchar(200) NOT NULL,
    CONSTRAINT [PK_TIMES] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cpf', N'Email', N'Endereco', N'Nome', N'Rg') AND [object_id] = OBJECT_ID(N'[CLIENTES]'))
    SET IDENTITY_INSERT [CLIENTES] ON;
INSERT INTO [CLIENTES] ([Id], [Cpf], [Email], [Endereco], [Nome], [Rg])
VALUES (1, 546812798, 'Renanalmeidadantas2007@gmail.com', 'Rua Jonas Cardoso N: 16B ', 'Renan', 1241454213),
(2, 124345325, 'DanilloLacerdad470', 'Rua Serra Do Apodi', 'Danillo', 235252436),
(3, 21345235, 'FelipeSilva@gmail.com', 'Rua Elisa do Apodi', 'Felipe', 123542253);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cpf', N'Email', N'Endereco', N'Nome', N'Rg') AND [object_id] = OBJECT_ID(N'[CLIENTES]'))
    SET IDENTITY_INSERT [CLIENTES] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data', N'Estadio', N'TimeCasa', N'TimeFora') AND [object_id] = OBJECT_ID(N'[PARTIDAS]'))
    SET IDENTITY_INSERT [PARTIDAS] ON;
INSERT INTO [PARTIDAS] ([Id], [Data], [Estadio], [TimeCasa], [TimeFora])
VALUES (1, '2024-11-04T20:00:00.0000000', 'Neo Quimica Arena', 'Corinthians', 'Palmeiras'),
(2, '2024-11-09T16:30:00.0000000', 'Barradão', 'Vitoria', 'Corinthians');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data', N'Estadio', N'TimeCasa', N'TimeFora') AND [object_id] = OBJECT_ID(N'[PARTIDAS]'))
    SET IDENTITY_INSERT [PARTIDAS] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cidade', N'Estadio', N'Estado', N'FundadoEm', N'Logo', N'MaiorRival', N'Mascote', N'Nome', N'Pais', N'Sigla') AND [object_id] = OBJECT_ID(N'[TIMES]'))
    SET IDENTITY_INSERT [TIMES] ON;
INSERT INTO [TIMES] ([Id], [Cidade], [Estadio], [Estado], [FundadoEm], [Logo], [MaiorRival], [Mascote], [Nome], [Pais], [Sigla])
VALUES (1, 'São Paulo', 'Neo Quimica Arena', 'SP', '1910-10-01T00:00:00.0000000', 'https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ', 'Palmeiras', 'Mosqueteiro', 'Corinthians', 'Brasil', 'Sccp'),
(2, 'São Paulo', 'Morumbi', 'SP', '1930-12-25T00:00:00.0000000', 'https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI', 'Corinthians', 'Santo Paulo', 'São Paulo', 'Brasil', 'SPFC'),
(3, 'Belo Horizonte', 'Mineirão', 'BH', '1921-01-02T00:00:00.0000000', 'https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI', 'Atlético Mg', 'Raposa', 'Cruzeiro', 'Brasil', 'Cru'),
(4, 'Bragança Paulista', 'Nabi Abi Chedid', 'SP', '1928-01-28T00:00:00.0000000', 'https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ', 'Corinthians', 'Touro', 'Bragantino', 'Brasil', 'Bra');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cidade', N'Estadio', N'Estado', N'FundadoEm', N'Logo', N'MaiorRival', N'Mascote', N'Nome', N'Pais', N'Sigla') AND [object_id] = OBJECT_ID(N'[TIMES]'))
    SET IDENTITY_INSERT [TIMES] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241120231643_InitialCreate', N'9.0.0');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241121132931_conexaoSomee', N'9.0.0');

COMMIT;
GO

