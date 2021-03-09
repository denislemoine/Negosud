using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoduxAPI.Models
{
    public class CommandeInterneProduit
    {
        public int IdCommandeInterne { get; set; }
        public int IdProduit { get; set; }
        public int Quantite { get; set; }
    }
}
