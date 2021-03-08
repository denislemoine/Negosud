using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoduxAPI.Models
{
    public class Commande
    {
        public long Id { get; set; }
        public long IdProduit { get; set; }
        public long IdFamille { get; set; }
        public long IdClient { get; set; }
        public int PrixTotal { get; set; }
        public DateTime DateCommande { get; set; }
        public bool IsActive { get; set; }
        public int Quantite { get; set; }
        public string Status { get; set; }
    }
}
