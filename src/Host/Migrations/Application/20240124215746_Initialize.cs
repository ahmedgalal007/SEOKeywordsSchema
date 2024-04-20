using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Host.Migrations.Application
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Schema");

            migrationBuilder.CreateTable(
                name: "Thing",
                schema: "Schema",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisambiguatingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainEntityOfPage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PotentialAction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SameAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffiliationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    award = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FollowsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thing_Thing_AffiliationId",
                        column: x => x.AffiliationId,
                        principalSchema: "Schema",
                        principalTable: "Thing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_Thing_FollowsId",
                        column: x => x.FollowsId,
                        principalSchema: "Schema",
                        principalTable: "Thing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_Thing_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Schema",
                        principalTable: "Thing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                schema: "Schema",
                columns: table => new
                {
                    ThingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HasValue1 = table.Column<bool>(type: "bit", nullable: false),
                    HasValue2 = table.Column<bool>(type: "bit", nullable: false),
                    IsSingle = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.ThingId);
                    table.ForeignKey(
                        name: "FK_Subjects_Thing_ThingId",
                        column: x => x.ThingId,
                        principalSchema: "Schema",
                        principalTable: "Thing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                schema: "Schema",
                columns: table => new
                {
                    SubjectOfThingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.SubjectOfThingId);
                    table.ForeignKey(
                        name: "FK_Organization_Subjects_SubjectOfThingId",
                        column: x => x.SubjectOfThingId,
                        principalSchema: "Schema",
                        principalTable: "Subjects",
                        principalColumn: "ThingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Schema",
                columns: table => new
                {
                    SubjectOfThingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.SubjectOfThingId);
                    table.ForeignKey(
                        name: "FK_Person_Subjects_SubjectOfThingId",
                        column: x => x.SubjectOfThingId,
                        principalSchema: "Schema",
                        principalTable: "Subjects",
                        principalColumn: "ThingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Thing_AffiliationId",
                schema: "Schema",
                table: "Thing",
                column: "AffiliationId",
                unique: true,
                filter: "[AffiliationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_FollowsId",
                schema: "Schema",
                table: "Thing",
                column: "FollowsId",
                unique: true,
                filter: "[FollowsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_PersonId",
                schema: "Schema",
                table: "Thing",
                column: "PersonId",
                unique: true,
                filter: "[PersonId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organization",
                schema: "Schema");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Schema");

            migrationBuilder.DropTable(
                name: "Subjects",
                schema: "Schema");

            migrationBuilder.DropTable(
                name: "Thing",
                schema: "Schema");
        }
    }
}
