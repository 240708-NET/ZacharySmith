using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project0.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reciepts",
                columns: table => new
                {
                    RecieptNum = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    App = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Din = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Des = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reciepts", x => x.RecieptNum);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reciepts");
        }
    }
}
