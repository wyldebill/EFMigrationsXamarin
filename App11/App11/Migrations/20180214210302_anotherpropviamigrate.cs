using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App11
{
    public partial class anotherpropviamigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ANOTHERNEWPROP",
                table: "Dogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ANOTHERNEWPROP",
                table: "Dogs");
        }
    }
}
