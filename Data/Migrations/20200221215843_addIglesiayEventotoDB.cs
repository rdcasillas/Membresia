using Microsoft.EntityFrameworkCore.Migrations;

namespace Membresia.Data.Migrations
{
    public partial class addIglesiayEventotoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    IDevento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    evento = table.Column<string>(nullable: false),
                    estatus = table.Column<bool>(nullable: false),
                    IDiglesia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.IDevento);
                });

            migrationBuilder.CreateTable(
                name: "Iglesias",
                columns: table => new
                {
                    IDiglesia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iglesia = table.Column<string>(nullable: false),
                    pastor = table.Column<string>(nullable: true),
                    pais = table.Column<string>(nullable: true),
                    ciudad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iglesias", x => x.IDiglesia);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Iglesias");
        }
    }
}
