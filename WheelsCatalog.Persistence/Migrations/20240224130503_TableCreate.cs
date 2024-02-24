using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsCatalog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TableCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandEntityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandEntityModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorEntityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HexCode = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorEntityModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyEntityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acronym = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyEntityModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelEntityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelEntityModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelEntityModel_BrandEntityModel_BrandId",
                        column: x => x.BrandId,
                        principalTable: "BrandEntityModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarEntityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EngineVolume = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarEntityModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarEntityModel_ColorEntityModel_ColorId",
                        column: x => x.ColorId,
                        principalTable: "ColorEntityModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarEntityModel_ModelEntityModel_ModelId",
                        column: x => x.ModelId,
                        principalTable: "ModelEntityModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarPhotoEntityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPhotoEntityModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarPhotoEntityModel_CarEntityModel_CarId",
                        column: x => x.CarId,
                        principalTable: "CarEntityModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceHistoryEntityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceHistoryEntityModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceHistoryEntityModel_CarEntityModel_CarId",
                        column: x => x.CarId,
                        principalTable: "CarEntityModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceHistoryEntityModel_CurrencyEntityModel_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "CurrencyEntityModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarEntityModel_ColorId",
                table: "CarEntityModel",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEntityModel_ModelId",
                table: "CarEntityModel",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CarPhotoEntityModel_CarId",
                table: "CarPhotoEntityModel",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelEntityModel_BrandId",
                table: "ModelEntityModel",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceHistoryEntityModel_CarId",
                table: "PriceHistoryEntityModel",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceHistoryEntityModel_CurrencyId",
                table: "PriceHistoryEntityModel",
                column: "CurrencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarPhotoEntityModel");

            migrationBuilder.DropTable(
                name: "PriceHistoryEntityModel");

            migrationBuilder.DropTable(
                name: "CarEntityModel");

            migrationBuilder.DropTable(
                name: "CurrencyEntityModel");

            migrationBuilder.DropTable(
                name: "ColorEntityModel");

            migrationBuilder.DropTable(
                name: "ModelEntityModel");

            migrationBuilder.DropTable(
                name: "BrandEntityModel");
        }
    }
}
