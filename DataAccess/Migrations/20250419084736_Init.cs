using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3363), null, "Meyve & Sebze", 1, null },
                    { 2, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3379), null, "Et & Tavuk", 1, null },
                    { 3, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3380), null, "Süt & Kahvaltılık", 1, null },
                    { 4, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3380), null, "Atıştırmalık", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Description", "ImagePath", "Name", "Status", "UnitPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3574), null, "Taze tarla domatesi", "images/domates.jpg", "Domates", 1, 15.50m, null },
                    { 2, 1, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3579), null, "Seradan taze salatalık", "images/salatalik.jpg", "Salatalık", 1, 12.25m, null },
                    { 3, 1, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3581), null, "Amasya elması", "images/elma.jpg", "Elma", 1, 10.75m, null },
                    { 4, 1, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3583), null, "Yerli patates", "images/patates.jpg", "Patates", 1, 8.90m, null },
                    { 5, 1, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3584), null, "Kuru soğan", "images/sogan.jpg", "Soğan", 1, 7.30m, null },
                    { 6, 2, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3585), null, "Yağsız dana kıyma", "images/kiyma.jpg", "Dana Kıyma", 1, 210.00m, null },
                    { 7, 2, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3587), null, "Taze tavuk fileto", "images/tavuk.jpg", "Tavuk Göğsü", 1, 85.00m, null },
                    { 8, 2, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3648), null, "Kayseri usulü fermente sucuk", "images/sucuk.jpg", "Sucuk", 1, 120.00m, null },
                    { 9, 2, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3650), null, "Kemikli kuzu pirzola", "images/kuzupirzola.jpg", "Kuzu Pirzola", 1, 280.00m, null },
                    { 10, 2, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3652), null, "Dilimli hindi füme", "images/hindifume.jpg", "Hindi Füme", 1, 95.00m, null },
                    { 11, 3, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3653), null, "Tam yağlı günlük süt", "images/sut.jpg", "Süt", 1, 18.50m, null },
                    { 12, 3, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3655), null, "Ezine tipi beyaz peynir", "images/peynir.jpg", "Beyaz Peynir", 1, 98.00m, null },
                    { 13, 3, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3656), null, "Kahvaltılık doğal tereyağı", "images/tereyag.jpg", "Tereyağı", 1, 140.00m, null },
                    { 14, 3, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3657), null, "Siyah sele zeytin", "images/zeytin.jpg", "Zeytin", 1, 75.00m, null },
                    { 15, 3, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3659), null, "Süzme çiçek balı", "images/bal.jpg", "Bal", 1, 160.00m, null },
                    { 16, 4, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3660), null, "Patates cipsi 150g", "images/cips.jpg", "Cips", 1, 23.00m, null },
                    { 17, 4, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3661), null, "Bitter çikolata 80g", "images/cikolata.jpg", "Çikolata", 1, 18.00m, null },
                    { 18, 4, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3663), null, "Kakaolu gofret", "images/gofret.jpg", "Gofret", 1, 9.00m, null },
                    { 19, 4, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3664), null, "Limon aromalı gazoz", "images/gazoz.jpg", "Gazoz", 1, 7.50m, null },
                    { 20, 4, new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3666), null, "Kremalı bisküvi", "images/biskuvi.jpg", "Bisküvi", 1, 11.75m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
