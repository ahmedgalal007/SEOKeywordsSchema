using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Host.Migrations.Application
{
    /// <inheritdoc />
    public partial class schemavalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Schema.Property");

            migrationBuilder.EnsureSchema(
                name: "Schema");

            migrationBuilder.CreateTable(
                name: "AdditionalType",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSingle = table.Column<bool>(type: "bit", nullable: false),
                    HasValue1 = table.Column<bool>(type: "bit", nullable: false),
                    HasValue2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSingle = table.Column<bool>(type: "bit", nullable: false),
                    HasValue1 = table.Column<bool>(type: "bit", nullable: false),
                    HasValue2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSingle = table.Column<bool>(type: "bit", nullable: false),
                    HasValue1 = table.Column<bool>(type: "bit", nullable: false),
                    HasValue2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainEntityOfPage",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSingle = table.Column<bool>(type: "bit", nullable: false),
                    HasValue1 = table.Column<bool>(type: "bit", nullable: false),
                    HasValue2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainEntityOfPage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PotentialAction",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotentialAction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectOf",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSingle = table.Column<bool>(type: "bit", nullable: false),
                    HasValue1 = table.Column<bool>(type: "bit", nullable: false),
                    HasValue2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectOf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Text",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Text", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Text_AdditionalType_AdditionalTypeId",
                        column: x => x.AdditionalTypeId,
                        principalSchema: "Schema.Property",
                        principalTable: "AdditionalType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Text_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalSchema: "Schema.Property",
                        principalTable: "Description",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "URL",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MainEntityOfPageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubjectOfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_URL_AdditionalType_AdditionalTypeId",
                        column: x => x.AdditionalTypeId,
                        principalSchema: "Schema.Property",
                        principalTable: "AdditionalType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_URL_Image_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "Schema.Property",
                        principalTable: "Image",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_URL_MainEntityOfPage_MainEntityOfPageId",
                        column: x => x.MainEntityOfPageId,
                        principalSchema: "Schema.Property",
                        principalTable: "MainEntityOfPage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_URL_SubjectOf_SubjectOfId",
                        column: x => x.SubjectOfId,
                        principalSchema: "Schema.Property",
                        principalTable: "SubjectOf",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AlternateName",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternateName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlternateName_Text_Id",
                        column: x => x.Id,
                        principalSchema: "Schema.Property",
                        principalTable: "Text",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identifier",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identifier_Text_Id",
                        column: x => x.Id,
                        principalSchema: "Schema.Property",
                        principalTable: "Text",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thing",
                schema: "Schema",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AlternateNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DisambiguatingDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdentifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MainEntityOfPageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PotentialActionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SameAsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubjectOfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UrlId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thing_AdditionalType_AdditionalTypeId",
                        column: x => x.AdditionalTypeId,
                        principalSchema: "Schema.Property",
                        principalTable: "AdditionalType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_AlternateName_AlternateNameId",
                        column: x => x.AlternateNameId,
                        principalSchema: "Schema.Property",
                        principalTable: "AlternateName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalSchema: "Schema.Property",
                        principalTable: "Description",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_Identifier_IdentifierId",
                        column: x => x.IdentifierId,
                        principalSchema: "Schema.Property",
                        principalTable: "Identifier",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_Image_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "Schema.Property",
                        principalTable: "Image",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_MainEntityOfPage_MainEntityOfPageId",
                        column: x => x.MainEntityOfPageId,
                        principalSchema: "Schema.Property",
                        principalTable: "MainEntityOfPage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_PotentialAction_PotentialActionId",
                        column: x => x.PotentialActionId,
                        principalSchema: "Schema.Property",
                        principalTable: "PotentialAction",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_SubjectOf_SubjectOfId",
                        column: x => x.SubjectOfId,
                        principalSchema: "Schema.Property",
                        principalTable: "SubjectOf",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_Text_DisambiguatingDescriptionId",
                        column: x => x.DisambiguatingDescriptionId,
                        principalSchema: "Schema.Property",
                        principalTable: "Text",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_Text_NameId",
                        column: x => x.NameId,
                        principalSchema: "Schema.Property",
                        principalTable: "Text",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_Thing_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Schema",
                        principalTable: "Thing",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_URL_SameAsId",
                        column: x => x.SameAsId,
                        principalSchema: "Schema.Property",
                        principalTable: "URL",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Thing_URL_UrlId",
                        column: x => x.UrlId,
                        principalSchema: "Schema.Property",
                        principalTable: "URL",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreativeWork",
                schema: "Schema",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchemaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MainEntityOfPageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubjectOfId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreativeWork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreativeWork_MainEntityOfPage_MainEntityOfPageId",
                        column: x => x.MainEntityOfPageId,
                        principalSchema: "Schema.Property",
                        principalTable: "MainEntityOfPage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreativeWork_SubjectOf_SubjectOfId",
                        column: x => x.SubjectOfId,
                        principalSchema: "Schema.Property",
                        principalTable: "SubjectOf",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreativeWork_Thing_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Schema",
                        principalTable: "Thing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Article",
                schema: "Schema",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchemaType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_CreativeWork_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Schema",
                        principalTable: "CreativeWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediaObject",
                schema: "Schema",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaObject_CreativeWork_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Schema",
                        principalTable: "CreativeWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageObject",
                schema: "Schema",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageObject_Image_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "Schema.Property",
                        principalTable: "Image",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ImageObject_MediaObject_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Schema",
                        principalTable: "MediaObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TextObject",
                schema: "Schema.Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextObject_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalSchema: "Schema.Property",
                        principalTable: "Description",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TextObject_MediaObject_Id",
                        column: x => x.Id,
                        principalSchema: "Schema",
                        principalTable: "MediaObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_ParentId",
                schema: "Schema",
                table: "Article",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CreativeWork_MainEntityOfPageId",
                schema: "Schema",
                table: "CreativeWork",
                column: "MainEntityOfPageId");

            migrationBuilder.CreateIndex(
                name: "IX_CreativeWork_ParentId",
                schema: "Schema",
                table: "CreativeWork",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CreativeWork_SubjectOfId",
                schema: "Schema",
                table: "CreativeWork",
                column: "SubjectOfId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageObject_ImageId",
                schema: "Schema",
                table: "ImageObject",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageObject_ParentId",
                schema: "Schema",
                table: "ImageObject",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaObject_ParentId",
                schema: "Schema",
                table: "MediaObject",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Text_AdditionalTypeId",
                schema: "Schema.Property",
                table: "Text",
                column: "AdditionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Text_DescriptionId",
                schema: "Schema.Property",
                table: "Text",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TextObject_DescriptionId",
                schema: "Schema.Property",
                table: "TextObject",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_AdditionalTypeId",
                schema: "Schema",
                table: "Thing",
                column: "AdditionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_AlternateNameId",
                schema: "Schema",
                table: "Thing",
                column: "AlternateNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_DescriptionId",
                schema: "Schema",
                table: "Thing",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_DisambiguatingDescriptionId",
                schema: "Schema",
                table: "Thing",
                column: "DisambiguatingDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_IdentifierId",
                schema: "Schema",
                table: "Thing",
                column: "IdentifierId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_ImageId",
                schema: "Schema",
                table: "Thing",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_MainEntityOfPageId",
                schema: "Schema",
                table: "Thing",
                column: "MainEntityOfPageId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_NameId",
                schema: "Schema",
                table: "Thing",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_ParentId",
                schema: "Schema",
                table: "Thing",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_PotentialActionId",
                schema: "Schema",
                table: "Thing",
                column: "PotentialActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_SameAsId",
                schema: "Schema",
                table: "Thing",
                column: "SameAsId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_SubjectOfId",
                schema: "Schema",
                table: "Thing",
                column: "SubjectOfId");

            migrationBuilder.CreateIndex(
                name: "IX_Thing_UrlId",
                schema: "Schema",
                table: "Thing",
                column: "UrlId");

            migrationBuilder.CreateIndex(
                name: "IX_URL_AdditionalTypeId",
                schema: "Schema.Property",
                table: "URL",
                column: "AdditionalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_URL_ImageId",
                schema: "Schema.Property",
                table: "URL",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_URL_MainEntityOfPageId",
                schema: "Schema.Property",
                table: "URL",
                column: "MainEntityOfPageId");

            migrationBuilder.CreateIndex(
                name: "IX_URL_SubjectOfId",
                schema: "Schema.Property",
                table: "URL",
                column: "SubjectOfId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article",
                schema: "Schema");

            migrationBuilder.DropTable(
                name: "ImageObject",
                schema: "Schema");

            migrationBuilder.DropTable(
                name: "TextObject",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "MediaObject",
                schema: "Schema");

            migrationBuilder.DropTable(
                name: "CreativeWork",
                schema: "Schema");

            migrationBuilder.DropTable(
                name: "Thing",
                schema: "Schema");

            migrationBuilder.DropTable(
                name: "AlternateName",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "Identifier",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "PotentialAction",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "URL",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "Text",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "Image",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "MainEntityOfPage",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "SubjectOf",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "AdditionalType",
                schema: "Schema.Property");

            migrationBuilder.DropTable(
                name: "Description",
                schema: "Schema.Property");
        }
    }
}
