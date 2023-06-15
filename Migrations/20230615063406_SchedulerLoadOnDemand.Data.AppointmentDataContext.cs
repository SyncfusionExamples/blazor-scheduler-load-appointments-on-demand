using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedulerLoadOnDemand.Migrations
{
    /// <inheritdoc />
    public partial class SchedulerLoadOnDemandDataAppointmentDataContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentDataSet",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: true),
                    IsAllDay = table.Column<bool>(type: "bit", nullable: false),
                    RecurrenceID = table.Column<int>(type: "int", nullable: true),
                    RecurrenceRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecurrenceException = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBlock = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDataSet", x => x.RecordId);
                });

            migrationBuilder.InsertData(
                table: "AppointmentDataSet",
                columns: new[] { "RecordId", "Description", "EndTime", "EndTimezone", "Id", "IsAllDay", "IsBlock", "IsReadOnly", "Location", "RecurrenceException", "RecurrenceID", "RecurrenceRule", "StartTime", "StartTimezone", "Subject" },
                values: new object[] { 1, null, new DateTime(2023, 6, 4, 10, 30, 0, 0, DateTimeKind.Unspecified), null, 1, false, null, null, "Tamilnadu", null, null, null, new DateTime(2023, 6, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), null, "Meeting" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentDataSet");
        }
    }
}
