using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace reimbursement_server_side.Migrations
{
    public partial class Intitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReimbursementStatuses",
                columns: table => new
                {
                    rStatusId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rStatus = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReimbursementStatuses", x => x.rStatusId);
                });

            migrationBuilder.CreateTable(
                name: "ReimbursementTypes",
                columns: table => new
                {
                    rTypeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReimbursementTypes", x => x.rTypeId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    userRoleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userRole = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.userRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    userFName = table.Column<string>(nullable: false),
                    userLName = table.Column<string>(nullable: false),
                    userEmail = table.Column<string>(nullable: false),
                    userRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_userRoleId",
                        column: x => x.userRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "userRoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reimbursements",
                columns: table => new
                {
                    rId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rAmount = table.Column<double>(nullable: false),
                    rSubmitted = table.Column<byte[]>(rowVersion: true, nullable: false),
                    rResolved = table.Column<byte[]>(rowVersion: true, nullable: true),
                    rDescription = table.Column<string>(nullable: true),
                    rStatusId = table.Column<int>(nullable: false),
                    rTypeId = table.Column<int>(nullable: false),
                    rAuthoruserId = table.Column<int>(nullable: false),
                    rResolveruserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reimbursements", x => x.rId);
                    table.ForeignKey(
                        name: "FK_Reimbursements_Users_rAuthoruserId",
                        column: x => x.rAuthoruserId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reimbursements_Users_rResolveruserId",
                        column: x => x.rResolveruserId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reimbursements_ReimbursementStatuses_rStatusId",
                        column: x => x.rStatusId,
                        principalTable: "ReimbursementStatuses",
                        principalColumn: "rStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reimbursements_ReimbursementTypes_rTypeId",
                        column: x => x.rTypeId,
                        principalTable: "ReimbursementTypes",
                        principalColumn: "rTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reimbursements_rAuthoruserId",
                table: "Reimbursements",
                column: "rAuthoruserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reimbursements_rResolveruserId",
                table: "Reimbursements",
                column: "rResolveruserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reimbursements_rStatusId",
                table: "Reimbursements",
                column: "rStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reimbursements_rTypeId",
                table: "Reimbursements",
                column: "rTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_userRoleId",
                table: "Users",
                column: "userRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reimbursements");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ReimbursementStatuses");

            migrationBuilder.DropTable(
                name: "ReimbursementTypes");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
