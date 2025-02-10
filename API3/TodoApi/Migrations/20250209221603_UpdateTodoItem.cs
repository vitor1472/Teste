using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTodoItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pontos_turisticos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_Loc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    est_Loc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc_Loc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ref_Loc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descritivos_Loc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pontos_turisticos", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pontos_turisticos");
        }
    }
}
