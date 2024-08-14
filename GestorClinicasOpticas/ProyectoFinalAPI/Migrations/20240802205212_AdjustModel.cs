using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdjustModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examenes_Doctores_DoctorId",
                table: "Examenes");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Examenes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Examenes_Doctores_DoctorId",
                table: "Examenes",
                column: "DoctorId",
                principalTable: "Doctores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examenes_Doctores_DoctorId",
                table: "Examenes");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Examenes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Examenes_Doctores_DoctorId",
                table: "Examenes",
                column: "DoctorId",
                principalTable: "Doctores",
                principalColumn: "Id");
        }
    }
}
