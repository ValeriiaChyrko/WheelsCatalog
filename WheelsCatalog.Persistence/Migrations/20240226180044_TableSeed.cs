using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WheelsCatalog.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TableSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BrandEntityModel",
                columns: new[] { "Id", "CreateDateTime", "Description", "LogoUrl", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("070733bf-996d-4a48-9842-8010eeaf8d4b"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1385), "Description for Brand 6", "https://example.com/logo6.png", "Brand 6", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1386) },
                    { new Guid("0c32db92-af97-4e7e-8b87-8f4c073c3521"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1403), "Description for Brand 12", "https://example.com/logo12.png", "Brand 12", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1403) },
                    { new Guid("4795d99a-a689-4225-96b5-a8720cb850a5"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1398), "Description for Brand 10", "https://example.com/logo10.png", "Brand 10", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1399) },
                    { new Guid("56601d97-96da-48de-b694-96795fb6d46a"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1381), "Description for Brand 5", "https://example.com/logo5.png", "Brand 5", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1382) },
                    { new Guid("57092ec8-8acd-48d5-a12b-0ea90c91d1e5"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1376), "Description for Brand 3", "https://example.com/logo3.png", "Brand 3", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1377) },
                    { new Guid("583c3492-fb7f-4dcf-ae6d-9bdb0bbc8705"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1410), "Description for Brand 15", "https://example.com/logo15.png", "Brand 15", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1410) },
                    { new Guid("59a66ee3-aada-4865-8249-732ac1c6304c"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1407), "Description for Brand 14", "https://example.com/logo14.png", "Brand 14", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1408) },
                    { new Guid("72ab631d-97e7-490f-96ea-51db3c443d17"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1405), "Description for Brand 13", "https://example.com/logo13.png", "Brand 13", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1406) },
                    { new Guid("74063f86-96b8-4aee-85b2-9a3c4b6bc2a4"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1390), "Description for Brand 8", "https://example.com/logo8.png", "Brand 8", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1390) },
                    { new Guid("79c775ed-8a3b-43dc-9ff2-f13472fe24ac"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1369), "Description for Brand 1", "https://example.com/logo1.png", "Brand 1", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1371) },
                    { new Guid("97fd23c4-9ca7-42c9-86ec-6da5f7f3f743"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1395), "Description for Brand 9", "https://example.com/logo9.png", "Brand 9", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1396) },
                    { new Guid("9eb85149-47ca-48d6-a4b4-dff9866bd2ba"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1379), "Description for Brand 4", "https://example.com/logo4.png", "Brand 4", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1379) },
                    { new Guid("ae5990c4-aa65-4549-a181-4cbba34e3939"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1388), "Description for Brand 7", "https://example.com/logo7.png", "Brand 7", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1388) },
                    { new Guid("bd54c8ca-6ce2-472f-a17f-62a4c895d832"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1401), "Description for Brand 11", "https://example.com/logo11.png", "Brand 11", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1401) },
                    { new Guid("e48d37cd-e956-4e6f-aabc-920c79f88b03"), new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1374), "Description for Brand 2", "https://example.com/logo2.png", "Brand 2", new DateTime(2024, 2, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1375) }
                });

            migrationBuilder.InsertData(
                table: "ColorEntityModel",
                columns: new[] { "Id", "CreateDateTime", "HexCode", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("0d6447c5-6257-4326-b541-b44b09512f88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#008080", "Teal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1131757d-20a9-4c70-83fe-5d60df8abd66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFC0CB", "Pink", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15fb55f5-fa8f-417e-95a0-85f2fc65f6fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FF0000", "Red", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a345cc1-d24f-4472-8571-43e22e06f02b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FFFF", "Cyan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f102f40-36da-4db5-bfab-feaae59286d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FF00FF", "Magenta", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a7b1a47-c610-4526-b4a7-ab87ea28bb77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FF00", "Lime", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4af04a4b-c5dc-44c3-a74a-023af34407a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#000000", "Black", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("570f7ae0-08e8-4f04-a749-7de45e416569"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#800080", "Purple", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d12a7c4-cbad-4ec8-9076-89af5a98c723"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#0000FF", "Blue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9fcb557d-30e5-4ca0-8b3c-e05a42732e75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFA500", "Orange", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a227c998-85d8-4d13-a1c2-dc8972dabc13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FF00", "Green", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd3068d7-546e-4940-b554-c36789d039c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFFF00", "Yellow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e93ac787-2cdb-4c4b-946f-6cc606665f31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#808080", "Gray", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f108d1c5-e2d4-4f0e-ba6b-66aed1b67ed5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFFFFF", "White", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f19f3bcb-0d51-4381-be96-9cd7d9e146fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#A52A2A", "Brown", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CurrencyEntityModel",
                columns: new[] { "Id", "Acronym", "CreateDateTime", "UpdateDateTime" },
                values: new object[] { new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), "USD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ModelEntityModel",
                columns: new[] { "Id", "BrandId", "CreateDateTime", "Description", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("00c3583c-dce2-4179-9dfe-cf297bf9c061"), new Guid("97fd23c4-9ca7-42c9-86ec-6da5f7f3f743"), new DateTime(2023, 10, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1830), "Description for Model2 for Brand 9", "Model2 for Brand 9", new DateTime(2024, 6, 25, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1830) },
                    { new Guid("0159fb7d-e894-4ba8-8469-dd0414f429db"), new Guid("56601d97-96da-48de-b694-96795fb6d46a"), new DateTime(2024, 2, 23, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1763), "Description for Model1 for Brand 5", "Model1 for Brand 5", new DateTime(2025, 1, 5, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1763) },
                    { new Guid("0672167c-5e9e-406d-b127-d42f3cc27259"), new Guid("79c775ed-8a3b-43dc-9ff2-f13472fe24ac"), new DateTime(2023, 11, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1677), "Description for Model3 for Brand 1", "Model3 for Brand 1", new DateTime(2023, 12, 19, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1677) },
                    { new Guid("0d751061-a872-46a6-aa23-e5d7439bd058"), new Guid("74063f86-96b8-4aee-85b2-9a3c4b6bc2a4"), new DateTime(2024, 1, 20, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1818), "Description for Model3 for Brand 8", "Model3 for Brand 8", new DateTime(2024, 5, 11, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1818) },
                    { new Guid("0f1b5c2b-5650-4fd6-b94d-f5e3edb9cf30"), new Guid("72ab631d-97e7-490f-96ea-51db3c443d17"), new DateTime(2023, 12, 9, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1915), "Description for Model2 for Brand 13", "Model2 for Brand 13", new DateTime(2024, 9, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1915) },
                    { new Guid("10a3325c-291e-4fa2-9abf-eec4659fc21f"), new Guid("79c775ed-8a3b-43dc-9ff2-f13472fe24ac"), new DateTime(2023, 3, 31, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1655), "Description for Model1 for Brand 1", "Model1 for Brand 1", new DateTime(2023, 8, 1, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1655) },
                    { new Guid("1b83b543-dadd-4fd5-ba76-f85c987e1905"), new Guid("56601d97-96da-48de-b694-96795fb6d46a"), new DateTime(2023, 9, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1768), "Description for Model2 for Brand 5", "Model2 for Brand 5", new DateTime(2024, 7, 1, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1768) },
                    { new Guid("2cad3a5f-418d-4404-b140-cfc28ae495df"), new Guid("72ab631d-97e7-490f-96ea-51db3c443d17"), new DateTime(2023, 4, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1920), "Description for Model3 for Brand 13", "Model3 for Brand 13", new DateTime(2023, 8, 9, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1920) },
                    { new Guid("2f25c032-4b4f-4675-868f-cfac331094bd"), new Guid("070733bf-996d-4a48-9842-8010eeaf8d4b"), new DateTime(2023, 4, 30, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1789), "Description for Model3 for Brand 6", "Model3 for Brand 6", new DateTime(2024, 2, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1789) },
                    { new Guid("322e964e-6d36-4c67-9ce4-ab52b1d794bd"), new Guid("bd54c8ca-6ce2-472f-a17f-62a4c895d832"), new DateTime(2023, 11, 12, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1859), "Description for Model2 for Brand 11", "Model2 for Brand 11", new DateTime(2024, 3, 27, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1859) },
                    { new Guid("39d91e45-f53a-4d4d-b95f-b907da6cac71"), new Guid("ae5990c4-aa65-4549-a181-4cbba34e3939"), new DateTime(2023, 10, 2, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1804), "Description for Model3 for Brand 7", "Model3 for Brand 7", new DateTime(2023, 11, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1804) },
                    { new Guid("4987e004-aaa1-4ab2-ab2e-cb824ffdce35"), new Guid("0c32db92-af97-4e7e-8b87-8f4c073c3521"), new DateTime(2023, 6, 2, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1894), "Description for Model1 for Brand 12", "Model1 for Brand 12", new DateTime(2024, 3, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1894) },
                    { new Guid("4b1c46f3-6376-470b-a1f6-63f9dc88b383"), new Guid("56601d97-96da-48de-b694-96795fb6d46a"), new DateTime(2024, 2, 23, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1773), "Description for Model3 for Brand 5", "Model3 for Brand 5", new DateTime(2024, 8, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1773) },
                    { new Guid("5dd98c7d-e5b1-435d-a4ea-68cf37cd0014"), new Guid("59a66ee3-aada-4865-8249-732ac1c6304c"), new DateTime(2024, 1, 11, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1936), "Description for Model3 for Brand 14", "Model3 for Brand 14", new DateTime(2024, 8, 2, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1936) },
                    { new Guid("675e724d-13d0-4b36-a9d0-9c33f5c30a27"), new Guid("ae5990c4-aa65-4549-a181-4cbba34e3939"), new DateTime(2023, 10, 23, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1794), "Description for Model1 for Brand 7", "Model1 for Brand 7", new DateTime(2024, 7, 30, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1794) },
                    { new Guid("6fe60e44-0ace-4d27-ae31-84998931d164"), new Guid("4795d99a-a689-4225-96b5-a8720cb850a5"), new DateTime(2023, 12, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1845), "Description for Model2 for Brand 10", "Model2 for Brand 10", new DateTime(2024, 3, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1845) },
                    { new Guid("750e1e6b-775b-4313-a4c3-b52a5c9d6272"), new Guid("e48d37cd-e956-4e6f-aabc-920c79f88b03"), new DateTime(2023, 7, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1724), "Description for Model3 for Brand 2", "Model3 for Brand 2", new DateTime(2024, 3, 9, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1724) },
                    { new Guid("76f2ef55-06f7-4e37-b70e-682d22b8e441"), new Guid("9eb85149-47ca-48d6-a4b4-dff9866bd2ba"), new DateTime(2023, 8, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1753), "Description for Model2 for Brand 4", "Model2 for Brand 4", new DateTime(2024, 1, 25, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1753) },
                    { new Guid("789636d9-c9ef-41d8-9545-2215b6547e0b"), new Guid("583c3492-fb7f-4dcf-ae6d-9bdb0bbc8705"), new DateTime(2023, 12, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1953), "Description for Model3 for Brand 15", "Model3 for Brand 15", new DateTime(2024, 8, 24, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1953) },
                    { new Guid("78ebfbe6-377d-40a8-a230-fd6afc755794"), new Guid("57092ec8-8acd-48d5-a12b-0ea90c91d1e5"), new DateTime(2023, 12, 28, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1730), "Description for Model1 for Brand 3", "Model1 for Brand 3", new DateTime(2024, 5, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1730) },
                    { new Guid("7ac4ae84-58e5-4007-ac2e-4c731993294c"), new Guid("0c32db92-af97-4e7e-8b87-8f4c073c3521"), new DateTime(2023, 5, 18, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1905), "Description for Model3 for Brand 12", "Model3 for Brand 12", new DateTime(2024, 4, 20, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1905) },
                    { new Guid("83102d3a-27d0-49ef-99be-ce6fa143cfa3"), new Guid("9eb85149-47ca-48d6-a4b4-dff9866bd2ba"), new DateTime(2024, 1, 25, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1748), "Description for Model1 for Brand 4", "Model1 for Brand 4", new DateTime(2024, 10, 5, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1748) },
                    { new Guid("8e4bbee4-f1f5-4380-90f7-ebf413e2dd33"), new Guid("e48d37cd-e956-4e6f-aabc-920c79f88b03"), new DateTime(2024, 1, 27, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1716), "Description for Model2 for Brand 2", "Model2 for Brand 2", new DateTime(2024, 10, 6, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1716) },
                    { new Guid("8edf1831-29d1-4c3d-9986-ba33d44fc15e"), new Guid("59a66ee3-aada-4865-8249-732ac1c6304c"), new DateTime(2023, 6, 24, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1931), "Description for Model2 for Brand 14", "Model2 for Brand 14", new DateTime(2024, 2, 17, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1931) },
                    { new Guid("946a29b7-e5bf-4f1f-b657-09758683326b"), new Guid("79c775ed-8a3b-43dc-9ff2-f13472fe24ac"), new DateTime(2023, 4, 10, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1672), "Description for Model2 for Brand 1", "Model2 for Brand 1", new DateTime(2023, 4, 20, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1672) },
                    { new Guid("9abdc373-36cd-4165-b296-b394658673c6"), new Guid("72ab631d-97e7-490f-96ea-51db3c443d17"), new DateTime(2024, 1, 31, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1910), "Description for Model1 for Brand 13", "Model1 for Brand 13", new DateTime(2024, 6, 2, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1910) },
                    { new Guid("a797c91f-048e-495b-8aa7-327ddc2dffac"), new Guid("97fd23c4-9ca7-42c9-86ec-6da5f7f3f743"), new DateTime(2023, 10, 30, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1825), "Description for Model1 for Brand 9", "Model1 for Brand 9", new DateTime(2023, 12, 17, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1825) },
                    { new Guid("abcc0307-a0aa-4d5c-8b9c-2f4e7e1956c2"), new Guid("583c3492-fb7f-4dcf-ae6d-9bdb0bbc8705"), new DateTime(2024, 2, 19, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1941), "Description for Model1 for Brand 15", "Model1 for Brand 15", new DateTime(2024, 6, 23, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1941) },
                    { new Guid("b677558a-2471-495b-9f1a-75a483e085a6"), new Guid("e48d37cd-e956-4e6f-aabc-920c79f88b03"), new DateTime(2024, 1, 7, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1682), "Description for Model1 for Brand 2", "Model1 for Brand 2", new DateTime(2024, 3, 23, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1682) },
                    { new Guid("b701bc01-00d0-4118-a205-c25126bdf815"), new Guid("4795d99a-a689-4225-96b5-a8720cb850a5"), new DateTime(2023, 12, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1840), "Description for Model1 for Brand 10", "Model1 for Brand 10", new DateTime(2024, 10, 28, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1840) },
                    { new Guid("bd297f97-7a1d-4d83-9ddf-c4a9c969d15b"), new Guid("ae5990c4-aa65-4549-a181-4cbba34e3939"), new DateTime(2023, 8, 20, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1799), "Description for Model2 for Brand 7", "Model2 for Brand 7", new DateTime(2024, 5, 31, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1799) },
                    { new Guid("bfc8ec35-a982-4e94-bb62-bccf1945e7f5"), new Guid("070733bf-996d-4a48-9842-8010eeaf8d4b"), new DateTime(2023, 4, 11, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1784), "Description for Model2 for Brand 6", "Model2 for Brand 6", new DateTime(2023, 11, 12, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1784) },
                    { new Guid("c250c0ed-1819-4062-932b-bc37755c2673"), new Guid("583c3492-fb7f-4dcf-ae6d-9bdb0bbc8705"), new DateTime(2023, 6, 19, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1948), "Description for Model2 for Brand 15", "Model2 for Brand 15", new DateTime(2023, 8, 5, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1948) },
                    { new Guid("c522300b-6d6a-4da5-8234-d280676c760e"), new Guid("070733bf-996d-4a48-9842-8010eeaf8d4b"), new DateTime(2023, 5, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1777), "Description for Model1 for Brand 6", "Model1 for Brand 6", new DateTime(2023, 7, 28, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1777) },
                    { new Guid("cd04fb8a-3323-4c72-81a0-0e267329236f"), new Guid("57092ec8-8acd-48d5-a12b-0ea90c91d1e5"), new DateTime(2023, 11, 18, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1736), "Description for Model2 for Brand 3", "Model2 for Brand 3", new DateTime(2024, 2, 19, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1736) },
                    { new Guid("ce06f39e-b09b-4570-94c3-cd3ee8a3e6fa"), new Guid("59a66ee3-aada-4865-8249-732ac1c6304c"), new DateTime(2023, 10, 31, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1924), "Description for Model1 for Brand 14", "Model1 for Brand 14", new DateTime(2024, 3, 28, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1924) },
                    { new Guid("d7b38009-0cbe-4418-a35a-3914a7487889"), new Guid("57092ec8-8acd-48d5-a12b-0ea90c91d1e5"), new DateTime(2023, 12, 1, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1742), "Description for Model3 for Brand 3", "Model3 for Brand 3", new DateTime(2024, 6, 23, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1742) },
                    { new Guid("d9218188-a265-4c98-bbdf-34064b0eace3"), new Guid("0c32db92-af97-4e7e-8b87-8f4c073c3521"), new DateTime(2023, 8, 25, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1900), "Description for Model2 for Brand 12", "Model2 for Brand 12", new DateTime(2023, 12, 1, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1900) },
                    { new Guid("e5816483-6ef6-4d99-affb-741c1ddb838c"), new Guid("74063f86-96b8-4aee-85b2-9a3c4b6bc2a4"), new DateTime(2023, 6, 25, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1808), "Description for Model1 for Brand 8", "Model1 for Brand 8", new DateTime(2023, 8, 6, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1808) },
                    { new Guid("e68cafef-9465-4dba-864d-d01edb83c4be"), new Guid("4795d99a-a689-4225-96b5-a8720cb850a5"), new DateTime(2023, 11, 6, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1850), "Description for Model3 for Brand 10", "Model3 for Brand 10", new DateTime(2024, 1, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1850) },
                    { new Guid("efa74c9f-9bdd-456d-999b-b1c1aae347f8"), new Guid("97fd23c4-9ca7-42c9-86ec-6da5f7f3f743"), new DateTime(2023, 11, 30, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1835), "Description for Model3 for Brand 9", "Model3 for Brand 9", new DateTime(2024, 9, 17, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1835) },
                    { new Guid("f516873e-db33-46e0-89db-b8f557f31778"), new Guid("74063f86-96b8-4aee-85b2-9a3c4b6bc2a4"), new DateTime(2023, 4, 1, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1813), "Description for Model2 for Brand 8", "Model2 for Brand 8", new DateTime(2023, 7, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1813) },
                    { new Guid("f8548b14-3b62-4846-8c00-f1bc7c218b84"), new Guid("9eb85149-47ca-48d6-a4b4-dff9866bd2ba"), new DateTime(2024, 1, 4, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1758), "Description for Model3 for Brand 4", "Model3 for Brand 4", new DateTime(2024, 9, 20, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1758) },
                    { new Guid("f9a282b3-88fb-4b5e-85ae-622ca67d99b4"), new Guid("bd54c8ca-6ce2-472f-a17f-62a4c895d832"), new DateTime(2024, 2, 25, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1866), "Description for Model3 for Brand 11", "Model3 for Brand 11", new DateTime(2024, 4, 14, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1866) },
                    { new Guid("ff2371b1-2e49-4a16-b9c8-99df8157d22d"), new Guid("bd54c8ca-6ce2-472f-a17f-62a4c895d832"), new DateTime(2023, 3, 6, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1854), "Description for Model1 for Brand 11", "Model1 for Brand 11", new DateTime(2023, 9, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(1854) }
                });

            migrationBuilder.InsertData(
                table: "CarEntityModel",
                columns: new[] { "Id", "ColorId", "CreateDateTime", "Description", "EngineVolume", "ModelId", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("21e932fc-326d-4669-9bf1-e8bae79852c5"), new Guid("15fb55f5-fa8f-417e-95a0-85f2fc65f6fc"), new DateTime(2023, 12, 27, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2072), "Description for car 5", 4270.0, new Guid("6fe60e44-0ace-4d27-ae31-84998931d164"), new DateTime(2023, 12, 28, 4, 0, 44, 587, DateTimeKind.Utc).AddTicks(2072) },
                    { new Guid("2dff8793-fff9-481f-9620-a64d995a993d"), new Guid("9fcb557d-30e5-4ca0-8b3c-e05a42732e75"), new DateTime(2023, 9, 18, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2063), "Description for car 2", 3467.0, new Guid("c250c0ed-1819-4062-932b-bc37755c2673"), new DateTime(2023, 9, 19, 16, 0, 44, 587, DateTimeKind.Utc).AddTicks(2063) },
                    { new Guid("2e232be3-723e-4e0c-b006-4ea2461520b6"), new Guid("4a7b1a47-c610-4526-b4a7-ab87ea28bb77"), new DateTime(2023, 4, 8, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2135), "Description for car 17", 4237.0, new Guid("abcc0307-a0aa-4d5c-8b9c-2f4e7e1956c2"), new DateTime(2023, 4, 9, 1, 0, 44, 587, DateTimeKind.Utc).AddTicks(2135) },
                    { new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"), new Guid("e93ac787-2cdb-4c4b-946f-6cc606665f31"), new DateTime(2023, 4, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2143), "Description for car 19", 4195.0, new Guid("f9a282b3-88fb-4b5e-85ae-622ca67d99b4"), new DateTime(2023, 4, 22, 1, 0, 44, 587, DateTimeKind.Utc).AddTicks(2143) },
                    { new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"), new Guid("3a345cc1-d24f-4472-8571-43e22e06f02b"), new DateTime(2024, 2, 16, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2111), "Description for car 9", 1910.0, new Guid("bd297f97-7a1d-4d83-9ddf-c4a9c969d15b"), new DateTime(2024, 2, 17, 9, 0, 44, 587, DateTimeKind.Utc).AddTicks(2111) },
                    { new Guid("7a970bcf-3f40-4f79-ad37-7db2c7ddd609"), new Guid("a227c998-85d8-4d13-a1c2-dc8972dabc13"), new DateTime(2023, 5, 7, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2067), "Description for car 3", 4302.0, new Guid("f9a282b3-88fb-4b5e-85ae-622ca67d99b4"), new DateTime(2023, 5, 8, 10, 0, 44, 587, DateTimeKind.Utc).AddTicks(2067) },
                    { new Guid("89923444-9dff-4ee7-a498-25b1319fb6a3"), new Guid("4a7b1a47-c610-4526-b4a7-ab87ea28bb77"), new DateTime(2024, 1, 18, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2145), "Description for car 20", 4467.0, new Guid("2cad3a5f-418d-4404-b140-cfc28ae495df"), new DateTime(2024, 1, 18, 22, 0, 44, 587, DateTimeKind.Utc).AddTicks(2145) },
                    { new Guid("89d8a840-6e7c-4b4c-b823-dbb3cf1bdf93"), new Guid("4a7b1a47-c610-4526-b4a7-ab87ea28bb77"), new DateTime(2023, 3, 20, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2115), "Description for car 10", 4375.0, new Guid("4987e004-aaa1-4ab2-ab2e-cb824ffdce35"), new DateTime(2023, 3, 21, 15, 0, 44, 587, DateTimeKind.Utc).AddTicks(2115) },
                    { new Guid("8d9a0a67-06d5-48a3-87d7-88fa34d9a5f8"), new Guid("570f7ae0-08e8-4f04-a749-7de45e416569"), new DateTime(2023, 4, 19, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2076), "Description for car 6", 1393.0, new Guid("0159fb7d-e894-4ba8-8469-dd0414f429db"), new DateTime(2023, 4, 19, 21, 0, 44, 587, DateTimeKind.Utc).AddTicks(2076) },
                    { new Guid("9134b318-baff-4bd9-9bf1-deb21cc2efcd"), new Guid("4a7b1a47-c610-4526-b4a7-ab87ea28bb77"), new DateTime(2023, 5, 9, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2120), "Description for car 11", 1826.0, new Guid("8edf1831-29d1-4c3d-9986-ba33d44fc15e"), new DateTime(2023, 5, 10, 1, 0, 44, 587, DateTimeKind.Utc).AddTicks(2120) },
                    { new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"), new Guid("dd3068d7-546e-4940-b554-c36789d039c8"), new DateTime(2023, 5, 16, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2056), "Description for car 1", 1206.0, new Guid("8e4bbee4-f1f5-4380-90f7-ebf413e2dd33"), new DateTime(2023, 5, 17, 9, 0, 44, 587, DateTimeKind.Utc).AddTicks(2056) },
                    { new Guid("ac04193f-021c-4683-a6d1-977c2e46b4a1"), new Guid("4a7b1a47-c610-4526-b4a7-ab87ea28bb77"), new DateTime(2023, 8, 14, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2138), "Description for car 18", 2606.0, new Guid("0d751061-a872-46a6-aa23-e5d7439bd058"), new DateTime(2023, 8, 15, 15, 0, 44, 587, DateTimeKind.Utc).AddTicks(2138) },
                    { new Guid("b7d60477-13a1-4e01-8c4b-974c51ab4460"), new Guid("0d6447c5-6257-4326-b541-b44b09512f88"), new DateTime(2023, 7, 6, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2122), "Description for car 12", 1788.0, new Guid("cd04fb8a-3323-4c72-81a0-0e267329236f"), new DateTime(2023, 7, 7, 1, 0, 44, 587, DateTimeKind.Utc).AddTicks(2122) },
                    { new Guid("bc48f96c-8419-4800-ae49-998855191926"), new Guid("15fb55f5-fa8f-417e-95a0-85f2fc65f6fc"), new DateTime(2023, 5, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2125), "Description for car 13", 1671.0, new Guid("5dd98c7d-e5b1-435d-a4ea-68cf37cd0014"), new DateTime(2023, 5, 30, 9, 0, 44, 587, DateTimeKind.Utc).AddTicks(2125) },
                    { new Guid("bd1e2600-5c4f-4f5c-a48d-75512f0b0f56"), new Guid("0d6447c5-6257-4326-b541-b44b09512f88"), new DateTime(2024, 1, 20, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2108), "Description for car 8", 1824.0, new Guid("946a29b7-e5bf-4f1f-b657-09758683326b"), new DateTime(2024, 1, 21, 3, 0, 44, 587, DateTimeKind.Utc).AddTicks(2108) },
                    { new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), new Guid("4a7b1a47-c610-4526-b4a7-ab87ea28bb77"), new DateTime(2023, 10, 5, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2130), "Description for car 15", 4644.0, new Guid("76f2ef55-06f7-4e37-b70e-682d22b8e441"), new DateTime(2023, 10, 6, 0, 0, 44, 587, DateTimeKind.Utc).AddTicks(2130) },
                    { new Guid("ea46cf2c-d785-4488-b833-ff8c046f74a4"), new Guid("15fb55f5-fa8f-417e-95a0-85f2fc65f6fc"), new DateTime(2023, 9, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2078), "Description for car 7", 1818.0, new Guid("0159fb7d-e894-4ba8-8469-dd0414f429db"), new DateTime(2023, 9, 22, 2, 0, 44, 587, DateTimeKind.Utc).AddTicks(2078) },
                    { new Guid("f161e5f8-2873-4c62-849c-50701e6743ea"), new Guid("a227c998-85d8-4d13-a1c2-dc8972dabc13"), new DateTime(2023, 5, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2132), "Description for car 16", 2693.0, new Guid("789636d9-c9ef-41d8-9545-2215b6547e0b"), new DateTime(2023, 5, 30, 10, 0, 44, 587, DateTimeKind.Utc).AddTicks(2132) },
                    { new Guid("f5df6cdf-e899-425d-995e-6c0077592f5d"), new Guid("4af04a4b-c5dc-44c3-a74a-023af34407a8"), new DateTime(2023, 4, 12, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2070), "Description for car 4", 1071.0, new Guid("83102d3a-27d0-49ef-99be-ce6fa143cfa3"), new DateTime(2023, 4, 13, 3, 0, 44, 587, DateTimeKind.Utc).AddTicks(2070) },
                    { new Guid("fdd9c3fb-e523-4ff8-9ab3-f4eb7ff50842"), new Guid("e93ac787-2cdb-4c4b-946f-6cc606665f31"), new DateTime(2023, 7, 8, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2127), "Description for car 14", 3361.0, new Guid("ce06f39e-b09b-4570-94c3-cd3ee8a3e6fa"), new DateTime(2023, 7, 9, 6, 0, 44, 587, DateTimeKind.Utc).AddTicks(2127) }
                });

            migrationBuilder.InsertData(
                table: "CarPhotoEntityModel",
                columns: new[] { "Id", "CarId", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("07c4ec6b-81fc-45e1-a99d-a511b3d3debd"), new Guid("ac04193f-021c-4683-a6d1-977c2e46b4a1"), "https://example.com/photo1.jpg" },
                    { new Guid("1363b588-147c-40ec-9adb-606fd1de14ba"), new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"), "https://example.com/photo2.jpg" },
                    { new Guid("13ccbf96-a960-4e89-8dfa-2e73786787e5"), new Guid("2e232be3-723e-4e0c-b006-4ea2461520b6"), "https://example.com/photo1.jpg" },
                    { new Guid("1dc24ddf-688e-4348-8865-5b0fb162b1f2"), new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), "https://example.com/photo3.jpg" },
                    { new Guid("2dc1b26a-b3d1-4502-9e91-f4dac72b315c"), new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"), "https://example.com/photo1.jpg" },
                    { new Guid("33f9ca73-495b-41ff-8172-d3789ed2b21f"), new Guid("f161e5f8-2873-4c62-849c-50701e6743ea"), "https://example.com/photo4.jpg" },
                    { new Guid("38808304-e2f0-4f4d-ba61-f267460a54b5"), new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"), "https://example.com/photo3.jpg" },
                    { new Guid("3a48e5c9-f14d-4e75-a573-057781a4351e"), new Guid("9134b318-baff-4bd9-9bf1-deb21cc2efcd"), "https://example.com/photo3.jpg" },
                    { new Guid("3a6beffe-9091-4e59-8d9a-316dc3a620fc"), new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"), "https://example.com/photo1.jpg" },
                    { new Guid("3dc4e9b1-295f-4935-bff3-acb43eac08c2"), new Guid("89d8a840-6e7c-4b4c-b823-dbb3cf1bdf93"), "https://example.com/photo2.jpg" },
                    { new Guid("462b86ce-cac3-45fe-8ca2-5856d3476a2d"), new Guid("9134b318-baff-4bd9-9bf1-deb21cc2efcd"), "https://example.com/photo1.jpg" },
                    { new Guid("493988db-ed98-4f46-ae52-caac232528dd"), new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"), "https://example.com/photo2.jpg" },
                    { new Guid("4f588d34-e221-4f7f-8fc8-7469088898df"), new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"), "https://example.com/photo4.jpg" },
                    { new Guid("4f98180f-7eac-4a67-a839-ed820812ff72"), new Guid("b7d60477-13a1-4e01-8c4b-974c51ab4460"), "https://example.com/photo2.jpg" },
                    { new Guid("58fbca8f-2847-4092-8f99-29f9d1fdf6ea"), new Guid("9134b318-baff-4bd9-9bf1-deb21cc2efcd"), "https://example.com/photo2.jpg" },
                    { new Guid("59798b17-936b-4dbd-8066-d78a5461cb4a"), new Guid("b7d60477-13a1-4e01-8c4b-974c51ab4460"), "https://example.com/photo1.jpg" },
                    { new Guid("59c8c58b-3976-41a8-a62f-f0da3bb68476"), new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), "https://example.com/photo1.jpg" },
                    { new Guid("5dc0b63e-b43a-4103-8dcf-436fc8bd6fbf"), new Guid("f161e5f8-2873-4c62-849c-50701e6743ea"), "https://example.com/photo1.jpg" },
                    { new Guid("6a864eca-928c-4ded-ace7-3a1afae4fc67"), new Guid("8d9a0a67-06d5-48a3-87d7-88fa34d9a5f8"), "https://example.com/photo1.jpg" },
                    { new Guid("6cc94fbb-8aef-4992-bf5d-bba902e2c652"), new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"), "https://example.com/photo3.jpg" },
                    { new Guid("8a471dcf-030c-44c8-92b2-ea2807f2e2ea"), new Guid("f5df6cdf-e899-425d-995e-6c0077592f5d"), "https://example.com/photo3.jpg" },
                    { new Guid("919affb3-8ad4-4368-818a-0e9b8a44bf3a"), new Guid("f5df6cdf-e899-425d-995e-6c0077592f5d"), "https://example.com/photo2.jpg" },
                    { new Guid("91ba22ec-615a-4ed7-8e5a-3d06ed8c1741"), new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"), "https://example.com/photo4.jpg" },
                    { new Guid("96fcf234-de80-47f6-97af-a2344f9b488c"), new Guid("bd1e2600-5c4f-4f5c-a48d-75512f0b0f56"), "https://example.com/photo2.jpg" },
                    { new Guid("9772d9a1-71a4-47f6-b996-01afe7a78f9c"), new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"), "https://example.com/photo1.jpg" },
                    { new Guid("9ad9d859-1723-43c4-8420-c916563c8a46"), new Guid("f161e5f8-2873-4c62-849c-50701e6743ea"), "https://example.com/photo3.jpg" },
                    { new Guid("a84bcd4a-9243-430f-aace-a61fc9a6ae27"), new Guid("2dff8793-fff9-481f-9620-a64d995a993d"), "https://example.com/photo1.jpg" },
                    { new Guid("b16620a2-e7c7-4c01-ad64-6818a77232ab"), new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), "https://example.com/photo4.jpg" },
                    { new Guid("b5d34a84-fe66-4ee1-a0f1-9066a583aa59"), new Guid("f161e5f8-2873-4c62-849c-50701e6743ea"), "https://example.com/photo2.jpg" },
                    { new Guid("bf9e5c73-8156-4707-9880-f9d767acd34e"), new Guid("89d8a840-6e7c-4b4c-b823-dbb3cf1bdf93"), "https://example.com/photo1.jpg" },
                    { new Guid("c95f0528-dd11-4734-bec3-78c2443bf90a"), new Guid("fdd9c3fb-e523-4ff8-9ab3-f4eb7ff50842"), "https://example.com/photo1.jpg" },
                    { new Guid("d172c07c-a47b-4e5a-bdde-89d65707f9d6"), new Guid("bc48f96c-8419-4800-ae49-998855191926"), "https://example.com/photo1.jpg" },
                    { new Guid("d40223d8-d986-435b-b7cc-38c63b0f7aa1"), new Guid("bc48f96c-8419-4800-ae49-998855191926"), "https://example.com/photo2.jpg" },
                    { new Guid("dd74a486-1ce4-4e03-a0db-670ba39bd01a"), new Guid("f5df6cdf-e899-425d-995e-6c0077592f5d"), "https://example.com/photo1.jpg" },
                    { new Guid("eab186b3-0dd0-4738-8186-ade2f0682394"), new Guid("bd1e2600-5c4f-4f5c-a48d-75512f0b0f56"), "https://example.com/photo1.jpg" },
                    { new Guid("ed9d30da-84ad-45e5-a44a-aee25f78cfb0"), new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"), "https://example.com/photo3.jpg" },
                    { new Guid("edd33d04-6eed-477a-b8f1-f370a326904e"), new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"), "https://example.com/photo2.jpg" },
                    { new Guid("f5b3ae46-e35a-4645-8ea0-9d53f47ac2ea"), new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), "https://example.com/photo2.jpg" },
                    { new Guid("fe4204ce-3965-48fa-8585-3629dadb6e42"), new Guid("ea46cf2c-d785-4488-b833-ff8c046f74a4"), "https://example.com/photo1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PriceHistoryEntityModel",
                columns: new[] { "Id", "CarId", "CreateDateTime", "CurrencyId", "Price", "StartDate", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("03e53046-3e51-4594-90a8-7aa13b671ce8"), new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), new DateTime(2024, 1, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2501), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 421.0, new DateTime(2023, 3, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2501), new DateTime(2024, 1, 30, 3, 0, 44, 587, DateTimeKind.Utc).AddTicks(2501) },
                    { new Guid("0875ac78-7e30-4d8b-ba6c-7291e7444e3c"), new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), new DateTime(2024, 2, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2511), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 777.0, new DateTime(2023, 8, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2510), new DateTime(2024, 2, 16, 10, 0, 44, 587, DateTimeKind.Utc).AddTicks(2511) },
                    { new Guid("102160b9-b241-474f-b242-5165b64a0b53"), new Guid("89d8a840-6e7c-4b4c-b823-dbb3cf1bdf93"), new DateTime(2024, 2, 12, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2453), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 984.0, new DateTime(2023, 3, 8, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2453), new DateTime(2024, 2, 13, 11, 0, 44, 587, DateTimeKind.Utc).AddTicks(2453) },
                    { new Guid("10b82217-98c9-439b-bb8b-fb2860a3750f"), new Guid("f5df6cdf-e899-425d-995e-6c0077592f5d"), new DateTime(2024, 2, 18, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2411), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 691.0, new DateTime(2023, 4, 14, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 2, 19, 9, 0, 44, 587, DateTimeKind.Utc).AddTicks(2411) },
                    { new Guid("126b0b24-8b1c-4891-a733-0b148a229865"), new Guid("9134b318-baff-4bd9-9bf1-deb21cc2efcd"), new DateTime(2024, 2, 20, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2489), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 673.0, new DateTime(2023, 6, 10, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2488), new DateTime(2024, 2, 21, 4, 0, 44, 587, DateTimeKind.Utc).AddTicks(2489) },
                    { new Guid("1451eee6-6277-4c7f-a50f-8233e7c8d90c"), new Guid("ea46cf2c-d785-4488-b833-ff8c046f74a4"), new DateTime(2024, 2, 13, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2432), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 876.0, new DateTime(2024, 2, 12, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2432), new DateTime(2024, 2, 14, 14, 0, 44, 587, DateTimeKind.Utc).AddTicks(2432) },
                    { new Guid("1721c6df-0579-44d2-b7d5-d59ab9bacc10"), new Guid("8d9a0a67-06d5-48a3-87d7-88fa34d9a5f8"), new DateTime(2024, 2, 12, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2425), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 820.0, new DateTime(2023, 12, 25, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2425), new DateTime(2024, 2, 13, 2, 0, 44, 587, DateTimeKind.Utc).AddTicks(2425) },
                    { new Guid("194004fe-000e-4cc4-a36a-94c624c53bee"), new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"), new DateTime(2024, 1, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2529), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 274.0, new DateTime(2024, 1, 13, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2529), new DateTime(2024, 1, 29, 21, 0, 44, 587, DateTimeKind.Utc).AddTicks(2529) },
                    { new Guid("20f0e330-fd30-403e-bfe0-49791651af2d"), new Guid("9134b318-baff-4bd9-9bf1-deb21cc2efcd"), new DateTime(2024, 2, 10, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2491), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 941.0, new DateTime(2024, 1, 31, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2491), new DateTime(2024, 2, 11, 0, 0, 44, 587, DateTimeKind.Utc).AddTicks(2491) },
                    { new Guid("28e28901-5123-4580-ae44-a4bc77d910ef"), new Guid("8d9a0a67-06d5-48a3-87d7-88fa34d9a5f8"), new DateTime(2024, 1, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2428), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 523.0, new DateTime(2023, 3, 5, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2427), new DateTime(2024, 1, 30, 6, 0, 44, 587, DateTimeKind.Utc).AddTicks(2428) },
                    { new Guid("2d14e2c4-0d4b-4e46-9c57-f34145792c37"), new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"), new DateTime(2024, 2, 13, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2373), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 58.0, new DateTime(2023, 6, 18, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2372), new DateTime(2024, 2, 14, 16, 0, 44, 587, DateTimeKind.Utc).AddTicks(2373) },
                    { new Guid("3aae8616-54ef-4412-b6e3-82322662d9f3"), new Guid("bd1e2600-5c4f-4f5c-a48d-75512f0b0f56"), new DateTime(2024, 2, 24, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2438), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 375.0, new DateTime(2023, 9, 2, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2437), new DateTime(2024, 2, 25, 2, 0, 44, 587, DateTimeKind.Utc).AddTicks(2438) },
                    { new Guid("3c965409-88f4-4dc4-8e84-9ddc65ba660f"), new Guid("2dff8793-fff9-481f-9620-a64d995a993d"), new DateTime(2024, 1, 30, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2408), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 892.0, new DateTime(2023, 9, 17, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2407), new DateTime(2024, 1, 30, 22, 0, 44, 587, DateTimeKind.Utc).AddTicks(2408) },
                    { new Guid("3f6993b8-834f-4ebe-9ed5-cac5230ffdc5"), new Guid("89d8a840-6e7c-4b4c-b823-dbb3cf1bdf93"), new DateTime(2024, 2, 4, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2458), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 167.0, new DateTime(2023, 3, 16, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2457), new DateTime(2024, 2, 4, 20, 0, 44, 587, DateTimeKind.Utc).AddTicks(2458) },
                    { new Guid("45837246-7c82-4df8-9ec0-6b27da55c26a"), new Guid("2dff8793-fff9-481f-9620-a64d995a993d"), new DateTime(2024, 2, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2399), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 806.0, new DateTime(2023, 9, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2399), new DateTime(2024, 2, 4, 9, 0, 44, 587, DateTimeKind.Utc).AddTicks(2399) },
                    { new Guid("48ac2b8b-353a-4c2c-bd8b-a04b497d45c3"), new Guid("89923444-9dff-4ee7-a498-25b1319fb6a3"), new DateTime(2024, 1, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2541), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 654.0, new DateTime(2023, 6, 27, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2541), new DateTime(2024, 1, 30, 11, 0, 44, 587, DateTimeKind.Utc).AddTicks(2541) },
                    { new Guid("4f56a91c-85fe-40e3-8463-e8f4803cbb83"), new Guid("ac04193f-021c-4683-a6d1-977c2e46b4a1"), new DateTime(2024, 2, 6, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2516), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 584.0, new DateTime(2023, 8, 13, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2516), new DateTime(2024, 2, 7, 3, 0, 44, 587, DateTimeKind.Utc).AddTicks(2516) },
                    { new Guid("4fbe27d5-5405-476d-9c85-be17c0a91e9f"), new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"), new DateTime(2024, 2, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2532), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 452.0, new DateTime(2023, 8, 2, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2531), new DateTime(2024, 2, 22, 19, 0, 44, 587, DateTimeKind.Utc).AddTicks(2532) },
                    { new Guid("5a7f681f-f4d5-4d26-a685-0a5e14687796"), new Guid("ea46cf2c-d785-4488-b833-ff8c046f74a4"), new DateTime(2024, 2, 1, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2430), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 436.0, new DateTime(2024, 1, 23, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 2, 1, 21, 0, 44, 587, DateTimeKind.Utc).AddTicks(2430) },
                    { new Guid("61e98e85-16f0-4e78-bd7e-5a017d69ddcc"), new Guid("2dff8793-fff9-481f-9620-a64d995a993d"), new DateTime(2024, 2, 13, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2405), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 267.0, new DateTime(2023, 8, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2405), new DateTime(2024, 2, 14, 0, 0, 44, 587, DateTimeKind.Utc).AddTicks(2405) },
                    { new Guid("6541f8ce-0a96-4ae1-86aa-d6bed2dfcbcd"), new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"), new DateTime(2024, 1, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2523), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 732.0, new DateTime(2023, 3, 29, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2523), new DateTime(2024, 1, 30, 0, 0, 44, 587, DateTimeKind.Utc).AddTicks(2523) },
                    { new Guid("6827edbe-326a-46d3-bad9-07bb45502982"), new Guid("89923444-9dff-4ee7-a498-25b1319fb6a3"), new DateTime(2024, 2, 16, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2537), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 463.0, new DateTime(2023, 6, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2536), new DateTime(2024, 2, 17, 0, 0, 44, 587, DateTimeKind.Utc).AddTicks(2537) },
                    { new Guid("6c9a106d-16a2-48e4-bc02-e105c7c81d8b"), new Guid("2e232be3-723e-4e0c-b006-4ea2461520b6"), new DateTime(2024, 2, 7, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2514), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 535.0, new DateTime(2023, 10, 8, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2513), new DateTime(2024, 2, 8, 10, 0, 44, 587, DateTimeKind.Utc).AddTicks(2514) },
                    { new Guid("7244e7da-cede-44c0-9429-e37502027afb"), new Guid("89d8a840-6e7c-4b4c-b823-dbb3cf1bdf93"), new DateTime(2024, 2, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2456), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 372.0, new DateTime(2023, 9, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 2, 22, 5, 0, 44, 587, DateTimeKind.Utc).AddTicks(2456) },
                    { new Guid("7b422782-07e3-481f-82c1-97233b99aff3"), new Guid("8d9a0a67-06d5-48a3-87d7-88fa34d9a5f8"), new DateTime(2024, 2, 5, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2423), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 446.0, new DateTime(2024, 1, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2423), new DateTime(2024, 2, 6, 11, 0, 44, 587, DateTimeKind.Utc).AddTicks(2423) },
                    { new Guid("8009b37a-b737-4e6a-901f-795e238335b7"), new Guid("f5df6cdf-e899-425d-995e-6c0077592f5d"), new DateTime(2024, 2, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2413), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 282.0, new DateTime(2023, 9, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2413), new DateTime(2024, 2, 21, 19, 0, 44, 587, DateTimeKind.Utc).AddTicks(2413) },
                    { new Guid("802b0009-031b-4698-b3e6-445f4760d735"), new Guid("ac04193f-021c-4683-a6d1-977c2e46b4a1"), new DateTime(2024, 2, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2521), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 511.0, new DateTime(2023, 4, 9, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2520), new DateTime(2024, 2, 22, 21, 0, 44, 587, DateTimeKind.Utc).AddTicks(2521) },
                    { new Guid("815d4270-f83b-4d7b-814b-0234727bb7fe"), new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"), new DateTime(2024, 2, 9, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2396), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 745.0, new DateTime(2023, 12, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2396), new DateTime(2024, 2, 10, 8, 0, 44, 587, DateTimeKind.Utc).AddTicks(2396) },
                    { new Guid("83605658-d9c2-48dd-82d4-d1155ba33b67"), new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"), new DateTime(2024, 2, 8, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2451), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 132.0, new DateTime(2024, 2, 19, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 2, 9, 17, 0, 44, 587, DateTimeKind.Utc).AddTicks(2451) },
                    { new Guid("836a2b57-13bd-4be6-8b47-5a4d97e0a85a"), new Guid("f5df6cdf-e899-425d-995e-6c0077592f5d"), new DateTime(2024, 2, 4, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2416), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 48.0, new DateTime(2023, 10, 31, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2416), new DateTime(2024, 2, 4, 20, 0, 44, 587, DateTimeKind.Utc).AddTicks(2416) },
                    { new Guid("879bc651-3782-4239-bf94-48c36349fc27"), new Guid("89923444-9dff-4ee7-a498-25b1319fb6a3"), new DateTime(2024, 2, 7, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2534), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 823.0, new DateTime(2023, 3, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2534), new DateTime(2024, 2, 8, 1, 0, 44, 587, DateTimeKind.Utc).AddTicks(2534) },
                    { new Guid("8a1c3ce1-060b-4971-8181-a33190545289"), new Guid("bd1e2600-5c4f-4f5c-a48d-75512f0b0f56"), new DateTime(2024, 2, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2444), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 276.0, new DateTime(2023, 11, 3, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2443), new DateTime(2024, 2, 16, 1, 0, 44, 587, DateTimeKind.Utc).AddTicks(2444) },
                    { new Guid("9271d620-87d3-4374-a1f8-4e0d273b369c"), new Guid("bd1e2600-5c4f-4f5c-a48d-75512f0b0f56"), new DateTime(2024, 2, 14, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2442), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 280.0, new DateTime(2023, 9, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2441), new DateTime(2024, 2, 15, 5, 0, 44, 587, DateTimeKind.Utc).AddTicks(2442) },
                    { new Guid("92ae5e57-c75a-445f-a956-4ab52f8a63c9"), new Guid("2dff8793-fff9-481f-9620-a64d995a993d"), new DateTime(2024, 2, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2402), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 933.0, new DateTime(2023, 4, 8, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2402), new DateTime(2024, 2, 15, 19, 0, 44, 587, DateTimeKind.Utc).AddTicks(2402) },
                    { new Guid("98309bf5-ae43-4775-9b03-a6b96d4921c9"), new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"), new DateTime(2024, 2, 5, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2525), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 188.0, new DateTime(2024, 1, 28, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2525), new DateTime(2024, 2, 6, 8, 0, 44, 587, DateTimeKind.Utc).AddTicks(2525) },
                    { new Guid("9a235f66-562b-4da6-b8a7-61dd8e3d81cf"), new Guid("bd1e2600-5c4f-4f5c-a48d-75512f0b0f56"), new DateTime(2024, 2, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2435), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 708.0, new DateTime(2024, 2, 2, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2434), new DateTime(2024, 2, 23, 14, 0, 44, 587, DateTimeKind.Utc).AddTicks(2435) },
                    { new Guid("9a8239e9-10e0-4872-b11f-a09cecd509c1"), new Guid("fdd9c3fb-e523-4ff8-9ab3-f4eb7ff50842"), new DateTime(2024, 2, 11, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2496), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 589.0, new DateTime(2023, 9, 18, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2496), new DateTime(2024, 2, 12, 9, 0, 44, 587, DateTimeKind.Utc).AddTicks(2496) },
                    { new Guid("a23e3ee5-1482-4fbf-9781-f8ff4be49468"), new Guid("9134b318-baff-4bd9-9bf1-deb21cc2efcd"), new DateTime(2024, 2, 7, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2486), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 57.0, new DateTime(2024, 2, 24, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2486), new DateTime(2024, 2, 8, 5, 0, 44, 587, DateTimeKind.Utc).AddTicks(2486) },
                    { new Guid("a9da6b7d-908e-49cc-9a6b-783676fb26c8"), new Guid("8d9a0a67-06d5-48a3-87d7-88fa34d9a5f8"), new DateTime(2024, 2, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2421), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 753.0, new DateTime(2023, 10, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2421), new DateTime(2024, 2, 16, 5, 0, 44, 587, DateTimeKind.Utc).AddTicks(2421) },
                    { new Guid("aa24474f-0f2a-4019-ad20-fed83a06435c"), new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"), new DateTime(2024, 2, 11, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2449), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 870.0, new DateTime(2023, 5, 6, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2448), new DateTime(2024, 2, 12, 14, 0, 44, 587, DateTimeKind.Utc).AddTicks(2449) },
                    { new Guid("b990b7a0-3661-4810-831e-869d2054fe08"), new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), new DateTime(2024, 2, 25, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2508), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 888.0, new DateTime(2023, 8, 16, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2508), new DateTime(2024, 2, 26, 12, 0, 44, 587, DateTimeKind.Utc).AddTicks(2508) },
                    { new Guid("d96a2e21-51d8-4fff-8db6-f275c56c1861"), new Guid("fdd9c3fb-e523-4ff8-9ab3-f4eb7ff50842"), new DateTime(2024, 2, 2, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2499), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 693.0, new DateTime(2023, 4, 26, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2498), new DateTime(2024, 2, 2, 23, 0, 44, 587, DateTimeKind.Utc).AddTicks(2499) },
                    { new Guid("ddfad10b-974c-460a-ba0a-35ac53cf5206"), new Guid("fdd9c3fb-e523-4ff8-9ab3-f4eb7ff50842"), new DateTime(2024, 1, 31, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2494), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 685.0, new DateTime(2023, 9, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2494), new DateTime(2024, 1, 31, 19, 0, 44, 587, DateTimeKind.Utc).AddTicks(2494) },
                    { new Guid("dfe2575a-4b62-41b7-b722-68575c0f48b3"), new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"), new DateTime(2024, 2, 15, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2447), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 784.0, new DateTime(2023, 6, 8, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2446), new DateTime(2024, 2, 16, 0, 0, 44, 587, DateTimeKind.Utc).AddTicks(2447) },
                    { new Guid("e06699a1-0334-42ce-9fd7-492508e5e11b"), new Guid("89923444-9dff-4ee7-a498-25b1319fb6a3"), new DateTime(2024, 2, 11, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2539), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 592.0, new DateTime(2023, 7, 27, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 2, 11, 19, 0, 44, 587, DateTimeKind.Utc).AddTicks(2539) },
                    { new Guid("e7157715-de78-4c0f-a427-b0e5bd799726"), new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"), new DateTime(2024, 2, 16, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2391), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 748.0, new DateTime(2024, 1, 21, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2391), new DateTime(2024, 2, 17, 10, 0, 44, 587, DateTimeKind.Utc).AddTicks(2391) },
                    { new Guid("f0a5e132-f498-4ad1-a761-d5309911d20f"), new Guid("dc95f70c-b467-4072-be66-875da9ac1549"), new DateTime(2024, 2, 24, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2504), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 476.0, new DateTime(2023, 5, 22, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 2, 24, 23, 0, 44, 587, DateTimeKind.Utc).AddTicks(2504) },
                    { new Guid("f6e1e7fe-cde1-466b-b8be-4637d16e836a"), new Guid("ac04193f-021c-4683-a6d1-977c2e46b4a1"), new DateTime(2024, 1, 31, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2518), new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"), 470.0, new DateTime(2023, 4, 9, 18, 0, 44, 587, DateTimeKind.Utc).AddTicks(2518), new DateTime(2024, 2, 1, 1, 0, 44, 587, DateTimeKind.Utc).AddTicks(2518) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("21e932fc-326d-4669-9bf1-e8bae79852c5"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7a970bcf-3f40-4f79-ad37-7db2c7ddd609"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("07c4ec6b-81fc-45e1-a99d-a511b3d3debd"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1363b588-147c-40ec-9adb-606fd1de14ba"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("13ccbf96-a960-4e89-8dfa-2e73786787e5"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1dc24ddf-688e-4348-8865-5b0fb162b1f2"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2dc1b26a-b3d1-4502-9e91-f4dac72b315c"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("33f9ca73-495b-41ff-8172-d3789ed2b21f"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("38808304-e2f0-4f4d-ba61-f267460a54b5"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3a48e5c9-f14d-4e75-a573-057781a4351e"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3a6beffe-9091-4e59-8d9a-316dc3a620fc"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3dc4e9b1-295f-4935-bff3-acb43eac08c2"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("462b86ce-cac3-45fe-8ca2-5856d3476a2d"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("493988db-ed98-4f46-ae52-caac232528dd"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4f588d34-e221-4f7f-8fc8-7469088898df"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4f98180f-7eac-4a67-a839-ed820812ff72"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("58fbca8f-2847-4092-8f99-29f9d1fdf6ea"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("59798b17-936b-4dbd-8066-d78a5461cb4a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("59c8c58b-3976-41a8-a62f-f0da3bb68476"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5dc0b63e-b43a-4103-8dcf-436fc8bd6fbf"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6a864eca-928c-4ded-ace7-3a1afae4fc67"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6cc94fbb-8aef-4992-bf5d-bba902e2c652"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8a471dcf-030c-44c8-92b2-ea2807f2e2ea"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("919affb3-8ad4-4368-818a-0e9b8a44bf3a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("91ba22ec-615a-4ed7-8e5a-3d06ed8c1741"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("96fcf234-de80-47f6-97af-a2344f9b488c"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9772d9a1-71a4-47f6-b996-01afe7a78f9c"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9ad9d859-1723-43c4-8420-c916563c8a46"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a84bcd4a-9243-430f-aace-a61fc9a6ae27"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b16620a2-e7c7-4c01-ad64-6818a77232ab"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b5d34a84-fe66-4ee1-a0f1-9066a583aa59"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bf9e5c73-8156-4707-9880-f9d767acd34e"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c95f0528-dd11-4734-bec3-78c2443bf90a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d172c07c-a47b-4e5a-bdde-89d65707f9d6"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d40223d8-d986-435b-b7cc-38c63b0f7aa1"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dd74a486-1ce4-4e03-a0db-670ba39bd01a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("eab186b3-0dd0-4738-8186-ade2f0682394"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ed9d30da-84ad-45e5-a44a-aee25f78cfb0"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("edd33d04-6eed-477a-b8f1-f370a326904e"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f5b3ae46-e35a-4645-8ea0-9d53f47ac2ea"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("fe4204ce-3965-48fa-8585-3629dadb6e42"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1131757d-20a9-4c70-83fe-5d60df8abd66"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3f102f40-36da-4db5-bfab-feaae59286d9"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5d12a7c4-cbad-4ec8-9076-89af5a98c723"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f108d1c5-e2d4-4f0e-ba6b-66aed1b67ed5"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f19f3bcb-0d51-4381-be96-9cd7d9e146fa"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("00c3583c-dce2-4179-9dfe-cf297bf9c061"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0672167c-5e9e-406d-b127-d42f3cc27259"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0f1b5c2b-5650-4fd6-b94d-f5e3edb9cf30"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("10a3325c-291e-4fa2-9abf-eec4659fc21f"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1b83b543-dadd-4fd5-ba76-f85c987e1905"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2f25c032-4b4f-4675-868f-cfac331094bd"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("322e964e-6d36-4c67-9ce4-ab52b1d794bd"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("39d91e45-f53a-4d4d-b95f-b907da6cac71"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4b1c46f3-6376-470b-a1f6-63f9dc88b383"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("675e724d-13d0-4b36-a9d0-9c33f5c30a27"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("750e1e6b-775b-4313-a4c3-b52a5c9d6272"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("78ebfbe6-377d-40a8-a230-fd6afc755794"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7ac4ae84-58e5-4007-ac2e-4c731993294c"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9abdc373-36cd-4165-b296-b394658673c6"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a797c91f-048e-495b-8aa7-327ddc2dffac"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b677558a-2471-495b-9f1a-75a483e085a6"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b701bc01-00d0-4118-a205-c25126bdf815"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bfc8ec35-a982-4e94-bb62-bccf1945e7f5"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c522300b-6d6a-4da5-8234-d280676c760e"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d7b38009-0cbe-4418-a35a-3914a7487889"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d9218188-a265-4c98-bbdf-34064b0eace3"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e5816483-6ef6-4d99-affb-741c1ddb838c"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e68cafef-9465-4dba-864d-d01edb83c4be"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("efa74c9f-9bdd-456d-999b-b1c1aae347f8"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f516873e-db33-46e0-89db-b8f557f31778"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f8548b14-3b62-4846-8c00-f1bc7c218b84"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ff2371b1-2e49-4a16-b9c8-99df8157d22d"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("03e53046-3e51-4594-90a8-7aa13b671ce8"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0875ac78-7e30-4d8b-ba6c-7291e7444e3c"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("102160b9-b241-474f-b242-5165b64a0b53"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("10b82217-98c9-439b-bb8b-fb2860a3750f"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("126b0b24-8b1c-4891-a733-0b148a229865"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1451eee6-6277-4c7f-a50f-8233e7c8d90c"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1721c6df-0579-44d2-b7d5-d59ab9bacc10"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("194004fe-000e-4cc4-a36a-94c624c53bee"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("20f0e330-fd30-403e-bfe0-49791651af2d"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("28e28901-5123-4580-ae44-a4bc77d910ef"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2d14e2c4-0d4b-4e46-9c57-f34145792c37"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3aae8616-54ef-4412-b6e3-82322662d9f3"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3c965409-88f4-4dc4-8e84-9ddc65ba660f"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3f6993b8-834f-4ebe-9ed5-cac5230ffdc5"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("45837246-7c82-4df8-9ec0-6b27da55c26a"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("48ac2b8b-353a-4c2c-bd8b-a04b497d45c3"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4f56a91c-85fe-40e3-8463-e8f4803cbb83"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4fbe27d5-5405-476d-9c85-be17c0a91e9f"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5a7f681f-f4d5-4d26-a685-0a5e14687796"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("61e98e85-16f0-4e78-bd7e-5a017d69ddcc"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6541f8ce-0a96-4ae1-86aa-d6bed2dfcbcd"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6827edbe-326a-46d3-bad9-07bb45502982"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6c9a106d-16a2-48e4-bc02-e105c7c81d8b"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7244e7da-cede-44c0-9429-e37502027afb"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7b422782-07e3-481f-82c1-97233b99aff3"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8009b37a-b737-4e6a-901f-795e238335b7"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("802b0009-031b-4698-b3e6-445f4760d735"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("815d4270-f83b-4d7b-814b-0234727bb7fe"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("83605658-d9c2-48dd-82d4-d1155ba33b67"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("836a2b57-13bd-4be6-8b47-5a4d97e0a85a"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("879bc651-3782-4239-bf94-48c36349fc27"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8a1c3ce1-060b-4971-8181-a33190545289"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9271d620-87d3-4374-a1f8-4e0d273b369c"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("92ae5e57-c75a-445f-a956-4ab52f8a63c9"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("98309bf5-ae43-4775-9b03-a6b96d4921c9"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9a235f66-562b-4da6-b8a7-61dd8e3d81cf"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9a8239e9-10e0-4872-b11f-a09cecd509c1"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a23e3ee5-1482-4fbf-9781-f8ff4be49468"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a9da6b7d-908e-49cc-9a6b-783676fb26c8"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("aa24474f-0f2a-4019-ad20-fed83a06435c"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b990b7a0-3661-4810-831e-869d2054fe08"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d96a2e21-51d8-4fff-8db6-f275c56c1861"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ddfad10b-974c-460a-ba0a-35ac53cf5206"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dfe2575a-4b62-41b7-b722-68575c0f48b3"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e06699a1-0334-42ce-9fd7-492508e5e11b"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e7157715-de78-4c0f-a427-b0e5bd799726"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f0a5e132-f498-4ad1-a761-d5309911d20f"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f6e1e7fe-cde1-466b-b8be-4637d16e836a"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("070733bf-996d-4a48-9842-8010eeaf8d4b"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("97fd23c4-9ca7-42c9-86ec-6da5f7f3f743"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2dff8793-fff9-481f-9620-a64d995a993d"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2e232be3-723e-4e0c-b006-4ea2461520b6"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4d0dd6f5-36f1-4b10-aabe-af6feb551cae"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6b9ffc2e-d153-440d-919d-72fe26b768d1"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("89923444-9dff-4ee7-a498-25b1319fb6a3"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("89d8a840-6e7c-4b4c-b823-dbb3cf1bdf93"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8d9a0a67-06d5-48a3-87d7-88fa34d9a5f8"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9134b318-baff-4bd9-9bf1-deb21cc2efcd"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a6eb7bbe-93d1-4817-9ff9-d648beaeca82"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ac04193f-021c-4683-a6d1-977c2e46b4a1"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b7d60477-13a1-4e01-8c4b-974c51ab4460"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bc48f96c-8419-4800-ae49-998855191926"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bd1e2600-5c4f-4f5c-a48d-75512f0b0f56"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dc95f70c-b467-4072-be66-875da9ac1549"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ea46cf2c-d785-4488-b833-ff8c046f74a4"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f161e5f8-2873-4c62-849c-50701e6743ea"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f5df6cdf-e899-425d-995e-6c0077592f5d"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("fdd9c3fb-e523-4ff8-9ab3-f4eb7ff50842"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a4c0c0bb-d9f4-4500-a170-62f66a625815"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6fe60e44-0ace-4d27-ae31-84998931d164"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4795d99a-a689-4225-96b5-a8720cb850a5"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0d6447c5-6257-4326-b541-b44b09512f88"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("15fb55f5-fa8f-417e-95a0-85f2fc65f6fc"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3a345cc1-d24f-4472-8571-43e22e06f02b"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4a7b1a47-c610-4526-b4a7-ab87ea28bb77"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4af04a4b-c5dc-44c3-a74a-023af34407a8"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("570f7ae0-08e8-4f04-a749-7de45e416569"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9fcb557d-30e5-4ca0-8b3c-e05a42732e75"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a227c998-85d8-4d13-a1c2-dc8972dabc13"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dd3068d7-546e-4940-b554-c36789d039c8"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e93ac787-2cdb-4c4b-946f-6cc606665f31"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0159fb7d-e894-4ba8-8469-dd0414f429db"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0d751061-a872-46a6-aa23-e5d7439bd058"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2cad3a5f-418d-4404-b140-cfc28ae495df"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4987e004-aaa1-4ab2-ab2e-cb824ffdce35"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5dd98c7d-e5b1-435d-a4ea-68cf37cd0014"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("76f2ef55-06f7-4e37-b70e-682d22b8e441"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("789636d9-c9ef-41d8-9545-2215b6547e0b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("83102d3a-27d0-49ef-99be-ce6fa143cfa3"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8e4bbee4-f1f5-4380-90f7-ebf413e2dd33"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8edf1831-29d1-4c3d-9986-ba33d44fc15e"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("946a29b7-e5bf-4f1f-b657-09758683326b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("abcc0307-a0aa-4d5c-8b9c-2f4e7e1956c2"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bd297f97-7a1d-4d83-9ddf-c4a9c969d15b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c250c0ed-1819-4062-932b-bc37755c2673"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cd04fb8a-3323-4c72-81a0-0e267329236f"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ce06f39e-b09b-4570-94c3-cd3ee8a3e6fa"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f9a282b3-88fb-4b5e-85ae-622ca67d99b4"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0c32db92-af97-4e7e-8b87-8f4c073c3521"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("56601d97-96da-48de-b694-96795fb6d46a"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("57092ec8-8acd-48d5-a12b-0ea90c91d1e5"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("583c3492-fb7f-4dcf-ae6d-9bdb0bbc8705"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("59a66ee3-aada-4865-8249-732ac1c6304c"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("72ab631d-97e7-490f-96ea-51db3c443d17"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("74063f86-96b8-4aee-85b2-9a3c4b6bc2a4"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("79c775ed-8a3b-43dc-9ff2-f13472fe24ac"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9eb85149-47ca-48d6-a4b4-dff9866bd2ba"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ae5990c4-aa65-4549-a181-4cbba34e3939"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bd54c8ca-6ce2-472f-a17f-62a4c895d832"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e48d37cd-e956-4e6f-aabc-920c79f88b03"));
        }
    }
}
