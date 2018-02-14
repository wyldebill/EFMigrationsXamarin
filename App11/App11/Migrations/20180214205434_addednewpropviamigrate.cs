using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App11
{
    public partial class addednewpropviamigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NEWPROPERTYVIAMIGRATE",
                table: "Dogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NEWPROPERTYVIAMIGRATE",
                table: "Dogs");
        }
    }
}
