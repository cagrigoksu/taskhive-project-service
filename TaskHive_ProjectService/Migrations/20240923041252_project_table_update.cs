using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskHive_ProjectService.Migrations
{
    /// <inheritdoc />
    public partial class project_table_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Manager",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "Team",
                table: "Projects",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "Projects",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "NumberOfMembers",
                table: "Projects",
                newName: "StatusId");

            migrationBuilder.AddColumn<float>(
                name: "Budget",
                table: "Projects",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "CreateUser",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Projects",
                newName: "NumberOfMembers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Projects",
                newName: "Team");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Projects",
                newName: "ProjectName");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
