using Microsoft.EntityFrameworkCore.Migrations;

namespace UrunStok1.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunAdi = table.Column<string>(nullable: true),
                    Stok = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Fiyat = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Urun",
                columns: new[] { "Id", "Aciklama", "Fiyat", "Stok", "UrunAdi" },
                values: new object[] { 1001, "Oyun bilgisayarı", 10000.0, 20, "Laptop" });

            migrationBuilder.InsertData(
                table: "Urun",
                columns: new[] { "Id", "Aciklama", "Fiyat", "Stok", "UrunAdi" },
                values: new object[] { 1002, "Office Application", 500.0, 99, "Microsoft Office" });

            migrationBuilder.InsertData(
                table: "Urun",
                columns: new[] { "Id", "Aciklama", "Fiyat", "Stok", "UrunAdi" },
                values: new object[] { 1003, " ", 2000.0, 12, "Lazer Mouse" });

            migrationBuilder.InsertData(
                table: "Urun",
                columns: new[] { "Id", "Aciklama", "Fiyat", "Stok", "UrunAdi" },
                values: new object[] { 1004, "64GB", 200.0, 5, "USB Storage" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urun");
        }
    }
}
