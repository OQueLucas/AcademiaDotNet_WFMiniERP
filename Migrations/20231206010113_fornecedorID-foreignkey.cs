using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaDotNet_WFMiniERP.Migrations
{
    public partial class fornecedorIDforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedorID",
                table: "Produtos");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedorID",
                table: "Produtos",
                column: "FornecedorID",
                principalTable: "Fornecedores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedorID",
                table: "Produtos");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedorID",
                table: "Produtos",
                column: "FornecedorID",
                principalTable: "Fornecedores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
