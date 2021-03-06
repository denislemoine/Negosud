using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoduxAPI.Models
{
    public class Produit
    {
        public long Id { get; set; }
        public long IdFamille { get; set; }
        public string Nom { get; set; }
        public string Millesime { get; set; }
        public float Prix { get; set; }
        public float PrixFournisseur { get; set; }
        public string Description { get; set; }
        public string Domaine { get; set; }
        public string UrlPhoto { get; set; }
        public string Contenant { get; set; }
        public bool IsActive { get; set; }
        public bool CommandeAuto { get; set; }
    }
}
