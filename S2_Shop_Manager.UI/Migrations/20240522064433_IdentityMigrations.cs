using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace S2_Shop_Manager.UI.Migrations
{
    /// <inheritdoc />
    public partial class IdentityMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Employees",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 14, 44, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 21, 42, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 2, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 9, 52, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 2, 11, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 0, 24, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 18, 35, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 4, 33, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 10, 19, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 14, 8, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 17, 33, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 1, 5, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 5, 50, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 0, 41, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 5, 8, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 18, 9, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 27, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 13, 39, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 2, 12, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 18, 12, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 23, 51, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 17, 16, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 9, 57, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 16, 57, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 40, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 19, 23, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 19, 54, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 16, 2, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 19, 36, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 2, 55, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 11, 12, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 1, 17, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 23, 1, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 5, 50, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 3, 57, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 10, 30, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 57, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 17, 25, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 19, 16, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 19, 17, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 9, 35, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 7, 29, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 56, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 6, 5, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 1, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 9, 38, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 14, 36, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 7, 28, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 7, 43, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 18, 34, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 11, 0, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 19, 43, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 17, 59, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 12, 23, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 17, 54, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 6, 3, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 10, 6, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 4, 14, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 20, 7, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 21, 56, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 47, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 16, 51, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 5, 56, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 12, 32, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 17, 38, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 17, 16, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 7, 36, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 19, 32, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 2, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 23, 46, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 9, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 14, 20, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 20, 24, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 15, 15, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 6, 33, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 21, 5, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 18, 31, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 21, 30, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 4, 36, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 15, 43, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 4, 50, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 47, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 6, 35, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 5, 14, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 16, 2, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 5, 10, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 16, 22, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 8, 55, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 19, 13, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 2, 0, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 15, 38, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 45, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 2, 0, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 16, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 5, 49, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 11, 42, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 22, 42, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 17, 36, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 9, 33, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 4, 36, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 4, 58, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 10, 46, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 19, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 1, 29, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 9, 1, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 5, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 3, 11, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 41, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 15, 35, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 27, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 6, 50, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 4, 0, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 1, 14, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 4, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 12, 18, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 15, 28, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 23, 13, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 8, 55, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 15, 49, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 22, 31, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 11, 36, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 4, 10, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 19, 21, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 11, 35, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 3, 54, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 6, 42, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 6, 56, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 2, 3, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 22, 8, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 11, 11, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 17, 41, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 34, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 3, 55, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 4, 15, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 8, 6, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 22, 8, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 11, 5, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 7, 14, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 10, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 13, 12, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 0, 28, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 22, 53, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 0, 34, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 23, 12, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 9, 37, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 5, 25, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 14, 0, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 21, 25, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 1, 58, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 15, 36, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 10, 47, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 9, 55, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 8, 1, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 3, 52, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 6, 35, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 37, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 12, 8, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 8, 29, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 21, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 18, 12, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 13, 30, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 3, 5, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 20, 59, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 59, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 17, 58, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 4, 11, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 6, 33, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 4, 59, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 22, 4, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 2, 6, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 14, 34, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 4, 0, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 18, 10, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 20, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 21, 11, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 5, 14, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 22, 57, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 38, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 9, 58, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 3, 12, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 4, 22, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 14, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 2, 17, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 16, 43, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 22, 7, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 7, 56, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 12, 3, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 21, 10, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 11, 39, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 15, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 7, 30, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 4, 49, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 16, 49, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 39, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 16, 23, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 19, 0, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 18, 3, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 2, 35, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 19, 21, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 15, 42, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 7, 30, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 29, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 21, 27, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 21, 33, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 9, 51, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 56, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 20, 36, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 17, 18, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 13, 3, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 22, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 8, 10, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 0, 52, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 5, 19, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 6, 30, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 23, 29, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 2, 11, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 0, 16, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 27, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 18, 4, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 10, 19, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 2, 10, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 14, 23, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 6, 1, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 4, 27, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 12, 23, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 53, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 5, 0, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 12, 51, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 6, 17, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 2, 32, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 8, 35, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 0, 16, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 11, 36, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 14, 18, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 7, 30, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 0, 42, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 17, 27, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 22, 47, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 21, 34, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 16, 34, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 14, 49, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 13, 46, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 3, 21, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 45, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 8, 16, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 15, 11, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 2, 47, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 5, 49, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 13, 1, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 6, 0, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 20, 53, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 23, 6, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 18, 32, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 16, 0, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 12, 26, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 5, 15, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 23, 28, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 6, 6, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 17, 11, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 15, 24, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 8, 21, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 48, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 11, 26, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 19, 51, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 22, 36, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 2, 41, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 22, 24, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 18, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 8, 56, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 5, 9, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 6, 30, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 32, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 19, 10, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 5, 20, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 18, 18, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 12, 3, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 6, 9, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 20, 20, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 8, 50, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 20, 58, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 19, 26, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 22, 51, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 10, 47, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 18, 52, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 13, 19, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 0, 52, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 18, 1, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 1, 15, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 23, 15, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 8, 53, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 20, 33, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 6, 49, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 4, 2, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 23, 58, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 11, 13, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 10, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 6, 5, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 6, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 11, 59, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 20, 22, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 5, 16, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 11, 26, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 15, 53, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 43, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 4, 5, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 18, 6, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 1, 5, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 19, 21, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 18, 7, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 9, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 1, 36, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 1, 14, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 22, 12, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 20, 25, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 7, 34, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 19, 48, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 23, 15, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 6, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 5, 45, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 18, 7, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 23, 52, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 6, 53, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 7, 22, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 23, 24, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 1, 14, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 59, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 8, 28, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 17, 9, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 11, 7, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 12, 46, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 11, 47, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 28, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 22, 58, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 33, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 20, 46, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 12, 27, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 19, 3, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 4, 23, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 21, 56, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 21, 13, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 18, 39, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 9, 0, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 8, 14, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 42, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 9, 10, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 9, 11, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 11, 7, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 5, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 22, 28, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 43, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 23, 44, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 23, 57, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 18, 45, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 7, 8, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 18, 3, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 0, 47, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 11, 19, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 20, 39, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 21, 5, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 10, 23, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 14, 48, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 49, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 2, 8, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 17, 37, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 7, 5, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 48, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 23, 55, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 15, 23, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 9, 40, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 4, 22, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 3, 36, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 3, 4, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 13, 47, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 22, 18, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 22, 15, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 36, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 7, 0, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 11, 7, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 2, 49, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 20, 41, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 12, 26, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 30, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 3, 45, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 14, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 20, 1, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 6, 44, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 19, 24, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 6, 24, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 17, 6, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 23, 44, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 5, 31, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 10, 54, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 6, 33, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 16, 2, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 10, 32, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 6, 46, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 12, 45, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 21, 6, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 1, 27, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 43, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 18, 12, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 5, 29, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 21, 54, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 5, 15, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 2, 56, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 32, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 21, 21, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 31, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 12, 3, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 9, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 4, 21, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 21, 55, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 18, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 22, 39, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 21, 59, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 1, 32, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 10, 7, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 15, 6, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 15, 56, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 4, 50, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 19, 45, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 40, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 4, 45, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 19, 29, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 15, 10, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 9, 10, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 11, 13, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 5, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 9, 10, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 1, 59, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 6, 16, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 23, 17, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 19, 10, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 22, 11, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 0, 22, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 2, 22, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 7, 21, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 0, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 14, 17, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 16, 42, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 8, 22, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 3, 51, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 11, 27, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 50, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 9, 27, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 14, 37, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 20, 21, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 18, 30, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 20, 42, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 11, 35, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 16, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 23, 51, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 9, 18, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 11, 23, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 27, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 0, 50, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 21, 26, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 15, 47, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 14, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 12, 59, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 18, 55, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 18, 11, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 8, 52, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 18, 47, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 32, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 23, 30, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 1, 43, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 19, 48, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 45, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 4, 0, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 16, 32, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 7, 28, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 18, 39, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 3, 14, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 6, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 18, 52, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 19, 5, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 1, 51, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 6, 26, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 1, 46, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 12, 22, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 21, 40, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 11, 14, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 2, 11, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 20, 59, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 14, 40, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 17, 25, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 3, 29, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 14, 46, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 3, 22, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 1, 0, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 22, 59, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 19, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 11, 33, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 36, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 9, 47, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 9, 16, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 14, 9, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 13, 2, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 12, 9, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 12, 29, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 3, 43, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 37, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 11, 32, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 23, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 2, 14, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 7, 45, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 23, 7, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 13, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 12, 34, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 6, 9, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 14, 58, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 3, 26, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 21, 41, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 20, 26, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 19, 37, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 22, 13, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 18, 19, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 19, 4, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 17, 39, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 4, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 15, 55, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 11, 33, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 10, 12, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 22, 25, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 6, 1, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 4, 56, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 0, 45, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 15, 41, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 6, 56, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 23, 36, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 7, 38, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 4, 36, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 19, 25, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 11, 35, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 17, 2, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 1, 47, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 23, 46, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 0, 19, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 18, 6, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 22, 37, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 16, 17, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 1, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 17, 41, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 1, 5, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 4, 42, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 5, 30, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 4, 38, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 6, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 6, 13, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 13, 0, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 17, 45, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 16, 44, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 6, 41, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 17, 0, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 14, 28, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 13, 29, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 7, 27, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 19, 12, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 11, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 14, 28, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 20, 10, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 57, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 18, 47, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 23, 52, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 8, 38, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 12, 42, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 11, 12, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 15, 37, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 11, 25, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 5, 44, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 7, 24, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 55, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 13, 26, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 0, 24, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 5, 44, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 4, 24, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 18, 55, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 26, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 5, 2, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 46, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 5, 19, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 12, 48, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 0, 12, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 44, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 17, 3, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 4, 23, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 4, 2, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 22, 44, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 23, 45, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 1, 33, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 3, 4, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 1, 58, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 1, 27, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 46, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 13, 39, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 8, 28, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 23, 18, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 2, 17, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 16, 58, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 6, 37, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 8, 6, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 13, 19, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 18, 51, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 15, 25, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 2, 31, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 13, 24, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 2, 40, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 10, 48, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 36, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 0, 1, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 9, 38, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 4, 18, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 22, 31, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 22, 44, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 58, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 22, 18, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 6, 32, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 15, 9, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 18, 51, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 8, 15, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 4, 1, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 0, 46, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 7, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 1, 10, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 6, 1, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 11, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 44, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 16, 55, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 28, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 23, 44, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 5, 49, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 0, 37, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 2, 16, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 9, 33, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 13, 54, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 12, 25, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 5, 41, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 9, 57, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 3, 39, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 15, 41, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 16, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 6, 25, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 14, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 17, 12, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 3, 1, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 4, 45, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 22, 58, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 5, 51, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 23, 51, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 2, 30, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 8, 49, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 5, 14, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 10, 39, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 21, 33, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 8, 32, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 9, 12, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 5, 16, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 14, 49, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 0, 18, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 8, 7, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 23, 25, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 8, 43, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 22, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 17, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 12, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 16, 55, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 18, 7, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 15, 27, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 8, 1, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 3, 38, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 2, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 23, 5, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 16, 9, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 9, 30, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 15, 47, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 2, 13, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 16, 41, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 0, 19, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 15, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 18, 29, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 3, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 14, 14, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 18, 40, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 18, 20, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 19, 38, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 10, 25, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 33, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 1, 1, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 21, 35, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 16, 10, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 7, 56, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 14, 46, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 35, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 21, 50, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 9, 12, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 18, 25, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 6, 31, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 10, 31, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 14, 9, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 19, 59, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 5, 29, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 14, 51, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 22, 52, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 16, 23, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 19, 18, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 17, 2, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 56, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 6, 12, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 11, 54, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 0, 55, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 3, 39, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 1, 19, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 13, 42, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 12, 30, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 10, 36, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 14, 23, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 2, 29, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 15, 55, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 17, 53, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 16, 27, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 21, 0, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 3, 57, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 17, 55, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 13, 30, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 2, 49, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 13, 39, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 14, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 17, 7, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 17, 33, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 16, 25, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 15, 35, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 23, 47, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 18, 38, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 15, 50, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 23, 33, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 20, 42, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 21, 7, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 49, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 2, 48, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 23, 12, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 7, 11, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 19, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 23, 24, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 21, 53, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 0, 48, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 11, 56, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 5, 3, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 7, 57, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 2, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 15, 43, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 11, 25, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 11, 20, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 32, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 20, 27, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 12, 26, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 14, 25, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 9, 0, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 6, 23, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 7, 9, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 8, 54, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 18, 48, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 1, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 8, 8, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 6, 35, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 33, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 13, 6, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 3, 32, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 5, 47, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 10, 0, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 10, 42, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 15, 21, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 16, 57, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 23, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 21, 29, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 22, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 11, 35, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 22, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 14, 50, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 8, 22, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 6, 27, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 21, 39, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 16, 0, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 21, 13, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 6, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 12, 5, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 8, 38, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 33, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 13, 16, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 7, 25, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 0, 56, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 22, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 12, 10, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 18, 56, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 15, 22, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 8, 56, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 16, 41, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 14, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 20, 31, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 4, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 6, 56, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 21, 27, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 20, 27, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 12, 42, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 18, 15, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 23, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 9, 36, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 12, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 19, 39, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 2, 26, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 20, 13, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 3, 0, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 23, 13, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 12, 15, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 17, 13, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 1, 32, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 16, 14, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 5, 0, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 14, 3, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 22, 42, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 20, 40, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 18, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 18, 23, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 47, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 15, 13, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 13, 15, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 4, 29, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 1, 23, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 22, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 7, 14, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 13, 45, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 1, 50, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 18, 38, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 19, 46, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 12, 40, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 9, 35, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 6, 26, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 16, 57, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 14, 7, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 8, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 5, 32, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 12, 24, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 22, 10, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 5, 19, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 9, 14, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 17, 58, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 1, 23, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 5, 43, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 23, 38, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 12, 29, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 2, 2, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 55, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 22, 6, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 0, 8, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 9, 21, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 18, 51, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 16, 17, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 21, 2, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 17, 21, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 21, 35, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 5, 41, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 15, 33, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 20, 31, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 22, 33, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 23, 30, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 14, 25, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 8, 56, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 36, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 20, 20, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 3, 54, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 9, 31, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 11, 45, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 21, 56, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 13, 18, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 7, 33, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 8, 33, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 6, 12, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 26, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 15, 42, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 13, 9, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 15, 58, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 4, 21, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 20, 51, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 4, 53, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 3, 51, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 3, 14, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 16, 22, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 1, 56, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 22, 57, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 16, 45, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 2, 39, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 2, 21, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 4, 19, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 38, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 8, 42, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 2, 34, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 22, 11, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 9, 26, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 9, 18, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 44, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 9, 44, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 3, 27, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 12, 38, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 11, 37, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 5, 53, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 5, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 0, 24, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 21, 7, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 23, 52, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 17, 28, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 9, 0, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 6, 29, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 9, 7, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 19, 37, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 22, 35, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 21, 7, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 9, 3, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 5, 55, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 11, 0, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 19, 34, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 3, 31, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 3, 53, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 11, 32, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 13, 5, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 4, 27, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 15, 24, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 20, 16, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 7, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 1, 11, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 17, 51, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 9, 24, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 11, 49, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 1, 23, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 19, 25, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 22, 30, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 20, 19, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 4, 13, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 7, 28, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 22, 39, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 17, 2, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 9, 58, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 54, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 11, 23, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 18, 25, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 16, 45, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 3, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 19, 18, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 1, 36, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 14, 20, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 23, 19, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 21, 37, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 1, 30, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 2, 49, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 14, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 13, 31, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 55, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 16, 42, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 19, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 11, 31, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 28, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 22, 43, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 55, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 18, 57, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 56, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 2, 44, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 18, 1, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 14, 34, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 1, 39, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 16, 10, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 4, 21, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 10, 25, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 20, 8, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 15, 14, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 11, 32, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 1, 37, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 6, 20, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 4, 6, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 4, 18, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 2, 51, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 48, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 7, 44, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 42, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 19, 22, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 13, 55, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 16, 23, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 21, 24, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 3, 18, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 17, 21, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 1, 38, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 8, 55, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 4, 44, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 12, 14, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 6, 11, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 9, 19, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 14, 8, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 15, 33, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 22, 13, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 2, 4, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 7, 36, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 21, 35, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 15, 29, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 11, 40, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 22, 15, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 23, 8, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 29, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 15, 48, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 19, 35, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 9, 25, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 7, 13, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 10, 8, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 8, 20, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 17, 51, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 30, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 15, 14, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 14, 22, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 16, 9, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 2, 1, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 16, 8, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 5, 5, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 7, 7, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 5, 29, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 0, 7, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 15, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 22, 45, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 39, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 7, 35, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 20, 7, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 14, 8, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 12, 45, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 2, 4, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 14, 15, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 12, 26, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 18, 0, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 6, 57, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 9, 4, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 9, 53, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 2, 34, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 10, 39, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 7, 37, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 9, 0, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 4, 20, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 18, 43, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 35, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 19, 57, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 20, 7, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 14, 52, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 10, 49, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 24, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 8, 31, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 8, 26, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 8, 54, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 41, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 10, 2, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 1, 55, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 4, 46, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 58, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 15, 54, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 57, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 1, 44, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 0, 30, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 13, 27, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 6, 5, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 3, 50, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 8, 59, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 23, 35, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 21, 46, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 18, 39, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 26, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 21, 59, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 21, 33, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 12, 13, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 32, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 3, 19, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 5, 57, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 11, 15, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 12, 30, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 19, 9, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 21, 57, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 2, 41, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 18, 14, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 3, 42, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 2, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 13, 20, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 20, 3, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 4, 55, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 21, 8, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 15, 41, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 12, 44, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 9, 19, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 7, 37, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 6, 38, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 55, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 20, 54, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 41, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 20, 57, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 4, 34, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 3, 16, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 5, 58, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 16, 58, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 51, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 12, 27, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 18, 0, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 11, 36, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 14, 55, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 14, 47, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 21, 8, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 4, 11, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 6, 29, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 2, 58, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 22, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 23, 18, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 4, 40, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 17, 57, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 16, 10, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 15, 45, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 23, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 10, 46, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 10, 2, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 4, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 10, 44, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 11, 53, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 5, 53, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 7, 13, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 14, 38, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 2, 10, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 3, 7, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 18, 44, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 18, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 17, 32, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 13, 8, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 21, 40, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 9, 35, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 23, 22, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 17, 23, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 18, 37, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 31, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 21, 47, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 22, 51, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 7, 53, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 0, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 2, 50, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 11, 10, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 20, 4, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 12, 32, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 10, 55, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 15, 47, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 21, 3, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 30, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 12, 57, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 14, 53, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 3, 33, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 42, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 5, 32, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 15, 38, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 15, 43, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 6, 34, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 19, 17, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 4, 55, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 5, 9, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 18, 41, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 21, 13, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 9, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 2, 28, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 7, 26, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 13, 38, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 3, 13, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 0, 10, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 3, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 4, 22, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 2, 28, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 4, 31, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 1, 22, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 2, 39, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 9, 33, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 13, 42, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 9, 11, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 8, 55, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 1, 3, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 4, 39, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 19, 14, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 10, 8, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 20, 1, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 13, 10, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 20, 18, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 19, 21, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 6, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 15, 27, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 13, 1, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 17, 3, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 3, 17, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 12, 52, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 4, 37, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 13, 21, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 3, 42, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 7, 39, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 4, 20, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 9, 50, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 1, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 20, 48, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 22, 11, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 4, 47, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 41, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 6, 51, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 37, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 11, 36, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 15, 22, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 14, 33, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 20, 43, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 11, 52, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 59, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 1, 52, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 20, 53, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 20, 13, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 14, 27, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 14, 4, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 13, 13, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 11, 22, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 21, 53, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 16, 59, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 37, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 12, 16, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 8, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 11, 37, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 0, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 15, 24, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 14, 54, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 23, 33, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 17, 14, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 22, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 6, 46, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 14, 56, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 17, 5, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 19, 21, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 6, 29, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 16, 13, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 14, 2, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 22, 3, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 8, 56, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 21, 57, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 12, 17, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 11, 12, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 7, 35, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 12, 54, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 43, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 18, 36, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 14, 36, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 19, 33, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 4, 4, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 22, 28, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 20, 48, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 19, 31, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 15, 14, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 18, 47, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 22, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 5, 10, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 23, 33, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 23, 0, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 23, 54, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 3, 45, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 6, 10, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 14, 20, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 6, 19, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 3, 7, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 7, 13, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 5, 25, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 14, 48, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 13, 33, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 2, 23, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 7, 11, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 0, 3, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 12, 26, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 21, 21, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 21, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 34, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 3, 10, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 4, 50, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 17, 51, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 1, 53, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 10, 21, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 20, 37, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 6, 19, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 2, 16, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 1, 40, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 5, 3, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 16, 3, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 14, 16, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 18, 42, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 3, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 18, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 9, 28, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 9, 49, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 7, 5, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 1, 51, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 20, 29, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 6, 2, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 43, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 3, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 59, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 13, 7, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 20, 55, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 19, 3, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 11, 49, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 15, 41, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 10, 12, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 23, 53, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 2, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 0, 35, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 11, 8, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 6, 53, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 5, 2, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 23, 45, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 46, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 7, 18, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 2, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 7, 44, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 6, 30, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 54, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 10, 27, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 17, 56, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 1, 22, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 20, 39, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 10, 36, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 10, 27, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 16, 39, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 7, 32, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 9, 10, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 1, 20, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 3, 46, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 21, 29, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 13, 19, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 13, 56, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 10, 2, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 9, 23, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 2, 0, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 11, 49, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 2, 34, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 14, 14, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 5, 58, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 0, 0, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 1, 4, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 7, 32, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 11, 28, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 23, 40, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 7, 35, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 10, 28, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 4, 10, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 2, 20, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 19, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 3, 16, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 52, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 5, 23, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 14, 52, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 23, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 23, 33, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 6, 55, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 20, 55, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 12, 29, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 18, 27, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 0, 12, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 12, 20, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 14, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 0, 30, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 0, 25, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 21, 50, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 3, 51, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 11, 57, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 19, 41, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 8, 54, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 12, 26, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 22, 37, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 3, 43, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 10, 11, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 13, 27, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 19, 21, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 3, 23, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 11, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 6, 55, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 23, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 11, 45, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 9, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 12, 44, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 18, 33, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 23, 44, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 10, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 15, 58, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 10, 17, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 0, 56, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 1, 1, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 3, 20, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 6, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 18, 28, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 21, 29, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 16, 32, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 0, 2, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 9, 19, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 20, 33, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 10, 10, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 11, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 2, 33, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 28, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 19, 34, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 7, 41, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 12, 51, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 3, 1, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 21, 2, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 20, 3, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 12, 37, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 21, 6, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 10, 42, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 18, 7, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 7, 20, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 19, 58, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 5, 15, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 53, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 1, 4, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 6, 33, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 4, 24, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 18, 25, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 2, 26, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 10, 36, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 13, 52, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 14, 12, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 23, 55, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 26, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 19, 40, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 4, 1, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 22, 4, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 3, 40, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 11, 54, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 33, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 12, 14, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 1, 37, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 1, 54, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 22, 31, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 16, 38, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 39, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 10, 41, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 6, 51, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 17, 27, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 7, 39, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 12, 55, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 11, 17, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 12, 13, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 4, 20, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 6, 32, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 21, 49, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 17, 32, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 43, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 6, 52, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 4, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 19, 30, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 54, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 17, 42, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 3, 30, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 9, 18, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 19, 43, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 4, 7, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 17, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 13, 23, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 44, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 19, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 52, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 23, 14, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 22, 37, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 17, 6, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 59, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 6, 13, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 5, 0, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 9, 44, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 7, 4, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 14, 37, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 13, 57, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 6, 30, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 14, 13, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 9, 15, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 17, 14, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 9, 1, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 2, 3, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 13, 29, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 7, 34, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 0, 36, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 20, 58, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 16, 47, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 39, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 22, 22, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 33, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 19, 37, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 23, 59, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 17, 15, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 20, 17, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 1, 59, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 13, 25, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 1, 45, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 4, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 3, 58, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 23, 20, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 9, 40, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 6, 40, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 7, 30, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 21, 52, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 23, 20, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 42, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 17, 31, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 8, 21, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 9, 5, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 6, 58, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 23, 38, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 4, 17, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 1, 28, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 4, 28, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 13, 13, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 0, 57, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 17, 39, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 7, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 11, 25, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 9, 1, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 18, 10, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 2, 29, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 8, 56, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 46, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 14, 15, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 20, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 16, 29, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 14, 21, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 23, 8, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 20, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 11, 15, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 4, 1, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 9, 59, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 21, 15, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 22, 15, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 1, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 1, 17, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 5, 58, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 11, 12, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 30, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 18, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 18, 45, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 17, 58, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 16, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 9, 29, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 15, 12, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 8, 59, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 15, 45, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 22, 9, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 17, 38, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 5, 47, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 2, 49, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 23, 25, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 3, 14, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 20, 8, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 23, 22, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 11, 49, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 3, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 18, 11, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 2, 46, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 19, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 3, 16, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 17, 45, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 5, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 10, 12, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 1, 53, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 6, 10, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 11, 32, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 6, 18, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 23, 33, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 19, 56, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 0, 24, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 22, 54, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 21, 9, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 9, 11, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 23, 32, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 13, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 56, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 22, 9, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 1, 30, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 9, 39, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 56, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 6, 48, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 11, 57, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 7, 16, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 3, 21, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 23, 43, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 15, 24, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 19, 22, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 53, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 7, 40, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 13, 43, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 22, 32, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 4, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 15, 0, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 5, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 16, 40, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 22, 8, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 18, 6, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 9, 56, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 12, 22, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 21, 2, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 7, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 21, 42, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 2, 14, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 20, 23, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 5, 36, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 19, 41, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 11, 12, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 2, 24, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 16, 42, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 10, 14, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 23, 57, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 3, 59, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 14, 28, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 8, 39, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 23, 59, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 59, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 3, 0, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 21, 18, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 1, 22, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 12, 48, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 1, 52, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 19, 34, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 11, 22, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 21, 33, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 8, 1, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 13, 43, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 23, 25, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 1, 57, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 15, 10, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 13, 41, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 20, 28, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 15, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 1, 7, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 17, 13, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 19, 36, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 8, 19, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 16, 40, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 17, 24, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 4, 5, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 13, 31, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 9, 23, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 22, 54, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 5, 21, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 22, 7, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 18, 0, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 19, 32, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 12, 47, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 21, 39, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 12, 42, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 5, 31, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 22, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 14, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 0, 49, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 20, 52, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 3, 57, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 4, 39, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 14, 5, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 3, 35, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 14, 3, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 9, 2, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 23, 35, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 13, 6, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 14, 58, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 10, 41, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 12, 51, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 6, 5, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 1, 22, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 3, 36, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 15, 55, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 20, 3, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 3, 1, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 16, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 15, 15, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 10, 6, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 19, 26, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 15, 17, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 9, 15, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 28, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 13, 49, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 5, 39, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 14, 37, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 17, 21, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 9, 26, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 18, 54, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 16, 3, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 1, 43, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 19, 52, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 10, 50, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 17, 48, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 11, 38, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 17, 13, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 1, 40, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 2, 47, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 3, 35, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 7, 38, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 5, 5, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 15, 9, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 4, 40, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 18, 6, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 2, 4, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 15, 16, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 12, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 1, 7, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 37, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 21, 14, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 9, 18, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 13, 55, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 24, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 11, 59, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 0, 16, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 9, 32, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 23, 13, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 2, 53, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 2, 35, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 21, 20, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 14, 49, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 8, 35, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 12, 41, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 11, 47, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 4, 46, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 22, 18, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 5, 22, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 12, 26, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 38, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 18, 54, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 17, 35, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 6, 23, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 19, 57, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 18, 3, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 13, 12, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 4, 18, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 19, 48, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 10, 25, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 21, 58, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 5, 44, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 1, 36, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 21, 20, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 4, 19, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 7, 34, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 2, 26, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 12, 28, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 16, 25, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 21, 3, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 15, 8, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 10, 19, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 20, 1, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 22, 59, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 18, 25, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 17, 30, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 4, 32, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 20, 13, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 22, 30, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 19, 44, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 3, 54, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 10, 29, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 1, 23, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 11, 9, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 2, 2, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 3, 27, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 6, 41, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 20, 11, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 20, 6, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 8, 24, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 5, 3, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 2, 38, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 13, 21, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 18, 41, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 6, 57, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 1, 12, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 4, 42, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 19, 52, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 18, 22, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 12, 21, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 22, 50, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 58, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 2, 41, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 18, 6, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 1, 26, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 21, 44, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 59, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 11, 39, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 14, 51, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 13, 54, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 34, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 13, 36, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 5, 57, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 54, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 9, 55, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 3, 2, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 21, 15, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 11, 4, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 17, 45, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 18, 29, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 14, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 20, 46, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 2, 15, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 10, 54, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 16, 37, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 20, 15, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 8, 20, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 22, 7, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 4, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 22, 0, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 20, 23, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 14, 42, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 55, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 2, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 14, 8, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 6, 59, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 9, 30, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 17, 58, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 10, 59, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 10, 34, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 8, 11, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 11, 19, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 5, 59, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 1, 5, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 7, 21, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 19, 19, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 11, 50, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 14, 16, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 2, 44, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 9, 32, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 20, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 11, 3, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 21, 36, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 6, 22, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 8, 55, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 18, 53, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 5, 1, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 10, 48, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 7, 38, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 7, 2, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 0, 46, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 1, 16, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 4, 17, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 12, 46, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 31, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 10, 48, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 13, 53, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 11, 2, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 5, 0, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 9, 35, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 5, 50, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 7, 31, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 5, 54, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 7, 37, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 8, 53, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 10, 53, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 3, 46, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 3, 23, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 14, 14, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 23, 13, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 21, 59, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 20, 59, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 11, 21, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 21, 42, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 49, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 17, 31, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 41, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 13, 2, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 3, 26, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 20, 25, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 9, 32, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 10, 24, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 5, 41, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 7, 46, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 8, 53, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 18, 45, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 24, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 3, 58, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 3, 13, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 18, 45, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 57, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 23, 49, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 16, 23, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 4, 5, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 21, 13, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 7, 46, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 13, 37, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 19, 32, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 34, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 23, 54, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 16, 51, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 23, 16, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 1, 12, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 7, 40, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 8, 53, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 7, 40, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 19, 6, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 17, 14, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 5, 52, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 3, 28, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 18, 7, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 15, 57, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 12, 0, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 20, 42, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 5, 46, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 13, 0, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 49, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 20, 7, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 13, 4, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 0, 5, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 20, 0, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 1, 30, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 15, 48, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 21, 3, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 6, 2, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 6, 35, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 32, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 21, 3, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 18, 39, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 15, 46, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 10, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 17, 52, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 22, 39, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 9, 52, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 54, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 20, 31, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 4, 11, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 23, 54, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 23, 32, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 6, 22, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 15, 17, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 19, 18, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 19, 35, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 11, 10, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 8, 34, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 2, 19, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 39, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 14, 28, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 16, 22, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 6, 25, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 18, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 19, 7, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 19, 20, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 2, 36, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 11, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 16, 39, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 9, 29, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 1, 29, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 39, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 3, 12, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 10, 39, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 18, 46, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 4, 22, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 18, 5, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 11, 47, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 4, 42, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 4, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 21, 31, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 0, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 19, 23, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 5, 30, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 0, 46, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 19, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 7, 21, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 5, 48, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 12, 51, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 18, 38, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 9, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 10, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 20, 40, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 55, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 18, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 1, 59, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 12, 27, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 10, 26, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 9, 24, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 21, 19, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 9, 6, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 18, 4, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 7, 22, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 38, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 16, 51, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 42, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 4, 33, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 24, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 3, 15, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 25, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 21, 23, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 5, 31, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 10, 38, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 4, 11, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 9, 22, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 12, 2, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 16, 44, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 10, 29, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 5, 38, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 27, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 23, 15, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 17, 54, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 18, 58, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_TimeRegistrations_EmployeeId",
                table: "TimeRegistrations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeRegistrations_Employees_EmployeeId",
                table: "TimeRegistrations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeRegistrations_Employees_EmployeeId",
                table: "TimeRegistrations");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_TimeRegistrations_EmployeeId",
                table: "TimeRegistrations");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 44, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 9, 55, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 26, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 20, 16, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 20, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 13, 27, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 1, 0, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 17, 59, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 9, 59, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 3, 25, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 12, 36, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 15, 52, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 5, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 6, 10, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 15, 54, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 12, 4, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 11, 39, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 0, 46, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 10, 20, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 14, 24, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 7, 39, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 4, 12, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 12, 39, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 15, 7, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 2, 29, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 20, 40, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 12, 27, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 23, 14, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 6, 47, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 20, 50, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 5, 22, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 14, 59, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 22, 34, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 7, 57, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 42, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 13, 32, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 34, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 23, 17, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 20, 30, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 23, 18, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 4, 30, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 19, 32, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 1, 36, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 52, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 7, 30, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 20, 39, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 2, 38, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 14, 32, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 43, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 2, 9, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 12, 36, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 22, 19, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 13, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 17, 5, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 21, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 20, 33, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 7, 42, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 19, 10, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 0, 30, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 19, 4, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 14, 52, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 23, 46, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 17, 47, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 22, 46, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 20, 59, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 22, 37, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 18, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 6, 4, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 37, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 18, 39, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 13, 55, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 6, 48, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 14, 9, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 19, 6, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 49, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 10, 27, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 17, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 4, 27, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 6, 58, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 9, 38, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 50, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 22, 17, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 17, 13, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 23, 33, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 20, 34, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 14, 42, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 20, 36, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 20, 9, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 3, 11, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 5, 14, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 17, 41, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 10, 20, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 18, 41, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 7, 32, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 6, 46, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 1, 5, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 23, 16, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 12, 33, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 14, 1, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 19, 10, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 9, 45, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 5, 58, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 0, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 18, 8, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 4, 5, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 23, 25, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 23, 5, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 16, 7, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 5, 59, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 15, 9, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 7, 10, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 17, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 19, 7, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 14, 21, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 14, 52, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 7, 22, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 5, 57, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 9, 33, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 10, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 8, 33, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 15, 25, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 22, 42, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 55, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 14, 40, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 15, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 2, 40, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 1, 15, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 11, 33, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 39, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 5, 0, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 4, 38, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 3, 39, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 23, 59, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 13, 56, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 6, 42, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 23, 18, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 13, 16, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 2, 33, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 4, 25, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 13, 52, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 6, 36, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 6, 47, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 8, 58, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 21, 17, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 6, 12, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 22, 46, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 1, 57, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 3, 23, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 8, 6, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 11, 15, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 21, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 4, 24, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 5, 6, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 10, 55, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 30, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 19, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 11, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 16, 3, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 2, 59, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 4, 49, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 21, 34, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 13, 22, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 31, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 16, 19, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 17, 50, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 19, 34, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 20, 43, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 4, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 22, 33, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 4, 40, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 8, 4, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 8, 7, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 1, 25, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 8, 18, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 2, 43, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 1, 6, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 26, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 14, 2, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 15, 8, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 2, 49, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 12, 20, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 11, 55, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 7, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 19, 1, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 22, 35, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 16, 45, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 20, 27, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 11, 56, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 19, 50, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 14, 50, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 28, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 13, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 15, 18, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 21, 42, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 19, 50, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 17, 59, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 16, 25, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 1, 52, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 52, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 17, 56, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 22, 7, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 13, 47, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 42, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 4, 25, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 7, 45, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 0, 31, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 15, 17, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 19, 12, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 1, 3, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 6, 48, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 20, 27, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 21, 50, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 21, 19, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 17, 35, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 20, 15, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 39, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 13, 27, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 21, 4, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 20, 58, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 13, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 11, 12, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 42, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 23, 2, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 14, 28, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 21, 2, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 46, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 23, 54, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 6, 9, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 10, 54, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 7, 11, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 2, 19, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 46, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 16, 11, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 6, 38, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 20, 8, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 16, 9, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 11, 33, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 17, 34, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 23, 12, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 20, 5, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 7, 48, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 12, 21, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 12, 51, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 16, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 8, 33, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 12, 15, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 21, 18, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 3, 12, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 9, 44, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 17, 54, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 23, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 42, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 16, 41, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 3, 50, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 12, 21, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 0, 46, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 8, 28, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 59, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 6, 58, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 18, 34, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 19, 46, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 14, 22, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 8, 30, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 42, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 17, 58, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 4, 3, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 10, 47, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 49, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 18, 30, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 2, 38, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 8, 11, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 3, 24, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 23, 2, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 14, 34, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 12, 32, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 13, 22, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 15, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 9, 30, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 23, 24, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 21, 22, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 21, 19, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 22, 7, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 5, 51, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 11, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 1, 35, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 13, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 17, 21, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 17, 57, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 10, 27, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 1, 16, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 5, 38, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 5, 4, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 19, 51, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 9, 52, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 23, 37, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 3, 31, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 3, 22, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 22, 10, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 19, 4, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 13, 10, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 21, 21, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 42, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 4, 47, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 20, 53, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 2, 34, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 4, 7, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 15, 20, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 10, 51, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 11, 25, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 6, 48, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 8, 46, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 26, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 2, 6, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 2, 17, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 4, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 18, 41, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 21, 56, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 20, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 3, 27, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 33, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 22, 42, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 11, 34, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 23, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 22, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 11, 13, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 20, 1, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 5, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 6, 41, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 19, 9, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 3, 57, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 2, 59, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 22, 37, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 12, 0, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 0, 17, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 23, 34, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 23, 17, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 0, 27, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 15, 41, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 2, 39, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 21, 19, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 13, 19, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 12, 22, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 9, 14, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 5, 3, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 17, 17, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 2, 47, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 2, 11, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 34, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 13, 19, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 0, 27, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 5, 32, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 18, 49, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 3, 16, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 18, 45, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 16, 30, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 19, 8, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 11, 18, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 11, 44, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 14, 13, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 13, 25, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 5, 2, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 19, 32, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 9, 3, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 12, 3, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 11, 24, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 21, 4, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 20, 27, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 21, 14, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 23, 1, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 22, 56, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 4, 1, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 3, 17, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 22, 59, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 53, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 7, 19, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 4, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 12, 10, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 7, 50, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 4, 20, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 10, 35, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 23, 51, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 12, 57, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 3, 20, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 14, 24, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 11, 58, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 37, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 6, 48, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 12, 33, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 13, 23, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 13, 58, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 16, 33, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 10, 7, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 12, 6, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 22, 14, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 20, 45, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 27, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 20, 15, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 5, 52, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 20, 52, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 23, 51, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 5, 0, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 4, 42, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 23, 6, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 3, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 21, 58, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 51, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 2, 52, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 16, 6, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 10, 15, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 2, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 11, 13, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 23, 31, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 43, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 10, 38, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 2, 28, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 11, 59, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 16, 45, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 7, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 5, 45, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 14, 19, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 21, 47, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 5, 28, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 7, 38, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 22, 46, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 0, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 9, 8, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 22, 59, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 10, 59, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 1, 16, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 11, 10, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 17, 44, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 21, 16, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 18, 1, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 13, 40, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 35, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 15, 45, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 2, 36, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 15, 57, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 19, 4, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 23, 22, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 6, 46, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 7, 59, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 47, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 19, 48, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 10, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 20, 54, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 1, 2, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 5, 57, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 9, 31, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 17, 55, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 16, 32, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 14, 44, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 8, 29, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 15, 50, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 23, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 18, 25, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 7, 32, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 1, 46, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 5, 58, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 21, 28, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 41, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 20, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 9, 23, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 16, 13, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 22, 3, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 22, 10, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 14, 56, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 2, 42, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 1, 4, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 21, 41, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 2, 30, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 13, 11, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 22, 23, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 13, 21, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 14, 39, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 11, 49, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 7, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 13, 2, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 22, 28, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 2, 40, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 4, 18, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 7, 27, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 14, 26, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 1, 11, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 22, 56, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 18, 36, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 5, 24, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 13, 11, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 13, 32, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 10, 25, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 18, 56, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 41, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 1, 38, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 30, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 0, 47, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 11, 3, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 6, 32, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 21, 5, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 7, 43, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 3, 35, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 10, 26, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 14, 6, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 20, 52, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 13, 28, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 4, 20, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 4, 20, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 9, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 11, 6, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 5, 41, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 22, 57, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 14, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 22, 59, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 12, 7, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 13, 55, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 22, 21, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 9, 49, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 23, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 20, 5, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 10, 23, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 22, 11, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 1, 35, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 9, 36, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 56, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 20, 53, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 23, 44, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 20, 8, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 8, 22, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 21, 20, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 8, 49, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 1, 49, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 1, 40, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 20, 57, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 9, 45, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 17, 17, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 4, 12, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 8, 58, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 19, 14, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 21, 42, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 12, 36, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 8, 4, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 10, 41, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 17, 54, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 23, 5, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 20, 8, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 3, 55, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 20, 49, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 17, 6, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 0, 18, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 3, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 1, 31, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 10, 37, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 6, 33, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 5, 11, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 2, 34, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 12, 27, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 6, 33, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 1, 44, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 19, 48, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 9, 56, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 13, 19, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 22, 52, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 10, 22, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 1, 8, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 21, 7, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 3, 30, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 19, 32, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 22, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 10, 53, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 15, 36, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 11, 2, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 9, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 23, 15, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 3, 1, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 16, 38, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 58, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 14, 36, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 6, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 1, 15, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 2, 11, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 18, 11, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 38, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 18, 29, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 58, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 14, 58, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 12, 58, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 17, 13, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 29, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 18, 47, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 14, 12, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 5, 35, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 48, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 15, 24, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 45, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 13, 28, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 5, 18, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 7, 2, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 20, 52, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 14, 26, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 16, 22, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 5, 39, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 18, 37, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 11, 48, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 17, 14, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 17, 36, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 15, 7, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 17, 33, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 19, 19, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 15, 42, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 19, 39, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 7, 43, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 6, 20, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 14, 9, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 21, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 10, 53, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 14, 39, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 10, 40, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 4, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 22, 6, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 21, 46, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 37, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 0, 17, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 23, 25, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 42, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 12, 4, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 20, 38, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 9, 7, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 23, 20, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 4, 54, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 11, 30, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 19, 35, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 23, 40, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 10, 50, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 17, 4, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 3, 38, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 36, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 13, 26, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 10, 23, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 12, 1, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 19, 15, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 8, 14, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 45, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 26, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 20, 38, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 3, 6, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 5, 53, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 11, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 9, 39, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 7, 57, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 7, 11, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 3, 32, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 12, 18, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 12, 8, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 8, 42, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 17, 20, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 23, 44, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 19, 27, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 17, 34, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 8, 20, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 2, 36, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 12, 51, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 20, 5, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 2, 0, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 7, 39, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 1, 55, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 15, 2, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 2, 19, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 23, 35, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 23, 3, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 18, 53, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 3, 41, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 10, 32, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 21, 30, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 8, 55, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 6, 54, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 13, 43, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 8, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 10, 29, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 4, 38, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 9, 31, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 4, 30, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 9, 27, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 19, 19, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 6, 40, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 9, 40, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 12, 35, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 18, 58, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 0, 17, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 10, 52, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 21, 45, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 17, 14, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 6, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 8, 25, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 4, 32, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 15, 17, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 23, 5, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 3, 23, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 12, 28, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 20, 51, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 3, 31, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 5, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 22, 44, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 17, 24, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 22, 46, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 19, 10, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 15, 44, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 19, 48, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 20, 9, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 1, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 11, 42, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 11, 26, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 20, 20, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 15, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 10, 48, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 44, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 0, 51, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 1, 59, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 10, 6, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 8, 3, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 13, 0, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 4, 9, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 7, 16, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 11, 19, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 3, 16, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 7, 20, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 16, 20, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 12, 20, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 20, 37, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 15, 53, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 3, 14, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 13, 58, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 10, 38, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 20, 15, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 20, 35, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 17, 29, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 21, 36, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 15, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 19, 22, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 31, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 11, 25, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 3, 21, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 17, 58, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 7, 19, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 8, 34, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 4, 7, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 15, 59, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 21, 8, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 15, 13, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 22, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 6, 24, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 3, 13, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 15, 37, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 15, 50, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 0, 0, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 7, 34, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 9, 2, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 12, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 9, 57, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 3, 11, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 17, 16, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 5, 16, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 17, 7, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 16, 38, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 16, 50, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 19, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 10, 14, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 2, 32, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 10, 33, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 48, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 44, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 18, 20, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 2, 17, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 22, 11, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 3, 5, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 8, 38, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 23, 48, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 11, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 12, 40, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 2, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 12, 6, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 13, 30, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 23, 7, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 6, 18, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 2, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 7, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 19, 31, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 12, 34, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 14, 3, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 4, 13, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 22, 35, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 16, 31, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 19, 16, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 10, 41, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 15, 6, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 1, 13, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 12, 1, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 28, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 1, 54, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 21, 49, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 10, 26, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 15, 29, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 11, 42, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 35, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 18, 37, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 13, 53, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 11, 1, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 3, 6, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 22, 3, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 19, 38, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 18, 58, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 16, 54, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 0, 21, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 5, 30, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 20, 50, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 12, 25, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 22, 6, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 2, 53, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 22, 28, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 10, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 22, 51, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 9, 49, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 3, 2, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 8, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 15, 5, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 8, 40, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 17, 41, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 26, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 11, 47, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 19, 14, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 1, 2, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 9, 13, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 11, 27, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 9, 49, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 15, 0, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 1, 56, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 23, 41, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 22, 21, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 20, 23, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 22, 1, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 8, 22, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 2, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 7, 3, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 20, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 2, 49, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 49, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 4, 22, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 45, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 10, 0, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 5, 1, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 18, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 23, 14, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 22, 59, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 21, 24, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 22, 14, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 30, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 13, 29, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 18, 22, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 17, 49, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 2, 45, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 0, 32, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 3, 11, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 21, 7, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 15, 13, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 9, 37, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 23, 46, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 20, 46, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 12, 36, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 12, 7, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 7, 37, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 21, 5, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 20, 36, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 2, 34, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 19, 2, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 14, 43, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 3, 55, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 23, 25, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 1, 24, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 12, 20, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 23, 10, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 20, 40, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 20, 38, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 4, 39, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 22, 19, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 5, 10, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 8, 40, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 21, 13, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 2, 56, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 20, 4, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 46, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 9, 5, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 20, 52, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 11, 19, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 23, 57, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 8, 27, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 5, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 19, 27, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 4, 16, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 1, 20, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 10, 59, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 12, 43, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 11, 33, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 2, 41, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 8, 19, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 19, 12, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 21, 7, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 3, 22, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 10, 14, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 4, 3, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 10, 20, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 8, 20, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 7, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 18, 49, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 57, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 6, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 3, 43, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 5, 28, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 8, 56, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 12, 30, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 22, 36, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 22, 2, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 42, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 12, 53, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 9, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 20, 27, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 40, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 5, 53, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 4, 2, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 3, 58, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 21, 36, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 18, 11, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 8, 28, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 7, 45, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 11, 11, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 22, 0, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 13, 40, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 6, 6, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 43, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 14, 36, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 5, 17, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 19, 11, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 2, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 23, 59, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 6, 12, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 16, 22, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 19, 52, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 22, 4, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 15, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 7, 48, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 1, 25, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 21, 4, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 22, 34, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 20, 41, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 8, 50, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 11, 46, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 6, 48, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 23, 18, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 5, 50, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 4, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 9, 14, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 4, 57, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 11, 2, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 22, 33, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 17, 40, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 23, 21, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 59, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 1, 14, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 19, 44, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 23, 36, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 20, 41, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 13, 36, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 9, 18, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 48, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 1, 39, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 3, 42, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 8, 39, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 54, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 8, 2, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 6, 39, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 17, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 3, 12, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 4, 19, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 4, 49, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 22, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 18, 29, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 9, 32, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 11, 47, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 16, 55, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 47, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 12, 56, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 17, 7, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 9, 18, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 9, 27, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 5, 11, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 3, 38, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 12, 14, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 9, 21, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 0, 46, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 43, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 10, 58, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 13, 3, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 10, 12, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 1, 13, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 2, 53, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 2, 55, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 15, 4, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 23, 8, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 1, 0, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 4, 48, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 0, 30, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 23, 21, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 22, 56, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 20, 26, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 0, 42, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 2, 1, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 1, 37, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 18, 1, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 14, 40, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 19, 8, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 7, 7, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 15, 40, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 1, 10, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 17, 9, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 23, 25, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 10, 56, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 21, 42, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 12, 15, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 2, 32, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 4, 52, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 8, 59, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 8, 32, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 22, 1, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 10, 24, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 0, 57, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 5, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 8, 18, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 20, 41, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 6, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 8, 15, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 18, 32, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 18, 57, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 19, 10, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 14, 16, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 18, 7, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 9, 4, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 18, 54, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 8, 25, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 37, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 6, 30, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 1, 17, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 12, 2, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 16, 12, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 7, 16, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 1, 56, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 22, 41, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 19, 23, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 17, 12, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 6, 46, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 7, 32, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 2, 36, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 23, 3, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 0, 25, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 4, 11, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 2, 54, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 8, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 10, 30, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 8, 48, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 16, 52, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 22, 17, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 15, 52, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 2, 36, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 4, 58, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 10, 51, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 14, 36, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 18, 21, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 16, 57, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 9, 1, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 21, 20, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 13, 35, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 3, 10, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 3, 16, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 53, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 13, 38, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 23, 21, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 4, 37, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 59, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 2, 49, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 59, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 20, 15, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 6, 43, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 8, 45, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 13, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 0, 9, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 2, 41, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 19, 22, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 48, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 15, 28, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 22, 39, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 20, 52, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 3, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 12, 23, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 42, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 5, 9, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 21, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 2, 44, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 28, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 13, 58, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 7, 23, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 9, 29, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 15, 57, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 20, 56, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 9, 56, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 1, 33, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 12, 54, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 6, 25, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 14, 44, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 15, 1, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 7, 47, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 16, 58, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 2, 32, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 20, 49, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 17, 56, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 23, 43, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 5, 23, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 4, 17, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 11, 0, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 12, 11, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 13, 20, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 12, 31, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 20, 4, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 0, 12, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 4, 12, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 2, 34, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 16, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 3, 25, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 52, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 9, 37, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 13, 34, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 7, 58, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 10, 6, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 8, 32, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 23, 55, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 5, 9, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 3, 20, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 7, 2, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 12, 11, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 2, 7, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 11, 37, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 3, 39, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 10, 47, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 11, 38, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 2, 11, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 18, 52, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 16, 58, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 12, 54, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 11, 15, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 1, 47, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 18, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 19, 11, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 14, 44, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 3, 46, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 2, 12, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 17, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 21, 25, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 8, 15, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 23, 23, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 6, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 7, 21, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 9, 1, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 16, 27, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 17, 9, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 21, 9, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 29, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 4, 24, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 23, 5, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 18, 27, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 20, 29, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 3, 32, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 1, 50, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 12, 40, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 16, 33, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 20, 40, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 5, 30, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 3, 1, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 11, 9, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 0, 59, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 6, 21, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 16, 50, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 8, 5, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 11, 34, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 2, 52, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 11, 20, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 17, 7, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 5, 4, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 42, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 0, 0, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 17, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 2, 34, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 9, 6, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 11, 45, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 17, 19, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 1, 7, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 10, 24, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 19, 9, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 6, 35, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 19, 5, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 3, 39, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 23, 33, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 37, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 13, 1, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 14, 13, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 3, 40, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 22, 36, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 22, 35, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 14, 56, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 9, 21, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 7, 49, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 7, 30, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 34, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 8, 16, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 19, 25, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 6, 53, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 20, 38, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 19, 48, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 15, 50, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 6, 58, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 19, 37, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 11, 7, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 22, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 0, 44, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 10, 35, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 7, 29, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 43, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 0, 59, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 6, 40, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 8, 10, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 2, 15, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 17, 56, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 31, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 9, 3, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 1, 49, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 12, 33, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 4, 31, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 17, 2, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 11, 49, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 4, 23, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 18, 35, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 0, 19, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 11, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 3, 42, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 14, 2, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 14, 6, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 52, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 18, 59, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 18, 12, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 19, 53, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 22, 6, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 2, 40, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 22, 14, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 7, 10, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 23, 16, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 17, 47, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 6, 56, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 9, 37, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 2, 18, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 13, 19, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 7, 52, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 3, 55, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 11, 11, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 13, 39, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 35, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 6, 1, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 6, 5, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 11, 32, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 8, 18, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 7, 5, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 3, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 20, 1, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 5, 35, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 0, 56, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 7, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 6, 48, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 2, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 0, 13, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 12, 9, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 11, 28, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 17, 19, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 2, 32, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 22, 41, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 5, 7, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 33, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 23, 28, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 6, 23, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 12, 31, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 4, 29, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 19, 48, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 18, 50, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 22, 50, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 9, 42, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 15, 37, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 5, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 4, 31, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 6, 36, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 18, 5, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 12, 28, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 9, 42, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 2, 10, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 16, 11, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 11, 48, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 5, 37, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 7, 46, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 11, 3, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 18, 3, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 22, 53, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 19, 48, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 11, 23, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 27, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 2, 10, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 7, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 22, 14, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 4, 54, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 0, 47, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 21, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 9, 47, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 11, 34, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 0, 9, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 35, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 22, 34, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 15, 50, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 23, 41, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 8, 11, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 3, 51, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 19, 12, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 21, 34, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 48, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 13, 59, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 20, 14, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 6, 27, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 17, 59, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 0, 0, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 9, 14, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 19, 41, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 6, 42, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 13, 50, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 33, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 11, 53, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 38, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 21, 7, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 11, 5, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 23, 35, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 11, 20, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 15, 17, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 29, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 3, 32, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 5, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 11, 7, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 4, 23, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 49, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 6, 34, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 9, 6, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 5, 29, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 2, 37, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 20, 49, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 9, 29, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 18, 23, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 20, 29, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 21, 30, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 5, 46, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 53, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 22, 34, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 5, 36, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 17, 20, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 19, 17, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 20, 7, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 13, 10, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 0, 47, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 4, 47, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 1, 10, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 1, 26, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 16, 48, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 2, 43, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 16, 54, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 3, 4, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 6, 24, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 17, 54, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 16, 0, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 10, 46, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 20, 3, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 12, 12, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 13, 56, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 8, 56, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 21, 2, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 19, 16, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 5, 23, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 3, 7, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 4, 8, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 15, 5, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 19, 3, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 20, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 13, 42, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 4, 3, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 14, 2, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 3, 7, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 1, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 4, 47, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 12, 58, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 20, 48, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 5, 54, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 11, 50, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 10, 29, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 7, 23, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 22, 11, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 16, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 6, 45, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 1, 3, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 12, 20, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 17, 41, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 19, 36, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 9, 27, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 20, 0, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 1, 5, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 18, 28, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 7, 29, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 10, 31, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 17, 15, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 16, 39, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 6, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 19, 1, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 7, 5, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 14, 18, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 23, 30, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 15, 29, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 15, 48, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 17, 5, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 3, 51, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 7, 23, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 21, 10, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 17, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 7, 33, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 3, 55, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 17, 23, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 23, 27, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 3, 49, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 9, 24, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 17, 20, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 12, 23, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 0, 34, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 1, 7, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 10, 53, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 21, 2, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 20, 3, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 3, 57, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 10, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 16, 22, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 6, 8, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 22, 34, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 23, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 11, 31, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 9, 24, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 8, 53, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 13, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 0, 11, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 0, 19, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 13, 23, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 4, 45, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 10, 15, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 2, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 22, 20, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 11, 38, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 3, 7, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 13, 50, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 0, 38, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 2, 23, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 14, 54, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 14, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 1, 23, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 14, 50, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 12, 40, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 22, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 9, 59, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 20, 20, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 1, 10, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 6, 23, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 23, 28, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 1, 44, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 18, 6, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 8, 42, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 13, 18, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 19, 10, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 6, 42, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 17, 12, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 2, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 5, 23, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 3, 9, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 17, 46, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 16, 26, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 7, 39, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 17, 56, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 16, 32, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 21, 42, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 7, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 16, 32, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 19, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 17, 41, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 5, 59, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 18, 35, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 10, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 15, 55, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 3, 28, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 15, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 8, 13, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 11, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 16, 55, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 17, 13, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 18, 18, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 6, 39, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 6, 4, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 3, 4, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 3, 21, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 4, 53, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 0, 39, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 11, 42, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 21, 52, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 2, 3, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 36, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 20, 14, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 7, 0, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 9, 31, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 14, 40, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 13, 14, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 2, 18, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 17, 59, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 15, 49, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 15, 36, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 2, 7, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 18, 34, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 12, 19, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 22, 7, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 21, 53, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 21, 48, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 9, 12, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 8, 58, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 21, 13, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 11, 30, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 6, 38, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 3, 28, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 8, 25, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 8, 8, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 14, 29, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 19, 15, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 12, 3, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 1, 47, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 9, 51, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 10, 46, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 12, 12, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 6, 20, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 13, 10, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 18, 6, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 14, 53, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 18, 11, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 10, 17, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 0, 47, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 10, 55, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 0, 46, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 12, 22, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 9, 13, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 5, 22, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 5, 42, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 42, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 10, 41, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 2, 3, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 12, 7, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 10, 59, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 7, 32, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 21, 59, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 13, 26, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 15, 44, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 2, 39, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 2, 53, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 12, 36, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 3, 49, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 10, 31, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 22, 8, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 20, 26, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 22, 26, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 21, 33, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 8, 22, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 2, 12, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 5, 33, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 9, 12, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 29, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 18, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 14, 54, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 16, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 8, 9, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 16, 45, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 25, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 0, 39, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 21, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 23, 49, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 23, 45, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 3, 48, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 4, 49, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 20, 31, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 11, 38, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 21, 33, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 7, 58, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 21, 52, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 6, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 20, 35, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 23, 26, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 20, 33, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 2, 43, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 21, 55, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 13, 29, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 22, 50, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 5, 11, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 5, 37, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 51, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 2, 18, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 20, 57, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 3, 9, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 58, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 7, 29, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 8, 8, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 22, 2, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 7, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 16, 6, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 13, 36, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 8, 16, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 4, 11, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 0, 0, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 19, 29, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 17, 40, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 21, 12, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 15, 28, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 8, 44, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 10, 23, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 23, 57, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 4, 3, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 17, 13, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 23, 6, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 44, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 6, 43, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 54, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 7, 15, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 13, 54, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 23, 13, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 17, 47, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 3, 1, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 9, 20, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 18, 51, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 38, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 11, 4, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 22, 45, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 14, 25, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 4, 47, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 16, 34, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 4, 0, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 8, 50, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 5, 10, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 20, 47, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 20, 32, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 22, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 59, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 22, 24, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 2, 14, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 2, 54, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 4, 37, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 22, 31, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 11, 16, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 17, 13, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 1, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 10, 48, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 1, 17, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 6, 26, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 2, 36, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 10, 0, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 7, 39, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 4, 17, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 13, 33, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 8, 6, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 16, 18, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 4, 38, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 5, 35, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 6, 29, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 6, 33, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 18, 34, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 13, 14, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 22, 12, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 1, 34, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 22, 50, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 4, 37, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 1, 3, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 1, 43, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 5, 58, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 16, 28, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 9, 1, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 6, 47, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 8, 28, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 20, 3, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 23, 12, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 21, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 18, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 8, 28, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 12, 26, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 13, 16, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 18, 30, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 7, 7, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 23, 6, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 1, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 6, 30, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 9, 46, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 3, 35, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 4, 11, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 15, 39, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 18, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 13, 8, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 12, 35, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 8, 0, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 27, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 6, 25, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 25, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 5, 21, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 4, 51, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 16, 12, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 9, 16, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 2, 42, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 4, 20, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 14, 54, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 0, 50, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 12, 41, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 23, 6, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 8, 18, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 7, 36, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 4, 30, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 11, 11, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 7, 8, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 25, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 22, 47, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 6, 34, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 17, 8, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 18, 53, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 20, 32, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 17, 9, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 6, 55, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 7, 55, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 13, 4, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 4, 17, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 0, 45, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 1, 13, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 13, 56, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 16, 16, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 9, 3, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 20, 58, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 11, 40, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 22, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 2, 48, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 1, 29, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 23, 6, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 5, 26, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 10, 31, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 37, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 12, 11, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 21, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 13, 48, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 18, 55, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 20, 49, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 6, 17, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 18, 27, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 19, 25, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 14, 2, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 2, 15, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 11, 33, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 8, 2, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 9, 45, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 20, 35, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 21, 22, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 19, 27, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 23, 44, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 10, 24, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 2, 47, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 5, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 3, 0, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 1, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 23, 39, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 17, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 8, 21, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 31, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 9, 52, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 21, 27, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 8, 57, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 18, 22, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 0, 45, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 41, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 20, 41, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 44, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 23, 8, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 8, 1, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 11, 20, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 20, 50, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 7, 38, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 4, 28, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 8, 47, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 8, 17, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 7, 45, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 15, 50, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 1, 56, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 18, 43, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 10, 0, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 43, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 50, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 8, 44, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 6, 0, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 15, 52, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 22, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 4, 41, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 5, 38, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 1, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 18, 57, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 14, 25, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 13, 27, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 14, 36, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 1, 33, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 31, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 22, 7, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 7, 7, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 19, 45, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 9, 49, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 5, 27, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 12, 6, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 4, 25, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 1, 55, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 12, 27, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 1, 6, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 21, 47, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 1, 22, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 21, 5, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 20, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 4, 19, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 10, 36, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 2, 35, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 4, 11, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 18, 6, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 21, 26, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 12, 7, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 2, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 17, 30, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 17, 59, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 16, 53, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 33, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 4, 59, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 1, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 21, 21, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 23, 16, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 2, 36, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 8, 53, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 13, 21, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 13, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 12, 15, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 5, 26, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 11, 40, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 23, 13, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 5, 33, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 19, 45, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 20, 56, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 23, 31, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 3, 38, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 38, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 5, 49, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 17, 37, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 2, 17, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 35, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 16, 59, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 29, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 19, 12, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 4, 6, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 1, 25, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 5, 10, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 23, 52, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 34, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 13, 4, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 11, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 19, 1, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 20, 30, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 7, 58, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 3, 23, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 17, 34, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 8, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 6, 40, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 12, 56, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 11, 11, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 20, 14, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 15, 29, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 7, 54, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 13, 31, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 23, 11, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 13, 7, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 15, 20, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 0, 26, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 5, 7, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 0, 46, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 25, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 15, 42, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 6, 15, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 9, 47, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 51, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 21, 38, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 3, 42, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 4, 50, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 18, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 14, 36, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 3, 22, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 12, 58, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 8, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 19, 48, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 19, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 19, 3, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 11, 8, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 17, 57, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 12, 22, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 7, 46, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 9, 47, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 21, 35, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 9, 57, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 9, 32, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 18, 23, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 9, 18, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 20, 6, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 5, 6, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 13, 14, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 4, 28, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 9, 28, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 20, 21, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 4, 34, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 9, 38, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 4, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 11, 25, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 5, 40, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 1, 39, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 50, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 17, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 6, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 15, 24, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 10, 25, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 20, 18, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 9, 35, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 12, 9, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 23, 14, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 2, 46, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 17, 25, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 13, 7, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 7, 41, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 14, 38, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 16, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 6, 47, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 21, 8, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 10, 44, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 57, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 10, 5, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 7, 16, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 4, 7, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 13, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 18, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 6, 20, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 20, 2, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 2, 37, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 2, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 21, 16, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 11, 30, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 12, 14, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 19, 50, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 17, 5, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 18, 47, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 10, 45, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 2, 8, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 23, 34, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 21, 14, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 27, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 7, 38, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 12, 12, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 20, 1, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 22, 56, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 17, 47, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 15, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 15, 37, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 14, 15, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 0, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 5, 45, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 15, 20, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 10, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 16, 41, 21, 0, DateTimeKind.Unspecified) });
        }
    }
}
