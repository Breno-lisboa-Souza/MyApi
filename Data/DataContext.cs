using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyApi.Models;
using MyApi.Utils;

namespace MyApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Favorito> Favoritos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Jogo> Jogos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Jogo>().HasData(
                new Jogo()
                {
                    Id = 1,
                    Nome = "Far Cry 6",
                    Descricao = "Far Cry 6 é um jogo de tiro em primeira pessoa de mundo aberto desenvolvido pela Ubisoft Toronto. Ambientado na ilha fictícia de Yara, os jogadores assumem o papel de Dani Rojas, um guerrilheiro lutando contra o regime opressivo do ditador Anton Castillo. Com um vasto mundo para explorar, combates intensos e uma narrativa envolvente, Far Cry 6 oferece uma experiência cheia de ação e aventura.",
                    Genero = "Tiro, Ação",
                    //DataL = Convert.ToDateTime("07/10/2021"),
                    Desenvolvedor = "Ubisoft Toronto"
                },

                new Jogo()
                {
                    Id = 2,
                    Nome = "Bloons TD6",
                    Descricao = "Bloons TD6 é um jogo de estratégia em que os jogadores devem defender seu território contra ondas de balões invasores. O jogo apresenta torres de defesa com habilidades únicas, diversos mapas e modos de jogo, oferecendo uma experiência desafiadora e divertida.",
                    Genero = "Estratégia",
                    //DataL = Convert.ToDateTime("14/06/2018"),
                    Desenvolvedor = "Ninja Kiwi",
                },

                new Jogo()
                {
                    Id = 3,
                    Nome = "Red Dead Redemption",
                    Descricao = "Red Dead Redemption é um jogo de ação e aventura em mundo aberto ambientado no Velho Oeste. Os jogadores assumem o papel de um pistoleiro chamado John Marston, que deve caçar criminosos e enfrentar desafios em uma história épica. O jogo oferece um vasto mundo para explorar, com muitas missões e atividades para realizar.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("18/05/2010"),
                    Desenvolvedor = "Rockstar San Diego",
                },


                new Jogo()
                {
                    Id = 4,
                    Nome = "Valorant",
                    Descricao = "Valorant é um jogo de tiro tático em primeira pessoa desenvolvido pela Riot Games. No jogo, duas equipes competem em partidas de ataque e defesa, utilizando personagens com habilidades únicas. Com combates estratégicos e trabalho em equipe, Valorant oferece uma experiência de jogo emocionante e competitiva.",
                    Genero = "Tiro em primeira pessoa",
                    //DataL = Convert.ToDateTime("02/06/2020"),
                    Desenvolvedor = "Riot Games"
                },

                new Jogo()
                {
                    Id = 5,
                    Nome = "Counter-Strike: Global Offensive",
                    Descricao = "Counter-Strike: Global Offensive é um jogo de tiro em primeira pessoa competitivo. Os jogadores se juntam a equipes terroristas ou antiterroristas e participam de partidas intensas em diversos modos de jogo. Com uma jogabilidade estratégica e habilidades individuais em teste, CS:GO continua sendo um dos jogos mais populares do gênero.",
                    Genero = "Tiro em primeira pessoa",
                    //DataL = Convert.ToDateTime("21/08/2012"),
                    Desenvolvedor = "Valve"
                },

                new Jogo()
                {
                    Id = 6,
                    Nome = "League of Legends",
                    Descricao = "League of Legends é um jogo online de batalha multiplayer em arenas (MOBA). Duas equipes de campeões únicos se enfrentam em intensas batalhas, com o objetivo de destruir o nexus inimigo. Com estratégia, trabalho em equipe e habilidades individuais, League of Legends é um dos jogos mais populares e competitivos do mundo.",
                    Genero = "MOBA",
                    //DataL = Convert.ToDateTime("27/10/2009"),
                    Desenvolvedor = "Riot Games"
                },

                new Jogo()
                {
                    Id = 7,
                    Nome = "Dota 2",
                    Descricao = "Dota 2 é um jogo online de batalha multiplayer em arenas (MOBA) desenvolvido pela Valve. Os jogadores formam equipes e batalham para destruir o Ancião inimigo, com a ajuda de heróis poderosos e estratégias elaboradas. Com uma grande variedade de heróis e uma comunidade ativa, Dota 2 oferece uma experiência desafiadora e competitiva.",
                    Genero = "MOBA",
                    //DataL = Convert.ToDateTime("09/07/2013"),
                    Desenvolvedor = "Valve",
                },


                new Jogo()
                {
                    Id = 8,
                    Nome = "Minecraft",
                    Descricao = "Minecraft é um jogo de construção e aventura em um mundo sandbox. Os jogadores podem explorar, construir estruturas e objetos, coletar recursos e enfrentar criaturas em um ambiente pixelizado. Com sua jogabilidade criativa e possibilidades infinitas, Minecraft se tornou um fenômeno mundial.",
                    Genero = "Sandbox, Aventura",
                    //DataL = Convert.ToDateTime("18/11/2011"),
                    Desenvolvedor = "Mojang Studios",
                },

                new Jogo()
                {
                    Id = 9,
                    Nome = "Grand Theft Auto V",
                    Descricao = "Grand Theft Auto V é um jogo de ação e aventura em mundo aberto desenvolvido pela Rockstar North. Nele, os jogadores podem explorar a cidade fictícia de Los Santos, realizar missões, participar de atividades e interagir com personagens diversos.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("17/09/2013"),
                    Desenvolvedor = "Rockstar North",
                },
                    
                new Jogo()    
                {
                    Id = 10,
                    Nome = "Fortnite",
                    Descricao = "Fortnite é um jogo de tiro em terceira pessoa com elementos de construção. Os jogadores são colocados em um mapa onde devem lutar contra outros jogadores, enquanto constroem estruturas e procuram por recursos. Com modos de jogo variados e eventos frequentes, Fortnite se tornou um dos jogos mais populares do mundo.",
                    Genero = "Battle Royale, Construção",
                    //DataL = Convert.ToDateTime("25/07/2017"),
                    Desenvolvedor = "Epic Games",
                },

                new Jogo()
                {
                    Id = 11,
                    Nome = "World of Warcraft",
                    Descricao = "World of Warcraft é um MMORPG ambientado no mundo de fantasia de Azeroth. Os jogadores podem criar personagens, explorar vastas terras, realizar missões, participar de batalhas épicas e interagir com outros jogadores. Com uma história rica e constantes atualizações, World of Warcraft continua sendo um dos jogos mais populares do gênero.",
                    Genero = "MMORPG",
                    //DataL = Convert.ToDateTime("23/11/2004"),
                    Desenvolvedor = "Blizzard Entertainment"
                },

                new Jogo()
                {
                    Id = 12,
                    Nome = "The Sims 4",
                    Descricao = "The Sims 4 é um jogo de simulação de vida em que os jogadores podem criar e controlar personagens virtuais, chamados Sims. Eles podem construir casas, desenvolver relacionamentos, buscar carreiras e viver diversas experiências. Com sua jogabilidade cativante e ferramentas de criação, The Sims 4 é um dos jogos mais populares da franquia.",
                    Genero = "Simulação",
                    //DataL = Convert.ToDateTime("02/09/2014"),
                    Desenvolvedor = "Maxis"
                },
                new Jogo()
                {
                    Id = 13,
                    Nome = "Call of Duty: Warzone",
                    Descricao = "Call of Duty: Warzone é um jogo de battle royale gratuito que faz parte da franquia Call of Duty. Os jogadores são lançados em um mapa vasto onde devem lutar contra outros jogadores para serem o último sobrevivente. Com um combate intenso e diversas armas e veículos, Warzone oferece uma experiência emocionante.",
                    Genero = "Battle Royale, Tiro",
                    //DataL = Convert.ToDateTime("10/03/2020"),
                    Desenvolvedor = "Infinity Ward"
                },

                new Jogo()
                {
                    Id = 14,
                    Nome = "Valorant",
                    Descricao = "Valorant é um jogo de tiro tático em equipe desenvolvido pela Riot Games. Os jogadores participam de partidas 5v5 onde devem completar objetivos e eliminar o time adversário. Com personagens únicos e habilidades especiais, Valorant combina estratégia e habilidade individual.",
                    Genero = "Tiro, Estratégia",
                    //DataL = Convert.ToDateTime("02/06/2020"),
                    Desenvolvedor = "Riot Games"
                },
                    
                new Jogo()
                {
                    Id = 15,
                    Nome = "Apex Legends",
                    Descricao = "Apex Legends é um jogo de tiro em equipe no estilo battle royale ambientado no universo do jogo Titanfall. Os jogadores formam esquadrões e competem contra outros times em um mapa repleto de ação. Com personagens únicos, habilidades especiais e um combate dinâmico, Apex Legends conquistou uma grande base de fãs.",
                    Genero = "Battle Royale, Tiro",
                    //DataL = Convert.ToDateTime("04/02/2019"),
                    Desenvolvedor = "Respawn Entertainment"
                },

                new Jogo()
                {
                    Id = 16,
                    Nome = "Battlefield V",
                    Descricao = "Battlefield V é um jogo de tiro em primeira pessoa ambientado na Segunda Guerra Mundial. Os jogadores participam de batalhas multiplayer épicas em cenários históricos, além de vivenciar uma campanha para um jogador emocionante. Com um foco em combate realista e uma ampla variedade de modos de jogo, Battlefield V oferece uma experiência de guerra imersiva.",
                    Genero = "Tiro",
                    //DataL = Convert.ToDateTime("20/11/2018"),
                    Desenvolvedor = "DICE"
                },

                new Jogo()
                {
                    Id = 17,
                    Nome = "FIFA",
                    Descricao = "FIFA é uma série de jogos de simulação de futebol desenvolvida pela EA Sports. Os jogadores podem controlar times e competir em partidas de futebol realistas, com gráficos impressionantes e uma jogabilidade envolvente. Com licenças oficiais de jogadores, times e ligas, FIFA oferece uma experiência autêntica para os fãs de futebol.",
                    Genero = "Esporte, Simulação",
                    //DataL = Convert.ToDateTime("15/12/1993"),
                    Desenvolvedor = "EA Vancouver"
                },

                new Jogo()
                {
                    Id = 18,
                    Nome = "Overwatch",
                    Descricao = "Overwatch é um jogo de tiro em equipe desenvolvido pela Blizzard Entertainment. Os jogadores formam times e participam de intensas batalhas multiplayer em um futuro próximo. Com uma variedade de heróis com habilidades únicas, Overwatch combina ação frenética, estratégia e trabalho em equipe.",
                    Genero = "Tiro",
                    //DataL = Convert.ToDateTime("24/05/2016"),
                    Desenvolvedor = "Blizzard Entertainment"
                },

                new Jogo()
                {
                    Id = 19,
                    Nome = "Rainbow Six Siege",
                    Descricao = "Rainbow Six Siege é um jogo de tiro tático em equipe desenvolvido pela Ubisoft. Os jogadores assumem o papel de agentes de elite e participam de emocionantes confrontos em equipe. Com um foco em estratégia, comunicação e destruição de ambientes, Rainbow Six Siege oferece uma experiência de jogo intensa e repleta de ação.",
                    Genero = "Tiro, Estratégia",
                    //DataL = Convert.ToDateTime("01/12/2015"),
                    Desenvolvedor = "Ubisoft Montreal"
                },

                new Jogo()
                {
                    Id = 20,
                    Nome = "PlayerUnknown's Battlegrounds (PUBG)",
                    Descricao = "PlayerUnknown's Battlegrounds, comumente conhecido como PUBG, é um jogo de battle royale onde os jogadores lutam entre si em uma ilha até que reste apenas um sobrevivente. Os jogadores devem encontrar armas, equipamentos e veículos enquanto enfrentam outros jogadores em uma luta pela sobrevivência.",
                    Genero = "Battle Royale, Tiro",
                    //DataL = Convert.ToDateTime("20/12/2017"),
                    Desenvolvedor = "PUBG Corporation"
                },

                new Jogo()
                {
                    Id = 21,
                    Nome = "Diablo III",
                    Descricao = "Diablo III é um jogo de RPG de ação desenvolvido pela Blizzard Entertainment. Os jogadores assumem o papel de um herói lutando contra as forças do mal, enfrentando hordas de inimigos, coletando tesouros e melhorando suas habilidades. Com uma narrativa envolvente e uma jogabilidade viciante, Diablo III é um dos principais jogos do gênero.",
                    Genero = "RPG, Ação",
                    //DataL = Convert.ToDateTime("15/05/2012"),
                    Desenvolvedor = "Blizzard Entertainment"
                },

                new Jogo()
                {
                    Id = 22,
                    Nome = "Far Cry 5",
                    Descricao = "Far Cry 5 é um jogo de tiro em primeira pessoa de mundo aberto desenvolvido pela Ubisoft. Ambientado em uma região fictícia dos Estados Unidos, os jogadores devem enfrentar um culto religioso perigoso enquanto exploram o mundo aberto e participam de missões emocionantes. Com uma jogabilidade imersiva e gráficos impressionantes, Far Cry 5 oferece uma experiência de ação intensa.",
                    Genero = "Tiro, Aventura",
                    //DataL = Convert.ToDateTime("27/03/2018"),
                    Desenvolvedor = "Ubisoft Montreal"
                },

                new Jogo()
                {
                    Id = 23,
                    Nome = "Red Dead Redemption 2",
                    Descricao = "Red Dead Redemption 2 é um jogo de ação e aventura em mundo aberto desenvolvido pela Rockstar Games. Situado no Velho Oeste, os jogadores assumem o papel de um fora da lei enquanto exploram um vasto mundo, realizam missões, interagem com personagens e vivenciam uma história épica. Com gráficos deslumbrantes e uma jogabilidade imersiva, Red Dead Redemption 2 é uma obra-prima dos jogos.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("26/10/2018"),
                    Desenvolvedor = "Rockstar Games"
                },

                new Jogo()
                {
                    Id = 24,
                    Nome = "Resident Evil Village",
                    Descricao = "Resident Evil Village é um jogo de terror e sobrevivência desenvolvido pela Capcom. Continuando a história de Resident Evil 7, os jogadores assumem o papel de Ethan Winters em uma vila assustadora e repleta de perigos. Com uma combinação de combate tenso, quebra-cabeças desafiadores e uma atmosfera sinistra, Resident Evil Village oferece uma experiência aterrorizante.",
                    Genero = "Terror, Sobrevivência",
                    //DataL = Convert.ToDateTime("07/05/2021"),
                    Desenvolvedor = "Capcom"
                },

                new Jogo()
                {
                    Id = 25,
                    Nome = "Cyberpunk 2077",
                    Descricao = "Cyberpunk 2077 é um jogo de RPG de ação ambientado em um futuro distópico. Os jogadores assumem o papel de V, um mercenário em busca de uma implante lendário que concede imortalidade. Com uma cidade vasta e cheia de possibilidades, escolhas morais significativas e uma história envolvente, Cyberpunk 2077 oferece uma experiência única.",
                    Genero = "RPG, Ação",
                    //DataL = Convert.ToDateTime("10/12/2020"),
                    Desenvolvedor = "CD Projekt Red"
                },

                new Jogo()
                {
                    Id = 26,
                    Nome = "Assassin's Creed Valhalla",
                    Descricao = "Assassin's Creed Valhalla é um jogo de ação e aventura em mundo aberto da série Assassin's Creed. Situado na era dos vikings, os jogadores assumem o papel de Eivor, um guerreiro viking em busca de um novo lar. Com batalhas épicas, exploração de vastos territórios e uma narrativa rica, Assassin's Creed Valhalla oferece uma experiência imersiva no mundo viking.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("10/11/2020"),
                    Desenvolvedor = "Ubisoft Montreal"
                },

                new Jogo()
                {
                    Id = 27,
                    Nome = "Elder Scrolls V: Skyrim",
                    Descricao = "The Elder Scrolls V: Skyrim é um jogo de RPG de ação em mundo aberto desenvolvido pela Bethesda Game Studios. Os jogadores assumem o papel de um personagem personalizável e embarcam em uma jornada épica em Skyrim, um reino de fantasia repleto de aventuras, missões e perigos. Com uma jogabilidade imersiva e uma rica narrativa, Skyrim é um dos jogos mais aclamados de todos os tempos.",
                    Genero = "RPG, Ação",
                    //DataL = Convert.ToDateTime("11/11/2011"),
                    Desenvolvedor = "Bethesda Game Studios"
                },

                new Jogo()
                {
                    Id = 28,
                    Nome = "Stardew Valley",
                    Descricao = "Stardew Valley é um jogo de simulação de fazenda desenvolvido por Eric Barone. Os jogadores assumem o papel de um personagem que herda uma fazenda antiga e precisam administrá-la, cultivando plantações, criando animais, explorando a cidade local, participando de eventos e interagindo com os personagens. Com seu estilo visual encantador e jogabilidade relaxante, Stardew Valley oferece uma experiência de fazenda cativante.",
                    Genero = "Simulação, RPG",
                    //DataL = Convert.ToDateTime("26/02/2016"),
                    Desenvolvedor = "ConcernedApe"
                },

                new Jogo()
                {
                    Id = 29,
                    Nome = "Rocket League",
                    Descricao = "Rocket League é um jogo de esporte e ação que combina futebol com carros em uma arena. Os jogadores controlam carros equipados com foguetes e devem marcar gols em uma partida frenética. Com modos de jogo variados, competições online e jogabilidade divertida, Rocket League oferece uma experiência multiplayer emocionante.",
                    Genero = "Esporte, Ação",
                    //DataL = Convert.ToDateTime("07/07/2015"),
                    Desenvolvedor = "Psyonix"
                },

                new Jogo()
                {
                    Id = 30,
                    Nome = "StarCraft II",
                    Descricao = "StarCraft II é um jogo de estratégia em tempo real desenvolvido pela Blizzard Entertainment. Os jogadores assumem o controle de uma das três facções - Terranos, Protoss ou Zergs - e competem em batalhas estratégicas. Com uma campanha envolvente, modos multiplayer competitivos e ferramentas de criação de mapas, StarCraft II é um dos principais jogos de estratégia do mercado.",
                    Genero = "Estratégia",
                    //DataL = Convert.ToDateTime("27/07/2010"),
                    Desenvolvedor = "Blizzard Entertainment"
                },

                new Jogo()
                {
                    Id = 31,
                    Nome = "Genshin Impact",
                    Descricao = "Genshin Impact é um jogo de ação e RPG de mundo aberto desenvolvido pela miHoYo. Os jogadores exploram o mundo de Teyvat, lutam contra inimigos, completam missões, desvendam segredos e embarcam em uma jornada para encontrar os membros perdidos de sua família. Com uma jogabilidade de combate dinâmica, belos visuais e uma história envolvente, Genshin Impact oferece uma experiência de aventura emocionante.",
                    Genero = "Ação, RPG",
                    //DataL = Convert.ToDateTime("28/09/2020"),
                    Desenvolvedor = "miHoYo"
                },

                new Jogo()
                {
                    Id = 32,
                    Nome = "Monster Hunter: World",
                    Descricao = "Monster Hunter: World é um jogo de ação e RPG desenvolvido pela Capcom. Os jogadores assumem o papel de um caçador e embarcam em missões para caçar e derrotar monstros gigantes em um mundo aberto. Com um vasto arsenal de armas e armaduras, combate tático e um sistema de progressão profundo, Monster Hunter: World oferece uma experiência desafiadora para os fãs de caçadas épicas.",
                    Genero = "Ação, RPG",
                    //DataL = Convert.ToDateTime("26/01/2018"),
                    Desenvolvedor = "Capcom"
                },

                new Jogo()
                {
                    Id = 33,
                    Nome = "The Witcher 3: Wild Hunt",
                    Descricao = "The Witcher 3: Wild Hunt é um jogo de RPG de ação em mundo aberto desenvolvido pela CD Projekt Red. Os jogadores assumem o papel de Geralt de Rivia, um caçador de monstros conhecido como Witcher, e embarcam em uma busca épica em um vasto continente repleto de perigos, escolhas morais e histórias envolventes. Com uma narrativa profunda, combate desafiador e um mundo rico em detalhes, The Witcher 3: Wild Hunt é considerado um dos melhores jogos de todos os tempos.",
                    Genero = "RPG, Ação",
                    //DataL = Convert.ToDateTime("19/05/2015"),
                    Desenvolvedor = "CD Projekt Red"
                },

                new Jogo()
                {
                    Id = 34,
                    Nome = "Mortal Kombat 11",
                    Descricao = "Mortal Kombat 11 é um jogo de luta desenvolvido pela NetherRealm Studios. Os jogadores participam de combates intensos e brutais, controlando uma variedade de personagens icônicos da franquia Mortal Kombat. Com gráficos impressionantes, movimentos especiais devastadores e uma história envolvente, Mortal Kombat 11 oferece uma experiência emocionante para os fãs de luta.",
                    Genero = "Luta",
                    //DataL = Convert.ToDateTime("23/04/2019"),
                    Desenvolvedor = "NetherRealm Studios"
                },

                new Jogo()
                {
                    Id = 35,
                    Nome = "Fallout 4",
                    Descricao = "Fallout 4 é um jogo de RPG de ação desenvolvido pela Bethesda Game Studios. Ambientado em um mundo pós-apocalíptico, os jogadores assumem o papel de um sobrevivente que emerge de um abrigo subterrâneo para explorar e enfrentar os perigos da região de Boston. Com um vasto mundo aberto, escolhas morais impactantes e um sistema de construção de assentamentos, Fallout 4 oferece uma experiência imersiva no universo pós-nuclear.",
                    Genero = "RPG, Ação",
                    //DataL = Convert.ToDateTime("10/11/2015"),
                    Desenvolvedor = "Bethesda Game Studios"
                },

                new Jogo()
                {
                    Id = 36,
                    Nome = "Terraria",
                    Descricao = "Terraria é um jogo de ação e aventura com elementos de construção desenvolvido pela Re-Logic. Os jogadores exploram um mundo pixelado em 2D, coletam recursos, constroem estruturas e enfrentam inimigos em diferentes biomas. Com uma jogabilidade sandbox e uma infinidade de itens, armas e chefes para enfrentar, Terraria oferece uma experiência criativa e desafiadora.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("16/05/2011"),
                    Desenvolvedor = "Re-Logic"
                    },

                new Jogo()
                {
                    Id = 37,
                    Nome = "Subnautica",
                    Descricao = "Subnautica é um jogo de exploração e sobrevivência desenvolvido pela Unknown Worlds Entertainment. Os jogadores assumem o papel de um sobrevivente de um acidente espacial e exploram um oceano alienígena repleto de criaturas perigosas e mistérios. Com uma atmosfera imersiva, gráficos impressionantes e uma narrativa cativante, Subnautica oferece uma experiência",
                    Genero = "Exploração, Sobrevivência",
                    //DataL = Convert.ToDateTime("23/01/2018"),
                    Desenvolvedor = "Unknown Worlds Entertainment"
                },

                new Jogo()
                {
                    Id = 38,
                    Nome = "Dark Souls III",
                    Descricao = "Dark Souls III é um jogo de RPG de ação desenvolvido pela FromSoftware. Situado em um mundo sombrio e repleto de desafios, os jogadores enfrentam inimigos poderosos, chefes intimidadores e exploram cenários detalhados. Com combates estratégicos, uma atmosfera única e uma narrativa envolvente, Dark Souls III proporciona uma experiência intensa e gratificante.",
                    Genero = "RPG, Ação",
                    //DataL = Convert.ToDateTime("12/04/2016"),
                    Desenvolvedor = "FromSoftware"
                },

                new Jogo()
                {
                    Id = 39,
                    Nome = "Warframe",
                    Descricao = "Warframe é um jogo de tiro em terceira pessoa online desenvolvido pela Digital Extremes. Os jogadores assumem o papel de Tennos, guerreiros espaciais que controlam armaduras avançadas conhecidas como Warframes. Com uma jogabilidade cooperativa, combates frenéticos e um sistema de progressão profundo, Warframe oferece uma experiência viciante no universo futurista.",
                    Genero = "Tiro em terceira pessoa, MMO",
                    //DataL = Convert.ToDateTime("25/03/2013"),
                    Desenvolvedor = "Digital Extremes"
                },

                new Jogo()
                {
                    Id = 40,
                    Nome = "The Elder Scrolls Online",
                    Descricao = "The Elder Scrolls Online é um MMORPG desenvolvido pela ZeniMax Online Studios. Situado no universo de fantasia de The Elder Scrolls, os jogadores podem explorar vastas terras, completar missões, lutar contra inimigos e interagir com outros jogadores. Com uma história rica, mecânicas de RPG clássicas e um mundo aberto expansivo, The Elder Scrolls Online oferece uma experiência imersiva no reino de Tamriel.",
                    Genero = "MMORPG",
                    //DataL = Convert.ToDateTime("04/04/2014"),
                    Desenvolvedor = "ZeniMax Online Studios",
                },

                new Jogo()
                {
                    Id = 41,
                    Nome = "Euro Truck Simulator 2",
                    Descricao = "Euro Truck Simulator 2 é um simulador de caminhões desenvolvido pela SCS Software. Os jogadores assumem o papel de motoristas de caminhões, transportando cargas por toda a Europa. Com gráficos realistas, uma ampla seleção de caminhões e missões desafiadoras, Euro Truck Simulator 2 proporciona uma experiência autêntica de condução de caminhões.",
                    Genero = "Simulação",
                    //DataL = Convert.ToDateTime("19/10/2012"),
                    Desenvolvedor = "SCS Software"
                },

                new Jogo()
                {
                    Id = 42,
                    Nome = "Don't Starve",
                    Descricao = "Don't Starve é um jogo de sobrevivência desenvolvido pela Klei Entertainment. Os jogadores assumem o papel de Wilson, um cientista preso em um mundo misterioso e perigoso. Eles devem explorar o ambiente, coletar recursos, criar itens e lutar contra criaturas para sobreviver. Com uma estética única, desafios constantes e uma jogabilidade envolvente, Don't Starve oferece uma experiência cativante de sobrevivência.",
                    Genero = "Sobrevivência",
                    //DataL = Convert.ToDateTime("23/04/2013"),
                    Desenvolvedor = "Klei Entertainment"
                },

                new Jogo()
                {
                    Id = 43,
                    Nome = "Age of Empires II: Definitive Edition",
                    Descricao = "Age of Empires II: Definitive Edition é uma versão remasterizada do clássico jogo de estratégia em tempo real Age of Empires II. Os jogadores constroem e expandem impérios, treinam exércitos e lutam contra outras civilizações em batalhas épicas. Com gráficos aprimorados, conteúdo adicional e melhorias de jogabilidade, Age of Empires II: Definitive Edition oferece uma experiência nostálgica e aprofundada para os fãs do gênero.",
                    Genero = "Estratégia em tempo real",
                    //DataL = Convert.ToDateTime("14/11/2019"),
                    Desenvolvedor = "Forgotten Empires, Tantalus Media, Wicked Witch"
                },
                    
                new Jogo()
                {
                    Id = 44,
                    Nome = "Hades",
                    Descricao = "Hades é um jogo de ação e roguelike desenvolvido pela Supergiant Games. Os jogadores assumem o papel de Zagreus, filho do deus grego Hades, enquanto ele tenta escapar do Submundo. Com uma jogabilidade fluida, combates desafiadores e uma narrativa envolvente, Hades oferece uma experiência cativante com elementos mitológicos.",
                    Genero = "Ação, Roguelike",
                    //DataL = Convert.ToDateTime("17/09/2020"),
                    Desenvolvedor = "Supergiant Games"
                },

                new Jogo()
                {
                    Id = 45,
                    Nome = "Cuphead",
                    Descricao = "Cuphead é um jogo de plataforma e ação desenvolvido pelo Studio MDHR. Com uma estética inspirada em desenhos animados dos anos 1930, os jogadores controlam Cuphead ou Mugman em batalhas contra chefes desafiadores. Com uma jogabilidade precisa, visuais impressionantes e trilha sonora envolvente, Cuphead oferece uma experiência única e desafiadora.",
                    Genero = "Plataforma, Ação",
                    //DataL = Convert.ToDateTime("29/09/2017"),
                    Desenvolvedor = "Studio MDHR"
                },

                new Jogo()
                {
                    Id = 46,
                    Nome = "Resident Evil 2 Remake",
                    Descricao = "Resident Evil 2 Remake é um jogo de terror e sobrevivência desenvolvido pela Capcom. O jogo é uma recriação do clássico Resident Evil 2 lançado em 1998. Os jogadores assumem o papel de Leon S. Kennedy e Claire Redfield, enquanto exploram a cidade infestada por zumbis. Com gráficos realistas, jogabilidade modernizada e uma atmosfera tensa, Resident Evil 2 Remake oferece uma experiência assustadora e envolvente.",
                    Genero = "Terror, Sobrevivência",
                    //DataL = Convert.ToDateTime("25/01/2019"),
                    Desenvolvedor = "Capcom"
                },

                new Jogo()
                {
                    Id = 47,
                    Nome = "NieR: Automata",
                    Descricao = "NieR: Automata é um jogo de ação e RPG desenvolvido pela PlatinumGames. Situado em um futuro distópico, os jogadores controlam androides de combate em uma guerra contra máquinas. Com uma narrativa complexa, jogabilidade fluida e uma trilha sonora marcante, NieR: Automata oferece uma experiência emocional e envolvente.",
                    Genero = "Ação, RPG",
                    //DataL = Convert.ToDateTime("23/02/2017"),
                    Desenvolvedor = "PlatinumGames"
                },

                new Jogo()
                {
                    Id = 48,
                    Nome = "Dead by Daylight",
                    Descricao = "Dead by Daylight é um jogo de terror multiplayer assimétrico desenvolvido pela Behaviour Interactive. Os jogadores podem assumir o papel de um assassino sanguinário ou de um dos sobreviventes tentando escapar. Com uma jogabilidade única e emocionante, Dead by Daylight oferece uma experiência intensa de perseguição e sobrevivência.",
                    Genero = "Terror, Multijogador",
                    //DataL = Convert.ToDateTime("14/06/2016"),
                    Desenvolvedor = "Behaviour Interactive"
                },

                new Jogo()
                {
                    Id = 49,
                    Nome = "Need for Speed: Heat",
                    Descricao = "Need for Speed: Heat é um jogo de corrida desenvolvido pela Ghost Games. Ambientado em Palm City, os jogadores participam de corridas ilegais durante o dia para ganhar dinheiro e aprimorar seus carros, e corridas emocionantes à noite para aumentar sua reputação. Com uma ampla seleção de carros, personalização detalhada e perseguições policiais intensas, Need for Speed: Heat oferece uma experiência emocionante para os fãs de corrida.",
                    Genero = "Corrida",
                    //DataL = Convert.ToDateTime("08/11/2019"),
                    Desenvolvedor = "Ghost Games"
                },

                new Jogo()
                {
                    Id = 50,
                    Nome = "Tom Clancy's Ghost Recon Breakpoint",
                    Descricao = "Tom Clancy's Ghost Recon Breakpoint é um jogo de tiro em mundo aberto desenvolvido pela Ubisoft. Situado em uma ilha fictícia chamada Auroa, os jogadores assumem o papel de um soldado de elite lutando contra um exército mercenário. Com uma jogabilidade tática, elementos de sobrevivência e um modo cooperativo online, Ghost Recon Breakpoint oferece uma experiência de combate emocionante.",
                    Genero = "Tiro, Mundo Aberto",
                    //DataL = Convert.ToDateTime("04/10/2019"),
                    Desenvolvedor = "Ubisoft"
                },

                new Jogo()
                {
                    Id = 51,
                    Nome = "Doom Eternal",
                    Descricao = "Doom Eternal é um jogo de tiro em primeira pessoa desenvolvido pela id Software. Os jogadores assumem o papel do Doom Slayer, um guerreiro enfrentando hordas de demônios do inferno. Com uma jogabilidade frenética, armas poderosas e combates intensos, Doom Eternal oferece uma experiência visceral e cheia de ação.",
                    Genero = "Tiro em primeira pessoa",
                    //DataL = Convert.ToDateTime("20/03/2020"),
                    Desenvolvedor = "id Software"
                },

                new Jogo()
                {
                    Id = 52,
                    Nome = "Deus Ex: Human Revolution",
                    Descricao = "Deus Ex: Human Revolution é um jogo de ação e RPG desenvolvido pela Eidos Montreal. Ambientado em um futuro distópico, os jogadores assumem o papel de Adam Jensen, um segurança cibernético com habilidades aprimoradas. Com uma narrativa envolvente, escolhas morais impactantes e jogabilidade que combina ação furtiva e combate, Deus Ex: Human Revolution oferece uma experiência imersiva e cativante.",
                    Genero = "Ação, RPG",
                    //DataL = Convert.ToDateTime("23/08/2011"),
                    Desenvolvedor = "Eidos Montreal"
                },

                new Jogo()
                {
                    Id = 53,
                    Nome = "Borderlands 3",
                    Descricao = "Borderlands 3 é um jogo de tiro em primeira pessoa e RPG de ação desenvolvido pela Gearbox Software. Os jogadores exploram mundos diversos, enfrentam inimigos e completam missões em busca de tesouros e loot. Com um estilo visual único, um elenco de personagens memoráveis e um sistema de armas variado, Borderlands 3 oferece uma experiência cheia de humor e caos.",
                    Genero = "Tiro em primeira pessoa, RPG de ação",
                    //DataL = Convert.ToDateTime("13/09/2019"),
                    Desenvolvedor = "Gearbox Software"
                },

                new Jogo()
                {
                    Id = 54,
                    Nome = "Sekiro: Shadows Die Twice",
                    Descricao = "Sekiro: Shadows Die Twice é um jogo de ação e aventura desenvolvido pela FromSoftware. Ambientado no Japão feudal, os jogadores assumem o papel de um guerreiro ninja em busca de vingança. Com combates desafiadores, habilidades especiais e uma narrativa envolvente, Sekiro: Shadows Die Twice oferece uma experiência emocionante e exigente.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("22/03/2019"),
                    Desenvolvedor = "FromSoftware"
                },

                new Jogo()
                {
                    Id = 55,
                    Nome = "Half-Life: Alyx",
                    Descricao = "Half-Life: Alyx é um jogo de realidade virtual desenvolvido pela Valve. Situado no universo de Half-Life, os jogadores assumem o papel de Alyx Vance em uma missão para combater uma invasão alienígena. Com uma narrativa envolvente, jogabilidade imersiva em realidade virtual e quebra-cabeças desafiadores, Half-Life: Alyx redefine a experiência de jogos em VR.",
                    Genero = "Ação, Aventura, Realidade Virtual",
                    //DataL = Convert.ToDateTime("23/03/2020"),
                    Desenvolvedor = "Valve"
                },

                new Jogo()
                {
                    Id = 56,
                    Nome = "Control",
                    Descricao = "Control é um jogo de ação e aventura desenvolvido pela Remedy Entertainment. Os jogadores assumem o papel de Jesse Faden, uma mulher com habilidades sobrenaturais, enquanto ela explora um prédio misterioso chamado Oldest House. Com poderes paranormais, combates intensos e uma narrativa intrigante, Control oferece uma experiência única e envolvente.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("27/08/2019"),
                    Desenvolvedor = "Remedy Entertainment"
                },

                new Jogo()
                {
                    Id = 57,
                    Nome = "Battlefield 1",
                    Descricao = "Battlefield 1 é um jogo de tiro em primeira pessoa desenvolvido pela DICE. Ambientado na Primeira Guerra Mundial, os jogadores participam de batalhas épicas em diversos cenários históricos. Com um modo campanha emocionante e um modo multiplayer intenso, Battlefield 1 oferece uma experiência imersiva e repleta de ação.",
                    Genero = "Tiro em primeira pessoa",
                    //DataL = Convert.ToDateTime("21/10/2016"),
                    Desenvolvedor = "DICE"
                },

                new Jogo()
                {
                    Id = 58,
                    Nome = "Tom Clancy's The Division 2",
                    Descricao = "Tom Clancy's The Division 2 é um jogo de tiro em terceira pessoa desenvolvido pela Massive Entertainment. Ambientado em um mundo pós-apocalíptico, os jogadores fazem parte de uma força especial para restaurar a ordem e combater facções hostis. Com um vasto mundo aberto, combates estratégicos e modo multiplayer cooperativo, The Division 2 oferece uma experiência completa e dinâmica.",
                    Genero = "Tiro em terceira pessoa, RPG de ação",
                    //DataL = Convert.ToDateTime("15/03/2019"),
                    Desenvolvedor = "Massive Entertainment"
                },

                new Jogo()
                {
                    Id = 59,
                    Nome = "Hitman 3",
                    Descricao = "Hitman 3 é um jogo de stealth e ação desenvolvido pela IO Interactive. Como o Agente 47, os jogadores viajam pelo mundo para eliminar alvos usando criatividade, disfarces e habilidades furtivas. Com uma variedade de missões e locais impressionantes, Hitman 3 oferece uma experiência envolvente e desafiadora para os fãs da série.",
                    Genero = "Ação, Stealth",
                    //DataL = Convert.ToDateTime("20/01/2021"),
                    Desenvolvedor = "IO Interactive"
                },

                new Jogo()
                {
                    Id = 60,
                    Nome = "Final Fantasy XIV",
                    Descricao = "Final Fantasy XIV é um MMORPG desenvolvido pela Square Enix. Os jogadores embarcam em aventuras épicas em um mundo de fantasia, enfrentando monstros, explorando masmorras e participando de batalhas emocionantes. Com uma história rica, personagens memoráveis e um sistema de classes flexível, Final Fantasy XIV oferece uma experiência online cativante para os fãs da franquia.",
                    Genero = "MMORPG",
                    //DataL = Convert.ToDateTime("27/08/2013"),
                    Desenvolvedor = "Square Enix"
                },

                new Jogo()
                {
                    Id = 61,
                    Nome = "Mass Effect: Legendary Edition",
                    Descricao = "Mass Effect: Legendary Edition é uma coletânea remasterizada dos jogos da trilogia Mass Effect, desenvolvida pela BioWare. Os jogadores embarcam em uma jornada épica pelo espaço como o Comandante Shepard, tomando decisões que afetam o destino da galáxia. Com gráficos aprimorados, jogabilidade refinada e todas as DLCs inclusas, Mass Effect: Legendary Edition oferece uma experiência imersiva e emocionante.",
                    Genero = "RPG de ação, Ficção científica",
                    //DataL = Convert.ToDateTime("14/05/2021"),
                    Desenvolvedor = "BioWare"
                },

                new Jogo()
                {
                    Id = 62,
                    Nome = "Destiny 2",
                    Descricao = "Destiny 2 é um jogo de tiro em primeira pessoa desenvolvido pela Bungie. Os jogadores exploram o universo fictício e lutam contra inimigos em uma história épica. Com uma campanha envolvente, modos PvP competitivos e desafios PvE cooperativos, Destiny 2 oferece uma experiência online dinâmica e repleta de ação.",
                    Genero = "Tiro em primeira pessoa, MMO",
                    //DataL = Convert.ToDateTime("06/09/2017"),
                    Desenvolvedor = "Bungie"
                },

                new Jogo()
                {
                    Id = 63,
                    Nome = "Resident Evil 3 Remake",
                    Descricao = "Resident Evil 3 Remake é uma reimaginação do clássico jogo de terror desenvolvido pela Capcom. Os jogadores assumem o papel de Jill Valentine enquanto tentam sobreviver a um apocalipse zumbi. Com gráficos realistas, jogabilidade intensa e uma narrativa envolvente, Resident Evil 3 Remake oferece uma experiência assustadora e emocionante.",
                    Genero = "Survival horror",
                    //DataL = Convert.ToDateTime("03/04/2020"),
                    Desenvolvedor = "Capcom"
                },

                new Jogo()
                {
                    Id = 64,
                    Nome = "The Elder Scrolls IV: Oblivion",
                    Descricao = "The Elder Scrolls IV: Oblivion é um RPG de mundo aberto desenvolvido pela Bethesda Game Studios. Os jogadores exploram a província de Cyrodiil enquanto embarcam em uma jornada para salvar o reino de Tamriel de uma ameaça demoníaca. Com um vasto mundo, personagens cativantes e uma jogabilidade envolvente, Oblivion é um clássico dos jogos de RPG.",
                    Genero = "RPG de ação, Mundo aberto",
                    //DataL = Convert.ToDateTime("20/03/2006"),
                    Desenvolvedor = "Bethesda Game Studios"
                },
                    
                new Jogo()
                {
                    Id = 65,
                    Nome = "Cities: Skylines",
                    Descricao = "Cities: Skylines é um jogo de construção de cidades desenvolvido pela Colossal Order. Os jogadores têm a tarefa de projetar, construir e gerenciar uma cidade em crescimento, cuidando de aspectos como infraestrutura, serviços públicos e economia. Com uma ampla gama de opções e ferramentas, Cities: Skylines oferece uma experiência detalhada e imersiva para os fãs de simulação urbana.",
                    Genero = "Simulação, Construção",
                    //DataL = Convert.ToDateTime("10/03/2015"),
                    Desenvolvedor = "Colossal Order"
                },

                new Jogo()
                {
                    Id = 66,
                    Nome = "Batman: Arkham Knight",
                    Descricao = "Batman: Arkham Knight é um jogo de ação e aventura desenvolvido pela Rocksteady Studios. Os jogadores assumem o papel do Batman enquanto lutam contra os vilões de Gotham City. Com um combate fluido, um enredo envolvente e gráficos impressionantes, Arkham Knight oferece uma experiência imersiva no mundo do Cavaleiro das Trevas.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("23/06/2015"),
                    Desenvolvedor = "Rocksteady Studios"
                },

                new Jogo()
                {
                    Id = 67,
                    Nome = "Detroit: Become Human",
                    Descricao = "Detroit: Become Human é um jogo de aventura interativa desenvolvido pela Quantic Dream. Os jogadores assumem o controle de androides em um futuro distópico, tomando decisões que afetam o desenrolar da história. Com uma narrativa complexa e ramificada, gráficos impressionantes e temáticas profundas, Detroit: Become Human oferece uma experiência única e emocional.",
                    Genero = "Aventura, Drama",
                    //DataL = Convert.ToDateTime("25/05/2018"),
                    Desenvolvedor = "Quantic Dream"
                },

                new Jogo()
                {
                    Id = 68,
                    Nome = "Ori and the Will of the Wisps",
                    Descricao = "Ori and the Will of the Wisps é um jogo de plataforma e aventura desenvolvido pela Moon Studios. Os jogadores assumem o controle de Ori, um espírito guardião, em sua jornada para descobrir seu destino e salvar a floresta de Nibel. Com visuais deslumbrantes, uma trilha sonora envolvente e mecânicas de jogo refinadas, Ori and the Will of the Wisps é uma experiência emocionante e cativante.",
                    Genero = "Plataforma, Aventura",
                    //DataL = Convert.ToDateTime("11/03/2020"),
                    Desenvolvedor = "Moon Studios"
                },

                new Jogo()
                {
                    Id = 69,
                    Nome = "Sid Meier's Civilization VI",
                    Descricao = "Sid Meier's Civilization VI é um jogo de estratégia por turnos desenvolvido pela Firaxis Games. Os jogadores assumem o papel de líderes de civilizações e devem expandir seus impérios, pesquisar tecnologias, negociar com outras nações e competir pelo domínio global. Com uma jogabilidade profunda, mecânicas desafiadoras e uma rica história, Civilization VI é uma referência no gênero de estratégia.",
                    Genero = "Estratégia",
                    //DataL = Convert.ToDateTime("21/10/2016"),
                    Desenvolvedor = "Firaxis Games"
                },

                new Jogo()
                {
                    Id = 70,
                    Nome = "Pillars of Eternity II: Deadfire",
                    Descricao = "Pillars of Eternity II: Deadfire é um RPG de fantasia desenvolvido pela Obsidian Entertainment. Os jogadores embarcam em uma jornada épica pelos mares, explorando ilhas exóticas, enfrentando criaturas perigosas e tomando decisões que afetam o destino do mundo. Com um sistema de combate tático, uma narrativa envolvente e uma vasta quantidade de escolhas, Pillars of Eternity II oferece uma experiência imersiva para os fãs de RPG.",
                    Genero = "RPG",
                    //DataL = Convert.ToDateTime("08/05/2018"),
                    Desenvolvedor = "Obsidian Entertainment"
                },

                new Jogo()
                {
                    Id = 71,
                    Nome = "Kingdom Come: Deliverance",
                    Descricao = "Kingdom Come: Deliverance é um RPG de mundo aberto realista desenvolvido pela Warhorse Studios. Os jogadores assumem o papel de Henry, um simples camponês que se torna envolvido em uma guerra civil na Boêmia do século XV. Com um foco em realismo histórico, combate desafiador e uma narrativa imersiva, Kingdom Come: Deliverance oferece uma experiência única e envolvente para os fãs de RPG.",
                    Genero = "RPG de ação, Mundo aberto",
                    //DataL = Convert.ToDateTime("13/02/2018"),
                    Desenvolvedor = "Warhorse Studios"
                },

                new Jogo()
                {
                    Id = 72,
                    Nome = "Dishonored 2",
                    Descricao = "Dishonored 2 é um jogo de ação e aventura desenvolvido pela Arkane Studios. Os jogadores assumem o papel de Emily Kaldwin ou Corvo Attano, personagens com habilidades sobrenaturais, em uma missão para restaurar a justiça em uma cidade dominada pela corrupção. Com um sistema de combate flexível, um mundo rico em detalhes e múltiplas abordagens para cada situação, Dishonored 2 oferece liberdade e escolhas para os jogadores.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("11/11/2016"),
                    Desenvolvedor = "Arkane Studios"
                },

                new Jogo()
                {
                    Id = 73,
                    Nome = "Forza Horizon 4",
                    Descricao = "Forza Horizon 4 é um jogo de corrida em mundo aberto desenvolvido pela Playground Games. Os jogadores podem explorar um mundo aberto dinâmico ambientado na Grã-Bretanha, participar de corridas emocionantes, colecionar e personalizar uma variedade de carros e interagir com outros jogadores online. Com gráficos impressionantes, uma ampla variedade de eventos e um sistema de estações que afeta o ambiente de jogo, Forza Horizon 4 oferece uma experiência completa para os fãs de corrida.",
                    Genero = "Corrida",
                    //DataL = Convert.ToDateTime("02/10/2018"),
                    Desenvolvedor = "Playground Games"
                },

                new Jogo()
                {
                    Id = 74,
                    Nome = "Sid Meier's Civilization VI",
                    Descricao = "Sid Meier's Civilization VI é um jogo de estratégia por turnos desenvolvido pela Firaxis Games. Os jogadores assumem o papel de líderes de civilizações e devem expandir seus impérios, pesquisar tecnologias, negociar com outras nações e competir pelo domínio global. Com uma jogabilidade profunda, mecânicas desafiadoras e uma rica história, Civilization VI é uma referência no gênero de estratégia.",
                    Genero = "Estratégia",
                    //DataL = Convert.ToDateTime("21/10/2016"),
                    Desenvolvedor = "Firaxis Games"
                },

                new Jogo()
                {
                    Id = 75,
                    Nome = "Pillars of Eternity II: Deadfire",
                    Descricao = "Pillars of Eternity II: Deadfire é um RPG de fantasia desenvolvido pela Obsidian Entertainment. Os jogadores embarcam em uma jornada épica pelos mares, explorando ilhas exóticas, enfrentando criaturas perigosas e tomando decisões que afetam o destino do mundo. Com um sistema de combate tático, uma narrativa envolvente e uma vasta quantidade de escolhas, Pillars of Eternity II oferece uma experiência imersiva para os fãs de RPG.",
                    Genero = "RPG",
                    //DataL = Convert.ToDateTime("08/05/2018"),
                    Desenvolvedor = "Obsidian Entertainment"
                },

                new Jogo()
                {
                    Id = 76,
                    Nome = "Kingdom Come: Deliverance",
                    Descricao = "Kingdom Come: Deliverance é um RPG de mundo aberto realista desenvolvido pela Warhorse Studios. Os jogadores assumem o papel de Henry, um simples camponês que se torna envolvido em uma guerra civil na Boêmia do século XV. Com um foco em realismo histórico, combate desafiador e uma narrativa imersiva, Kingdom Come: Deliverance oferece uma experiência única e envolvente para os fãs de RPG.",
                    Genero = "RPG de ação, Mundo aberto",
                    //DataL = Convert.ToDateTime("13/02/2018"),
                    Desenvolvedor = "Warhorse Studios"
                },

                new Jogo()
                {
                    Id = 77,
                    Nome = "Dishonored 2",
                    Descricao = "Dishonored 2 é um jogo de ação e aventura desenvolvido pela Arkane Studios. Os jogadores assumem o papel de Emily Kaldwin ou Corvo Attano, personagens com habilidades sobrenaturais, em uma missão para restaurar a justiça em uma cidade dominada pela corrupção. Com um sistema de combate flexível, um mundo rico em detalhes e múltiplas abordagens para cada situação, Dishonored 2 oferece liberdade e escolhas para os jogadores.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("11/11/2016"),
                    Desenvolvedor = "Arkane Studios"
                },

                new Jogo()
                {
                    Id = 78,
                    Nome = "Forza Horizon 4",
                    Descricao = "Forza Horizon 4 é um jogo de corrida em mundo aberto desenvolvido pela Playground Games. Os jogadores podem explorar um mundo aberto dinâmico ambientado na Grã-Bretanha, participar de corridas emocionantes, colecionar e personalizar uma variedade de carros e interagir com outros jogadores online. Com gráficos impressionantes, uma ampla variedade de eventos e um sistema de estações que afeta o ambiente de jogo, Forza Horizon 4 oferece uma experiência completa para os fãs de corrida.",
                    Genero = "Corrida",
                    //DataL = Convert.ToDateTime("02/10/2018"),
                    Desenvolvedor = "Playground Games"
                },

                new Jogo()
                {
                    Id = 79,
                    Nome = "Far Cry 3",
                    Descricao = "Far Cry 3 é um jogo de tiro em primeira pessoa desenvolvido pela Ubisoft Montreal. Os jogadores assumem o papel de Jason Brody, que fica preso em uma ilha tropical infestada por piratas e deve lutar pela sua sobrevivência. Com um mundo aberto vasto, combate empolgante e uma história envolvente, Far Cry 3 oferece uma experiência emocionante para os fãs de ação.",
                    Genero = "Tiro em primeira pessoa, Mundo aberto",
                    //DataL = Convert.ToDateTime("29/11/2012"),
                    Desenvolvedor = "Ubisoft Montreal"
                },

                new Jogo()
                {
                    Id = 80,
                    Nome = "The Outer Worlds",
                    Descricao = "The Outer Worlds é um RPG de ação desenvolvido pela Obsidian Entertainment. Ambientado em um futuro distante, os jogadores exploram uma série de planetas e participam de uma história repleta de escolhas e consequências. Com um estilo de jogo semelhante aos clássicos RPGs de ação, diálogos marcantes e uma narrativa envolvente, The Outer Worlds oferece uma experiência única e cativante.",
                    Genero = "RPG de ação",
                    //DataL = Convert.ToDateTime("25/10/2019"),
                    Desenvolvedor = "Obsidian Entertainment"
                },

                new Jogo()
                {
                    Id = 81,
                    Nome = "Dying Light",
                    Descricao = "Dying Light é um jogo de sobrevivência e ação em primeira pessoa desenvolvido pela Techland. Ambientado em um mundo pós-apocalíptico infestado por zumbis, os jogadores devem usar suas habilidades de parkour e combate para sobreviver e explorar o ambiente hostil. Com uma jogabilidade frenética, modo cooperativo e um ciclo dia/noite que afeta o gameplay, Dying Light proporciona uma experiência intensa e emocionante.",
                    Genero = "Sobrevivência, Ação",
                    //DataL = Convert.ToDateTime("27/01/2015"),
                    Desenvolvedor = "Techland"
                },

                new Jogo()
                {
                    Id = 82,
                    Nome = "Hollow Knight",
                    Descricao = "Hollow Knight é um jogo de plataforma e ação desenvolvido pela Team Cherry. Os jogadores exploram um vasto subterrâneo repleto de insetos e mistérios, enfrentando desafios e chefes poderosos. Com uma atmosfera única, gráficos belíssimos e uma trilha sonora envolvente, Hollow Knight cativa os jogadores com sua jogabilidade fluida e desafiadora.",
                    Genero = "Plataforma, Ação",
                    //DataL = Convert.ToDateTime("24/02/2017"),
                    Desenvolvedor = "Team Cherry"
                },

                new Jogo()
                {
                    Id = 83,
                    Nome = "A Plague Tale: Innocence",
                    Descricao = "A Plague Tale: Innocence é um jogo de aventura e ação desenvolvido pela Asobo Studio. Ambientado na França medieval, os jogadores controlam Amicia e seu irmão Hugo em uma jornada perigosa e emocionante durante a epidemia de peste negra. Com uma narrativa cativante, gráficos impressionantes e uma jogabilidade baseada em stealth, A Plague Tale: Innocence oferece uma experiência imersiva e comovente.",
                    Genero = "Aventura, Ação",
                    //DataL = Convert.ToDateTime("14/05/2019"),
                    Desenvolvedor = "Asobo Studio"
                },

                new Jogo()
                {
                    Id = 84,
                    Nome = "The Legend of Zelda: Breath of the Wild (emulador)",
                    Descricao = "The Legend of Zelda: Breath of the Wild é um jogo de ação e aventura desenvolvido pela Nintendo. Nesta versão emulada, os jogadores podem explorar o vasto mundo de Hyrule, enfrentar desafios e desvendar segredos em uma jornada épica. Com gráficos deslumbrantes, jogabilidade envolvente e uma história cativante, Breath of the Wild proporciona uma experiência inesquecível para os fãs da franquia.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("03/03/2017"),
                    Desenvolvedor = "Nintendo"
                },

                new Jogo()
                {
                    Id = 85,
                    Nome = "Command & Conquer Remastered Collection",
                    Descricao = "Command & Conquer Remastered Collection é uma coletânea remasterizada dos clássicos jogos de estratégia em tempo real da série Command & Conquer. Os jogadores podem reviver a ação e a estratégia dos jogos originais, agora com gráficos atualizados e melhorias na jogabilidade. Com campanhas emocionantes e multiplayer competitivo, esta coleção é um deleite para os fãs de estratégia.",
                    Genero = "Estratégia em tempo real",
                    //DataL = Convert.ToDateTime("05/06/2020"),
                    Desenvolvedor = "Petroglyph"
                },

                new Jogo()
                {
                    Id = 86,
                    Nome = "Divinity: Original Sin II",
                    Descricao = "Divinity: Original Sin II é um RPG de fantasia desenvolvido pela Larian Studios. Os jogadores podem criar seus próprios personagens e embarcar em uma jornada épica repleta de escolhas e consequências. Com um sistema de combate estratégico por turnos, interação detalhada com o ambiente e uma narrativa rica, Divinity: Original Sin II oferece uma experiência imersiva e envolvente.",
                    Genero = "RPG",
                    //DataL = Convert.ToDateTime("14/09/2017"),
                    Desenvolvedor = "Larian Studios"
                },

                new Jogo()
                {
                    Id = 87,
                    Nome = "Baldur's Gate III",
                    Descricao = "Baldur's Gate III é um RPG de aventura desenvolvido pela Larian Studios. Ambientado no universo de Forgotten Realms, os jogadores embarcam em uma jornada épica repleta de magia, perigos e escolhas morais. Com um sistema de combate estratégico, personagens cativantes e uma narrativa envolvente, Baldur's Gate III oferece uma experiência imersiva para os fãs do gênero.",
                    Genero = "RPG, Aventura",
                    //DataL = Convert.ToDateTime("06/10/2020"),
                    Desenvolvedor = "Larian Studios"
                },

                new Jogo()
                {
                    Id = 88,
                    Nome = "Mount & Blade II: Bannerlord",
                    Descricao = "Mount & Blade II: Bannerlord é um RPG de ação e estratégia desenvolvido pela TaleWorlds Entertainment. Ambientado em um mundo medieval fictício, os jogadores podem assumir o papel de um guerreiro, liderar exércitos, conquistar territórios e participar de batalhas épicas. Com um sistema de combate realista e uma ampla liberdade de escolhas, Bannerlord oferece uma experiência única no gênero.",
                    Genero = "RPG, Estratégia",
                    //DataL = Convert.ToDateTime("30/03/2020"),
                    Desenvolvedor = "TaleWorlds Entertainment"
                },

                new Jogo()
                {
                    Id = 89,
                    Nome = "Star Wars Jedi: Fallen Order",
                    Descricao = "Star Wars Jedi: Fallen Order é um jogo de ação e aventura desenvolvido pela Respawn Entertainment. Os jogadores assumem o papel de um jovem Padawan em fuga enquanto explora planetas, enfrenta inimigos e desenvolve habilidades Jedi. Com uma história envolvente, combates emocionantes e elementos de plataforma, Fallen Order proporciona uma experiência autêntica de Star Wars.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("15/11/2019"),
                    Desenvolvedor = "Respawn Entertainment"
                },

                new Jogo()
                {
                    Id = 90,
                    Nome = "The Forest",
                    Descricao = "The Forest é um jogo de sobrevivência em mundo aberto desenvolvido pela Endnight Games. Os jogadores encontram-se em uma ilha deserta após um acidente de avião e devem explorar, construir abrigos, caçar e lutar contra ameaças para sobreviver. Com elementos de terror e uma narrativa misteriosa, The Forest oferece uma experiência desafiadora e imersiva.",
                    Genero = "Sobrevivência, Terror",
                    //DataL = Convert.ToDateTime("30/04/2018"),
                    Desenvolvedor = "Endnight Games"
                },

                new Jogo()
                {
                    Id = 91,
                    Nome = "Little Nightmares II",
                    Descricao = "Little Nightmares II é um jogo de quebra-cabeças e horror desenvolvido pela Tarsier Studios. Os jogadores controlam Mono, um garoto preso em um mundo distorcido, enquanto desvendam segredos sombrios e enfrentam ameaças assustadoras. Com uma atmosfera única, visuais deslumbrantes e uma jogabilidade cativante, Little Nightmares II proporciona uma experiência arrepiante.",
                    Genero = "Quebra-cabeças, Horror",
                    //DataL = Convert.ToDateTime("11/02/2021"),
                    Desenvolvedor = "Tarsier Studios"
                },

                new Jogo()
                {
                    Id = 92,
                    Nome = "Resident Evil 7: Biohazard",
                    Descricao = "Resident Evil 7: Biohazard é um jogo de terror em primeira pessoa desenvolvido pela Capcom. Os jogadores assumem o papel de Ethan Winters, que busca sua esposa desaparecida em uma mansão isolada infestada de criaturas grotescas. Com uma atmosfera aterrorizante, quebra-cabeças desafiadores e uma narrativa envolvente, Resident Evil 7 oferece uma reinvenção assustadora da famosa franquia.",
                    Genero = "Terror, Ação",
                    //DataL = Convert.ToDateTime("24/01/2017"),
                    Desenvolvedor = "Capcom"
                },

                new Jogo()
                {
                    Id = 93,
                    Nome = "Nioh 2",
                    Descricao = "Nioh 2 é um jogo de ação e RPG desenvolvido pela Team Ninja. Os jogadores embarcam em uma jornada no Japão feudal, enfrentando demônios e desafiando poderosos chefes. Com um combate intenso, personalização de personagens e uma atmosfera imersiva, Nioh 2 proporciona uma experiência desafiadora para os fãs do gênero.",
                    Genero = "Ação, RPG",
                    //DataL = Convert.ToDateTime("13/03/2020"),
                    Desenvolvedor = "Team Ninja"
                },

                new Jogo()
                {
                    Id = 94,
                    Nome = "Disco Elysium",
                    Descricao = "Disco Elysium é um jogo de RPG e aventura desenvolvido pela ZA/UM. Os jogadores assumem o papel de um detetive em um mundo distópico, investigando crimes e desvendando uma narrativa complexa. Com escolhas impactantes, diálogos profundos e uma atmosfera única, Disco Elysium oferece uma experiência imersiva e envolvente.",
                    Genero = "RPG, Aventura",
                    //DataL = Convert.ToDateTime("15/10/2019"),
                    Desenvolvedor = "ZA/UM"
                },
                new Jogo()
                {
                    Id = 95,
                    Nome = "Watch Dogs: Legion",
                    Descricao = "Watch Dogs: Legion é um jogo de ação e aventura em mundo aberto desenvolvido pela Ubisoft Toronto. Os jogadores assumem o controle de uma resistência hacker em uma versão futurista de Londres, recrutando e controlando diversos personagens para combater uma opressiva corporação. Com um sistema de recrutamento inovador e uma jogabilidade dinâmica, Watch Dogs: Legion oferece uma experiência cativante.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("29/10/2020"),
                    Desenvolvedor = "Ubisoft Toronto"
                },

                new Jogo()
                {
                    Id = 96,
                    Nome = "Metro Exodus",
                    Descricao = "Metro Exodus é um jogo de tiro em primeira pessoa desenvolvido pela 4A Games. Os jogadores exploram ambientes pós-apocalípticos, enfrentando mutantes e sobrevivendo em um mundo hostil. Com uma narrativa envolvente, combate realista e gráficos impressionantes, Metro Exodus proporciona uma experiência imersiva e tensa.",
                    Genero = "Tiro, Ação",
                    //DataL = Convert.ToDateTime("15/02/2019"),
                    Desenvolvedor = "4A Games"
                },

                new Jogo()
                {
                    Id = 97,
                    Nome = "NieR Replicant ver.1.22474487139",
                    Descricao = "NieR Replicant ver.1.22474487139 é uma versão remasterizada do jogo de ação e RPG desenvolvido pela Square Enix. Os jogadores seguem a jornada de um jovem em busca de uma cura para sua irmã doente, explorando um mundo pós-apocalíptico e enfrentando desafios emocionantes. Com uma história envolvente, personagens cativantes e melhorias gráficas, NieR Replicant oferece uma experiência nostálgica para os fãs do jogo original.",
                    Genero = "Ação, RPG",
                    //DataL = Convert.ToDateTime("23/04/2021"),
                    Desenvolvedor = "Square Enix"
                },

                new Jogo()
                {
                    Id = 99,
                    Nome = "Resident Evil 4",
                    Descricao = "Resident Evil 4 é um jogo de ação e terror desenvolvido pela Capcom. Os jogadores assumem o papel de Leon S. Kennedy, que é enviado em uma missão para resgatar a filha do presidente dos Estados Unidos de um culto sinistro. Com uma jogabilidade intensa, puzzles desafiadores e uma atmosfera assustadora, Resident Evil 4 é considerado um dos melhores jogos da franquia.",
                    Genero = "Ação, Terror",
                    //DataL = Convert.ToDateTime("11/01/2005"),
                    Desenvolvedor = "Capcom"
                    },

                new Jogo()
                {
                    Id = 100,
                    Nome = "Dragon Age: Inquisition",
                    Descricao = "Dragon Age: Inquisition é um jogo de RPG desenvolvido pela BioWare. Os jogadores assumem o papel de um inquisidor, liderando uma equipe de heróis em uma missão para salvar o mundo de uma ameaça sobrenatural. Com um vasto mundo aberto, escolhas impactantes e um sistema de combate estratégico, Dragon Age: Inquisition oferece uma experiência imersiva e épica.",
                    Genero = "RPG",
                    //DataL = Convert.ToDateTime("18/11/2014"),
                    Desenvolvedor = "BioWare"
                },

                new Jogo()
                {
                    Id = 101,
                    Nome = "F1 2021",
                    Descricao = "F1 2021 é um jogo de corrida desenvolvido pela Codemasters. Os jogadores podem vivenciar a emoção e a intensidade do Campeonato Mundial de Fórmula 1, competindo contra pilotos reais e equipes renomadas. Com gráficos realistas, mecânicas de corrida autênticas e modos de jogo variados, F1 2021 oferece uma experiência completa para os fãs do esporte.",
                    Genero = "Corrida",
                    //DataL = Convert.ToDateTime("16/07/2021"),
                    Desenvolvedor = "Codemasters"
                },

                new Jogo()
                {
                    Id = 102,
                    Nome = "Oxygen Not Included",
                    Descricao = "Oxygen Not Included é um jogo de simulação e sobrevivência desenvolvido pela Klei Entertainment. Os jogadores assumem o controle de colonos em um asteroide distante, gerenciando recursos, construindo estruturas e lidando com os desafios do ambiente hostil. Com uma jogabilidade complexa e desafiadora, Oxygen Not Included oferece uma experiência viciante para os fãs do gênero.",
                    Genero = "Simulação, Sobrevivência",
                    //DataL = Convert.ToDateTime("30/07/2019"),
                    Desenvolvedor = "Klei Entertainment"
                    },

                new Jogo()
                {
                    Id = 103,
                    Nome = "Subnautica: Below Zero",
                    Descricao = "Subnautica: Below Zero é um jogo de aventura e sobrevivência desenvolvido pela Unknown Worlds Entertainment. Os jogadores exploram um mundo subaquático gelado, coletando recursos, construindo bases e desvendando os mistérios do ambiente. Com uma narrativa envolvente e uma atmosfera imersiva, Subnautica: Below Zero oferece uma experiência única no fundo do oceano.",
                    Genero = "Aventura, Sobrevivência",
                    //DataL = Convert.ToDateTime("14/05/2021"),
                    Desenvolvedor = "Unknown Worlds Entertainment"
                },

                new Jogo()
                {
                    Id = 104,
                    Nome = "World of Tanks",
                    Descricao = "World of Tanks é um jogo de guerra online desenvolvido pela Wargaming. Nele, os jogadores controlam tanques de guerra e participam de batalhas épicas em equipes. Com uma ampla variedade de veículos, táticas estratégicas e combates emocionantes, World of Tanks oferece uma experiência multiplayer intensa.",
                    Genero = "Ação, Estratégia",
                    //DataL = Convert.ToDateTime("12/08/2010"),
                    Desenvolvedor = "Wargaming"
                    },

                new Jogo()
                {
                    Id = 105,
                    Nome = "Ghost of Tsushima",
                    Descricao = "Ghost of Tsushima é um jogo de ação e aventura desenvolvido pela Sucker Punch Productions. Os jogadores assumem o papel de Jin Sakai, um samurai em uma missão para proteger a ilha de Tsushima durante a invasão mongol. Com um mundo aberto deslumbrante, combates de espada precisos e uma narrativa cativante, Ghost of Tsushima oferece uma experiência imersiva no Japão feudal.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("17/07/2020"),
                    Desenvolvedor = "Sucker Punch Productions"
                },

                new Jogo()
                {
                    Id = 106,
                    Nome = "Tom Clancy's Rainbow Six: Siege",
                    Descricao = "Tom Clancy's Rainbow Six: Siege é um jogo de tiro tático desenvolvido pela Ubisoft Montreal. Os jogadores participam de intensas partidas multiplayer em equipes, onde estratégia, trabalho em equipe e precisão são fundamentais. Com uma grande variedade de operadores e mapas, Rainbow Six: Siege oferece uma experiência competitiva e emocionante.",
                    Genero = "Tiro, Estratégia",
                    //DataL = Convert.ToDateTime("01/12/2015"),
                    Desenvolvedor = "Ubisoft Montreal"
                },

                new Jogo()
                {
                    Id = 107,
                    Nome = "ARK: Survival Evolved",
                    Descricao = "ARK: Survival Evolved é um jogo de sobrevivência em um mundo aberto repleto de dinossauros e criaturas pré-históricas. Os jogadores devem explorar, caçar, criar e construir suas bases para sobreviver nesse ambiente hostil. Com um vasto mapa para explorar e uma grande variedade de dinossauros para domar, ARK: Survival Evolved oferece uma experiência única de sobrevivência.",
                    Genero = "Aventura, Sobrevivência",
                    //DataL = Convert.ToDateTime("29/08/2017"),
                    Desenvolvedor = "Studio Wildcard"
                },

                new Jogo()
                {
                    Id = 108,
                    Nome = "Assassin's Creed Odyssey",
                    Descricao = "Assassin's Creed Odyssey é um jogo de ação e aventura desenvolvido pela Ubisoft. Ambientado na Grécia Antiga, os jogadores assumem o papel de um mercenário e embarcam em uma jornada épica repleta de combates, exploração e escolhas que afetam a narrativa. Com um vasto mundo aberto, batalhas emocionantes e uma história envolvente, Assassin's Creed Odyssey oferece uma experiência imersiva no universo da série.",
                    Genero = "Ação, Aventura",
                    //DataL = Convert.ToDateTime("05/10/2018"),
                    Desenvolvedor = "Ubisoft",
                    }
            );










            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Perfil)
                .HasDefaultValue("Usuario");
        }
    }
}