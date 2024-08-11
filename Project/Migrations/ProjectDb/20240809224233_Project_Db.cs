using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations.ProjectDb
{
    /// <inheritdoc />
    public partial class Project_Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Documento",
                table: "entidades",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "entidades");
        }
    }
}
