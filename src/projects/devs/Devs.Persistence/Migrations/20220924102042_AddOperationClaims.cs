﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Devs.Persistence.Migrations
{
    public partial class AddOperationClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOperationClaim_OperationClaim_OperationClaimId",
                table: "UserOperationClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOperationClaim_Users_UserId",
                table: "UserOperationClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOperationClaim",
                table: "UserOperationClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OperationClaim",
                table: "OperationClaim");

            migrationBuilder.RenameTable(
                name: "UserOperationClaim",
                newName: "UserOperationClaims");

            migrationBuilder.RenameTable(
                name: "OperationClaim",
                newName: "OperationClaims");

            migrationBuilder.RenameIndex(
                name: "IX_UserOperationClaim_UserId",
                table: "UserOperationClaims",
                newName: "IX_UserOperationClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOperationClaim_OperationClaimId",
                table: "UserOperationClaims",
                newName: "IX_UserOperationClaims_OperationClaimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOperationClaims",
                table: "UserOperationClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OperationClaims",
                table: "OperationClaims",
                column: "Id");

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "admin" });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "developer" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId",
                principalTable: "OperationClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperationClaims_Users_UserId",
                table: "UserOperationClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                table: "UserOperationClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOperationClaims_Users_UserId",
                table: "UserOperationClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOperationClaims",
                table: "UserOperationClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OperationClaims",
                table: "OperationClaims");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "UserOperationClaims",
                newName: "UserOperationClaim");

            migrationBuilder.RenameTable(
                name: "OperationClaims",
                newName: "OperationClaim");

            migrationBuilder.RenameIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaim",
                newName: "IX_UserOperationClaim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaim",
                newName: "IX_UserOperationClaim_OperationClaimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOperationClaim",
                table: "UserOperationClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OperationClaim",
                table: "OperationClaim",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperationClaim_OperationClaim_OperationClaimId",
                table: "UserOperationClaim",
                column: "OperationClaimId",
                principalTable: "OperationClaim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperationClaim_Users_UserId",
                table: "UserOperationClaim",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
