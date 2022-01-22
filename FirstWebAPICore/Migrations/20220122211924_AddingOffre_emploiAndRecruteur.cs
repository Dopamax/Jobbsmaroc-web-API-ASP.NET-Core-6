using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebAPICore.Migrations
{
    public partial class AddingOffre_emploiAndRecruteur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recruteurs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    societe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    siteweb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    details_societe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    motdepasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruteurs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Offre_emploi",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_emploi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_contrat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    experience_requise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    niveau_etude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salaire_min = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salaire_max = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    offre_adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recruteurid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offre_emploi", x => x.id);
                    table.ForeignKey(
                        name: "FK_Offre_emploi_Recruteurs_recruteurid",
                        column: x => x.recruteurid,
                        principalTable: "Recruteurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offre_emploi_recruteurid",
                table: "Offre_emploi",
                column: "recruteurid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offre_emploi");

            migrationBuilder.DropTable(
                name: "Recruteurs");
        }
    }
}
