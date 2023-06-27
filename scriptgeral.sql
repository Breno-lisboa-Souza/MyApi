
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
GO

CREATE TABLE [Jogos] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NULL,
    [Genero] nvarchar(max) NULL,
    [Desenvolvedor] nvarchar(max) NULL,
    CONSTRAINT [PK_Jogos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Latitude] float NULL,
    [Longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [PasswordString] nvarchar(max) NULL,
    [Perfil] nvarchar(max) NULL DEFAULT N'Usuario',
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Favoritos] (
    [Id] int NOT NULL IDENTITY,
    [JogoId] int NOT NULL,
    [UsuarioId] int NOT NULL,
    CONSTRAINT [PK_Favoritos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Favoritos_Jogos_JogoId] FOREIGN KEY ([JogoId]) REFERENCES [Jogos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Favoritos_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [JogoUsuario] (
    [JogoId] int NOT NULL,
    [UsuarioId] int NOT NULL,
    CONSTRAINT [PK_JogoUsuario] PRIMARY KEY ([JogoId], [UsuarioId]),
    CONSTRAINT [FK_JogoUsuario_Jogos_JogoId] FOREIGN KEY ([JogoId]) REFERENCES [Jogos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_JogoUsuario_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Desenvolvedor', N'Genero', N'Nome') AND [object_id] = OBJECT_ID(N'[Jogos]'))
    SET IDENTITY_INSERT [Jogos] ON;
INSERT INTO [Jogos] ([Id], [Descricao], [Desenvolvedor], [Genero], [Nome])
VALUES (1, N'Far Cry 6 ├® um jogo de tiro em primeira pessoa de mundo aberto desenvolvido pela Ubisoft Toronto. Ambientado na ilha fict├¡cia de Yara, os jogadores assumem o papel de Dani Rojas, um guerrilheiro lutando contra o regime opressivo do ditador Anton Castillo. Com um vasto mundo para explorar, combates intensos e uma narrativa envolvente, Far Cry 6 oferece uma experi├¬ncia cheia de a├º├úo e aventura.', N'Ubisoft Toronto', N'Tiro, A├º├úo', N'Far Cry 6'),
(2, N'Bloons TD6 ├® um jogo de estrat├®gia em que os jogadores devem defender seu territ├│rio contra ondas de bal├Áes invasores. O jogo apresenta torres de defesa com habilidades ├║nicas, diversos mapas e modos de jogo, oferecendo uma experi├¬ncia desafiadora e divertida.', N'Ninja Kiwi', N'Estrat├®gia', N'Bloons TD6'),
(3, N'Red Dead Redemption ├® um jogo de a├º├úo e aventura em mundo aberto ambientado no Velho Oeste. Os jogadores assumem o papel de um pistoleiro chamado John Marston, que deve ca├ºar criminosos e enfrentar desafios em uma hist├│ria ├®pica. O jogo oferece um vasto mundo para explorar, com muitas miss├Áes e atividades para realizar.', N'Rockstar San Diego', N'A├º├úo, Aventura', N'Red Dead Redemption'),
(4, N'Valorant ├® um jogo de tiro t├ítico em primeira pessoa desenvolvido pela Riot Games. No jogo, duas equipes competem em partidas de ataque e defesa, utilizando personagens com habilidades ├║nicas. Com combates estrat├®gicos e trabalho em equipe, Valorant oferece uma experi├¬ncia de jogo emocionante e competitiva.', N'Riot Games', N'Tiro em primeira pessoa', N'Valorant'),
(5, N'Counter-Strike: Global Offensive ├® um jogo de tiro em primeira pessoa competitivo. Os jogadores se juntam a equipes terroristas ou antiterroristas e participam de partidas intensas em diversos modos de jogo. Com uma jogabilidade estrat├®gica e habilidades individuais em teste, CS:GO continua sendo um dos jogos mais populares do g├¬nero.', N'Valve', N'Tiro em primeira pessoa', N'Counter-Strike: Global Offensive');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Desenvolvedor', N'Genero', N'Nome') AND [object_id] = OBJECT_ID(N'[Jogos]'))
    SET IDENTITY_INSERT [Jogos] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'PasswordString', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] ON;
INSERT INTO [Usuarios] ([Id], [DataAcesso], [Email], [Latitude], [Longitude], [PasswordHash], [PasswordSalt], [PasswordString], [Perfil], [Username])
VALUES (1, NULL, N'seuEmail@gmail.com', -23.520024100000001E0, -46.596497999999997E0, 0x1B8DDDAE3390B8095EFC5898D040B93DAAA72093448932E25C1E2610C5A0925D83D5C59E1FD21EF119BC44266B51999E1869723040B76A228B62C435433C64C8, 0x9884C371A9AF3157686502CC364AE98820027442916BEA6B5CEBD3DCDE8718AF614C7B85F3132506AE4A0384A9EB8FB7419A40151D2E5458F34C9892949674E0730604B1D64F6FA83F8E4FF0CF77968792399D36B6C94A4F89C435BDBD79279DE6A3546ACCC5BEB4DB955CCAFC5C359AC35B3CD88940B074C166E93F9DDB0E3D, N'', N'Admin', N'UsuarioAdmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'PasswordString', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] OFF;
GO

CREATE INDEX [IX_Favoritos_JogoId] ON [Favoritos] ([JogoId]);
GO

CREATE INDEX [IX_Favoritos_UsuarioId] ON [Favoritos] ([UsuarioId]);
GO

CREATE INDEX [IX_JogoUsuario_UsuarioId] ON [JogoUsuario] ([UsuarioId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230626234504_InitialCreate', N'7.0.5');
GO

COMMIT;
GO


