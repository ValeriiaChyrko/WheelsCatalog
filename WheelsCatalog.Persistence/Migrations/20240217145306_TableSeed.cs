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
                table: "Brands",
                columns: new[] { "Id", "CreateDateTime", "Description", "LogoUrl", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("10b7f847-f9df-4a7b-97f5-7bc9aa108d0d"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8913), "Description for Brand 15", "https://example.com/logo15.png", "Brand 15", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8914) },
                    { new Guid("155dff8e-91a2-4cf6-ae38-34a948580506"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8898), "Description for Brand 10", "https://example.com/logo10.png", "Brand 10", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8898) },
                    { new Guid("2aa1683d-dad3-4822-a0bd-f89349878072"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8911), "Description for Brand 14", "https://example.com/logo14.png", "Brand 14", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8911) },
                    { new Guid("356c58b1-b9f1-420a-b4af-87d9c4c1075d"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8906), "Description for Brand 12", "https://example.com/logo12.png", "Brand 12", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8907) },
                    { new Guid("39cca2f8-3359-4172-bfa9-7a25beb333cc"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8831), "Description for Brand 1", "https://example.com/logo1.png", "Brand 1", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8833) },
                    { new Guid("47c27c13-bc6b-4054-87f0-5b6758a61ef9"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8855), "Description for Brand 4", "https://example.com/logo4.png", "Brand 4", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8856) },
                    { new Guid("4e4eb263-6b9d-4c3a-bdfd-3a47733073b1"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8837), "Description for Brand 2", "https://example.com/logo2.png", "Brand 2", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8838) },
                    { new Guid("4eed6de0-4430-435c-9994-b0b81717c6ee"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8840), "Description for Brand 3", "https://example.com/logo3.png", "Brand 3", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("664f8cd0-f992-4b55-818e-3465cf55ed4c"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8862), "Description for Brand 6", "https://example.com/logo6.png", "Brand 6", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8863) },
                    { new Guid("78938ae2-2895-48e5-b60a-166e5d01f27e"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8867), "Description for Brand 8", "https://example.com/logo8.png", "Brand 8", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8867) },
                    { new Guid("8b9fdb4f-4d9c-437a-8569-e753578d87b8"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8869), "Description for Brand 9", "https://example.com/logo9.png", "Brand 9", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8870) },
                    { new Guid("b977a908-ee1e-4f26-afc5-ae9947ca0965"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8865), "Description for Brand 7", "https://example.com/logo7.png", "Brand 7", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8865) },
                    { new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8901), "Description for Brand 11", "https://example.com/logo11.png", "Brand 11", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8901) },
                    { new Guid("e8c2e5ef-ca3c-4f58-9c44-b0a8d2010699"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8909), "Description for Brand 13", "https://example.com/logo13.png", "Brand 13", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8909) },
                    { new Guid("eb208759-7d7f-4d80-b6e3-fae451be526c"), new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8858), "Description for Brand 5", "https://example.com/logo5.png", "Brand 5", new DateTime(2024, 2, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(8858) }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "HexCode", "Name" },
                values: new object[,]
                {
                    { new Guid("08ba557c-950e-4a03-9df1-609abf1cb4b7"), "#00FFFF", "Cyan" },
                    { new Guid("17ecbd63-71f4-4446-856b-1d2e7e63d40a"), "#00FF00", "Green" },
                    { new Guid("19698506-7011-49b0-8ac0-4a75d91e2b23"), "#FFFFFF", "White" },
                    { new Guid("27230718-8ca6-446a-94bd-51cd42f13918"), "#00FF00", "Lime" },
                    { new Guid("359beace-45a4-415c-833d-fd1a75fa82ce"), "#0000FF", "Blue" },
                    { new Guid("3b272e08-8c06-4102-8fdd-87e0cf9022a6"), "#008080", "Teal" },
                    { new Guid("563f905d-75a9-47d5-b6fa-71c95d356f9e"), "#FFFF00", "Yellow" },
                    { new Guid("5c87f24c-7261-4969-9358-03fcf8efcaf0"), "#808080", "Gray" },
                    { new Guid("7b84e2a6-d492-4d0e-8640-aea37efc2b8f"), "#FFC0CB", "Pink" },
                    { new Guid("97116f83-8542-407a-8b9c-38e3a7eff574"), "#FF00FF", "Magenta" },
                    { new Guid("d01dc53e-6814-44af-b131-0caa5a9dc784"), "#800080", "Purple" },
                    { new Guid("df7f9131-6db0-4031-8c6e-ec6f64888be5"), "#FFA500", "Orange" },
                    { new Guid("eb8f2007-c5ea-44c5-b2a1-24c62f16f945"), "#FF0000", "Red" },
                    { new Guid("f62aad82-1809-4afa-8a88-95c88a197da7"), "#A52A2A", "Brown" },
                    { new Guid("fcf23c04-6d8d-4fa2-a36d-46f1142a29c7"), "#000000", "Black" }
                });

            migrationBuilder.InsertData(
                table: "CurrencyEntityModel",
                columns: new[] { "Id", "Acronym" },
                values: new object[,]
                {
                    { new Guid("011f15d9-30ac-4615-a91a-968426944568"), "CNY" },
                    { new Guid("14164e32-7a72-4e6d-a2aa-4bec95d190e5"), "CAD" },
                    { new Guid("3d3bc000-f076-4a21-b82c-06237655a4e0"), "CHF" },
                    { new Guid("480ef354-749b-48f6-a244-7167b8f5c59a"), "JPY" },
                    { new Guid("4d32a1a0-4d02-432c-af27-d355019c8816"), "SEK" },
                    { new Guid("748fca0d-cba2-46cb-a87b-ccd09e274efd"), "AUD" },
                    { new Guid("8ee69859-8389-4dae-b886-4d9d112adaea"), "GBP" },
                    { new Guid("94b9c25b-0507-476d-9f13-c6749498d50d"), "HKD" },
                    { new Guid("9fb332d1-bf3f-4de5-bf10-e5ca8416a7c3"), "EUR" },
                    { new Guid("b3e9d271-7445-4ba6-ab23-26aff55efac4"), "MXN" },
                    { new Guid("b94ab15e-61c1-4103-b7a5-224addadcf81"), "ZAR" },
                    { new Guid("bf2cb6a1-bcf7-4f82-9a8f-7fd2b64f499f"), "SGD" },
                    { new Guid("da13eb88-2b19-455e-ae47-3476255cfb5f"), "NOK" },
                    { new Guid("f2a9b836-70c8-4ea1-b4c1-38b7fcfcc87a"), "USD" },
                    { new Guid("f82938a3-e500-4894-a488-8c4b324039cc"), "NZD" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "CreateDateTime", "Description", "Name", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("027ec8a4-e6fc-4a05-8f35-1ef9b9cd992e"), new Guid("4eed6de0-4430-435c-9994-b0b81717c6ee"), new DateTime(2023, 3, 6, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9103), "Description for Model2 for Brand 3", "Model2 for Brand 3", new DateTime(2023, 7, 14, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9103) },
                    { new Guid("05ccbb0f-1380-4884-b68a-4e546845dd3b"), new Guid("e8c2e5ef-ca3c-4f58-9c44-b0a8d2010699"), new DateTime(2023, 12, 31, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9294), "Description for Model3 for Brand 13", "Model3 for Brand 13", new DateTime(2024, 12, 24, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9294) },
                    { new Guid("0614e76c-1403-4a78-a236-c393c3816634"), new Guid("4e4eb263-6b9d-4c3a-bdfd-3a47733073b1"), new DateTime(2023, 11, 9, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9081), "Description for Model1 for Brand 2", "Model1 for Brand 2", new DateTime(2024, 2, 24, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9081) },
                    { new Guid("062c7bc7-c06a-45e3-bbf0-721a2bcdf75c"), new Guid("39cca2f8-3359-4172-bfa9-7a25beb333cc"), new DateTime(2023, 7, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9068), "Description for Model2 for Brand 1", "Model2 for Brand 1", new DateTime(2024, 2, 27, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9068) },
                    { new Guid("112b06d2-c83a-4b0c-8552-ec48938f022e"), new Guid("10b7f847-f9df-4a7b-97f5-7bc9aa108d0d"), new DateTime(2023, 9, 24, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9314), "Description for Model1 for Brand 15", "Model1 for Brand 15", new DateTime(2024, 3, 22, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9314) },
                    { new Guid("1de069a0-1b86-46e9-9060-156e1b0aa296"), new Guid("664f8cd0-f992-4b55-818e-3465cf55ed4c"), new DateTime(2023, 10, 1, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9157), "Description for Model3 for Brand 6", "Model3 for Brand 6", new DateTime(2023, 10, 23, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9157) },
                    { new Guid("1fc87ce0-56e8-459f-9a86-f232b7c8d328"), new Guid("2aa1683d-dad3-4822-a0bd-f89349878072"), new DateTime(2023, 4, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9304), "Description for Model2 for Brand 14", "Model2 for Brand 14", new DateTime(2024, 3, 1, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9304) },
                    { new Guid("2632c85c-0633-4d20-bb6f-f54a2542869f"), new Guid("8b9fdb4f-4d9c-437a-8569-e753578d87b8"), new DateTime(2023, 12, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9223), "Description for Model1 for Brand 9", "Model1 for Brand 9", new DateTime(2024, 5, 3, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9223) },
                    { new Guid("3288807c-903a-475f-969b-f00f2b3244bc"), new Guid("b977a908-ee1e-4f26-afc5-ae9947ca0965"), new DateTime(2023, 6, 7, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9163), "Description for Model1 for Brand 7", "Model1 for Brand 7", new DateTime(2023, 7, 12, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9163) },
                    { new Guid("36282f68-a75e-47cb-bd33-53b326774f0b"), new Guid("155dff8e-91a2-4cf6-ae38-34a948580506"), new DateTime(2024, 1, 21, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9248), "Description for Model3 for Brand 10", "Model3 for Brand 10", new DateTime(2024, 3, 15, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9248) },
                    { new Guid("384587b3-6165-43b6-861b-0f84caf9cdce"), new Guid("10b7f847-f9df-4a7b-97f5-7bc9aa108d0d"), new DateTime(2023, 8, 12, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9325), "Description for Model3 for Brand 15", "Model3 for Brand 15", new DateTime(2023, 11, 21, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9325) },
                    { new Guid("41dc511f-84b5-4775-a40c-4ddb59e2243d"), new Guid("4e4eb263-6b9d-4c3a-bdfd-3a47733073b1"), new DateTime(2023, 8, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9086), "Description for Model2 for Brand 2", "Model2 for Brand 2", new DateTime(2023, 10, 15, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9086) },
                    { new Guid("43517c6c-9492-47d9-9181-c062c85b9ec2"), new Guid("47c27c13-bc6b-4054-87f0-5b6758a61ef9"), new DateTime(2023, 11, 6, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9119), "Description for Model2 for Brand 4", "Model2 for Brand 4", new DateTime(2024, 6, 9, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9119) },
                    { new Guid("4a078e12-7b83-4572-bb19-d7a46c58d7c7"), new Guid("e8c2e5ef-ca3c-4f58-9c44-b0a8d2010699"), new DateTime(2023, 4, 19, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9285), "Description for Model1 for Brand 13", "Model1 for Brand 13", new DateTime(2024, 3, 22, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9285) },
                    { new Guid("502e9953-f55f-4ba5-bbeb-aa4b68922675"), new Guid("4e4eb263-6b9d-4c3a-bdfd-3a47733073b1"), new DateTime(2023, 3, 23, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9092), "Description for Model3 for Brand 2", "Model3 for Brand 2", new DateTime(2023, 5, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9092) },
                    { new Guid("5d055ec1-567b-4adf-b212-5d74fd024985"), new Guid("2aa1683d-dad3-4822-a0bd-f89349878072"), new DateTime(2023, 9, 25, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9299), "Description for Model1 for Brand 14", "Model1 for Brand 14", new DateTime(2024, 5, 6, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9299) },
                    { new Guid("606ff679-394a-485f-b880-7cddc4d77ee5"), new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"), new DateTime(2023, 5, 21, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9262), "Description for Model3 for Brand 11", "Model3 for Brand 11", new DateTime(2023, 7, 22, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9262) },
                    { new Guid("6d664298-5e8c-4c61-807b-35f3400d5a30"), new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"), new DateTime(2024, 2, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9258), "Description for Model2 for Brand 11", "Model2 for Brand 11", new DateTime(2024, 6, 20, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9258) },
                    { new Guid("6eace151-d6de-4611-be8d-283f7bf5961f"), new Guid("8b9fdb4f-4d9c-437a-8569-e753578d87b8"), new DateTime(2023, 12, 13, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9232), "Description for Model3 for Brand 9", "Model3 for Brand 9", new DateTime(2024, 3, 27, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9232) },
                    { new Guid("82bb343c-033d-475e-b6b9-ac37eed141d3"), new Guid("47c27c13-bc6b-4054-87f0-5b6758a61ef9"), new DateTime(2023, 11, 4, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9114), "Description for Model1 for Brand 4", "Model1 for Brand 4", new DateTime(2024, 8, 31, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9114) },
                    { new Guid("8453c0a2-e47a-4d91-bf9b-dcc73c4150fb"), new Guid("eb208759-7d7f-4d80-b6e3-fae451be526c"), new DateTime(2023, 9, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9131), "Description for Model1 for Brand 5", "Model1 for Brand 5", new DateTime(2023, 12, 13, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9131) },
                    { new Guid("8517d8d3-04b7-4679-809f-9c098a58e0f4"), new Guid("4eed6de0-4430-435c-9994-b0b81717c6ee"), new DateTime(2023, 4, 14, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9107), "Description for Model3 for Brand 3", "Model3 for Brand 3", new DateTime(2023, 7, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9107) },
                    { new Guid("8ae07e9d-2a99-45a4-b67e-f4e6fbd2eef4"), new Guid("155dff8e-91a2-4cf6-ae38-34a948580506"), new DateTime(2023, 6, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9239), "Description for Model1 for Brand 10", "Model1 for Brand 10", new DateTime(2024, 5, 31, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9239) },
                    { new Guid("8d69a28b-e00b-4cba-87ad-1d4e9e762d2f"), new Guid("10b7f847-f9df-4a7b-97f5-7bc9aa108d0d"), new DateTime(2023, 2, 18, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9321), "Description for Model2 for Brand 15", "Model2 for Brand 15", new DateTime(2023, 3, 9, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9321) },
                    { new Guid("90ae9dfa-b32f-4464-8793-70abd08263ac"), new Guid("4eed6de0-4430-435c-9994-b0b81717c6ee"), new DateTime(2024, 2, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9098), "Description for Model1 for Brand 3", "Model1 for Brand 3", new DateTime(2024, 4, 12, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9098) },
                    { new Guid("91cbb861-918e-4cf5-a8ad-af0b9f2c67cf"), new Guid("b977a908-ee1e-4f26-afc5-ae9947ca0965"), new DateTime(2023, 6, 3, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9175), "Description for Model3 for Brand 7", "Model3 for Brand 7", new DateTime(2024, 1, 21, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9175) },
                    { new Guid("92df87c8-36b2-4a69-b2c7-6673cab018d0"), new Guid("47c27c13-bc6b-4054-87f0-5b6758a61ef9"), new DateTime(2023, 10, 21, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9126), "Description for Model3 for Brand 4", "Model3 for Brand 4", new DateTime(2024, 5, 7, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9126) },
                    { new Guid("9384afcd-1605-4142-a4cf-7dd6fd22c994"), new Guid("78938ae2-2895-48e5-b60a-166e5d01f27e"), new DateTime(2024, 1, 29, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9180), "Description for Model1 for Brand 8", "Model1 for Brand 8", new DateTime(2024, 4, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9180) },
                    { new Guid("93cdc9b4-a28c-4114-b02e-8d4ad23314e4"), new Guid("eb208759-7d7f-4d80-b6e3-fae451be526c"), new DateTime(2023, 7, 3, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9141), "Description for Model3 for Brand 5", "Model3 for Brand 5", new DateTime(2024, 6, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9141) },
                    { new Guid("97a08df7-3b6f-466b-be2c-a04bb5f4009c"), new Guid("2aa1683d-dad3-4822-a0bd-f89349878072"), new DateTime(2023, 11, 23, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9309), "Description for Model3 for Brand 14", "Model3 for Brand 14", new DateTime(2024, 3, 13, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9309) },
                    { new Guid("9b1dd26e-f944-4495-9646-6d3848d94579"), new Guid("78938ae2-2895-48e5-b60a-166e5d01f27e"), new DateTime(2023, 3, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9185), "Description for Model2 for Brand 8", "Model2 for Brand 8", new DateTime(2024, 2, 4, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9185) },
                    { new Guid("bc45c316-d145-49a4-aee3-50b0626f2bc3"), new Guid("155dff8e-91a2-4cf6-ae38-34a948580506"), new DateTime(2023, 10, 29, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9244), "Description for Model2 for Brand 10", "Model2 for Brand 10", new DateTime(2024, 9, 6, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9244) },
                    { new Guid("be028e7e-f334-4c56-8e33-a6e435a257a7"), new Guid("e8c2e5ef-ca3c-4f58-9c44-b0a8d2010699"), new DateTime(2023, 4, 29, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9290), "Description for Model2 for Brand 13", "Model2 for Brand 13", new DateTime(2023, 9, 12, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9290) },
                    { new Guid("c00512a4-f7d8-421f-be3e-c0ec8b97d63c"), new Guid("664f8cd0-f992-4b55-818e-3465cf55ed4c"), new DateTime(2023, 11, 5, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9147), "Description for Model1 for Brand 6", "Model1 for Brand 6", new DateTime(2024, 6, 26, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9147) },
                    { new Guid("c05b71d3-615c-401a-9663-9d2a77010b87"), new Guid("78938ae2-2895-48e5-b60a-166e5d01f27e"), new DateTime(2023, 6, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9218), "Description for Model3 for Brand 8", "Model3 for Brand 8", new DateTime(2023, 10, 13, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9218) },
                    { new Guid("ca0a0bd3-0d5c-4a8e-81d9-5b8b56003c56"), new Guid("356c58b1-b9f1-420a-b4af-87d9c4c1075d"), new DateTime(2023, 10, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9274), "Description for Model2 for Brand 12", "Model2 for Brand 12", new DateTime(2024, 10, 7, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9274) },
                    { new Guid("d85e1119-8ed6-4e56-b444-119f38fe8ae4"), new Guid("8b9fdb4f-4d9c-437a-8569-e753578d87b8"), new DateTime(2023, 12, 28, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9227), "Description for Model2 for Brand 9", "Model2 for Brand 9", new DateTime(2024, 8, 23, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9227) },
                    { new Guid("da668d2b-e22d-4d41-a14f-b25875375f6e"), new Guid("39cca2f8-3359-4172-bfa9-7a25beb333cc"), new DateTime(2023, 4, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9051), "Description for Model1 for Brand 1", "Model1 for Brand 1", new DateTime(2023, 10, 17, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9051) },
                    { new Guid("db6390a8-6b4f-48f7-be5e-09d862ac5ecb"), new Guid("eb208759-7d7f-4d80-b6e3-fae451be526c"), new DateTime(2023, 3, 24, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9136), "Description for Model2 for Brand 5", "Model2 for Brand 5", new DateTime(2023, 7, 23, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9136) },
                    { new Guid("de9b09ae-887a-4f61-81e5-fb0eece0ed14"), new Guid("356c58b1-b9f1-420a-b4af-87d9c4c1075d"), new DateTime(2023, 3, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9269), "Description for Model1 for Brand 12", "Model1 for Brand 12", new DateTime(2023, 5, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9269) },
                    { new Guid("dfe5c1ce-6989-48c7-b61b-1c9b44a8fdd8"), new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"), new DateTime(2023, 5, 6, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9253), "Description for Model1 for Brand 11", "Model1 for Brand 11", new DateTime(2023, 9, 12, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9253) },
                    { new Guid("ea76f537-b9b0-40e4-baae-4e98dc8b5dce"), new Guid("b977a908-ee1e-4f26-afc5-ae9947ca0965"), new DateTime(2023, 3, 5, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9170), "Description for Model2 for Brand 7", "Model2 for Brand 7", new DateTime(2023, 12, 19, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9170) },
                    { new Guid("ea9b9f34-309f-4ee7-a5d9-4eab061a318d"), new Guid("356c58b1-b9f1-420a-b4af-87d9c4c1075d"), new DateTime(2023, 7, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9280), "Description for Model3 for Brand 12", "Model3 for Brand 12", new DateTime(2024, 4, 11, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9280) },
                    { new Guid("eba59464-a1f0-4ebc-9585-cfbc2368c431"), new Guid("664f8cd0-f992-4b55-818e-3465cf55ed4c"), new DateTime(2023, 10, 18, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9151), "Description for Model2 for Brand 6", "Model2 for Brand 6", new DateTime(2024, 8, 31, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9151) },
                    { new Guid("f9930db5-086b-43bb-87c0-675ddade664c"), new Guid("39cca2f8-3359-4172-bfa9-7a25beb333cc"), new DateTime(2024, 2, 9, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9073), "Description for Model3 for Brand 1", "Model3 for Brand 1", new DateTime(2024, 6, 6, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9073) }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "ColorId", "CreateDateTime", "Description", "EngineVolume", "ModelId", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("0e8da9b4-2a32-4ea4-b678-518e5e7f1ae0"), new Guid("4e4eb263-6b9d-4c3a-bdfd-3a47733073b1"), new Guid("7b84e2a6-d492-4d0e-8640-aea37efc2b8f"), new DateTime(2024, 1, 7, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9480), "Description for car 10", 2116, new Guid("f9930db5-086b-43bb-87c0-675ddade664c"), new DateTime(2024, 1, 7, 20, 53, 6, 668, DateTimeKind.Utc).AddTicks(9480) },
                    { new Guid("2687ac4e-1226-4ec6-bd9f-78e37d0d81a4"), new Guid("4e4eb263-6b9d-4c3a-bdfd-3a47733073b1"), new Guid("df7f9131-6db0-4031-8c6e-ec6f64888be5"), new DateTime(2023, 5, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9448), "Description for car 1", 4922, new Guid("91cbb861-918e-4cf5-a8ad-af0b9f2c67cf"), new DateTime(2023, 5, 3, 6, 53, 6, 668, DateTimeKind.Utc).AddTicks(9448) },
                    { new Guid("2e66b8bc-2274-498c-909d-5b444ef3ea37"), new Guid("b977a908-ee1e-4f26-afc5-ae9947ca0965"), new Guid("d01dc53e-6814-44af-b131-0caa5a9dc784"), new DateTime(2024, 2, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9488), "Description for car 13", 2689, new Guid("82bb343c-033d-475e-b6b9-ac37eed141d3"), new DateTime(2024, 2, 2, 23, 53, 6, 668, DateTimeKind.Utc).AddTicks(9488) },
                    { new Guid("3d97e820-b2a3-443a-8bf1-3a7d707b863a"), new Guid("664f8cd0-f992-4b55-818e-3465cf55ed4c"), new Guid("08ba557c-950e-4a03-9df1-609abf1cb4b7"), new DateTime(2023, 8, 31, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9495), "Description for car 15", 3312, new Guid("3288807c-903a-475f-969b-f00f2b3244bc"), new DateTime(2023, 8, 31, 22, 53, 6, 668, DateTimeKind.Utc).AddTicks(9495) },
                    { new Guid("47b1e7a2-7456-4136-aea4-e296f0fa96f6"), new Guid("e8c2e5ef-ca3c-4f58-9c44-b0a8d2010699"), new Guid("7b84e2a6-d492-4d0e-8640-aea37efc2b8f"), new DateTime(2023, 9, 4, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9504), "Description for car 18", 4589, new Guid("ca0a0bd3-0d5c-4a8e-81d9-5b8b56003c56"), new DateTime(2023, 9, 5, 5, 53, 6, 668, DateTimeKind.Utc).AddTicks(9504) },
                    { new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"), new Guid("2aa1683d-dad3-4822-a0bd-f89349878072"), new Guid("563f905d-75a9-47d5-b6fa-71c95d356f9e"), new DateTime(2023, 5, 15, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9458), "Description for car 3", 2933, new Guid("97a08df7-3b6f-466b-be2c-a04bb5f4009c"), new DateTime(2023, 5, 16, 11, 53, 6, 668, DateTimeKind.Utc).AddTicks(9458) },
                    { new Guid("508b2912-bd42-4480-95fb-73a432ba8276"), new Guid("39cca2f8-3359-4172-bfa9-7a25beb333cc"), new Guid("3b272e08-8c06-4102-8fdd-87e0cf9022a6"), new DateTime(2024, 2, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9463), "Description for car 5", 4959, new Guid("ca0a0bd3-0d5c-4a8e-81d9-5b8b56003c56"), new DateTime(2024, 2, 2, 18, 53, 6, 668, DateTimeKind.Utc).AddTicks(9463) },
                    { new Guid("52e1c94d-5c7b-449d-819b-ebd5e7fb9ce5"), new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"), new Guid("3b272e08-8c06-4102-8fdd-87e0cf9022a6"), new DateTime(2023, 8, 9, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9483), "Description for car 11", 3389, new Guid("9b1dd26e-f944-4495-9646-6d3848d94579"), new DateTime(2023, 8, 9, 18, 53, 6, 668, DateTimeKind.Utc).AddTicks(9483) },
                    { new Guid("6b912a89-4cd1-4cc2-b02c-018de5837fec"), new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"), new Guid("563f905d-75a9-47d5-b6fa-71c95d356f9e"), new DateTime(2023, 9, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9492), "Description for car 14", 2472, new Guid("0614e76c-1403-4a78-a236-c393c3816634"), new DateTime(2023, 9, 11, 13, 53, 6, 668, DateTimeKind.Utc).AddTicks(9492) },
                    { new Guid("6db24646-f4ec-4597-9127-afef5390f471"), new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"), new Guid("97116f83-8542-407a-8b9c-38e3a7eff574"), new DateTime(2023, 12, 20, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9485), "Description for car 12", 2540, new Guid("da668d2b-e22d-4d41-a14f-b25875375f6e"), new DateTime(2023, 12, 21, 6, 53, 6, 668, DateTimeKind.Utc).AddTicks(9485) },
                    { new Guid("7601d109-372f-411f-8884-f37d39e4a094"), new Guid("10b7f847-f9df-4a7b-97f5-7bc9aa108d0d"), new Guid("f62aad82-1809-4afa-8a88-95c88a197da7"), new DateTime(2023, 5, 20, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9510), "Description for car 20", 1042, new Guid("da668d2b-e22d-4d41-a14f-b25875375f6e"), new DateTime(2023, 5, 20, 20, 53, 6, 668, DateTimeKind.Utc).AddTicks(9510) },
                    { new Guid("965b61dc-ff72-4408-a9de-626686ee572f"), new Guid("664f8cd0-f992-4b55-818e-3465cf55ed4c"), new Guid("359beace-45a4-415c-833d-fd1a75fa82ce"), new DateTime(2023, 10, 31, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9476), "Description for car 9", 1727, new Guid("9384afcd-1605-4142-a4cf-7dd6fd22c994"), new DateTime(2023, 11, 1, 6, 53, 6, 668, DateTimeKind.Utc).AddTicks(9476) },
                    { new Guid("b701b263-430a-487b-9a5f-c8fd77fe41f0"), new Guid("356c58b1-b9f1-420a-b4af-87d9c4c1075d"), new Guid("f62aad82-1809-4afa-8a88-95c88a197da7"), new DateTime(2023, 3, 21, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9460), "Description for car 4", 4533, new Guid("606ff679-394a-485f-b880-7cddc4d77ee5"), new DateTime(2023, 3, 22, 3, 53, 6, 668, DateTimeKind.Utc).AddTicks(9460) },
                    { new Guid("b91571f0-398b-4293-a9f6-3938505972c4"), new Guid("39cca2f8-3359-4172-bfa9-7a25beb333cc"), new Guid("19698506-7011-49b0-8ac0-4a75d91e2b23"), new DateTime(2023, 3, 23, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9455), "Description for car 2", 4268, new Guid("be028e7e-f334-4c56-8e33-a6e435a257a7"), new DateTime(2023, 3, 24, 8, 53, 6, 668, DateTimeKind.Utc).AddTicks(9455) },
                    { new Guid("c15df684-32c4-4d8d-9bdb-ab8f7dcd23b7"), new Guid("4e4eb263-6b9d-4c3a-bdfd-3a47733073b1"), new Guid("7b84e2a6-d492-4d0e-8640-aea37efc2b8f"), new DateTime(2023, 8, 23, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9474), "Description for car 8", 2721, new Guid("bc45c316-d145-49a4-aee3-50b0626f2bc3"), new DateTime(2023, 8, 23, 18, 53, 6, 668, DateTimeKind.Utc).AddTicks(9474) },
                    { new Guid("d518b5d6-43e5-4418-b9d5-f975e673f822"), new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"), new Guid("eb8f2007-c5ea-44c5-b2a1-24c62f16f945"), new DateTime(2023, 7, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9471), "Description for car 7", 3844, new Guid("90ae9dfa-b32f-4464-8793-70abd08263ac"), new DateTime(2023, 7, 2, 18, 53, 6, 668, DateTimeKind.Utc).AddTicks(9471) },
                    { new Guid("db2d61fe-ce14-40ed-a010-cf70f586e9d4"), new Guid("155dff8e-91a2-4cf6-ae38-34a948580506"), new Guid("d01dc53e-6814-44af-b131-0caa5a9dc784"), new DateTime(2023, 12, 31, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9507), "Description for car 19", 3661, new Guid("1de069a0-1b86-46e9-9060-156e1b0aa296"), new DateTime(2023, 12, 31, 15, 53, 6, 668, DateTimeKind.Utc).AddTicks(9507) },
                    { new Guid("dbe4df0c-06e1-45ca-9cee-f0c5aafe8ecd"), new Guid("356c58b1-b9f1-420a-b4af-87d9c4c1075d"), new Guid("97116f83-8542-407a-8b9c-38e3a7eff574"), new DateTime(2023, 12, 4, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9501), "Description for car 17", 3359, new Guid("8517d8d3-04b7-4679-809f-9c098a58e0f4"), new DateTime(2023, 12, 5, 1, 53, 6, 668, DateTimeKind.Utc).AddTicks(9501) },
                    { new Guid("ed25bbe2-971a-4dfb-8a77-e1217c0d74e6"), new Guid("eb208759-7d7f-4d80-b6e3-fae451be526c"), new Guid("5c87f24c-7261-4969-9358-03fcf8efcaf0"), new DateTime(2023, 4, 20, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9498), "Description for car 16", 3726, new Guid("2632c85c-0633-4d20-bb6f-f54a2542869f"), new DateTime(2023, 4, 20, 21, 53, 6, 668, DateTimeKind.Utc).AddTicks(9498) },
                    { new Guid("fd09842c-7cc9-4d7a-9c3e-aec4038a313e"), new Guid("8b9fdb4f-4d9c-437a-8569-e753578d87b8"), new Guid("d01dc53e-6814-44af-b131-0caa5a9dc784"), new DateTime(2023, 7, 15, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9468), "Description for car 6", 2622, new Guid("c00512a4-f7d8-421f-be3e-c0ec8b97d63c"), new DateTime(2023, 7, 16, 2, 53, 6, 668, DateTimeKind.Utc).AddTicks(9468) }
                });

            migrationBuilder.InsertData(
                table: "CarPhotos",
                columns: new[] { "Id", "CarId", "PhotoUrl" },
                values: new object[,]
                {
                    { new Guid("044b6cc6-690c-4d76-99d2-eae931fbd759"), new Guid("ed25bbe2-971a-4dfb-8a77-e1217c0d74e6"), "https://example.com/photo1.jpg" },
                    { new Guid("153f2c71-4342-4c3c-94f2-925d31eb27dd"), new Guid("508b2912-bd42-4480-95fb-73a432ba8276"), "https://example.com/photo3.jpg" },
                    { new Guid("2bcc663e-d1c3-42eb-b4c1-bbc5bba565ec"), new Guid("b91571f0-398b-4293-a9f6-3938505972c4"), "https://example.com/photo2.jpg" },
                    { new Guid("32dab96e-ae07-4d72-850a-c3588493fb37"), new Guid("6db24646-f4ec-4597-9127-afef5390f471"), "https://example.com/photo3.jpg" },
                    { new Guid("3ba20b46-3284-4619-86e4-6db6660006a7"), new Guid("c15df684-32c4-4d8d-9bdb-ab8f7dcd23b7"), "https://example.com/photo1.jpg" },
                    { new Guid("4398c2ce-f809-4e90-8292-c0a7bdff0937"), new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"), "https://example.com/photo2.jpg" },
                    { new Guid("46e91112-d59e-4157-9dd7-850d7da01305"), new Guid("fd09842c-7cc9-4d7a-9c3e-aec4038a313e"), "https://example.com/photo1.jpg" },
                    { new Guid("4ce9216c-58c6-460f-8d49-2f750e930e47"), new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"), "https://example.com/photo3.jpg" },
                    { new Guid("56b5a4a1-62b6-4007-aaeb-354e80f48bec"), new Guid("6b912a89-4cd1-4cc2-b02c-018de5837fec"), "https://example.com/photo2.jpg" },
                    { new Guid("67812abc-2cea-4b50-b150-8ff65911fb96"), new Guid("b91571f0-398b-4293-a9f6-3938505972c4"), "https://example.com/photo4.jpg" },
                    { new Guid("684fe001-b59d-467a-8f89-412c964fd86a"), new Guid("52e1c94d-5c7b-449d-819b-ebd5e7fb9ce5"), "https://example.com/photo2.jpg" },
                    { new Guid("6c12be7f-621b-47a8-bf72-17fcba56b2d4"), new Guid("6db24646-f4ec-4597-9127-afef5390f471"), "https://example.com/photo2.jpg" },
                    { new Guid("7c58b546-8501-4ed5-aa0e-5251751bb103"), new Guid("6b912a89-4cd1-4cc2-b02c-018de5837fec"), "https://example.com/photo3.jpg" },
                    { new Guid("83b4bf7c-4999-4d74-9c88-d6cfc1772d34"), new Guid("6b912a89-4cd1-4cc2-b02c-018de5837fec"), "https://example.com/photo1.jpg" },
                    { new Guid("88e4d5c0-00fa-424e-9aba-1168ef869b75"), new Guid("52e1c94d-5c7b-449d-819b-ebd5e7fb9ce5"), "https://example.com/photo3.jpg" },
                    { new Guid("8b56d7d1-45b6-4936-b7ae-6d5f76011ad9"), new Guid("508b2912-bd42-4480-95fb-73a432ba8276"), "https://example.com/photo1.jpg" },
                    { new Guid("8f69542d-eddb-453a-8afe-68c15c4d58a9"), new Guid("6b912a89-4cd1-4cc2-b02c-018de5837fec"), "https://example.com/photo4.jpg" },
                    { new Guid("93a4e684-a160-40ef-b4f1-d34ebdb7bfa9"), new Guid("c15df684-32c4-4d8d-9bdb-ab8f7dcd23b7"), "https://example.com/photo2.jpg" },
                    { new Guid("9ccf01dd-1636-41c7-82e3-d48f9b1eec97"), new Guid("508b2912-bd42-4480-95fb-73a432ba8276"), "https://example.com/photo4.jpg" },
                    { new Guid("a1c66c9e-cd2c-43c3-991b-5f5eba3035a2"), new Guid("2e66b8bc-2274-498c-909d-5b444ef3ea37"), "https://example.com/photo1.jpg" },
                    { new Guid("ae48ad53-14bb-4730-a71f-95b074103b54"), new Guid("db2d61fe-ce14-40ed-a010-cf70f586e9d4"), "https://example.com/photo1.jpg" },
                    { new Guid("ae62cc25-674d-4f7a-a7ee-f907b4e89b51"), new Guid("52e1c94d-5c7b-449d-819b-ebd5e7fb9ce5"), "https://example.com/photo1.jpg" },
                    { new Guid("b0b5bec7-3cfe-452a-8e21-610810ec4976"), new Guid("b91571f0-398b-4293-a9f6-3938505972c4"), "https://example.com/photo3.jpg" },
                    { new Guid("c2c86672-c640-4a1f-9b60-e51185544a32"), new Guid("ed25bbe2-971a-4dfb-8a77-e1217c0d74e6"), "https://example.com/photo2.jpg" },
                    { new Guid("d5d24bd3-13e9-45f1-b97a-2dd7c23d4006"), new Guid("3d97e820-b2a3-443a-8bf1-3a7d707b863a"), "https://example.com/photo2.jpg" },
                    { new Guid("d637b98d-6668-4eef-8e6d-5de12b9b689d"), new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"), "https://example.com/photo1.jpg" },
                    { new Guid("d6937134-112c-454f-9a16-737e5137b279"), new Guid("47b1e7a2-7456-4136-aea4-e296f0fa96f6"), "https://example.com/photo2.jpg" },
                    { new Guid("d893c786-c9d3-46ef-9f95-d1684d18be22"), new Guid("b91571f0-398b-4293-a9f6-3938505972c4"), "https://example.com/photo1.jpg" },
                    { new Guid("dc8fe83a-51e2-4954-85e5-0494b05e4578"), new Guid("dbe4df0c-06e1-45ca-9cee-f0c5aafe8ecd"), "https://example.com/photo1.jpg" },
                    { new Guid("e0179ce4-caec-4d01-8e98-64b8023cc742"), new Guid("b701b263-430a-487b-9a5f-c8fd77fe41f0"), "https://example.com/photo1.jpg" },
                    { new Guid("e083cff3-630a-400c-b807-692a90763ec1"), new Guid("508b2912-bd42-4480-95fb-73a432ba8276"), "https://example.com/photo2.jpg" },
                    { new Guid("e225c77d-c147-4c8a-83f5-fe32555a4db6"), new Guid("db2d61fe-ce14-40ed-a010-cf70f586e9d4"), "https://example.com/photo2.jpg" },
                    { new Guid("e43c668e-9e52-4314-bedb-ed1d09d7926f"), new Guid("d518b5d6-43e5-4418-b9d5-f975e673f822"), "https://example.com/photo2.jpg" },
                    { new Guid("e98adb28-f002-4c89-b8f6-8582804ed815"), new Guid("6db24646-f4ec-4597-9127-afef5390f471"), "https://example.com/photo1.jpg" },
                    { new Guid("f180c6da-a191-428d-9643-952c1dffeaff"), new Guid("ed25bbe2-971a-4dfb-8a77-e1217c0d74e6"), "https://example.com/photo3.jpg" },
                    { new Guid("f318bfc2-7b13-4f2b-bfe0-463b1eead88c"), new Guid("d518b5d6-43e5-4418-b9d5-f975e673f822"), "https://example.com/photo1.jpg" },
                    { new Guid("f347c1b2-cecf-47cc-9538-d2fb598e7183"), new Guid("2e66b8bc-2274-498c-909d-5b444ef3ea37"), "https://example.com/photo2.jpg" },
                    { new Guid("f5875104-7691-4a62-9e4b-5e99b5d76c58"), new Guid("0e8da9b4-2a32-4ea4-b678-518e5e7f1ae0"), "https://example.com/photo1.jpg" },
                    { new Guid("f9b8a7ea-f398-4f6f-97a9-7772409d5878"), new Guid("3d97e820-b2a3-443a-8bf1-3a7d707b863a"), "https://example.com/photo1.jpg" },
                    { new Guid("fbb4d73b-49e4-44f5-abc5-d7da2a9e62ee"), new Guid("dbe4df0c-06e1-45ca-9cee-f0c5aafe8ecd"), "https://example.com/photo2.jpg" },
                    { new Guid("ff30f7e4-dacb-428e-9b90-50da9dddf6ec"), new Guid("47b1e7a2-7456-4136-aea4-e296f0fa96f6"), "https://example.com/photo1.jpg" },
                    { new Guid("ff5ab54c-301e-4917-8587-f3abc6039e40"), new Guid("0e8da9b4-2a32-4ea4-b678-518e5e7f1ae0"), "https://example.com/photo2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PriceHistories",
                columns: new[] { "Id", "CarId", "CreateDateTime", "CurrencyId", "Price", "StartDate", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("06f46227-66c5-49c8-950b-32f12f6effdc"), new Guid("52e1c94d-5c7b-449d-819b-ebd5e7fb9ce5"), new DateTime(2024, 2, 8, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9845), new Guid("b94ab15e-61c1-4103-b7a5-224addadcf81"), 851.0, new DateTime(2023, 3, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 2, 9, 2, 53, 6, 668, DateTimeKind.Utc).AddTicks(9845) },
                    { new Guid("1249f167-15fc-493e-93f4-b0cbfef225ef"), new Guid("c15df684-32c4-4d8d-9bdb-ab8f7dcd23b7"), new DateTime(2024, 2, 11, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9831), new Guid("b94ab15e-61c1-4103-b7a5-224addadcf81"), 399.0, new DateTime(2023, 4, 8, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9831), new DateTime(2024, 2, 12, 4, 53, 6, 668, DateTimeKind.Utc).AddTicks(9831) },
                    { new Guid("153da4e9-d4f3-4e86-8fef-457bee85ca27"), new Guid("6db24646-f4ec-4597-9127-afef5390f471"), new DateTime(2024, 2, 14, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9850), new Guid("3d3bc000-f076-4a21-b82c-06237655a4e0"), 763.0, new DateTime(2023, 5, 1, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 2, 15, 7, 53, 6, 668, DateTimeKind.Utc).AddTicks(9850) },
                    { new Guid("205a8d51-3d3e-45ae-b526-11154234179e"), new Guid("965b61dc-ff72-4408-a9de-626686ee572f"), new DateTime(2024, 2, 11, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9842), new Guid("b94ab15e-61c1-4103-b7a5-224addadcf81"), 498.0, new DateTime(2023, 9, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9842), new DateTime(2024, 2, 11, 17, 53, 6, 668, DateTimeKind.Utc).AddTicks(9842) },
                    { new Guid("28a8f811-9e05-4a72-830d-407b87e4b934"), new Guid("7601d109-372f-411f-8884-f37d39e4a094"), new DateTime(2024, 2, 8, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9897), new Guid("f2a9b836-70c8-4ea1-b4c1-38b7fcfcc87a"), 869.0, new DateTime(2023, 9, 21, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9896), new DateTime(2024, 2, 9, 9, 53, 6, 668, DateTimeKind.Utc).AddTicks(9897) },
                    { new Guid("295817fe-d028-4f68-88a5-a898d5774be0"), new Guid("3d97e820-b2a3-443a-8bf1-3a7d707b863a"), new DateTime(2024, 2, 15, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9865), new Guid("da13eb88-2b19-455e-ae47-3476255cfb5f"), 948.0, new DateTime(2023, 5, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 2, 16, 5, 53, 6, 668, DateTimeKind.Utc).AddTicks(9865) },
                    { new Guid("2a483508-c008-4256-aa06-bf68c1fdb6e4"), new Guid("b91571f0-398b-4293-a9f6-3938505972c4"), new DateTime(2024, 1, 28, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9817), new Guid("9fb332d1-bf3f-4de5-bf10-e5ca8416a7c3"), 576.0, new DateTime(2023, 11, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9816), new DateTime(2024, 1, 29, 6, 53, 6, 668, DateTimeKind.Utc).AddTicks(9817) },
                    { new Guid("2bf18858-60ad-4843-9b95-3fc99b30c4e7"), new Guid("c15df684-32c4-4d8d-9bdb-ab8f7dcd23b7"), new DateTime(2024, 1, 27, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9833), new Guid("011f15d9-30ac-4615-a91a-968426944568"), 560.0, new DateTime(2023, 9, 14, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9833), new DateTime(2024, 1, 28, 13, 53, 6, 668, DateTimeKind.Utc).AddTicks(9833) },
                    { new Guid("2d8d0377-62d3-4531-92df-91c41776aa0b"), new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"), new DateTime(2024, 1, 26, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9823), new Guid("f2a9b836-70c8-4ea1-b4c1-38b7fcfcc87a"), 618.0, new DateTime(2023, 10, 30, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9822), new DateTime(2024, 1, 26, 19, 53, 6, 668, DateTimeKind.Utc).AddTicks(9823) },
                    { new Guid("388bc878-5bba-4415-a2a8-a24b70af2d2e"), new Guid("965b61dc-ff72-4408-a9de-626686ee572f"), new DateTime(2024, 2, 8, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9840), new Guid("b3e9d271-7445-4ba6-ab23-26aff55efac4"), 254.0, new DateTime(2023, 12, 29, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9840), new DateTime(2024, 2, 9, 12, 53, 6, 668, DateTimeKind.Utc).AddTicks(9840) },
                    { new Guid("402af165-bd5f-4337-a39e-6b2eb6fe8253"), new Guid("3d97e820-b2a3-443a-8bf1-3a7d707b863a"), new DateTime(2024, 1, 21, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9859), new Guid("3d3bc000-f076-4a21-b82c-06237655a4e0"), 459.0, new DateTime(2023, 12, 14, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 1, 21, 23, 53, 6, 668, DateTimeKind.Utc).AddTicks(9859) },
                    { new Guid("413d0dab-1b2a-40c0-b99c-bd45ba883755"), new Guid("ed25bbe2-971a-4dfb-8a77-e1217c0d74e6"), new DateTime(2024, 2, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9870), new Guid("8ee69859-8389-4dae-b886-4d9d112adaea"), 685.0, new DateTime(2023, 6, 29, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9869), new DateTime(2024, 2, 11, 7, 53, 6, 668, DateTimeKind.Utc).AddTicks(9870) },
                    { new Guid("45bddbe7-497e-4ffd-aaf1-712d19309b57"), new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"), new DateTime(2024, 1, 19, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9821), new Guid("480ef354-749b-48f6-a244-7167b8f5c59a"), 967.0, new DateTime(2023, 12, 19, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9820), new DateTime(2024, 1, 19, 22, 53, 6, 668, DateTimeKind.Utc).AddTicks(9821) },
                    { new Guid("47541357-1cf8-459e-8718-b5c47e54309c"), new Guid("6db24646-f4ec-4597-9127-afef5390f471"), new DateTime(2024, 1, 25, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9855), new Guid("011f15d9-30ac-4615-a91a-968426944568"), 366.0, new DateTime(2023, 7, 5, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 1, 25, 19, 53, 6, 668, DateTimeKind.Utc).AddTicks(9855) },
                    { new Guid("4f55b875-d98f-4edf-8311-f80de851d1fa"), new Guid("db2d61fe-ce14-40ed-a010-cf70f586e9d4"), new DateTime(2024, 1, 24, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9894), new Guid("8ee69859-8389-4dae-b886-4d9d112adaea"), 473.0, new DateTime(2023, 4, 26, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9894), new DateTime(2024, 1, 24, 23, 53, 6, 668, DateTimeKind.Utc).AddTicks(9894) },
                    { new Guid("4f80b14a-452c-40dc-aabd-45dedabbe6d9"), new Guid("dbe4df0c-06e1-45ca-9cee-f0c5aafe8ecd"), new DateTime(2024, 2, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9874), new Guid("011f15d9-30ac-4615-a91a-968426944568"), 131.0, new DateTime(2024, 2, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9873), new DateTime(2024, 2, 16, 23, 53, 6, 668, DateTimeKind.Utc).AddTicks(9874) },
                    { new Guid("6444fb02-cbc3-466f-a2b9-c82c75975b9d"), new Guid("db2d61fe-ce14-40ed-a010-cf70f586e9d4"), new DateTime(2024, 2, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9891), new Guid("3d3bc000-f076-4a21-b82c-06237655a4e0"), 351.0, new DateTime(2023, 9, 7, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 2, 3, 5, 53, 6, 668, DateTimeKind.Utc).AddTicks(9891) },
                    { new Guid("76ee5d5b-c471-4cbe-b957-98c70f75cec5"), new Guid("965b61dc-ff72-4408-a9de-626686ee572f"), new DateTime(2024, 2, 11, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9836), new Guid("8ee69859-8389-4dae-b886-4d9d112adaea"), 276.0, new DateTime(2023, 9, 29, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9836), new DateTime(2024, 2, 11, 23, 53, 6, 668, DateTimeKind.Utc).AddTicks(9836) },
                    { new Guid("8407d5cb-2f22-47a0-a0a4-c433bff4c78c"), new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"), new DateTime(2024, 2, 4, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9825), new Guid("bf2cb6a1-bcf7-4f82-9a8f-7fd2b64f499f"), 749.0, new DateTime(2023, 5, 11, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9824), new DateTime(2024, 2, 4, 21, 53, 6, 668, DateTimeKind.Utc).AddTicks(9825) },
                    { new Guid("850a7e0c-f442-449f-b8f7-0833cbec1b65"), new Guid("dbe4df0c-06e1-45ca-9cee-f0c5aafe8ecd"), new DateTime(2024, 1, 26, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9879), new Guid("94b9c25b-0507-476d-9f13-c6749498d50d"), 924.0, new DateTime(2023, 8, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9878), new DateTime(2024, 1, 26, 22, 53, 6, 668, DateTimeKind.Utc).AddTicks(9879) },
                    { new Guid("85735cd8-e88d-4ebf-a8c3-eafdb81992e8"), new Guid("b91571f0-398b-4293-a9f6-3938505972c4"), new DateTime(2024, 2, 8, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9813), new Guid("9fb332d1-bf3f-4de5-bf10-e5ca8416a7c3"), 628.0, new DateTime(2023, 5, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9812), new DateTime(2024, 2, 9, 12, 53, 6, 668, DateTimeKind.Utc).AddTicks(9813) },
                    { new Guid("87070623-52d9-4a46-b40b-de02d1aa2e23"), new Guid("2687ac4e-1226-4ec6-bd9f-78e37d0d81a4"), new DateTime(2024, 1, 25, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9810), new Guid("480ef354-749b-48f6-a244-7167b8f5c59a"), 721.0, new DateTime(2023, 11, 18, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9810), new DateTime(2024, 1, 25, 16, 53, 6, 668, DateTimeKind.Utc).AddTicks(9810) },
                    { new Guid("8e533620-4a5a-45cb-8708-996fbc2ba403"), new Guid("ed25bbe2-971a-4dfb-8a77-e1217c0d74e6"), new DateTime(2024, 1, 19, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9872), new Guid("480ef354-749b-48f6-a244-7167b8f5c59a"), 915.0, new DateTime(2023, 5, 26, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9871), new DateTime(2024, 1, 19, 19, 53, 6, 668, DateTimeKind.Utc).AddTicks(9872) },
                    { new Guid("901be530-9232-401a-a69a-637f2b08e9d6"), new Guid("47b1e7a2-7456-4136-aea4-e296f0fa96f6"), new DateTime(2024, 1, 29, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9883), new Guid("748fca0d-cba2-46cb-a87b-ccd09e274efd"), 416.0, new DateTime(2023, 3, 8, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9882), new DateTime(2024, 1, 30, 10, 53, 6, 668, DateTimeKind.Utc).AddTicks(9883) },
                    { new Guid("90ebeb2a-eadf-46eb-835d-d18d7de8c2fe"), new Guid("2687ac4e-1226-4ec6-bd9f-78e37d0d81a4"), new DateTime(2024, 2, 3, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9808), new Guid("14164e32-7a72-4e6d-a2aa-4bec95d190e5"), 454.0, new DateTime(2023, 5, 20, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9807), new DateTime(2024, 2, 3, 16, 53, 6, 668, DateTimeKind.Utc).AddTicks(9808) },
                    { new Guid("911f2cf0-ed1d-4b6f-b4ad-7e7db33777bc"), new Guid("52e1c94d-5c7b-449d-819b-ebd5e7fb9ce5"), new DateTime(2024, 1, 22, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9847), new Guid("480ef354-749b-48f6-a244-7167b8f5c59a"), 911.0, new DateTime(2024, 1, 2, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9847), new DateTime(2024, 1, 23, 3, 53, 6, 668, DateTimeKind.Utc).AddTicks(9847) },
                    { new Guid("b842d43d-2466-47ad-a9be-f26fa362b3d1"), new Guid("6db24646-f4ec-4597-9127-afef5390f471"), new DateTime(2024, 1, 24, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9853), new Guid("480ef354-749b-48f6-a244-7167b8f5c59a"), 282.0, new DateTime(2023, 9, 10, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9853), new DateTime(2024, 1, 24, 16, 53, 6, 668, DateTimeKind.Utc).AddTicks(9853) },
                    { new Guid("b9560715-b903-407f-9a3f-789209203db1"), new Guid("47b1e7a2-7456-4136-aea4-e296f0fa96f6"), new DateTime(2024, 2, 12, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9885), new Guid("bf2cb6a1-bcf7-4f82-9a8f-7fd2b64f499f"), 101.0, new DateTime(2024, 2, 9, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9885), new DateTime(2024, 2, 13, 4, 53, 6, 668, DateTimeKind.Utc).AddTicks(9885) },
                    { new Guid("c0b6119d-81bd-4474-a31b-f7e6f62ff161"), new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"), new DateTime(2024, 1, 25, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9827), new Guid("f82938a3-e500-4894-a488-8c4b324039cc"), 210.0, new DateTime(2023, 11, 22, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9827), new DateTime(2024, 1, 26, 0, 53, 6, 668, DateTimeKind.Utc).AddTicks(9827) },
                    { new Guid("cfa98b5c-3a18-4c7c-bc17-1e95fe11efbf"), new Guid("dbe4df0c-06e1-45ca-9cee-f0c5aafe8ecd"), new DateTime(2024, 2, 7, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9876), new Guid("f2a9b836-70c8-4ea1-b4c1-38b7fcfcc87a"), 906.0, new DateTime(2023, 10, 6, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9876), new DateTime(2024, 2, 8, 9, 53, 6, 668, DateTimeKind.Utc).AddTicks(9876) },
                    { new Guid("d133707a-d852-428f-addb-cc6ede51e79a"), new Guid("47b1e7a2-7456-4136-aea4-e296f0fa96f6"), new DateTime(2024, 1, 19, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9887), new Guid("748fca0d-cba2-46cb-a87b-ccd09e274efd"), 410.0, new DateTime(2023, 8, 14, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 1, 20, 7, 53, 6, 668, DateTimeKind.Utc).AddTicks(9887) },
                    { new Guid("d54d408e-4344-4b05-a8c2-2dba550eb7d6"), new Guid("ed25bbe2-971a-4dfb-8a77-e1217c0d74e6"), new DateTime(2024, 1, 26, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9867), new Guid("b3e9d271-7445-4ba6-ab23-26aff55efac4"), 681.0, new DateTime(2023, 4, 13, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 1, 26, 15, 53, 6, 668, DateTimeKind.Utc).AddTicks(9867) },
                    { new Guid("d5bbd263-f8b4-42b9-9c2c-fa4a085d1d12"), new Guid("db2d61fe-ce14-40ed-a010-cf70f586e9d4"), new DateTime(2024, 2, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9889), new Guid("4d32a1a0-4d02-432c-af27-d355019c8816"), 381.0, new DateTime(2023, 9, 23, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9889), new DateTime(2024, 2, 16, 23, 53, 6, 668, DateTimeKind.Utc).AddTicks(9889) },
                    { new Guid("e8231b88-d98c-4c14-a182-236985e6918e"), new Guid("3d97e820-b2a3-443a-8bf1-3a7d707b863a"), new DateTime(2024, 2, 12, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9863), new Guid("da13eb88-2b19-455e-ae47-3476255cfb5f"), 867.0, new DateTime(2023, 7, 27, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9862), new DateTime(2024, 2, 12, 15, 53, 6, 668, DateTimeKind.Utc).AddTicks(9863) },
                    { new Guid("ebc830d1-fe5b-46c9-a886-1baecc3c1786"), new Guid("2687ac4e-1226-4ec6-bd9f-78e37d0d81a4"), new DateTime(2024, 2, 16, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9795), new Guid("f2a9b836-70c8-4ea1-b4c1-38b7fcfcc87a"), 182.0, new DateTime(2023, 5, 5, 14, 53, 6, 668, DateTimeKind.Utc).AddTicks(9794), new DateTime(2024, 2, 17, 3, 53, 6, 668, DateTimeKind.Utc).AddTicks(9795) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("044b6cc6-690c-4d76-99d2-eae931fbd759"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("153f2c71-4342-4c3c-94f2-925d31eb27dd"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("2bcc663e-d1c3-42eb-b4c1-bbc5bba565ec"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("32dab96e-ae07-4d72-850a-c3588493fb37"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("3ba20b46-3284-4619-86e4-6db6660006a7"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("4398c2ce-f809-4e90-8292-c0a7bdff0937"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("46e91112-d59e-4157-9dd7-850d7da01305"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("4ce9216c-58c6-460f-8d49-2f750e930e47"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("56b5a4a1-62b6-4007-aaeb-354e80f48bec"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("67812abc-2cea-4b50-b150-8ff65911fb96"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("684fe001-b59d-467a-8f89-412c964fd86a"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("6c12be7f-621b-47a8-bf72-17fcba56b2d4"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("7c58b546-8501-4ed5-aa0e-5251751bb103"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("83b4bf7c-4999-4d74-9c88-d6cfc1772d34"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("88e4d5c0-00fa-424e-9aba-1168ef869b75"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8b56d7d1-45b6-4936-b7ae-6d5f76011ad9"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8f69542d-eddb-453a-8afe-68c15c4d58a9"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("93a4e684-a160-40ef-b4f1-d34ebdb7bfa9"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("9ccf01dd-1636-41c7-82e3-d48f9b1eec97"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("a1c66c9e-cd2c-43c3-991b-5f5eba3035a2"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ae48ad53-14bb-4730-a71f-95b074103b54"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ae62cc25-674d-4f7a-a7ee-f907b4e89b51"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b0b5bec7-3cfe-452a-8e21-610810ec4976"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("c2c86672-c640-4a1f-9b60-e51185544a32"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("d5d24bd3-13e9-45f1-b97a-2dd7c23d4006"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("d637b98d-6668-4eef-8e6d-5de12b9b689d"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("d6937134-112c-454f-9a16-737e5137b279"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("d893c786-c9d3-46ef-9f95-d1684d18be22"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("dc8fe83a-51e2-4954-85e5-0494b05e4578"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e0179ce4-caec-4d01-8e98-64b8023cc742"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e083cff3-630a-400c-b807-692a90763ec1"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e225c77d-c147-4c8a-83f5-fe32555a4db6"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e43c668e-9e52-4314-bedb-ed1d09d7926f"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("e98adb28-f002-4c89-b8f6-8582804ed815"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f180c6da-a191-428d-9643-952c1dffeaff"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f318bfc2-7b13-4f2b-bfe0-463b1eead88c"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f347c1b2-cecf-47cc-9538-d2fb598e7183"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f5875104-7691-4a62-9e4b-5e99b5d76c58"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f9b8a7ea-f398-4f6f-97a9-7772409d5878"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("fbb4d73b-49e4-44f5-abc5-d7da2a9e62ee"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ff30f7e4-dacb-428e-9b90-50da9dddf6ec"));

            migrationBuilder.DeleteData(
                table: "CarPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ff5ab54c-301e-4917-8587-f3abc6039e40"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("17ecbd63-71f4-4446-856b-1d2e7e63d40a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("27230718-8ca6-446a-94bd-51cd42f13918"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("fcf23c04-6d8d-4fa2-a36d-46f1142a29c7"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("027ec8a4-e6fc-4a05-8f35-1ef9b9cd992e"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("05ccbb0f-1380-4884-b68a-4e546845dd3b"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("062c7bc7-c06a-45e3-bbf0-721a2bcdf75c"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("112b06d2-c83a-4b0c-8552-ec48938f022e"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("1fc87ce0-56e8-459f-9a86-f232b7c8d328"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("36282f68-a75e-47cb-bd33-53b326774f0b"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("384587b3-6165-43b6-861b-0f84caf9cdce"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("41dc511f-84b5-4775-a40c-4ddb59e2243d"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("43517c6c-9492-47d9-9181-c062c85b9ec2"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("4a078e12-7b83-4572-bb19-d7a46c58d7c7"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("502e9953-f55f-4ba5-bbeb-aa4b68922675"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("5d055ec1-567b-4adf-b212-5d74fd024985"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("6d664298-5e8c-4c61-807b-35f3400d5a30"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("6eace151-d6de-4611-be8d-283f7bf5961f"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("8453c0a2-e47a-4d91-bf9b-dcc73c4150fb"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("8ae07e9d-2a99-45a4-b67e-f4e6fbd2eef4"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("8d69a28b-e00b-4cba-87ad-1d4e9e762d2f"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("92df87c8-36b2-4a69-b2c7-6673cab018d0"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("93cdc9b4-a28c-4114-b02e-8d4ad23314e4"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c05b71d3-615c-401a-9663-9d2a77010b87"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("d85e1119-8ed6-4e56-b444-119f38fe8ae4"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("db6390a8-6b4f-48f7-be5e-09d862ac5ecb"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("de9b09ae-887a-4f61-81e5-fb0eece0ed14"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("dfe5c1ce-6989-48c7-b61b-1c9b44a8fdd8"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("ea76f537-b9b0-40e4-baae-4e98dc8b5dce"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("ea9b9f34-309f-4ee7-a5d9-4eab061a318d"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("eba59464-a1f0-4ebc-9585-cfbc2368c431"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("06f46227-66c5-49c8-950b-32f12f6effdc"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("1249f167-15fc-493e-93f4-b0cbfef225ef"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("153da4e9-d4f3-4e86-8fef-457bee85ca27"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("205a8d51-3d3e-45ae-b526-11154234179e"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("28a8f811-9e05-4a72-830d-407b87e4b934"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("295817fe-d028-4f68-88a5-a898d5774be0"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("2a483508-c008-4256-aa06-bf68c1fdb6e4"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("2bf18858-60ad-4843-9b95-3fc99b30c4e7"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("2d8d0377-62d3-4531-92df-91c41776aa0b"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("388bc878-5bba-4415-a2a8-a24b70af2d2e"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("402af165-bd5f-4337-a39e-6b2eb6fe8253"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("413d0dab-1b2a-40c0-b99c-bd45ba883755"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("45bddbe7-497e-4ffd-aaf1-712d19309b57"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("47541357-1cf8-459e-8718-b5c47e54309c"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("4f55b875-d98f-4edf-8311-f80de851d1fa"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("4f80b14a-452c-40dc-aabd-45dedabbe6d9"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("6444fb02-cbc3-466f-a2b9-c82c75975b9d"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("76ee5d5b-c471-4cbe-b957-98c70f75cec5"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("8407d5cb-2f22-47a0-a0a4-c433bff4c78c"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("850a7e0c-f442-449f-b8f7-0833cbec1b65"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("85735cd8-e88d-4ebf-a8c3-eafdb81992e8"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("87070623-52d9-4a46-b40b-de02d1aa2e23"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("8e533620-4a5a-45cb-8708-996fbc2ba403"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("901be530-9232-401a-a69a-637f2b08e9d6"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("90ebeb2a-eadf-46eb-835d-d18d7de8c2fe"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("911f2cf0-ed1d-4b6f-b4ad-7e7db33777bc"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("b842d43d-2466-47ad-a9be-f26fa362b3d1"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("b9560715-b903-407f-9a3f-789209203db1"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("c0b6119d-81bd-4474-a31b-f7e6f62ff161"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("cfa98b5c-3a18-4c7c-bc17-1e95fe11efbf"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("d133707a-d852-428f-addb-cc6ede51e79a"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("d54d408e-4344-4b05-a8c2-2dba550eb7d6"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("d5bbd263-f8b4-42b9-9c2c-fa4a085d1d12"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("e8231b88-d98c-4c14-a182-236985e6918e"));

            migrationBuilder.DeleteData(
                table: "PriceHistories",
                keyColumn: "Id",
                keyValue: new Guid("ebc830d1-fe5b-46c9-a886-1baecc3c1786"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("0e8da9b4-2a32-4ea4-b678-518e5e7f1ae0"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2687ac4e-1226-4ec6-bd9f-78e37d0d81a4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2e66b8bc-2274-498c-909d-5b444ef3ea37"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3d97e820-b2a3-443a-8bf1-3a7d707b863a"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("47b1e7a2-7456-4136-aea4-e296f0fa96f6"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4c7ee6fe-ea56-4001-af13-241a85dba21f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("508b2912-bd42-4480-95fb-73a432ba8276"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("52e1c94d-5c7b-449d-819b-ebd5e7fb9ce5"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6b912a89-4cd1-4cc2-b02c-018de5837fec"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6db24646-f4ec-4597-9127-afef5390f471"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7601d109-372f-411f-8884-f37d39e4a094"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("965b61dc-ff72-4408-a9de-626686ee572f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b701b263-430a-487b-9a5f-c8fd77fe41f0"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b91571f0-398b-4293-a9f6-3938505972c4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c15df684-32c4-4d8d-9bdb-ab8f7dcd23b7"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d518b5d6-43e5-4418-b9d5-f975e673f822"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("db2d61fe-ce14-40ed-a010-cf70f586e9d4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("dbe4df0c-06e1-45ca-9cee-f0c5aafe8ecd"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("ed25bbe2-971a-4dfb-8a77-e1217c0d74e6"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("fd09842c-7cc9-4d7a-9c3e-aec4038a313e"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("011f15d9-30ac-4615-a91a-968426944568"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("14164e32-7a72-4e6d-a2aa-4bec95d190e5"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("3d3bc000-f076-4a21-b82c-06237655a4e0"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("480ef354-749b-48f6-a244-7167b8f5c59a"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("4d32a1a0-4d02-432c-af27-d355019c8816"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("748fca0d-cba2-46cb-a87b-ccd09e274efd"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("8ee69859-8389-4dae-b886-4d9d112adaea"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("94b9c25b-0507-476d-9f13-c6749498d50d"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("9fb332d1-bf3f-4de5-bf10-e5ca8416a7c3"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b3e9d271-7445-4ba6-ab23-26aff55efac4"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("b94ab15e-61c1-4103-b7a5-224addadcf81"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("bf2cb6a1-bcf7-4f82-9a8f-7fd2b64f499f"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("da13eb88-2b19-455e-ae47-3476255cfb5f"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f2a9b836-70c8-4ea1-b4c1-38b7fcfcc87a"));

            migrationBuilder.DeleteData(
                table: "CurrencyEntityModel",
                keyColumn: "Id",
                keyValue: new Guid("f82938a3-e500-4894-a488-8c4b324039cc"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("10b7f847-f9df-4a7b-97f5-7bc9aa108d0d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("eb208759-7d7f-4d80-b6e3-fae451be526c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("08ba557c-950e-4a03-9df1-609abf1cb4b7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("19698506-7011-49b0-8ac0-4a75d91e2b23"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("359beace-45a4-415c-833d-fd1a75fa82ce"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("3b272e08-8c06-4102-8fdd-87e0cf9022a6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("563f905d-75a9-47d5-b6fa-71c95d356f9e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5c87f24c-7261-4969-9358-03fcf8efcaf0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("7b84e2a6-d492-4d0e-8640-aea37efc2b8f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("97116f83-8542-407a-8b9c-38e3a7eff574"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d01dc53e-6814-44af-b131-0caa5a9dc784"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("df7f9131-6db0-4031-8c6e-ec6f64888be5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("eb8f2007-c5ea-44c5-b2a1-24c62f16f945"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("f62aad82-1809-4afa-8a88-95c88a197da7"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("0614e76c-1403-4a78-a236-c393c3816634"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("1de069a0-1b86-46e9-9060-156e1b0aa296"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("2632c85c-0633-4d20-bb6f-f54a2542869f"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("3288807c-903a-475f-969b-f00f2b3244bc"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("606ff679-394a-485f-b880-7cddc4d77ee5"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("82bb343c-033d-475e-b6b9-ac37eed141d3"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("8517d8d3-04b7-4679-809f-9c098a58e0f4"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("90ae9dfa-b32f-4464-8793-70abd08263ac"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("91cbb861-918e-4cf5-a8ad-af0b9f2c67cf"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("9384afcd-1605-4142-a4cf-7dd6fd22c994"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("97a08df7-3b6f-466b-be2c-a04bb5f4009c"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("9b1dd26e-f944-4495-9646-6d3848d94579"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("bc45c316-d145-49a4-aee3-50b0626f2bc3"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("be028e7e-f334-4c56-8e33-a6e435a257a7"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c00512a4-f7d8-421f-be3e-c0ec8b97d63c"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("ca0a0bd3-0d5c-4a8e-81d9-5b8b56003c56"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("da668d2b-e22d-4d41-a14f-b25875375f6e"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("f9930db5-086b-43bb-87c0-675ddade664c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("155dff8e-91a2-4cf6-ae38-34a948580506"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("2aa1683d-dad3-4822-a0bd-f89349878072"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("356c58b1-b9f1-420a-b4af-87d9c4c1075d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("39cca2f8-3359-4172-bfa9-7a25beb333cc"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("47c27c13-bc6b-4054-87f0-5b6758a61ef9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4e4eb263-6b9d-4c3a-bdfd-3a47733073b1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4eed6de0-4430-435c-9994-b0b81717c6ee"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("664f8cd0-f992-4b55-818e-3465cf55ed4c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("78938ae2-2895-48e5-b60a-166e5d01f27e"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8b9fdb4f-4d9c-437a-8569-e753578d87b8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("b977a908-ee1e-4f26-afc5-ae9947ca0965"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("bec4bbfd-5558-4659-b966-ea37f87cb3a1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("e8c2e5ef-ca3c-4f58-9c44-b0a8d2010699"));
        }
    }
}
