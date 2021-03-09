using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoduxAPI.Models
{
    public class Stock
    {
        public long Id { get; set; }
        public long IdProduit { get; set; }
        public int Quantite { get; set; }
        public int QuantiteCommande { get; set; }
    }
}
