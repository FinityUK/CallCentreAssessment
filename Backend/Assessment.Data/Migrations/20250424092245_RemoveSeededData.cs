using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: new Guid("f6fd57fa-c0fb-4c2d-b94c-2e7de08c0e89"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "CallingUserId", "DateCallStarted", "DateDeleted" },
                values: new object[] { new Guid("f6fd57fa-c0fb-4c2d-b94c-2e7de08c0e89"), new Guid("43baf7ac-2ba3-46f8-acf4-10b0795f34d1"), new DateTimeOffset(new DateTime(2024, 3, 22, 8, 29, 35, 219, DateTimeKind.Unspecified).AddTicks(7185), new TimeSpan(0, 0, 0, 0, 0)), null });
        }
    }
}
