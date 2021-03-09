using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NegoduxAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<long>(type: "bigint", nullable: false),
                    PrixTotal = table.Column<float>(type: "real", nullable: false),
                    DateCommande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommandeInterne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrixTotal = table.Column<float>(type: "real", nullable: false),
                    DateCommande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandeInterne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommandeInterneProduit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCommandeInterne = table.Column<int>(type: "int", nullable: false),
                    IdProduit = table.Column<int>(type: "int", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandeInterneProduit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommandeProduit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCommande = table.Column<int>(type: "int", nullable: false),
                    IdProduit = table.Column<int>(type: "int", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandeProduit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Famille",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Famille", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEntreprise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFamille = table.Column<long>(type: "bigint", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Millesime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    PrixFournisseur = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domaine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contenant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CommandeAuto = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProduitFournisseur",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduit = table.Column<int>(type: "int", nullable: false),
                    IdFournisseur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitFournisseur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduit = table.Column<long>(type: "bigint", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    QuantiteCommande = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "CommandeInterne");

            migrationBuilder.DropTable(
                name: "CommandeInterneProduit");

            migrationBuilder.DropTable(
                name: "CommandeProduit");

            migrationBuilder.DropTable(
                name: "Famille");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "ProduitFournisseur");

            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
