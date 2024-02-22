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
                    { new Guid("0d1e9c3f-f698-402a-8f2b-7c8b9700dfa0"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5576), "Description for Brand 15", "https://example.com/logo15.png", "Brand 15", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5576) },
                    { new Guid("36564e4f-2d48-4e8c-8d3f-e3264be9967a"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5507), "Description for Brand 4", "https://example.com/logo4.png", "Brand 4", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5507) },
                    { new Guid("42936d44-00eb-4080-bbca-e2dd906edd2c"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5502), "Description for Brand 2", "https://example.com/logo2.png", "Brand 2", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5503) },
                    { new Guid("4fb4e662-3ae0-4772-b623-a27e691f76d2"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5505), "Description for Brand 3", "https://example.com/logo3.png", "Brand 3", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5505) },
                    { new Guid("7d80ef25-291e-4e50-8ab2-fb2cff092e83"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5495), "Description for Brand 1", "https://example.com/logo1.png", "Brand 1", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5497) },
                    { new Guid("7ef31551-37d9-4322-b516-b3a8511dbb37"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5527), "Description for Brand 7", "https://example.com/logo7.png", "Brand 7", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5527) },
                    { new Guid("a7bfcc63-7876-4b45-b05a-82c93d22d102"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5529), "Description for Brand 8", "https://example.com/logo8.png", "Brand 8", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5530) },
                    { new Guid("c9774c07-e76e-4650-8879-f7f9e9147ece"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5567), "Description for Brand 13", "https://example.com/logo13.png", "Brand 13", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5567) },
                    { new Guid("ce44e0ba-a5e0-45d5-beb5-456206342f08"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5509), "Description for Brand 5", "https://example.com/logo5.png", "Brand 5", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5510) },
                    { new Guid("d61aa1fe-9a71-4c55-b491-a2ea4e495fe4"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5560), "Description for Brand 10", "https://example.com/logo10.png", "Brand 10", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5560) },
                    { new Guid("d895412d-aeb6-4abc-a176-3be19621dcb0"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5573), "Description for Brand 14", "https://example.com/logo14.png", "Brand 14", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5574) },
                    { new Guid("e82832e8-7bb5-47ba-add7-6204b8a4d9ae"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5524), "Description for Brand 6", "https://example.com/logo6.png", "Brand 6", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5524) },
                    { new Guid("ee34f3f9-5ab1-4901-95e6-528a8300fb99"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5562), "Description for Brand 11", "https://example.com/logo11.png", "Brand 11", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5563) },
                    { new Guid("f036342c-c3ae-476c-9569-ecb9362134be"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5565), "Description for Brand 12", "https://example.com/logo12.png", "Brand 12", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5565) },
                    { new Guid("f86ea7ce-adfd-4c58-88d1-3a13b6f3644a"), new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5531), "Description for Brand 9", "https://example.com/logo9.png", "Brand 9", new DateTime(2024, 2, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5532) }
                });

            migrationBuilder.InsertData(
                table: "ColorEntityModel",
                columns: new[] { "Id", "CreateDateTime", "HexCode", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("04bd6ddf-8177-4980-b0cd-6b023592ec95"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#0000FF", "Blue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2935e278-320b-4129-a6d6-5f9ac0ac8223"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#008080", "Teal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2942ed48-0c8f-4af6-aa76-449d31a0e114"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#800080", "Purple", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d6d521e-cd1a-478f-88f9-b1ad4042b404"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FFFF", "Cyan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d1a7aec-2d27-4710-9090-4cb952f32491"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFFFFF", "White", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b764621-1014-44d2-8599-ffe8bd31e598"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFFF00", "Yellow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b16f7cf-7e81-471a-bed8-72aa0ecf1b72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFC0CB", "Pink", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70c282a8-2060-4060-89f4-81b051edbed4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FF00", "Green", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77f4cea5-e1e8-45d1-b5fe-6db9dd7fdec1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FFA500", "Orange", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad4a640c-5418-42b5-b845-46a93f667746"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#A52A2A", "Brown", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc636f83-3a37-461c-bbd7-f10f590cdf71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#00FF00", "Lime", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c20935a4-9523-4c6c-81c7-82e54d067c9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FF00FF", "Magenta", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb575b31-3851-4271-a45f-070fa5725f4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#FF0000", "Red", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f21f3613-e393-401e-b858-f8c346d99767"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#000000", "Black", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f23b1943-bf0c-4d42-8392-c41c0a160302"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#808080", "Gray", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CurrencyEntityModel",
                columns: new[] { "Id", "Acronym", "CreateDateTime", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("0dd21b45-dda2-4e5e-b5e3-9879d4afd9fd"), "USD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b4a1c34-2990-4f34-87b3-195f948e8f7f"), "HKD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1febe713-7175-44e2-b136-d047011db8a5"), "GBP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b534f4c-7a7f-4ad4-b254-80bab831877c"), "MXN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4dbb8a25-fda9-416d-8185-6a7889476ba4"), "JPY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56c200a9-9621-47a9-a12a-c186d9d48da9"), "EUR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7706fa2a-6b63-4918-8a85-52e18f86ac0f"), "CNY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ca0f519-ea03-4114-b108-537791c80eea"), "SGD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8678354c-f462-42e1-a38b-c1a17895b633"), "NZD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("944069e0-6fff-46e9-bccd-7f2801140940"), "AUD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99f1db78-5e1f-4919-96a7-93ad2932c508"), "SEK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abb9d71b-70bf-431d-9377-82ebf3b4291d"), "CHF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c66eb2d2-ea35-46ec-a0d6-51343ef80338"), "NOK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca8acd35-9dcb-4e37-abbf-e533c32ef50c"), "ZAR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8a807a5-08a7-4d8e-bc17-5b0532ddd979"), "CAD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ModelEntityModel",
                columns: new[] { "Id", "BrandId", "CreateDateTime", "Description", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("04b66e59-f46b-4abe-8f42-7dff0b79ae5b"), new Guid("ce44e0ba-a5e0-45d5-beb5-456206342f08"), new DateTime(2023, 9, 13, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5875), "Description for Model3 for Brand 5", "Model3 for Brand 5", new DateTime(2024, 8, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5875) },
                    { new Guid("081509f2-2c10-4c48-9955-e3c917696685"), new Guid("7d80ef25-291e-4e50-8ab2-fb2cff092e83"), new DateTime(2023, 9, 26, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5803), "Description for Model3 for Brand 1", "Model3 for Brand 1", new DateTime(2024, 5, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5803) },
                    { new Guid("08ff3171-f473-431a-826e-3afd04b39a63"), new Guid("f86ea7ce-adfd-4c58-88d1-3a13b6f3644a"), new DateTime(2023, 11, 14, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5967), "Description for Model3 for Brand 9", "Model3 for Brand 9", new DateTime(2024, 7, 1, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5967) },
                    { new Guid("0e721561-83e9-4d62-a599-0e677d3ceb79"), new Guid("ee34f3f9-5ab1-4901-95e6-528a8300fb99"), new DateTime(2023, 10, 11, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5991), "Description for Model1 for Brand 11", "Model1 for Brand 11", new DateTime(2024, 3, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5991) },
                    { new Guid("0fc29ec3-680f-4c06-a370-9fae858c4c57"), new Guid("a7bfcc63-7876-4b45-b05a-82c93d22d102"), new DateTime(2023, 4, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5947), "Description for Model2 for Brand 8", "Model2 for Brand 8", new DateTime(2024, 4, 14, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5947) },
                    { new Guid("13c925f8-746f-40f5-9792-c775c2d07ca9"), new Guid("42936d44-00eb-4080-bbca-e2dd906edd2c"), new DateTime(2024, 1, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5814), "Description for Model2 for Brand 2", "Model2 for Brand 2", new DateTime(2024, 6, 18, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5814) },
                    { new Guid("16aeeeda-d7b9-400c-bba0-d02bb07ee2b5"), new Guid("7d80ef25-291e-4e50-8ab2-fb2cff092e83"), new DateTime(2023, 9, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5797), "Description for Model2 for Brand 1", "Model2 for Brand 1", new DateTime(2024, 1, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5797) },
                    { new Guid("26ac32e2-5391-49a1-980e-2f4fd88e74f4"), new Guid("0d1e9c3f-f698-402a-8f2b-7c8b9700dfa0"), new DateTime(2023, 8, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6062), "Description for Model2 for Brand 15", "Model2 for Brand 15", new DateTime(2023, 9, 10, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6062) },
                    { new Guid("2a2376a2-1803-44dd-9ee8-66dff912dd18"), new Guid("ce44e0ba-a5e0-45d5-beb5-456206342f08"), new DateTime(2024, 1, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5862), "Description for Model1 for Brand 5", "Model1 for Brand 5", new DateTime(2024, 4, 10, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5862) },
                    { new Guid("350d13fb-cb02-47e2-9206-a371cb7096bf"), new Guid("f036342c-c3ae-476c-9569-ecb9362134be"), new DateTime(2023, 8, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6008), "Description for Model1 for Brand 12", "Model1 for Brand 12", new DateTime(2024, 5, 4, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6008) },
                    { new Guid("3b7656ad-86d5-4bd0-8304-c45aca23b88a"), new Guid("f036342c-c3ae-476c-9569-ecb9362134be"), new DateTime(2023, 12, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6019), "Description for Model3 for Brand 12", "Model3 for Brand 12", new DateTime(2024, 10, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6019) },
                    { new Guid("513faa11-669f-431a-b7c4-82a42e456a80"), new Guid("ce44e0ba-a5e0-45d5-beb5-456206342f08"), new DateTime(2023, 9, 30, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5870), "Description for Model2 for Brand 5", "Model2 for Brand 5", new DateTime(2024, 7, 14, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5870) },
                    { new Guid("583f5d78-dc6d-4897-8ac3-789a9eeda8e0"), new Guid("7ef31551-37d9-4322-b516-b3a8511dbb37"), new DateTime(2023, 9, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5898), "Description for Model1 for Brand 7", "Model1 for Brand 7", new DateTime(2023, 9, 29, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5898) },
                    { new Guid("58a6528a-bb64-498c-a358-8c829f565750"), new Guid("ee34f3f9-5ab1-4901-95e6-528a8300fb99"), new DateTime(2023, 8, 31, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6001), "Description for Model3 for Brand 11", "Model3 for Brand 11", new DateTime(2024, 3, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6001) },
                    { new Guid("58b7afad-70b0-4a44-86eb-67e32ab7fd30"), new Guid("f86ea7ce-adfd-4c58-88d1-3a13b6f3644a"), new DateTime(2024, 1, 18, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5962), "Description for Model2 for Brand 9", "Model2 for Brand 9", new DateTime(2024, 11, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5962) },
                    { new Guid("5a79c4d4-122f-4a51-8f6a-509ec74f2ada"), new Guid("7d80ef25-291e-4e50-8ab2-fb2cff092e83"), new DateTime(2023, 10, 4, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5779), "Description for Model1 for Brand 1", "Model1 for Brand 1", new DateTime(2023, 10, 12, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5779) },
                    { new Guid("61943f0b-13bc-4de3-9136-d3d7b95f549e"), new Guid("d895412d-aeb6-4abc-a176-3be19621dcb0"), new DateTime(2023, 4, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6046), "Description for Model2 for Brand 14", "Model2 for Brand 14", new DateTime(2023, 7, 6, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6046) },
                    { new Guid("63e3c7a9-f8f2-4fa9-ac41-42b7392269ee"), new Guid("e82832e8-7bb5-47ba-add7-6204b8a4d9ae"), new DateTime(2023, 11, 30, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5881), "Description for Model1 for Brand 6", "Model1 for Brand 6", new DateTime(2024, 8, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5881) },
                    { new Guid("69be4d60-e69d-4b0c-8a9b-5eeb273ad30b"), new Guid("36564e4f-2d48-4e8c-8d3f-e3264be9967a"), new DateTime(2023, 7, 19, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5851), "Description for Model2 for Brand 4", "Model2 for Brand 4", new DateTime(2024, 7, 6, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5851) },
                    { new Guid("6d6d56a8-64c2-40ab-9119-2e2fd079cf3a"), new Guid("4fb4e662-3ae0-4772-b623-a27e691f76d2"), new DateTime(2023, 6, 26, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5829), "Description for Model1 for Brand 3", "Model1 for Brand 3", new DateTime(2024, 5, 30, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5829) },
                    { new Guid("7e669f22-20bb-4713-be1c-0fda19da0c4d"), new Guid("36564e4f-2d48-4e8c-8d3f-e3264be9967a"), new DateTime(2023, 5, 7, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5856), "Description for Model3 for Brand 4", "Model3 for Brand 4", new DateTime(2024, 4, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("81d617c1-2e85-4063-969c-66fe33f8c03b"), new Guid("0d1e9c3f-f698-402a-8f2b-7c8b9700dfa0"), new DateTime(2023, 12, 5, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6067), "Description for Model3 for Brand 15", "Model3 for Brand 15", new DateTime(2024, 10, 14, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6067) },
                    { new Guid("916b86cb-a11c-4fdd-9eec-8457bef721c9"), new Guid("ee34f3f9-5ab1-4901-95e6-528a8300fb99"), new DateTime(2023, 12, 13, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5996), "Description for Model2 for Brand 11", "Model2 for Brand 11", new DateTime(2024, 4, 4, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5996) },
                    { new Guid("92bd39ed-e580-4708-8f69-9a29e4c772c6"), new Guid("a7bfcc63-7876-4b45-b05a-82c93d22d102"), new DateTime(2023, 9, 20, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5916), "Description for Model1 for Brand 8", "Model1 for Brand 8", new DateTime(2023, 10, 20, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5916) },
                    { new Guid("9831e218-848b-4348-926e-e5c751fc82f8"), new Guid("e82832e8-7bb5-47ba-add7-6204b8a4d9ae"), new DateTime(2023, 6, 17, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5886), "Description for Model2 for Brand 6", "Model2 for Brand 6", new DateTime(2023, 6, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5886) },
                    { new Guid("9aaed91e-60d8-41ce-83d2-58168a4bae55"), new Guid("c9774c07-e76e-4650-8879-f7f9e9147ece"), new DateTime(2023, 3, 23, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6024), "Description for Model1 for Brand 13", "Model1 for Brand 13", new DateTime(2023, 5, 12, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6024) },
                    { new Guid("9b3f7513-2ca0-4217-bfcc-7ea923417062"), new Guid("4fb4e662-3ae0-4772-b623-a27e691f76d2"), new DateTime(2023, 10, 22, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5840), "Description for Model3 for Brand 3", "Model3 for Brand 3", new DateTime(2024, 1, 14, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5840) },
                    { new Guid("9c07f1e4-7639-4701-ac5c-3e6e2d628fab"), new Guid("36564e4f-2d48-4e8c-8d3f-e3264be9967a"), new DateTime(2023, 10, 23, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5846), "Description for Model1 for Brand 4", "Model1 for Brand 4", new DateTime(2024, 3, 25, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5846) },
                    { new Guid("a1eee8bd-7a94-42e6-92ab-5d2cfc9c530f"), new Guid("0d1e9c3f-f698-402a-8f2b-7c8b9700dfa0"), new DateTime(2024, 2, 20, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6057), "Description for Model1 for Brand 15", "Model1 for Brand 15", new DateTime(2024, 7, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6057) },
                    { new Guid("a3d334d0-57b9-4f14-8d34-055fa9de431a"), new Guid("4fb4e662-3ae0-4772-b623-a27e691f76d2"), new DateTime(2024, 1, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5834), "Description for Model2 for Brand 3", "Model2 for Brand 3", new DateTime(2024, 2, 17, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5834) },
                    { new Guid("a6655ca8-d63b-4c14-96e6-510ceb8415eb"), new Guid("a7bfcc63-7876-4b45-b05a-82c93d22d102"), new DateTime(2023, 5, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5951), "Description for Model3 for Brand 8", "Model3 for Brand 8", new DateTime(2024, 3, 7, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5951) },
                    { new Guid("aba8fdb7-fb08-41a9-90bf-fad403284ab3"), new Guid("f86ea7ce-adfd-4c58-88d1-3a13b6f3644a"), new DateTime(2024, 2, 12, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5957), "Description for Model1 for Brand 9", "Model1 for Brand 9", new DateTime(2024, 8, 8, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5957) },
                    { new Guid("ac0178b3-ded8-49c6-b05f-06ecd3f41a92"), new Guid("42936d44-00eb-4080-bbca-e2dd906edd2c"), new DateTime(2023, 3, 22, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5823), "Description for Model3 for Brand 2", "Model3 for Brand 2", new DateTime(2023, 11, 20, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5823) },
                    { new Guid("b80adf5c-abd0-468f-b634-bdab670b1891"), new Guid("7ef31551-37d9-4322-b516-b3a8511dbb37"), new DateTime(2023, 9, 24, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5908), "Description for Model3 for Brand 7", "Model3 for Brand 7", new DateTime(2024, 8, 25, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5908) },
                    { new Guid("bd0413c7-860f-4db8-aa81-ddedcfc4c78b"), new Guid("d61aa1fe-9a71-4c55-b491-a2ea4e495fe4"), new DateTime(2023, 4, 23, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5985), "Description for Model3 for Brand 10", "Model3 for Brand 10", new DateTime(2024, 2, 18, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5985) },
                    { new Guid("bf9692b4-ae5b-48ff-96af-d6d75e09027d"), new Guid("d61aa1fe-9a71-4c55-b491-a2ea4e495fe4"), new DateTime(2023, 12, 8, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5977), "Description for Model2 for Brand 10", "Model2 for Brand 10", new DateTime(2024, 3, 18, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5977) },
                    { new Guid("caeca087-776c-4583-bc86-40f954587a0a"), new Guid("f036342c-c3ae-476c-9569-ecb9362134be"), new DateTime(2023, 9, 25, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6013), "Description for Model2 for Brand 12", "Model2 for Brand 12", new DateTime(2024, 9, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6013) },
                    { new Guid("ccebd1db-9d7c-4ed2-91ae-c5b92445de67"), new Guid("d895412d-aeb6-4abc-a176-3be19621dcb0"), new DateTime(2023, 7, 11, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6041), "Description for Model1 for Brand 14", "Model1 for Brand 14", new DateTime(2023, 9, 26, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6041) },
                    { new Guid("de77f2e9-a3cc-4d76-819b-cbac59249ff7"), new Guid("e82832e8-7bb5-47ba-add7-6204b8a4d9ae"), new DateTime(2024, 1, 26, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5892), "Description for Model3 for Brand 6", "Model3 for Brand 6", new DateTime(2024, 9, 20, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5892) },
                    { new Guid("df50b72b-f028-4941-9f85-750a953e3e4c"), new Guid("d895412d-aeb6-4abc-a176-3be19621dcb0"), new DateTime(2024, 1, 17, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6051), "Description for Model3 for Brand 14", "Model3 for Brand 14", new DateTime(2024, 8, 12, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6051) },
                    { new Guid("e3db63fe-be43-4e73-b05c-e47e5e244363"), new Guid("c9774c07-e76e-4650-8879-f7f9e9147ece"), new DateTime(2023, 4, 10, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6031), "Description for Model2 for Brand 13", "Model2 for Brand 13", new DateTime(2023, 5, 23, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6031) },
                    { new Guid("eac2b298-abf0-4c67-87be-470e579b1477"), new Guid("42936d44-00eb-4080-bbca-e2dd906edd2c"), new DateTime(2024, 1, 23, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5808), "Description for Model1 for Brand 2", "Model1 for Brand 2", new DateTime(2024, 4, 15, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5808) },
                    { new Guid("f486d3af-6e9f-4d1d-99e1-3d42758bfc95"), new Guid("c9774c07-e76e-4650-8879-f7f9e9147ece"), new DateTime(2023, 11, 18, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6036), "Description for Model3 for Brand 13", "Model3 for Brand 13", new DateTime(2024, 8, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6036) },
                    { new Guid("f7c8b522-34c0-44c5-9bf2-1571522e59ae"), new Guid("d61aa1fe-9a71-4c55-b491-a2ea4e495fe4"), new DateTime(2023, 8, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5972), "Description for Model1 for Brand 10", "Model1 for Brand 10", new DateTime(2023, 9, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5972) },
                    { new Guid("fb0f0bd5-1d56-43f8-aa44-87db5d7b650c"), new Guid("7ef31551-37d9-4322-b516-b3a8511dbb37"), new DateTime(2023, 8, 7, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5903), "Description for Model2 for Brand 7", "Model2 for Brand 7", new DateTime(2023, 8, 19, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(5903) }
                });

            migrationBuilder.InsertData(
                table: "CarEntityModel",
                columns: new[] { "Id", "ColorId", "CreateDateTime", "Description", "EngineVolume", "ModelId", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("06de5dbb-7f31-4abc-97b9-cc2b7afebfbc"), new Guid("f21f3613-e393-401e-b858-f8c346d99767"), new DateTime(2023, 3, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6254), "Description for car 20", 2161.0, new Guid("61943f0b-13bc-4de3-9136-d3d7b95f549e"), new DateTime(2023, 3, 16, 20, 46, 27, 463, DateTimeKind.Utc).AddTicks(6254) },
                    { new Guid("0f7330f5-6b73-465d-bdbe-ed13cbc5d943"), new Guid("2942ed48-0c8f-4af6-aa76-449d31a0e114"), new DateTime(2023, 3, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6225), "Description for car 10", 1576.0, new Guid("ac0178b3-ded8-49c6-b05f-06ecd3f41a92"), new DateTime(2023, 3, 16, 22, 46, 27, 463, DateTimeKind.Utc).AddTicks(6225) },
                    { new Guid("25767b88-13a8-4a69-8b73-3739d119ad22"), new Guid("4d1a7aec-2d27-4710-9090-4cb952f32491"), new DateTime(2023, 4, 17, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6214), "Description for car 7", 2301.0, new Guid("e3db63fe-be43-4e73-b05c-e47e5e244363"), new DateTime(2023, 4, 18, 6, 46, 27, 463, DateTimeKind.Utc).AddTicks(6214) },
                    { new Guid("2c3f91ce-41bd-4e94-b67a-71940ad862bc"), new Guid("f21f3613-e393-401e-b858-f8c346d99767"), new DateTime(2024, 1, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6245), "Description for car 17", 2011.0, new Guid("61943f0b-13bc-4de3-9136-d3d7b95f549e"), new DateTime(2024, 1, 21, 21, 46, 27, 463, DateTimeKind.Utc).AddTicks(6245) },
                    { new Guid("43a89939-73c1-40fd-a785-ce51f3783558"), new Guid("70c282a8-2060-4060-89f4-81b051edbed4"), new DateTime(2023, 8, 13, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6219), "Description for car 8", 2622.0, new Guid("513faa11-669f-431a-b7c4-82a42e456a80"), new DateTime(2023, 8, 14, 9, 46, 27, 463, DateTimeKind.Utc).AddTicks(6219) },
                    { new Guid("45b691a5-fd39-45a3-849d-e98d5e090d24"), new Guid("77f4cea5-e1e8-45d1-b5fe-6db9dd7fdec1"), new DateTime(2024, 2, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6194), "Description for car 1", 4699.0, new Guid("63e3c7a9-f8f2-4fa9-ac41-42b7392269ee"), new DateTime(2024, 2, 10, 9, 46, 27, 463, DateTimeKind.Utc).AddTicks(6194) },
                    { new Guid("5bfa8265-1732-4059-867e-4f84a5bdc16e"), new Guid("f21f3613-e393-401e-b858-f8c346d99767"), new DateTime(2023, 4, 23, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6249), "Description for car 18", 2044.0, new Guid("9831e218-848b-4348-926e-e5c751fc82f8"), new DateTime(2023, 4, 23, 18, 46, 27, 463, DateTimeKind.Utc).AddTicks(6249) },
                    { new Guid("61fe6fa3-f8b4-482a-87f3-4d8791c36f08"), new Guid("f21f3613-e393-401e-b858-f8c346d99767"), new DateTime(2023, 8, 7, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6211), "Description for car 6", 4188.0, new Guid("2a2376a2-1803-44dd-9ee8-66dff912dd18"), new DateTime(2023, 8, 8, 8, 46, 27, 463, DateTimeKind.Utc).AddTicks(6211) },
                    { new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), new Guid("4d1a7aec-2d27-4710-9090-4cb952f32491"), new DateTime(2023, 3, 1, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6202), "Description for car 3", 1305.0, new Guid("61943f0b-13bc-4de3-9136-d3d7b95f549e"), new DateTime(2023, 3, 2, 7, 46, 27, 463, DateTimeKind.Utc).AddTicks(6202) },
                    { new Guid("7a1804b9-55fd-48b4-a22b-edb2387c7401"), new Guid("eb575b31-3851-4271-a45f-070fa5725f4f"), new DateTime(2023, 11, 23, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6228), "Description for car 11", 2705.0, new Guid("513faa11-669f-431a-b7c4-82a42e456a80"), new DateTime(2023, 11, 23, 23, 46, 27, 463, DateTimeKind.Utc).AddTicks(6228) },
                    { new Guid("8a73f030-78a6-490b-a83e-791256eaaf7c"), new Guid("f23b1943-bf0c-4d42-8392-c41c0a160302"), new DateTime(2023, 4, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6233), "Description for car 13", 1406.0, new Guid("3b7656ad-86d5-4bd0-8304-c45aca23b88a"), new DateTime(2023, 4, 22, 12, 46, 27, 463, DateTimeKind.Utc).AddTicks(6233) },
                    { new Guid("a5e5d6a6-65b8-466d-9b7b-9a9d6d0636a1"), new Guid("4d1a7aec-2d27-4710-9090-4cb952f32491"), new DateTime(2023, 10, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6200), "Description for car 2", 3821.0, new Guid("f486d3af-6e9f-4d1d-99e1-3d42758bfc95"), new DateTime(2023, 10, 29, 13, 46, 27, 463, DateTimeKind.Utc).AddTicks(6200) },
                    { new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"), new Guid("04bd6ddf-8177-4980-b0cd-6b023592ec95"), new DateTime(2023, 12, 8, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6238), "Description for car 15", 2022.0, new Guid("26ac32e2-5391-49a1-980e-2f4fd88e74f4"), new DateTime(2023, 12, 8, 17, 46, 27, 463, DateTimeKind.Utc).AddTicks(6238) },
                    { new Guid("cf62063a-6924-4a6e-991b-5ff44ecc72f6"), new Guid("c20935a4-9523-4c6c-81c7-82e54d067c9f"), new DateTime(2023, 4, 21, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6208), "Description for car 5", 1254.0, new Guid("bf9692b4-ae5b-48ff-96af-d6d75e09027d"), new DateTime(2023, 4, 21, 23, 46, 27, 463, DateTimeKind.Utc).AddTicks(6208) },
                    { new Guid("cf65798b-bc3a-4a0d-a662-d426463e640f"), new Guid("5b764621-1014-44d2-8599-ffe8bd31e598"), new DateTime(2023, 12, 19, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6243), "Description for car 16", 2322.0, new Guid("de77f2e9-a3cc-4d76-819b-cbac59249ff7"), new DateTime(2023, 12, 19, 18, 46, 27, 463, DateTimeKind.Utc).AddTicks(6243) },
                    { new Guid("e518b3a3-775a-475b-849c-6c79e7205f88"), new Guid("bc636f83-3a37-461c-bbd7-f10f590cdf71"), new DateTime(2023, 7, 5, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6222), "Description for car 9", 4196.0, new Guid("58a6528a-bb64-498c-a358-8c829f565750"), new DateTime(2023, 7, 6, 1, 46, 27, 463, DateTimeKind.Utc).AddTicks(6222) },
                    { new Guid("e5b28c78-98aa-4ade-b6d9-782d200801a9"), new Guid("2935e278-320b-4129-a6d6-5f9ac0ac8223"), new DateTime(2023, 6, 15, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6231), "Description for car 12", 3381.0, new Guid("513faa11-669f-431a-b7c4-82a42e456a80"), new DateTime(2023, 6, 16, 11, 46, 27, 463, DateTimeKind.Utc).AddTicks(6231) },
                    { new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"), new Guid("2d6d521e-cd1a-478f-88f9-b1ad4042b404"), new DateTime(2023, 11, 20, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6251), "Description for car 19", 1643.0, new Guid("63e3c7a9-f8f2-4fa9-ac41-42b7392269ee"), new DateTime(2023, 11, 21, 12, 46, 27, 463, DateTimeKind.Utc).AddTicks(6251) },
                    { new Guid("f48372bb-a3ca-4ad9-9dd3-36c659d72259"), new Guid("6b16f7cf-7e81-471a-bed8-72aa0ecf1b72"), new DateTime(2024, 1, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6205), "Description for car 4", 4743.0, new Guid("bd0413c7-860f-4db8-aa81-ddedcfc4c78b"), new DateTime(2024, 1, 28, 20, 46, 27, 463, DateTimeKind.Utc).AddTicks(6205) },
                    { new Guid("f585afaf-075f-4eb7-9bef-0c597db59e2e"), new Guid("77f4cea5-e1e8-45d1-b5fe-6db9dd7fdec1"), new DateTime(2023, 8, 14, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6236), "Description for car 14", 3819.0, new Guid("9b3f7513-2ca0-4217-bfcc-7ea923417062"), new DateTime(2023, 8, 14, 18, 46, 27, 463, DateTimeKind.Utc).AddTicks(6236) }
                });

            migrationBuilder.InsertData(
                table: "CarPhotoEntityModel",
                columns: new[] { "Id", "CarId", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("0b475705-d8b1-4d77-b972-9d973f117212"), new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"), "https://example.com/photo3.jpg" },
                    { new Guid("0b79bdbd-2cf4-4e96-87ed-f8a103fc6a36"), new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), "https://example.com/photo2.jpg" },
                    { new Guid("1452e8a8-1248-4fa7-b0ea-feaef2b534c5"), new Guid("a5e5d6a6-65b8-466d-9b7b-9a9d6d0636a1"), "https://example.com/photo2.jpg" },
                    { new Guid("1e740d8b-7642-4a8f-8268-424c3acdc710"), new Guid("7a1804b9-55fd-48b4-a22b-edb2387c7401"), "https://example.com/photo2.jpg" },
                    { new Guid("209fa7d0-328c-47da-9f57-fffa6dce2aa8"), new Guid("5bfa8265-1732-4059-867e-4f84a5bdc16e"), "https://example.com/photo2.jpg" },
                    { new Guid("316a1948-0de3-4d82-af30-1a09196f8cbd"), new Guid("2c3f91ce-41bd-4e94-b67a-71940ad862bc"), "https://example.com/photo2.jpg" },
                    { new Guid("33163363-c92d-4e8f-acc7-93f136ed1a03"), new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"), "https://example.com/photo2.jpg" },
                    { new Guid("3f8f0219-2be6-41f0-85bc-f0f260566ba5"), new Guid("e5b28c78-98aa-4ade-b6d9-782d200801a9"), "https://example.com/photo2.jpg" },
                    { new Guid("44226734-802b-4e5c-b9c4-2680f8a98f64"), new Guid("06de5dbb-7f31-4abc-97b9-cc2b7afebfbc"), "https://example.com/photo3.jpg" },
                    { new Guid("515e6e5c-b42b-4491-bdf3-e11a4268e6b0"), new Guid("a5e5d6a6-65b8-466d-9b7b-9a9d6d0636a1"), "https://example.com/photo3.jpg" },
                    { new Guid("55a88ce2-2553-4daa-994d-c04fffffe9b0"), new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"), "https://example.com/photo1.jpg" },
                    { new Guid("5fee163c-6bd3-4c2a-ba3b-8d832a93d65f"), new Guid("e518b3a3-775a-475b-849c-6c79e7205f88"), "https://example.com/photo1.jpg" },
                    { new Guid("6d3547d9-fb04-4b39-8854-c83727249a6e"), new Guid("61fe6fa3-f8b4-482a-87f3-4d8791c36f08"), "https://example.com/photo2.jpg" },
                    { new Guid("75375a91-f41a-4ab9-8780-46f5ccb8325f"), new Guid("61fe6fa3-f8b4-482a-87f3-4d8791c36f08"), "https://example.com/photo1.jpg" },
                    { new Guid("8077e3ce-f5ce-4ab3-a497-9e0f62060bc2"), new Guid("f585afaf-075f-4eb7-9bef-0c597db59e2e"), "https://example.com/photo1.jpg" },
                    { new Guid("8376907c-2f6f-4777-88b2-12c27c932be6"), new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"), "https://example.com/photo1.jpg" },
                    { new Guid("884e6b30-29b8-400c-b974-16c5edaf3054"), new Guid("06de5dbb-7f31-4abc-97b9-cc2b7afebfbc"), "https://example.com/photo1.jpg" },
                    { new Guid("9cf42c02-bd3e-4b4c-bce4-81a850e205b5"), new Guid("61fe6fa3-f8b4-482a-87f3-4d8791c36f08"), "https://example.com/photo3.jpg" },
                    { new Guid("9f2d2af3-478a-4d46-a1b2-4d314df3dc54"), new Guid("2c3f91ce-41bd-4e94-b67a-71940ad862bc"), "https://example.com/photo1.jpg" },
                    { new Guid("a294a63a-e718-4cc2-8481-b9470a799289"), new Guid("cf62063a-6924-4a6e-991b-5ff44ecc72f6"), "https://example.com/photo2.jpg" },
                    { new Guid("ac3ac016-4c2e-4a03-bf1c-e791f134f6f8"), new Guid("f48372bb-a3ca-4ad9-9dd3-36c659d72259"), "https://example.com/photo3.jpg" },
                    { new Guid("ad1e7c35-8127-440b-b1a5-d3334b3c7839"), new Guid("06de5dbb-7f31-4abc-97b9-cc2b7afebfbc"), "https://example.com/photo2.jpg" },
                    { new Guid("b639a317-02ed-408c-a62b-a7d09a882a28"), new Guid("7a1804b9-55fd-48b4-a22b-edb2387c7401"), "https://example.com/photo1.jpg" },
                    { new Guid("b823ae53-ac1d-4eef-b40b-9af71fdb89cd"), new Guid("f585afaf-075f-4eb7-9bef-0c597db59e2e"), "https://example.com/photo2.jpg" },
                    { new Guid("bae0ac35-2edb-464e-9f09-76060cab5111"), new Guid("5bfa8265-1732-4059-867e-4f84a5bdc16e"), "https://example.com/photo1.jpg" },
                    { new Guid("c0de2ba1-1fad-4772-9778-1a9825d82086"), new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"), "https://example.com/photo3.jpg" },
                    { new Guid("c8e17abb-1438-4277-8f14-6e45c08bf002"), new Guid("5bfa8265-1732-4059-867e-4f84a5bdc16e"), "https://example.com/photo3.jpg" },
                    { new Guid("cb4fdf88-e83c-4e65-9d68-78ad7d7912ea"), new Guid("cf62063a-6924-4a6e-991b-5ff44ecc72f6"), "https://example.com/photo1.jpg" },
                    { new Guid("cd91dd1a-2e1b-42f5-97e5-68c9a002da68"), new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), "https://example.com/photo3.jpg" },
                    { new Guid("d05b61f6-00d0-4f06-8b07-c907dc34d094"), new Guid("a5e5d6a6-65b8-466d-9b7b-9a9d6d0636a1"), "https://example.com/photo1.jpg" },
                    { new Guid("d07c4fab-796b-41b6-b198-fc32b129299d"), new Guid("f48372bb-a3ca-4ad9-9dd3-36c659d72259"), "https://example.com/photo1.jpg" },
                    { new Guid("d7c4a991-559a-42f1-a36c-37d3f2a99e79"), new Guid("f585afaf-075f-4eb7-9bef-0c597db59e2e"), "https://example.com/photo3.jpg" },
                    { new Guid("dbeeaf7a-11df-4bab-ba16-0be2044c731a"), new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), "https://example.com/photo1.jpg" },
                    { new Guid("e25f70ec-ea5b-4ecf-abd2-a2cae77b0195"), new Guid("f48372bb-a3ca-4ad9-9dd3-36c659d72259"), "https://example.com/photo2.jpg" },
                    { new Guid("e99a254a-c9b4-4fdc-95b9-940e4c462f7a"), new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"), "https://example.com/photo2.jpg" },
                    { new Guid("f1d1db7a-b980-4d79-ad6c-68e0d6f732ce"), new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), "https://example.com/photo4.jpg" },
                    { new Guid("f2ef4d23-c5d3-4311-9330-cd09866ae79d"), new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"), "https://example.com/photo4.jpg" },
                    { new Guid("f5c75eb2-609c-45b7-b1b4-81f10a7ac576"), new Guid("e5b28c78-98aa-4ade-b6d9-782d200801a9"), "https://example.com/photo1.jpg" },
                    { new Guid("fd00e590-8186-47aa-b952-76a6e7c4a26b"), new Guid("f585afaf-075f-4eb7-9bef-0c597db59e2e"), "https://example.com/photo4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PriceHistoryEntityModel",
                columns: new[] { "Id", "CarId", "CreateDateTime", "CurrencyId", "Price", "StartDate", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("39654a26-3e81-4489-9a42-f648b2d5288a"), new Guid("e518b3a3-775a-475b-849c-6c79e7205f88"), new DateTime(2024, 2, 7, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6601), new Guid("0dd21b45-dda2-4e5e-b5e3-9879d4afd9fd"), 906.0, new DateTime(2023, 6, 26, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6600), new DateTime(2024, 2, 7, 17, 46, 27, 463, DateTimeKind.Utc).AddTicks(6601) },
                    { new Guid("4139b093-b431-4a74-9639-d6c8eb5c83ee"), new Guid("8a73f030-78a6-490b-a83e-791256eaaf7c"), new DateTime(2024, 1, 24, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6605), new Guid("56c200a9-9621-47a9-a12a-c186d9d48da9"), 734.0, new DateTime(2023, 12, 14, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6604), new DateTime(2024, 1, 25, 4, 46, 27, 463, DateTimeKind.Utc).AddTicks(6605) },
                    { new Guid("5b20517a-caba-4f01-9db6-8eebf5bb75c3"), new Guid("cf65798b-bc3a-4a0d-a662-d426463e640f"), new DateTime(2024, 2, 4, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6625), new Guid("c66eb2d2-ea35-46ec-a0d6-51343ef80338"), 815.0, new DateTime(2023, 12, 15, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6625), new DateTime(2024, 2, 5, 13, 46, 27, 463, DateTimeKind.Utc).AddTicks(6625) },
                    { new Guid("5c1a672d-3678-4eb7-8fca-c0b07377e57d"), new Guid("cf62063a-6924-4a6e-991b-5ff44ecc72f6"), new DateTime(2024, 1, 26, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6592), new Guid("7706fa2a-6b63-4918-8a85-52e18f86ac0f"), 544.0, new DateTime(2023, 4, 4, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6592), new DateTime(2024, 1, 27, 14, 46, 27, 463, DateTimeKind.Utc).AddTicks(6592) },
                    { new Guid("5f66560b-c540-4d54-9a2c-4faac963be58"), new Guid("06de5dbb-7f31-4abc-97b9-cc2b7afebfbc"), new DateTime(2024, 2, 7, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6648), new Guid("0dd21b45-dda2-4e5e-b5e3-9879d4afd9fd"), 371.0, new DateTime(2023, 10, 15, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6648), new DateTime(2024, 2, 8, 8, 46, 27, 463, DateTimeKind.Utc).AddTicks(6648) },
                    { new Guid("71b96461-2d74-4d65-a34d-b68f59a583fa"), new Guid("cf65798b-bc3a-4a0d-a662-d426463e640f"), new DateTime(2024, 1, 28, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6623), new Guid("4dbb8a25-fda9-416d-8185-6a7889476ba4"), 395.0, new DateTime(2024, 1, 5, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6622), new DateTime(2024, 1, 28, 21, 46, 27, 463, DateTimeKind.Utc).AddTicks(6623) },
                    { new Guid("741f3c14-3242-43ea-8bbc-b3091f0b4e87"), new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"), new DateTime(2024, 1, 31, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6646), new Guid("944069e0-6fff-46e9-bccd-7f2801140940"), 86.0, new DateTime(2023, 7, 8, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6645), new DateTime(2024, 1, 31, 17, 46, 27, 463, DateTimeKind.Utc).AddTicks(6646) },
                    { new Guid("7c6dbf18-35f7-432c-91b5-fd83f4b3cdae"), new Guid("cf62063a-6924-4a6e-991b-5ff44ecc72f6"), new DateTime(2024, 2, 5, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6582), new Guid("7706fa2a-6b63-4918-8a85-52e18f86ac0f"), 905.0, new DateTime(2023, 11, 20, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6581), new DateTime(2024, 2, 6, 15, 46, 27, 463, DateTimeKind.Utc).AddTicks(6582) },
                    { new Guid("7e213e99-b857-4d79-9d05-26e41929a512"), new Guid("cf62063a-6924-4a6e-991b-5ff44ecc72f6"), new DateTime(2024, 2, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6587), new Guid("c66eb2d2-ea35-46ec-a0d6-51343ef80338"), 864.0, new DateTime(2023, 10, 24, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6587), new DateTime(2024, 2, 17, 8, 46, 27, 463, DateTimeKind.Utc).AddTicks(6587) },
                    { new Guid("8710b435-d46f-4eec-b88c-bfda22582a15"), new Guid("cf62063a-6924-4a6e-991b-5ff44ecc72f6"), new DateTime(2024, 1, 30, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6590), new Guid("2b534f4c-7a7f-4ad4-b254-80bab831877c"), 542.0, new DateTime(2023, 4, 18, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6590), new DateTime(2024, 1, 31, 13, 46, 27, 463, DateTimeKind.Utc).AddTicks(6590) },
                    { new Guid("8ca36e16-406d-4561-a46f-03005deddc55"), new Guid("25767b88-13a8-4a69-8b73-3739d119ad22"), new DateTime(2024, 2, 15, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6598), new Guid("0dd21b45-dda2-4e5e-b5e3-9879d4afd9fd"), 801.0, new DateTime(2023, 11, 8, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6597), new DateTime(2024, 2, 16, 11, 46, 27, 463, DateTimeKind.Utc).AddTicks(6598) },
                    { new Guid("8f9a84fe-634e-4c0d-aae9-5b8e14ab6ac9"), new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"), new DateTime(2024, 2, 10, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6641), new Guid("c66eb2d2-ea35-46ec-a0d6-51343ef80338"), 409.0, new DateTime(2023, 7, 13, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6641), new DateTime(2024, 2, 11, 3, 46, 27, 463, DateTimeKind.Utc).AddTicks(6641) },
                    { new Guid("92021823-42ce-4f37-b42e-d8fce408fe25"), new Guid("2c3f91ce-41bd-4e94-b67a-71940ad862bc"), new DateTime(2024, 2, 8, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6635), new Guid("944069e0-6fff-46e9-bccd-7f2801140940"), 238.0, new DateTime(2023, 11, 7, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6635), new DateTime(2024, 2, 8, 18, 46, 27, 463, DateTimeKind.Utc).AddTicks(6635) },
                    { new Guid("a4508f29-7b0e-48b2-a32a-ef704646e7d0"), new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"), new DateTime(2024, 2, 17, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6643), new Guid("abb9d71b-70bf-431d-9377-82ebf3b4291d"), 682.0, new DateTime(2024, 1, 6, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 2, 18, 5, 46, 27, 463, DateTimeKind.Utc).AddTicks(6643) },
                    { new Guid("a7f832ed-f693-47b7-8338-36e45b15a17e"), new Guid("f585afaf-075f-4eb7-9bef-0c597db59e2e"), new DateTime(2024, 2, 11, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6607), new Guid("ca8acd35-9dcb-4e37-abbf-e533c32ef50c"), 670.0, new DateTime(2023, 12, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6607), new DateTime(2024, 2, 12, 14, 46, 27, 463, DateTimeKind.Utc).AddTicks(6607) },
                    { new Guid("a8874d82-dd34-447d-b20e-1e57fddfc9b7"), new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), new DateTime(2024, 2, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6579), new Guid("7706fa2a-6b63-4918-8a85-52e18f86ac0f"), 317.0, new DateTime(2024, 1, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6578), new DateTime(2024, 2, 3, 7, 46, 27, 463, DateTimeKind.Utc).AddTicks(6579) },
                    { new Guid("a9576744-94f6-4ba4-9677-bd4337c114fd"), new Guid("cf65798b-bc3a-4a0d-a662-d426463e640f"), new DateTime(2024, 2, 13, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6628), new Guid("99f1db78-5e1f-4919-96a7-93ad2932c508"), 767.0, new DateTime(2023, 5, 29, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6627), new DateTime(2024, 2, 13, 23, 46, 27, 463, DateTimeKind.Utc).AddTicks(6628) },
                    { new Guid("ae41f640-9261-4769-adf4-db375b595402"), new Guid("45b691a5-fd39-45a3-849d-e98d5e090d24"), new DateTime(2024, 2, 1, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6542), new Guid("1b4a1c34-2990-4f34-87b3-195f948e8f7f"), 967.0, new DateTime(2023, 10, 20, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6542), new DateTime(2024, 2, 2, 14, 46, 27, 463, DateTimeKind.Utc).AddTicks(6542) },
                    { new Guid("aec5dbd5-b21d-46b9-9b43-4575a96adaaa"), new Guid("06de5dbb-7f31-4abc-97b9-cc2b7afebfbc"), new DateTime(2024, 2, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6651), new Guid("c66eb2d2-ea35-46ec-a0d6-51343ef80338"), 714.0, new DateTime(2023, 5, 9, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6650), new DateTime(2024, 2, 9, 22, 46, 27, 463, DateTimeKind.Utc).AddTicks(6651) },
                    { new Guid("af4b00e2-7874-4d15-9722-51e966272c7f"), new Guid("45b691a5-fd39-45a3-849d-e98d5e090d24"), new DateTime(2024, 1, 27, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6567), new Guid("99f1db78-5e1f-4919-96a7-93ad2932c508"), 712.0, new DateTime(2023, 10, 3, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6566), new DateTime(2024, 1, 28, 0, 46, 27, 463, DateTimeKind.Utc).AddTicks(6567) },
                    { new Guid("b1c40765-8c9a-4722-be3f-716056b3c3fc"), new Guid("f585afaf-075f-4eb7-9bef-0c597db59e2e"), new DateTime(2024, 1, 26, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6612), new Guid("8678354c-f462-42e1-a38b-c1a17895b633"), 474.0, new DateTime(2023, 12, 17, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6612), new DateTime(2024, 1, 27, 7, 46, 27, 463, DateTimeKind.Utc).AddTicks(6612) },
                    { new Guid("b2d78bf5-4d95-403c-a574-4573fb423c77"), new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"), new DateTime(2024, 2, 5, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6620), new Guid("56c200a9-9621-47a9-a12a-c186d9d48da9"), 253.0, new DateTime(2023, 10, 6, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6620), new DateTime(2024, 2, 6, 13, 46, 27, 463, DateTimeKind.Utc).AddTicks(6620) },
                    { new Guid("b7176cb3-ad2f-4352-9b7c-bbb7310d50b8"), new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"), new DateTime(2024, 2, 1, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6638), new Guid("c66eb2d2-ea35-46ec-a0d6-51343ef80338"), 368.0, new DateTime(2023, 4, 15, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6638), new DateTime(2024, 2, 2, 0, 46, 27, 463, DateTimeKind.Utc).AddTicks(6638) },
                    { new Guid("bcdd6c10-8325-4ea0-ac93-2a05ad6bbf34"), new Guid("45b691a5-fd39-45a3-849d-e98d5e090d24"), new DateTime(2024, 2, 13, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6565), new Guid("99f1db78-5e1f-4919-96a7-93ad2932c508"), 586.0, new DateTime(2023, 5, 2, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6564), new DateTime(2024, 2, 13, 19, 46, 27, 463, DateTimeKind.Utc).AddTicks(6565) },
                    { new Guid("c07d0144-48e5-451e-9003-43479a47c1d4"), new Guid("61fe6fa3-f8b4-482a-87f3-4d8791c36f08"), new DateTime(2024, 1, 27, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6595), new Guid("99f1db78-5e1f-4919-96a7-93ad2932c508"), 858.0, new DateTime(2023, 11, 8, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6595), new DateTime(2024, 1, 27, 20, 46, 27, 463, DateTimeKind.Utc).AddTicks(6595) },
                    { new Guid("c9a14318-ccb7-4a86-8296-395d00dc20e0"), new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), new DateTime(2024, 1, 27, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6576), new Guid("c66eb2d2-ea35-46ec-a0d6-51343ef80338"), 492.0, new DateTime(2023, 11, 16, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6575), new DateTime(2024, 1, 27, 23, 46, 27, 463, DateTimeKind.Utc).AddTicks(6576) },
                    { new Guid("cd9053dc-1a16-4cf3-b895-566f71aea7ab"), new Guid("cf65798b-bc3a-4a0d-a662-d426463e640f"), new DateTime(2024, 1, 27, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6630), new Guid("1febe713-7175-44e2-b136-d047011db8a5"), 116.0, new DateTime(2023, 7, 22, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6630), new DateTime(2024, 1, 28, 0, 46, 27, 463, DateTimeKind.Utc).AddTicks(6630) },
                    { new Guid("d496a595-4f87-4490-b5e9-9610ad93db74"), new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"), new DateTime(2024, 1, 27, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6617), new Guid("7ca0f519-ea03-4114-b108-537791c80eea"), 805.0, new DateTime(2024, 2, 5, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6617), new DateTime(2024, 1, 27, 17, 46, 27, 463, DateTimeKind.Utc).AddTicks(6617) },
                    { new Guid("e7877c7e-2868-42d1-82f5-30289f57ef5f"), new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), new DateTime(2024, 1, 25, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6574), new Guid("1febe713-7175-44e2-b136-d047011db8a5"), 763.0, new DateTime(2023, 11, 8, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6573), new DateTime(2024, 1, 26, 0, 46, 27, 463, DateTimeKind.Utc).AddTicks(6574) },
                    { new Guid("f16e9c3a-4e3b-4465-a6da-d3bc515d52a3"), new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"), new DateTime(2024, 2, 1, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6570), new Guid("7706fa2a-6b63-4918-8a85-52e18f86ac0f"), 292.0, new DateTime(2023, 4, 12, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6570), new DateTime(2024, 2, 2, 3, 46, 27, 463, DateTimeKind.Utc).AddTicks(6570) },
                    { new Guid("f323b12c-66b9-4002-984d-d2e0f8455f18"), new Guid("45b691a5-fd39-45a3-849d-e98d5e090d24"), new DateTime(2024, 1, 31, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6561), new Guid("abb9d71b-70bf-431d-9377-82ebf3b4291d"), 200.0, new DateTime(2023, 12, 17, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6561), new DateTime(2024, 2, 1, 12, 46, 27, 463, DateTimeKind.Utc).AddTicks(6561) },
                    { new Guid("f357c644-6553-47b3-b264-d0786daeb691"), new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"), new DateTime(2024, 1, 23, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6615), new Guid("8678354c-f462-42e1-a38b-c1a17895b633"), 59.0, new DateTime(2023, 10, 11, 16, 46, 27, 463, DateTimeKind.Utc).AddTicks(6615), new DateTime(2024, 1, 24, 4, 46, 27, 463, DateTimeKind.Utc).AddTicks(6615) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0f7330f5-6b73-465d-bdbe-ed13cbc5d943"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("43a89939-73c1-40fd-a785-ce51f3783558"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0b475705-d8b1-4d77-b972-9d973f117212"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0b79bdbd-2cf4-4e96-87ed-f8a103fc6a36"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1452e8a8-1248-4fa7-b0ea-feaef2b534c5"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1e740d8b-7642-4a8f-8268-424c3acdc710"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("209fa7d0-328c-47da-9f57-fffa6dce2aa8"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("316a1948-0de3-4d82-af30-1a09196f8cbd"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("33163363-c92d-4e8f-acc7-93f136ed1a03"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3f8f0219-2be6-41f0-85bc-f0f260566ba5"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("44226734-802b-4e5c-b9c4-2680f8a98f64"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("515e6e5c-b42b-4491-bdf3-e11a4268e6b0"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("55a88ce2-2553-4daa-994d-c04fffffe9b0"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5fee163c-6bd3-4c2a-ba3b-8d832a93d65f"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6d3547d9-fb04-4b39-8854-c83727249a6e"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("75375a91-f41a-4ab9-8780-46f5ccb8325f"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8077e3ce-f5ce-4ab3-a497-9e0f62060bc2"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8376907c-2f6f-4777-88b2-12c27c932be6"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("884e6b30-29b8-400c-b974-16c5edaf3054"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9cf42c02-bd3e-4b4c-bce4-81a850e205b5"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9f2d2af3-478a-4d46-a1b2-4d314df3dc54"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a294a63a-e718-4cc2-8481-b9470a799289"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ac3ac016-4c2e-4a03-bf1c-e791f134f6f8"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ad1e7c35-8127-440b-b1a5-d3334b3c7839"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b639a317-02ed-408c-a62b-a7d09a882a28"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b823ae53-ac1d-4eef-b40b-9af71fdb89cd"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bae0ac35-2edb-464e-9f09-76060cab5111"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c0de2ba1-1fad-4772-9778-1a9825d82086"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c8e17abb-1438-4277-8f14-6e45c08bf002"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cb4fdf88-e83c-4e65-9d68-78ad7d7912ea"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cd91dd1a-2e1b-42f5-97e5-68c9a002da68"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d05b61f6-00d0-4f06-8b07-c907dc34d094"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d07c4fab-796b-41b6-b198-fc32b129299d"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d7c4a991-559a-42f1-a36c-37d3f2a99e79"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("dbeeaf7a-11df-4bab-ba16-0be2044c731a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e25f70ec-ea5b-4ecf-abd2-a2cae77b0195"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e99a254a-c9b4-4fdc-95b9-940e4c462f7a"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f1d1db7a-b980-4d79-ad6c-68e0d6f732ce"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f2ef4d23-c5d3-4311-9330-cd09866ae79d"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f5c75eb2-609c-45b7-b1b4-81f10a7ac576"));

            migrationBuilder.DeleteData(
                table: "CarPhotoEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("fd00e590-8186-47aa-b952-76a6e7c4a26b"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ad4a640c-5418-42b5-b845-46a93f667746"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d8a807a5-08a7-4d8e-bc17-5b0532ddd979"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("04b66e59-f46b-4abe-8f42-7dff0b79ae5b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("081509f2-2c10-4c48-9955-e3c917696685"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("08ff3171-f473-431a-826e-3afd04b39a63"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0e721561-83e9-4d62-a599-0e677d3ceb79"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0fc29ec3-680f-4c06-a370-9fae858c4c57"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("13c925f8-746f-40f5-9792-c775c2d07ca9"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("16aeeeda-d7b9-400c-bba0-d02bb07ee2b5"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("350d13fb-cb02-47e2-9206-a371cb7096bf"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("583f5d78-dc6d-4897-8ac3-789a9eeda8e0"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("58b7afad-70b0-4a44-86eb-67e32ab7fd30"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5a79c4d4-122f-4a51-8f6a-509ec74f2ada"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("69be4d60-e69d-4b0c-8a9b-5eeb273ad30b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6d6d56a8-64c2-40ab-9119-2e2fd079cf3a"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7e669f22-20bb-4713-be1c-0fda19da0c4d"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("81d617c1-2e85-4063-969c-66fe33f8c03b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("916b86cb-a11c-4fdd-9eec-8457bef721c9"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("92bd39ed-e580-4708-8f69-9a29e4c772c6"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9aaed91e-60d8-41ce-83d2-58168a4bae55"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9c07f1e4-7639-4701-ac5c-3e6e2d628fab"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a1eee8bd-7a94-42e6-92ab-5d2cfc9c530f"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a3d334d0-57b9-4f14-8d34-055fa9de431a"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a6655ca8-d63b-4c14-96e6-510ceb8415eb"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("aba8fdb7-fb08-41a9-90bf-fad403284ab3"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b80adf5c-abd0-468f-b634-bdab670b1891"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("caeca087-776c-4583-bc86-40f954587a0a"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ccebd1db-9d7c-4ed2-91ae-c5b92445de67"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("df50b72b-f028-4941-9f85-750a953e3e4c"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("eac2b298-abf0-4c67-87be-470e579b1477"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f7c8b522-34c0-44c5-9bf2-1571522e59ae"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("fb0f0bd5-1d56-43f8-aa44-87db5d7b650c"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("39654a26-3e81-4489-9a42-f648b2d5288a"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4139b093-b431-4a74-9639-d6c8eb5c83ee"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5b20517a-caba-4f01-9db6-8eebf5bb75c3"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5c1a672d-3678-4eb7-8fca-c0b07377e57d"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5f66560b-c540-4d54-9a2c-4faac963be58"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("71b96461-2d74-4d65-a34d-b68f59a583fa"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("741f3c14-3242-43ea-8bbc-b3091f0b4e87"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7c6dbf18-35f7-432c-91b5-fd83f4b3cdae"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7e213e99-b857-4d79-9d05-26e41929a512"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8710b435-d46f-4eec-b88c-bfda22582a15"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8ca36e16-406d-4561-a46f-03005deddc55"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8f9a84fe-634e-4c0d-aae9-5b8e14ab6ac9"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("92021823-42ce-4f37-b42e-d8fce408fe25"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a4508f29-7b0e-48b2-a32a-ef704646e7d0"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a7f832ed-f693-47b7-8338-36e45b15a17e"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a8874d82-dd34-447d-b20e-1e57fddfc9b7"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a9576744-94f6-4ba4-9677-bd4337c114fd"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ae41f640-9261-4769-adf4-db375b595402"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("aec5dbd5-b21d-46b9-9b43-4575a96adaaa"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("af4b00e2-7874-4d15-9722-51e966272c7f"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b1c40765-8c9a-4722-be3f-716056b3c3fc"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b2d78bf5-4d95-403c-a574-4573fb423c77"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b7176cb3-ad2f-4352-9b7c-bbb7310d50b8"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bcdd6c10-8325-4ea0-ac93-2a05ad6bbf34"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c07d0144-48e5-451e-9003-43479a47c1d4"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c9a14318-ccb7-4a86-8296-395d00dc20e0"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cd9053dc-1a16-4cf3-b895-566f71aea7ab"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d496a595-4f87-4490-b5e9-9610ad93db74"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e7877c7e-2868-42d1-82f5-30289f57ef5f"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f16e9c3a-4e3b-4465-a6da-d3bc515d52a3"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f323b12c-66b9-4002-984d-d2e0f8455f18"));

            migrationBuilder.DeleteData(
                table: "PriceHistoryEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f357c644-6553-47b3-b264-d0786daeb691"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("36564e4f-2d48-4e8c-8d3f-e3264be9967a"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7d80ef25-291e-4e50-8ab2-fb2cff092e83"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7ef31551-37d9-4322-b516-b3a8511dbb37"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a7bfcc63-7876-4b45-b05a-82c93d22d102"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f86ea7ce-adfd-4c58-88d1-3a13b6f3644a"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("06de5dbb-7f31-4abc-97b9-cc2b7afebfbc"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("25767b88-13a8-4a69-8b73-3739d119ad22"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2c3f91ce-41bd-4e94-b67a-71940ad862bc"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("45b691a5-fd39-45a3-849d-e98d5e090d24"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5bfa8265-1732-4059-867e-4f84a5bdc16e"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("61fe6fa3-f8b4-482a-87f3-4d8791c36f08"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6ee68fba-f131-4c88-b2d9-a58e9bb7f588"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7a1804b9-55fd-48b4-a22b-edb2387c7401"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8a73f030-78a6-490b-a83e-791256eaaf7c"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("a5e5d6a6-65b8-466d-9b7b-9a9d6d0636a1"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b9cc3c25-0520-46ba-9dd2-3b5783f8e417"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cf62063a-6924-4a6e-991b-5ff44ecc72f6"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("cf65798b-bc3a-4a0d-a662-d426463e640f"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e518b3a3-775a-475b-849c-6c79e7205f88"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e5b28c78-98aa-4ade-b6d9-782d200801a9"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ede97276-cc4d-41eb-8299-c2c83046266f"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f48372bb-a3ca-4ad9-9dd3-36c659d72259"));

            migrationBuilder.DeleteData(
                table: "CarEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f585afaf-075f-4eb7-9bef-0c597db59e2e"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2942ed48-0c8f-4af6-aa76-449d31a0e114"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("70c282a8-2060-4060-89f4-81b051edbed4"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0dd21b45-dda2-4e5e-b5e3-9879d4afd9fd"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1b4a1c34-2990-4f34-87b3-195f948e8f7f"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("1febe713-7175-44e2-b136-d047011db8a5"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2b534f4c-7a7f-4ad4-b254-80bab831877c"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4dbb8a25-fda9-416d-8185-6a7889476ba4"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("56c200a9-9621-47a9-a12a-c186d9d48da9"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7706fa2a-6b63-4918-8a85-52e18f86ac0f"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("7ca0f519-ea03-4114-b108-537791c80eea"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8678354c-f462-42e1-a38b-c1a17895b633"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("944069e0-6fff-46e9-bccd-7f2801140940"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("99f1db78-5e1f-4919-96a7-93ad2932c508"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("abb9d71b-70bf-431d-9377-82ebf3b4291d"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c66eb2d2-ea35-46ec-a0d6-51343ef80338"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ca8acd35-9dcb-4e37-abbf-e533c32ef50c"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ac0178b3-ded8-49c6-b05f-06ecd3f41a92"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("42936d44-00eb-4080-bbca-e2dd906edd2c"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("04bd6ddf-8177-4980-b0cd-6b023592ec95"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2935e278-320b-4129-a6d6-5f9ac0ac8223"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2d6d521e-cd1a-478f-88f9-b1ad4042b404"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4d1a7aec-2d27-4710-9090-4cb952f32491"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("5b764621-1014-44d2-8599-ffe8bd31e598"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("6b16f7cf-7e81-471a-bed8-72aa0ecf1b72"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("77f4cea5-e1e8-45d1-b5fe-6db9dd7fdec1"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bc636f83-3a37-461c-bbd7-f10f590cdf71"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c20935a4-9523-4c6c-81c7-82e54d067c9f"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("eb575b31-3851-4271-a45f-070fa5725f4f"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f21f3613-e393-401e-b858-f8c346d99767"));

            migrationBuilder.DeleteData(
                table: "ColorEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f23b1943-bf0c-4d42-8392-c41c0a160302"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("26ac32e2-5391-49a1-980e-2f4fd88e74f4"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("2a2376a2-1803-44dd-9ee8-66dff912dd18"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3b7656ad-86d5-4bd0-8304-c45aca23b88a"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("513faa11-669f-431a-b7c4-82a42e456a80"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("58a6528a-bb64-498c-a358-8c829f565750"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("61943f0b-13bc-4de3-9136-d3d7b95f549e"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("63e3c7a9-f8f2-4fa9-ac41-42b7392269ee"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9831e218-848b-4348-926e-e5c751fc82f8"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9b3f7513-2ca0-4217-bfcc-7ea923417062"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bd0413c7-860f-4db8-aa81-ddedcfc4c78b"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bf9692b4-ae5b-48ff-96af-d6d75e09027d"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("de77f2e9-a3cc-4d76-819b-cbac59249ff7"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e3db63fe-be43-4e73-b05c-e47e5e244363"));

            migrationBuilder.DeleteData(
                table: "ModelEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f486d3af-6e9f-4d1d-99e1-3d42758bfc95"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("0d1e9c3f-f698-402a-8f2b-7c8b9700dfa0"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4fb4e662-3ae0-4772-b623-a27e691f76d2"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("c9774c07-e76e-4650-8879-f7f9e9147ece"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ce44e0ba-a5e0-45d5-beb5-456206342f08"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d61aa1fe-9a71-4c55-b491-a2ea4e495fe4"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("d895412d-aeb6-4abc-a176-3be19621dcb0"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("e82832e8-7bb5-47ba-add7-6204b8a4d9ae"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("ee34f3f9-5ab1-4901-95e6-528a8300fb99"));

            migrationBuilder.DeleteData(
                table: "BrandEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f036342c-c3ae-476c-9569-ecb9362134be"));
        }
    }
}
