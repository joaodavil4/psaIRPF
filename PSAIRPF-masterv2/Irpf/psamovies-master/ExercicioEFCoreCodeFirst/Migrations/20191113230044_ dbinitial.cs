using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExercicioEFCoreCodeFirst.Migrations
{
    public partial class dbinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contribuintes",
                columns: table => new
                {
                    ContribuinteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuintes", x => x.ContribuinteID);
                });

            migrationBuilder.CreateTable(
                name: "Declaracoes",
                columns: table => new
                {
                    DeclaracaoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RendimentoTrib = table.Column<double>(nullable: false),
                    NmroDependentes = table.Column<int>(nullable: false),
                    Previdencia = table.Column<double>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Data = table.Column<string>(nullable: true),
                    ContribuinteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Declaracoes", x => x.DeclaracaoID);
                    table.ForeignKey(
                        name: "FK_Declaracoes_Contribuintes_ContribuinteID",
                        column: x => x.ContribuinteID,
                        principalTable: "Contribuintes",
                        principalColumn: "ContribuinteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deducoes",
                columns: table => new
                {
                    DeducaoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDeducao = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    DeclaracaoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deducoes", x => x.DeducaoID);
                    table.ForeignKey(
                        name: "FK_Deducoes_Declaracoes_DeclaracaoID",
                        column: x => x.DeclaracaoID,
                        principalTable: "Declaracoes",
                        principalColumn: "DeclaracaoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Declaracoes_ContribuinteID",
                table: "Declaracoes",
                column: "ContribuinteID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deducoes_DeclaracaoID",
                table: "Deducoes",
                column: "DeclaracaoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deducoes");

            migrationBuilder.DropTable(
                name: "Declaracoes");

            migrationBuilder.DropTable(
                name: "Contribuintes");
        }
    }
}
