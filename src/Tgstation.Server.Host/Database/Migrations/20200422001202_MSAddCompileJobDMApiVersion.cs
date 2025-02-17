﻿using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Tgstation.Server.Host.Database.Migrations
{
	/// <summary>
	/// Add fields for the <see cref="Models.CompileJob.DMApiVersion"/> property for MSSQL.
	/// </summary>
	public partial class MSAddCompileJobDMApiVersion : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			if (migrationBuilder == null)
				throw new ArgumentNullException(nameof(migrationBuilder));

			migrationBuilder.DropColumn(
				name: "ServerCommandsJson",
				table: "ReattachInformations");

			migrationBuilder.AddColumn<int>(
				name: "DMApiMajorVersion",
				table: "CompileJobs",
				nullable: true);

			migrationBuilder.AddColumn<int>(
				name: "DMApiMinorVersion",
				table: "CompileJobs",
				nullable: true);

			migrationBuilder.AddColumn<int>(
				name: "DMApiPatchVersion",
				table: "CompileJobs",
				nullable: true);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			if (migrationBuilder == null)
				throw new ArgumentNullException(nameof(migrationBuilder));

			migrationBuilder.DropColumn(
				name: "DMApiMajorVersion",
				table: "CompileJobs");

			migrationBuilder.DropColumn(
				name: "DMApiMinorVersion",
				table: "CompileJobs");

			migrationBuilder.DropColumn(
				name: "DMApiPatchVersion",
				table: "CompileJobs");

			migrationBuilder.AddColumn<string>(
				name: "ServerCommandsJson",
				table: "ReattachInformations",
				nullable: false,
				defaultValue: "server_commands.tgs.json");
		}
	}
}
