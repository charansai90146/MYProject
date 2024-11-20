using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYPROJECT.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dcondidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dcondidates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dcondidates");
        }
    }
}
