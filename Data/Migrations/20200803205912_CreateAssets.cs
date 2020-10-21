using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CreateAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagNumber = table.Column<string>(nullable: false),
                    AssetTypeId = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Computer" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Monitor" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Phone" });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "AssetTypeId", "Description", "Manufacturer", "Model", "SerialNumber", "TagNumber" },
                values: new object[,]
                {
                    { 10001, 1, "17.3 Laptop", "Dell", "Inspiration 5520", " i3793-5841BLK-PUS", "C101" },
                    { 10004, 1, "14 Notebook", "Dell", "Latitude 3400", "i3793-5e378-BLK-AOC", "C102" },
                    { 10006, 1, "All-in-One PC", " HP", "Pavilion 27", "88POL-999345-00KMM", "C102" },
                    { 10002, 2, "Colour lcd monitor", "Acer", "S191HQL", "9999333iiie33", "M101" },
                    { 10003, 3, "Telephone", "Cisco", null, "123456fffe3p3", "P101" },
                    { 10005, 3, "Business IP Phone", "Polycom", "VVX 150", "iiik-999-0olk", "P102" },
                    { 10007, 3, "Office Phone", "Avaya", "T7316E", "NT8B27", "P103" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "AssetType");
        }
    }
}
