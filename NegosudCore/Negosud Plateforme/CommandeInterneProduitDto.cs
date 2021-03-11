using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class CommandeInterneProduitDto
    {
        public long idCommandeInterne { get; set; }
        public long idProduit { get; set; }
        public int quantite { get; set; }
  

    }

    class Datalist_Commande_Interne_Produit
    {
        public List<CommandeInterneProduitDto> ListcommandeInterneProduit { get; set; }
    }
}
