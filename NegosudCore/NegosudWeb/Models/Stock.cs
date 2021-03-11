using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NegosudWeb.Models
{
    public class Stock
    {
        public long Id { get; set; }
        public long IdProduit { get; set; }
        public int Quantite { get; set; }
        public int QuantiteCommande { get; set; }

    }
}