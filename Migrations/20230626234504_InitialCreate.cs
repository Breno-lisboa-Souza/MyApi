using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desenvolvedor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Usuario"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JogoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favoritos_Jogos_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favoritos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JogoUsuario",
                columns: table => new
                {
                    JogoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogoUsuario", x => new { x.JogoId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_JogoUsuario_Jogos_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogoUsuario_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Jogos",
                columns: new[] { "Id", "Descricao", "Desenvolvedor", "Genero", "Nome" },
                values: new object[,]
                {
                    { 1, "Far Cry 6 é um jogo de tiro em primeira pessoa de mundo aberto desenvolvido pela Ubisoft Toronto. Ambientado na ilha fictícia de Yara, os jogadores assumem o papel de Dani Rojas, um guerrilheiro lutando contra o regime opressivo do ditador Anton Castillo. Com um vasto mundo para explorar, combates intensos e uma narrativa envolvente, Far Cry 6 oferece uma experiência cheia de ação e aventura.", "Ubisoft Toronto", "Tiro, Ação", "Far Cry 6" },
                    { 2, "Bloons TD6 é um jogo de estratégia em que os jogadores devem defender seu território contra ondas de balões invasores. O jogo apresenta torres de defesa com habilidades únicas, diversos mapas e modos de jogo, oferecendo uma experiência desafiadora e divertida.", "Ninja Kiwi", "Estratégia", "Bloons TD6" },
                    { 3, "Red Dead Redemption é um jogo de ação e aventura em mundo aberto ambientado no Velho Oeste. Os jogadores assumem o papel de um pistoleiro chamado John Marston, que deve caçar criminosos e enfrentar desafios em uma história épica. O jogo oferece um vasto mundo para explorar, com muitas missões e atividades para realizar.", "Rockstar San Diego", "Ação, Aventura", "Red Dead Redemption" },
                    { 4, "Valorant é um jogo de tiro tático em primeira pessoa desenvolvido pela Riot Games. No jogo, duas equipes competem em partidas de ataque e defesa, utilizando personagens com habilidades únicas. Com combates estratégicos e trabalho em equipe, Valorant oferece uma experiência de jogo emocionante e competitiva.", "Riot Games", "Tiro em primeira pessoa", "Valorant" },
                    { 5, "Counter-Strike: Global Offensive é um jogo de tiro em primeira pessoa competitivo. Os jogadores se juntam a equipes terroristas ou antiterroristas e participam de partidas intensas em diversos modos de jogo. Com uma jogabilidade estratégica e habilidades individuais em teste, CS:GO continua sendo um dos jogos mais populares do gênero.", "Valve", "Tiro em primeira pessoa", "Counter-Strike: Global Offensive" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataAcesso", "Email", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "PasswordString", "Perfil", "Username" },
                values: new object[] { 1, null, "seuEmail@gmail.com", -23.520024100000001, -46.596497999999997, new byte[] { 27, 141, 221, 174, 51, 144, 184, 9, 94, 252, 88, 152, 208, 64, 185, 61, 170, 167, 32, 147, 68, 137, 50, 226, 92, 30, 38, 16, 197, 160, 146, 93, 131, 213, 197, 158, 31, 210, 30, 241, 25, 188, 68, 38, 107, 81, 153, 158, 24, 105, 114, 48, 64, 183, 106, 34, 139, 98, 196, 53, 67, 60, 100, 200 }, new byte[] { 152, 132, 195, 113, 169, 175, 49, 87, 104, 101, 2, 204, 54, 74, 233, 136, 32, 2, 116, 66, 145, 107, 234, 107, 92, 235, 211, 220, 222, 135, 24, 175, 97, 76, 123, 133, 243, 19, 37, 6, 174, 74, 3, 132, 169, 235, 143, 183, 65, 154, 64, 21, 29, 46, 84, 88, 243, 76, 152, 146, 148, 150, 116, 224, 115, 6, 4, 177, 214, 79, 111, 168, 63, 142, 79, 240, 207, 119, 150, 135, 146, 57, 157, 54, 182, 201, 74, 79, 137, 196, 53, 189, 189, 121, 39, 157, 230, 163, 84, 106, 204, 197, 190, 180, 219, 149, 92, 202, 252, 92, 53, 154, 195, 91, 60, 216, 137, 64, 176, 116, 193, 102, 233, 63, 157, 219, 14, 61 }, "", "Admin", "UsuarioAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_JogoId",
                table: "Favoritos",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_UsuarioId",
                table: "Favoritos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoUsuario_UsuarioId",
                table: "JogoUsuario",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "JogoUsuario");

            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
