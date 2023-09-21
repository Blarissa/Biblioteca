using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositorioDeLivros.Migrations
{
    /// <inheritdoc />
    public partial class alterandoemprestimo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "emprestimos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "emprestimos");
        }
    }
}
