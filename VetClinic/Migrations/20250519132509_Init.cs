using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VetClinic.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adresy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Miasto = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Ulica = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Nr_ulicy = table.Column<int>(type: "integer", nullable: false),
                    Nr_lokalu = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adresy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "leki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nazwa = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Ilosc = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leki", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "osoby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Imie = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Data_ur = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Telefon = table.Column<string>(type: "text", nullable: false),
                    Lekarz = table.Column<bool>(type: "boolean", nullable: false),
                    AdresId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_osoby", x => x.Id);
                    table.ForeignKey(
                        name: "FK_osoby_adresy_AdresId",
                        column: x => x.AdresId,
                        principalTable: "adresy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "zamowienia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LekId = table.Column<int>(type: "integer", nullable: false),
                    Ilosc = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zamowienia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_zamowienia_leki_LekId",
                        column: x => x.LekId,
                        principalTable: "leki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lekarze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Specjalizacja = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Tryb = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lekarze", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lekarze_osoby_Id",
                        column: x => x.Id,
                        principalTable: "osoby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "zwierzeta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Imie = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Gatunek = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Typ = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Wiek = table.Column<int>(type: "integer", nullable: false),
                    WlascicielId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zwierzeta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_zwierzeta_osoby_WlascicielId",
                        column: x => x.WlascicielId,
                        principalTable: "osoby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wizyty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ZwierzeId = table.Column<int>(type: "integer", nullable: false),
                    LekarzId = table.Column<int>(type: "integer", nullable: false),
                    Tryb = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Opis = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wizyty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wizyty_lekarze_LekarzId",
                        column: x => x.LekarzId,
                        principalTable: "lekarze",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wizyty_zwierzeta_ZwierzeId",
                        column: x => x.ZwierzeId,
                        principalTable: "zwierzeta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WizytaLek",
                columns: table => new
                {
                    LekId = table.Column<int>(type: "integer", nullable: false),
                    WizytaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WizytaLek", x => new { x.LekId, x.WizytaId });
                    table.ForeignKey(
                        name: "FK_WizytaLek_leki_LekId",
                        column: x => x.LekId,
                        principalTable: "leki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WizytaLek_wizyty_WizytaId",
                        column: x => x.WizytaId,
                        principalTable: "wizyty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_osoby_AdresId",
                table: "osoby",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_WizytaLek_WizytaId",
                table: "WizytaLek",
                column: "WizytaId");

            migrationBuilder.CreateIndex(
                name: "IX_wizyty_LekarzId",
                table: "wizyty",
                column: "LekarzId");

            migrationBuilder.CreateIndex(
                name: "IX_wizyty_ZwierzeId",
                table: "wizyty",
                column: "ZwierzeId");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienia_LekId",
                table: "zamowienia",
                column: "LekId");

            migrationBuilder.CreateIndex(
                name: "IX_zwierzeta_WlascicielId",
                table: "zwierzeta",
                column: "WlascicielId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WizytaLek");

            migrationBuilder.DropTable(
                name: "zamowienia");

            migrationBuilder.DropTable(
                name: "wizyty");

            migrationBuilder.DropTable(
                name: "leki");

            migrationBuilder.DropTable(
                name: "lekarze");

            migrationBuilder.DropTable(
                name: "zwierzeta");

            migrationBuilder.DropTable(
                name: "osoby");

            migrationBuilder.DropTable(
                name: "adresy");
        }
    }
}
