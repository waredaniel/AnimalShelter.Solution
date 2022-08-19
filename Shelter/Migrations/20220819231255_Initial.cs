using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Species = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Breed = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Immunizations = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Immunizations", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 3, "Mix", "Male", true, "Rex", "Dog" },
                    { 2, 4, "Maltese", "Male", true, "Snowball", "Dog" },
                    { 3, 3, "Siamese", "Male", false, "Tyson", "Cat" },
                    { 4, 7, "Pitbull", "Female", true, "Gilda", "Dog" },
                    { 5, 5, "Poodle", "Female", true, "Bunny", "Dog" },
                    { 6, 10, "Tuxedo", "Male", true, "Groucho", "Cat" },
                    { 7, 1, "Lab", "Male", true, "Peanutbutter", "Dog" },
                    { 8, 4, "Tabby", "Male", true, "Swiper", "Cat" },
                    { 9, 6, "Hairless", "Female", true, "Janet", "Cat" },
                    { 10, 1, "Mix", "Male", true, "Target", "Dog" },
                    { 11, 1, "Austrailian Shepard", "Female", false, "TuTu", "Dog" },
                    { 12, 10, "Bengal", "Female", true, "Cups", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
