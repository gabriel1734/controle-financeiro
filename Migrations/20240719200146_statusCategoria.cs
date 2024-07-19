using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace controlefinanceiro.Migrations
{
    /// <inheritdoc />
    public partial class statusCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Categorias",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Categorias");
        }
    }
}
