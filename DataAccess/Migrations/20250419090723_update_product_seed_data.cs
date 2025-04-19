using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_product_seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1634), "domates.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1640), "salatalik.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1642), "elma.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1643), "patates.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1645), "sogan.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1646), "kiyma.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1647), "tavuk.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1649), "sucuk.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1650), "kuzupirzola.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1652), "hindifume.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1653), "sut.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1655), "peynir.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1656), "tereyag.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1657), "zeytin.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1659), "bal.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1660), "cips.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1662), "cikolata.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1663), "gofret.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1665), "gazoz.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 7, 23, 188, DateTimeKind.Local).AddTicks(1666), "biskuvi.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3574), "images/domates.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3579), "images/salatalik.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3581), "images/elma.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3583), "images/patates.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3584), "images/sogan.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3585), "images/kiyma.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3587), "images/tavuk.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3648), "images/sucuk.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3650), "images/kuzupirzola.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3652), "images/hindifume.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3653), "images/sut.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3655), "images/peynir.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3656), "images/tereyag.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3657), "images/zeytin.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3659), "images/bal.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3660), "images/cips.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3661), "images/cikolata.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3663), "images/gofret.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3664), "images/gazoz.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 47, 35, 760, DateTimeKind.Local).AddTicks(3666), "images/biskuvi.jpg" });
        }
    }
}
