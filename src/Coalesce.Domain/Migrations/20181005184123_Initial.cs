using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coalesce.Domain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Address1 = table.Column<string>(maxLength: 200, nullable: true),
                    Address2 = table.Column<string>(maxLength: 200, nullable: true),
                    City = table.Column<string>(maxLength: 200, nullable: true),
                    State = table.Column<string>(maxLength: 100, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    State = table.Column<string>(maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 50, nullable: true),
                    ProductUniqueId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 75, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    LastBath = table.Column<DateTime>(nullable: true),
                    NextUpgrade = table.Column<DateTimeOffset>(nullable: true),
                    ProfilePic = table.Column<byte[]>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    CaseKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OpenedAt = table.Column<DateTimeOffset>(nullable: false),
                    AssignedToId = table.Column<int>(nullable: true),
                    ReportedById = table.Column<int>(nullable: true),
                    Attachment = table.Column<byte[]>(nullable: true),
                    Severity = table.Column<string>(maxLength: 20, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DevTeamAssignedId = table.Column<int>(nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.CaseKey);
                    table.ForeignKey(
                        name: "FK_Case_Person_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Case_Person_ReportedById",
                        column: x => x.ReportedById,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaseProduct",
                columns: table => new
                {
                    CaseProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseProduct", x => x.CaseProductId);
                    table.ForeignKey(
                        name: "FK_CaseProduct_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "CaseKey",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Case_AssignedToId",
                table: "Case",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_ReportedById",
                table: "Case",
                column: "ReportedById");

            migrationBuilder.CreateIndex(
                name: "IX_CaseProduct_CaseId",
                table: "CaseProduct",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseProduct_ProductId",
                table: "CaseProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CompanyId",
                table: "Person",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseProduct");

            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
