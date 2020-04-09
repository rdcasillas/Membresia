using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Membresia.Data.Migrations
{
    public partial class AddCatalogosPersonasHistoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblBautismo",
                columns: table => new
                {
                    IdBautismo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaBautismo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBautismo", x => x.IdBautismo);
                });

            migrationBuilder.CreateTable(
                name: "tblEscolaridad",
                columns: table => new
                {
                    IdEscolaridad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Escolaridad = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEscolaridad", x => x.IdEscolaridad);
                });

            migrationBuilder.CreateTable(
                name: "tblEstadoCivil",
                columns: table => new
                {
                    IdEstadoCivil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoCivil = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEstadoCivil", x => x.IdEstadoCivil);
                });

            migrationBuilder.CreateTable(
                name: "tblEstatus",
                columns: table => new
                {
                    IdEstatus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estatus = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEstatus", x => x.IdEstatus);
                });

            migrationBuilder.CreateTable(
                name: "tblFamilia",
                columns: table => new
                {
                    IdFamilia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Familia = table.Column<string>(nullable: false),
                    IDiglesia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFamilia", x => x.IdFamilia);
                    table.ForeignKey(
                        name: "FK_tblFamilia_Iglesias_IDiglesia",
                        column: x => x.IDiglesia,
                        principalTable: "Iglesias",
                        principalColumn: "IDiglesia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblTipoMiembro",
                columns: table => new
                {
                    IdMiembro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMiembro = table.Column<string>(nullable: false),
                    IDiglesia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTipoMiembro", x => x.IdMiembro);
                    table.ForeignKey(
                        name: "FK_tblTipoMiembro_Iglesias_IDiglesia",
                        column: x => x.IDiglesia,
                        principalTable: "Iglesias",
                        principalColumn: "IDiglesia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 200, nullable: false),
                    ApPaterno = table.Column<string>(maxLength: 200, nullable: false),
                    ApMaterno = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 12, nullable: true),
                    CorreoElectronico = table.Column<string>(maxLength: 100, nullable: true),
                    Calle = table.Column<string>(maxLength: 200, nullable: true),
                    colonia = table.Column<string>(maxLength: 50, nullable: true),
                    Ciudad = table.Column<string>(maxLength: 50, nullable: true),
                    CP = table.Column<int>(nullable: true),
                    Oficio = table.Column<string>(maxLength: 50, nullable: true),
                    Notas = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    NotasMedicas = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    RutaFoto = table.Column<string>(nullable: true),
                    idsexo = table.Column<int>(nullable: true),
                    IdEstadoCivil = table.Column<int>(nullable: true),
                    IdEscolaridad = table.Column<int>(nullable: true),
                    IDiglesia = table.Column<int>(nullable: false),
                    IdMiembro = table.Column<int>(nullable: true),
                    IdFamilia = table.Column<int>(nullable: true),
                    IdBautismo = table.Column<int>(nullable: true),
                    idEstatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_Personas_Iglesias_IDiglesia",
                        column: x => x.IDiglesia,
                        principalTable: "Iglesias",
                        principalColumn: "IDiglesia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_tblBautismo_IdBautismo",
                        column: x => x.IdBautismo,
                        principalTable: "tblBautismo",
                        principalColumn: "IdBautismo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_tblEstadoCivil_IdEstadoCivil",
                        column: x => x.IdEstadoCivil,
                        principalTable: "tblEstadoCivil",
                        principalColumn: "IdEstadoCivil",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_tblFamilia_IdFamilia",
                        column: x => x.IdFamilia,
                        principalTable: "tblFamilia",
                        principalColumn: "IdFamilia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_tblTipoMiembro_IdMiembro",
                        column: x => x.IdMiembro,
                        principalTable: "tblTipoMiembro",
                        principalColumn: "IdMiembro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_tblEstatus_idEstatus",
                        column: x => x.idEstatus,
                        principalTable: "tblEstatus",
                        principalColumn: "IdEstatus",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPersonasHistorial",
                columns: table => new
                {
                    IdCambio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCambio = table.Column<DateTime>(nullable: false),
                    IdPersona = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 200, nullable: false),
                    ApPaterno = table.Column<string>(maxLength: 200, nullable: false),
                    ApMaterno = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 12, nullable: true),
                    CorreoElectronico = table.Column<string>(maxLength: 100, nullable: true),
                    Calle = table.Column<string>(maxLength: 200, nullable: true),
                    colonia = table.Column<string>(maxLength: 50, nullable: true),
                    Ciudad = table.Column<string>(maxLength: 50, nullable: true),
                    CP = table.Column<int>(nullable: false),
                    Oficio = table.Column<string>(maxLength: 50, nullable: true),
                    Notas = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    NotasMedicas = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    RutaFoto = table.Column<string>(nullable: true),
                    idsexo = table.Column<int>(nullable: false),
                    IdEstadoCivil = table.Column<int>(nullable: true),
                    IdEscolaridad = table.Column<int>(nullable: true),
                    IDiglesia = table.Column<int>(nullable: false),
                    IdMiembro = table.Column<int>(nullable: false),
                    IdFamilia = table.Column<int>(nullable: true),
                    IdBautismo = table.Column<int>(nullable: false),
                    idEstatus = table.Column<int>(nullable: false),
                    FechaEstatus = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPersonasHistorial", x => x.IdCambio);
                    table.ForeignKey(
                        name: "FK_tblPersonasHistorial_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IDiglesia",
                table: "Personas",
                column: "IDiglesia");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdBautismo",
                table: "Personas",
                column: "IdBautismo");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdEstadoCivil",
                table: "Personas",
                column: "IdEstadoCivil");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdFamilia",
                table: "Personas",
                column: "IdFamilia");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdMiembro",
                table: "Personas",
                column: "IdMiembro");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_idEstatus",
                table: "Personas",
                column: "idEstatus");

            migrationBuilder.CreateIndex(
                name: "IX_tblFamilia_IDiglesia",
                table: "tblFamilia",
                column: "IDiglesia");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersonasHistorial_IdPersona",
                table: "tblPersonasHistorial",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_tblTipoMiembro_IDiglesia",
                table: "tblTipoMiembro",
                column: "IDiglesia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEscolaridad");

            migrationBuilder.DropTable(
                name: "tblPersonasHistorial");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "tblBautismo");

            migrationBuilder.DropTable(
                name: "tblEstadoCivil");

            migrationBuilder.DropTable(
                name: "tblFamilia");

            migrationBuilder.DropTable(
                name: "tblTipoMiembro");

            migrationBuilder.DropTable(
                name: "tblEstatus");
        }
    }
}
