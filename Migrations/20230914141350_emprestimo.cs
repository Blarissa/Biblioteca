using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RepositorioDeLivros.Migrations
{
    /// <inheritdoc />
    public partial class emprestimo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "emprestimos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_hora = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    livro_id = table.Column<int>(type: "integer", nullable: false),
                    leitor_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_emprestimos", x => x.id);
                    table.ForeignKey(
                        name: "fk_emprestimos_leitores_leitor_id",
                        column: x => x.leitor_id,
                        principalTable: "leitores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_emprestimos_livros_livro_id",
                        column: x => x.livro_id,
                        principalTable: "livros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_emprestimos_leitor_id",
                table: "emprestimos",
                column: "leitor_id");

            migrationBuilder.CreateIndex(
                name: "ix_emprestimos_livro_id",
                table: "emprestimos",
                column: "livro_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emprestimos");
        }
    }
}
