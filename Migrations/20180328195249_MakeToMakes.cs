﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AngularWebApp.Migrations
{
    public partial class MakeToMakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Makes_MakeId",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Makes",
                table: "Makes");

            migrationBuilder.RenameTable(
                name: "Makes",
                newName: "Models");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Models_MakeId",
                table: "Model",
                column: "MakeId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Models_MakeId",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Makes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Makes",
                table: "Makes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Makes_MakeId",
                table: "Model",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
