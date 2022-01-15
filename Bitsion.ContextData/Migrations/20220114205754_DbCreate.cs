using Microsoft.EntityFrameworkCore.Migrations;

namespace Bitsion.ContextData.Migrations
{
    public partial class DbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    cli_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cli_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_doc_Documentdoc_Id = table.Column<int>(type: "int", nullable: true),
                    cli_gen_Gendergen_Id = table.Column<int>(type: "int", nullable: true),
                    cli_Active = table.Column<bool>(type: "bit", nullable: false),
                    cli_Drive = table.Column<bool>(type: "bit", nullable: false),
                    cli_UseGlasses = table.Column<bool>(type: "bit", nullable: false),
                    cli_Diabetic = table.Column<bool>(type: "bit", nullable: false),
                    cli_Diseases = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.cli_Id);
                    table.ForeignKey(
                        name: "FK_Clients_DocumentTypes_cli_doc_Documentdoc_Id",
                        column: x => x.cli_doc_Documentdoc_Id,
                        principalTable: "DocumentTypes",
                        principalColumn: "doc_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Genders_cli_gen_Gendergen_Id",
                        column: x => x.cli_gen_Gendergen_Id,
                        principalTable: "Genders",
                        principalColumn: "gen_Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_Clients_cli_doc_Documentdoc_Id",
                table: "Clients",
                column: "cli_doc_Documentdoc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_cli_gen_Gendergen_Id",
                table: "Clients",
                column: "cli_gen_Gendergen_Id");
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
