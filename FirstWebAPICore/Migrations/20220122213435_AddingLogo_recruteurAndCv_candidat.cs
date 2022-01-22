using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebAPICore.Migrations
{
    public partial class AddingLogo_recruteurAndCv_candidat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cv_Candidats",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lien_cv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    candidatid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cv_Candidats", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cv_Candidats_Candidats_candidatid",
                        column: x => x.candidatid,
                        principalTable: "Candidats",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logo_Recruteur",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lien_logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recruteurid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logo_Recruteur", x => x.id);
                    table.ForeignKey(
                        name: "FK_Logo_Recruteur_Recruteurs_recruteurid",
                        column: x => x.recruteurid,
                        principalTable: "Recruteurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cv_Candidats_candidatid",
                table: "Cv_Candidats",
                column: "candidatid");

            migrationBuilder.CreateIndex(
                name: "IX_Logo_Recruteur_recruteurid",
                table: "Logo_Recruteur",
                column: "recruteurid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cv_Candidats");

            migrationBuilder.DropTable(
                name: "Logo_Recruteur");
        }
    }
}
