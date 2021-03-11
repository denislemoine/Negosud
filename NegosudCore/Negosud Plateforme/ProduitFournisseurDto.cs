using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class ProduitFournisseurDto
    {
 
        public long idProduit { get; set; }
        public int idFournisseur { get; set; }

    }


    class Datalist_Produit_Fournisseur
    {
        public List<CommandeInterneDto> ListProduitFournisseur { get; set; }
    }
}
