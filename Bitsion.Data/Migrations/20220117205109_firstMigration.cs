using Microsoft.EntityFrameworkCore.Migrations;

namespace Bitsion.Server.Data.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    cli_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cli_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_Dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_doc_DocumentType = table.Column<int>(type: "int", nullable: false),
                    cli_gen_Gender = table.Column<int>(type: "int", nullable: false),
                    cli_Active = table.Column<bool>(type: "bit", nullable: false),
                    cli_Drive = table.Column<bool>(type: "bit", nullable: false),
                    cli_UseGlasses = table.Column<bool>(type: "bit", nullable: false),
                    cli_Diabetic = table.Column<bool>(type: "bit", nullable: false),
                    cli_OtherDiseases = table.Column<bool>(type: "bit", nullable: false),
                    cli_Diseases = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.cli_Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    doc_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doc_Document = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.doc_Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    gen_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gen_Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.gen_Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "cli_Id", "cli_Active", "cli_Diabetic", "cli_Diseases", "cli_Dni", "cli_Drive", "cli_Name", "cli_OtherDiseases", "cli_UseGlasses", "cli_doc_DocumentType", "cli_gen_Gender" },
                values: new object[,]
                {
                    { 1, true, true, "Hipertensión", "40777666", true, "Roberto Gomez", false, true, 1, 1 },
                    { 2, true, false, "Ceguera", "14557234", true, "Fulanita Perez", false, true, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "doc_Id", "doc_Document" },
                values: new object[,]
                {
                    { 1, "DNI" },
                    { 2, "Pasaporte" },
                    { 3, "Carnet Extranjero" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "gen_Id", "gen_Gender" },
                values: new object[,]
                {
                    { 1, "Masculino" },
                    { 2, "Femenino" },
                    { 3, "Prefiero no decirlo" },
                    { 4, "Otro" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
