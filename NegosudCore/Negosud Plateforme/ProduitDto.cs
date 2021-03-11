using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class ProduitDto
    {
        public long id { get; set; }
        public long idFamille { get; set; }
        public string nom { get; set; }
        public string millesime { get; set; }
        public int prix { get; set; }
        public int prixFournisseur { get; set; }
        public string description { get; set; }
        public string domaine { get; set; }
        public string urlPhoto { get; set; }
        public string contenant { get; set; }
        public bool isActive { get; set; }
        public bool commandeAuto { get; set; }
    }


 

    class Datalist_Produits
    {
        public List<ProduitDto> Listproduit { get; set; }
    }
}
