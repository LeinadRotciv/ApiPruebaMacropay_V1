using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPruebaMacropay.Migrations
{
    /// <inheritdoc />
    public partial class ApiPruebaMacropayDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idProveedor",
                table: "RecepcionMaterial",
                newName: "ProveedorId");

            migrationBuilder.RenameColumn(
                name: "idMaterial",
                table: "RecepcionMaterial",
                newName: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_RecepcionMaterial_MaterialId",
                table: "RecepcionMaterial",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_RecepcionMaterial_ProveedorId",
                table: "RecepcionMaterial",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecepcionMaterial_Material_MaterialId",
                table: "RecepcionMaterial",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecepcionMaterial_Proveedor_ProveedorId",
                table: "RecepcionMaterial",
                column: "ProveedorId",
                principalTable: "Proveedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecepcionMaterial_Material_MaterialId",
                table: "RecepcionMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_RecepcionMaterial_Proveedor_ProveedorId",
                table: "RecepcionMaterial");

            migrationBuilder.DropIndex(
                name: "IX_RecepcionMaterial_MaterialId",
                table: "RecepcionMaterial");

            migrationBuilder.DropIndex(
                name: "IX_RecepcionMaterial_ProveedorId",
                table: "RecepcionMaterial");

            migrationBuilder.RenameColumn(
                name: "ProveedorId",
                table: "RecepcionMaterial",
                newName: "idProveedor");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "RecepcionMaterial",
                newName: "idMaterial");
        }
    }
}
