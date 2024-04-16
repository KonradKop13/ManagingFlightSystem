using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace flightManagement.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arrivalss",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrivalss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departuress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepurtureDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departuress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planess",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locationss",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locationss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locationss_Arrivalss_ArrivalId",
                        column: x => x.ArrivalId,
                        principalTable: "Arrivalss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locationss_Departuress_DepartureId",
                        column: x => x.DepartureId,
                        principalTable: "Departuress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListsOfFlight",
                columns: table => new
                {
                    FlightNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArrivalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListsOfFlight", x => x.FlightNumber);
                    table.ForeignKey(
                        name: "FK_ListsOfFlight_Arrivalss_ArrivalId",
                        column: x => x.ArrivalId,
                        principalTable: "Arrivalss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListsOfFlight_Departuress_DepartureId",
                        column: x => x.DepartureId,
                        principalTable: "Departuress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListsOfFlight_Planess_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "Planess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListsOfFlight_ArrivalId",
                table: "ListsOfFlight",
                column: "ArrivalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListsOfFlight_DepartureId",
                table: "ListsOfFlight",
                column: "DepartureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListsOfFlight_PlaneId",
                table: "ListsOfFlight",
                column: "PlaneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locationss_ArrivalId",
                table: "Locationss",
                column: "ArrivalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locationss_DepartureId",
                table: "Locationss",
                column: "DepartureId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListsOfFlight");

            migrationBuilder.DropTable(
                name: "Locationss");

            migrationBuilder.DropTable(
                name: "Planess");

            migrationBuilder.DropTable(
                name: "Arrivalss");

            migrationBuilder.DropTable(
                name: "Departuress");
        }
    }
}
