using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoduxAPI.Models
{
    public class CommandeProduit
    {
        public long Id { get; set; }
        public int IdCommande { get; set; }
        public int IdProduit { get; set; }
        public int Quantite { get; set; }
    }
}
