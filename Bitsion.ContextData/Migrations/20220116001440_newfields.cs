using Microsoft.EntityFrameworkCore.Migrations;

namespace Bitsion.ContextData.Migrations
{
    public partial class newfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cli_Dni",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "cli_OtherDiseases",
                table: "Clients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "cli_Id",
                keyValue: 1,
                column: "cli_Dni",
                value: "40777666");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "cli_Id",
                keyValue: 2,
                column: "cli_Dni",
                value: "14557234");

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "doc_Id", "doc_Document" },
                values: new object[,]
                {
                    { 1, "DNI" },
                    { 2, "Pasaporte" },
                    { 3, "Carnet Extranjero" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DocumentTypes",
                keyColumn: "doc_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DocumentTypes",
                keyColumn: "doc_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DocumentTypes",
                keyColumn: "doc_Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "cli_Dni",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "cli_OtherDiseases",
                table: "Clients");
        }
    }
}
