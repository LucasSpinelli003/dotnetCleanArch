using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CP3.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "tb_barco");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "tb_barco",
                newName: "Tamanho");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tb_barco",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modelo",
                table: "tb_barco",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "tb_barco");

            migrationBuilder.RenameColumn(
                name: "Tamanho",
                table: "tb_barco",
                newName: "Preco");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tb_barco",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "tb_barco",
                type: "NVARCHAR2(2000)",
                nullable: true);
        }
    }
}
