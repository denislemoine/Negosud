using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NegoduxAPI.Models;

namespace NegoduxAPI.Data
{
    public class NegoduxAPIContext : DbContext
    {
        public NegoduxAPIContext (DbContextOptions<NegoduxAPIContext> options)
            : base(options)
        {
        }

        public DbSet<NegoduxAPI.Models.Client> Client { get; set; }

        public DbSet<NegoduxAPI.Models.Commande> Commande { get; set; }

        public DbSet<NegoduxAPI.Models.Famille> Famille { get; set; }

        public DbSet<NegoduxAPI.Models.Fournisseur> Fournisseur { get; set; }

        public DbSet<NegoduxAPI.Models.Produit> Produit { get; set; }

        public DbSet<NegoduxAPI.Models.Stock> Stock { get; set; }
    }
}
