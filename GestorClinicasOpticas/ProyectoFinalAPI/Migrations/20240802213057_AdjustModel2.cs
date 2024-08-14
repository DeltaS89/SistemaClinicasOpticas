using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdjustModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examenes_Doctores_DoctorId",
                table: "Examenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Examenes_Pacientes_PacienteId",
                table: "Examenes");

            migrationBuilder.AddForeignKey(
                name: "FK_Examenes_Doctores_DoctorId",
                table: "Examenes",
                column: "DoctorId",
                principalTable: "Doctores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Examenes_Pacientes_PacienteId",
                table: "Examenes",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examenes_Doctores_DoctorId",
                table: "Examenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Examenes_Pacientes_PacienteId",
                table: "Examenes");

            migrationBuilder.AddForeignKey(
                name: "FK_Examenes_Doctores_DoctorId",
                table: "Examenes",
                column: "DoctorId",
                principalTable: "Doctores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Examenes_Pacientes_PacienteId",
                table: "Examenes",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
