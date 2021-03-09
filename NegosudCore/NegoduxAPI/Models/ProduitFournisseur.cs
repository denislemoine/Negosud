using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoduxAPI.Models
{
    public class ProduitFournisseur
    {
        public long Id { get; set; }
        public int IdProduit { get; set; }
        public int IdFournisseur { get; set; }
    }
}
